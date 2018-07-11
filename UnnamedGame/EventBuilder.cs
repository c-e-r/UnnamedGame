using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace UnnamedGame
{
    class EventBuilder
    {
        XmlDocument doc = new XmlDocument();
        

        public EventBuilder()
        {
            doc.Load("data/test.xml");
            //Debug.WriteLine(doc.InnerXml);
            XmlNodeList nodeList = doc.FirstChild.ChildNodes;
            nodeList = doc.FirstChild.SelectSingleNode("branch[@key='one']").ChildNodes;
            foreach (XmlNode node in nodeList)
            {
                Debug.WriteLine(node.Name);
                parseNode(node);
            }
        }

        public void ParseNodes(XmlNode node)
        {
            if (node.HasChildNodes)
            {
                
            }
        }

        public void parseNode(XmlNode node)
        {
            switch (node.Name)
            {
                case "text":
                    break;
                default:
                    break;
                    
            }
        }
    }
}
