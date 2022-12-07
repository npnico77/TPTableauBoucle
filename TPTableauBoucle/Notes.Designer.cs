namespace TPTableauBoucle
{
    partial class Notes
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
            this.textBoxNbreNote = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonValidNbreNote = new System.Windows.Forms.Button();
            this.labelSaisie = new System.Windows.Forms.Label();
            this.textBoxNote = new System.Windows.Forms.TextBox();
            this.buttonValidNote = new System.Windows.Forms.Button();
            this.confirmation = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBoxNbreNote
            // 
            this.textBoxNbreNote.Location = new System.Drawing.Point(26, 75);
            this.textBoxNbreNote.Name = "textBoxNbreNote";
            this.textBoxNbreNote.Size = new System.Drawing.Size(125, 27);
            this.textBoxNbreNote.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(190, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Combien de notes à saisir ?";
            // 
            // buttonValidNbreNote
            // 
            this.buttonValidNbreNote.Location = new System.Drawing.Point(169, 75);
            this.buttonValidNbreNote.Name = "buttonValidNbreNote";
            this.buttonValidNbreNote.Size = new System.Drawing.Size(47, 29);
            this.buttonValidNbreNote.TabIndex = 2;
            this.buttonValidNbreNote.Text = "OK";
            this.buttonValidNbreNote.UseVisualStyleBackColor = true;
            this.buttonValidNbreNote.Click += new System.EventHandler(this.buttonValidNbre_Click);
            // 
            // labelSaisie
            // 
            this.labelSaisie.AutoSize = true;
            this.labelSaisie.Location = new System.Drawing.Point(26, 128);
            this.labelSaisie.Name = "labelSaisie";
            this.labelSaisie.Size = new System.Drawing.Size(113, 20);
            this.labelSaisie.TabIndex = 3;
            this.labelSaisie.Text = "Saisir les notes :";
            this.labelSaisie.Visible = false;
            // 
            // textBoxNote
            // 
            this.textBoxNote.Location = new System.Drawing.Point(26, 160);
            this.textBoxNote.Name = "textBoxNote";
            this.textBoxNote.Size = new System.Drawing.Size(125, 27);
            this.textBoxNote.TabIndex = 4;
            this.textBoxNote.Visible = false;
            // 
            // buttonValidNote
            // 
            this.buttonValidNote.Location = new System.Drawing.Point(169, 158);
            this.buttonValidNote.Name = "buttonValidNote";
            this.buttonValidNote.Size = new System.Drawing.Size(47, 29);
            this.buttonValidNote.TabIndex = 5;
            this.buttonValidNote.Text = "OK";
            this.buttonValidNote.UseVisualStyleBackColor = true;
            this.buttonValidNote.Visible = false;
            this.buttonValidNote.Click += new System.EventHandler(this.buttonValidNote_Click);
            // 
            // confirmation
            // 
            this.confirmation.AutoSize = true;
            this.confirmation.Location = new System.Drawing.Point(31, 201);
            this.confirmation.Name = "confirmation";
            this.confirmation.Size = new System.Drawing.Size(13, 20);
            this.confirmation.TabIndex = 6;
            this.confirmation.Text = " ";
            // 
            // Notes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(267, 304);
            this.Controls.Add(this.confirmation);
            this.Controls.Add(this.buttonValidNote);
            this.Controls.Add(this.textBoxNote);
            this.Controls.Add(this.labelSaisie);
            this.Controls.Add(this.buttonValidNbreNote);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxNbreNote);
            this.Name = "Notes";
            this.Text = "Notes";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox textBoxNbreNote;
        private Label label1;
        private Button buttonValidNbreNote;
        private Label labelSaisie;
        private TextBox textBoxNote;
        private Button buttonValidNote;
        private Label confirmation;
    }
}