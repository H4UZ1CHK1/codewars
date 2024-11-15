//5_1
using System;

class Program
{
    public static int IsSolved(int[,] board)
    {
        bool CheckWinner(int player)
        {
            for (int i = 0; i < 3; i++)
            {
                if (board[i, 0] == player && board[i, 1] == player && board[i, 2] == player) return true;
                if (board[0, i] == player && board[1, i] == player && board[2, i] == player) return true;
            }
            if (board[0, 0] == player && board[1, 1] == player && board[2, 2] == player) return true;
            if (board[0, 2] == player && board[1, 1] == player && board[2, 0] == player) return true;
            return false;
        }

        if (CheckWinner(1)) return 1;
        if (CheckWinner(2)) return 2;

        foreach (int cell in board)
        {
            if (cell == 0) return -1;
        }

        return 0;
    }

    static void Main()
    {
        int[,] board = { { 1, 1, 1 }, { 0, 2, 0 }, { 2, 0, 0 } };
        Console.WriteLine(IsSolved(board)); // Пример
    }
}

//5_2
using System;

class CaesarCipher
{
    private int Shift;

    public CaesarCipher(int shift)
    {
        Shift = shift;
    }

    private char ShiftChar(char c, int shift)
    {
        if (char.IsUpper(c))
        {
            return (char)((c - 'A' + shift) % 26 + 'A');
        }
        if (char.IsLower(c))
        {
            return (char)((c - 'a' + shift) % 26 + 'a');
        }
        return c;
    }

    public string Encode(string str)
    {
        return string.Concat(str.Select(c => ShiftChar(c, Shift)));
    }

    public string Decode(string str)
    {
        return string.Concat(str.Select(c => ShiftChar(c, 26 - Shift)));
    }
}

//5_3
using System;
using System.Collections.Generic;
using System.Linq;

class GeneticAlgorithm
{
    private Random _rand = new Random();

    public string Generate(int length)
    {
        return string.Concat(Enumerable.Range(0, length).Select(_ => _rand.Next(2).ToString()));
    }

    public string Select(List<string> population, List<int> fitnesses)
    {
        int sum = fitnesses.Sum();
        int pick = _rand.Next(sum);
        int current = 0;

        for (int i = 0; i < population.Count; i++)
        {
            current += fitnesses[i];
            if (current > pick)
            {
                return population[i];
            }
        }
        return population.Last();
    }

    public string Mutate(string chromosome, double p)
    {
        return string.Concat(chromosome.Select(gene => _rand.NextDouble() < p ? (gene == '0' ? '1' : '0') : gene));
    }

    public (string, string) Crossover(string parent1, string parent2)
    {
        if (_rand.NextDouble() < 0.6)
        {
            int crossoverPoint = _rand.Next(parent1.Length);
            return (parent1.Substring(0, crossoverPoint) + parent2.Substring(crossoverPoint),
                    parent2.Substring(0, crossoverPoint) + parent1.Substring(crossoverPoint));
        }
        return (parent1, parent2);
    }

    public string Run(Func<string, int> fitness, int length, double pC, double pM, int iterations = 100)
    {
        List<string> population = Enumerable.Range(0, 100).Select(_ => Generate(length)).ToList();

        for (int i = 0; i < iterations; i++)
        {
            List<int> fitnesses = population.Select(fitness).ToList();
            List<string> newPopulation = new List<string>();

            while (newPopulation.Count < 100)
            {
                string parent1 = Select(population, fitnesses);
                string parent2 = Select(population, fitnesses);

                (string offspring1, string offspring2) = Crossover(parent1, parent2);
                newPopulation.Add(Mutate(offspring1, pM));
                newPopulation.Add(Mutate(offspring2, pM));
            }

            population = newPopulation.Take(100).ToList();
        }

        return population.OrderByDescending(fitness).First();
    }
}
