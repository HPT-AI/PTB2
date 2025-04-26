namespace PTB2App_New
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            labelTitle = new Label();
            buttonExit = new Button();
            labelCoefficientA = new Label();
            labelCoefficientB = new Label();
            labelCoefficientC = new Label();
            textBoxCoefficientA = new TextBox();
            textBoxCoefficientB = new TextBox();
            textBoxCoefficientC = new TextBox();
            buttonSolve = new Button();
            buttonClear = new Button();
            buttonViewHistory = new Button();
            labelResult = new Label();
            textBoxResult = new TextBox();
            SuspendLayout();
            // 
            // labelTitle
            // 
            labelTitle.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            labelTitle.Location = new System.Drawing.Point(12, 9);
            labelTitle.Name = "labelTitle";
            labelTitle.Size = new System.Drawing.Size(776, 50);
            labelTitle.TabIndex = 0;
            labelTitle.Text = "Quadratic Equation Solver";
            labelTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonExit
            // 
            buttonExit.Location = new System.Drawing.Point(650, 400);
            buttonExit.Name = "buttonExit";
            buttonExit.Size = new System.Drawing.Size(138, 38);
            buttonExit.TabIndex = 9;
            buttonExit.Text = "E&xit";
            buttonExit.UseVisualStyleBackColor = true;
            buttonExit.Click += buttonExit_Click;
            // 
            // labelCoefficientA
            // 
            labelCoefficientA.AutoSize = true;
            labelCoefficientA.Location = new System.Drawing.Point(50, 80);
            labelCoefficientA.Name = "labelCoefficientA";
            labelCoefficientA.Size = new System.Drawing.Size(150, 25);
            labelCoefficientA.TabIndex = 2;
            labelCoefficientA.Text = "Coefficient a:";
            // 
            // labelCoefficientB
            // 
            labelCoefficientB.AutoSize = true;
            labelCoefficientB.Location = new System.Drawing.Point(50, 130);
            labelCoefficientB.Name = "labelCoefficientB";
            labelCoefficientB.Size = new System.Drawing.Size(150, 25);
            labelCoefficientB.TabIndex = 3;
            labelCoefficientB.Text = "Coefficient b:";
            // 
            // labelCoefficientC
            // 
            labelCoefficientC.AutoSize = true;
            labelCoefficientC.Location = new System.Drawing.Point(50, 180);
            labelCoefficientC.Name = "labelCoefficientC";
            labelCoefficientC.Size = new System.Drawing.Size(150, 25);
            labelCoefficientC.TabIndex = 4;
            labelCoefficientC.Text = "Coefficient c:";
            // 
            // textBoxCoefficientA
            // 
            textBoxCoefficientA.Location = new System.Drawing.Point(200, 80);
            textBoxCoefficientA.Name = "textBoxCoefficientA";
            textBoxCoefficientA.Size = new System.Drawing.Size(150, 31);
            textBoxCoefficientA.TabIndex = 1;
            // 
            // textBoxCoefficientB
            // 
            textBoxCoefficientB.Location = new System.Drawing.Point(200, 130);
            textBoxCoefficientB.Name = "textBoxCoefficientB";
            textBoxCoefficientB.Size = new System.Drawing.Size(150, 31);
            textBoxCoefficientB.TabIndex = 2;
            // 
            // textBoxCoefficientC
            // 
            textBoxCoefficientC.Location = new System.Drawing.Point(200, 180);
            textBoxCoefficientC.Name = "textBoxCoefficientC";
            textBoxCoefficientC.Size = new System.Drawing.Size(150, 31);
            textBoxCoefficientC.TabIndex = 3;
            // 
            // buttonSolve
            // 
            buttonSolve.Location = new System.Drawing.Point(50, 240);
            buttonSolve.Name = "buttonSolve";
            buttonSolve.Size = new System.Drawing.Size(150, 38);
            buttonSolve.TabIndex = 4;
            buttonSolve.Text = "Solve";
            buttonSolve.UseVisualStyleBackColor = true;
            buttonSolve.Click += buttonSolve_Click;
            // 
            // buttonClear
            // 
            buttonClear.Location = new System.Drawing.Point(220, 240);
            buttonClear.Name = "buttonClear";
            buttonClear.Size = new System.Drawing.Size(150, 38);
            buttonClear.TabIndex = 5;
            buttonClear.Text = "Clear";
            buttonClear.UseVisualStyleBackColor = true;
            buttonClear.Click += buttonClear_Click;
            // 
            // buttonViewHistory
            // 
            buttonViewHistory.Location = new System.Drawing.Point(390, 240);
            buttonViewHistory.Name = "buttonViewHistory";
            buttonViewHistory.Size = new System.Drawing.Size(150, 38);
            buttonViewHistory.TabIndex = 6;
            buttonViewHistory.Text = "View History";
            buttonViewHistory.UseVisualStyleBackColor = true;
            buttonViewHistory.Click += buttonViewHistory_Click;
            // 
            // labelResult
            // 
            labelResult.AutoSize = true;
            labelResult.Location = new System.Drawing.Point(50, 300);
            labelResult.Name = "labelResult";
            labelResult.Size = new System.Drawing.Size(79, 25);
            labelResult.TabIndex = 11;
            labelResult.Text = "Result:";
            // 
            // textBoxResult
            // 
            textBoxResult.Location = new System.Drawing.Point(50, 330);
            textBoxResult.Multiline = true;
            textBoxResult.Name = "textBoxResult";
            textBoxResult.ReadOnly = true;
            textBoxResult.Size = new System.Drawing.Size(490, 108);
            textBoxResult.TabIndex = 8;
            // 
            // Form1
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(800, 450);
            Controls.Add(textBoxResult);
            Controls.Add(labelResult);
            Controls.Add(buttonViewHistory);
            Controls.Add(buttonClear);
            Controls.Add(buttonSolve);
            Controls.Add(textBoxCoefficientC);
            Controls.Add(textBoxCoefficientB);
            Controls.Add(textBoxCoefficientA);
            Controls.Add(labelCoefficientC);
            Controls.Add(labelCoefficientB);
            Controls.Add(labelCoefficientA);
            Controls.Add(buttonExit);
            Controls.Add(labelTitle);
            Name = "Form1";
            Text = "Quadratic Equation Solver";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelTitle;
        private Button buttonExit;
        private Label labelCoefficientA;
        private Label labelCoefficientB;
        private Label labelCoefficientC;
        private TextBox textBoxCoefficientA;
        private TextBox textBoxCoefficientB;
        private TextBox textBoxCoefficientC;
        private Button buttonSolve;
        private Button buttonClear;
        private Button buttonViewHistory;
        private Label labelResult;
        private TextBox textBoxResult;
    }
}
