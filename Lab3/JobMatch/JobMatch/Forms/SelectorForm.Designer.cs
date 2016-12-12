namespace JobMatch
{
    partial class SelectorForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.no_btn = new System.Windows.Forms.Button();
            this.yes_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(540, 610);
            this.panel1.TabIndex = 0;
            // 
            // no_btn
            // 
            this.no_btn.Location = new System.Drawing.Point(35, 625);
            this.no_btn.Name = "no_btn";
            this.no_btn.Size = new System.Drawing.Size(110, 25);
            this.no_btn.TabIndex = 1;
            this.no_btn.Text = "No";
            this.no_btn.UseVisualStyleBackColor = true;
            this.no_btn.Click += new System.EventHandler(this.no_btn_Click);
            // 
            // yes_btn
            // 
            this.yes_btn.Location = new System.Drawing.Point(400, 625);
            this.yes_btn.Name = "yes_btn";
            this.yes_btn.Size = new System.Drawing.Size(110, 25);
            this.yes_btn.TabIndex = 2;
            this.yes_btn.Text = "Yes";
            this.yes_btn.UseVisualStyleBackColor = true;
            this.yes_btn.Click += new System.EventHandler(this.yes_btn_Click);
            // 
            // SelectorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(540, 671);
            this.Controls.Add(this.yes_btn);
            this.Controls.Add(this.no_btn);
            this.Controls.Add(this.panel1);
            this.Name = "SelectorForm";
            this.Text = "SelectorForm";
            this.Load += new System.EventHandler(this.SelectorForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button no_btn;
        private System.Windows.Forms.Button yes_btn;
    }
}