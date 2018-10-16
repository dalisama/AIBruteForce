using System;
using System.Linq;
using System.Windows.Forms;

namespace AIBruteForce
{
    public partial class Safe : Form
    {

        private GeneticAlgo _geneticAlgo;
        public Safe(double mutation, int population, string combination, int crossOver, int fitness)
        {
            var crossoverFunction = new string[] { "the fittest", "fifty - fifty", "default" };
            var fitnessFunction = new string[] { "x1", "x100","x1000","x10000","Exp" };
            InitializeComponent();

            _geneticAlgo = new GeneticAlgo(mutation, population, combination, crossOver, fitness);
            Combinationlbl.Text = combination;
            PopulationLbl.Text = "Population: " + population;
            MutationRateLbl.Text = "Mutation Rate: " + mutation;
            CrossoverFunctionLbl.Text = "Crossover function: " + crossoverFunction[crossOver];
            FitnessFunctionLbl.Text = "Fitness scaling: " + fitnessFunction[fitness];
            _geneticAlgo.GenerateFirstPopulation();



        }

  

        private void StartBtn_Click(object sender, EventArgs e)
        {
            var best = 0.0;
            var generation = 0;
            while (true)
            {

                _geneticAlgo.CalculateFitness();
                var maxVal = _geneticAlgo.Fitness.Max();
                if (maxVal > best)
                {
                    best = maxVal;
                }
                BestFitnesslbl.Text = "fitness " + maxVal.ToString("0.00") + "/" + best.ToString("0.00");
                var bestResult = _geneticAlgo.Population[Array.IndexOf(_geneticAlgo.Fitness, maxVal)];
                BestDNaLbl.Text = bestResult;

                PopulationDnaMltylineTxtBox.Text = string.Join("\r\n", _geneticAlgo.Population);
                Generationlbl.Text = "Generation: " + generation;
                CombinationSIzelbl.Text = "Key size: " + _geneticAlgo.ComBination.Length;
                CompletedLbl.Text = "status: " + ((double)(_geneticAlgo.status * 100) / (double)_geneticAlgo.ComBination.Length).ToString("0.00");
                this.Refresh();
                if (bestResult == _geneticAlgo.ComBination)
                {
                    MessageBox.Show("Done!!!!");
                    break;
                }
                _geneticAlgo.GenerateNewPopulation();
                generation++;
            }
        }
    }
}
