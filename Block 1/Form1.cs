using System;
using System.Threading;
using System.Windows.Forms;

namespace Block_1
{
    public partial class FMain : Form
    {
        public FMain()
        {
            InitializeComponent();
            f1 = new ControlDelegate(ControlWriteText);
            f2 = new TBDelegate(TBGetDouble);
        }
        delegate void ControlDelegate(object sender, string text);
        ControlDelegate f1;

        void ControlWriteText(object sender, string text)
        {
            ((Control)sender).Text = text;
        }

        delegate double TBDelegate(object sender);
        TBDelegate f2;
        double TBGetDouble(object sender)
        {
            double num = 0;
            bool result;
            if (((TextBox)sender).Text != "")
            {
                result = double.TryParse(((TextBox)sender).Text, out num);
                if (result) return num ;
            }
            return num;
        }

        void Func1()
        {
            double x;
            double accuracy;

            x = (double)tbEPower.Invoke(f2, tbEPower);
            accuracy = (double)tbExAccuracy.Invoke(f2, tbExAccuracy);
            double s = Block1.EPowXClasic(x, accuracy);
            lbExClassic.Invoke(f1, lbExClassic, s.ToString());
        }

        void Func2()
        {
            double x;
            double accuracy;

            x = (double)tbEPower.Invoke(f2, tbEPower);
            accuracy = (double)tbExAccuracy.Invoke(f2, tbExAccuracy);
            double s = Block1.EPowXReq(x, accuracy);
            lbExReq.Invoke(f1, lbExReq, s.ToString());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            lbExControl.Text = Math.Exp(TBGetDouble(tbEPower)).ToString();

            lbExClassic.Text = "-";
            lbExReq.Text = "-";

            Thread th1 = new Thread(Func1);
            Thread th2 = new Thread(Func2);
            th1.Start();
            th2.Start();

        }

        private void pbSinCulc_Click(object sender, EventArgs e)
        {
            double x = TBGetDouble(tbSinX);
            double accuracy = TBGetDouble(tbSinAccuracy);
            ControlWriteText(lbSinControl, Math.Sin(x).ToString());
            ControlWriteText(lbSinRes, Block1.Sin(x, accuracy).ToString());
        }
    }
}
