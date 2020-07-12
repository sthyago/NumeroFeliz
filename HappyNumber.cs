using System;
using System.Collections.Generic;
using System.Linq;

namespace TesteAuvoNumeroFeliz
{
    class Program
    {
        static void Main(string[] args) 
        {
            Console.WriteLine("4 é feliz? {0}", CheckHappiness(4));
            Console.WriteLine("30 é feliz? {0}", CheckHappiness(30));
            Console.WriteLine("7 é feliz? {0}", CheckHappiness(7));           
            Console.WriteLine("49 é feliz? {0}", CheckHappiness(49));

        }

        static bool CheckHappiness(int numero){

            var listaNumeros = SepararDigitoNumero(numero);

            ElevaNumerosAoQuadrado(listaNumeros);

            if (TemMenosDeDoisAlgarismos(listaNumeros.First()))
            {
                return listaNumero.First() == 1;
            }

            return EhFeliz(SomaListaQuadrados(listaNumeros));
        }

        static bool TemMenosDeDoisAlgarismos(int numero){
            return numero < 10;
        }

        static List<int> SepararDigitoNumero(int numero)
        {
            var numeroComoString = numero.ToString();

            var listaNumeros = new List<int>();

            foreach (var algarismo in numeroComoString)
            {
                listaNumeros.Add((int) char.GetNumericValue(algarismo));
            }
            
            return listaNumeros;
        }

        static void ElevaNumerosAoQuadrado(List<int> listaNumeros)
        {
            for (int i = 0; i < listaNumeros.Count; i++)
            {
                listaNumeros[i] = listaNumeros[i] * listaNumeros[i];
            }
        }

        static int SomaListaQuadrados(List<int> listaNumeros)
        {
            return listaNumeros.Sum();
        }
    }
