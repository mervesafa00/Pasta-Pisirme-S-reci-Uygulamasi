namespace Pasta_Pişirme_Süreci_Uygulaması
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            progressBar1 = new ProgressBar();
            progressBar2 = new ProgressBar();
            progressBar3 = new ProgressBar();
            progressBar4 = new ProgressBar();
            timer1 = new System.Windows.Forms.Timer(components);
            timer2 = new System.Windows.Forms.Timer(components);
            timer3 = new System.Windows.Forms.Timer(components);
            timer4 = new System.Windows.Forms.Timer(components);
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ButtonHighlight;
            label1.Font = new Font("Segoe UI Semibold", 24F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label1.Location = new Point(12, 19);
            label1.Name = "label1";
            label1.Size = new Size(438, 45);
            label1.TabIndex = 0;
            label1.Text = "Un ve yumurta karıştırılıyor...";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.ButtonHighlight;
            label2.Font = new Font("Segoe UI Semibold", 24F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label2.Location = new Point(12, 109);
            label2.Name = "label2";
            label2.Size = new Size(369, 45);
            label2.TabIndex = 1;
            label2.Text = "Çırpma işlemi yapılıyor...";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = SystemColors.ButtonHighlight;
            label3.Font = new Font("Segoe UI Semibold", 24F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label3.Location = new Point(12, 223);
            label3.Name = "label3";
            label3.Size = new Size(574, 45);
            label3.TabIndex = 2;
            label3.Text = "Malzemeler ekleniyor ve karıştırılıyor...";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = SystemColors.ButtonHighlight;
            label4.Font = new Font("Segoe UI Semibold", 24F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label4.Location = new Point(12, 333);
            label4.Name = "label4";
            label4.Size = new Size(260, 45);
            label4.TabIndex = 3;
            label4.Text = "Pasta pişiriliyor...";
            // 
            // progressBar1
            // 
            progressBar1.Location = new Point(12, 67);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(468, 39);
            progressBar1.TabIndex = 4;
            // 
            // progressBar2
            // 
            progressBar2.Location = new Point(12, 166);
            progressBar2.Name = "progressBar2";
            progressBar2.Size = new Size(468, 39);
            progressBar2.TabIndex = 5;
            // 
            // progressBar3
            // 
            progressBar3.Location = new Point(12, 277);
            progressBar3.Name = "progressBar3";
            progressBar3.Size = new Size(468, 39);
            progressBar3.TabIndex = 6;
            // 
            // progressBar4
            // 
            progressBar4.Location = new Point(12, 396);
            progressBar4.Name = "progressBar4";
            progressBar4.Size = new Size(468, 42);
            progressBar4.TabIndex = 7;
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Interval = 1000;
            timer1.Tick += timer1_Tick;
            // 
            // timer2
            // 
            timer2.Interval = 1000;
            timer2.Tick += timer2_Tick;
            // 
            // timer3
            // 
            timer3.Interval = 1000;
            timer3.Tick += timer3_Tick;
            // 
            // timer4
            // 
            timer4.Interval = 1000;
            timer4.Tick += timer4_Tick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(800, 450);
            Controls.Add(progressBar4);
            Controls.Add(progressBar3);
            Controls.Add(progressBar2);
            Controls.Add(progressBar1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private ProgressBar progressBar1;
        private ProgressBar progressBar2;
        private ProgressBar progressBar3;
        private ProgressBar progressBar4;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Timer timer3;
        private System.Windows.Forms.Timer timer4;
    }
}
