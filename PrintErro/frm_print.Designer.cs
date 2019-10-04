namespace PrintErro
{
    partial class frm_print
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
            this.btPrint = new System.Windows.Forms.Button();
            this.lbObs = new System.Windows.Forms.Label();
            this.tbObsv = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btPrint
            // 
            this.btPrint.Dock = System.Windows.Forms.DockStyle.Top;
            this.btPrint.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btPrint.Location = new System.Drawing.Point(0, 0);
            this.btPrint.Name = "btPrint";
            this.btPrint.Size = new System.Drawing.Size(318, 37);
            this.btPrint.TabIndex = 0;
            this.btPrint.Text = "Print Erro";
            this.btPrint.UseVisualStyleBackColor = true;
            this.btPrint.Click += new System.EventHandler(this.btPrint_Click);
            // 
            // lbObs
            // 
            this.lbObs.AutoSize = true;
            this.lbObs.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbObs.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbObs.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbObs.Location = new System.Drawing.Point(12, 46);
            this.lbObs.Name = "lbObs";
            this.lbObs.Size = new System.Drawing.Size(33, 13);
            this.lbObs.TabIndex = 1;
            this.lbObs.Text = "Obs:";
            this.lbObs.DoubleClick += new System.EventHandler(this.lbObs_DoubleClick);
            // 
            // tbObsv
            // 
            this.tbObsv.Location = new System.Drawing.Point(52, 43);
            this.tbObsv.Name = "tbObsv";
            this.tbObsv.Size = new System.Drawing.Size(254, 20);
            this.tbObsv.TabIndex = 2;
            this.tbObsv.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbObsv_KeyPress);
            // 
            // frm_print
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(318, 75);
            this.Controls.Add(this.tbObsv);
            this.Controls.Add(this.lbObs);
            this.Controls.Add(this.btPrint);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frm_print";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Resize += new System.EventHandler(this.frm_print_Resize);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btPrint;
        private System.Windows.Forms.Label lbObs;
        private System.Windows.Forms.TextBox tbObsv;
    }
}

