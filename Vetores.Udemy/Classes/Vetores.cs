using System;
using System.Globalization;

namespace Vetores.Udemy
{
    public class Vetores
    {
         public string Nome {get; set;}
         public string Email {get; set;}
         public int Quarto {get; set;}

         public Vetores(string nome, string email)
         {
             Nome = nome;
             Email = email;
         }

        public override string ToString()
        {
            return Nome + "," + Email;
        }

    }

}    