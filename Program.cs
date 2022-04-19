using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _59DersDeconstructorMetotu
{
    class Program
    {   
        class Insan
        {
            public Insan()
            {
                Console.WriteLine("Obje olusturuldu...");
            }

            ~Insan() //Tilda isareti ile deconsturctor metotu kurulur.
            {
                Console.WriteLine("Obje yok edildi...");
            }
        }
        static void Main(string[] args)
        {

            objeleriOlustur();
            GC.Collect(); //Cop toplayici olarak gecer.
        }

        static void objeleriOlustur()
        {
            Insan i2 = new Insan();
            Insan i1 = new Insan();
        }
    }
}
