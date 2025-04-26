using System;
using System.Windows.Forms;

namespace PTB2App_New
{
    public partial class Form1 : Form
    {
        private readonly DatabaseManager _databaseManager;

        public Form1()
        {
            InitializeComponent();
            _databaseManager = new DatabaseManager(AppConfig.ConnectionString);
            InitializeDatabaseAsync();
        }

        private async void InitializeDatabaseAsync()
        {
            try
            {
                await _databaseManager.InitializeDatabaseAsync();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error initializing database: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void buttonSolve_Click(object sender, EventArgs e)
        {
            try
            {
                if (!QuadraticSolver.TryParseDouble(textBoxCoefficientA.Text, out double a))
                {
                    MessageBox.Show("Please enter a valid real number for coefficient a.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    textBoxCoefficientA.Focus();
                    return;
                }

                if (!QuadraticSolver.TryParseDouble(textBoxCoefficientB.Text, out double b))
                {
                    MessageBox.Show("Please enter a valid real number for coefficient b.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    textBoxCoefficientB.Focus();
                    return;
                }

                if (!QuadraticSolver.TryParseDouble(textBoxCoefficientC.Text, out double c))
                {
                    MessageBox.Show("Please enter a valid real number for coefficient c.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    textBoxCoefficientC.Focus();
                    return;
                }

                string result = QuadraticSolver.Solve(a, b, c);
                textBoxResult.Text = result;

                try
                {
                    await _databaseManager.SaveEquationAsync(a, b, c, result);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error saving to database: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            textBoxCoefficientA.Clear();
            textBoxCoefficientB.Clear();
            textBoxCoefficientC.Clear();
            textBoxResult.Clear();
        }

        private void buttonViewHistory_Click(object sender, EventArgs e)
        {
            using (HistoryForm historyForm = new HistoryForm(_databaseManager))
            {
                historyForm.ShowDialog();
            }
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
