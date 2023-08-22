using Empathia.Vistas;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace Empathia.VistaModelo
{
    public class VMregister : BaseViewModel
    {
        #region VARIABLES
        string _texto;


        #endregion

        #region CONSTRUCTOR
        public VMregister(INavigation navigation)
        {
            Navigation = navigation;
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

        public async Task NavegarLogin()
        {
            await Navigation.PushAsync(new Login());
        }

        public async Task NavegarHome()
        {
            await Navigation.PushAsync(new Home());
        }

        public void ProcesoSimple()
        {

        }

        #endregion

        #region COMANDOS
        public ICommand ProcesoAsynccommand => new Command(async () => await ProcesoAsyncrono());
        public ICommand VolverCommand => new Command(async () => await Volver());
        public ICommand LoginCommand => new Command(async () => await NavegarLogin());
        public ICommand HomeCommand => new Command(async () => await NavegarHome());
        public ICommand ProcesoSimppcommand => new Command(ProcesoSimple);

        #endregion
    }
}
