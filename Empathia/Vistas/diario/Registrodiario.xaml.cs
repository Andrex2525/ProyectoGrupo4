using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Empathia.VistaModelo.VMdiario;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Empathia.Vistas.diario
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Registrodiario : ContentPage
	{
		public Registrodiario ()
		{
			InitializeComponent ();
			BindingContext = new VMregistrodiario(Navigation);
		}
	}
}