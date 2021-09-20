using System;
using System.Drawing;
using System.Windows.Forms;

namespace BMI_Rechner
{
    public partial class Form1 : Form
    {
        double Mass;
        double HeightValue;
        double BMI;

        public Form1()
        {
            InitializeComponent();
        }

        private void Bt_Calculate_Click(object sender, EventArgs e)
        {
                Mass = Convert.ToDouble(tb_masse.Text.Replace('.', ','));
                HeightValue = Convert.ToDouble(tb_groesse.Text.Replace('.', ','));

            BMI = Mass / (HeightValue * HeightValue);
            SetArrowHeight();
            var roundedValue = Math.Round(BMI, 2);

            tb_ergebnis.Text = Convert.ToString(roundedValue);
        }
        private void SetArrowHeight()
        {
            const int pixelStartHeight = 53;
            this.pb_arrow1.Visible = true;
            if (BMI < 16)
            {
                this.pb_arrow1.Location = new Point(256, pixelStartHeight);
            }

            if (BMI >= 16 && BMI <= 17)
            {
                this.pb_arrow1.Location = new Point(256, pixelStartHeight + 22 * 1);
            }

            if (BMI >= 17.01 && BMI <= 18.5)
            {
                this.pb_arrow1.Location = new Point(256, pixelStartHeight + 22 * 2);
            }

            if (BMI >= 18.51 && BMI <= 25)
            {
                this.pb_arrow1.Location = new Point(256, pixelStartHeight + 22 * 3);
            }
            
            if (BMI >= 25.01 && BMI <= 30)
            {
                this.pb_arrow1.Location = new Point(256, pixelStartHeight + 22 * 4);
            }

            if (BMI >= 30.01 && BMI <= 35)
            {
                this.pb_arrow1.Location = new Point(256, pixelStartHeight + 22 * 5);
            }

            if (BMI >= 35.01 && BMI <= 40)
            {
                this.pb_arrow1.Location = new Point(256, pixelStartHeight + 22 * 6);
            }

            if (BMI >= 40.01)
            {
                this.pb_arrow1.Location = new Point(256, pixelStartHeight + 22 * 7);
            }
        }
    }
}
