using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ConsultaCEP
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class PageHome : ContentPage
	{
		public PageHome ()
		{
			InitializeComponent ();
		}

        public void Sair(object obj, EventArgs args)
        {
            App.Current.MainPage = new NavigationPage(new MainPage());
        }

    }
}