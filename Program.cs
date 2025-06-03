Console.WriteLine("Digite o tamanho desejado da moldura:");

Console.Write("Informe a largura: ");
int larguraMoldura = Convert.ToInt32(Console.ReadLine());

Console.Write("Informe a altura...: ");
int alturaMoldura = Convert.ToInt32(Console.ReadLine());

if (larguraMoldura < 1 || larguraMoldura > 10 || alturaMoldura < 1 || alturaMoldura > 10)
{
    Console.WriteLine("A largura e altura devem estar entre 1 e 10.");
}
else
{
    int linha = 1;

    while (linha <= alturaMoldura)
    {
        Console.WriteLine();

        int coluna = 1;

        while (coluna <= larguraMoldura)
        {
            if (linha == 1 || linha == alturaMoldura)
            {
                Console.Write("*");
            }
            else
            {
                if (coluna == 1 || coluna == larguraMoldura)
                {
                    Console.Write("*");
                }
                else
                {
                    Console.Write(" ");
                }
            }

            coluna++;
        }

        linha++;
    }
}
