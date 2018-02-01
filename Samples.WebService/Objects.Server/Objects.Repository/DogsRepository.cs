namespace Objects.Repository
{
	using System;
	using System.Collections.Generic;
	using System.Data.SQLite;
	using System.IO;
	using Dapper;
	using Model.Dogs;

	public class DogsRepository
    {
		// settings :))
	    private string databasePath = Path.Combine(Environment.CurrentDirectory, "db.sqlite");

	    public IEnumerable<Dog> GetAllDogs()
	    {
		    
			CreateDatabase();

			// TODO:
			return new List<Dog>();
	    }

	    public void SaveDogs(IEnumerable<Dog> dogs)
	    {
		    
	    }

	    public IEnumerable<Dog> GetDogByName(string name)
	    {
		    

			// TODO:
			return new List<Dog>();
	    }

	    void CreateDatabase()
	    {
		    // path from settings
		    using (var connection = new SQLiteConnection("data Source=" + databasePath))
		    {
			    connection.Open();
			    connection.Execute(@"create table Dogs
									 (
									  Id integer identity primary key AUTOINCREMENT,
									  Name varchar(100) not null,
									  Age float,
									  Weight float
                                     )");
		    }
	    }
    }
}
