using Empathia.VistaModelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms.GoogleMaps;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Empathia.Vistas
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Buscarayuda : ContentPage
    {
        public Buscarayuda()
        {
            InitializeComponent();
            BindingContext = new VMbuscarayuda(Navigation);

            Pin MiUbi = new Pin()
            {
                Type = PinType.Place,
                Label = "Mi ubicacion",
                Address = "Facultad de ingenieria Industrial",
                Position = new Position(-2.1476546067438744, -79.9124243626635),
                Tag = "id_miubi"
            };

            Pin MiUbi2 = new Pin()
            {
                Type = PinType.Place,
                Label = "PSIA Psicología Integral Aguirre",
                Address = "Gonzanamá Mz 741, Guayaquil 090501",
                Position = new Position(-2.138516711373907, -79.90024405105359),
                Tag = "id_miubi"
            };

            Pin MiUbi3 = new Pin()
            {
                Type = PinType.Place,
                Label = "Upgrade S.A. Centro de Especialidades Psicológicas",
                Address = "Cdla Alamos Norte, Ingeniero Rodolfo Baquerizo Nazur S9 V1, Guayaquil 090501",
                Position = new Position(-2.131848008698142, -79.90949230738855),
                Tag = "id_miubi"
            };

            Pin MiUbi4 = new Pin()
            {
                Type = PinType.Place,
                Label = "Psi. Clin. Cinthia Almeida T.",
                Address = "Centro de Servicios Profesionales, Oficina 1, Av. Francisco de Orellana 22, Guayaquil 090112",
                Position = new Position(-2.144912667309788, -79.90057444193857),
                Tag = "id_miubi"
            };

            Pin MiUbi5 = new Pin()
            {
                Type = PinType.Place,
                Label = "Psicóloga Jessica Villacis Freire",
                Address = "René Hidrovo Rosales 45, Guayaquil 090505",
                Position = new Position(-2.1457537749705127, -79.89315153531409),
                Tag = "id_miubi"
            };

            map.Pins.Add(MiUbi);
            map.Pins.Add(MiUbi2);
            map.Pins.Add(MiUbi3);
            map.Pins.Add(MiUbi4);
            map.Pins.Add(MiUbi5);
            map.MoveToRegion(MapSpan.FromCenterAndRadius(MiUbi.Position, Distance.FromMeters(1000)));

        }
    }
}