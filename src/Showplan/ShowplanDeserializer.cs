using System;
using System.IO;
using System.Xml.Serialization;

namespace Showplan
{
    public class ShowplanDeserializer
    {
        private static readonly XmlSerializer s_xmlSerializer = new XmlSerializer(typeof(ShowPlanXML));

        public ShowPlanXML Deserialize(Stream stream)
        {
            if (!(s_xmlSerializer.Deserialize(stream) is ShowPlanXML o))
            {
                throw new InvalidShowplanXmlException();
            }

            return o;
        }

        public ShowPlanXML Deserialize(TextReader stringReader)
        {
            if (!(s_xmlSerializer.Deserialize(stringReader) is ShowPlanXML o))
            {
                throw new InvalidShowplanXmlException();
            }

            return o;
        }

        public ShowPlanXML Deserialize(string showplan)
        {
            return Deserialize(new StringReader(showplan));
        }

        public ShowPlanXML Deserialize(FileInfo file)
        {
            return Deserialize(file.OpenRead());
        }
    }

    public class InvalidShowplanXmlException : Exception
    {
    }
}
