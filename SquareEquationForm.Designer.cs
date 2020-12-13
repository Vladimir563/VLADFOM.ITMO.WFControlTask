﻿namespace SimpleCalculator
{
    partial class SquareEquationForm
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
            this.components = new System.ComponentModel.Container();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxFirstRoot = new System.Windows.Forms.TextBox();
            this.textBoxSecondRoot = new System.Windows.Forms.TextBox();
            this.cmdSollveSquareEquation = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxBVal = new System.Windows.Forms.TextBox();
            this.textBoxCVal = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxAVal = new System.Windows.Forms.TextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.labelSquareRootsAnswer = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.Blue;
            this.label5.Location = new System.Drawing.Point(63, 113);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(112, 16);
            this.label5.TabIndex = 21;
            this.label5.Text = "- second root";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.Blue;
            this.label4.Location = new System.Drawing.Point(63, 87);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 16);
            this.label4.TabIndex = 20;
            this.label4.Text = "- first root";
            // 
            // textBoxFirstRoot
            // 
            this.textBoxFirstRoot.Location = new System.Drawing.Point(7, 84);
            this.textBoxFirstRoot.Name = "textBoxFirstRoot";
            this.textBoxFirstRoot.Size = new System.Drawing.Size(50, 20);
            this.textBoxFirstRoot.TabIndex = 5;
            // 
            // textBoxSecondRoot
            // 
            this.textBoxSecondRoot.Location = new System.Drawing.Point(7, 110);
            this.textBoxSecondRoot.Name = "textBoxSecondRoot";
            this.textBoxSecondRoot.Size = new System.Drawing.Size(50, 20);
            this.textBoxSecondRoot.TabIndex = 6;
            // 
            // cmdSollveSquareEquation
            // 
            this.cmdSollveSquareEquation.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Bold);
            this.cmdSollveSquareEquation.ForeColor = System.Drawing.Color.Blue;
            this.cmdSollveSquareEquation.Location = new System.Drawing.Point(36, 33);
            this.cmdSollveSquareEquation.Name = "cmdSollveSquareEquation";
            this.cmdSollveSquareEquation.Size = new System.Drawing.Size(253, 23);
            this.cmdSollveSquareEquation.TabIndex = 4;
            this.cmdSollveSquareEquation.Text = "Solve square equation";
            this.cmdSollveSquareEquation.UseVisualStyleBackColor = true;
            this.cmdSollveSquareEquation.Click += new System.EventHandler(this.cmdSollveSquareEquation_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.Blue;
            this.label3.Location = new System.Drawing.Point(282, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 17);
            this.label3.TabIndex = 16;
            this.label3.Text = "= 0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.Blue;
            this.label2.Location = new System.Drawing.Point(181, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 17);
            this.label2.TabIndex = 15;
            this.label2.Text = "x +";
            // 
            // textBoxBVal
            // 
            this.textBoxBVal.Location = new System.Drawing.Point(111, 6);
            this.textBoxBVal.Name = "textBoxBVal";
            this.textBoxBVal.Size = new System.Drawing.Size(50, 20);
            this.textBoxBVal.TabIndex = 2;
            this.textBoxBVal.Text = "0";
            this.textBoxBVal.TextChanged += new System.EventHandler(this.textBoxBVal_TextChanged);
            // 
            // textBoxCVal
            // 
            this.textBoxCVal.Location = new System.Drawing.Point(213, 6);
            this.textBoxCVal.Name = "textBoxCVal";
            this.textBoxCVal.Size = new System.Drawing.Size(50, 20);
            this.textBoxCVal.TabIndex = 3;
            this.textBoxCVal.Text = "0";
            this.textBoxCVal.TextChanged += new System.EventHandler(this.textBoxCVal_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(74, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 17);
            this.label1.TabIndex = 12;
            this.label1.Text = "х² +";
            // 
            // textBoxAVal
            // 
            this.textBoxAVal.Location = new System.Drawing.Point(7, 6);
            this.textBoxAVal.Name = "textBoxAVal";
            this.textBoxAVal.Size = new System.Drawing.Size(50, 20);
            this.textBoxAVal.TabIndex = 1;
            this.textBoxAVal.Text = "0";
            this.textBoxAVal.TextChanged += new System.EventHandler(this.textBoxAVal_TextChanged);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // labelSquareRootsAnswer
            // 
            this.labelSquareRootsAnswer.AutoSize = true;
            this.labelSquareRootsAnswer.Location = new System.Drawing.Point(4, 68);
            this.labelSquareRootsAnswer.Name = "labelSquareRootsAnswer";
            this.labelSquareRootsAnswer.Size = new System.Drawing.Size(0, 13);
            this.labelSquareRootsAnswer.TabIndex = 23;
            // 
            // SquareEquationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ClientSize = new System.Drawing.Size(328, 147);
            this.Controls.Add(this.labelSquareRootsAnswer);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxFirstRoot);
            this.Controls.Add(this.textBoxSecondRoot);
            this.Controls.Add(this.cmdSollveSquareEquation);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxBVal);
            this.Controls.Add(this.textBoxCVal);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxAVal);
            this.Name = "SquareEquationForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Square Equation";
            this.TopMost = true;
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxFirstRoot;
        private System.Windows.Forms.TextBox textBoxSecondRoot;
        private System.Windows.Forms.Button cmdSollveSquareEquation;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxBVal;
        private System.Windows.Forms.TextBox textBoxCVal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxAVal;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Label labelSquareRootsAnswer;
    }
}