using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace InterfaceTest
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Content : ContentPage
	{
		public Content ()
		{
			InitializeComponent ();
		}

        private void AddBar_OnClicked(object sender, EventArgs e)
        {
            DisplayAlert("Success", "Bar now added", "Great!");
        }
    }
}