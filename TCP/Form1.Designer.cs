namespace TCP
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
            this.Adres = new System.Windows.Forms.TextBox();
            this.Port = new System.Windows.Forms.NumericUpDown();
            this.info_o_polaczeniach = new System.Windows.Forms.ListBox();
            this.Polacz = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Port)).BeginInit();
            this.SuspendLayout();
            // 
            // Adres
            // 
            this.Adres.Location = new System.Drawing.Point(23, 23);
            this.Adres.Name = "Adres";
            this.Adres.Size = new System.Drawing.Size(226, 20);
            this.Adres.TabIndex = 0;
            this.Adres.Text = "Adres";
            this.Adres.TextChanged += new System.EventHandler(this.Adres_TextChanged);
            // 
            // Port
            // 
            this.Port.Location = new System.Drawing.Point(282, 22);
            this.Port.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.Port.Name = "Port";
            this.Port.Size = new System.Drawing.Size(210, 20);
            this.Port.TabIndex = 1;
            // 
            // info_o_polaczeniach
            // 
            this.info_o_polaczeniach.FormattingEnabled = true;
            this.info_o_polaczeniach.Location = new System.Drawing.Point(23, 68);
            this.info_o_polaczeniach.Name = "info_o_polaczeniach";
            this.info_o_polaczeniach.Size = new System.Drawing.Size(469, 173);
            this.info_o_polaczeniach.TabIndex = 2;
            // 
            // Polacz
            // 
            this.Polacz.Location = new System.Drawing.Point(174, 257);
            this.Polacz.Name = "Polacz";
            this.Polacz.Size = new System.Drawing.Size(166, 23);
            this.Polacz.TabIndex = 3;
            this.Polacz.Text = "Połącz";
            this.Polacz.UseVisualStyleBackColor = true;
            this.Polacz.Click += new System.EventHandler(this.Polacz_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(529, 292);
            this.Controls.Add(this.Polacz);
            this.Controls.Add(this.info_o_polaczeniach);
            this.Controls.Add(this.Port);
            this.Controls.Add(this.Adres);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.Port)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Adres;
        private System.Windows.Forms.NumericUpDown Port;
        private System.Windows.Forms.ListBox info_o_polaczeniach;
        private System.Windows.Forms.Button Polacz;
    }
}

