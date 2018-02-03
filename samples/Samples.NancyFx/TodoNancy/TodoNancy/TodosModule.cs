namespace TodoNancy
{
    using System.Collections.Generic;
    using Nancy;
    using Nancy.ModelBinding;

    public class TodosModule : NancyModule
    {
        public static Dictionary<long, Todo> store = new Dictionary<long, Todo>();

        public TodosModule(IDataStore todoStore) : base("todos")
        {
            Get["/"] = _ => Response.AsJson(store.Values);

            Post["/"] = _ =>
            {
                var newTodo = this.Bind<Todo>();
                if (newTodo.id == 0)
                    newTodo.id = todoStore.Count + 1;

                if (!todoStore.TryAdd(newTodo))
                    return HttpStatusCode.NotAcceptable;

                store.Add(newTodo.id, newTodo);
                return Response.AsJson(newTodo)
                    .WithStatusCode(HttpStatusCode.Created);
            };

            Put["/{id}"] = p =>
            {
                var updatedTodo = this.Bind<Todo>();
                if (!todoStore.TryUpdate(updatedTodo))
                    return HttpStatusCode.NotFound;

                return Response.AsJson(updatedTodo);
            };

            Delete["/{id}"] = p =>
            {
                if (!todoStore.TryRemove(p.id))
                    return HttpStatusCode.NotFound;

                store.Remove(p.id);
                return HttpStatusCode.OK;
            };
        }
    }
}