namespace MatrixMultiplactionFinalVersion
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ndMatrix1Row = new System.Windows.Forms.NumericUpDown();
            this.ndMatrix1Column = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ndMatrix2Column = new System.Windows.Forms.NumericUpDown();
            this.ndMatrix2Row = new System.Windows.Forms.NumericUpDown();
            this.btnCreateMatrix = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ndMatrix1Row)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ndMatrix1Column)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ndMatrix2Column)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ndMatrix2Row)).BeginInit();
            this.SuspendLayout();
            // 
            // ndMatrix1Row
            // 
            this.ndMatrix1Row.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ndMatrix1Row.Location = new System.Drawing.Point(181, 141);
            this.ndMatrix1Row.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.ndMatrix1Row.Name = "ndMatrix1Row";
            this.ndMatrix1Row.Size = new System.Drawing.Size(120, 34);
            this.ndMatrix1Row.TabIndex = 0;
            this.ndMatrix1Row.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // ndMatrix1Column
            // 
            this.ndMatrix1Column.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ndMatrix1Column.Location = new System.Drawing.Point(352, 139);
            this.ndMatrix1Column.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.ndMatrix1Column.Name = "ndMatrix1Column";
            this.ndMatrix1Column.Size = new System.Drawing.Size(120, 34);
            this.ndMatrix1Column.TabIndex = 1;
            this.ndMatrix1Column.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.ndMatrix1Column.ValueChanged += new System.EventHandler(this.ndMatrix1Column_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(54, 144);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 29);
            this.label1.TabIndex = 2;
            this.label1.Text = "Matrix 1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(54, 204);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 29);
            this.label2.TabIndex = 5;
            this.label2.Text = "Matrix 2";
            // 
            // ndMatrix2Column
            // 
            this.ndMatrix2Column.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ndMatrix2Column.Location = new System.Drawing.Point(352, 201);
            this.ndMatrix2Column.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.ndMatrix2Column.Name = "ndMatrix2Column";
            this.ndMatrix2Column.Size = new System.Drawing.Size(120, 34);
            this.ndMatrix2Column.TabIndex = 4;
            this.ndMatrix2Column.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // ndMatrix2Row
            // 
            this.ndMatrix2Row.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ndMatrix2Row.Location = new System.Drawing.Point(181, 201);
            this.ndMatrix2Row.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.ndMatrix2Row.Name = "ndMatrix2Row";
            this.ndMatrix2Row.Size = new System.Drawing.Size(120, 34);
            this.ndMatrix2Row.TabIndex = 3;
            this.ndMatrix2Row.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btnCreateMatrix
            // 
            this.btnCreateMatrix.Location = new System.Drawing.Point(59, 254);
            this.btnCreateMatrix.Name = "btnCreateMatrix";
            this.btnCreateMatrix.Size = new System.Drawing.Size(413, 37);
            this.btnCreateMatrix.TabIndex = 6;
            this.btnCreateMatrix.Text = "Create matrix";
            this.btnCreateMatrix.UseVisualStyleBackColor = true;
            this.btnCreateMatrix.Click += new System.EventHandler(this.btnCreateMatrix_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(555, 327);
            this.Controls.Add(this.btnCreateMatrix);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ndMatrix2Column);
            this.Controls.Add(this.ndMatrix2Row);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ndMatrix1Column);
            this.Controls.Add(this.ndMatrix1Row);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.ndMatrix1Row)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ndMatrix1Column)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ndMatrix2Column)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ndMatrix2Row)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown ndMatrix1Row;
        private System.Windows.Forms.NumericUpDown ndMatrix1Column;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown ndMatrix2Column;
        private System.Windows.Forms.NumericUpDown ndMatrix2Row;
        private System.Windows.Forms.Button btnCreateMatrix;
    }
}

