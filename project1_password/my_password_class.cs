using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project1_password
{
    class my_password_class
    {
        Random rnd_new = new Random();
        bool LR = false; // LOW Register flag
        bool HR = false; // HIGH Register flag
        bool SSY = false; // SYMBOL SPEC flag
        bool N = false; // NUM FLAG SPEC flag, in the bottow, there are combination of them (внизу комбинация флагов)
        bool HRLR = false;
        bool LRSSY = false;
        bool LRN = false;
        bool HRSSY = false;
        bool HRN = false;
        bool SSYN = false;
        bool LRHRSSY = false;
        bool LRHRSSYN = false;
        bool LRHRN = false;
        bool HRSSYN = false;
        private void bools(bool LR1, bool HR1, bool SSY1, bool N1, bool HRLR1, bool LRSSY1, bool LRN1, bool HRSSY1, bool HRN1, bool SSYN1, bool LRHRSSY1, bool LRHRN1, bool LRHRSSYN1, bool HRSSYN1)
        { // функция для получения переменных, обозначающих комбинации флагов (или одиночные флаги)
          // чтобы понимать, сколько одновременнно нажато флажков (напр., большие и малые регистры одновременно)
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
            HRSSYN = HRSSYN1;
        }
        //bool Low_reg_checked = false;
       // bool High_reg_checked = false;
        //bool Special_symbol_checked = false;
        //bool Numbers_symbol_checked = false;
        int A_ = 0;

        private int generator_special_sym() // генератор спец. символов
        {
            //  Random rnd_new = new Random();
            int rnd_num = rnd_new.Next(0, 4); // случайно будем генерировать спец. символы разных диапазонов ASCII
            int rnd_to_return = 0;
            if (rnd_num == 0)
            {
                rnd_to_return = rnd_new.Next(33, 47); //генерируем спец. символы №1
            }
            else if (rnd_num == 1)
            {
                rnd_to_return = rnd_new.Next(58, 64); //генерируем спец. символы №2
            }
            else if (rnd_num == 2)
            {
                rnd_to_return = rnd_new.Next(91, 96); //генерируем спец. символы №3
            }
            else if (rnd_num == 3)
            {
                rnd_to_return = rnd_new.Next(123, 126); //генерируем спец. символы №4 (в скобках - диапазон в ASCII)
            }
            return rnd_to_return;
        }

        public string GetPass(bool Low_reg_checked, bool High_reg_checked, bool Special_symbol_checked, bool Numbers_symbol_checked)
        { //функция для получения пароля

            if ((Low_reg_checked == true) && (!High_reg_checked) && (!Special_symbol_checked) && (!Numbers_symbol_checked))
            {
                A_ = 26;//мощность алфавита. bools() используется для получения комбинаций флагов.
                bools(true, false, false, false, false, false, false, false, false, false, false, false, false, false);
            }
            else if ((High_reg_checked == true) && (!Low_reg_checked) && (!Special_symbol_checked) && (!Numbers_symbol_checked))
            {
                A_ = 26;//мощность алфавита
                bools(false, true, false, false, false, false, false, false, false, false, false, false, false, false);
            }
            else if ((Special_symbol_checked == true) && (!High_reg_checked) && (!Low_reg_checked) && (!Numbers_symbol_checked))
            {
                A_ = 32;//мощность алфавита
                bools(false, false, true, false, false, false, false, false, false, false, false, false, false, false);
            }
            else if ((Numbers_symbol_checked == true) && (!High_reg_checked) && (!Low_reg_checked) && (!Special_symbol_checked))
            {
                A_ = 10;//мощность алфавита
                bools(false, false, false, true, false, false, false, false, false, false, false, false, false, false);
            }
            else if ((Low_reg_checked == true) && (High_reg_checked == true) && (!Special_symbol_checked) && (!Numbers_symbol_checked))
            {
                A_ = 52;//мощность алфавита
                bools(false, false, false, false, true, false, false, false, false, false, false, false, false, false);
            }
            else if ((Low_reg_checked == true) && (Special_symbol_checked == true) && (!Numbers_symbol_checked) && (!High_reg_checked))
            {
                A_ = 58;//мощность алфавита
                bools(false, false, false, false, false, true, false, false, false, false, false, false, false, false);
            }
            else if ((Low_reg_checked == true) && (Numbers_symbol_checked == true) && (!High_reg_checked) && (!Special_symbol_checked))
            {
                A_ = 36;//мощность алфавита
                bools(false, false, false, false, false, false, true, false, false, false, false, false, false, false);
            }
            else if ((High_reg_checked == true) && (Special_symbol_checked == true) && (!Numbers_symbol_checked) && (!Low_reg_checked))
            {
                A_ = 58;//мощность алфавита
                bools(false, false, false, false, false, false, false, true, false, false, false, false, false, false);
            }
            else if ((High_reg_checked == true) && (Numbers_symbol_checked == true) && (!Low_reg_checked) && (!Special_symbol_checked))
            {
                A_ = 36;//мощность алфавита
                bools(false, false, false, false, false, false, false, false, true, false, false, false, false, false);
            }
            else if ((Special_symbol_checked == true) && (Numbers_symbol_checked == true) && (!Low_reg_checked) && (!High_reg_checked))
            {
                A_ = 42;//мощность алфавита
                bools(false, false, false, false, false, false, false, false, false, true, false, false, false, false);
            }
            else if ((Low_reg_checked == true) && (High_reg_checked == true) && (Special_symbol_checked == true) && (!Numbers_symbol_checked))
            {
                A_ = 84;//мощность алфавита
                bools(false, false, false, false, false, false, false, false, false, false, true, false, false, false);
            }
            else if ((Low_reg_checked == true) && (High_reg_checked == true) && (!Special_symbol_checked) && (Numbers_symbol_checked == true))
            {
                A_ = 62;//мощность алфавита
                bools(false, false, false, false, false, false, false, false, false, false, false, true, false, false);
            }
            else if ((Low_reg_checked == true) && (High_reg_checked == true) && (Special_symbol_checked == true) && (Numbers_symbol_checked == true))
            {
                A_ = 94;//мощность алфавита
                bools(false, false, false, false, false, false, false, false, false, false, false, false, true, false);
            }
            else if ((Low_reg_checked == false) && (High_reg_checked == true) && (Special_symbol_checked == true) && (Numbers_symbol_checked == true))
            {
                A_ = 94;//мощность алфавита
                bools(false, false, false, false, false, false, false, false, false, false, false, false, false, true);
            }
            else
            {
                A_ = 0;//мощность алфавита
                bools(false, false, false, false, false, false, false, false, false, false, false, false, false, false);
            }
            string Password = ""; //объявляем пустую строку и инициализируем её.
            if (A_ != 0) // если мощность алфавита не равна нулю
            {
                double L = Math.Ceiling(10 / Math.Log10(A_)); // вычисляем по формуле оптимальную длину пароля
                //Random rnd_extra = new Random();
                int value_extra = rnd_new.Next(0, 10); // генерируем случайное число от 0 до 10
                L = L + value_extra; // добавляем его к длине пароля
                int intLength = Convert.ToInt32(L); //конвертируем число в целое

                int[] arr = new int[intLength]; //объявлем массив полученной ранее длины

                bool checkHR = false; // флаги для генерации символов
                bool checkLR = false;
                bool checkSSY = false;
                bool checkN = false;
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
                        arr[i] = rnd_new.Next(97, 122); //генерация букв малого регистра
                    }
                    else if (HR == true)
                    {
                        arr[i] = rnd_new.Next(65, 90); //генерация букв большого регистра
                    }
                    else if (N == true)
                    {
                        arr[i] = rnd_new.Next(48, 57); //генерация чисел
                    }
                    else if (SSY == true)
                    {
                        arr[i] = generator_special_sym(); // генерация спец. символов
                    }
                    else if (HRLR == true) // если выбрано несколько флагов (и высокий, и низкий регистр)
                    {
                        //Random rnd_new = new Random();
                        int rnd_num = rnd_new.Next(0, 2); //генерируется случайное число в диапазоне
                        if (checkLR == false || checkHR == false) //если ни разу не был сгенерирован выбранный тип символов
                            rnd_num = -1; // не обращаем внимание на ранее сгенерированное число в диапазоне

                        if (rnd_num == 0 || checkLR == false) //заходим в каждое из условий, пока ни разу не сгенерирован выбранный тип символов
                        {                                       // если каждый тип символов сгенерирован, то заходим в условия в зависимости от rnd_num
                            arr[i] = rnd_new.Next(97, 122);
                            checkLR = true;
                        }
                        else if (rnd_num == 1 || checkHR == false)
                        {
                            arr[i] = rnd_new.Next(65, 90);
                            checkHR = true;
                        }
                    }
                    else if (LRSSY == true)//далее аналогично предыдущему:
                    {
                        //Random rnd_new = new Random();
                        int rnd_num = rnd_new.Next(0, 2);
                        if (checkLR == false || checkSSY == false)
                            rnd_num = -1;

                        if (rnd_num == 0 || checkLR == false)
                        {
                            arr[i] = rnd_new.Next(97, 122);
                            checkLR = true;
                        }
                        else if (rnd_num == 1 || checkSSY == false)
                        {
                            arr[i] = generator_special_sym(); //генератор спец. символов
                            checkSSY = true;
                        }
                    }
                    else if (LRN == true)
                    {
                        //Random rnd_new = new Random();
                        int rnd_num = rnd_new.Next(0, 2);
                        if (checkLR == false || checkN == false)
                            rnd_num = -1;

                        if (rnd_num == 0 || checkLR == false)
                        {
                            arr[i] = rnd_new.Next(97, 122);
                            checkLR = true;
                        }
                        else if (rnd_num == 1 || checkN == false)
                        {
                            arr[i] = rnd_new.Next(48, 57);
                            checkN = true;
                        }
                    }
                    else if (HRSSY == true)
                    {
                        //Random rnd_new = new Random();
                        int rnd_num = rnd_new.Next(0, 2);
                        if (checkHR == false || checkSSY == false)
                            rnd_num = -1;

                        if (rnd_num == 0 || checkHR == false)
                        {
                            arr[i] = rnd_new.Next(65, 90);
                            checkHR = true;
                        }
                        else if (rnd_num == 1 || checkSSY == false)
                        {
                            arr[i] = generator_special_sym();
                            checkSSY = true;
                        }
                    }
                    else if (HRN == true)
                    {
                        //Random rnd_new = new Random();
                        int rnd_num = rnd_new.Next(0, 2);
                        if (checkN == false || checkHR == false)
                            rnd_num = -1;

                        if (rnd_num == 0 || checkHR == false)
                        {
                            arr[i] = rnd_new.Next(65, 90);
                            checkHR = true;
                        }
                        else if (rnd_num == 1 || checkN == false)
                        {
                            arr[i] = rnd_new.Next(48, 57);
                            checkN = true;
                        }
                    }
                    else if (SSYN == true)
                    {
                        //Random rnd_new = new Random();
                        int rnd_num = rnd_new.Next(0, 2);
                        if (checkSSY == false || checkN == false)
                            rnd_num = -1;

                        if (rnd_num == 0 || checkSSY == false)
                        {
                            arr[i] = rnd_new.Next(48, 57);
                            checkSSY = true;
                        }
                        else if (rnd_num == 1 || checkN == false)
                        {
                            arr[i] = generator_special_sym();
                            checkN = true;
                        }
                    }
                    else if (LRHRSSY == true)
                    {
                        //Random rnd_new = new Random();
                        int rnd_num = rnd_new.Next(0, 3);
                        if (checkLR == false || checkSSY == false || checkHR == false)
                            rnd_num = -1;

                        if (rnd_num == 0 || checkLR == false)
                        {
                            arr[i] = rnd_new.Next(97, 122);
                            checkLR = true;
                        }
                        else if (rnd_num == 1 || checkHR == false)
                        {
                            arr[i] = rnd_new.Next(65, 90);
                            checkHR = true;
                        }
                        else if (rnd_num == 2 || checkSSY == false)
                        {
                            arr[i] = generator_special_sym();
                            checkSSY = true;
                        }
                    }
                    else if (LRHRN == true)
                    {
                        //Random rnd_new = new Random();
                        int rnd_num = rnd_new.Next(0, 3);
                        if (checkLR == false || checkN == false || checkHR == false)
                            rnd_num = -1;

                        if (rnd_num == 0 || checkLR == false)
                        {
                            arr[i] = rnd_new.Next(97, 122);
                            checkLR = true;
                        }
                        else if (rnd_num == 1 || checkHR == false)
                        {
                            arr[i] = rnd_new.Next(65, 90);
                            checkHR = true;
                        }
                        else if (rnd_num == 2 || checkN == false)
                        {
                            arr[i] = rnd_new.Next(48, 57);
                            checkN = true;
                        }
                    }
                    else if (LRHRSSYN == true)
                    {
                        //Random rnd_new = new Random();
                        int rnd_num = rnd_new.Next(0, 4);
                        if (checkLR == false || checkHR == false || checkN == false || checkSSY == false)
                            rnd_num = -1;


                        if (rnd_num == 0 || checkLR == false)
                        {
                            arr[i] = rnd_new.Next(97, 122);
                            checkLR = true;
                        }
                        else if (rnd_num == 1 || checkHR == false)
                        {
                            arr[i] = rnd_new.Next(65, 90);
                            checkHR = true;
                        }
                        else if (rnd_num == 2 || checkSSY == false)
                        {
                            arr[i] = generator_special_sym();
                            checkSSY = true;
                        }
                        else if (rnd_num == 3 || checkN == false)
                        {
                            arr[i] = rnd_new.Next(48, 57);
                            checkN = true;
                        }
                    }
                    else if (HRSSYN == true)
                    {
                        //Random rnd_new = new Random();

                        int rnd_num = rnd_new.Next(0, 3);
                        if (checkHR == false || checkN == false || checkSSY == false)
                            rnd_num = -1;

                        if (rnd_num == 0 || checkHR == false)
                        {
                            arr[i] = rnd_new.Next(65, 90);
                            checkHR = true;
                        }
                        else if (rnd_num == 1 || checkSSY == false)
                        {
                            arr[i] = rnd_new.Next(65, 90);
                            checkSSY = true;
                        }
                        else if (rnd_num == 2 || checkSSY == false)
                        {
                            arr[i] = generator_special_sym();
                            checkSSY = true;
                        }
                        else if (rnd_num == 3 || checkN == false)
                        {
                            arr[i] = rnd_new.Next(48, 57);
                            checkN = true;
                        }
                    }
                    Password += (char)arr[i]; //присваиваем строке сгенерир. символ на каждой итерации
                }
            }
            int r; 
            char p;
            char[] mas = new char[Password.Length];
            mas = Password.ToCharArray();
            for (int i = mas.Length - 1; i > 1; i--) //перемешиваем случайным образом полученные символы пароля
            {
                r = rnd_new.Next(0, i - 1);
                p = mas[i];
                mas[i] = mas[r];
                mas[r] = p;
            }
            Password = "";
            Password = String.Concat<char>(mas); //преобразуем каждый элемент
                                                 // массива в строку и складываем их в Password
            //Password = mas.ToString();
            return Password; //возвращаем полученое значение пароля
        }
    }
}
