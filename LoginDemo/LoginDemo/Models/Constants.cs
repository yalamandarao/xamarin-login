using System;
using Xamarin.Forms;
namespace LoginDemo.Models
{
    public class Constants
    {
		public static bool isDev = true;
        public static Color BackgroundColor = Color.FromRgb(58, 124, 220);
        public static Color MainTextColor = Color.White;
        public static Color ButtonColor = Color.Red;

        public static int ImageIconHeight = 120;


        // ------ Login -------
        public static string LoginUrl = "https://test.com/api/Auth/Login";

        public Constants()
        {
           
        }
    }
}
