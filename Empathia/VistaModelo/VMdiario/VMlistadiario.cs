using Empathia.Vistas.diario;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;
using System.Collections.ObjectModel;
using Empathia.Datos;
using Empathia.Modelo;

namespace Empathia.VistaModelo.VMdiario
{
    public class VMlistadiario:BaseViewModel
    {
        #region VARIABLES
        string _texto;
        ObservableCollection<Mdiario> _Listadiario;


        #endregion

        #region CONSTRUCTOR
        public VMlistadiario(INavigation navigation)
        {
            Navigation = navigation;
            Mostrardiario();
        }

        #endregion

        #region OBJETOS
        public ObservableCollection<Mdiario> Listadiario
        {
            get { return _Listadiario; }
            set { SetValue(ref _Listadiario, value);          
                OnPropertyChanged();
            }
        }

        #endregion

        #region PROCESOS
        public async Task Mostrardiario()
        {
            var funcion = new Ddiario();
            Listadiario = await funcion.Mostrardiarios();
        }

        public async Task Iraregistro()
        {
            await Navigation.PushAsync(new Registrodiario());
        }

        public async Task Iradetalle(Mdiario parametros) 
        {
            await Navigation.PushAsync(new Detallediario(parametros));
        }


        public void ProcesoSimple()
        {

        }

        #endregion

        #region COMANDOS
        public ICommand IraregistroCommand => new Command(async () => await Iraregistro());

        public ICommand IradetalleCommand => new Command<Mdiario>(async (parametros) => await Iradetalle(parametros));
        public ICommand ProcesoSimppcommand => new Command(ProcesoSimple);

        #endregion
    }
}
