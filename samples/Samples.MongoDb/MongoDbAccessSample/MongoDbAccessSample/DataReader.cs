namespace MongoDbAccessSample
{
	using System.Collections.Generic;

	using MongoDB.Bson;
	using MongoDB.Driver;

	public class DataReader
	{
		private readonly MongoDbConnectionSettings mongoDbConnectionSettings;
		public DataReader(MongoDbConnectionSettings settings)
		{
			this.mongoDbConnectionSettings = settings;
		}

		public IEnumerable<BsonDocument> GetCollection()
		{




			return new List<BsonDocument>();
		}
	}
}