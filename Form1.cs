using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CS311_Project3_ADH
{
   
    public partial class Form1 : Form
    {
        private bool integrity = false;
        private bool isCrust = false;
        private double price;
        private double tax;
        private double taxRate = 7;
        private double total;
        private String size;
        private String crust;
        private String summary;
        public Form1()
        {
            InitializeComponent();
        }


        private void btnCalculate_Click(object sender, EventArgs e)
        {
            size = cboPizzaSize.GetItemText(cboPizzaSize.SelectedItem);
            calculateSubtotal();
            calculateTax();
            calculateTotal();
            Summarize();
            optionCheck();
        }//end calculate click

        private void Summarize()
        {
            summary = "";
            //crust 
            if (rdoThin.Checked) { crust = "thin"; }
            else if(rdoThick.Checked) { crust = "thick"; }
            else if(rdoRegular.Checked) { crust = "regular";  }
            else { crust = "no"; }
            summary += "You ordered a " + size + " pizza with " + crust + " crust and the following toppings: \n";

            //toppings
            if (ckbPepperoni.Checked) { summary += "\u2022Pepperoni\n"; }
            if(ckbSausage.Checked) { summary += "\u2022Sausage\n"; }
            if(ckbCanadianBacon.Checked) { summary += "\u2022Canadian Bacon\n"; }
            if (ckbSpicyItalianSausage.Checked) { summary += "\u2022Spicy Italian Sausage\n"; }
            if (ckbOnion.Checked) { summary += "\u2022Onion\n"; }
            if (ckbGreenPepper.Checked) { summary += "\u2022Green Pepper\n"; }
            if (ckbBlackOlives.Checked) { summary += "\u2022Black Olives\n"; }
            if (ckbGreenOlives.Checked) { summary += "\u2022Green Olives\n"; }
            if (ckbBananaPeppers.Checked) { summary += "\u2022Banana Peppers\n"; }
            if (ckbJalapeno.Checked) { summary += "\u2022Jalapeno\n"; }
            if (ckbExtraCheese.Checked) { summary += "\u2022Extra Cheese\n"; }
            if (ckbMushroom.Checked) { summary += "\u2022Mushroom\n"; }

            rtfOutput.Text = summary;
        }//end summarize

        private void optionCheck()
        { 
            if (cboPizzaSize.SelectedIndex > -1) 
            { 
                //continue on as normal
            }//end if
            else
            {
                rtfOutput.Clear();
                txtSubtotal.Clear();
                txtTax.Clear();
                txtTotal.Clear();
                rtfOutput.Text = "Please ensure you have all options chosen.";
            }//end else

        }//end optionCheck

        private void calculateSubtotal ()
        {
            price = 0;
            //add pizza size cost
            if (size == "Small")
                price += 2;
            else if (size == "Medium")
                price += 5;
            else if (size == "Large")
                price += 10;
            else if (size == "Ginormous")
                price += 15;

            //add meat price
            if (ckbPepperoni.Checked)
                price += 2;
            if (ckbSausage.Checked)
                price += 2;
            if (ckbCanadianBacon.Checked)
                price += 2;
            if (ckbSpicyItalianSausage.Checked)
                price += 2;

            //add other toppings
            if (ckbPepperoni.Checked) { price += 1; }
            if (ckbSausage.Checked) { price += 1; ; }
            if (ckbCanadianBacon.Checked) { price += 1; }
            if (ckbSpicyItalianSausage.Checked) { price += 1; }
            if (ckbOnion.Checked) { price += 1; }
            if (ckbGreenPepper.Checked) { price += 1; }
            if (ckbBlackOlives.Checked) { price += 1; }
            if (ckbGreenOlives.Checked) { price += 1; }
            if (ckbBananaPeppers.Checked) { price += 1; }
            if (ckbJalapeno.Checked) { price += 1; }
            if (ckbExtraCheese.Checked) { price += 1; }
            if (ckbMushroom.Checked) { price += 1; }

            String txtPrice = price.ToString();
            txtSubtotal.Text = txtPrice;

        }//end calculate subtotal

        private void calculateTax()
        {
            tax = 0;
            tax = price * taxRate / 100;
            String taxPrice = tax.ToString();
            txtTax.Text = taxPrice;
        }//end calculateTax

        private void calculateTotal()
        {
            total = 0;
            total = price + tax;
            String totalPrice = total.ToString();
            txtTotal.Text = totalPrice;
        }//end calculate total
     
    }
}
