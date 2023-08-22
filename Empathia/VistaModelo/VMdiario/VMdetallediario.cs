using Empathia.Modelo;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace Empathia.VistaModelo.VMdiario
{
        public class VMdetallediario:BaseViewModel
        {
            #region VARIABLES
            string _texto;
            public Mdiario parametrosRecibe { get; set; }


            #endregion

            #region CONSTRUCTOR
            public VMdetallediario(INavigation navigation, Mdiario parametrosTrae)
            {
                Navigation = navigation;
                parametrosRecibe = parametrosTrae;
            }

            #endregion

            #region OBJETOS
            public string Texto
            {
                get { return _texto; }
                set { SetValue(ref _texto, value); }
            }

            #endregion

            #region PROCESOS
            public async Task ProcesoAsyncrono()
            {

            }

            public async Task Volver()
            {
                await Navigation.PopAsync();
            }

        public void ProcesoSimple()
            {

            }

            #endregion

            #region COMANDOS
            public ICommand ProcesoAsynccommand => new Command(async () => await ProcesoAsyncrono());
            public ICommand ProcesoSimppcommand => new Command(ProcesoSimple);
            public ICommand VolverCommand => new Command(async () => await Volver());

        #endregion
    }
}
