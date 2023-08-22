using Empathia.Datos;
using Empathia.Modelo;
using Empathia.VistaModelo.VMdiario;
using Empathia.Vistas;
using Empathia.Vistas.diario;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace Empathia.VistaModelo
{
    public class VMhome : BaseViewModel
    {
        #region VARIABLES
        string _texto;
        public List<Mhome> listapaginas { get; set; }

        private ObservableCollection<ImagenInicio> _Places;


        #endregion

        #region CONSTRUCTOR

       
        public VMhome(INavigation navigation)
        {
            Navigation = navigation;
            Mostrarrecomendacion();
        }

        #endregion

        #region OBJETOS
        public string Texto
        {
            get { return _texto; }
            set { SetValue(ref _texto, value); }
        }

        public ObservableCollection<ImagenInicio> Places
        {
            get { return _Places; }
            set
            {
                SetValue(ref _Places, value);
                OnPropertyChanged();
            }
        }

        #endregion

        #region PROCESOS

        public async Task Mostrarrecomendacion()
        {
            var funcion = new Dhome();
            Places = await funcion.Mostrarrecomendaciones();
        }

        public async Task NavLec(ImagenInicio parametros)
        {
            await Navigation.PushAsync(new Lecturas(parametros));
        }

        //public async Task NavLec(ImagenInicio parametros)
        //{
        //    string title;
        //    title = parametros.title;

        //    if (title.Contains("La salud mental"))
        //    {
        //        await Navigation.PushAsync(new Lecturas());
        //    }

        //    if (title.Contains("Diario"))
        //    {
        //        await Navigation.PushAsync(new Recomendaciones());
        //    }
        //    if (title.Contains("Ejercicios"))
        //    {
        //        await Navigation.PushAsync(new Recomendaciones());
        //    }
        //    if (title.Contains("Solicitar"))
        //    {
        //        await Navigation.PushAsync(new Solicitud());
        //    }
        //}
        public async Task Volver()
        {
            await Navigation.PopAsync();
        }

        //public void Mostrarpaginas()
        //{
        //    listapaginas = new List<Mhome>()
        //    {
        //        new Mhome
        //        {
        //            Pagina="Recomendaciones diarias",
        //            Icono="https://i.ibb.co/16bYj2K/cara-sonriente.png"
        //        },

        //        new Mhome
        //        {
        //            Pagina="Diario de gratitud",
        //            Icono="https://i.ibb.co/MnrBrMG/cara-enojada.png"
        //        },

        //        new Mhome
        //        {
        //            Pagina="Ejercicios de relajacion",
        //            Icono="https://i.ibb.co/4tNYWTV/linda.png"
        //        },

        //        new Mhome
        //        {
        //            Pagina="Solicitar ayuda",
        //            Icono="https://i.ibb.co/r7hDHMc/meh.png"
        //        }

        //    };
        //}



        //public async Task Navegar(Mhome parametros)
        //{
        //    string pagina;
        //    pagina = parametros.Pagina;

        //    if (pagina.Contains("Recomendaciones"))
        //    {
        //        await Navigation.PushAsync(new Recomendaciones());
        //    }

        //    if (pagina.Contains("Diario"))
        //    {
        //        await Navigation.PushAsync(new Recomendaciones());
        //    }
        //    if (pagina.Contains("Ejercicios"))
        //    {
        //        await Navigation.PushAsync(new Recomendaciones());
        //    }
        //    if (pagina.Contains("Solicitar"))
        //    {
        //        await Navigation.PushAsync(new Solicitud());
        //    }
        //}

        public async Task NavegarRecomendaciones()
        {
            await Navigation.PushAsync(new Recomendaciones());
        }

        public async Task NavegarLecturas(ImagenInicio parametros)
        {
            await Navigation.PushAsync(new Lecturas(parametros));
        }

        public async Task NavegarDiario()
        {
            await Navigation.PushAsync(new Listadiario());
        }

        public async Task NavegarAyuda()
        {
            await Navigation.PushAsync(new Buscarayuda());
        }

        #endregion

        #region COMANDOS
        //public ICommand ProcesoAsynccommand => new Command(async () => await ProcesoAsyncrono());
        //public ICommand ProcesoSimppcommand => new Command(Mostrarusuario);
        //public ICommand VolverCommand => new Command(async () => await Volver());
        public ICommand RecomendacionesCommand => new Command(async () => await NavegarRecomendaciones());
        public ICommand LecturasCommand => new Command<ImagenInicio>(async (a) => await NavegarLecturas(a));

        public ICommand NavegardiarioCommand => new Command(async () => await NavegarDiario());
        public ICommand NavegarayudaCommand => new Command(async () => await NavegarAyuda());


        //public ICommand NavegarCommand => new Command<Mhome>(async (p) => await Navegar(p));
        public ICommand NavLecCommand => new Command<ImagenInicio>(async (p) => await NavLec(p));
        #endregion
    }
}