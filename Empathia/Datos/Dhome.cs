using Empathia.Modelo;
using Empathia.Conexion;
using Firebase.Database.Query;
using System.Linq;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using Firebase.Database;


namespace Empathia.Datos
{
    public class Dhome{ 
        public async Task<ObservableCollection<ImagenInicio>> Mostrarrecomendaciones()
        {
            var data = await Task.Run(() => Cconexion.firebase
                .Child("Recomendaciones")
                .AsObservable<ImagenInicio>()
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


