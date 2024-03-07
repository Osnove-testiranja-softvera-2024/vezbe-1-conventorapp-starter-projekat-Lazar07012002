namespace OTS2023_ConventorApp
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
            this.btn_Convert = new System.Windows.Forms.Button();
            this.lbl_1 = new System.Windows.Forms.Label();
            this.lbl_2 = new System.Windows.Forms.Label();
            this.rbtn_1 = new System.Windows.Forms.RadioButton();
            this.rbtn_2 = new System.Windows.Forms.RadioButton();
            this.txt_1 = new System.Windows.Forms.TextBox();
            this.txt_2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btn_Convert
            // 
            this.btn_Convert.Location = new System.Drawing.Point(375, 337);
            this.btn_Convert.Name = "btn_Convert";
            this.btn_Convert.Size = new System.Drawing.Size(75, 23);
            this.btn_Convert.TabIndex = 0;
            this.btn_Convert.Text = "Convert";
            this.btn_Convert.UseVisualStyleBackColor = true;
            this.btn_Convert.Click += new System.EventHandler(this.button1_Click);
            // 
            // lbl_1
            // 
            this.lbl_1.AutoSize = true;
            this.lbl_1.Location = new System.Drawing.Point(239, 206);
            this.lbl_1.Name = "lbl_1";
            this.lbl_1.Size = new System.Drawing.Size(35, 13);
            this.lbl_1.TabIndex = 2;
            this.lbl_1.Text = "label1";
            // 
            // lbl_2
            // 
            this.lbl_2.AutoSize = true;
            this.lbl_2.Location = new System.Drawing.Point(239, 256);
            this.lbl_2.Name = "lbl_2";
            this.lbl_2.Size = new System.Drawing.Size(35, 13);
            this.lbl_2.TabIndex = 3;
            this.lbl_2.Text = "label2";
            // 
            // rbtn_1
            // 
            this.rbtn_1.AutoSize = true;
            this.rbtn_1.Location = new System.Drawing.Point(125, 69);
            this.rbtn_1.Name = "rbtn_1";
            this.rbtn_1.Size = new System.Drawing.Size(50, 17);
            this.rbtn_1.TabIndex = 4;
            this.rbtn_1.TabStop = true;
            this.rbtn_1.Text = "Mass";
            this.rbtn_1.UseVisualStyleBackColor = true;
            this.rbtn_1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // rbtn_2
            // 
            this.rbtn_2.AutoSize = true;
            this.rbtn_2.Location = new System.Drawing.Point(125, 106);
            this.rbtn_2.Name = "rbtn_2";
            this.rbtn_2.Size = new System.Drawing.Size(58, 17);
            this.rbtn_2.TabIndex = 5;
            this.rbtn_2.TabStop = true;
            this.rbtn_2.Text = "Length";
            this.rbtn_2.UseVisualStyleBackColor = true;
            this.rbtn_2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // txt_1
            // 
            this.txt_1.Location = new System.Drawing.Point(316, 203);
            this.txt_1.Name = "txt_1";
            this.txt_1.Size = new System.Drawing.Size(134, 20);
            this.txt_1.TabIndex = 6;
      
            // 
            // txt_2
            // 
            this.txt_2.Location = new System.Drawing.Point(316, 253);
            this.txt_2.Name = "txt_2";
            this.txt_2.Size = new System.Drawing.Size(134, 20);
            this.txt_2.TabIndex = 7;
    
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(783, 456);
            this.Controls.Add(this.txt_2);
            this.Controls.Add(this.txt_1);
            this.Controls.Add(this.rbtn_2);
            this.Controls.Add(this.rbtn_1);
            this.Controls.Add(this.lbl_2);
            this.Controls.Add(this.lbl_1);
            this.Controls.Add(this.btn_Convert);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Convert;
        private System.Windows.Forms.Label lbl_1;
        private System.Windows.Forms.Label lbl_2;
        private System.Windows.Forms.RadioButton rbtn_1;
        private System.Windows.Forms.RadioButton rbtn_2;
        private System.Windows.Forms.TextBox txt_1;
        private System.Windows.Forms.TextBox txt_2;
    }
}

