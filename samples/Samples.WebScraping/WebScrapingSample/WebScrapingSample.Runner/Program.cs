namespace WebScrapingSample.Runner
{
	using System;
	using System.Linq;
	using HtmlAgilityPack;

	class Program
    {
        static void Main(string[] args)
        {
	        var nodesLoader = new PageLoader();
			nodesLoader.GetHtmlNodes("http://yandex.ru")
				.Where(node => node.NodeType == HtmlNodeType.Element)
				.ToList()
				.ForEach(node => Console.WriteLine($"{node}: id={node.Id}, name={node.Name}, type={node.NodeType}, XPath={node.XPath}"));

	        Console.ReadKey();
        }
    }
}
