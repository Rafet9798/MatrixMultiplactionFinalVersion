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
        TextBox[,] matrix1 = new TextBox[(int)Form1.matrix1Row , (int)Form1.matrix1Column];
        TextBox[,] matrix2 = new TextBox[(int)Form1.matrix2Row ,(int)Form1.matrix2Column];
        TextBox[,] matrixMultiplaction = new TextBox[(int)Form1.matrix1Row , (int)Form1.matrix2Column];

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
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < column; j++)
                {
                    
                    matrix1[i,j] = new TextBox();
                    matrix1[i,j].ReadOnly = readOnly;
                    matrix1[i,j].Size = new Size(40, 20);
                    matrix1[i,j].Top = (i + 1) * 20;
                    matrix1[i,j].Left = (j + 1) * 40+start;
                    this.Controls.Add(matrix1[i, j]);
                }
            }
        }
        private void CreateMatrix2(decimal row, decimal column, int start, bool readOnly)
        {
            int indeks = 0;
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < column; j++)
                {

                    matrix2[i,j] = new TextBox();
                    matrix2[i,j].ReadOnly = readOnly;
                    matrix2[i,j].Size = new Size(40, 20);
                    matrix2[i,j].Top = (i + 1) * 20;
                    matrix2[i,j].Left = (j + 1) * 40 + start;
                    this.Controls.Add(matrix2[i, j]);
                }
            }
        }
        private void CreateMatrixMultiplaction(decimal row, decimal column, int start, bool readOnly)
        {
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < column; j++)
                {

                    matrixMultiplaction[i,j] = new TextBox();
                    matrixMultiplaction[i,j].ReadOnly = readOnly;
                    matrixMultiplaction[i,j].Size = new Size(40, 20);
                    matrixMultiplaction[i,j].Top = (i + 1) * 20;
                    matrixMultiplaction[i,j].Left = (j + 1) * 40 + start;
                    this.Controls.Add(matrixMultiplaction[i,j]);
                }
            }
        }
        private void BtnCalculate_Click(object sender, EventArgs e)
        {
            double cem = 0;
            int d=0,q=0;
           
            for (int i = 0; i < matrix1Row; i++)
            {
                for (int j = 0; j < matrix2Column; j++)
                {
                    for (int k = 0; k < matrix2Row; k++)
                    {
                        cem +=int.Parse(matrix1[i,k].Text) *int.Parse(matrix2[k,j].Text);
                    }
                    matrixMultiplaction[i,j].Text = cem.ToString();
                    cem = 0;
                }

            }
        }
    }
}
