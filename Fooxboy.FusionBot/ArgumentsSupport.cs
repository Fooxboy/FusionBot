using Fooxboy.FusionBot.Models;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;
using System.Linq;

namespace Fooxboy.FusionBot
{
    public class ArgumentsSupport
    {
        public static object FindMethod(List<object> arguments, string @namespace, MessageVK msg, object data)
        {
            if (arguments == null) return null;
            if (arguments.Count == 0) return null;


            //Получаем список всех классов в неймспейсе.
            var classes = Assembly.GetExecutingAssembly()
                .GetTypes().Where(t => t.Namespace == @namespace).ToList();
            foreach (var @class in classes)
            {
                var methods = @class.GetMethods();
                foreach (var method in methods)
                {
                    var customAttributes = method.GetCustomAttributes();
                    foreach (var customAttribute in customAttributes)
                    {
                        if (customAttribute.GetType() == typeof(ArgumentAttribute))
                        {
                            var attribute = (ArgumentAttribute)customAttribute;
                            if (attribute.Argument == (string)arguments[0])
                            {
                                var o = Activator.CreateInstance(@class);
                                var result = method.Invoke(o, new object[] { msg, data });
                                return result;
                            }
                        }
                    }
                }
            }

            return null;
        }
    }
}
