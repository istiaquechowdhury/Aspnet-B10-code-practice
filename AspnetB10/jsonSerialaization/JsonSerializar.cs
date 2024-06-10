using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace jsonSerialaization
{
    public class JsonSerializar
    {
        public string SerializeObject(object obj)
        {
            Type type = obj.GetType();
            PropertyInfo[] properties = type.GetProperties();

            Dictionary<string, object> propertyValues = new Dictionary<string, object>();

            foreach (var property in properties)
            {
                propertyValues[property.Name]= property.GetValue(obj);
            }

            return JsonSerializer.Serialize(propertyValues);
        }
    }
}
