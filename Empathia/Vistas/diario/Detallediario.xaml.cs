using Empathia.Modelo;
using Empathia.VistaModelo.VMdiario;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Empathia.Vistas.diario
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Detallediario : ContentPage
    {
        public Detallediario(Mdiario parametros)
        {
            InitializeComponent();
            BindingContext = new VMdetallediario(Navigation, parametros);
        }
    }
}