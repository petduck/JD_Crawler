using System;
using System.Linq;
using System.Text;
using ConsoleApp1.JModel;
using HtmlAgilityPack;

namespace ConsoleApp1
{
    public static class HTMLProcess
    {
        
        private static string current ="";

        public static void GetProductList(string url)
        {
            try
            {
                var htmlStr = HttpHelper.DownloadHtml(url, Encoding.UTF8);
                HtmlDocument doc = new HtmlDocument();
                doc.LoadHtml(htmlStr);

                string goodClass = @"//div[@class='gl-i-wrap']";

                HtmlNodeCollection noneNodeList = doc.DocumentNode.SelectNodes(goodClass);

                foreach (var node in noneNodeList)
                {
                    var childDoc = new HtmlDocument();
                    childDoc.LoadHtml(node.OuterHtml);
                   
                    var price = childDoc.DocumentNode.SelectSingleNode("//*[@class='p-price']/strong/i").InnerText;
                    var img = childDoc.DocumentNode.SelectSingleNode("//*[@class='p-img']/a/img").GetAttributeValue("data-lazy-img", "");


                    var information = childDoc.DocumentNode.SelectSingleNode("//*[@class='p-name p-name-type-2']/a/em").InnerText;
                    current = information;

                    var infoArr = information.Split(new char[]{ ')','）',' '});
                    var Brand = infoArr[0];
                    var ProductName = infoArr[1];
                    var Model = infoArr.Last();

                    var getall = @"
品牌：" + Brand + @"
产品名称：" + ProductName + @"
价格："+ price+@"
"+ "<img src=\"" + img + "\" width=\"100\">";
Console.WriteLine(getall);
//Console.WriteLine("<img src=\""+img+ "\" width=\"100\">");
                }
            }
            catch
            {
                Console.WriteLine($"Err :{current}");
            }
        }
    }
}
