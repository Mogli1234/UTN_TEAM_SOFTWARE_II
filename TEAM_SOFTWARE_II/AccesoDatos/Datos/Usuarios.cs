﻿using System;
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
         
        #region Verifyis admin
        public int is_Admin(string username, string password)
        {
            int retorno = 0;
            try
            {
                List<User> userList = new List<User>();
                var query = from us in modelo.users
                            select new { us.Username, us.Password, us.Role };
                foreach (var data in query.ToList())
                {

                    userList.Add(new User()
                    {
                        username = data.Username,
                        password = data.Password,
                        role = data.Role
                    });
                }

                foreach (var datos in userList)
                {
                    if (datos.username.Equals(username))
                    {
                        if (datos.password.Equals(password))
                        {
                            
                                retorno = datos.role;
                            

                        }
                    }

                }
            }
            catch (Exception)
            {
                retorno = 0;
            }
            return retorno;
        }
        #endregion

        #region Charger emails from user not admin
        public List<User>ChargerMailsList()
        {
            List<User> mailList = new List<User>();
            try
            {
                var queryList = from n in modelo.users
                    select n;

                foreach (var data in queryList.ToList())
                {
                    mailList.Add(new User()
                    {
                      id = data.id,
                      username = data.Username,
                      password = data.Password,
                      email = data.Email,
                      role = data.Role
                    });
                }
            }
            catch (Exception)
            {
                throw;
            }
            return mailList;
        }
        #endregion

    }
}
