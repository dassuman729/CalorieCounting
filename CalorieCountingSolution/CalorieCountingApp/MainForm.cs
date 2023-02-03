using CalorieCountingApp.Repository;
using System;
using System.Windows.Forms;

namespace CalorieCountingApp
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void btnFindElf_Click(object sender, EventArgs e)
        {
            try
            {
                txtOutput.Text = String.Empty;
                btnFindElf.Enabled = false;
                var elf = new CalorieCalculator(new ElvesRepository()).Calculate(txtInput.Text);
                if (elf != null)
                {
                    txtOutput.Text = $"ElvName: {elf.Name}{Environment.NewLine}Total Calories: {elf.TotalCalories}";
                }
                else
                {
                    txtOutput.Text = "Unable to calculate!";
                }
            }
            catch(Exception ex)
            {
                txtOutput.Text = ex.Message;
            }
            finally
            {
                btnFindElf.Enabled = true;
            }
        }
    }
}
