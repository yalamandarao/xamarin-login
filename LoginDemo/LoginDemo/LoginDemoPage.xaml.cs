using Xamarin.Forms;
using LoginDemo.Models;

namespace LoginDemo
{
    public partial class LoginDemoPage : ContentPage
    {
        public LoginDemoPage()
        {
            InitializeComponent();
            Init();
        }

         void Init()
        {
         
            BackgroundColor = Constants.BackgroundColor;
            Lbl_Username.TextColor = Constants.MainTextColor;
            Lbl_Password.TextColor = Constants.MainTextColor;
            ActivitySpinner.IsVisible = false;
            LoginIcon.HeightRequest = Constants.ImageIconHeight;
            Btn_Signin.BackgroundColor = Constants.ButtonColor;
            Btn_Signin.TextColor = Constants.MainTextColor;

            Entry_Username.Completed += (s, e) => Entry_Password.Focus();
            Entry_Password.Completed += (s, e) => SignInProcedure(s, e);

		

        }
        void SignInProcedure(object sender, System.EventArgs e)
        {
            User user = new User(Entry_Username.Text, Entry_Password.Text);

            if(user.CheckInformation())
            {
                DisplayAlert("LoginDemo", "Login success", "Ok");
                App.UserDatabase.SaveUser((user));
            }
            else
            {
                DisplayAlert("LoginDemo", "Login is not success enter user name and password", "Ok");
            }
        }
    }
}
