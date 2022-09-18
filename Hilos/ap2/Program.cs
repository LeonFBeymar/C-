using System;
using System.Threading;
namespace ap2
{
    class Program
    {
        static void Main(string[] args)
        {
            CuentaBancaria CuentaFamilia = new CuentaBancaria(2000);
            Thread[] hilosPersonas = new Thread[15];

            for (int i = 0; i < 15; i++)
            {
                Thread t = new Thread(CuentaFamilia.VamosRetirarEfectivo);
                hilosPersonas[i] = t;
            }
            for (int i = 0; i < 15; i++)
            {
                hilosPersonas[i].Start();
            }

            // double cantidad = Console
            // cuentaBancaria.RetirarEfectivo()
        }
    }
}