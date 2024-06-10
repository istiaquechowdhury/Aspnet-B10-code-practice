using System;
using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

public class JsonFormatter
{
    public static string Convert(object item)
    {
        StringBuilder json = new StringBuilder();
        ConvertItem(item, json);
        return json.ToString();
    }

    private static void ConvertItem(object item, StringBuilder json)
    {
        if (item == null)
        {
            json.Append("null");
            return;
        }

        Type itemType = item.GetType();

        // Handle primitive types
        if (itemType.IsPrimitive || itemType == typeof(string) || itemType == typeof(decimal) || itemType == typeof(DateTime))
        {
            AppendPrimitiveValue(item, json);
            return;
        }

        // Handle arrays and lists
        if (item is IEnumerable enumerable)
        {
            json.Append("[");
            bool first = true;
            foreach (var element in enumerable)
            {
                if (!first)
                    json.Append(",");
                ConvertItem(element, json);
                first = false;
            }
            json.Append("]");
            return;
        }

        // Handle objects
        json.Append("{");
        PropertyInfo[] properties = itemType.GetProperties(BindingFlags.Public | BindingFlags.Instance);
        bool firstProp = true;
        foreach (var prop in properties)
        {
            if (!firstProp)
                json.Append(",");
            json.Append($"\"{prop.Name}\":");
            ConvertItem(prop.GetValue(item), json);
            firstProp = false;
        }
        json.Append("}");
    }

    private static void AppendPrimitiveValue(object value, StringBuilder json)
    {
        if (value is string)
        {
            json.Append($"\"{value}\"");
        }
        else if (value is DateTime)
        {
            DateTime dateTime = (DateTime)value;
            json.Append($"\"{dateTime.ToString("yyyy-MM-ddTHH:mm:ss")}\"");
        }
        else if(value is char)
        {
            json.Append($"\"{value}\"");
        }
        else
        {
            json.Append(value.ToString().ToLower()); // Lowercase for bool values
        }
    }
}
