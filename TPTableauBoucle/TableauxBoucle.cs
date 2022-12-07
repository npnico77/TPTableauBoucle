namespace TPTableauBoucle
{
    public partial class TableauxBoucle : Form
    {
        public TableauxBoucle()
        {
            InitializeComponent();
        }

        int[] tabEntiers = new int[5];

        //char[] tabVoyelles = new char[6];
        //tabVoyelles = { 'a','e','i','o','u','y'};

        //short syntax :
        char[] tabVoyelles = { 'a', 'e', 'i', 'o', 'u', 'y' };

        int[] tabEntiers2 = { 4, 12, 25, 8, 9, 3 };

        private void buttonSommeFor_Click(object sender, EventArgs e)
        {
            int somme=0;
            for (int i=0; i<tabEntiers2.Length; i++)
            {
                somme += tabEntiers2[i];
            }
            MessageBox.Show("La somme du tableau est de "+somme);
        }

        private void buttonSommeWhile_Click(object sender, EventArgs e)
        {
            int somme = 0;
            int i = 0;
            while (i < tabEntiers2.Length)
            {
                somme += tabEntiers2[i];
                i++;
            }
            MessageBox.Show("La somme du tableau est de " + somme);
        }

        private void buttonSommeDoWhile_Click(object sender, EventArgs e)
        {
            int somme = 0;
            int i = 0;
            do
            {
                somme += tabEntiers2[i];
                i++;
            } while (i < tabEntiers2.Length);
            MessageBox.Show("La somme du tableau est de " + somme);
        }

        private void buttonSommeForeach_Click(object sender, EventArgs e)
        {
            int somme = 0;
            foreach (int i in tabEntiers2)
            {
                somme += i;
            }
            MessageBox.Show("La somme du tableau est de " + somme);
        }

        private void buttonMinimum_Click(object sender, EventArgs e)
        {
            int mini = tabEntiers2[0];
            for (int i = 1; i < tabEntiers2.Length; i++)
            {
                if (tabEntiers2[i] < mini)
                {
                    mini = tabEntiers2[i];
                }
            }
            MessageBox.Show("Le minimum est " + mini);
        }

        private void buttonMaximum_Click(object sender, EventArgs e)
        {
            int maxi = tabEntiers2[0];
            for (int i = 1; i < tabEntiers2.Length; i++)
            {
                if (tabEntiers2[i] > maxi)
                {
                    maxi = tabEntiers2[i];
                }
            }
            MessageBox.Show("Le maximum est " + maxi);
        }

       
    }
}