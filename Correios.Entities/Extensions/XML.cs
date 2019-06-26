using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;
using System.IO;
using System.Xml;

namespace Correios.Entities.Extensions
{
    public static class XML
    {
        public static string ToXml(this object obj)
        {

            string xmlStr = string.Empty;

            XmlWriterSettings settings = new XmlWriterSettings
            {
                Indent = false,
                OmitXmlDeclaration = true,
                NewLineChars = string.Empty,
                NewLineHandling = NewLineHandling.None
            };

            using (StringWriter stringWriter = new StringWriter())
            {
                using (XmlWriter xmlWriter = XmlWriter.Create(stringWriter, settings))
                {
                    XmlSerializerNamespaces namespaces = new XmlSerializerNamespaces();
                    namespaces.Add(string.Empty, string.Empty);

                    XmlSerializer serializer = new XmlSerializer(obj.GetType());
                    serializer.Serialize(xmlWriter, obj, namespaces);

                    xmlStr = stringWriter.ToString();
                    xmlWriter.Close();
                }

                stringWriter.Close();
            }

            return xmlStr;           
        }

        public static T FromXml<T>(this string data)
        {
            XmlSerializer s = new XmlSerializer(typeof(T));
            using (StringReader reader = new StringReader(data))
            {
                object obj = s.Deserialize(reader);
                return (T)obj;
            }
        }
    }
}
