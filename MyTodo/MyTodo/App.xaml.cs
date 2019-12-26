using MyTodo.Data;
using MyTodo.Views;

using Xamarin.Forms;

namespace MyTodo
{
    public partial class App : Application
    {
        static MyTodoDatabase database;

        public App()
        {
            InitializeComponent();

            var nav = new NavigationPage(new TodoMainPage());
            nav.BarBackgroundColor = (Color)App.Current.Resources["primaryGreen"];
            nav.BarTextColor = Color.White;

            MainPage = nav;
        }

        public static MyTodoDatabase Database
        {
            get
            {
                if (database == null)
                {
                    database = new MyTodoDatabase();
                }
                return database;
            }
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
