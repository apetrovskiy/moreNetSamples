namespace WebScrapingSample
{
	using System.Collections.Generic;
	using HtmlAgilityPack;

	public class PageLoader
    {
	    public IEnumerable<HtmlNode> GetHtmlNodes(string url)
	    {
		    var web = new HtmlWeb();
		    var doc = web.Load(url);
		    return doc.DocumentNode.Descendants();
	    }
    }
}
