using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Win_sum_control
{
    public partial class My_Sum_Control : UserControl
    {
        //events and delegates 
        public delegate void del(double _x);
        public event del _event;

        public My_Sum_Control()
        {
            InitializeComponent();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            double n1 = Convert.ToInt32(firstValueTB.Text);
            double n2 = Convert.ToInt32(secondValueTB.Text);
            double ans = n1 + n2;
            resultTB.Text = ans + "";
            if (_event != null)
            {
                _event(ans);
            }
        }

        private void subButton_Click(object sender, EventArgs e)
        {
            double n1 = Convert.ToInt32(firstValueTB.Text);
            double n2 = Convert.ToInt32(secondValueTB.Text);
            double ans = n1 - n2;
            resultTB.Text = ans + "";
            if (_event != null)
            {
                _event(ans);
            }
        }

        private void multiButton_Click(object sender, EventArgs e)
        {
            double n1 = Convert.ToInt32(firstValueTB.Text);
            double n2 = Convert.ToInt32(secondValueTB.Text);
            double ans = n1 * n2;
            resultTB.Text = ans + "";
            if (_event != null)
            {
                _event(ans);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            double n1 = Convert.ToInt32(firstValueTB.Text);
            double n2 = Convert.ToInt32(secondValueTB.Text);
            double ans = n1 / n2;
            resultTB.Text = ans + "";
            if (_event != null)
            {
                _event(ans);
            }
        }
    }
}
