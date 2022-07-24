using System;
using System.Windows.Input;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace CV_Xamarin.ViewModels
{
    public class AboutViewModel : BaseViewModel
    {
        public AboutViewModel()
        {
            Title = "About";
            OpenWebCommand = new Command(async () => await Browser.OpenAsync("https://ec.linkedin.com/in/carlos-quel-830627219"));
        }

        public ICommand OpenWebCommand { get; }
    }
}