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
            accuracy = (double)tbAccuracy.Invoke(f2, tbAccuracy);
            double s = Ex.CalcSumClasic(x, accuracy);
            lbClassic.Invoke(f1, lbClassic, s.ToString());
        }

        void Func2()
        {
            double x;
            double accuracy;

            x = (double)tbEPower.Invoke(f2, tbEPower);
            accuracy = (double)tbAccuracy.Invoke(f2, tbAccuracy);
            double s = Ex.CalcSumReq(x, accuracy);
            lbReq.Invoke(f1, lbReq, s.ToString());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            lbExControl.Text = Math.Exp(TBGetDouble(tbEPower)).ToString();

            lbClassic.Text = "-";
            lbReq.Text = "-";

            Thread th1 = new Thread(Func1);
            Thread th2 = new Thread(Func2);
            th1.Start();
            th2.Start();

        }


    }
}
