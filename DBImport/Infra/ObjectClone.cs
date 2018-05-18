using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace Api.Engines.Venda.Infra
{
    public static class ObjectClone
    {
        public static T DoClone<T>(T objeto)
        {
            var newObject = Activator.CreateInstance<T>();
            var properties = newObject.GetType().GetProperties(BindingFlags.Public
                | BindingFlags.Instance);
            foreach (var property in properties)
            {                
                if (property.PropertyType.GetInterfaces().Any(t => t.IsGenericType && t.GetGenericTypeDefinition() == typeof(IEnumerable<>)) && 
                    property.PropertyType.FullName != typeof(string).FullName)
                {
                    var genericType = property.PropertyType.GetGenericTypeDefinition();
                    dynamic value = Activator.CreateInstance(genericType.MakeGenericType(property.PropertyType.GetGenericArguments()));
                    dynamic collection = property.GetValue(objeto);
                    if (collection != null)
                    {
                        value.AddRange(collection);
                        property.SetValue(newObject, value);
                    }
                }
                else
                {
                    var value = property.GetValue(objeto);
                    property.SetValue(newObject, value);
                }
            }
            return newObject;
        }      
    }
}
