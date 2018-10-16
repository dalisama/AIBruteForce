using System;
using System.Linq;
using System.Windows.Forms;

namespace AIBruteForce
{
    public partial class Safe : Form
    {
        public Safe()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var mutation = Convert.ToDouble(MutationRateTxtBox.Text);
            var population = Convert.ToInt32(PopulationTxtBox.Text);
            var combination = CombinationTxtBox.Text;
            var crossOver = CrossOverComBoBox.SelectedIndex;
            var fitness = FitnessComboBox.SelectedIndex;
            var algo = new GeneticAlgo(mutation, population, combination, crossOver,fitness);
            algo.GenerateFirstPopulation();
            var best = 0.0;
            var generation = 0;
            while (true)
            {
                
                    algo.CalculateFitness();
                    var maxVal = algo.Fitness.Max();
                    if (maxVal > best)
                    {
                        best = maxVal;
                    }
                    BestFitnesslbl.Text = maxVal.ToString("0.00") + "/" + best.ToString("0.00");
                var bestResult= algo.Population[Array.IndexOf(algo.Fitness, maxVal)]; 
                BestDNaLbl.Text = bestResult;

                PopulationDnaMltylineTxtBox.Text = string.Join("\r\n", algo.Population);
                Generationlbl.Text = "Generation: " + generation;
                this.Refresh();
                if (bestResult == algo.ComBination) break;
                algo.GenerateNewPopulation();
                generation++;
            }
        }

      
    }
}
