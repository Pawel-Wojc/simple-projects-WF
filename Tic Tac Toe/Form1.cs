namespace projekt2kolkokrzyzyk
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        bool gracz1 = true;
        int ruch = 0;
        private void button_reset_Click(object sender, EventArgs e)
        {
            Restartuj();
            wynik_o.Text = "0";
            wynik_x.Text = "0";
            labelKto.Text = "0";
            gracz1 = true;
        }

        private void Restartuj()
        {
            ruch = 0;
            Button[] wszystkie = new Button[9];
            wszystkie[0] = button1;
            wszystkie[1] = button2;
            wszystkie[2] = button3;
            wszystkie[3] = button4;
            wszystkie[4] = button5;
            wszystkie[5] = button6;
            wszystkie[6] = button7;
            wszystkie[7] = button8;
            wszystkie[8] = button9;
            foreach (Button b in wszystkie)
            {
                b.Enabled = true;
                b.Text = "";

            }
        }
        private void Sprawdz()
        {
            if (button1.Text != "" && button1.Text == button2.Text && button2.Text == button3.Text) {
                Wygrana();
            } else if (button4.Text != "" && button4.Text == button5.Text && button5.Text == button6.Text) {
                Wygrana();
            } else if (button7.Text != "" && button7.Text == button8.Text && button8.Text == button9.Text) {
                Wygrana();
            } else if (button1.Text != "" && button1.Text == button4.Text && button4.Text == button7.Text) {
                Wygrana();
            } else if (button2.Text != "" && button2.Text == button5.Text && button5.Text == button8.Text) {
                Wygrana();
            } else if (button3.Text != "" && button3.Text == button6.Text && button6.Text == button9.Text) {
                Wygrana();
            } else if (button1.Text != "" && button1.Text == button5.Text && button5.Text == button9.Text) {
                Wygrana();
            } else if (button3.Text != "" && button3.Text == button5.Text && button5.Text == button7.Text) {
                Wygrana();
            } else if (ruch == 9) {
                MessageBox.Show("REMIS", "Koniec gry", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Restartuj();
            }

        }

        private void Wygrana()
        {
            MessageBox.Show("Wygrywa gracz: " + (gracz1 ? "O":"X"), "Koniec gry", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            if (gracz1)
                wynik_o.Text = ((int.Parse(wynik_o.Text)) + 1).ToString();
            else
                wynik_x.Text = ((int.Parse(wynik_x.Text)) + 1).ToString();
            Restartuj();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ruch++;
            ((Button)sender).Text = gracz1 ? "O" : "X";
            ((Button)sender).Enabled = false;
            if (ruch >= 5)
            {
                Sprawdz();
            }
            gracz1 = !gracz1;
            labelKto.Text = gracz1 ? "0" : "X";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ruch++;
            ((Button)sender).Text = gracz1 ? "O" : "X";
            ((Button)sender).Enabled = false;
            if (ruch >= 5)
            {
                Sprawdz();
            }
            gracz1 = !gracz1;
            labelKto.Text = gracz1 ? "0" : "X";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ruch++;
            ((Button)sender).Text = gracz1 ? "O" : "X";
            ((Button)sender).Enabled = false;
            if (ruch >= 5)
            {
                Sprawdz();
            }
            gracz1 = !gracz1;
            labelKto.Text = gracz1 ? "0" : "X";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ruch++;
            ((Button)sender).Text = gracz1 ? "O" : "X";
            ((Button)sender).Enabled = false;
            if (ruch >= 5)
            {
                Sprawdz();
            }
            gracz1 = !gracz1;
            labelKto.Text = gracz1 ? "0" : "X";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            ruch++;
            ((Button)sender).Text = gracz1 ? "O" : "X";
            ((Button)sender).Enabled = false;
            if (ruch >= 5)
            {
                Sprawdz();
            }
            gracz1 = !gracz1;
            labelKto.Text = gracz1 ? "0" : "X";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            ruch++;
            ((Button)sender).Text = gracz1 ? "O" : "X";
            ((Button)sender).Enabled = false;
            if (ruch >= 5)
            {
                Sprawdz();
            }
            gracz1 = !gracz1;
            labelKto.Text = gracz1 ? "0" : "X";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            ruch++;
            ((Button)sender).Text = gracz1 ? "O" : "X";
            ((Button)sender).Enabled = false;
            if (ruch >= 5)
            {
                Sprawdz();
            }
            gracz1 = !gracz1;
            labelKto.Text = gracz1 ? "0" : "X";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            ruch++;
            ((Button)sender).Text = gracz1 ? "O" : "X";
            ((Button)sender).Enabled = false;
            if (ruch >= 5)
            {
                Sprawdz();
            }
            gracz1 = !gracz1;
            labelKto.Text = gracz1 ? "0" : "X";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            ruch++;
            ((Button)sender).Text = gracz1 ? "O" : "X";
            ((Button)sender).Enabled = false;
            if (ruch >= 5)
            {
                Sprawdz();
            }
            gracz1 = !gracz1;
            labelKto.Text = gracz1 ? "0" : "X";
        }
    }
}