﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccesoDatos.Entidades
{
   public class User
    {
      public int id { get; set; }
      public string username { get; set; }
      public string password { get; set; }
      public string email { get; set; }
      public int role { get; set; }
    }
}
