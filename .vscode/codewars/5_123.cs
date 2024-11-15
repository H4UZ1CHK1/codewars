//1
using System;

public class TicTacToe
{
    public int IsSolved(int[,] board)
    {
        for (int i = 0; i < 3; i++)
        {
            if (board[i, 0] == board[i, 1] && board[i, 1] == board[i, 2])
            {
                if (board[i, 0] != 0)
                    return board[i, 0];
            }
            if (board[0, i] == board[1, i] && board[1, i] == board[2, i])
            {
                if (board[0, i] != 0)
                    return board[0, i];
            }
        }

        if (board[0, 0] == board[1, 1] && board[1, 1] == board[2, 2])
        {
            if (board[0, 0] != 0)
                return board[0, 0];
        }
        if (board[0, 2] == board[1, 1] && board[1, 1] == board[2, 0])
        {
            if (board[0, 2] != 0)
                return board[0, 2];
        }

        foreach (int cell in board)
        {
            if (cell == 0)
                return -1; 
        }

        return 0;
    }
}
//2
var CaesarCipher = function (shift) {
    this.shift = shift;
  
    this.shiftChar = function (char, shift) {
      const charCode = char.charCodeAt(0);
  
      if (charCode >= 65 && charCode <= 90) { 
        return String.fromCharCode(((charCode - 65 + shift) % 26) + 65);
      }
      if (charCode >= 97 && charCode <= 122) { 
        return String.fromCharCode(((charCode - 97 + shift) % 26) + 65);
      }
      return char;
    };
  
    this.encode = function (str) {
      return str.split('').map(char => this.shiftChar(char, this.shift)).join('');
    };
  
    this.decode = function (str) {
      return str.split('').map(char => this.shiftChar(char, 26 - this.shift)).join('');
    };
  };  
//3
using System;
using System.Collections.Generic;
using System.Linq;

public class GeneticAlgorithm
{
    private Random random = new Random();

    public string Generate(int length)
    {
        return new string(Enumerable.Range(0, length).Select(_ => random.Next(2) == 0 ? '0' : '1').ToArray());
    }
    
    public string Select(IEnumerable<string> population, IEnumerable<double> fitnesses, double sum = 0)
    {
        sum = fitnesses.Sum();
        double target = random.NextDouble() * sum;
        double cumulative = 0.0;

        using (var popEnumerator = population.GetEnumerator())
        using (var fitEnumerator = fitnesses.GetEnumerator())
        {
            while (popEnumerator.MoveNext() && fitEnumerator.MoveNext())
            {
                cumulative += fitEnumerator.Current;
                if (cumulative >= target)
                    return popEnumerator.Current;
            }
        }

        return population.First(); 
    }

    public string Mutate(string chromosome, double probability)
    {
        return new string(chromosome.Select(bit =>
            random.NextDouble() < probability ? (bit == '0' ? '1' : '0') : bit
        ).ToArray());
    }

    public IEnumerable<string> Crossover(string chromosome1, string chromosome2)
    {
        if (random.NextDouble() < 0.6)
        {
            int point = random.Next(1, chromosome1.Length);
            string child1 = chromosome1.Substring(0, point) + chromosome2.Substring(point);
            string child2 = chromosome2.Substring(0, point) + chromosome1.Substring(point);
            return new[] { child1, child2 };
        }
        return new[] { chromosome1, chromosome2 };
    }

    public string Run(Func<string, double> fitness, int length, double p_c, double p_m, int iterations = 100)
    {
        List<string> population = Enumerable.Range(0, 100).Select(_ => Generate(length)).ToList();
        for (int i = 0; i < iterations; i++)
        {
            List<double> fitnesses = population.Select(fitness).ToList();
            List<string> newPopulation = new List<string>();

            for (int j = 0; j < population.Count / 2; j++)
            {
                string parent1 = Select(population, fitnesses);
                string parent2 = Select(population, fitnesses);

                foreach (var child in Crossover(parent1, parent2))
                {
                    newPopulation.Add(Mutate(child, p_m));
                }
            }
            population = newPopulation;
        }
        
        return population.OrderByDescending(fitness).First();
    }
}
