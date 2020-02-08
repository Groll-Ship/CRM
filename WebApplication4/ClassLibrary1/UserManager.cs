using CRMTest.stab;
using data;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace busines
{
    public abstract class UserManager
    {
        protected Storage _storage;
        public UserManager()
        {
            _storage = new Storage();
        }

        /// <summary>
        /// Convert type String to Integer
        /// </summary>
        /// <param name="str">String type</param>
        /// <returns></returns>
        protected int StringToInt(string str)
        {
            return int.TryParse(str, out int number) ? number : 0;
        }

        /// <summary>
        /// Convert object to dictionary
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        protected Dictionary<string, string> DeserializeObjectTodictionary(Object obj)
        {
            string str = obj.ToString();
            return JsonConvert.DeserializeObject<Dictionary<string, string>>(str);
        }
    }
}
