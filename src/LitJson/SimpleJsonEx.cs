using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using LitJson;

namespace SimpleJsonEx
{
    /// <summary>
    /// 使用LitJson兼容SimleJson
    /// </summary>
    internal class SimpleJson
    {
        internal static string SerializeObject(object obj) {
            return JsonMapper.ToJson(obj);
        }

        internal static object DeserializeObject(string json,Type t) {
            return JsonMapper.ToObject(json, t);
            
        }
        internal static T DeserializeObject<T>(string json) {
            return JsonMapper.ToObject<T>(json);
        }

    }
}
