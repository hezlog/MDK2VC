﻿namespace MDK2VC
{
    partial class FormMain
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tBoxMDKPath = new System.Windows.Forms.TextBox();
            this.tBoxvcxproj = new System.Windows.Forms.TextBox();
            this.btnTrans = new System.Windows.Forms.Button();
            this.btnSelMDKPath = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.btnTest = new System.Windows.Forms.Button();
            this.tboxfilters = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tboxsln = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnOpen = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "MDK项目";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "vcxproj";
            // 
            // tBoxMDKPath
            // 
            this.tBoxMDKPath.Location = new System.Drawing.Point(65, 11);
            this.tBoxMDKPath.Name = "tBoxMDKPath";
            this.tBoxMDKPath.ReadOnly = true;
            this.tBoxMDKPath.Size = new System.Drawing.Size(397, 21);
            this.tBoxMDKPath.TabIndex = 2;
            // 
            // tBoxvcxproj
            // 
            this.tBoxvcxproj.Location = new System.Drawing.Point(65, 43);
            this.tBoxvcxproj.Name = "tBoxvcxproj";
            this.tBoxvcxproj.ReadOnly = true;
            this.tBoxvcxproj.Size = new System.Drawing.Size(448, 21);
            this.tBoxvcxproj.TabIndex = 3;
            // 
            // btnTrans
            // 
            this.btnTrans.Location = new System.Drawing.Point(40, 124);
            this.btnTrans.Name = "btnTrans";
            this.btnTrans.Size = new System.Drawing.Size(75, 23);
            this.btnTrans.TabIndex = 4;
            this.btnTrans.Text = "测试读取";
            this.btnTrans.UseVisualStyleBackColor = true;
            this.btnTrans.Click += new System.EventHandler(this.btnTrans_Click);
            // 
            // btnSelMDKPath
            // 
            this.btnSelMDKPath.Location = new System.Drawing.Point(468, 9);
            this.btnSelMDKPath.Name = "btnSelMDKPath";
            this.btnSelMDKPath.Size = new System.Drawing.Size(45, 23);
            this.btnSelMDKPath.TabIndex = 6;
            this.btnSelMDKPath.Text = "...";
            this.btnSelMDKPath.UseVisualStyleBackColor = true;
            this.btnSelMDKPath.Click += new System.EventHandler(this.btnSelMDKPath_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(12, 153);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(492, 71);
            this.richTextBox1.TabIndex = 8;
            this.richTextBox1.Text = "";
            // 
            // btnTest
            // 
            this.btnTest.Location = new System.Drawing.Point(226, 124);
            this.btnTest.Name = "btnTest";
            this.btnTest.Size = new System.Drawing.Size(75, 23);
            this.btnTest.TabIndex = 9;
            this.btnTest.Text = "转换";
            this.btnTest.UseVisualStyleBackColor = true;
            this.btnTest.Click += new System.EventHandler(this.btnTest_Click);
            // 
            // tboxfilters
            // 
            this.tboxfilters.Location = new System.Drawing.Point(65, 70);
            this.tboxfilters.Name = "tboxfilters";
            this.tboxfilters.ReadOnly = true;
            this.tboxfilters.Size = new System.Drawing.Size(448, 21);
            this.tboxfilters.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 12);
            this.label3.TabIndex = 12;
            this.label3.Text = "filters";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 100);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(23, 12);
            this.label4.TabIndex = 14;
            this.label4.Text = "sln";
            // 
            // tboxsln
            // 
            this.tboxsln.Location = new System.Drawing.Point(65, 97);
            this.tboxsln.Name = "tboxsln";
            this.tboxsln.ReadOnly = true;
            this.tboxsln.Size = new System.Drawing.Size(448, 21);
            this.tboxsln.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(316, 129);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 12);
            this.label5.TabIndex = 15;
            this.label5.Text = "未转换";
            // 
            // btnOpen
            // 
            this.btnOpen.Location = new System.Drawing.Point(420, 124);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(75, 23);
            this.btnOpen.TabIndex = 16;
            this.btnOpen.Text = "打开";
            this.btnOpen.UseVisualStyleBackColor = true;
            this.btnOpen.Visible = false;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(524, 234);
            this.Controls.Add(this.btnOpen);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tboxsln);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tboxfilters);
            this.Controls.Add(this.btnTest);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.btnSelMDKPath);
            this.Controls.Add(this.btnTrans);
            this.Controls.Add(this.tBoxvcxproj);
            this.Controls.Add(this.tBoxMDKPath);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MDK5 2 VC2017";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tBoxMDKPath;
        private System.Windows.Forms.TextBox tBoxvcxproj;
        private System.Windows.Forms.Button btnTrans;
        private System.Windows.Forms.Button btnSelMDKPath;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button btnTest;
        private System.Windows.Forms.TextBox tboxfilters;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tboxsln;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnOpen;
    }
}

