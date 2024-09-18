internal class Program
{
    private static void Main(string[] args)
    {
        int vitorias = 0;
        int empates = 0;
        int derrotas = 0;
        int jogadnv;

        do
        {
            Console.WriteLine("Escolha se você vai jogar Pedra, Papel ou Tesoura");
            string jogada = Console.ReadLine();
            Random random = new Random();
            switch (jogada)
            {
                case "Pedra":
                    Console.WriteLine("Você jogou: Pedra");
                    if (random.Next(1, 4) == 1)
                    {
                        Console.WriteLine("A máquina jogou: Pedra, Empate");
                        empates++;
                    }
                    else if (random.Next(1, 4) == 2)
                    {
                        Console.WriteLine("A máquina jogou: Papel, Derrota");
                        derrotas++;
                    }
                    else if (random.Next(1, 4) == 3)
                    {
                        Console.WriteLine("A máquina jogou: Tesoura, Vitória");
                        vitorias++;
                    }
                    break;

                case "Papel":
                    Console.WriteLine("Você jogou: Papel");
                    if (random.Next(1, 4) == 1)
                    {
                        Console.WriteLine("A máquina jogou: Pedra, Vitória");
                        vitorias++;
                    }
                    else if (random.Next(1, 4) == 2)
                    {
                        Console.WriteLine("A máquina jogou: Papel, Empate");
                        empates++;
                    }
                    else if (random.Next(1, 4) == 3)
                    {
                        Console.WriteLine("A máquina jogou: Tesoura, Derrota");
                        derrotas++;
                    }
                    break;

                case "Tesoura":
                    Console.WriteLine("Você jogou: Tesoura");
                    if (random.Next(1, 4) == 1)
                    {
                        Console.WriteLine("A máquina jogou: Pedra, Derrota");
                        derrotas++;
                    }
                    else if (random.Next(1, 4) == 2)
                    {
                        Console.WriteLine("A máquina jogou: Papel, Vitória");
                        vitorias++;
                    }
                    else if (random.Next(1, 4) == 3)
                    {
                        Console.WriteLine("A máquina jogou: Tesoura, Empate");
                        empates++;
                    }
                    break;
                default:
                    break;
            }
            Console.WriteLine($"Vitórias: {vitorias} \nDerrotas: {derrotas}\n Empates: {empates}");
            Console.WriteLine("Deseja jogar de novo? (Digite 1 para sim e 2 para não)");
            jogadnv = int.Parse(Console.ReadLine());
        }
        while (jogadnv == 1);

        Console.WriteLine($"Fim de jogo.\nVitórias: {vitorias} \nDerrotas: {derrotas}\n Empates: {empates}");
    }
}