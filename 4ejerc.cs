using System;


class Ejerc
{
    static void Main(string[] args)
    {
        a numeros = new a { 0, 1, 11, 12, 15, 19 };
        int[] resultado = EncontrarDiferencia(numeros);
        Console.WriteLine($"Encontrar diferencias: {resultado[0]}, m: [{resultado[1]}, {resultado[2]}]");
    }

    static int[] EncontrarDiferencia(List numeros)
    {
        int maxDiferencia = 0;
        int d1 = 0;
        int d2 = 0;

        for (int i = 0; i < numeros.Count - 1; i++)
        {
            int diferencia = Math.Abs((int)numeros[i + 1] - (int)numeros[i]);
            if (diferencia > maxDiferencia)
            {
                maxDiferencia = diferencia;
                d1 = i;
                d2 = i + 1;
            }
        }

        return new int[] { maxDiferencia, indice1, indice2 };
    }
}
