using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
//using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;


namespace K_04_0510
{


    public partial class experiment : Form
    {
        int eq1;
        int ch1;
        int[,] graphicmas = new int[1000000,5];
        int counter = 0;
        public void sorting(int[] arr, int first, int last, int X)
        {
            int temp;
            last--;
            int i = first, j = last;
            while (i <= j)
            {
                while (arr[i] < X && i <= last) ++i;
                while (arr[j] > X && j >= first) --j;
                if (i <= j)
                {
                    ch1++;
                    eq1++;
                    temp = arr[i];
                    arr[i] = arr[j];
                    arr[j] = temp;
                    ++i; --j;
                }
                else eq1++;
            }
            if (j > first) sorting(arr, first, j, X);
            if (i < last) sorting(arr, i, last,  X);
        }




        public Form form1;
        public experiment(Form newForm)
        {
            form1 = newForm;
            InitializeComponent();
        }

        private void expCancel_Click(object sender, EventArgs e)
        {
            form1.Enabled = true;
            this.Close();
        }

        private void expGen_Click(object sender, EventArgs e)
        {

        }


        private void expAdd_Click(object sender, EventArgs e)
        {
            if (!(med.Checked || first.Checked || last.Checked || rand.Checked)) MessageBox.Show("ERROR");
            else
            {
                counter = 0;
                int how_much_ch = 0;
                //OFD.FileNames[1] = "den";
                OFD.Filter = "Все файлы|*.*|Файлы UP|*.up|Файлы DOWN|*.down|Файлы ROTATE|*.rotate|Файлы RANDOM|*.random";
                if (OFD.ShowDialog() == DialogResult.OK)
                {
                    this.Close();
                }
                int x; //разделяющий элемент
                OFD.CheckFileExists = true;
                OFD.CheckPathExists = true;

                if (OFD.FileNames.Length == 1) ;
                else
                {
                    if (med.Checked)
                    {
                        how_much_ch++;
                        foreach (var s in OFD.FileNames)
                        {
                            StreamReader sr = new StreamReader(s); //открыли для файл чтения
                            string lengt = sr.ReadLine();
                            int[] mas = new int[Convert.ToInt64(lengt)];
                            string masstring = sr.ReadLine();
                            string[] resmas = masstring.Split(' ');
                            for (int q = 0; q < Convert.ToInt32(lengt); q++)
                            {
                                mas[q] = Convert.ToInt32(resmas[q]);
                            }
                            //----------извлекаем массив из файла--------
                            int length = (int)Convert.ToInt64(lengt);
                            //x = mas[0]; //первый элемент -----НУЖНО ИЗМЕНИТЬ НА МЕДИАНУ-----
                            int l = 0;
                            int int_med = length / 2;
                            //---------------------------------------поиск медианы-------------------
                            if (mas[int_med] < mas[int_med + 1] && mas[int_med] < mas[int_med - 1]) x = mas[int_med - 1] < mas[int_med + 1] ? mas[int_med - 1] : mas[int_med + 1];
                            else x = mas[int_med - 1] > mas[int_med + 1] ? mas[int_med - 1] : mas[int_med + 1];
                            eq1 = 0;
                            ch1 = 0;
                            Stopwatch stopWatch = new Stopwatch();
                            stopWatch.Start();
                            sorting(mas, l, length, x);
                            stopWatch.Stop();
                            TimeSpan ts = stopWatch.Elapsed;
                            int elapsedtime = (int)ts.Ticks;
                            graphicmas[counter, 0] = elapsedtime;
                            graphicmas[counter, 1] = eq1;
                            graphicmas[counter, 2] = ch1;
                            graphicmas[counter, 3] = length;
                            graphicmas[counter, 4] = 1;
                            counter++;
                        }
                    }

                    if (first.Checked)
                    {
                        how_much_ch++;
                        foreach (var s in OFD.FileNames)
                        {
                            StreamReader sr = new StreamReader(s); //открыли для файл чтения
                            string lengt = sr.ReadLine();
                            int[] mas = new int[Convert.ToInt64(lengt)];
                            string masstring = sr.ReadLine();
                            string[] resmas = masstring.Split(' ');
                            for (int q = 0; q < Convert.ToInt32(lengt); q++)
                            {
                                mas[q] = Convert.ToInt32(resmas[q]);
                            }
                            //----------извлекаем массив из файла--------
                            x = mas[0]; //первый элемент
                            int l = 0;
                            int length = (int)Convert.ToInt64(lengt);
                            eq1 = 0;
                            ch1 = 0;
                            Stopwatch stopWatch = new Stopwatch();
                            stopWatch.Start();
                            sorting(mas, l, length, x);
                            stopWatch.Stop();
                            TimeSpan ts = stopWatch.Elapsed;
                            int elapsedtime = (int)ts.Ticks; 
                            graphicmas[counter, 0] = elapsedtime;
                            graphicmas[counter, 1] = eq1;
                            graphicmas[counter, 2] = ch1;
                            graphicmas[counter, 3] = length;
                            graphicmas[counter, 4] = 1;
                            counter++;
                        }
                    }


                    if (last.Checked)
                    {
                        how_much_ch++;
                        foreach (var s in OFD.FileNames)
                        {
                            StreamReader sr = new StreamReader(s); //открыли для файл чтения
                            string lengt = sr.ReadLine();
                            int[] mas = new int[Convert.ToInt64(lengt)];
                            string masstring = sr.ReadLine();
                            string[] resmas = masstring.Split(' ');
                            for (int q = 0; q < Convert.ToInt32(lengt); q++)
                            {
                                mas[q] = Convert.ToInt32(resmas[q]);
                            }
                            //----------извлекаем массив из файла--------
                            int l = 0;
                            int length = (int)Convert.ToInt64(lengt);
                            x = mas[length - 1]; //последний элемент 
                            eq1 = 0;
                            ch1 = 0;
                            Stopwatch stopWatch = new Stopwatch();
                            stopWatch.Start();
                            sorting(mas, l, length, x);
                            stopWatch.Stop();
                            TimeSpan ts = stopWatch.Elapsed;
                            int elapsedtime = (int)ts.Ticks; 
                            graphicmas[counter, 0] = elapsedtime;
                            graphicmas[counter, 1] = eq1;
                            graphicmas[counter, 2] = ch1;
                            graphicmas[counter, 3] = length;
                            graphicmas[counter, 4] = 1;
                            counter++;
                        }
                    }

                    if (rand.Checked)
                    {
                        how_much_ch++;
                        foreach (var s in OFD.FileNames)
                        {
                            StreamReader sr = new StreamReader(s); //открыли для файл чтения
                            string lengt = sr.ReadLine();
                            int[] mas = new int[Convert.ToInt64(lengt)];
                            string masstring = sr.ReadLine();
                            string[] resmas = masstring.Split(' ');
                            for (int q = 0; q < Convert.ToInt32(lengt); q++)
                            {
                                mas[q] = Convert.ToInt32(resmas[q]);
                            }
                            //----------извлекаем массив из файла--------
                            Random ourrandom = new Random();
                            int l = 0;
                            int length = (int)Convert.ToInt64(lengt);
                            x = mas[ourrandom.Next(length)]; //первый элемент -----НУЖНО ИЗМЕНИТЬ НА МЕДИАНУ-----
                            eq1 = 0;
                            ch1 = 0;
                            Stopwatch stopWatch = new Stopwatch();
                            stopWatch.Start();
                            sorting(mas, l, length, x);
                            stopWatch.Stop();
                            TimeSpan ts = stopWatch.Elapsed;
                            int elapsedtime = (int)ts.Ticks; 
                            graphicmas[counter, 0] = elapsedtime;
                            graphicmas[counter, 1] = eq1;
                            graphicmas[counter, 2] = ch1;
                            graphicmas[counter, 3] = length;
                            graphicmas[counter, 4] = 1;
                            counter++;
                        }
                    }
                        
                    
                    //---------------------рисуем графики--------------------
                    var mygr = new graph(graphicmas, counter, how_much_ch);
                    //this.Enabled = false;
                    mygr.Show();

                }
            }
            
            

        }

        private void expAnalyse_Click(object sender, EventArgs e)
        {
            
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void expDel_Click(object sender, EventArgs e)
        {

        }

        private void experiment_Load(object sender, EventArgs e)
        {

        }

        private void OFD_FileOk(object sender, CancelEventArgs e)
        {

        }
    }
}
