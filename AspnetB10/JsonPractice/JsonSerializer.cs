using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;


namespace JsonPractice
{
    public class JsonSerializer
    {

        public string Serializer(object obj)
        {
            Type type = obj.GetType();

            PropertyInfo[] properties = type.GetProperties();

            Dictionary<string,object> propertyvalues = new Dictionary<string,object>();

            foreach (PropertyInfo property in properties)
            {
                propertyvalues[property.Name] = property.GetValue(obj);

            }


            return System.Text.Json.JsonSerializer.Serialize(propertyvalues);
        }
    }
}
