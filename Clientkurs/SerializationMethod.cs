using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;

namespace Clientkurs
{
    class SerializationMethod
    {
        public static object fromByteArray(byte[] data, Type type, int length)
        {
            string str = Encoding.UTF8.GetString(data, 0, length);
            return new JavaScriptSerializer().Deserialize(str, type);
        }

        public static byte[] objectToByteArray(object obj, Type type)
        {
            if (obj == null)
                return null;
            String str = new JavaScriptSerializer().Serialize(obj);
            return Encoding.UTF8.GetBytes(str);
        }
    }
}
