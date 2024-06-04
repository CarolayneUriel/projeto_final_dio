using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrilhaTesteDesafio
{
    internal class Calculadora
    {
        private List<string> listahistorico;

        public Calculadora()
        {
            listahistorico = new List<string>();
        }

        public int Somar(int num1, int num2)
        {
            int result = num1 + num2;
            listahistorico.Insert(0, "Res" + result);
            return result;
        }

        public int Subtrair(int num1, int num2)
        {
            int result = num1 - num2;
            listahistorico.Insert(0, "Res" + result);
            return result;
        }

        public int Multiplicar(int num1, int num2)
        {
            int result = num1 * num2;
            listahistorico.Insert(0, "Res" + result);
            return result;
        }

        public int Dividir(int num1, int num2)
        {
            int result = num1 / num2;
            listahistorico.Insert(0, "Res" + result);
            return result;
        }

        public List<string> historico()
        {
            listahistorico.RemoveRange(3, listahistorico.Count - 3);
            return listahistorico;
        }

    }
}
