﻿namespace HASHMD5TEST
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
            this.button1 = new System.Windows.Forms.Button();
            this.txt_MD5_ENC = new System.Windows.Forms.TextBox();
            this.txt_TEXT1_ENC = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_TEXT_DECRY = new System.Windows.Forms.TextBox();
            this.txt_MD5_DECR = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(51, 138);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(176, 42);
            this.button1.TabIndex = 0;
            this.button1.Text = "ENCRYPT";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txt_MD5_ENC
            // 
            this.txt_MD5_ENC.Location = new System.Drawing.Point(51, 112);
            this.txt_MD5_ENC.Name = "txt_MD5_ENC";
            this.txt_MD5_ENC.Size = new System.Drawing.Size(176, 20);
            this.txt_MD5_ENC.TabIndex = 1;
            // 
            // txt_TEXT1_ENC
            // 
            this.txt_TEXT1_ENC.Location = new System.Drawing.Point(51, 86);
            this.txt_TEXT1_ENC.Name = "txt_TEXT1_ENC";
            this.txt_TEXT1_ENC.Size = new System.Drawing.Size(176, 20);
            this.txt_TEXT1_ENC.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "TEXT";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "MD5";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(328, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "MD5";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(328, 115);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "TEXT";
            // 
            // txt_TEXT_DECRY
            // 
            this.txt_TEXT_DECRY.Location = new System.Drawing.Point(369, 112);
            this.txt_TEXT_DECRY.Name = "txt_TEXT_DECRY";
            this.txt_TEXT_DECRY.Size = new System.Drawing.Size(176, 20);
            this.txt_TEXT_DECRY.TabIndex = 7;
            // 
            // txt_MD5_DECR
            // 
            this.txt_MD5_DECR.Location = new System.Drawing.Point(369, 86);
            this.txt_MD5_DECR.Name = "txt_MD5_DECR";
            this.txt_MD5_DECR.Size = new System.Drawing.Size(176, 20);
            this.txt_MD5_DECR.TabIndex = 6;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(369, 138);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(176, 42);
            this.button2.TabIndex = 5;
            this.button2.Text = "DECRYPT";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(571, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_TEXT_DECRY);
            this.Controls.Add(this.txt_MD5_DECR);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_TEXT1_ENC);
            this.Controls.Add(this.txt_MD5_ENC);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txt_MD5_ENC;
        private System.Windows.Forms.TextBox txt_TEXT1_ENC;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_TEXT_DECRY;
        private System.Windows.Forms.TextBox txt_MD5_DECR;
        private System.Windows.Forms.Button button2;
    }
}

