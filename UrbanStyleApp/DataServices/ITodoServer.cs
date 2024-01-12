using System;
using System.Threading.Tasks;
using Refit;
using UrbanStyleApp.DataModel;

namespace UrbanStyleApp.DataServices
{
    public interface ITodoServer
    {
        [Get("/todos")]
        Task<UrbanUsersModel[]> GetTodoItems();

        [Get("/todos/{id}")]
        Task<UrbanUsersModel> GetTodoItem(int id);

       // [Post("/todos")]
       // Task<UrbanUsersModel> SaveTodoItem([Body] TodoItem item);
    }
}
