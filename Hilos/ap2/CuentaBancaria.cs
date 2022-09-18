using System;
namespace ap2
{
    public class CuentaBancaria
    {
        public double Saldo{set; get;}
        public CuentaBancaria(){}
        public CuentaBancaria (double saldo)
        {
            this.Saldo = saldo; 
        }
        public double RetirarEfectivo(double cantidad)
        {
            if ((Saldo - cantidad) < 0 )
            {
                Console.WriteLine($"Lo siento queda {Saldo}$ de saldo en la cuenta");
                return Saldo;
            }
            if (Saldo >= cantidad) 
            {
                System.Console.WriteLine($"Retirado {cantidad}$ y queda {Saldo - cantidad}$ en la cuenta");
                Saldo -= cantidad;
            }
            return Saldo;
        }
        public void VamosRetirarEfectivo()
        {
            RetirarEfectivo(500);
        }
    }
}