using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace TPTableauBoucle
{
    public partial class Notes : Form
    {
        public Notes()
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

        
        int nbre=0;
        int i;
        double moyenne;
        double noteMax;
        double noteMin;
        private void buttonValidNbre_Click(object sender, EventArgs e)
        {
            string input = textBoxNbreNote.Text;
            bool convertResult = int.TryParse(input, out nbre);

            if (convertResult)
            {
                labelSaisie.Text = "Saisir les " + nbre + " notes :";
                labelSaisie.Visible = true;
                textBoxNote.Visible= true;
                buttonValidNote.Visible= true;
                moyenne = 0;
                i = 0;
                confirmation.Text = "";
            }
            else
            {
                MessageBox.Show("Saisie incorrecte");
            }
        }

        private void buttonValidNote_Click(object sender, EventArgs e)
        {
            string input = textBoxNote.Text;
            double note;
            bool convertResult = double.TryParse(input, out note);

            if (convertResult && i<=nbre)
            {
                moyenne += note;
                if (i == 1)
                {
                    noteMin = note;
                    noteMax = note; 
                }
                else if (note<noteMin)
                {
                    noteMin= note;
                }else if (note>noteMax)
                {
                    noteMax= note;
                }
                i++;
                textBoxNote.Text = "";
                confirmation.Text = "Note " +(i)+" saisie";
            }
            else
            {
                MessageBox.Show("Saisie incorrecte");
            }

            if (i==nbre)
            {
                moyenne = moyenne / nbre;
                MessageBox.Show("La moyenne est de "+moyenne+"\nNote minimum : "+noteMin+"\nNote maximum : "+noteMax);
            }
        }
    }
}
