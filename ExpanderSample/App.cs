using Xamarin.Forms;

namespace ExpanderSample
{
    public class App : Application
    {
        public App()
        {
            Device.SetFlags(new[] { "Expander_Experimental" });
            MainPage = new ExpanderContentPage();
        }
    }
}
