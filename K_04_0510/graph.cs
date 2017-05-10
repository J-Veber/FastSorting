using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using ZedGraph;


namespace K_04_0510
{
    public partial class graph : Form
    {
        int[,] inputArr;
        int counter;
        int how_much_ch;

        public graph(int[,] inputArr1, int counter1, int numberch)
        {
            inputArr = inputArr1;
            counter = counter1;
            InitializeComponent();
            how_much_ch = numberch;
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

        }
        private void arraySeries(int[,] inputArr1, int[] check_mas)
        {
            for (int i = 0; i < 4; i++)
                check_mas[i] = 0;
            for (int i = 0; i < counter / how_much_ch; i++)
                check_mas[i] = inputArr1[(counter / how_much_ch) * i , 4];
        }
        private void graph_Load(object sender, EventArgs e)
        {
            float[] xPoints = new float[counter/how_much_ch];
            for (int i = 0; i < counter / how_much_ch; i++)
                xPoints[i] = inputArr[i, 3];


            //----------------------TIME--------------------------------
            float[] yPoints = new float[counter / how_much_ch];
            int curline = 0;
            //for (int i = 0; i < counter / how_much_ch; i++)
            //    yPoints[i] = inputArr[i, 1];
            
            //заполнили значения по оси Х
            //заполняем серии и сторим графики
            
            int[] checkmas = new int[4];
            arraySeries(inputArr, checkmas);
            for (int i = 0; i < how_much_ch; i++)
            {
                switch (checkmas[i])
                {
                    case 0:
                        {
                            break;
                        }
                    case 1:
                        {
                            Series series_med = new Series();
                            series_med.ChartArea = "chart_time";
                            while (inputArr[curline, 4] == 1)
                            {
                                yPoints[curline] = inputArr[curline, 1];
                                curline++;
                            }
                            //заполнили массив значениями по времени
                            //рисуем график
                            for (int j = 0; j < counter / how_much_ch; j++)
                            {
                                chart_time.Series[i].Points.AddXY(xPoints[j], yPoints[j]);
                            }
                            break;
                        }
                    case 2:
                        {
                             Series series_fir = new Series();
                             break;
                        }
                    case 3:
                        {
                            Series series_las = new Series();
                            break;
                        }
                    case 4:
                        {
                            Series series_ran = new Series();
                            break;
                        }
                }
            }
            


                /*for (int i = 0; i < counter / how_much_ch; i++)
                    {
                    
                        chart_time.Series[j].Points.AddXY(xPoints[i], yPoints[i]);
                    }*/
        }

        private void chart_time_Click(object sender, EventArgs e)
        {

        }
    }
}
