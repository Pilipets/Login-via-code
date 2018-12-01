using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HtmlAgilityPack;
namespace ConsoleLogin
{
    class Parser
    {
        public static string GetToken(string pageCode, string actionType, string fieldName)
        {
            var doc = new HtmlDocument();
            doc.LoadHtml(pageCode);

            HtmlNode form = doc.DocumentNode.SelectSingleNode(string.Format("//form[@action='{0}']",
                actionType));
            var inputs = form.SelectNodes("input");

            foreach (HtmlNode elem in inputs)
            {

                string name = elem.GetAttributeValue("name", "");
                if (elem.GetAttributeValue("type", "") == "hidden" && name == fieldName)
                    return elem.GetAttributeValue("value", "");
            }
            return "";
        }
    }
}
