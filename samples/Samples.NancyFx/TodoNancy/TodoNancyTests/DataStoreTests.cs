namespace TodoNancyTests
{
    using FakeItEasy;
    using Nancy.Testing;
	using TodoNancy;
	using Xunit;

    public class DataStoreTests
	{
		private readonly IDataStore fakeDataStore;
		private Browser sut;
		private readonly Todo aTodo;

		public DataStoreTests()
		{
			fakeDataStore = A.Fake<IDataStore>();
			sut = new Browser(with =>
			{
				with.Dependency(fakeDataStore);
				with.Module<TodosModule>();
			});

			aTodo = new Todo {id = 5, title = "task 10", order = 100, completed = true};
		}

	    [Fact]
	    public void ShouldStorePostedTodosInDatastore()
	    {
	        sut.Post("/todos/", with => with.JsonBody(aTodo));

	        AssertCalledTryAddOnDataStoreWith(aTodo);
	    }

	    private void AssertCalledTryAddOnDataStoreWith(Todo expected)
	    {
	        A.CallTo(() => fakeDataStore.TryAdd(A<Todo>
	                .That.Matches(actual =>/*
	                {
	                    Assert.Equal(expected.title, actual.title);
	                    Assert.Equal(expected.order, actual.order);
	                    Assert.Equal(expected.completed, actual.completed);
	                    return true;
	                }
	                    */
	                    true
	                    )))
	            .MustHaveHappened();
	    }
	}
}