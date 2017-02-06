using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using LitJson;

namespace Newtonsoft.Json
{
    /// <summary>
    /// 使用Litjson来序列化 因为我们要的只是简单的数据结构
    /// </summary>
    internal class JsonConvert
    {
        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="jsonStr"></param>
        /// <returns></returns>
        public static T DeserializeObject<T>(string jsonStr) {
            return JsonMapper.ToObject<T>(jsonStr);
        }

        public static string SerializeObject(object obj) {
            //
            return JsonMapper.ToJson(obj);
        }
    }
}
