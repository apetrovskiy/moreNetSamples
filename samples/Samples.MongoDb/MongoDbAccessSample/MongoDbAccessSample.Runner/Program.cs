namespace MongoDbAccessSample.Runner
{
	using System;
	using System.Configuration;

	using MongoDB.Bson;
	using MongoDB.Driver;

	class Program
    {
        static void Main(string[] args)
        {
	        var server = ConfigurationManager.AppSettings.Get("MongoDbServer");
	        var port = Convert.ToInt32(ConfigurationManager.AppSettings.Get("MongoDbPort"));
			var mongoDbConnectionSettings = new MongoDbConnectionSettings(server, port);
			var client = MongoClientFactory.Create(mongoDbConnectionSettings);

	        var database = client.GetDatabase("book");
	        var collection = database.GetCollection<BsonDocument>("towns");

	        var document = collection.Find(new BsonDocument()).FirstOrDefault();

	        Console.ReadKey();
        }
    }
}
