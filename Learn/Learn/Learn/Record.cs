using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Learn
{
    public partial class Record : Form
    {
        public Record()
        {
            InitializeComponent();
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            
        }

        private void BackButton_Click_1(object sender, EventArgs e)
        {
            Form MainForm = Application.OpenForms[0];
            MainForm.Show();
            this.Close();
        }

        private void Record_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "school_08ip213DataSet4.Client". При необходимости она может быть перемещена или удалена.
            this.clientTableAdapter1.Fill(this.school_08ip213DataSet4.Client);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "school_08ip213DataSet2.Service". При необходимости она может быть перемещена или удалена.
            this.serviceTableAdapter.Fill(this.school_08ip213DataSet2.Service);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "school_08ip213DataSet1.Client". При необходимости она может быть перемещена или удалена.
            this.clientTableAdapter.Fill(this.school_08ip213DataSet1.Client);

        }

        private void label3_Click(object sender, EventArgs e)
        {
         
        }

        //Расчет стоимсости после скидки
        decimal Discount(decimal c, decimal d)
        {
            return c - ((d / 100) * c);
        }


        //Расчет времени в секундах
        int TimeInSecunds(int a, int b)
        {
            return a * 3600 + b * 60;
        }


        //Обраотчик кнопки расчета времени окончания занятия
        private void RecordEndButton_Click(object sender, EventArgs e)
        {
            int ch, min, sec;
            ch = Convert.ToInt32(textBox1.Text);
            min = Convert.ToInt32(textBox2.Text);
            sec = TimeInSecunds(ch, min);
            int dur = Convert.ToInt32(textBox3.Text);
            sec = sec + dur;
            textBox4.Text = Convert.ToString((int)sec / 3600);
            sec = sec % 3600;
            textBox5.Text = Convert.ToString((int)sec / 60);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {
           

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }
        //ОБработчик кнопки расчета стоимости после скидки
        private void button1_Click(object sender, EventArgs e)
        {
            decimal cst, dsc, final_cst;
            cst = Convert.ToDecimal(textBox6.Text);
            dsc = Convert.ToDecimal(textBox7.Text);
            final_cst = Discount(cst, dsc);
            textBox8.Text = Convert.ToString(final_cst);
        }
    }
}
