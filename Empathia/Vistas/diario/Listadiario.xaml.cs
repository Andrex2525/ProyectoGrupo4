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
	public partial class Listadiario : ContentPage
	{
        public Listadiario()
        {
            InitializeComponent();
            BindingContext = new VMlistadiario(Navigation);
        }


        //VMlistadiario vm;
        //public Listadiario ()
        //{
        //	InitializeComponent ();
        //	vm = new VMlistadiario(Navigation);
        //	BindingContext = vm;
        //          this.Appearing += Listadiario_Appearing; 
        //}

        //      private async void Listadiario_Appearing(object sender, EventArgs e)
        //      {
        //	await vm.Mostrardiario();
        //      }
    }
}