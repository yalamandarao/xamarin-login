using Xamarin.Forms;
using LoginDemo.Data;

namespace LoginDemo
{
    public partial class App : Application
    {
        static TokenDatabaseController tokenDatabase;
        static UserDatabaseController userDatabase;

        public App()
        {
            InitializeComponent();

            MainPage = new LoginDemoPage();
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

        public static UserDatabaseController UserDatabase 
        {
            get 
            {
                if(userDatabase == null)
                {
                    userDatabase = new UserDatabaseController(); 
                }
                return userDatabase;
            }
        }

		public static TokenDatabaseController TokenDatabase
		{
			get
			{
                if (tokenDatabase == null)
				{
                    tokenDatabase = new TokenDatabaseController();
				}
				return tokenDatabase;
			}
		}
    }
}
