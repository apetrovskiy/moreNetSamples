namespace MongoDbAccessSample
{
	using MongoDB.Driver;

	public class MongoClientFactory
	{
		public static MongoClient Create(MongoDbConnectionSettings settings)
		{
			return new MongoClient($"mongodb://{settings.Server}:{settings.Port}");
		}
	}
}