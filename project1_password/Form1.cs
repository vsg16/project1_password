using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using static System.Console;



namespace project1_password
{
    public partial class Form1 : Form
    {

        bool Low_reg_checked = false;
        bool High_reg_checked = false;
        bool Special_symbol_checked = false;
        bool Numbers_symbol_checked = false;



        public Form1()
        {
            InitializeComponent();
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void button_generate_Click(object sender, EventArgs e)
        {
            my_password_class my_class = new my_password_class();
            var password = my_class.GetPass(Low_reg_checked, High_reg_checked, Special_symbol_checked, Numbers_symbol_checked);
            textBox1.Text = password;
            textBox2.Text = (Convert.ToString(password.Length));
            //string file = @"Textfile_pass.txt";
            //File.Create(file);
            string path = @"C:\temp\readmePASS.txt";
            string contents = password;

            File.WriteAllText(path, contents);
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Power_Al_label_Click(object sender, EventArgs e)
        {

        }

        private void Low_reg_check_CheckedChanged(object sender, EventArgs e)
        {
            if (Low_reg_checked == false)
            {
                Low_reg_checked = true;
            }
            else
                Low_reg_checked = false;
        }

        private void high_regs_check_CheckedChanged(object sender, EventArgs e)
        {
            if (High_reg_checked == false)
            {
                High_reg_checked = true;
            }
            else
                High_reg_checked = false;
        }

        private void Special_symbols_check_CheckedChanged_1(object sender, EventArgs e)
        {
            if (Special_symbol_checked == false)
            {
                Special_symbol_checked = true;
            }
            else
                Special_symbol_checked = false;
        }

        private void Numbers_symbols_check_CheckedChanged(object sender, EventArgs e)
        {
            if (Numbers_symbol_checked == false)
            {
                Numbers_symbol_checked = true;
            }
            else
                Numbers_symbol_checked = false;
        }
      
     }
}

    
