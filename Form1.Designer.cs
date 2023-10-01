namespace homework_problems
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
            txt_EndingPoint = new TextBox();
            txt_StartingPoint = new TextBox();
            rdb_Every = new RadioButton();
            rdb_EveryOddProb = new RadioButton();
            rdb_EveryOtherOdd = new RadioButton();
            cmd_GetProblems = new Button();
            lbl_FirstProb = new Label();
            lbl_LastProb = new Label();
            lbl_Explanation = new Label();
            SuspendLayout();
            // 
            // txt_EndingPoint
            // 
            txt_EndingPoint.Location = new Point(362, 99);
            txt_EndingPoint.Name = "txt_EndingPoint";
            txt_EndingPoint.Size = new Size(100, 23);
            txt_EndingPoint.TabIndex = 0;
            txt_EndingPoint.TextChanged += txt_EndingPoint_TextChanged;
            // 
            // txt_StartingPoint
            // 
            txt_StartingPoint.Location = new Point(130, 99);
            txt_StartingPoint.Name = "txt_StartingPoint";
            txt_StartingPoint.Size = new Size(100, 23);
            txt_StartingPoint.TabIndex = 1;
            txt_StartingPoint.TextChanged += txt_StartingPoint_TextChanged;
            // 
            // rdb_Every
            // 
            rdb_Every.AutoSize = true;
            rdb_Every.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            rdb_Every.Location = new Point(12, 158);
            rdb_Every.Name = "rdb_Every";
            rdb_Every.Size = new Size(129, 25);
            rdb_Every.TabIndex = 2;
            rdb_Every.TabStop = true;
            rdb_Every.Text = "Every Problem";
            rdb_Every.UseVisualStyleBackColor = true;
            // 
            // rdb_EveryOddProb
            // 
            rdb_EveryOddProb.AutoSize = true;
            rdb_EveryOddProb.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            rdb_EveryOddProb.Location = new Point(175, 158);
            rdb_EveryOddProb.Name = "rdb_EveryOddProb";
            rdb_EveryOddProb.Size = new Size(165, 25);
            rdb_EveryOddProb.TabIndex = 3;
            rdb_EveryOddProb.TabStop = true;
            rdb_EveryOddProb.Text = "Odd Problems Only";
            rdb_EveryOddProb.UseVisualStyleBackColor = true;
            // 
            // rdb_EveryOtherOdd
            // 
            rdb_EveryOtherOdd.AutoSize = true;
            rdb_EveryOtherOdd.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            rdb_EveryOtherOdd.Location = new Point(362, 158);
            rdb_EveryOtherOdd.Name = "rdb_EveryOtherOdd";
            rdb_EveryOtherOdd.Size = new Size(207, 25);
            rdb_EveryOtherOdd.TabIndex = 4;
            rdb_EveryOtherOdd.TabStop = true;
            rdb_EveryOtherOdd.Text = "Every Other Odd Problem";
            rdb_EveryOtherOdd.UseVisualStyleBackColor = true;
            // 
            // cmd_GetProblems
            // 
            cmd_GetProblems.Location = new Point(217, 211);
            cmd_GetProblems.Name = "cmd_GetProblems";
            cmd_GetProblems.Size = new Size(141, 44);
            cmd_GetProblems.TabIndex = 5;
            cmd_GetProblems.Text = "Get Problems";
            cmd_GetProblems.UseVisualStyleBackColor = true;
            cmd_GetProblems.Click += cmd_GetProblems_Click;
            // 
            // lbl_FirstProb
            // 
            lbl_FirstProb.AutoSize = true;
            lbl_FirstProb.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_FirstProb.Location = new Point(12, 99);
            lbl_FirstProb.Name = "lbl_FirstProb";
            lbl_FirstProb.Size = new Size(103, 21);
            lbl_FirstProb.TabIndex = 6;
            lbl_FirstProb.Text = "First Problem";
            // 
            // lbl_LastProb
            // 
            lbl_LastProb.AutoSize = true;
            lbl_LastProb.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_LastProb.Location = new Point(269, 102);
            lbl_LastProb.Name = "lbl_LastProb";
            lbl_LastProb.Size = new Size(89, 19);
            lbl_LastProb.TabIndex = 7;
            lbl_LastProb.Text = "Last Problem";
            // 
            // lbl_Explanation
            // 
            lbl_Explanation.AutoSize = true;
            lbl_Explanation.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_Explanation.Location = new Point(12, 9);
            lbl_Explanation.Name = "lbl_Explanation";
            lbl_Explanation.Size = new Size(573, 56);
            lbl_Explanation.TabIndex = 8;
            lbl_Explanation.Text = "Input the first problem and last problem and it will let you\nnow the number of problems and what number the problem are.";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(593, 275);
            Controls.Add(lbl_Explanation);
            Controls.Add(lbl_LastProb);
            Controls.Add(lbl_FirstProb);
            Controls.Add(cmd_GetProblems);
            Controls.Add(rdb_EveryOtherOdd);
            Controls.Add(rdb_EveryOddProb);
            Controls.Add(rdb_Every);
            Controls.Add(txt_StartingPoint);
            Controls.Add(txt_EndingPoint);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txt_EndingPoint;
        private TextBox txt_StartingPoint;
        private RadioButton rdb_Every;
        private RadioButton rdb_EveryOddProb;
        private RadioButton rdb_EveryOtherOdd;
        private Button cmd_GetProblems;
        private Label lbl_FirstProb;
        private Label lbl_LastProb;
        private Label lbl_Explanation;
    }
}