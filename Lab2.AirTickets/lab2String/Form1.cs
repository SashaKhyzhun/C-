using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;


namespace lab2String
{
    public partial class Form1 : Form
    {
        int lines1 = System.IO.File.ReadAllLines("E:/Education/2 курс/Програмування/C#/labka2/Авіарейси.txt").Length;
        int lines2 = System.IO.File.ReadAllLines("E:/Education/2 курс/Програмування/C#/labka2/Квитки.txt").Length;

        public Form1()
        {
            InitializeComponent();
            this.Font = new Font("Arial", 11);
            label1.Font = new Font("Arial", 14, FontStyle.Italic);
            label2.Font = new Font("Arial", 14, FontStyle.Italic);
            label2.ForeColor = System.Drawing.Color.Green;

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridView1.RowHeadersVisible = false;
            dataGridView2.RowHeadersVisible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button2.Enabled = true;
            button3.Enabled = true;
            string[] str;


            dataGridView1.ColumnCount = 4;
            dataGridView1.Columns[0].HeaderCell.Value = "Номер рейсу";
            dataGridView1.Columns[1].HeaderCell.Value = "Пункт відправлення";
            dataGridView1.Columns[2].HeaderCell.Value = "Час вильоту";
            dataGridView1.Columns[3].HeaderCell.Value = "Загальна к-сть місць";

           
            dataGridView1.Columns[1].Width = 150;
            dataGridView1.Columns[3].Width = 120;
          

            dataGridView2.ColumnCount = 8;
            dataGridView2.Columns[0].HeaderCell.Value = "Номер квитка";
            dataGridView2.Columns[1].HeaderCell.Value = "Номер рейсу";
            dataGridView2.Columns[2].HeaderCell.Value = "Місце";
            dataGridView2.Columns[3].HeaderCell.Value = "Дата вильоту";
            dataGridView2.Columns[4].HeaderCell.Value = "Пункт призначення";
            dataGridView2.Columns[5].HeaderCell.Value = "Дата прибуття";
            dataGridView2.Columns[6].HeaderCell.Value = "Час прибуття";
            dataGridView2.Columns[7].HeaderCell.Value = "Ціна";

            using (System.IO.StreamReader read = new System.IO.StreamReader("E:/Education/2 курс/Програмування/C#/labka2/Авіарейси.txt"))
            {


                str = read.ReadToEnd().Split(new Char[] { ' ', '\r' });
                int pos = 0;
                for (int i = 0; i < lines1; i++)
                {
                    dataGridView1.Rows.Add();
                    for (int j = 0; j < 4; j++)
                    {

                        if (str[pos] != "")

                            dataGridView1[j, i].Value = str[pos];
                        pos++;
                    }

                }
            }


            using (System.IO.StreamReader read = new System.IO.StreamReader("E:/Education/2 курс/Програмування/C#/labka2/Квитки.txt"))
            {


                str = read.ReadToEnd().Split(new Char[] { ' ', '\r' });
                int pos = 0;
                for (int i = 0; i < lines2; i++)
                {
                    dataGridView2.Rows.Add();
                    for (int j = 0; j < 8; j++)
                    {

                        if (str[pos] != "")

                            dataGridView2[j, i].Value = str[pos];
                        pos++;
                    }

                }
            }




            button1.Enabled = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            button1.Enabled = false;
            string[] timeStr;
            int number = 0;
            int ticket = 0;
            int allTicket = 0;
            string cities = "";

            cities = "Пункти призначення, у які не продано жодного квитка" + "\n" + "на рейси, які відлітають з Києва після обіду.";
            labelT1.Text = (cities);
            cities = "";
            for (int i = 0; i < lines1; i++)
            {
                ticket = 0;
                allTicket = 0;

                if (dataGridView1[1, i].Value.Equals("Kyiv"))
                {
                    
                    timeStr = dataGridView1.Rows[i].Cells[2].Value.ToString().Split(new Char[] { ':' }); ;
                    allTicket = Convert.ToInt32(dataGridView1.Rows[i].Cells[3].Value);
                    //MessageBox.Show(timeStr[0]);
                    if (Convert.ToInt32(timeStr[0]) >= 14)
                    {
                        number = Convert.ToInt32(dataGridView1.Rows[i].Cells[0].Value);

                        for (int j = 0; j < lines2; j++)
                        {

                            if (Convert.ToInt32(dataGridView2[1, j].Value) == number)
                            {
                                ticket++;
                            }

                        }


                    }

                    if (ticket == allTicket)
                    {
                        for (int j = 0; j < lines2; j++)
                        {
                            if (Convert.ToInt32(dataGridView2[1, j].Value) == number) { cities = cities + dataGridView2.Rows[j].Cells[4].Value.ToString() + "\n"; break; }


                        }
                    }


                }
            }
            label1.Text = (cities);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Dictionary<int, string> flightCity = new Dictionary<int, string>();
            int[] flight = new int[lines1];
            int[] numberOfPlaces = new int[lines1];
            List<int>  numberOfAllPlaces = new List<int>();
            string timeStr = "";

            for (int i = 0; i < lines1; i++)
            {
                flightCity.Add(Convert.ToInt32(dataGridView1.Rows[i].Cells[0].Value), dataGridView1.Rows[i].Cells[1].Value.ToString());
                numberOfAllPlaces.Add(Convert.ToInt32(dataGridView1.Rows[i].Cells[3].Value));
                flight[i] = Convert.ToInt32(dataGridView1.Rows[i].Cells[0].Value);
             
                for (int j = 0; j < lines2; j++)
                {
                    if (Convert.ToInt32(dataGridView2.Rows[j].Cells[1].Value) == flight[i]) { numberOfPlaces[i] = numberOfPlaces[i] + 1; } 
                }
            }

            for (int i = 0; i < lines1; i++)
            {
                timeStr = timeStr + "На рейс " + flight[i] + " " + flightCity[flight[i]] + " кількість вільних місць:" + numberOfPlaces[i] + "/" + numberOfAllPlaces[i] + "\n"; 
            }
            label2.Text = (timeStr);
        }
    }
}