using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Yap_Lambda
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            //YAP,RYlE T.
            //ACT.5 Lambda Expression
            InitializeComponent();
            btnTotal.Click += (s, e) =>//Declaration of lambda expression
            {
                int Quantity = Convert.ToInt32(TxtQuantity.Text);
                if (Quantity > 0)//if else statement 
                {
                    lblResult.Text = "ORDER ACCEPTED";//if the input is greater than ZERO
                }
                else
                {
                    lblResult.Text = "INVALID ORDER";//if the input is less than or equal to ZERO
                }
            };

            btnClear.Click += (s, e) =>//lambda expression for clear button
            {
                TxtQuantity.Clear();//clear the textbox
                lblResult.Text="Waiting for new result... ";//clear the lable <RESULT>
            };
        }

       
    }
}
