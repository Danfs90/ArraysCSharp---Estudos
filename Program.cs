using System;
using System.Threading;


namespace ArraysCSharp
{
    class Program
    {
        static void Main(string[] args)
        {   
            Console.Clear();

            var meuArray = new int[5] { 1, 2, 3, 4, 5}; //Para se criar o array é preciso coloca o "new" e a quantidade de itens de do array
            meuArray[0] = 12; // inserindo item no array (CSharp é tipado!!)

            Console.WriteLine(meuArray.Length);

            // for(var index=0; index < meuArray.Length; index++)
            // {
            //         Console.Write(meuArray[index]+/n);
            // }

            foreach (var item in meuArray)
            {
                Console.WriteLine(item); //Foreach percorre o array e exibindo no console (alternativa bem melhor do que o for nornmal)
                Thread.Sleep(5000);
            }

        }
    }
}
