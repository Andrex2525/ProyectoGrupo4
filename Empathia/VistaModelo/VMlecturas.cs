using Empathia.Modelo;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace Empathia.VistaModelo
{
    public class VMlecturas : BaseViewModel
    {
        #region VARIABLES
        string _texto;
        public ImagenInicio parametrosRecibe { get; set; }


        #endregion

        #region CONSTRUCTOR
        public VMlecturas(INavigation navigation, ImagenInicio parametrosTrae)
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

        public void ProcesoSimple()
        {

        }

        #endregion

        #region COMANDOS
        public ICommand ProcesoAsynccommand => new Command(async () => await ProcesoAsyncrono());
        public ICommand ProcesoSimppcommand => new Command(ProcesoSimple);

        #endregion
    }
}
