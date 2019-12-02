using System;
using System.Windows.Forms;

namespace MatrixMultiplactionFinalVersion
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public static decimal matrix1Row,matrix1Column,matrix2Row,matrix2Column;
        private void ndMatrix1Column_ValueChanged(object sender, EventArgs e)
        {
            ndMatrix2Row.Value = ndMatrix1Column.Value;
        }

        private void btnCreateMatrix_Click(object sender, EventArgs e)
        {
            matrix1Row =ndMatrix1Row.Value;
            matrix1Column = ndMatrix1Column.Value;
            matrix2Row = ndMatrix2Row.Value;
            matrix2Column = ndMatrix2Column.Value;
            Form2 form2 = new Form2();
            form2.Show(this);
        }
    }
}
