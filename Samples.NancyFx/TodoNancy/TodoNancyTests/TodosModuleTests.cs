namespace TodoNancyTests
{
    using Nancy;
    using Nancy.Testing;
    using TodoNancy;
    using Xunit;

    public class TodosModuleTests
    {
        private Browser sut;
        private Todo aTodo;
        private Todo anEditedTodo;

        public TodosModuleTests()
        {
            TodosModule.store.Clear();
            sut = new Browser(new DefaultNancyBootstrapper());
            aTodo = new Todo
            {
                title = "task 1", order = 0, completed = false
            };
            anEditedTodo = new Todo
            {
                id = 42, title = "edited name", order = 0, completed = false
            };
        }

        [Fact]
        public void ShouldReturnEmptyListOnGetWhenNoTodosHaveBeenPosted()
        {
            var actual = sut.Get("/todos");

            Assert.Equal(HttpStatusCode.OK, actual.StatusCode);
            Assert.Empty(actual.Body.DeserializeJson<TodosModuleTests[]>());
        }

        [Fact]
        public void ShouldReturn201CreateWhenAtodoIsPosted()
        {
            var actual = sut.Post("/todos/", with => with.JsonBody(aTodo));

            Assert.Equal(HttpStatusCode.Created, actual.StatusCode);
        }

        [Fact]
        public void ShouldNotAcceptPostingToWithDuplicateId()
        {
            var actual = sut.Post("/todos/", with => with.JsonBody(anEditedTodo))
                .Then
                .Post("/todos/", with => with.JsonBody(anEditedTodo));

            Assert.Equal(HttpStatusCode.NotAcceptable, actual.StatusCode);
        }

        [Fact]
        public void ShouldBeAbleToGetPostedTodo()
        {
            var actual = sut.Post("/todos/", with => with.JsonBody(aTodo))
                .Then
                .Get("/todos/");

            var actualBody = actual.Body.DeserializeJson<Todo[]>();

            Assert.Equal(1, actualBody.Length);
            AssertAreSame(aTodo, actualBody[0]);
        }

        private void AssertAreSame(Todo expected, Todo actual)
        {
            Assert.Equal(expected.title, actual.title);
            Assert.Equal(expected.order, actual.order);
            Assert.Equal(expected.completed, actual.completed);
        }
    }
}