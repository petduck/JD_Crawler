using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class TestCode
    {
        /*
       public static void GetProductInfo(string url)
       {
           try
           {
               string html = HttpHelper.DownloadHtml(url, Encoding.UTF8);
               HtmlDocument productDoc = new HtmlDocument();
               productDoc.LoadHtml(html);
               HtmlNode pageNode = productDoc.DocumentNode.SelectSingleNode(@"//*[@id='J_topPage']/span/i");
               if (pageNode != null)
               {
                   int pageNum = Convert.ToInt32(pageNode.InnerText);
                   for (int i = 1; i < pageNum + 1; i++)
                   {
                       string pageUrl = string.Format("{0}&page={1}", category.Url, i).Replace("&page=1&", string.Format("&page={0}&", i));
                       try
                       {
                           List<ProductInfo> proDuctInfo = GetPageProduct(pageUrl);
                       }
                       catch (Exception ex)
                       {
                           Console.WriteLine(ex.Message);
                       }
                   }
               }

       HtmlNodeCollection list = docChild.DocumentNode.SelectNodes(urlPath);

                   foreach (var l in list)
                   {
                       HtmlDocument docChild1 = new HtmlDocument();
                       docChild1.LoadHtml(l.OuterHtml);
                       var sortUrl = l.Attributes["href"].Value;
                       if (!string.IsNullOrWhiteSpace(sortUrl) && sortUrl.Contains("cat="))
                       {
                           //InsertSort("https:" + sortUrl);
                       }
                   }

           }
           catch (Exception ex)
           {
               Console.WriteLine(ex.Message);
           }
       }

       public static void GetPrice()
       {
           List<ProductInfo> productInfoList = new List<ProductInfo>();
           try
           {
               string html = HttpHelper.DownloadUrl(url);
               HtmlDocument doc = new HtmlDocument();
               doc.LoadHtml(html);
               HtmlNodeCollection productNodeList = doc.DocumentNode.SelectNodes("//*[@id='plist']/ul/li");
               if (productNodeList == null || productNodeList.Count == 0)
               {
                   return productInfoList;
               }
               foreach (var node in productNodeList)
               {
                   HtmlDocument docChild = new HtmlDocument();
                   docChild.LoadHtml(node.OuterHtml);
                   ProductInfo productInfo = new ProductInfo()
                   {
                       CategoryId = category.Id
                   };

                   HtmlNode urlNode = docChild.DocumentNode.SelectSingleNode("//*[@class='p-name']/a");
                   if (urlNode == null)
                   {
                       continue;
                   }
                   string newUrl = urlNode.Attributes["href"].Value;
                   newUrl = !newUrl.StartsWith("http:") ? "http:" + newUrl : newUrl;
                   string sId = Path.GetFileName(newUrl).Replace(".html", "");
                   productInfo.ProductId = long.Parse(sId);
                   HtmlNode titleNode = docChild.DocumentNode.SelectSingleNode("//*[@class='p-name']/a/em");
                   if (titleNode == null)
                   {
                       continue;
                   }
                   productInfo.Title = titleNode.InnerText;

                   HtmlNode priceNode = docChild.DocumentNode.SelectSingleNode("//*[@class='p-price']/strong/i");
                   if (priceNode == null)
                   {
                       continue;
                   }
                   else
                   {

                   }
                   productInfoList.Add(productInfo);

               }
               //批量获取价格
               GetGoodsPrice(productInfoList);
           }
           catch (Exception ex)
           {
           }
           return productInfoList;
       }

       public static void GetInfo()
       {
           try
           {
               StringBuilder sb = new StringBuilder();
               sb.AppendFormat("http://p.3.cn/prices/mgets?callback=jQuery1069298&type=1&area=1_72_4137_0&skuIds={0}&pdbp=0&pdtk=&pdpin=&pduid=1945966343&_=1469022843655", string.Join("%2C", productInfoList.Select(c => string.Format("J_{0}", c.ProductId))));
               string html = HttpHelper.DownloadUrl(sb.ToString());
               if (string.IsNullOrWhiteSpace(html))
               {
                   return productInfoList;
               }
               html = html.Substring(html.IndexOf("(") + 1);
               html = html.Substring(0, html.LastIndexOf(")"));
               List<CommodityPrice> priceList = JsonConvert.DeserializeObject<List<CommodityPrice>>(html);
               productInfoList.ForEach(c => c.Price = priceList.FirstOrDefault(p => p.id.Equals(string.Format("J_{0}", c.ProductId))).p);
           }
           catch (Exception ex)
           {
               Console.WriteLine(ex.Message);
           }
           return productInfoList;
       }*/
    }
}
