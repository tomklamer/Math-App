using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Xml.Serialization;

namespace Math_App.Xml
{
    public static class ReaderXml
    {
        public static StrategyXmlObject ReadFile(Stream stream, string name)
        {
            List<StrategyXmlObject> strat = new List<StrategyXmlObject>();
            using (var reader = new System.IO.StreamReader(stream))
            {
                var serializer = new XmlSerializer(typeof(List<StrategyXmlObject>));
                strat = (List<StrategyXmlObject>)serializer.Deserialize(reader);
                
                foreach(var strategie in strat)
                {
                    if(strategie.Title == name)
                    {
                        return strategie;
                    }
                }
            }
            return null;
        }        
    }
}
