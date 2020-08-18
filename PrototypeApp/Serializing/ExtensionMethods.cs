using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;

namespace PrototypeApp.Serializing
{
    public static class ExtensionMethods
    {
        public static T Copy<T>(this T self)
        {
            var stream = new MemoryStream();
            var fomatter = new BinaryFormatter();
            fomatter.Serialize(stream, self);
            stream.Seek(0, SeekOrigin.Begin);

            object copy = fomatter.Deserialize(stream);
            stream.Close();
            return (T)copy;
        }
    }
}
