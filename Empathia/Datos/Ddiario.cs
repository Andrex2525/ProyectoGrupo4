using System;
using System.Collections.Generic;
using System.Text;
using Empathia.Modelo;
using Empathia.Conexion;
using Firebase.Database.Query;
using System.Linq;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using Firebase.Database;

namespace Empathia.Datos
{
    public class Ddiario
    {
        public async Task Insertardiario(Mdiario parametros)
        {
            await Cconexion.firebase
                .Child("Diario")
                .PostAsync(new Mdiario()
                {
                    Colorfondo = parametros.Colorfondo,
                    Fecha = parametros.Fecha,
                    Imagen = parametros.Imagen,
                    Parrafo = parametros.Parrafo,
                    Titulo = parametros.Titulo
                });
        }
        public async Task<ObservableCollection<Mdiario>> Mostrardiarios()
        {
            var data = await Task.Run(() => Cconexion.firebase
                .Child("Diario")
                .AsObservable<Mdiario>()
                .AsObservableCollection()
                );
                //.Where(a => a.Titulo != "-"));

            return data;

            //return (await Cconexion.firebase
            //    .Child("Diario")
            //    .OnceAsync<Mdiario>())
            //    .Select(item => new Mdiario
            //    {
            //        Iddiario=item.Key,
            //        Titulo=item.Object.Titulo,
            //        Parrafo=item.Object.Parrafo,
            //        Colorfondo=item.Object.Colorfondo,
            //        Fecha=item.Object.Fecha,
            //        Imagen=item.Object.Imagen,  

            //    }).ToList();
        }
    }
}
