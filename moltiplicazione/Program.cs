using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace moltiplicazione
{
    
    class Program
    {
        static void Main(string[] args)
        {
            var calc1 = new CalcMoltSatndard();
            calc1.Moltiplicazione();
            Console.ReadLine();
            var calc2 = new CalcMoltContadino();
            calc2.Moltiplicazione();
            Console.ReadLine();
        }
    }

    abstract class Calcolatrice : ICalcolatrice
    {
        int x, y, z;
        protected virtual void PowerOn()
        {
            Console.WriteLine("La calcolatrice è accesa");
        }

        private void Canc()
        {
            Console.WriteLine("Cancello");
        }

        private void InputX()
        {
            Console.Write("Inserisci primo fattore -> ");
            x = Convert.ToInt32(Console.ReadLine());
        }

        private void InputY()
        {
            Console.Write("Inserisci secondo fattore -> ");
            y = Convert.ToInt32(Console.ReadLine());
        }
       
        protected abstract int Molt(int x, int y);
       private void WriteRes(int z)
        {
            Console.WriteLine("La moltiplicazione è -> "+z);
        }
        private void PowerOff()
        {

            Console.WriteLine("La calcolatrice è spenta");
        }

        public void Moltiplicazione()
        {
            PowerOn();
            Canc();
            InputX();
            InputY();
            z = Molt(x, y);
            WriteRes(z);
            PowerOff();
        }
    }

    public interface ICalcolatrice
    {
        void Moltiplicazione();
    }

    class CalcMoltSatndard : Calcolatrice
    {
        protected override int Molt(int x,int y)
        {
            return x * y;
        }
        protected override void PowerOn()
        {
            Console.WriteLine("Calcolatrice Moltiplicazione Standard:");
            base.PowerOn();
        }
    }

    class CalcMoltContadino : Calcolatrice
    {
        protected override int Molt(int x, int y)
        {
            int z=0;
            for (int i=0; i < y; i++)
            {
                z += x;
            }
            return z;
        }
        protected override void PowerOn()
        {
            Console.WriteLine("Calcolatrice Moltiplicazione Contadino:");
            base.PowerOn();
        }
    }
}
