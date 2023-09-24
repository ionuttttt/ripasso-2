using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ripasso_2
{
    internal class Program
    {
        static int[] caricamento(int[] arr, int x, int y, int n)//funzione caricamento di un array di N elementi con numeri random compresi tra X e Y
        {

            Random rnd = new Random();
            for (int i = 0; i < n; i++)
            {
                arr[i] = rnd.Next(x, y);
            }
            return arr;
        }

        static int[] troncamento(int[] arr, int x)//funzione  troncamento di un array
        {
            arr = new int[x];
            return arr;
        }

        static bool AggiungiElemento(int[] array, int elem,ref int i)
        {
            bool ins = true;
            //controllo la dimensione dell'array
            if (i < array.Length)
            {
                //inserimento
                array[i] = elem;
                i++;
            }
            else //se l'array è pieno
            {
                ins = false;
            }
            return ins;
        }
        static void aggiunta(int[] array, ref int dimensione, int el)
        {
            //dichiarazioni
            int x, y, temp;
            //aggiunge l'elemento
            if (AggiungiElemento(array, el, ref dimensione))
            {
                Console.WriteLine("Elemento inserito correttamente");
            }
            else
            {
                Console.WriteLine("Array pieno");
            }
            //ciclo per tutti i numeri
            for (x = 0; x < dimensione - 1; x++)
            {
                //per confrontare tutte le coppie
                for (y = 0; y < dimensione - 1; y++)
                {
                    //se la coppia è da scambiare
                    if (array[y] > array[y + 1])
                    {
                        temp = array[y];
                        //faccio avvenire lo scambio
                        array[y] = array[y + 1];
                        array[y + 1] = temp;
                    }
                }
            }
        }
        static void Main(string[] args)
        {
            int n=0, x, y;
            bool g=true;//dichiarazione variabili
           int[] array = new int[10];//dichiarazione dell'array

            while (g == true)
            {
                Console.WriteLine("Inserire la lettera associata alla funzione per selezionarla: \r\na - caricamento di un array di N elementi con numeri random compresi tra X e Y\r\nb - troncamento di un array\r\nc - aggiunta ordinata di numeri in un array\r\nd - stampa array\r\ne - uscita");//output menù
                switch (Console.ReadLine()) //switch che controlla input ricevuto
                {
                    case "a":
                        Console.WriteLine("Inserisci la dimensione dell'array");
                        n = int.Parse(Console.ReadLine());//definizione dimensione array
                        Console.WriteLine("Inserisci il primo limite dei numeri casuali");
                        x = int.Parse(Console.ReadLine());
                        Console.WriteLine("Inserisci il secondo limite dei numeri casuali");
                        y = int.Parse(Console.ReadLine());
                        array = caricamento(array, x, y, n);
                        break;

                    case "b":
                        Console.WriteLine("Inserire la nuova dimensionbe dell'array");
                        x = int.Parse(Console.ReadLine());
                        array = troncamento(array, x);
                        break;
                    case "c":
                        Console.WriteLine("Inserire il numero: ");
                        x = int.Parse(Console.ReadLine());
                        aggiunta(array, ref y, x);
                        Console.WriteLine("Elemento inserito correttamente");
                        break;
                    case "d":
                        for(int i=0; i<n;i++)
                        {
                            Console.WriteLine(array[i]);    
                        }
                        break;
                    case "e":
                        g= false;   
                        break;

                }
            }
            Console.ReadLine();
        }
    }
}

