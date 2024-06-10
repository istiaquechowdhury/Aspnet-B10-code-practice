using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace AssigmentDemo
{
    public class JsonSerializer
    {
        public string Serialize(object obj)
        {
            StringBuilder sb = new StringBuilder();
            SerializeObject(obj, sb);
            return sb.ToString();
        }

        private void SerializeObject(object obj, StringBuilder sb)
        {
            if (obj == null)
            {
                sb.Append("null");
                return;
            }

            Type type = obj.GetType();

            if (type.IsPrimitive || type == typeof(string) || type == typeof(DateTime))
            {
                SerializePrimitive(obj, sb);
            }
            else if (type.IsArray || type.IsGenericType)
            {
                SerializeArrayOrList(obj, sb);
            }
            else
            {
                SerializeComplexObject(obj, sb);
            }
        }

        private void SerializePrimitive(object obj, StringBuilder sb)
        {
            if (obj is string)
            {
                sb.Append("\"" + obj + "\"");
            }
            else if (obj is DateTime)
            {
                sb.Append("\"" + ((DateTime)obj).ToString("yyyy-MM-ddTHH:mm:ss") + "\"");
            }
            else
            {
                sb.Append(obj.ToString().ToLower());
            }
        }

        private void SerializeArrayOrList(object obj, StringBuilder sb)
        {
            IEnumerable enumerable = obj as IEnumerable;
            if (enumerable != null)
            {
                sb.Append("[");
                bool first = true;
                foreach (object item in enumerable)
                {
                    if (!first)
                    {
                        sb.Append(",");
                    }
                    SerializeObject(item, sb);
                    first = false;
                }
                sb.Append("]");
            }
        }

        private void SerializeComplexObject(object obj, StringBuilder sb)
        {
            Type type = obj.GetType();
            sb.Append("{");
            bool first = true;
            foreach (PropertyInfo prop in type.GetProperties())
            {
                if (!first)
                {
                    sb.Append(",");
                }
                sb.Append("\"" + prop.Name + "\":");
                SerializeObject(prop.GetValue(obj), sb);
                first = false;
            }
            sb.Append("}");
        }
    }
}
