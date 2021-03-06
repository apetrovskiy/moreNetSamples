﻿namespace WebAPIClient
{
	using System;
	using System.Collections.Generic;
	using System.Net.Http;
	using System.Net.Http.Headers;
	using System.Runtime.Serialization.Json;
	using System.Threading.Tasks;

	class Program
    {
        static void Main(string[] args)
        {
            var repositories = ProcessRepositories().Result;

            repositories.ForEach(repo => Console.WriteLine($"Name={repo.Name}, description={repo.Description}, home url={repo.Homepage}, Github home url={repo.GitHubHomeUrl}, watchers={repo.Watchers}, lastPush={repo.LastPush}"));
            Console.ReadKey();
        }

	    private static async Task<List<Repository>> ProcessRepositories()
	    {
		    var client = new HttpClient();
			client.DefaultRequestHeaders.Accept.Clear();
			client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/vnd.github.v3+json"));
			client.DefaultRequestHeaders.Add("User-Agent", ".NET Foundation Repository Reporter");

		    var stringTask = client.GetStringAsync("https://api.github.com/orgs/dotnet/repos");

		    // var msg = await stringTask;
			// Console.Write(msg);

			var serializer = new DataContractJsonSerializer(typeof(List<Repository>));
		    var streamTask = client.GetStreamAsync("https://api.github.com/orgs/dotnet/repos");
		    var repositories = serializer.ReadObject(await streamTask) as List<Repository>;

	        return repositories;
	    }
    }
}
