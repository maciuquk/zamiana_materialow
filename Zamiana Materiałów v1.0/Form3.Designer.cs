namespace Zamiana_Materiałów_v1._0
{
    partial class Form3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            this.textBoxPodajSredniceP6 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonPrzeliczP6doP = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.labelSrednicaP6doP = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxPodajSredniceP6
            // 
            this.textBoxPodajSredniceP6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxPodajSredniceP6.Location = new System.Drawing.Point(467, 175);
            this.textBoxPodajSredniceP6.Name = "textBoxPodajSredniceP6";
            this.textBoxPodajSredniceP6.Size = new System.Drawing.Size(100, 29);
            this.textBoxPodajSredniceP6.TabIndex = 0;
            this.textBoxPodajSredniceP6.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxPodajSredniceP6_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(457, 135);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(218, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Podaj wymiar pręta 6-kątnego";
            // 
            // buttonPrzeliczP6doP
            // 
            this.buttonPrzeliczP6doP.Location = new System.Drawing.Point(596, 175);
            this.buttonPrzeliczP6doP.Name = "buttonPrzeliczP6doP";
            this.buttonPrzeliczP6doP.Size = new System.Drawing.Size(79, 29);
            this.buttonPrzeliczP6doP.TabIndex = 2;
            this.buttonPrzeliczP6doP.Text = "Przelicz";
            this.buttonPrzeliczP6doP.UseVisualStyleBackColor = true;
            this.buttonPrzeliczP6doP.Click += new System.EventHandler(this.buttonPrzeliczP6doP_Click);
            this.buttonPrzeliczP6doP.KeyDown += new System.Windows.Forms.KeyEventHandler(this.buttonPrzeliczP6doP_KeyDown);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(438, 230);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(262, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Zamiennie można użyć pręt okrągły:";
            this.label2.Visible = false;
            // 
            // labelSrednicaP6doP
            // 
            this.labelSrednicaP6doP.AutoSize = true;
            this.labelSrednicaP6doP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelSrednicaP6doP.Location = new System.Drawing.Point(541, 263);
            this.labelSrednicaP6doP.Name = "labelSrednicaP6doP";
            this.labelSrednicaP6doP.Size = new System.Drawing.Size(0, 20);
            this.labelSrednicaP6doP.TabIndex = 1;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(27, 135);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(353, 140);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.buttonPrzeliczP6doP);
            this.Controls.Add(this.labelSrednicaP6doP);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxPodajSredniceP6);
            this.Name = "Form3";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Zamiana pręta 6k na pręt okrągły";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form3_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxPodajSredniceP6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonPrzeliczP6doP;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelSrednicaP6doP;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}