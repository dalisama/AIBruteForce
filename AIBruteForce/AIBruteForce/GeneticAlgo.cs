using System;
using System.Linq;
using System.Text;

namespace AIBruteForce
{
    public class GeneticAlgo
    {
        public double MutationRate { get; set; }
        public int PopulationSize { get; set; }
        public string[] Population { get; set; }
        public string ComBination { get; set; }
        public double[] Fitness { get; set; }
        public double status { get; set; }

        private Random _rand;
        private int CrossoverMethod;
        private int FitnessMethod;

        public GeneticAlgo(double mutationRate, int populationSize, string comBination, int crossoverMethod, int fitnessMethod)
        {
            MutationRate = mutationRate;
            PopulationSize = populationSize;
            ComBination = comBination;
            Fitness = new double[PopulationSize];
            Population = new string[PopulationSize];
            CrossoverMethod = crossoverMethod;
            FitnessMethod = fitnessMethod;
            _rand = new Random();
            status = 0;
        }
        private char GetRandomChar()
        {
            string chars = " abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890";

            int num = _rand.Next(0, chars.Length - 1);
            return chars[num];
        }
        private string GenerateRandomCombination()
        {
            StringBuilder stringBuilder = new StringBuilder();
            for (int i = 0; i < ComBination.Length; i++)
            {
                stringBuilder.Append(GetRandomChar());
            }
            return stringBuilder.ToString();
        }
        private string CrossoverByTheFittest()
        {
            var fatherIndex = NaturalSelection();
            var motherIndex = NaturalSelection();
            var father = Population[fatherIndex];
            var mother = Population[motherIndex];
            var child = new StringBuilder(father);
            var index = _rand.Next(ComBination.Length);
            for (int i = 0; i < ComBination.Length; i++)
            {
                //if (i>index)
                if (_rand.Next((int)Fitness[motherIndex] + (int)Fitness[fatherIndex]) < Fitness[motherIndex])
                {
                    child[i] = mother[i];
                }
                if (_rand.Next(100) < MutationRate)
                {
                    child[i] = GetRandomChar();
                }
            }
            return child.ToString();
        }
        private string CrossoverFiftyFifty()
        {
            var fatherIndex = NaturalSelection();
            var motherIndex = NaturalSelection();
            var father = Population[fatherIndex];
            var mother = Population[motherIndex];
            var child = new StringBuilder(father);
            var index = _rand.Next(ComBination.Length);
            for (int i = 0; i < ComBination.Length; i++)
            {
                if (_rand.Next(100) < 50)
                {
                    child[i] = mother[i];
                }
                if (_rand.Next(100) < MutationRate)
                {
                    child[i] = GetRandomChar();
                }
            }
            return child.ToString();
        }
        private string CrossoverDefault()
        {
            var fatherIndex = NaturalSelection();
            var motherIndex = NaturalSelection();
            var father = Population[fatherIndex];
            var mother = Population[motherIndex];
            var child = new StringBuilder(father);
            var index = _rand.Next(ComBination.Length);
            for (int i = 0; i < ComBination.Length; i++)
            {
                if (i > index)

                {
                    child[i] = mother[i];
                }
                if (_rand.Next(100) < MutationRate)
                {
                    child[i] = GetRandomChar();
                }
            }
            return child.ToString();
        }
        private string Crossover()
        {
            switch (CrossoverMethod)
            {
                case 0: return CrossoverByTheFittest();
                case 1: return CrossoverFiftyFifty();
                default:
                    return CrossoverDefault();

            }
        }
        public void GenerateFirstPopulation()
        {
            for (int i = 0; i < PopulationSize; i++)
            {
                Population[i] = GenerateRandomCombination();

            }
        }
        public void GenerateNewPopulation()
        {
            var tmpPopulation = new string[PopulationSize];
            for (int i = 0; i < PopulationSize; i++)
            {
                tmpPopulation[i] = Crossover();
            }
            for (int i = 0; i < PopulationSize; i++)
            {
                Population[i] = tmpPopulation[i];
            }
        }
        public void CalculateFitness()
        {
            for (int index = 0; index < PopulationSize; index++)
            {
                var count = 0;
                for (int i = 0; i < ComBination.Length; i++)
                {
                    if (ComBination[i] == Population[index][i]) count++;
                }
                if (status < count) status = count;
                switch (FitnessMethod)
                {
                    case 0:
                        Fitness[index] = count;
                        break;
                    case 1:
                        Fitness[index] = count * 100;
                        break;
                    case 2:
                        Fitness[index] = count * 1000;
                        break;
                    case 3:
                        Fitness[index] = count * 10000;
                        break;
                    case 4:
                        Fitness[index] = Math.Exp(count);
                        break;
                    default:
                        Fitness[index] = count;
                        break;
                }

            }

        }
        private int NaturalSelection()
        {


            var accept = false;
            var rd = 0;
            var rd2 = 0;
            while (!accept)
            {

                rd = _rand.Next(PopulationSize);
                rd2 = _rand.Next((int)Fitness.Max());


                if (rd2 <= Fitness[rd])
                {
                    accept = true;
                }

            }

            return rd;


        }
    }
}
