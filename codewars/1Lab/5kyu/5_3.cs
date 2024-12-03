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
