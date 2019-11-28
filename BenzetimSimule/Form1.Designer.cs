namespace BenzetimSimule
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea5 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend5 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.Sistem = new System.Windows.Forms.Timer(this.components);
            this.Hesap = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SisOrtBekSuresi = new System.Windows.Forms.Label();
            this.SisOrtKisi = new System.Windows.Forms.Label();
            this.kuyruktakiOrtElemanSayisi = new System.Windows.Forms.Label();
            this.OrtalamaKuyruk = new System.Windows.Forms.Label();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // chart1
            // 
            chartArea5.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea5);
            legend5.Name = "Legend1";
            this.chart1.Legends.Add(legend5);
            this.chart1.Location = new System.Drawing.Point(16, 15);
            this.chart1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.chart1.Name = "chart1";
            series5.ChartArea = "ChartArea1";
            series5.Legend = "Legend1";
            series5.Name = "Series1";
            this.chart1.Series.Add(series5);
            this.chart1.Size = new System.Drawing.Size(1035, 396);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            // 
            // Sistem
            // 
            this.Sistem.Interval = 1000;
            this.Sistem.Tick += new System.EventHandler(this.Sistem_Tick_1);
            // 
            // Hesap
            // 
            this.Hesap.Interval = 1000;
            this.Hesap.Tick += new System.EventHandler(this.Hesap_Tick_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 415);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(228, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Kuyrukta Ortalama Bekleme Suresi";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 444);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(217, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Kuyrukta Ortamala Musterı Sayısı";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 500);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(240, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Sistemdeki Ortalama Bekleme Suresi";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 473);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(205, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Sistemdeki Ortalama Kişi Sayısı";
            // 
            // SisOrtBekSuresi
            // 
            this.SisOrtBekSuresi.AutoSize = true;
            this.SisOrtBekSuresi.Location = new System.Drawing.Point(297, 500);
            this.SisOrtBekSuresi.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.SisOrtBekSuresi.Name = "SisOrtBekSuresi";
            this.SisOrtBekSuresi.Size = new System.Drawing.Size(0, 17);
            this.SisOrtBekSuresi.TabIndex = 8;
            // 
            // SisOrtKisi
            // 
            this.SisOrtKisi.AutoSize = true;
            this.SisOrtKisi.Location = new System.Drawing.Point(297, 473);
            this.SisOrtKisi.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.SisOrtKisi.Name = "SisOrtKisi";
            this.SisOrtKisi.Size = new System.Drawing.Size(0, 17);
            this.SisOrtKisi.TabIndex = 7;
            // 
            // kuyruktakiOrtElemanSayisi
            // 
            this.kuyruktakiOrtElemanSayisi.AutoSize = true;
            this.kuyruktakiOrtElemanSayisi.Location = new System.Drawing.Point(297, 444);
            this.kuyruktakiOrtElemanSayisi.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.kuyruktakiOrtElemanSayisi.Name = "kuyruktakiOrtElemanSayisi";
            this.kuyruktakiOrtElemanSayisi.Size = new System.Drawing.Size(0, 17);
            this.kuyruktakiOrtElemanSayisi.TabIndex = 6;
            // 
            // OrtalamaKuyruk
            // 
            this.OrtalamaKuyruk.AutoSize = true;
            this.OrtalamaKuyruk.Location = new System.Drawing.Point(297, 415);
            this.OrtalamaKuyruk.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.OrtalamaKuyruk.Name = "OrtalamaKuyruk";
            this.OrtalamaKuyruk.Size = new System.Drawing.Size(0, 17);
            this.OrtalamaKuyruk.TabIndex = 5;
            // 
            // timer2
            // 
            this.timer2.Enabled = true;
            this.timer2.Interval = 2000;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 615);
            this.Controls.Add(this.SisOrtBekSuresi);
            this.Controls.Add(this.SisOrtKisi);
            this.Controls.Add(this.kuyruktakiOrtElemanSayisi);
            this.Controls.Add(this.OrtalamaKuyruk);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.chart1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Timer Sistem;
        private System.Windows.Forms.Timer Hesap;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label SisOrtBekSuresi;
        private System.Windows.Forms.Label SisOrtKisi;
        private System.Windows.Forms.Label kuyruktakiOrtElemanSayisi;
        private System.Windows.Forms.Label OrtalamaKuyruk;
        private System.Windows.Forms.Timer timer2;
    }
}

