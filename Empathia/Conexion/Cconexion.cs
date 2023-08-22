using System;
using System.Collections.Generic;
using System.Text;
using Firebase.Database;

namespace Empathia.Conexion
{
    public class Cconexion
    {
        public static FirebaseClient firebase = new FirebaseClient("https://empathiadb-default-rtdb.firebaseio.com/");
    }
}
