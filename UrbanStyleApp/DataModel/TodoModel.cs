using System;

namespace UrbanStyleApp.DataModel
{
    public class TodoModel
    {
        public int UserId { get; set; }

        public int Id { get; set; }

        public string Title { get; set; }

        public bool Completed { get; set; }

        public TodoModel()
        {
        }
    }
}
