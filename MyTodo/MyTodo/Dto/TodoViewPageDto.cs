using MyTodo.Model;

namespace MyTodo.Dto
{
    public class TodoViewPageDto
    {
        public TodoItem TodoItem { get; set; }

        public bool IsItemEditMode { get; set; }
    }
}
