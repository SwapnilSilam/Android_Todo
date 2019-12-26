using System.ComponentModel;

using MyTodo.Model;

namespace MyTodo.ViewModel
{
    public class TodoItemViewModel : INotifyPropertyChanged
    {
        private TodoItem todoItem;
        private bool isItemEditMode;

        public TodoItemViewModel()
        {
        }

        public TodoItem TodoItem
        {
            get
            {
                return todoItem;
            }
            set
            {
                todoItem = value;
                OnPropertyChanged(nameof(TodoItem));
            }
        }

        public bool IsItemEditMode
        {
            get
            {
                return isItemEditMode;
            }
            set
            {
                isItemEditMode = value;
                OnPropertyChanged(nameof(IsItemEditMode));
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
