namespace MongoDbAccessSample
{
	public class DataWriter
	{
		private readonly MongoDbConnectionSettings mongoDbConnectionSettings;
		public DataWriter(MongoDbConnectionSettings settings)
		{
			this.mongoDbConnectionSettings = settings;
		}
	}
}