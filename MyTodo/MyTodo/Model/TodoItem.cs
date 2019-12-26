using System.ComponentModel.DataAnnotations;

using SQLite;

namespace MyTodo.Model
{
    public class TodoItem
    {
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Title is required.")]
        public string Name { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Notes is required.")]
        public string Notes { get; set; }

        public bool Done { get; set; }
    }
}
