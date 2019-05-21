using ConsultaCEP.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace ConsultaCEP
{
    public partial class MainPage : ContentPage
    {
        public List<Usuarios> usuarios = new List<Usuarios>();]
        public Usuarios mariana = new Usuarios();
        public Usuarios anderson = new Usuarios();
        public Usuarios bianca = new Usuarios();


        public MainPage()
        {
            mariana.email = "mariana@";
            mariana.senha = "123";
            usuarios.Add(mariana);

            anderson.email = "anderson@";
            anderson.senha = "abc";
            usuarios.Add(anderson);

            bianca.email = "bianca@";
            bianca.senha = "pato";
            usuarios.Add(bianca);


            InitializeComponent();
        }

               
        public void Logar( object obj, EventArgs args)
        {
            
            if(email.Text != null && senha.Text != null && email.Text != "" && senha.Text != "")
            {
                App.Current.MainPage = new NavigationPage(new PageHome());
            }
            else
            {
                DisplayAlert("Alerta", "E-mail ou senha invalidos", "sair");
            }

        }

        
    }
}
