﻿using Empathia.Vistas;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace Empathia.VistaModelo
{
    public class VMinicio : BaseViewModel
    {
        #region VARIABLES
        string _texto;


        #endregion

        #region CONSTRUCTOR
        public VMinicio(INavigation navigation)
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
        public async Task NavegarLogin()
        {
            await Navigation.PushAsync(new Login());
        }
        public async Task NavegarRegister()
        {
            await Navigation.PushAsync(new Register());
        }
        public void ProcesoSimple()
        {

        }

        #endregion

        #region COMANDOS
        public ICommand LoginCommand => new Command(async () => await NavegarLogin());


        public ICommand RegisterCommand => new Command(async () => await NavegarRegister());
        public ICommand ProcesoSimppcommand => new Command(ProcesoSimple);

        #endregion
    }
}
