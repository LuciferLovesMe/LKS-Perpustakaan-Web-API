using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LKS_Perpustakaan_Web_API.Models
{
    public class LoginModel
    {
        public int id_user { set; get; }
        public string name { set; get; }
        public string username { set; get; }
        public string password { set; get; }
    }
}