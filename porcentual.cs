using System;

public class Porcentual
{
    static void mostrarMatriz(int[,] matriz)
    {
        for (int i = 0; i < matriz.GetLength(0); i++)
        {
            for (int j = 0; j < matriz.GetLength(1); j++)
            {
                Console.Write(matriz[i, j] + " ");
            }
            Console.WriteLine();
        }
    }

    static double[] calcularPercentualDesmatamento(int[,] matriz)
    {
        double soma = 0;

        for (int i = 0; i < matriz.GetLength(0); i++)
        {
            for (int j = 0; j < matriz.GetLength(1); j++)
            {
                if (matriz[i, j] == 0)
                {
                    soma++;
                }
            }
        }

        double percentual = (soma / 36) * 100;

        return new double[] { percentual };
    }

    static void analisarAumento(int[,] matrizAnterior, int[,] matrizAtual)
    {
        double anterior = calcularPercentualDesmatamento(matrizAnterior)[0];
        double atual = calcularPercentualDesmatamento(matrizAtual)[0];

        Console.WriteLine("6 meses atrás: " + anterior.ToString("F2") + "%");
        Console.WriteLine("Atual: " + atual.ToString("F2") + "%");
        Console.WriteLine("Aumento: " + (atual - anterior).ToString("F2") + "%");
    }

    static void Main()
    {
        int[,] matrizAnterior =
        {
            {2,2,2,2,1,1},
            {2,2,2,1,1,0},
            {2,2,2,1,0,0},
            {2,2,1,1,0,0},
            {2,2,1,0,0,0},
            {2,1,1,0,0,0}
        };

        int[,] matrizAtual =
        {
            {2,2,2,1,1,0},
            {2,2,1,1,0,0},
            {2,2,1,1,0,0},
            {2,1,1,0,0,0},
            {2,1,0,0,0,0},
            {1,1,0,0,0,0}
        };

        Console.WriteLine("Matriz 6 meses atrás:");
        mostrarMatriz(matrizAnterior);

        Console.WriteLine("\nMatriz atual:");
        mostrarMatriz(matrizAtual);

        analisarAumento(matrizAnterior, matrizAtual);
    }
}