using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;
using System.Web.Routing;
using System.Web.SessionState;

namespace INC.Web.Mvc.Infrastructure.ControllerFactory
{
    public class SessionStateControllerFactory : DefaultControllerFactory
    {
        private object _lockObject = new object();
        private ConcurrentDictionary<Type, Dictionary<string, Dictionary<MethodInfo, MethodAttributeCache>>> _controllerActionCache = new ConcurrentDictionary<Type, Dictionary<string, Dictionary<MethodInfo, MethodAttributeCache>>>();
        protected override SessionStateBehavior GetControllerSessionBehavior(RequestContext requestContext, Type controllerType)
        {
            if (controllerType == null)
                return SessionStateBehavior.Default;

            Dictionary<string, Dictionary<MethodInfo, MethodAttributeCache>> methodInfos = null;
            if (!_controllerActionCache.TryGetValue(controllerType, out methodInfos))
            {
                lock (_lockObject)
                {
                    methodInfos = GetActionSessionActionFromController(controllerType);
                    _controllerActionCache.AddOrUpdate(controllerType, methodInfos, (x, y) => y);
                }
            }

            var actionName = requestContext.RouteData.Values["action"].ToString();
            if (methodInfos != null && methodInfos.ContainsKey(actionName))
            {
                var validatePassActions = new Dictionary<MethodInfo, MethodAttributeCache>();
                foreach (var item in methodInfos[actionName])
                {
                    var actionSelectResult = false;
                    if (item.Value.ActionMethodSelectors != null && item.Value.ActionMethodSelectors.Count > 0)
                    {
                        var controllerContext = new ControllerContext(requestContext, this.GetControllerInstance(requestContext, controllerType) as Controller);
                        foreach (var actionSelector in item.Value.ActionMethodSelectors)
                        {
                            if (actionSelector.IsValidForRequest(controllerContext, item.Key))
                            {
                                actionSelectResult = true;
                                break;
                            }
                        }
                    }
                    else
                    {
                        actionSelectResult = true;
                    }

                    if (actionSelectResult && item.Value.ActionSessionState != null)
                    {
                        validatePassActions.Add(item.Key, item.Value);
                    }
                }

                if (validatePassActions.Count > 0)
                {
                    return validatePassActions.First().Value.ActionSessionState.Behavior;
                }
            }

            return base.GetControllerSessionBehavior(requestContext, controllerType);
        }

        private Dictionary<string, Dictionary<MethodInfo, MethodAttributeCache>> GetActionSessionActionFromController(Type controllerType)
        {
            var dic = new Dictionary<string, Dictionary<MethodInfo, MethodAttributeCache>>(StringComparer.InvariantCultureIgnoreCase);
            var methods = controllerType.GetMethods(BindingFlags.IgnoreCase | BindingFlags.Public | BindingFlags.Instance);
            foreach (var method in methods)
            {
                var actionName = method.Name;
                if (!(typeof(ActionResult)).IsAssignableFrom(method.ReturnType))
                    continue;

                var customAttribute = method.GetCustomAttributes(true);
                var actionSessionAttribute = customAttribute.OfType<ActionSessionStateAttribute>().FirstOrDefault();
                if (actionSessionAttribute == null)
                    continue;

                var methodAttributeCache = new MethodAttributeCache();
                methodAttributeCache.ActionSessionState = actionSessionAttribute;
                foreach (var item in customAttribute)
                {
                    var attributeType = item.GetType();
                    if (typeof(ActionMethodSelectorAttribute).IsAssignableFrom(attributeType))
                    {
                        methodAttributeCache.ActionMethodSelectors.Add(item as ActionMethodSelectorAttribute);
                    }

                    if (typeof(ActionNameAttribute).IsAssignableFrom(attributeType))
                    {
                        actionName = (item as ActionNameAttribute).Name;
                    }
                }

                if (dic.ContainsKey(actionName))
                {
                    var cacheItem = dic[actionName];
                    cacheItem.Add(method, methodAttributeCache);
                }
                else
                {
                    var cacheItem = new Dictionary<MethodInfo, MethodAttributeCache>();
                    cacheItem.Add(method, methodAttributeCache);
                    dic.Add(actionName, cacheItem);
                }
            }

            return dic;
        }

        private sealed class MethodAttributeCache
        {
            public MethodAttributeCache()
            {
                this.ActionMethodSelectors = new List<ActionMethodSelectorAttribute>();
            }
            public List<ActionMethodSelectorAttribute> ActionMethodSelectors { get; set; }

            public ActionSessionStateAttribute ActionSessionState { get; set; }
        }
    }

    [AttributeUsage(AttributeTargets.Method, AllowMultiple = false, Inherited = true)]
    public sealed class ActionSessionStateAttribute : Attribute
    {
        public SessionStateBehavior Behavior { get; private set; }
        public ActionSessionStateAttribute(SessionStateBehavior behavior)
        {
            this.Behavior = behavior;
        }
    }
}
