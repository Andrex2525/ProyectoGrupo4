using Empathia.Modelo;
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
	public partial class Lecturas : ContentPage
	{
		public Lecturas (ImagenInicio parametros)
		{
			InitializeComponent ();
			BindingContext = new VMlecturas(Navigation, parametros);

        }
	}
}