namespace SimpleCalculator
{
    partial class IngeneersCalc
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
            this.cmdSquareOfX = new System.Windows.Forms.Button();
            this.cmdGetReverseValue = new System.Windows.Forms.Button();
            this.cmdSqrtX = new System.Windows.Forms.Button();
            this.cmdXToThePowerOfY = new System.Windows.Forms.Button();
            this.cmdFactorialX = new System.Windows.Forms.Button();
            this.cmdSquareRootX = new System.Windows.Forms.Button();
            this.cmdSquareEquation = new System.Windows.Forms.Button();
            this.cmdFactorialCalculationStart = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.textBoxFactorialResult = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.labelFactorialStatus = new System.Windows.Forms.Label();
            this.cmdFactorialCalculationCancel = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.labelFactStatus = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // KeyExit
            // 
            this.KeyExit.Location = new System.Drawing.Point(196, 273);
            // 
            // KeyDate
            // 
            this.KeyDate.Location = new System.Drawing.Point(196, 225);
            // 
            // KeyClear
            // 
            this.KeyClear.Location = new System.Drawing.Point(196, 179);
            this.KeyClear.Click += new System.EventHandler(this.KeyClear_Click_1);
            // 
            // KeyMinus
            // 
            this.KeyMinus.Location = new System.Drawing.Point(148, 321);
            // 
            // KeyPlus
            // 
            this.KeyPlus.Location = new System.Drawing.Point(196, 323);
            this.KeyPlus.Size = new System.Drawing.Size(55, 86);
            // 
            // KeyEqual
            // 
            this.KeyEqual.Location = new System.Drawing.Point(148, 369);
            this.KeyEqual.Size = new System.Drawing.Size(40, 40);
            // 
            // KeyMultiply
            // 
            this.KeyMultiply.Location = new System.Drawing.Point(148, 273);
            // 
            // KeyDivide
            // 
            this.KeyDivide.Location = new System.Drawing.Point(148, 225);
            // 
            // KeyPoint
            // 
            this.KeyPoint.Location = new System.Drawing.Point(52, 369);
            // 
            // KeySign
            // 
            this.KeySign.Location = new System.Drawing.Point(100, 369);
            // 
            // KeyZero
            // 
            this.KeyZero.Location = new System.Drawing.Point(4, 369);
            // 
            // KeyNine
            // 
            this.KeyNine.Location = new System.Drawing.Point(100, 225);
            // 
            // KeyEight
            // 
            this.KeyEight.Location = new System.Drawing.Point(52, 225);
            // 
            // KeySeven
            // 
            this.KeySeven.Location = new System.Drawing.Point(4, 225);
            // 
            // KeySix
            // 
            this.KeySix.Location = new System.Drawing.Point(100, 273);
            // 
            // KeyFive
            // 
            this.KeyFive.Location = new System.Drawing.Point(52, 273);
            // 
            // KeyFour
            // 
            this.KeyFour.Location = new System.Drawing.Point(4, 273);
            // 
            // KeyThree
            // 
            this.KeyThree.Location = new System.Drawing.Point(100, 321);
            // 
            // KeyTwo
            // 
            this.KeyTwo.Location = new System.Drawing.Point(52, 321);
            // 
            // KeyOne
            // 
            this.KeyOne.Location = new System.Drawing.Point(4, 321);
            // 
            // cmdSquareOfX
            // 
            this.cmdSquareOfX.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Bold);
            this.cmdSquareOfX.ForeColor = System.Drawing.Color.Blue;
            this.cmdSquareOfX.Location = new System.Drawing.Point(146, 179);
            this.cmdSquareOfX.Name = "cmdSquareOfX";
            this.cmdSquareOfX.Size = new System.Drawing.Size(40, 40);
            this.cmdSquareOfX.TabIndex = 30;
            this.cmdSquareOfX.TabStop = false;
            this.cmdSquareOfX.Text = "х²";
            this.cmdSquareOfX.Click += new System.EventHandler(this.cmdSquareOfX_Click);
            // 
            // cmdGetReverseValue
            // 
            this.cmdGetReverseValue.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Bold);
            this.cmdGetReverseValue.ForeColor = System.Drawing.Color.Blue;
            this.cmdGetReverseValue.Location = new System.Drawing.Point(100, 179);
            this.cmdGetReverseValue.Name = "cmdGetReverseValue";
            this.cmdGetReverseValue.Size = new System.Drawing.Size(40, 40);
            this.cmdGetReverseValue.TabIndex = 29;
            this.cmdGetReverseValue.TabStop = false;
            this.cmdGetReverseValue.Text = "1/x";
            this.cmdGetReverseValue.Click += new System.EventHandler(this.cmdGetReverseValue_Click);
            // 
            // cmdSqrtX
            // 
            this.cmdSqrtX.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Bold);
            this.cmdSqrtX.ForeColor = System.Drawing.Color.Blue;
            this.cmdSqrtX.Location = new System.Drawing.Point(52, 179);
            this.cmdSqrtX.Name = "cmdSqrtX";
            this.cmdSqrtX.Size = new System.Drawing.Size(40, 40);
            this.cmdSqrtX.TabIndex = 28;
            this.cmdSqrtX.TabStop = false;
            this.cmdSqrtX.Text = "√x";
            this.cmdSqrtX.Click += new System.EventHandler(this.cmdSqrtX_Click);
            // 
            // cmdXToThePowerOfY
            // 
            this.cmdXToThePowerOfY.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Bold);
            this.cmdXToThePowerOfY.ForeColor = System.Drawing.Color.Blue;
            this.cmdXToThePowerOfY.Location = new System.Drawing.Point(4, 179);
            this.cmdXToThePowerOfY.Name = "cmdXToThePowerOfY";
            this.cmdXToThePowerOfY.Size = new System.Drawing.Size(40, 40);
            this.cmdXToThePowerOfY.TabIndex = 27;
            this.cmdXToThePowerOfY.TabStop = false;
            this.cmdXToThePowerOfY.Text = "xʸ";
            this.cmdXToThePowerOfY.Click += new System.EventHandler(this.cmdXToThePowerOfY_Click);
            // 
            // cmdFactorialX
            // 
            this.cmdFactorialX.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Bold);
            this.cmdFactorialX.ForeColor = System.Drawing.Color.Blue;
            this.cmdFactorialX.Location = new System.Drawing.Point(4, 133);
            this.cmdFactorialX.Name = "cmdFactorialX";
            this.cmdFactorialX.Size = new System.Drawing.Size(40, 40);
            this.cmdFactorialX.TabIndex = 31;
            this.cmdFactorialX.TabStop = false;
            this.cmdFactorialX.Text = "F*";
            this.cmdFactorialX.Click += new System.EventHandler(this.cmdFactorialX_Click);
            // 
            // cmdSquareRootX
            // 
            this.cmdSquareRootX.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Bold);
            this.cmdSquareRootX.ForeColor = System.Drawing.Color.Blue;
            this.cmdSquareRootX.Location = new System.Drawing.Point(52, 133);
            this.cmdSquareRootX.Name = "cmdSquareRootX";
            this.cmdSquareRootX.Size = new System.Drawing.Size(40, 40);
            this.cmdSquareRootX.TabIndex = 32;
            this.cmdSquareRootX.TabStop = false;
            this.cmdSquareRootX.Text = "∛x";
            this.cmdSquareRootX.Click += new System.EventHandler(this.cmdSquareRootX_Click);
            // 
            // cmdSquareEquation
            // 
            this.cmdSquareEquation.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Bold);
            this.cmdSquareEquation.ForeColor = System.Drawing.Color.Blue;
            this.cmdSquareEquation.Location = new System.Drawing.Point(100, 133);
            this.cmdSquareEquation.Name = "cmdSquareEquation";
            this.cmdSquareEquation.Size = new System.Drawing.Size(151, 40);
            this.cmdSquareEquation.TabIndex = 33;
            this.cmdSquareEquation.TabStop = false;
            this.cmdSquareEquation.Text = "square equation";
            this.cmdSquareEquation.Click += new System.EventHandler(this.cmdSquareEquation_Click);
            // 
            // cmdFactorialCalculationStart
            // 
            this.cmdFactorialCalculationStart.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Bold);
            this.cmdFactorialCalculationStart.ForeColor = System.Drawing.Color.Blue;
            this.cmdFactorialCalculationStart.Location = new System.Drawing.Point(4, 87);
            this.cmdFactorialCalculationStart.Name = "cmdFactorialCalculationStart";
            this.cmdFactorialCalculationStart.Size = new System.Drawing.Size(88, 40);
            this.cmdFactorialCalculationStart.TabIndex = 34;
            this.cmdFactorialCalculationStart.TabStop = false;
            this.cmdFactorialCalculationStart.Text = "F* (Start)";
            this.cmdFactorialCalculationStart.Click += new System.EventHandler(this.button1_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // textBoxFactorialResult
            // 
            this.textBoxFactorialResult.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.textBoxFactorialResult.Location = new System.Drawing.Point(98, 87);
            this.textBoxFactorialResult.Name = "textBoxFactorialResult";
            this.textBoxFactorialResult.Size = new System.Drawing.Size(100, 20);
            this.textBoxFactorialResult.TabIndex = 37;
            this.textBoxFactorialResult.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(95, 114);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 38;
            this.label1.Text = "Status: ";
            // 
            // labelFactorialStatus
            // 
            this.labelFactorialStatus.AutoSize = true;
            this.labelFactorialStatus.Location = new System.Drawing.Point(230, 348);
            this.labelFactorialStatus.Name = "labelFactorialStatus";
            this.labelFactorialStatus.Size = new System.Drawing.Size(0, 13);
            this.labelFactorialStatus.TabIndex = 39;
            // 
            // cmdFactorialCalculationCancel
            // 
            this.cmdFactorialCalculationCancel.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Bold);
            this.cmdFactorialCalculationCancel.ForeColor = System.Drawing.Color.Blue;
            this.cmdFactorialCalculationCancel.Location = new System.Drawing.Point(204, 87);
            this.cmdFactorialCalculationCancel.Name = "cmdFactorialCalculationCancel";
            this.cmdFactorialCalculationCancel.Size = new System.Drawing.Size(48, 40);
            this.cmdFactorialCalculationCancel.TabIndex = 40;
            this.cmdFactorialCalculationCancel.TabStop = false;
            this.cmdFactorialCalculationCancel.Text = "Stop";
            this.cmdFactorialCalculationCancel.Click += new System.EventHandler(this.cmdFactorialCalculationCancel_Click);
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.WorkerReportsProgress = true;
            this.backgroundWorker1.WorkerSupportsCancellation = true;
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            this.backgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker1_RunWorkerCompleted);
            // 
            // labelFactStatus
            // 
            this.labelFactStatus.AutoSize = true;
            this.labelFactStatus.Location = new System.Drawing.Point(132, 114);
            this.labelFactStatus.Name = "labelFactStatus";
            this.labelFactStatus.Size = new System.Drawing.Size(0, 13);
            this.labelFactStatus.TabIndex = 41;
            // 
            // IngeneersCalc
            // 
            this.ClientSize = new System.Drawing.Size(259, 420);
            this.Controls.Add(this.labelFactStatus);
            this.Controls.Add(this.cmdFactorialCalculationCancel);
            this.Controls.Add(this.labelFactorialStatus);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxFactorialResult);
            this.Controls.Add(this.cmdFactorialCalculationStart);
            this.Controls.Add(this.cmdSquareEquation);
            this.Controls.Add(this.cmdSquareRootX);
            this.Controls.Add(this.cmdFactorialX);
            this.Controls.Add(this.cmdSquareOfX);
            this.Controls.Add(this.cmdGetReverseValue);
            this.Controls.Add(this.cmdSqrtX);
            this.Controls.Add(this.cmdXToThePowerOfY);
            this.Name = "IngeneersCalc";
            this.Text = "Engeneers Calculator";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.IngeneersCalc_FormClosed);
            this.Controls.SetChildIndex(this.OutputDisplay, 0);
            this.Controls.SetChildIndex(this.KeyExit, 0);
            this.Controls.SetChildIndex(this.KeyClear, 0);
            this.Controls.SetChildIndex(this.KeyDate, 0);
            this.Controls.SetChildIndex(this.KeyEqual, 0);
            this.Controls.SetChildIndex(this.KeyPoint, 0);
            this.Controls.SetChildIndex(this.KeySign, 0);
            this.Controls.SetChildIndex(this.KeyDivide, 0);
            this.Controls.SetChildIndex(this.KeyMultiply, 0);
            this.Controls.SetChildIndex(this.KeyMinus, 0);
            this.Controls.SetChildIndex(this.KeyPlus, 0);
            this.Controls.SetChildIndex(this.KeyZero, 0);
            this.Controls.SetChildIndex(this.KeyNine, 0);
            this.Controls.SetChildIndex(this.KeyEight, 0);
            this.Controls.SetChildIndex(this.KeySeven, 0);
            this.Controls.SetChildIndex(this.KeySix, 0);
            this.Controls.SetChildIndex(this.KeyFive, 0);
            this.Controls.SetChildIndex(this.KeyFour, 0);
            this.Controls.SetChildIndex(this.KeyThree, 0);
            this.Controls.SetChildIndex(this.KeyTwo, 0);
            this.Controls.SetChildIndex(this.KeyOne, 0);
            this.Controls.SetChildIndex(this.cmdXToThePowerOfY, 0);
            this.Controls.SetChildIndex(this.cmdSqrtX, 0);
            this.Controls.SetChildIndex(this.cmdGetReverseValue, 0);
            this.Controls.SetChildIndex(this.cmdSquareOfX, 0);
            this.Controls.SetChildIndex(this.cmdFactorialX, 0);
            this.Controls.SetChildIndex(this.cmdSquareRootX, 0);
            this.Controls.SetChildIndex(this.cmdSquareEquation, 0);
            this.Controls.SetChildIndex(this.cmdFactorialCalculationStart, 0);
            this.Controls.SetChildIndex(this.textBoxFactorialResult, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.labelFactorialStatus, 0);
            this.Controls.SetChildIndex(this.cmdFactorialCalculationCancel, 0);
            this.Controls.SetChildIndex(this.labelFactStatus, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cmdSquareOfX;
        private System.Windows.Forms.Button cmdGetReverseValue;
        private System.Windows.Forms.Button cmdSqrtX;
        private System.Windows.Forms.Button cmdXToThePowerOfY;
        private System.Windows.Forms.Button cmdFactorialX;
        private System.Windows.Forms.Button cmdSquareRootX;
        private System.Windows.Forms.Button cmdSquareEquation;
        private System.Windows.Forms.Button cmdFactorialCalculationStart;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TextBox textBoxFactorialResult;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelFactorialStatus;
        private System.Windows.Forms.Button cmdFactorialCalculationCancel;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label labelFactStatus;
    }
}
