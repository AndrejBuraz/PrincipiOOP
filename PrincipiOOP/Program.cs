using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrincipiOOP
{
    class GeometrijskoTijelo
    {
        public double Volumen, Oplosje;
        public static int BrojacTijela;

        public GeometrijskoTijelo()
        {

        }

        public GeometrijskoTijelo(double volumen, double oplosje)
        {
            this.Volumen = volumen;
            this.Oplosje = oplosje;
            GeometrijskoTijelo.BrojacTijela++;
        }

        //public double volumen { get => this.volumen; set => this.volumen = value; }
        //public double oplosje { get => this.oplosje; set => this.oplosje = value; }


    }
    class Kugla : GeometrijskoTijelo
    {
        public Kugla() : base()
        {

        }

        public Kugla(double volumen, double oplosje) : base(volumen, oplosje)
        {
        }
    }
    class Kvadar : GeometrijskoTijelo
    {
        public Kvadar() : base()
        {

        }

        public Kvadar(double volumen, double oplosje) : base(volumen, oplosje)
        {
        }
    }
    class Kocka : Kvadar
    {
        public Kocka() : base()
        {

        }

        public Kocka(double volumen, double oplosje) : base(volumen, oplosje)
        {
        }
    }


    internal class Program
    {
        static void Main(string[] args)
        {
            double a, b;
            Console.WriteLine("Unesi volumen kugle: ");
            a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Unesi oplosje kugle: ");
            b = Convert.ToDouble(Console.ReadLine());
            Kugla x = new Kugla(a, b);
            Console.WriteLine("Unesi volumen kvadra: ");
            a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Unesi oplosje kvadra: ");
            b = Convert.ToDouble(Console.ReadLine());
            Kvadar y = new Kvadar(a, b);
            Console.WriteLine("Unesi volumen kocke: ");
            a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Unesi oplosje kocke: ");
            b = Convert.ToDouble(Console.ReadLine());
            Kocka z = new Kocka(a, b);
            Console.WriteLine("Kugla volumen: " + x.Volumen + ", kugla oplosje: " + x.Oplosje);
            Console.WriteLine("Kvadar volumen: " + y.Volumen + ", kugla oplosje: " + y.Oplosje);
            Console.WriteLine("Kocka volumen: " + z.Volumen + ", kugla oplosje: " + z.Oplosje);
            Console.WriteLine("Broj unesenih tijela je: " + GeometrijskoTijelo.BrojacTijela);
            Console.ReadKey();
        }
    }
}
