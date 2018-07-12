using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace UnnamedGame
{
    public class EventMenu : UnnamedMenu
    {

        private XmlNode CurrentNode;
        private XmlDocument doc;


        public EventMenu(UnnamedDataContext ctx, Func<UnnamedMenu> prevMenu, String eventFile)
            : base(ctx, prevMenu)
        {
            ThisMenu = () => new EventMenu(ctx, prevMenu, eventFile);


            Options = new ObservableCollection<Option>();
            doc = new XmlDocument();

            Debug.WriteLine(ctx.PlayerOptions.Menu);

            doc.Load("data/" + eventFile);
            CurrentNode = doc.SelectSingleNode("//branch[@key='start']").FirstChild;
            ProcessNode(CurrentNode);


        }

        private void ProcessNode(XmlNode node)
        {
            Debug.WriteLine("Processing Node: " + node.Name);

            Options.Clear();
            switch (node.Name)
            {
                case "text":
                    Text(node);
                    break;

                case "choice":
                    foreach (XmlNode option in node.ChildNodes)
                    {
                        Option(option);
                    }
                    break;
                case "end":
                    Next(new MainMenu(Ctx, null));
                    break;
                default:
                    Debug.WriteLine("Could not process node : " + node.Name + ". Element not recognized.");
                    break;
            }
        }

        private XmlNode NextNode(XmlNode node)
        {
            CurrentNode = CurrentNode.NextSibling;
            return node.NextSibling;
        }

        private void Text(XmlNode textNode)
        {
            NextNode(CurrentNode);
            Options.Add(new Option(textNode.InnerText, () => ProcessNode((CurrentNode))));
        }

        private void Option(XmlNode optionNode)
        {
            Options.Add(new UnnamedGame.Option(optionNode.Attributes["text"].Value, () => SelectOption(optionNode)));
        }

        private void SelectOption(XmlNode optionNode)
        {
            CurrentNode = optionNode.FirstChild;
            ProcessNode(CurrentNode);
        }
    }
}
