using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AccesoDatos.Entidades;
using AccesoDatos.Modelo;

namespace AccesoDatos.Datos
{
    public class Usuarios
    {
        UTN_SPORTS_ModelContainer modelo = new UTN_SPORTS_ModelContainer();
        private bool estado = false;
        User use = new User();

        #region Metodo para insertar usuarios
        public Boolean InsertarUsuario(user oUser)
        {
            try
            {
                if (oUser != null)
                {
                    modelo.users.Add(oUser);
                    modelo.SaveChanges();
                    estado = true;
                }
            }
            catch (Exception)
            {
                
                estado = false;
            }
            return estado;
        }
        #endregion
         
        #region ChargePasswords
        public Boolean verifyUser(string username , string password)
        {
            try
            {
                List<User> userList = new List<User>();
                var query = from us in modelo.users
                            select new { us.Username, us.Password };
                foreach (var data in query.ToList())
                {
                    
                    userList.Add(new User()
                    {
                    username = data.Username,
                    password = data.Password
                    });
                }

                foreach (var datos in userList)
                {
                    if (datos.username.Equals(username))
                    {
                        if (datos.password.Equals(password))
                        {
                            estado = true;
                        }
                    }
                }
            }
            catch (Exception)
            {
                estado = false;
            }
            return estado;
        }
        #endregion
    }
}
