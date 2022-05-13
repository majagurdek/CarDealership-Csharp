namespace KomisSamochodowy
{
    partial class Wybierz
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
            this.label1 = new System.Windows.Forms.Label();
            this.MarkaCBX = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.ModelCBX = new System.Windows.Forms.ComboBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.KolorCBX = new System.Windows.Forms.ComboBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.SilnikCBX = new System.Windows.Forms.ComboBox();
            this.AddToFav = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(263, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(244, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Wybierz samochód";
            // 
            // MarkaCBX
            // 
            this.MarkaCBX.FormattingEnabled = true;
            this.MarkaCBX.Location = new System.Drawing.Point(199, 3);
            this.MarkaCBX.Name = "MarkaCBX";
            this.MarkaCBX.Size = new System.Drawing.Size(121, 21);
            this.MarkaCBX.TabIndex = 1;
            this.MarkaCBX.SelectedIndexChanged += new System.EventHandler(this.AnyDropdown_SelectedIndexChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.MarkaCBX);
            this.panel1.Location = new System.Drawing.Point(204, 123);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(336, 30);
            this.panel1.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Marka";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.ModelCBX);
            this.panel2.Location = new System.Drawing.Point(204, 187);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(336, 30);
            this.panel2.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Model";
            // 
            // ModelCBX
            // 
            this.ModelCBX.FormattingEnabled = true;
            this.ModelCBX.Location = new System.Drawing.Point(199, 3);
            this.ModelCBX.Name = "ModelCBX";
            this.ModelCBX.Size = new System.Drawing.Size(121, 21);
            this.ModelCBX.TabIndex = 1;
            this.ModelCBX.SelectedIndexChanged += new System.EventHandler(this.AnyDropdown_SelectedIndexChanged);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.KolorCBX);
            this.panel3.Location = new System.Drawing.Point(201, 252);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(339, 30);
            this.panel3.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(4, 10);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Kolor";
            // 
            // KolorCBX
            // 
            this.KolorCBX.FormattingEnabled = true;
            this.KolorCBX.Location = new System.Drawing.Point(199, 3);
            this.KolorCBX.Name = "KolorCBX";
            this.KolorCBX.Size = new System.Drawing.Size(121, 21);
            this.KolorCBX.TabIndex = 1;
            this.KolorCBX.SelectedIndexChanged += new System.EventHandler(this.AnyDropdown_SelectedIndexChanged);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.label5);
            this.panel4.Controls.Add(this.SilnikCBX);
            this.panel4.Location = new System.Drawing.Point(201, 318);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(339, 30);
            this.panel4.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(4, 10);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Silnik";
            // 
            // SilnikCBX
            // 
            this.SilnikCBX.FormattingEnabled = true;
            this.SilnikCBX.Location = new System.Drawing.Point(199, 3);
            this.SilnikCBX.Name = "SilnikCBX";
            this.SilnikCBX.Size = new System.Drawing.Size(121, 21);
            this.SilnikCBX.TabIndex = 1;
            this.SilnikCBX.SelectedIndexChanged += new System.EventHandler(this.AnyDropdown_SelectedIndexChanged);
            // 
            // AddToFav
            // 
            this.AddToFav.Location = new System.Drawing.Point(312, 389);
            this.AddToFav.Name = "AddToFav";
            this.AddToFav.Size = new System.Drawing.Size(157, 23);
            this.AddToFav.TabIndex = 4;
            this.AddToFav.Text = "Dodaj do ulubionych";
            this.AddToFav.UseVisualStyleBackColor = true;
            this.AddToFav.Click += new System.EventHandler(this.AddToFav_Click);
            // 
            // Wybierz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.AddToFav);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Name = "Wybierz";
            this.Text = "Wybierz";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox MarkaCBX;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox ModelCBX;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox KolorCBX;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox SilnikCBX;
        private System.Windows.Forms.Button AddToFav;
    }
}