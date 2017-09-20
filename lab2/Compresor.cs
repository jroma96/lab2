using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Rle
{
    public class Compresor
    {
        private string entrada;
        private char[] caracter;
        private StringBuilder sb;

        public string salida { get; set; }
        
        public Compresor(string entrada)
        {
            this.entrada = entrada;
            caracter = new char[entrada.Length];
            caracter = entrada.ToCharArray();
            sb = new StringBuilder();
            
        }

        public string Comprime()
        {            
            int i = 0;
            int Iguales;
            while (i < entrada.Length)
            {
                Iguales = IgualRepetido(caracter[i], i);                
                Salida(Iguales, caracter[i]);
                i += Iguales;
                Iguales = 0;                
            }
            return sb.ToString();
            Console.ReadLine();
        }

        private int Aux(char c, int i)
        {            
            char Auxj = caracter[i++];
            int cont = 1;
            while (c == Auxj && i < entrada.Length)
            {             
                cont++;
                Auxj = caracter[i++];
            }
            return cont;
        }

        private int IgualRepetido(char c, int i)
        {
            int cont = 0;
            while (c == caracter[i])
            {
                cont++;
                i++;
                if (i == entrada.Length||cont == 5) break;
            }
            
            return cont;
        }
        public string Descomprimir(string linea )
        { 
            
            int i = 0;
            int numero;
            int j = 0;
            string retorno = "";
            while (i < linea.Length)
                {
                numero = Convert.ToInt32( Convert.ToString(linea[i]));
                j = 1;
                while(j <= numero)
                {
                    retorno = retorno + linea[i + 1];
                    j++;
                }
                i+=2;
                
            }
            return retorno;


          }

        private void Salida(int rep,char c)
        {           
            sb.Append(rep.ToString());
            sb.Append(c);
        }        
    }
}