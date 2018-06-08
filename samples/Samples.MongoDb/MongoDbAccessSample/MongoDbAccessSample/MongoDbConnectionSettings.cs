namespace MongoDbAccessSample
{
	public class MongoDbConnectionSettings
	{
		public string Server { get; set; }
		public int Port { get; set; }

		public MongoDbConnectionSettings(string server, int port)
		{
			Server = server;
			Port = port;
		}
	}
}