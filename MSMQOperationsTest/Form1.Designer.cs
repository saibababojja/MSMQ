﻿namespace MSMQOperationsTest
{
    partial class frmMSMQ
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
            this.txtMSMQName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.PushBtn = new System.Windows.Forms.Button();
            this.PopBtn = new System.Windows.Forms.Button();
            this.txtInputData = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtMSMQName
            // 
            this.txtMSMQName.Location = new System.Drawing.Point(101, 12);
            this.txtMSMQName.Name = "txtMSMQName";
            this.txtMSMQName.Size = new System.Drawing.Size(177, 20);
            this.txtMSMQName.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "Queue Name";
            // 
            // PushBtn
            // 
            this.PushBtn.Location = new System.Drawing.Point(101, 85);
            this.PushBtn.Name = "PushBtn";
            this.PushBtn.Size = new System.Drawing.Size(75, 23);
            this.PushBtn.TabIndex = 4;
            this.PushBtn.Text = "Push";
            this.PushBtn.UseVisualStyleBackColor = true;
            this.PushBtn.Click += new System.EventHandler(this.PushBtn_Click);
            // 
            // PopBtn
            // 
            this.PopBtn.Location = new System.Drawing.Point(192, 85);
            this.PopBtn.Name = "PopBtn";
            this.PopBtn.Size = new System.Drawing.Size(75, 23);
            this.PopBtn.TabIndex = 5;
            this.PopBtn.Text = "Pop";
            this.PopBtn.UseVisualStyleBackColor = true;
            this.PopBtn.Click += new System.EventHandler(this.PopBtn_Click);
            // 
            // txtInputData
            // 
            this.txtInputData.Location = new System.Drawing.Point(101, 45);
            this.txtInputData.Name = "txtInputData";
            this.txtInputData.Size = new System.Drawing.Size(177, 20);
            this.txtInputData.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(6, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 18);
            this.label2.TabIndex = 7;
            this.label2.Text = "Input Data";
            // 
            // frmMSMQ
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(305, 144);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtInputData);
            this.Controls.Add(this.PopBtn);
            this.Controls.Add(this.PushBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtMSMQName);
            this.Name = "frmMSMQ";
            this.Text = "Message Queue";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtMSMQName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button PushBtn;
        private System.Windows.Forms.Button PopBtn;
        private System.Windows.Forms.TextBox txtInputData;
        private System.Windows.Forms.Label label2;
    }
}
