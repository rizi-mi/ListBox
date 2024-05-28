using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace lab4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            List.SelectedIndexChanged += (object sender, EventArgs e) =>
            {
                int count1 = List.Items.Count;
                textBox14.Text = count1.ToString();
            };

            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox2.Text.Length <= 0) { return; }
            List.Items.Add(textBox2.Text);
            textBox2.Clear();
        }

        private void List_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBox9.Text = (List.SelectedItem).ToString();
            textBox12.Text = (List.SelectedIndex + 1).ToString();
            if (List.Items.Count == 0) textBox16.Text = "Пусто";
            else textBox16.Text = "Список не пуст";
            
        }

        int counter = 0;
        private void button2_Click(object sender, EventArgs e)
        {
            int count1 = List.Items.Count;
            if (textBox5.Text.Length > 0)
            {
                if (List.Items.IndexOf(textBox5.Text) > 0) { textBox7.Text = "N"; }
                else { 
                    int num_ind = int.Parse(textBox5.Text);
                    if (count1 < num_ind) { textBox7.Text = "out"; }
                    else
                    {   
                        num_ind = num_ind - 1;
                        textBox7.Text = "Y";
                        textBox19.Text = List.Items[num_ind].ToString();
                        counter++;
                    }
                 }
                
            }
            textBox21.Text = counter.ToString();
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox21_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
