using System;

using MyTodo.Dto;
using MyTodo.Model;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MyTodo.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class TodoMainPage : ContentPage
    {
        public TodoMainPage()
        {
            InitializeComponent();
        }

        protected override async void OnAppearing()
        {
            base.OnAppearing();

            listView.ItemsSource = await App.Database.GetItemsAsync();
        }

        async void OnItemAdded(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new TodoViewPage(new TodoViewPageDto
            {
                TodoItem = new TodoItem(),
                IsItemEditMode = false
            }));
        }

        async void OnListItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            if (e.SelectedItem != null)
            {
                await Navigation.PushAsync(new TodoViewPage(new TodoViewPageDto
                {
                    TodoItem = e.SelectedItem as TodoItem,
                    IsItemEditMode = true
                }));
            }
        }
    }
}