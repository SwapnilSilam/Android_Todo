using System;

using MyTodo.Dto;
using MyTodo.Helpers;
using MyTodo.ViewModel;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MyTodo.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class TodoViewPage : ContentPage
    {
        private readonly TodoItemViewModel todoItemViewModel = null;
        public TodoViewPage(TodoViewPageDto todoViewPageDto)
        {
            InitializeComponent();

            todoItemViewModel = new TodoItemViewModel();
            BindingContext = todoItemViewModel;
            todoItemViewModel.TodoItem = todoViewPageDto.TodoItem;
            todoItemViewModel.IsItemEditMode = todoViewPageDto.IsItemEditMode;
        }

        async void OnSaveClicked(object sender, EventArgs e)
        {
            if (ValidationHelper.IsFormValid(todoItemViewModel.TodoItem, this))
            {
                await App.Database.SaveItemAsync(todoItemViewModel.TodoItem);
                await Navigation.PopAsync();
            }
        }

        async void OnDeleteClicked(object sender, EventArgs e)
        {
            if (await DisplayAlert("Delete", "Are you sure?", "Yes", "No"))
            {
                await App.Database.DeleteItemAsync(todoItemViewModel.TodoItem);
                await Navigation.PopAsync();
            }
        }
    }
}