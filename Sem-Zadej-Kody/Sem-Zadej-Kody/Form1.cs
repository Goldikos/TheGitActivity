using System.Security.Cryptography;
using System.Text;

namespace Sem_Zadej_Kody
{
    public partial class Form1 : Form
    {
        string[] kody = { "D35A4E1ADF829AF5131BB32B150702B0E9E02A23B7A75E78CF025F8281A81D2B", "" };
        Label[] labels = new Label[4];
        int pocetKodu;
        public Form1()
        {
            InitializeComponent();
            pocetKodu = 0;
            for (int i = 0; i < labels.Length; i++)
            {
                Label novy = new Label();
                novy.Text = String.Format((i + 1).ToString() + ". Kód");
                novy.Location = new Point(260, 40 * i + 20);
                novy.Font = new Font("Segue UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
                novy.ForeColor = Color.DarkRed;
                labels[i] = novy;
                this.Controls.Add(labels[i]);
            }
        }

        private void buttonSifrovat_Click(object sender, EventArgs e)
        {
            using (SHA256 sifrovac = SHA256.Create())
            {
                byte[] data = sifrovac.ComputeHash(Encoding.UTF8.GetBytes(textBoxKody.Text));
                string hashovano = BitConverter.ToString(data);
                hashovano = hashovano.Replace("-", "");
                textBoxKody.Text = hashovano;
                for (int i = 0; i < kody.Length; i++)
                {
                    if (kody[i] == hashovano)
                    {
                        labels[i].ForeColor = Color.Green;
                        pocetKodu++;
                        if (pocetKodu == labels.Length)
                        {
                            MessageBox.Show("Vyhrál jsi.");
                            this.Close();
                        }
                    }
                }
            }
        }
    }
}