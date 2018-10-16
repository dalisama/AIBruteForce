using System;
using System.Threading;
using System.Windows.Forms;

namespace AIBruteForce
{
    public partial class Main : Form
    {

        public Main()
        {
            InitializeComponent();
             CrossOverComBoBox.SelectedIndex=0;
            FitnessComboBox.SelectedIndex=0;
        }

        private void BeginBruteForce(object sender, EventArgs e)
        {


            var mutation = Convert.ToDouble(MutationRateTxtBox.Text);
            var population = Convert.ToInt32(PopulationTxtBox.Text);
            var combination = CombinationTxtBox.Text;
            var crossOver = CrossOverComBoBox.SelectedIndex;
            var fitness = FitnessComboBox.SelectedIndex;
            var safe = new Safe(mutation, population, combination, crossOver, fitness);
            new Thread(() => safe.ShowDialog()).Start();


        }





    }
}
