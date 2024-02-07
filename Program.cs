// See https://aka.ms/new-console-template for more information
int n = 3;

int[,] matriz = new int[n , n];

Random random = new Random(); //Se crea un Random para generar valores aleatores


int suma = 0;

Console.WriteLine("Matriz: ");
for (int f = 0; f < n; f++)
{
    for (int c = 0; c < n; c++)
    {
        matriz[f, c] = random.Next(1, 10); // Aqui para generar un numero aleatorio entre 1 y 9
        suma += matriz[f, c];
        Console.Write($"  {matriz[f, c]}");
    }
    Console.WriteLine();
}

int sumaEsquina = matriz[0, 0] + matriz[0, n - 1] + matriz[n - 1, 0] + matriz[n - 1, n - 1];
int sumaPrimeraDiagonal = 0; 
int sumaSegundaDiagonal = 0;
for (int i = 0; i < n; i++)
{
    for (int j = 0; j < n; j++)
    {
        if (i == j)
        {
            sumaPrimeraDiagonal += matriz[i, j];
        }
        if (i == n - 1 - j)
        {
            sumaSegundaDiagonal += matriz[i, j];
        }
    }
}
Console.WriteLine("Sumatoria matriz " + suma);
Console.WriteLine("La suma de la diagonal 1 es de: " + sumaPrimeraDiagonal);
Console.WriteLine("La sumatoria de la otra diagonal es de: " + sumaSegundaDiagonal);
Console.WriteLine("La sumatoria de las esquinas de la matriz es de: " + sumaEsquina);



////Tarea hacer las sumas de las esquinas de una matriz nxn
////Tarea hacer la suma de las diagonales de una matrices