namespace KomisSamochodowy
{
    partial class MainMenu
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.PickACar = new System.Windows.Forms.Button();
            this.AddCar = new System.Windows.Forms.Button();
            this.BookACar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(230, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(345, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "Komis Samochodowy";
            // 
            // PickACar
            // 
            this.PickACar.Location = new System.Drawing.Point(252, 122);
            this.PickACar.Name = "PickACar";
            this.PickACar.Size = new System.Drawing.Size(300, 66);
            this.PickACar.TabIndex = 1;
            this.PickACar.Text = "Wybierz samochód";
            this.PickACar.UseVisualStyleBackColor = true;
            this.PickACar.Click += new System.EventHandler(this.PickACar_Click);
            // 
            // AddCar
            // 
            this.AddCar.Location = new System.Drawing.Point(252, 212);
            this.AddCar.Name = "AddCar";
            this.AddCar.Size = new System.Drawing.Size(300, 66);
            this.AddCar.TabIndex = 2;
            this.AddCar.Text = "Dodaj nowy samochód do komisu";
            this.AddCar.UseVisualStyleBackColor = true;
            this.AddCar.Click += new System.EventHandler(this.AddACar_Click);
            // 
            // BookACar
            // 
            this.BookACar.Location = new System.Drawing.Point(252, 314);
            this.BookACar.Name = "BookACar";
            this.BookACar.Size = new System.Drawing.Size(300, 66);
            this.BookACar.TabIndex = 3;
            this.BookACar.Text = "Zarezerwuj termin na jazdą próbną";
            this.BookACar.UseVisualStyleBackColor = true;
            this.BookACar.Click += new System.EventHandler(this.BookACar_Click);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BookACar);
            this.Controls.Add(this.AddCar);
            this.Controls.Add(this.PickACar);
            this.Controls.Add(this.label1);
            this.Name = "MainMenu";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button PickACar;
        private System.Windows.Forms.Button AddCar;
        private System.Windows.Forms.Button BookACar;
    }
}

