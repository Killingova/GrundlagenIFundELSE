using System;
using System.Windows.Forms;

namespace GrundlagenIFundELSE
{
    public partial class IFundElse : Form
    {
        public IFundElse()
        {
            InitializeComponent();
        }

        // Wird aufgerufen, wenn der "Anzeigen" Button geklickt wird.
        private void CmdAnzeigen_Click(object sender, EventArgs e)
        {
            // Zeigt den aktuellen Text der TxtEingabe TextBox im LblAnzeige Label an.
            LblAnzeige.Text = TxtEingabe.Text;
        }

        // Wird aufgerufen, wenn der "Rechnen" Button geklickt wird.
        private void CmdRechnen_Click(object sender, EventArgs e)
        {
            // Versucht, den Text der TxtEingabe TextBox in einen double-Wert zu konvertieren.
            if (double.TryParse(TxtEingabe.Text, out double wert))
            {
                // Verdoppelt den Wert und zeigt das Ergebnis im LblAnzeige Label an.
                LblAnzeige.Text = $"Ergebnis: {wert * 2}";
            }
            else
            {
                // Zeigt eine Fehlermeldung an, wenn die Eingabe kein gültiger double-Wert ist.
                LblAnzeige.Text = "Bitte geben Sie eine gültige Zahl ein.";
            }
        }

        // Wird aufgerufen, wenn der "Ergebnis" Button geklickt wird.
        private void CmdErgebnis_Click(object sender, EventArgs e)
        {
            // Versucht, den Text der TxtEingabe TextBox in einen double-Wert zu konvertieren.
            if (double.TryParse(TxtEingabe.Text, out double wert))
            {
                // Überprüft, ob der Wert größer als ein Schwellenwert ist.
                if (wert > 100)
                {
                    // Wenn der Wert größer als 100 ist, zeige eine entsprechende Nachricht an.
                    LblAnzeige.Text = "Der Wert ist größer als 100!";
                    LblAnzeige.ForeColor = Color.Red;
                }
                else
                {
                    // Wenn der Wert kleiner oder gleich 100 ist, zeige eine andere Nachricht.
                    LblAnzeige.Text = "Der Wert ist 100 oder weniger.";
                    LblAnzeige.ForeColor= Color.Blue;
                }
            }
            else
            {
                // Zeigt eine Fehlermeldung an, wenn die Eingabe kein gültiger double-Wert ist.
                LblAnzeige.Text = "Bitte geben Sie eine gültige Zahl ein.";
            }
        }


        // Wird aufgerufen, wenn der Wert des NumEingabe Steuerelements sich ändert.
        private void NumEingabe_ValueChanged(object sender, EventArgs e)
        {
            // Aktualisiert die TxtEingabe TextBox mit dem neuen Wert des NumEingabe Steuerelements.
            TxtEingabe.Text = NumEingabe.Value.ToString();
        }

        // Wird aufgerufen, wenn der Text der TxtEingabe TextBox sich ändert.
        private void TxtEingabe_TextChanged(object sender, EventArgs e)
        {
            // Diese Methode könnte zum Beispiel genutzt werden, um Validierungen in Echtzeit durchzuführen,
            // während der Benutzer Text eingibt.
        }

        // Wird aufgerufen, wenn auf das LblAnzeige Label geklickt wird.
        private void LblAnzeige_Click(object sender, EventArgs e)
        {
            // Diese Methode könnte zum Beispiel genutzt werden, um weitere Informationen anzuzeigen,
            // oder eine Aktion auszuführen, wenn auf das Label geklickt wird.
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
