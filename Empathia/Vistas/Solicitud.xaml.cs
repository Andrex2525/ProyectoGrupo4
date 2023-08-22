using Empathia.VistaModelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Empathia.Vistas
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Solicitud : ContentPage
	{
		public Solicitud ()
		{
			InitializeComponent ();
            BindingContext = new VMsolicitud(Navigation);

        }
    }
}