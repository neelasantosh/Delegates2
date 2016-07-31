using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace UsingDelegatesInWindowsApplication
{
    public partial class Form1 : Form
    {
        //we are making a delegate to call a thread
        public delegate void del_thread(string str);

        public void getData(string s)
        {
            MessageBox.Show("getData: " + s);
        }

        public Form1()
        {
            InitializeComponent();

            my_Sum_Control1._event += new Win_sum_control.My_Sum_Control.del(result);

            //accessing delegate of UserControl class

        }

        //event fires then this function will be called
        void result(double total)
        {
            resultTextBox.Text = "Result is " + total + "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //passing address of getData function
            del_thread obj = new del_thread(getData);

            //calling getData function with string argument "hello"
            //BeginInvoke: It will invoke the function with new thread
            //CallBack: when ever we are using thread we should use callback function
            //CallBack is used for cleaning purpose.
            obj.BeginInvoke("This is parameter to getData Function", new AsyncCallback(callback), "This is parameter to callback");
            //if want to send some parameter to callback funtion the in place of null put value i.e on third argument
        }
        
        //This is the definition of call back function
        //This funciton will be called when getData finished
        public void callback(IAsyncResult res)
        {
            MessageBox.Show("This is the call back funtion!", "Info");
        }
    }
}
