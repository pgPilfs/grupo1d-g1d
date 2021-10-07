using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;



namespace MVCWebApi.Models
{
    public class LoginRespuesta
    {
        public LoginRespuesta(string token, int id)
        {
            Token = token;
            Id = id;
        }


        public string Token { get; set; }
        public int Id { get; set; }


    }
}