using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinForms_NetCore
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            dateTimePicker1.AccessibleName = labelBirthday.Text;

            SetupDataGridView();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SetupDataGridView()
        {
            testDataGridView.Columns.Add(
                new DataGridViewTextBoxColumn());
            testDataGridView.Columns.Add(
                new DataGridViewButtonColumn());
            testDataGridView.Columns.Add(
                new DataGridViewCheckBoxColumn());
            testDataGridView.Columns.Add(
                new DataGridViewComboBoxColumn());
            testDataGridView.Columns.Add(
                new DataGridViewImageColumn());
            testDataGridView.Columns.Add(
                new DataGridViewLinkColumn());

            for (int i = 0; i < testDataGridView.Columns.Count; ++i)
            {
                testDataGridView.Columns[i].Width = 200;
            }

            testDataGridView.Rows.Add();
            testDataGridView.Rows.Add();
            testDataGridView.Rows.Add();
            testDataGridView.Rows.Add();
            testDataGridView.Rows.Add();

            testDataGridView.ScrollBars = ScrollBars.Both;
        }
    }
}
