using System;
using System.Drawing;
using System.Windows.Forms;

namespace MatrixMultiplactionFinalVersion
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();

        }
        private decimal matrix1Row = Form1.matrix1Row;
        private decimal matrix1Column = Form1.matrix1Column;
        private decimal matrix2Row = Form1.matrix2Row;
        private decimal matrix2Column=Form1.matrix2Column;
        TextBox[] matrix1 = new TextBox[(int)Form1.matrix1Row * (int)Form1.matrix1Column];
        TextBox[] matrix2 = new TextBox[(int)Form1.matrix2Row * (int)Form1.matrix2Column];
        TextBox[] matrixMultiplaction = new TextBox[(int)Form1.matrix1Row * (int)Form1.matrix2Column];

        private void Form2_Load(object sender, EventArgs e)
        {
            CreateCalculateButton();
            CreateMatrix1(matrix1Row, matrix1Column, 0,false);
            CreateMatrix2(matrix2Row, matrix2Column, ((int)matrix1Column + 1) * 40,false);
            CreateMatrixMultiplaction(matrix1Row, matrix2Column, ((int)matrix1Column + (int)matrix2Column + 2) * 40,true);

        }
        private void CreateCalculateButton()
        {
            Button btnCalculate = new Button();
            btnCalculate.Text = "Calculate";
            btnCalculate.Size = new Size(100, 25);
            btnCalculate.Top = this.Height - 100;
            btnCalculate.Left = this.Width - 150;
            this.Controls.Add(btnCalculate);
            btnCalculate.Click += BtnCalculate_Click;
        }
        private void CreateMatrix1(decimal row,decimal column,int start,bool readOnly)
        {
            int indeks = 0;
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < column; j++)
                {
                    
                    matrix1[indeks] = new TextBox();
                    matrix1[indeks].ReadOnly = readOnly;
                    matrix1[indeks].Size = new Size(40, 20);
                    matrix1[indeks].Top = (i + 1) * 20;
                    matrix1[indeks].Left = (j + 1) * 40+start;
                    indeks++;
                }
            }
            this.Controls.AddRange(matrix1);
        }
        private void CreateMatrix2(decimal row, decimal column, int start, bool readOnly)
        {
            int indeks = 0;
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < column; j++)
                {

                    matrix2[indeks] = new TextBox();
                    matrix2[indeks].ReadOnly = readOnly;
                    matrix2[indeks].Size = new Size(40, 20);
                    matrix2[indeks].Top = (i + 1) * 20;
                    matrix2[indeks].Left = (j + 1) * 40 + start;
                    indeks++;
                }
            }
            this.Controls.AddRange(matrix2);
        }
        private void CreateMatrixMultiplaction(decimal row, decimal column, int start, bool readOnly)
        {
            int indeks = 0;
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < column; j++)
                {

                    matrixMultiplaction[indeks] = new TextBox();
                    matrixMultiplaction[indeks].ReadOnly = readOnly;
                    matrixMultiplaction[indeks].Size = new Size(40, 20);
                    matrixMultiplaction[indeks].Top = (i + 1) * 20;
                    matrixMultiplaction[indeks].Left = (j + 1) * 40 + start;
                    indeks++;
                }
            }
            this.Controls.AddRange(matrixMultiplaction);
        }
        private void BtnCalculate_Click(object sender, EventArgs e)
        {
            double cem = 0;
            int d=0,q=0;
            int[,] a = new int[(int)matrix1Row, (int)matrix1Column];
            int[,] b=new int[(int)matrix2Row, (int)matrix2Column];
            for (int i = 0; i < matrix1Row; i++)
            {
                for (int j = 0; j < matrix1Column; j++)
                {
                    a[i, j] = int.Parse(matrix1[d++].Text);
                }
            }
            d = 0;
            for (int i = 0; i < matrix2Row; i++)
            {
                for (int j = 0; j < matrix2Column; j++)
                {
                    b[i, j] = int.Parse(matrix2[d++].Text);
                }
            }
            d = 0;
            for (int i = 0; i < matrix1Row; i++)
            {
                for (int j = 0; j < matrix2Column; j++)
                {
                    for (int k = 0; k < matrix2Row; k++)
                    {
                        cem +=a[i,k] *b[k,j];
                    }
                    matrixMultiplaction[d++].Text = cem.ToString();
                    cem = 0;
                }

            }
        }
    }
}
