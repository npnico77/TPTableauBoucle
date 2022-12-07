using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TPTableauBoucle
{
    public partial class NotesArray : Form
    {
        public NotesArray()
        {
            InitializeComponent();
        }
        // Exo 3

        // 1. Écrire un algo qui permet de saisir les notes d’un élève pour en calculer la moyenne (Attention au contrôle de saisie)
        // On commence par demander à l’utilisateur combien de notes il souhaite saisir.
        // Une fois toutes les notes saisies, on calcule et affiche la moyenne

        // 2. Compléter l’algorithme précédent en affichant la note maxi et la note mini de l'élève

        // 3. Modifier l’algorithme précédent en supprimant l’étape “demander à l’utilisateur combien de notes il souhaite saisir” 
        // La saisie des notes sera possible tant que l’utilisateur ne clic pas sur le bouton “Calculer” 
        // En plus de la moyenne et des notes min et max, il faudra afficher combien de notes ont été saisies

        ArrayList tableauNotes = new ArrayList();
        double moyenne=0;
        double noteMax;
        double noteMin;
        int compteur = 1;
        private void buttonValid_Click(object sender, EventArgs e)
        {
            string input = textBoxNote.Text;
            double note;
            bool convertResult = double.TryParse(input, out note);

            if (convertResult)
            {
                tableauNotes.Add(note);
                compteurNote.Text = "Note " + compteur + " saisie";
                textBoxNote.Text = "";
                compteur++;
            }
            else
            {
                MessageBox.Show("Saisie incorrecte");
            }
        }

        private void buttonCalcul_Click(object sender, EventArgs e)
        {
            for (int i = 0;i<tableauNotes.Count;i++)
            {
                double noteTableau = Convert.ToDouble(tableauNotes[i]);
                moyenne += noteTableau;
                if (i == 0)
                {
                    noteMin = noteTableau;
                    noteMax = noteTableau;
                }
                else if (noteTableau < noteMin)
                {
                    noteMin = noteTableau;
                }
                else if (noteTableau > noteMax)
                {
                    noteMax = noteTableau;
                }
            }
            moyenne = moyenne / tableauNotes.Count;
            MessageBox.Show("La moyenne est de " + moyenne + "\nNote minimum : " + noteMin + "\nNote maximum : " + noteMax);
            compteurNote.Text = "";
            compteur = 1; 
            tableauNotes.Clear();
            moyenne=0;
        }
    }
}
