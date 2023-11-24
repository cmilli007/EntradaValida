Console.BackgroundColor = ConsoleColor.Blue;
Console.WriteLine("Entrada Válida\n");
 Console.ResetColor();
int numeroDigitado = -1;
 
while (numeroDigitado < 0 || numeroDigitado > 9)
{
    Console.Write("Digite um número entre 1 e 9 (ou 0 para sair): ");
    numeroDigitado = Convert.ToInt32(Console.ReadLine());
}
 
Console.WriteLine();
 
if (numeroDigitado == 0)
{
    Console.WriteLine("Operação cancelada.\n");
}
 
else {
    Console.WriteLine($"Número selecionado = {numeroDigitado}.");
}
 
Console.WriteLine("Volte sempre!\n");