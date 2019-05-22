using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace ConsultaCEP.Model
{
    public class Usuarios
    {
        public string email{get; set;}

        public string senha {get; set;}

        public static implicit operator Entry(Usuarios v)
        {
            throw new NotImplementedException();
        }
    }
}
