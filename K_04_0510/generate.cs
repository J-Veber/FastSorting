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

namespace K_04_0510
{
    public partial class generate : Form
    {
        public Form form1;
        public generate(Form inpForm)
        {
            form1 = inpForm; 
            InitializeComponent();
        }

        private void genRotate_CheckedChanged(object sender, EventArgs e)
        {

        }
        private void genCancel_Click(object sender, EventArgs e)
        {
            form1.Enabled = true;
            this.Close();
        }

        private void genGenerateB_Click(object sender, EventArgs e)
        {
            if ((genFromUpDown1.Value <= genFromUpDown2.Value) && (genNumSeqUpDown.Value > 0)
                && genFromUpDown1.Value >=0 && genFromUpDown2.Value >= 0)
            {
                int value_From = (int) genFromUpDown1.Value;
                int value_To = (int) genFromUpDown2.Value;
                int value_NumSeq = (int) genNumSeqUpDown.Value;
                int diap = value_To - value_From + 1;         //сколько чисел в диапазоне включительно
                int numberBlocks = diap / value_NumSeq;
                Random ourrandom = new Random();
                string extend = "";                              //расширение файла
                string default_folder = @"C:\Users\Veiber\Desktop\K_04\K_04_0510\inputfiles\";
                string filename = "";                       //имя файла
                int prop = 0;
                int d = 0;
                string outstring = "";
                string fullFileName = "";
                //-----------------ПОТОМ УДАЛИТЬ--------------
                MessageBox.Show("можно генерировать последовательности");

                //--------------определяем вид последовательности---------------
                if (genUp.Checked)
                {
                    extend = "Up";
                    prop = 1;
                }
                if (genDown.Checked)
                {
                    extend = "Down";
                    prop = 2;
                }
                if (genRotate.Checked)
                {
                    extend = "Rotate";
                    prop = 3;
                }
                if (genRandom.Checked)
                {
                    extend = "Random";
                    prop = 4;
                }
                int curgenseq = 0;
                //-------------------генерируем последовательности определенного выше типа-------------
                while (curgenseq != value_NumSeq)
                {
                    curgenseq++;
                    int length = value_From + d;
                    filename = Convert.ToString(length); //это ИМЯ ФАЙЛА
                    fullFileName = default_folder + filename + "." + extend; //КОНЕЧНОЕ имя файла

                    try
                    {
                        // Delete the file if it exists.
                        if (File.Exists(fullFileName))
                            File.Delete(fullFileName);
                    }
                    catch (Exception Ex)
                    {
                        Console.WriteLine(Ex.ToString());
                    }
                    int outputdata = 0;
                    using (StreamWriter sw = new StreamWriter(fullFileName, false, System.Text.Encoding.Default))
                    {
                        sw.WriteLine(Convert.ToString(length));
                        sw.Close();
                        outstring = "";
                    }
                    //собственно, сама генерация
                    for (int j = 0; j < length; j++)
                    {
                        switch (prop)
                        {
                            case 1:
                                outputdata = j * 4;
                                break;
                            case 2:
                                outputdata = length - j;
                                break;
                            case 3:
                                outputdata = j % 2;
                                break;
                            case 4:
                                outputdata = ourrandom.Next(1000);
                                break;
                        }
                        outstring += Convert.ToString(outputdata) + " ";
                    }
                using (StreamWriter sw = new StreamWriter(fullFileName, true, System.Text.Encoding.Default))
                {
                    sw.WriteLine(outstring);
                    sw.Close();
                    outstring = "";
                }
                d += numberBlocks; //равномерно увеличили длину следующего массива
                }
                
                }
                //-----------------ПОТОМ УДАЛИТЬ-----------------
                else MessageBox.Show("ERROR");

            }

        private void genUp_CheckedChanged(object sender, EventArgs e)
        {

        }
        private void genDown_CheckedChanged(object sender, EventArgs e)
        {

        }
        private void genRandom_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void genFromUpDown1_ValueChanged(object sender, EventArgs e)
        {
            genFromUpDown1.Minimum = 0;
            genFromUpDown1.Maximum = 1000000;
        }

        private void genFromUpDown2_ValueChanged(object sender, EventArgs e)
        {
            genFromUpDown2.Minimum = 1;
            genFromUpDown2.Maximum = 1000000;
        }

        private void seqtype_Enter(object sender, EventArgs e)
        {

        }

        private void genNumSeqUpDown_ValueChanged(object sender, EventArgs e)
        {
            genNumSeqUpDown.Minimum = 0;
            genNumSeqUpDown.Maximum = 500;
        }

        private void generate_Load(object sender, EventArgs e)
        {

        }
    }
}
