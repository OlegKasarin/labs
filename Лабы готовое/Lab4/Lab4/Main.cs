using System;
using System.Collections.Generic;
using System.Drawing;
using System.Reflection;
using System.Windows.Forms;

namespace Lab4
{
    public partial class Main : Form
    {
        public static readonly string path = "MinskPhonebook.txt";
        Assembly assembly = null;
        object obj = null;
        Type type = null;

        // Constructor with no parameters
        public Main()
        {
            InitializeComponent();
        }

        // Load form
        private void Main_Load(object sender, EventArgs e)
        {
            // Create dll object by .dll file
            assembly = Assembly.Load("Lab4Dll");

            // Creating obj using name class and create type using name class
            obj = assembly.CreateInstance("ConnectorTxt");
            type = assembly.GetType("ConnectorTxt");

            // Create method by name and use method with parameter
            type.GetMethod("Set").Invoke(obj, new object[] { path });
 
            // Create method by name and use method without parameter
            type.GetMethod("WriteFileToMemory").Invoke(obj, null);

            // Create method by name and use binding source to hold dummy data
            LoadAllRecords(null);
        }

        // Close application
        private void exitToolStripMenuItem_Click(object sender, EventArgs e) => Application.Exit();

        // Search data
        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbSearch.Text))
            {
                MessageBox.Show("Text field is empty!");
            }
            else
            {
                int i, j = 0;
                for (i = 0; i < dgvMain.ColumnCount; i++)
                {
                    for (j = 0; j < dgvMain.RowCount; j++)
                    {
                        dgvMain[i, j].Style.BackColor = Color.White;
                        dgvMain[i, j].Style.ForeColor = Color.Black;
                    }
                }
                for (i = 0; i < dgvMain.ColumnCount; i++)
                {
                    for (j = 0; j < dgvMain.RowCount; j++)
                    {
                        if ((dgvMain[i, j].FormattedValue.ToString().Contains(tbSearch.Text.Trim())))
                        {
                            dgvMain[i, j].Style.BackColor = Color.Navy;
                            dgvMain[i, j].Style.ForeColor = Color.White;
                        }
                    }
                }
            }
        }

        // Clear search field
        private void btnClear_Click(object sender, EventArgs e)
        {
            tbSearch.Clear();
            int i, j;

            for (i = 0; i <= dgvMain.ColumnCount - 1; i++)
            {
                for (j = 0; j <= dgvMain.RowCount - 1; j++)
                {
                    dgvMain[i, j].Style.BackColor = Color.White;
                    dgvMain[i, j].Style.ForeColor = Color.Black;
                }
            }
        }

        // Search by index
        private void btnSearcIndex_Click(object sender, EventArgs e) => LoadAllRecords(type.GetMethod("GetIndex").Invoke(obj, new object[] { int.Parse(nudIndex.Text) }));

        // Load all records
        private void btnLoadAll_Click(object sender, EventArgs e) => LoadAllRecords(null);

        // Load all records method
        public void LoadAllRecords(object dataSourceObj)
        {
            // Create method by name and use binding source to hold dummy data

            if (dataSourceObj != null)
            {
                dgvMain.DataSource = new BindingSource
                {
                    // Using method without parameter
                    DataSource = dataSourceObj
                };
            }
            else
            {
                dgvMain.DataSource = new BindingSource
                {
                    // Using method without parameter
                    DataSource = type.GetMethod("ReadFileFromMemory").Invoke(obj, null)
                };
            }

            try
            {
                dgvMain.Columns[0].HeaderText = "Id";
                dgvMain.Columns[1].HeaderText = "Phone";
                dgvMain.Columns[2].HeaderText = "Second name";
                dgvMain.Columns[3].HeaderText = "First name";
                dgvMain.Columns[4].HeaderText = "Middle name";
                dgvMain.Columns[5].HeaderText = "Street";
                dgvMain.Columns[6].HeaderText = "House";
                dgvMain.Columns[7].HeaderText = "Housing";
                dgvMain.Columns[8].HeaderText = "Flat";
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }
    }
}