using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

using Xamarin.Essentials;

namespace CV_Xamarin.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class cvLuis : ContentPage
    {
        public cvLuis()
        {
            InitializeComponent();
        }
        async void OnButtonClicked(object sender, EventArgs e)
        {
            // Launch the specified URL in the system browser.
            await Launcher.OpenAsync("https://www.linkedin.com/in/luis-jacome-334b7219a/");
        }
    }
}