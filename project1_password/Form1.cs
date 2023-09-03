using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace project1_password
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }

        bool LR = false;
        bool HR = false;
        bool SSY = false;
        bool N = false;
        bool HRLR = false;
        bool LRSSY = false;
        bool LRN = false;
        bool HRSSY = false;
        bool HRN = false;
        bool SSYN = false;
        bool LRHRSSY = false;
        bool LRHRSSYN = false;
        bool LRHRN = false;
        public void bools(bool LR1, bool HR1, bool SSY1, bool N1, bool HRLR1, bool LRSSY1, bool LRN1, bool HRSSY1, bool HRN1, bool SSYN1, bool LRHRSSY1, bool LRHRN1, bool LRHRSSYN1)
        {
            LR = LR1;
            HR = HR1;
            SSY = SSY1;
            N = N1;
            HRLR = HRLR1;
            LRSSY = LRSSY1;
            LRN = LRN1;
            HRSSY = HRSSY1;
            HRN = HRN1;
            SSYN = SSYN1;
            LRHRSSY = LRHRSSY1;
            LRHRN = LRHRN1;
            LRHRSSYN = LRHRSSYN1;
        }
        bool Low_reg_checked = false;
        bool High_reg_checked = false;
        bool Special_symbol_checked = false;
        bool Numbers_symbol_checked = false;
        int A_ = 0;

        public int generator_special_sym()
        {   
            Random rnd_new = new Random();
            int rnd_num = rnd_new.Next(0, 4);
            int rnd_to_return = 0;
            if (rnd_num == 0)
            {
                rnd_to_return = rnd_new.Next(33, 47);
            }
            else if (rnd_num == 1)
            {
                rnd_to_return = rnd_new.Next(58, 64);
            }
            else if (rnd_num == 2)
            {
                rnd_to_return = rnd_new.Next(91, 96);
            }
            else if (rnd_num == 3)
            {
                rnd_to_return = rnd_new.Next(123, 126);
            }
            return rnd_to_return;
        }

        public string GetPass()
        {
            if ((Low_reg_checked == true) && (!High_reg_checked) && (!Special_symbol_checked) && (!Numbers_symbol_checked))
            {
                A_ = 26;
                bools(true, false, false, false, false, false, false, false, false, false, false, false, false);
            }
            else if ((High_reg_checked == true) && (!Low_reg_checked) && (!Special_symbol_checked) && (!Numbers_symbol_checked))
            {
                A_ = 26;
                bools(false, true, false, false, false, false, false, false, false, false, false, false, false);
            }
            else if ((Special_symbol_checked == true) && (!High_reg_checked) && (!Low_reg_checked) && (!Numbers_symbol_checked))
            {
                A_ = 32;
                bools(false, false, true, false, false, false, false, false, false, false, false, false, false);
            }
            else if ((Numbers_symbol_checked == true) && (!High_reg_checked) && (!Low_reg_checked) && (!Special_symbol_checked))
            {
                A_ = 10;
                bools(false, false, false, true, false, false, false, false, false, false, false, false, false);
            }
            else if ((Low_reg_checked == true) && (High_reg_checked == true) && (!Special_symbol_checked) && (!Numbers_symbol_checked))
            {
                A_ = 52;
                bools(false, false, false, false, true, false, false, false, false, false, false, false, false);
            }
            else if ((Low_reg_checked == true) && (Special_symbol_checked == true) && (!Numbers_symbol_checked) && (!High_reg_checked))
            {
                A_ = 58;
                bools(false, false, false, false, false, true, false, false, false, false, false, false, false);
            }
            else if ((Low_reg_checked == true) && (Numbers_symbol_checked == true) && (!High_reg_checked) && (!Special_symbol_checked))
            {
                A_ = 36;
                bools(false, false, false, false, false, false, true, false, false, false, false, false, false);
            }
            else if ((High_reg_checked == true) && (Special_symbol_checked == true) && (!Numbers_symbol_checked) && (!Low_reg_checked))
            {
                A_ = 58;
                bools(false, false, false, false, false, false, false, true, false, false, false, false, false);
            }
            else if ((High_reg_checked == true) && (Numbers_symbol_checked == true) && (!Low_reg_checked) && (!Special_symbol_checked))
            {
                A_ = 36;
                bools(false, false, false, false, false, false, false, false, true, false, false, false, false);
            }
            else if ((Special_symbol_checked == true) && (Numbers_symbol_checked == true) && (!Low_reg_checked) && (!High_reg_checked))
            {
                A_ = 42;
                bools(false, false, false, false, false, false, false, false, false, true, false, false, false);
            }
            else if ((Low_reg_checked == true) && (High_reg_checked == true) && (Special_symbol_checked == true) && (!Numbers_symbol_checked))
            {
                A_ = 84;
                bools(false, false, false, false, false, false, false, false, false, false, true, false, false);
            }
            else if ((Low_reg_checked == true) && (High_reg_checked == true) && (!Special_symbol_checked) && (Numbers_symbol_checked == true))
            {
                A_ = 62;
                bools(false, false, false, false, false, false, false, false, false, false, false, true, false);
            }
            else if ((Low_reg_checked == true) && (High_reg_checked == true) && (Special_symbol_checked == true) && (Numbers_symbol_checked == true))
            {
                A_ = 94;
                bools(false, false, false, false, false, false, false, false, false, false, false, false, true);
            }
            else
            {
                A_ = 0;
                bools(false, false, false, false, false, false, false, false, false, false, false, false, false);
            }
            string Password = "";
            if (A_ != 0)
            {
                double L = Math.Ceiling(10 / Math.Log10(A_));
                Random rnd_extra = new Random();
                int value_extra = rnd_extra.Next(0, 10);
                L = L + value_extra;
                int intLength = Convert.ToInt32(L);
                int[] arr = new int[intLength];


                /*  LR = LR1;
                  HR = HR1;
                  SSy = SSY1;
                  N = N1;
                  HRLR = HRLR1;
                  LRSSY = LRSSY1;
                  LRN = LRN1;
                  HRSSY = HRSSY1;
                  HRN = HRN1;
                  SSYN = SSYN1;
                  LRHRSSY = LRHRSSY1;
                  LRHRSSYN = LRHRSSYN1; */

                for (int i = 0; i < arr.Length; i++)
                {
                    if (LR == true)
                    {
                        arr[i] = rnd_extra.Next(97, 122);
                    }
                    else if (HR == true)
                    {
                        arr[i] = rnd_extra.Next(65, 90);
                    }
                    else if (N == true)
                    {
                        arr[i] = rnd_extra.Next(48, 57);
                    }
                    else if (SSY == true)
                    {
                        arr[i] = generator_special_sym();
                    }
                    else if (HRLR == true)
                    {
                        Random rnd_new = new Random();
                        int rnd_num = rnd_new.Next(0, 2);
                        if (rnd_num == 0)
                        {
                            arr[i] = rnd_new.Next(97, 122);
                        }
                        else if (rnd_num == 1)
                        {
                            arr[i] = rnd_new.Next(65, 90);
                        }
                    }
                    else if (LRSSY == true)
                    {
                        Random rnd_new = new Random();
                        int rnd_num = rnd_new.Next(0, 2);
                        if (rnd_num == 0)
                        {
                            arr[i] = rnd_new.Next(97, 122);
                        }
                        else if (rnd_num == 1)
                        {
                            arr[i] = generator_special_sym();
                        }
                    }
                    else if (LRN == true)
                    {
                        Random rnd_new = new Random();
                        int rnd_num = rnd_new.Next(0, 2);
                        if (rnd_num == 0)
                        {
                            arr[i] = rnd_new.Next(97, 122);
                        }
                        else if (rnd_num == 1)
                        {
                            arr[i] = rnd_new.Next(48, 57);
                        }
                    }
                    else if (HRSSY == true)
                    {
                        Random rnd_new = new Random();
                        int rnd_num = rnd_new.Next(0, 2);
                        if (rnd_num == 0)
                        {
                            arr[i] = rnd_new.Next(65, 90);
                        }
                        else if (rnd_num == 1)
                        {
                            arr[i] = generator_special_sym();
                        }
                    }
                    else if (HRN == true)
                    {
                        Random rnd_new = new Random();
                        int rnd_num = rnd_new.Next(0, 2);
                        if (rnd_num == 0)
                        {
                            arr[i] = rnd_new.Next(65, 90);
                        }
                        else if (rnd_num == 1)
                        {
                            arr[i] = rnd_new.Next(48, 57);
                        }
                    }
                    else if (SSYN == true)
                    {
                        Random rnd_new = new Random();
                        int rnd_num = rnd_new.Next(0, 2);
                        if (rnd_num == 0)
                        {
                            arr[i] = rnd_new.Next(48, 57);
                        }
                        else if (rnd_num == 1)
                        {
                            arr[i] = generator_special_sym();
                        }
                    }
                    else if (LRHRSSY == true)
                    {
                        Random rnd_new = new Random();
                        int rnd_num = rnd_new.Next(0, 3);
                        if (rnd_num == 0)
                        {
                            arr[i] = rnd_new.Next(97, 122);
                        }
                        else if (rnd_num == 1)
                        {
                            arr[i] = rnd_new.Next(65, 90);
                        }
                        else if (rnd_num == 2)
                        {
                            arr[i] = generator_special_sym();
                        }
                    }
                    else if (LRHRN == true)
                    {
                        Random rnd_new = new Random();
                        int rnd_num = rnd_new.Next(0, 3);
                        if (rnd_num == 0)
                        {
                            arr[i] = rnd_new.Next(97, 122);
                        }
                        else if (rnd_num == 1)
                        {
                            arr[i] = rnd_new.Next(65, 90);
                        }
                        else if (rnd_num == 2)
                        {
                            arr[i] = rnd_new.Next(48, 57);
                        }
                    }
                    else if (LRHRSSYN == true)
                    {
                        Random rnd_new = new Random();
                        int rnd_num = rnd_new.Next(0, 4);
                        if (rnd_num == 0)
                        {
                            arr[i] = rnd_new.Next(97, 122);
                        }
                        else if (rnd_num == 1)
                        {
                            arr[i] = rnd_new.Next(65, 90);
                        }
                        else if (rnd_num == 2)
                        {
                            arr[i] = generator_special_sym();
                        }
                        else if (rnd_num == 3)
                        {
                            arr[i] = rnd_new.Next(48, 57);
                        }
                    }

                        Password += (char)arr[i];
                }

            }
            return Password;
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void button_generate_Click(object sender, EventArgs e)
        {
                var password = GetPass();
                textBox1.Text = password;
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

    
