﻿
namespace week2.forms
{
    partial class addCourse
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
            this.textBoxCPed = new System.Windows.Forms.TextBox();
            this.textBoxCName = new System.Windows.Forms.TextBox();
            this.textBoxCId = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textboxCDesc = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.addCourseBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxCPed
            // 
            this.textBoxCPed.Location = new System.Drawing.Point(177, 179);
            this.textBoxCPed.Name = "textBoxCPed";
            this.textBoxCPed.Size = new System.Drawing.Size(153, 22);
            this.textBoxCPed.TabIndex = 16;
            this.textBoxCPed.TextChanged += new System.EventHandler(this.textBoxCPed_TextChanged);
            // 
            // textBoxCName
            // 
            this.textBoxCName.Location = new System.Drawing.Point(177, 117);
            this.textBoxCName.Name = "textBoxCName";
            this.textBoxCName.Size = new System.Drawing.Size(248, 22);
            this.textBoxCName.TabIndex = 15;
            this.textBoxCName.TextChanged += new System.EventHandler(this.textBoxCName_TextChanged);
            // 
            // textBoxCId
            // 
            this.textBoxCId.Location = new System.Drawing.Point(177, 58);
            this.textBoxCId.Name = "textBoxCId";
            this.textBoxCId.Size = new System.Drawing.Size(102, 22);
            this.textBoxCId.TabIndex = 14;
            this.textBoxCId.TextChanged += new System.EventHandler(this.textBoxCId_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(67, 179);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 24);
            this.label3.TabIndex = 13;
            this.label3.Text = "Period:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(67, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 24);
            this.label2.TabIndex = 12;
            this.label2.Text = "Label:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(67, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 24);
            this.label1.TabIndex = 11;
            this.label1.Text = "Course ID:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // textboxCDesc
            // 
            this.textboxCDesc.Location = new System.Drawing.Point(177, 250);
            this.textboxCDesc.Multiline = true;
            this.textboxCDesc.Name = "textboxCDesc";
            this.textboxCDesc.Size = new System.Drawing.Size(331, 124);
            this.textboxCDesc.TabIndex = 18;
            this.textboxCDesc.TextChanged += new System.EventHandler(this.textboxCDesc_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(67, 266);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 24);
            this.label4.TabIndex = 17;
            this.label4.Text = "Description:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // addCourseBtn
            // 
            this.addCourseBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.addCourseBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addCourseBtn.ForeColor = System.Drawing.Color.White;
            this.addCourseBtn.Location = new System.Drawing.Point(129, 398);
            this.addCourseBtn.Name = "addCourseBtn";
            this.addCourseBtn.Size = new System.Drawing.Size(319, 54);
            this.addCourseBtn.TabIndex = 19;
            this.addCourseBtn.Text = "ADD";
            this.addCourseBtn.UseVisualStyleBackColor = false;
            this.addCourseBtn.Click += new System.EventHandler(this.addCourseBtn_Click);
            // 
            // addCourse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(576, 472);
            this.Controls.Add(this.addCourseBtn);
            this.Controls.Add(this.textboxCDesc);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxCPed);
            this.Controls.Add(this.textBoxCName);
            this.Controls.Add(this.textBoxCId);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "addCourse";
            this.Text = "Add Course";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxCPed;
        private System.Windows.Forms.TextBox textBoxCName;
        private System.Windows.Forms.TextBox textBoxCId;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textboxCDesc;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button addCourseBtn;
    }
}