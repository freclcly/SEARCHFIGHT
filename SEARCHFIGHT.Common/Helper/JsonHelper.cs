using Nancy.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace SEARCHFIGHT.Common.Helper
{
    public static class JsonHelper
    {
        public static T Deserialize<T>(this string json)
        {
            var serializer = new JavaScriptSerializer();
            return serializer.Deserialize<T>(json);
        }
    }
}
