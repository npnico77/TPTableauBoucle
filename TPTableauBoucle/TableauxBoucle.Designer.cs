namespace TPTableauBoucle
{
    partial class TableauxBoucle
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
            this.buttonSomme = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonSomme
            // 
            this.buttonSomme.Location = new System.Drawing.Point(22, 22);
            this.buttonSomme.Name = "buttonSomme";
            this.buttonSomme.Size = new System.Drawing.Size(232, 29);
            this.buttonSomme.TabIndex = 0;
            this.buttonSomme.Text = "Somme des entiers boucle For";
            this.buttonSomme.UseVisualStyleBackColor = true;
            this.buttonSomme.Click += new System.EventHandler(this.buttonSommeFor_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(22, 71);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(257, 29);
            this.button1.TabIndex = 1;
            this.button1.Text = "Somme des entiers boucle While";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.buttonSommeWhile_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(22, 124);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(269, 29);
            this.button2.TabIndex = 2;
            this.button2.Text = "Somme des entiers boucle DoWhile";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.buttonSommeDoWhile_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(22, 174);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(269, 29);
            this.button3.TabIndex = 3;
            this.button3.Text = "Somme des entiers boucle Foreach";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.buttonSommeForeach_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(22, 227);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(155, 29);
            this.button4.TabIndex = 4;
            this.button4.Text = "Trouver le minimum";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.buttonMinimum_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(22, 276);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(155, 29);
            this.button5.TabIndex = 5;
            this.button5.Text = "Trouver le maximum";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.buttonMaximum_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.buttonSomme);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private Button buttonSomme;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
    }
}