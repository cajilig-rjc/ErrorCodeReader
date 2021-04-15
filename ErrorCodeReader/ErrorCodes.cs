using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace ErrorCodeReader
{
    public static class ErrorCodes
    {
        public static Error Get(int code,string filename = null)
        {
           return JsonConvert.DeserializeObject<IEnumerable<Error>>(File.ReadAllText($"{AppDomain.CurrentDomain.BaseDirectory}{(filename == null ? "ErrorCodes.json" : filename)}")).FirstOrDefault(x=>x.Code == code);
        }
    }
}
