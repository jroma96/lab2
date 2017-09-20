using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using lab_5;
using Rle;
using lab_5.Huffman;
using System.Collections;

namespace lab_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese el nombre del archivo");
            string nombre = Console.ReadLine();
            Console.WriteLine("Ingrese h si desea el metodo huffman o r para el metodo de compresion rle");
            string opcion = Console.ReadLine();
            Console.WriteLine("desea comprimir o descomprimir?");
            StreamReader lector = new StreamReader(nombre);


            string linea = lector.ReadLine();
            string compresor = "";
            while (linea != null)
            {
                compresor = compresor + linea;
                linea = lector.ReadLine();
            }
            Compresor hola = new Compresor(compresor);
            string guardar = Console.ReadLine();
            HuffmanT huffmanTree = new HuffmanT();
            // Huffman tree
            List<Node> Lalista =  huffmanTree.Build(compresor);

            // Encode
            
            if (guardar == "c")
            {
                BitArray encoded = huffmanTree.Encode(compresor);
                if (opcion == "r")
                {
                    {
                        int lineasalida;
                        StreamWriter escritor = new StreamWriter(nombre + ".rlex");

                        string lineaS = hola.Comprime();
                        escritor.WriteLine(lineaS);
                        lector.Close();
                        lineasalida = compresor.Length - lineaS.Length;
                        int prueba = compresor.Length;
                        int prueba2 = lineaS.Length;
                        escritor.Close();
                        Console.WriteLine("Tamaño original : " + compresor.Length);
                        Console.WriteLine("Tamaño Final : " + lineaS.Length);
                        Console.WriteLine("ratio de compresion : " + Convert.ToString(Convert.ToDouble(lineaS.Length) / Convert.ToDouble(prueba)));
                        Console.WriteLine("factor de compresion : " + Convert.ToString((Convert.ToDouble(prueba) / Convert.ToDouble(lineaS.Length))));
                        Console.WriteLine(Convert.ToString(((Convert.ToDouble(prueba2) / (Convert.ToDouble(prueba))) + "%")));
                    }
                }
                    StreamWriter escritor2 = new StreamWriter(nombre + ".chuffman");
                    if (opcion == "h")
                    {

                        foreach (bool bit in encoded)
                        {
                            escritor2.Write((bit ? 1 : 0) + "");
                        }
                    int i = 0;
                    while(i < Lalista.Count)
                    {
                       


                    }
                    }
                    escritor2.Close();

                }
                if (guardar == "d")
                {

                    StreamWriter escritor2 = new StreamWriter(nombre + ".drlex");
                    StreamWriter escritor = new StreamWriter(nombre + ".dhuffman");
                    if (opcion == "r")
                    {
                        escritor2.WriteLine(hola.Descomprimir(compresor));
                        lector.Close();
                        escritor2.Close();
                    }

                    // Decode
                    if (opcion == "h")

                    {
                    BitArray encoded = huffmanTree.Encode(compresor);
                    string decoded = huffmanTree.Decode(encoded);

                        escritor.WriteLine(decoded);

                        escritor.Close();
                    }


                }









            }
        }
    }


