using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;
using Empathia.Modelo;

namespace Empathia.VistaModelo
    
{
    public class VMrecomendaciones : BaseViewModel
    {
        #region VARIABLES
        string _texto;
        public List<Musuarios> listausuarios {  get; set; } 

        #endregion

        #region CONSTRUCTOR
        public VMrecomendaciones(INavigation navigation)
        {
            Navigation = navigation;
            Mostrarusuarios();
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

        public void Mostrarusuarios()
        {
            listausuarios = new List<Musuarios>()
            {
                new Musuarios
                {
                    Nombre="Contento",
                    Imagen="https://i.ibb.co/16bYj2K/cara-sonriente.png"
                },

                new Musuarios
                {
                    Nombre="Enojado",
                    Imagen="https://i.ibb.co/MnrBrMG/cara-enojada.png"
                },

                new Musuarios
                {
                    Nombre="Triste",
                    Imagen="https://i.ibb.co/4tNYWTV/linda.png"
                },

                new Musuarios
                {
                    Nombre="Desanimado",
                    Imagen="https://i.ibb.co/r7hDHMc/meh.png"
                }

            };
        }

        public async Task Alerta(Musuarios parametros)
        {
            await DisplayAlert("Titulo", parametros.Nombre, "Ok");
        }

        #endregion

        #region COMANDOS
        public ICommand ProcesoAsynccommand => new Command(async () => await ProcesoAsyncrono());
        //public ICommand ProcesoSimppcommand => new Command(Mostrarusuario);
        public ICommand VolverCommand => new Command(async () => await Volver());

        public ICommand AlertaCommand => new Command<Musuarios>(async (p) => await Alerta(p));
        #endregion
    }
}
