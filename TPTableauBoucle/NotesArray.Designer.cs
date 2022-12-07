namespace TPTableauBoucle
{
    partial class NotesArray
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
            this.textBoxNote = new System.Windows.Forms.TextBox();
            this.buttonValid = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.compteurNote = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Saisir les notes :";
            // 
            // textBoxNote
            // 
            this.textBoxNote.Location = new System.Drawing.Point(39, 76);
            this.textBoxNote.Name = "textBoxNote";
            this.textBoxNote.Size = new System.Drawing.Size(125, 27);
            this.textBoxNote.TabIndex = 1;
            // 
            // buttonValid
            // 
            this.buttonValid.Location = new System.Drawing.Point(184, 75);
            this.buttonValid.Name = "buttonValid";
            this.buttonValid.Size = new System.Drawing.Size(42, 29);
            this.buttonValid.TabIndex = 2;
            this.buttonValid.Text = "OK";
            this.buttonValid.UseVisualStyleBackColor = true;
            this.buttonValid.Click += new System.EventHandler(this.buttonValid_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(39, 156);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 29);
            this.button1.TabIndex = 3;
            this.button1.Text = "Calculer";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.buttonCalcul_Click);
            // 
            // compteurNote
            // 
            this.compteurNote.AutoSize = true;
            this.compteurNote.Location = new System.Drawing.Point(41, 110);
            this.compteurNote.Name = "compteurNote";
            this.compteurNote.Size = new System.Drawing.Size(13, 20);
            this.compteurNote.TabIndex = 4;
            this.compteurNote.Text = " ";
            // 
            // NotesArray
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(278, 238);
            this.Controls.Add(this.compteurNote);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.buttonValid);
            this.Controls.Add(this.textBoxNote);
            this.Controls.Add(this.label1);
            this.Name = "NotesArray";
            this.Text = "NotesArray";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private TextBox textBoxNote;
        private Button buttonValid;
        private Button button1;
        private Label compteurNote;
    }
}