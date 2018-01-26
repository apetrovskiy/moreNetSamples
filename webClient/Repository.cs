namespace WebAPIClient
{
    using System.Runtime.Serialization;

    [DataContract(Name = "repo")]
	public class Repository
	{
        [DataMember(Name = "name")]
		public string Name { get; set; }
	}
}