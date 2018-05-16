using System;
using System.ComponentModel;
using System.Reflection;

namespace Api.Engines.Venda.Extensions
{
    public static class ExtensaoEnum
    {
        public static string GetDescription(this Enum value)
        {
            if (value == null)
                return null;

            FieldInfo fi = value.GetType().GetField(value.ToString());
            if (fi == null)
                return null;

            object[] attributesObject = fi.GetCustomAttributes(typeof(DescriptionAttribute), false);
            var attributes = (DescriptionAttribute[])attributesObject;

            return attributes.Length > 0 ? attributes[0].Description : value.ToString();
        }
    }
}
