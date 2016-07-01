namespace LenghtconverWFA
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
            this.BoxTo = new System.Windows.Forms.ComboBox();
            this.BtnConver = new System.Windows.Forms.Button();
            this.Lblto = new System.Windows.Forms.Label();
            this.BoxFrom = new System.Windows.Forms.TextBox();
            this.LblFrom = new System.Windows.Forms.Label();
            this.lblresult = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BoxTo
            // 
            this.BoxTo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.BoxTo.FormattingEnabled = true;
            this.BoxTo.Location = new System.Drawing.Point(13, 41);
            this.BoxTo.Name = "BoxTo";
            this.BoxTo.Size = new System.Drawing.Size(121, 21);
            this.BoxTo.TabIndex = 0;
            this.BoxTo.SelectedIndexChanged += new System.EventHandler(this.BoxTo_SelectedIndexChanged);
            // 
            // BtnConver
            // 
            this.BtnConver.Location = new System.Drawing.Point(178, 227);
            this.BtnConver.Name = "BtnConver";
            this.BtnConver.Size = new System.Drawing.Size(75, 23);
            this.BtnConver.TabIndex = 1;
            this.BtnConver.Text = "Convert";
            this.BtnConver.UseVisualStyleBackColor = true;
            this.BtnConver.Click += new System.EventHandler(this.BtnConver_Click);
            // 
            // Lblto
            // 
            this.Lblto.AutoSize = true;
            this.Lblto.Location = new System.Drawing.Point(13, 13);
            this.Lblto.Name = "Lblto";
            this.Lblto.Size = new System.Drawing.Size(56, 13);
            this.Lblto.TabIndex = 2;
            this.Lblto.Text = "Convert to";
            // 
            // BoxFrom
            // 
            this.BoxFrom.Location = new System.Drawing.Point(16, 94);
            this.BoxFrom.Name = "BoxFrom";
            this.BoxFrom.Size = new System.Drawing.Size(100, 20);
            this.BoxFrom.TabIndex = 3;
            this.BoxFrom.TextChanged += new System.EventHandler(this.BoxFrom_TextChanged);
            this.BoxFrom.MouseHover += new System.EventHandler(this.BoxFrom_MouseHover);
            // 
            // LblFrom
            // 
            this.LblFrom.AutoSize = true;
            this.LblFrom.Location = new System.Drawing.Point(16, 75);
            this.LblFrom.Name = "LblFrom";
            this.LblFrom.Size = new System.Drawing.Size(79, 13);
            this.LblFrom.TabIndex = 4;
            this.LblFrom.Text = "Convert Inches";
            // 
            // lblresult
            // 
            this.lblresult.AutoSize = true;
            this.lblresult.Location = new System.Drawing.Point(19, 198);
            this.lblresult.Name = "lblresult";
            this.lblresult.Size = new System.Drawing.Size(0, 13);
            this.lblresult.TabIndex = 5;
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(197, 22);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 6;
            this.btnExit.Text = "exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RoyalBlue;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.lblresult);
            this.Controls.Add(this.LblFrom);
            this.Controls.Add(this.BoxFrom);
            this.Controls.Add(this.Lblto);
            this.Controls.Add(this.BtnConver);
            this.Controls.Add(this.BoxTo);
            this.Name = "Form1";
            this.Text = "Unit Converter";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox BoxTo;
        private System.Windows.Forms.Button BtnConver;
        private System.Windows.Forms.Label Lblto;
        private System.Windows.Forms.TextBox BoxFrom;
        private System.Windows.Forms.Label LblFrom;
        private System.Windows.Forms.Label lblresult;
        private System.Windows.Forms.Button btnExit;
    }
}