Console.Write("Insira o tamanho de sua matriz:");
if (!int.TryParse(Console.ReadLine(), out int tam)) tam = 2;

int[,] matOriginal = new int[tam, tam];
int[,] matInvertida = new int[tam, tam];

// Armazenando em variáveis o comprimento da linha e coluna:
int linha = matOriginal.GetLength(0);
int coluna = matOriginal.GetLength(1);

// Populando matriz original:
Console.WriteLine("\nInserindo valores na matriz, caso valor for inválido, será substituído por zero");
for (int i = 0; i < linha; i++)
{
	for (int j = 0; j < coluna; j++)
	{
		Console.Write("Posição {0}:{1}:", i + 1, j + 1);
		int.TryParse(Console.ReadLine(), out matOriginal[i, j]);
	}
}

// Invertendo matriz:
for (int i = 0; i < linha; i++)
{
	for (int j = 0; j < coluna; j++)
	{
		matInvertida[i, j] = matOriginal[(linha - 1) - i, (coluna - 1) - j];
	}
}

// Exibindo matriz:
Console.Clear();

Console.WriteLine("Matriz original:");
ImprimirMatriz(matOriginal);

Console.WriteLine("Matriz invertida:");
ImprimirMatriz(matInvertida);

void ImprimirMatriz(int[,] mat)
{
	for (int i = 0; i < mat.GetLength(0); i++)
	{
		for (int j = 0; j < mat.GetLength(1); j++)
		{
            Console.Write("\t {0} \t", mat[i, j]);
        }
        Console.WriteLine();
    }
}