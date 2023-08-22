using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;
using Empathia.Vistas.diario;
using Empathia.Modelo;
using Empathia.Datos;

namespace Empathia.VistaModelo.VMdiario
{
    public class VMregistrodiario:BaseViewModel
    {
        #region VARIABLES
        string _Txtcolorfondo;
        string _Txttitulo;
        string _Txtimagen;
        string _Txtparrafo;
        string _Txtfecha;


        #endregion

        #region CONSTRUCTOR
        public VMregistrodiario(INavigation navigation)
        {
            Navigation = navigation;
        }

        #endregion

        #region OBJETOS
        public string Txtcolorfondo
        {
            get { return _Txtcolorfondo; }
            set { SetValue(ref _Txtcolorfondo, value); }
        }
        public string Txttitulo
        {
            get { return _Txttitulo; }
            set { SetValue(ref _Txttitulo, value); }
        }
        public string Txtimagen
        {
            get { return _Txtimagen; }
            set { SetValue(ref _Txtimagen, value); }
        }
        public string Txtparrafo
        {
            get { return _Txtparrafo; }
            set { SetValue(ref _Txtparrafo, value); }
        }
        public string Txtfecha
        {
            get { return _Txtfecha; }
            set { SetValue(ref _Txtfecha, value); }
        }

        #endregion

        #region PROCESOS
        public async Task Insertar()
        {
            var funcion = new Ddiario();
            var parametros = new Mdiario();
            parametros.Parrafo = _Txtparrafo;
            parametros.Titulo = _Txttitulo;
            parametros.Fecha = _Txtfecha;
            parametros.Imagen = _Txtimagen;
            parametros.Colorfondo = _Txtcolorfondo;

            await funcion.Insertardiario(parametros);
            await Volver();
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
        public ICommand InsertarCommand => new Command(async () => await Insertar());   
        public ICommand VolverCommand => new Command(async () => await Volver());
        public ICommand ProcesoSimppcommand => new Command(ProcesoSimple);

        #endregion
    }
}
