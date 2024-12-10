using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Learn
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();

            //Деавктивация кнопок
            this.serviceTableAdapter.Fill(this.school_08ip213DataSet.Service);
            EditButton.Enabled = false;
            RecordButton.Enabled = false;
            ViewButton.Enabled = false;
        }

        

        private void EditButton_Click(object sender, EventArgs e)
        {
            Edit Edit = new Edit();
            Edit.Show();
            this.Hide();
        }

        private void RecordButton_Click(object sender, EventArgs e)
        {
            Record Record = new Record();
            Record.Show();
            this.Hide();
        }

        private void ViewButton_Click(object sender, EventArgs e)
        {
            View View = new View();
            View.Show();
            this.Hide();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "school_08ip213DataSet.Service". При необходимости она может быть перемещена или удалена.
            this.serviceTableAdapter.Fill(this.school_08ip213DataSet.Service);

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
                    }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        //Проверка корректности введенного кода
        private void button1_Click(object sender, EventArgs e)
        {
            if (CodeBox.Text == "0000")
            {
                EditButton.Enabled = true;
                RecordButton.Enabled = true;
                ViewButton.Enabled = true;
            }
            else {
                MessageBox.Show("Неверный код администратора!");
            }
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
