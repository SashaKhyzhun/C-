using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab1Var19
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }

        public static int iMaker(int n)
        {
            int i = 0;
            for (int j = 0; j <= n; j++)
            {
                i += (j * j);
            }
            return i;
        }

        public static int jMaker(int m)
        {
            int j = 1;
            for (int i = 1; i <=m; i++)
            {
                j *= i;
            }
            return j;
        }

        public static void MatrixMaker(DataGridView matrix, int n, int m)
        {
            matrix.ColumnCount = n;
            matrix.RowCount = m;
            
            for (int i = 1; i <= m; i++)
            {
                for (int j = 1; j <= n; j++)
                {
                    matrix.Columns[j - 1].Width = 21;
                    matrix[j - 1, i - 1].Value = gcd(iMaker(i), jMaker(j));
                }
            }
        }

        public static int [] ToArray(DataGridView matrix)
        {
            int z = 0;
            int[] simplifiedArr = new int[matrix.RowCount * matrix.ColumnCount];
            for (int i = 0; i < matrix.RowCount;  i++)
            {
                for (int j = 0; j < matrix.ColumnCount; j++)
                {
                    simplifiedArr[z] = Convert.ToInt32(matrix[j, i].Value);
                    z++;
                }
            }
            return simplifiedArr;
        }

        public static int[] CutSimilar(int[] array)
        {
            List<int> identList = new List<int>();

            for (int x = 0; x <= array.Max(); x++)
            {
                int k = 0;
                for (int i = 0; i < array.Length; i++)
                {
                    if (x == array[i])
                    {
                        k++;
                    }
                }
                if (k >= 2)
                {
                    identList.Add(x);
                }
            }

            return identList.ToArray();
        }

        public static int gcd(int a, int b)
        {
            while (b != 0)
            {
                int r = a % b;
                a = b;
                b = r;
            }
            return a;
        }

        public static void SaveFile(int[] array)
        {
            Stream myStream;
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            StreamWriter writer;

            saveFileDialog1.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            saveFileDialog1.FilterIndex = 0;
            saveFileDialog1.RestoreDirectory = true;

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                if ((myStream = saveFileDialog1.OpenFile()) != null)
                {
                    string line = "";
                    writer = new StreamWriter(myStream);
                    foreach (int e in array)
                    {
                        line += e + ", ";
                    }
                    writer.WriteLine(line.Substring(0, line.Length - 2));
                    writer.Close();
                    myStream.Close();
                }
            }
        }
    }
}
