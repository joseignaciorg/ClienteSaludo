using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClienteSaludos.ServiciosSaludos;

namespace ClienteSaludos
{
    class Program
    {
        static void Main(string[] args)
        {
            var s=new SaludosServiceClient();
            var saludo=new Saludo() {Idioma = "tr",Nombre = "Nacho"};

            try
            {//hola
                var r = s.Saludar(saludo);
                Console.WriteLine(r);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            Console.ReadLine();
        }
    }
}
