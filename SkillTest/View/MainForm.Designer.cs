namespace SkillTest.View
{
    partial class SortingApplication
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
            label1 = new Label();
            label2 = new Label();
            textBoxInput = new TextBox();
            comboBoxSort = new ComboBox();
            label3 = new Label();
            textBoxResult = new TextBox();
            buttonSort = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F);
            label1.Location = new Point(12, 49);
            label1.Name = "label1";
            label1.Size = new Size(180, 37);
            label1.TabIndex = 0;
            label1.Text = "Input a string:";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 20F);
            label2.Location = new Point(12, 128);
            label2.Name = "label2";
            label2.Size = new Size(120, 37);
            label2.TabIndex = 1;
            label2.Text = "Strategy:";
            // 
            // textBoxInput
            // 
            textBoxInput.Font = new Font("Segoe UI", 20F);
            textBoxInput.Location = new Point(198, 43);
            textBoxInput.Name = "textBoxInput";
            textBoxInput.Size = new Size(335, 43);
            textBoxInput.TabIndex = 2;
            // 
            // comboBoxSort
            // 
            comboBoxSort.Font = new Font("Segoe UI", 20F);
            comboBoxSort.FormattingEnabled = true;
            comboBoxSort.Location = new Point(198, 128);
            comboBoxSort.Name = "comboBoxSort";
            comboBoxSort.Size = new Size(335, 45);
            comboBoxSort.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 20F);
            label3.Location = new Point(12, 286);
            label3.Name = "label3";
            label3.Size = new Size(94, 37);
            label3.TabIndex = 4;
            label3.Text = "Result:";
            // 
            // textBoxResult
            // 
            textBoxResult.Font = new Font("Segoe UI", 20F);
            textBoxResult.Location = new Point(198, 280);
            textBoxResult.Name = "textBoxResult";
            textBoxResult.ReadOnly = true;
            textBoxResult.Size = new Size(335, 43);
            textBoxResult.TabIndex = 5;
            textBoxResult.TextChanged += textBoxResult_TextChanged;
            // 
            // buttonSort
            // 
            buttonSort.BackColor = SystemColors.HotTrack;
            buttonSort.Font = new Font("Segoe UI", 20F);
            buttonSort.ForeColor = SystemColors.ButtonFace;
            buttonSort.Location = new Point(275, 197);
            buttonSort.Name = "buttonSort";
            buttonSort.Size = new Size(152, 53);
            buttonSort.TabIndex = 6;
            buttonSort.Text = "Sort";
            buttonSort.UseVisualStyleBackColor = false;
            // 
            // SortingApplication
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonSort);
            Controls.Add(textBoxResult);
            Controls.Add(label3);
            Controls.Add(comboBoxSort);
            Controls.Add(textBoxInput);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "SortingApplication";
            Text = "MainForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox textBoxInput;
        private ComboBox comboBoxSort;
        private Label label3;
        private TextBox textBoxResult;
        private Button buttonSort;
    }
}