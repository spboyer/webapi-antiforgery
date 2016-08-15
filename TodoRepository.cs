
using System.Collections.Generic;

namespace webapi_antiforgery
{
public class TodoRepository
    {
        private List<TodoItem> _items;

        public TodoRepository()
        {
            _items = new List<TodoItem>()
            {
                new TodoItem() { Name = "Mow the lawn" },
                new TodoItem() { Name = "Do the dishes" },
                new TodoItem() { Name = "Wash the car" },
                
            };
        }

        public IEnumerable<TodoItem> GetItems()
        {
            return _items;
        }

        public void Add(TodoItem item)
        {
            _items.Add(item);
        }
    }
}