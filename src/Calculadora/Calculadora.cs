using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
//Criaçao de classe calculadora

//Operacões mtématicas
namespace Codigos.ProgramaCalculadora
{
    public class Calculadora
    {
        public void Soma(int x, int y)
        {
            Console.WriteLine($"{x} + {y} = {x + y}");
        }    
        public void Subtrair(int x, int y)
        {
            Console.WriteLine($"{x} - {y} = {x - y}");
        }    
        public void Mltiplicar(int x, int y)
        {
            Console.WriteLine($"{x} x {y} = {x * y}");
        }    
        public void Dividir(int x, int y)
        {
            Console.WriteLine($"{x} / {y} = {x / y}");
        }    
    }
}
