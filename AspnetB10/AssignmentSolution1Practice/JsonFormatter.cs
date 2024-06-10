using System;
using System.Buffers;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentSolution1Practice
{
    public class JsonFormatter
    {
        public static string Convert(object obj)
        {
           StringBuilder Json = new StringBuilder();

           ConvertObj(obj, Json);

           return Json.ToString();
        }


        public static void ConvertObj(object obj, StringBuilder Json)
        {
            if (obj == null)
            {
                Json.Append("null");
                return;
               
            }

            Type ObjType = obj.GetType();

            if(ObjType.IsPrimitive || ObjType == typeof(string) || ObjType == typeof(decimal) || ObjType == typeof(DateTime)) 
            {
               AppendPrimitive(obj, Json);
               return;
                
            }

            if(obj is IEnumerable)
            {
                Json.Append('[');
                bool Json1 = true;
                foreach(var item in (IEnumerable)obj)
                {
                    if (!Json1)
                    {
                        Json.Append(",");
                    }

                    ConvertObj(item, Json);
                    Json1 = false;
                }

                Json.Append("]");   
                return;


            }
            



            Json.Append('{');

           

            PropertyInfo[] Properties =  ObjType.GetProperties();
            bool json = true;
            foreach (PropertyInfo Prop in Properties)
            {
                if (!json)
                {
                    Json.Append(",");
                }
                Json.Append($"\"{Prop.Name}\":");

                ConvertObj(Prop.GetValue(obj), Json);
                json = false;
                
            }
            Json.Append("}");
        }

        public static void AppendPrimitive(object obj,StringBuilder json)
        {
            if(obj is string)
            {
                json.Append($"\"{obj}\"");
            }
            else if(obj is DateTime)
            {
                DateTime datetime = (DateTime)obj;

                json.Append($"\"{datetime.ToString()}\"");
            }
            else if(obj is char)
            {
                json.Append($"\"{obj}\"");
            }
            else
            {
                json.Append(obj.ToString().ToLower());
            }

        }
    }
}
