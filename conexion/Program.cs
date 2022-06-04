using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace conexion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using(futbolEntities db= new futbolEntities())
            {
                var list = db.tb_jugadores;
                foreach(var ojugadores in list)
                {
                    Console.WriteLine(ojugadores.nombre);
                }

              
            }
            Console.Read();
        }
    }
}
