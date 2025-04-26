using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace PTB2App_New
{
    public partial class HistoryForm : Form
    {
        private readonly DatabaseManager _databaseManager;
        private DataGridView dataGridViewHistory;
        private Button buttonDelete;
        private Button buttonClose;

        public HistoryForm(DatabaseManager databaseManager)
        {
            _databaseManager = databaseManager;
            InitializeComponent();
            LoadHistory();
        }

        private void InitializeComponent()
        {
            this.dataGridViewHistory = new DataGridView();
            this.buttonDelete = new Button();
            this.buttonClose = new Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewHistory)).BeginInit();
            this.SuspendLayout();
            
            this.dataGridViewHistory.AllowUserToAddRows = false;
            this.dataGridViewHistory.AllowUserToDeleteRows = false;
            this.dataGridViewHistory.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewHistory.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewHistory.Location = new System.Drawing.Point(12, 12);
            this.dataGridViewHistory.Name = "dataGridViewHistory";
            this.dataGridViewHistory.ReadOnly = true;
            this.dataGridViewHistory.RowHeadersWidth = 51;
            this.dataGridViewHistory.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewHistory.Size = new System.Drawing.Size(776, 350);
            this.dataGridViewHistory.TabIndex = 0;
            
            this.buttonDelete.Location = new System.Drawing.Point(12, 380);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(150, 38);
            this.buttonDelete.TabIndex = 1;
            this.buttonDelete.Text = "Delete Selected";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            
            this.buttonClose.Location = new System.Drawing.Point(638, 380);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(150, 38);
            this.buttonClose.TabIndex = 2;
            this.buttonClose.Text = "Close";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 430);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.dataGridViewHistory);
            this.Name = "HistoryForm";
            this.Text = "Equation History";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewHistory)).EndInit();
            this.ResumeLayout(false);
        }

        private async void LoadHistory()
        {
            try
            {
                DataTable dataTable = await _databaseManager.GetHistoryAsync();
                dataGridViewHistory.DataSource = dataTable;
                
                if (dataGridViewHistory.Columns.Contains("Id"))
                    dataGridViewHistory.Columns["Id"].HeaderText = "ID";
                if (dataGridViewHistory.Columns.Contains("A"))
                    dataGridViewHistory.Columns["A"].HeaderText = "Coefficient A";
                if (dataGridViewHistory.Columns.Contains("B"))
                    dataGridViewHistory.Columns["B"].HeaderText = "Coefficient B";
                if (dataGridViewHistory.Columns.Contains("C"))
                    dataGridViewHistory.Columns["C"].HeaderText = "Coefficient C";
                if (dataGridViewHistory.Columns.Contains("KetQua"))
                    dataGridViewHistory.Columns["KetQua"].HeaderText = "Result";
                if (dataGridViewHistory.Columns.Contains("NgayGiai"))
                    dataGridViewHistory.Columns["NgayGiai"].HeaderText = "Solve Date";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading history: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void buttonDelete_Click(object sender, EventArgs e)
        {
            if (dataGridViewHistory.SelectedRows.Count > 0)
            {
                DialogResult result = MessageBox.Show("Are you sure you want to delete the selected record(s)?", 
                    "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                
                if (result == DialogResult.Yes)
                {
                    try
                    {
                        foreach (DataGridViewRow row in dataGridViewHistory.SelectedRows)
                        {
                            int id = Convert.ToInt32(row.Cells["Id"].Value);
                            await _databaseManager.DeleteEquationAsync(id);
                        }
                        LoadHistory(); // Refresh the grid
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error deleting record: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select a record to delete.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
