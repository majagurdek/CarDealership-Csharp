namespace KomisSamochodowy
{
    partial class Dodawanie
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Marka_textbox = new System.Windows.Forms.TextBox();
            this.model_textbox = new System.Windows.Forms.TextBox();
            this.silnik_textbox = new System.Windows.Forms.TextBox();
            this.kolor_textbox = new System.Windows.Forms.TextBox();
            this.buttonDodaj = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(225, 333);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(255, 35);
            this.button1.TabIndex = 0;
            this.button1.Text = "Zresetuj dane";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.zresetuj);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(225, 374);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(255, 35);
            this.button2.TabIndex = 1;
            this.button2.Text = "Zrezygnuj z dodawania samochodu";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.zakończ);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(167, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(396, 30);
            this.label1.TabIndex = 2;
            this.label1.Text = "Dodaj nowy samochód do komisu";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(169, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 18);
            this.label2.TabIndex = 3;
            this.label2.Text = "Wprowadź markę :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(169, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(133, 18);
            this.label3.TabIndex = 4;
            this.label3.Text = "Wprowadź model :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(146, 178);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(178, 18);
            this.label4.TabIndex = 5;
            this.label4.Text = "Wprowadź rodzaj silnika :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(169, 228);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(126, 18);
            this.label5.TabIndex = 6;
            this.label5.Text = "Wprowadż kolor :\r\n";
            // 
            // Marka_textbox
            // 
            this.Marka_textbox.Location = new System.Drawing.Point(336, 77);
            this.Marka_textbox.Name = "Marka_textbox";
            this.Marka_textbox.Size = new System.Drawing.Size(213, 20);
            this.Marka_textbox.TabIndex = 7;
            // 
            // model_textbox
            // 
            this.model_textbox.Location = new System.Drawing.Point(336, 127);
            this.model_textbox.Name = "model_textbox";
            this.model_textbox.Size = new System.Drawing.Size(213, 20);
            this.model_textbox.TabIndex = 8;
            // 
            // silnik_textbox
            // 
            this.silnik_textbox.Location = new System.Drawing.Point(336, 179);
            this.silnik_textbox.Name = "silnik_textbox";
            this.silnik_textbox.Size = new System.Drawing.Size(213, 20);
            this.silnik_textbox.TabIndex = 9;
            // 
            // kolor_textbox
            // 
            this.kolor_textbox.Location = new System.Drawing.Point(336, 229);
            this.kolor_textbox.Name = "kolor_textbox";
            this.kolor_textbox.Size = new System.Drawing.Size(213, 20);
            this.kolor_textbox.TabIndex = 10;
            // 
            // buttonDodaj
            // 
            this.buttonDodaj.Location = new System.Drawing.Point(225, 292);
            this.buttonDodaj.Name = "buttonDodaj";
            this.buttonDodaj.Size = new System.Drawing.Size(255, 35);
            this.buttonDodaj.TabIndex = 11;
            this.buttonDodaj.Text = "Dodaj";
            this.buttonDodaj.UseVisualStyleBackColor = true;
            this.buttonDodaj.Click += new System.EventHandler(this.dodaj);
            // 
            // Dodawanie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(714, 421);
            this.Controls.Add(this.buttonDodaj);
            this.Controls.Add(this.kolor_textbox);
            this.Controls.Add(this.silnik_textbox);
            this.Controls.Add(this.model_textbox);
            this.Controls.Add(this.Marka_textbox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Dodawanie";
            this.Text = "Dodaj samochód";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Dodawanie_FormClosed);
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox Marka_textbox;
        private System.Windows.Forms.TextBox model_textbox;
        private System.Windows.Forms.TextBox silnik_textbox;
        private System.Windows.Forms.TextBox kolor_textbox;
        private System.Windows.Forms.Button buttonDodaj;
    }
}