namespace CS311_Project3_ADH
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.cboPizzaSize = new System.Windows.Forms.ComboBox();
            this.grpCrust = new System.Windows.Forms.GroupBox();
            this.rdoRegular = new System.Windows.Forms.RadioButton();
            this.rdoThick = new System.Windows.Forms.RadioButton();
            this.rdoThin = new System.Windows.Forms.RadioButton();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.ckbPepperoni = new System.Windows.Forms.CheckBox();
            this.ckbSausage = new System.Windows.Forms.CheckBox();
            this.ckbCanadianBacon = new System.Windows.Forms.CheckBox();
            this.ckbSpicyItalianSausage = new System.Windows.Forms.CheckBox();
            this.rtfOutput = new System.Windows.Forms.RichTextBox();
            this.ckbOnion = new System.Windows.Forms.CheckBox();
            this.ckbGreenPepper = new System.Windows.Forms.CheckBox();
            this.ckbBlackOlives = new System.Windows.Forms.CheckBox();
            this.ckbGreenOlives = new System.Windows.Forms.CheckBox();
            this.ckbBananaPeppers = new System.Windows.Forms.CheckBox();
            this.ckbJalapeno = new System.Windows.Forms.CheckBox();
            this.ckbExtraCheese = new System.Windows.Forms.CheckBox();
            this.ckbMushroom = new System.Windows.Forms.CheckBox();
            this.lblSize = new System.Windows.Forms.Label();
            this.lblToppings = new System.Windows.Forms.Label();
            this.lblOrderSummary = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblTax = new System.Windows.Forms.Label();
            this.lblSubtotal = new System.Windows.Forms.Label();
            this.txtSubtotal = new System.Windows.Forms.TextBox();
            this.txtTax = new System.Windows.Forms.TextBox();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.picPizza = new System.Windows.Forms.PictureBox();
            this.grpCrust.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picPizza)).BeginInit();
            this.SuspendLayout();
            // 
            // cboPizzaSize
            // 
            this.cboPizzaSize.FormattingEnabled = true;
            this.cboPizzaSize.Items.AddRange(new object[] {
            "Small",
            "Medium",
            "Large",
            "X-Large",
            "Ginormous"});
            this.cboPizzaSize.Location = new System.Drawing.Point(183, 423);
            this.cboPizzaSize.Name = "cboPizzaSize";
            this.cboPizzaSize.Size = new System.Drawing.Size(185, 28);
            this.cboPizzaSize.TabIndex = 0;
            // 
            // grpCrust
            // 
            this.grpCrust.Controls.Add(this.rdoRegular);
            this.grpCrust.Controls.Add(this.rdoThick);
            this.grpCrust.Controls.Add(this.rdoThin);
            this.grpCrust.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpCrust.Location = new System.Drawing.Point(428, 423);
            this.grpCrust.Name = "grpCrust";
            this.grpCrust.Size = new System.Drawing.Size(556, 40);
            this.grpCrust.TabIndex = 2;
            this.grpCrust.TabStop = false;
            this.grpCrust.Text = "Crust Type:";
            // 
            // rdoRegular
            // 
            this.rdoRegular.AutoSize = true;
            this.rdoRegular.Location = new System.Drawing.Point(395, 0);
            this.rdoRegular.Name = "rdoRegular";
            this.rdoRegular.Size = new System.Drawing.Size(111, 29);
            this.rdoRegular.TabIndex = 2;
            this.rdoRegular.TabStop = true;
            this.rdoRegular.Text = "Regular";
            this.rdoRegular.UseVisualStyleBackColor = true;
            // 
            // rdoThick
            // 
            this.rdoThick.AutoSize = true;
            this.rdoThick.Location = new System.Drawing.Point(272, 0);
            this.rdoThick.Name = "rdoThick";
            this.rdoThick.Size = new System.Drawing.Size(90, 29);
            this.rdoThick.TabIndex = 1;
            this.rdoThick.TabStop = true;
            this.rdoThick.Text = "Thick";
            this.rdoThick.UseVisualStyleBackColor = true;
            // 
            // rdoThin
            // 
            this.rdoThin.AutoSize = true;
            this.rdoThin.Location = new System.Drawing.Point(162, 0);
            this.rdoThin.Name = "rdoThin";
            this.rdoThin.Size = new System.Drawing.Size(80, 29);
            this.rdoThin.TabIndex = 0;
            this.rdoThin.TabStop = true;
            this.rdoThin.Text = "Thin";
            this.rdoThin.UseVisualStyleBackColor = true;
            // 
            // btnCalculate
            // 
            this.btnCalculate.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalculate.Location = new System.Drawing.Point(777, 992);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(205, 60);
            this.btnCalculate.TabIndex = 3;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // ckbPepperoni
            // 
            this.ckbPepperoni.AutoSize = true;
            this.ckbPepperoni.Location = new System.Drawing.Point(183, 575);
            this.ckbPepperoni.Name = "ckbPepperoni";
            this.ckbPepperoni.Size = new System.Drawing.Size(107, 24);
            this.ckbPepperoni.TabIndex = 4;
            this.ckbPepperoni.Text = "Pepperoni";
            this.ckbPepperoni.UseVisualStyleBackColor = true;
            // 
            // ckbSausage
            // 
            this.ckbSausage.AutoSize = true;
            this.ckbSausage.Location = new System.Drawing.Point(183, 633);
            this.ckbSausage.Name = "ckbSausage";
            this.ckbSausage.Size = new System.Drawing.Size(99, 24);
            this.ckbSausage.TabIndex = 5;
            this.ckbSausage.Text = "Sausage";
            this.ckbSausage.UseVisualStyleBackColor = true;
            // 
            // ckbCanadianBacon
            // 
            this.ckbCanadianBacon.AutoSize = true;
            this.ckbCanadianBacon.Location = new System.Drawing.Point(183, 690);
            this.ckbCanadianBacon.Name = "ckbCanadianBacon";
            this.ckbCanadianBacon.Size = new System.Drawing.Size(153, 24);
            this.ckbCanadianBacon.TabIndex = 6;
            this.ckbCanadianBacon.Text = "Canadian Bacon";
            this.ckbCanadianBacon.UseVisualStyleBackColor = true;
            // 
            // ckbSpicyItalianSausage
            // 
            this.ckbSpicyItalianSausage.AutoSize = true;
            this.ckbSpicyItalianSausage.Location = new System.Drawing.Point(183, 755);
            this.ckbSpicyItalianSausage.Name = "ckbSpicyItalianSausage";
            this.ckbSpicyItalianSausage.Size = new System.Drawing.Size(188, 24);
            this.ckbSpicyItalianSausage.TabIndex = 7;
            this.ckbSpicyItalianSausage.Text = "Spicy Italian Sausage";
            this.ckbSpicyItalianSausage.UseVisualStyleBackColor = true;
            // 
            // rtfOutput
            // 
            this.rtfOutput.Location = new System.Drawing.Point(269, 853);
            this.rtfOutput.Name = "rtfOutput";
            this.rtfOutput.Size = new System.Drawing.Size(409, 199);
            this.rtfOutput.TabIndex = 8;
            this.rtfOutput.Text = "";
            // 
            // ckbOnion
            // 
            this.ckbOnion.AutoSize = true;
            this.ckbOnion.Location = new System.Drawing.Point(428, 574);
            this.ckbOnion.Name = "ckbOnion";
            this.ckbOnion.Size = new System.Drawing.Size(77, 24);
            this.ckbOnion.TabIndex = 9;
            this.ckbOnion.Text = "Onion";
            this.ckbOnion.UseVisualStyleBackColor = true;
            // 
            // ckbGreenPepper
            // 
            this.ckbGreenPepper.AutoSize = true;
            this.ckbGreenPepper.Location = new System.Drawing.Point(428, 632);
            this.ckbGreenPepper.Name = "ckbGreenPepper";
            this.ckbGreenPepper.Size = new System.Drawing.Size(135, 24);
            this.ckbGreenPepper.TabIndex = 10;
            this.ckbGreenPepper.Text = "Green Pepper";
            this.ckbGreenPepper.UseVisualStyleBackColor = true;
            // 
            // ckbBlackOlives
            // 
            this.ckbBlackOlives.AutoSize = true;
            this.ckbBlackOlives.Location = new System.Drawing.Point(428, 689);
            this.ckbBlackOlives.Name = "ckbBlackOlives";
            this.ckbBlackOlives.Size = new System.Drawing.Size(120, 24);
            this.ckbBlackOlives.TabIndex = 11;
            this.ckbBlackOlives.Text = "Black Olives";
            this.ckbBlackOlives.UseVisualStyleBackColor = true;
            // 
            // ckbGreenOlives
            // 
            this.ckbGreenOlives.AutoSize = true;
            this.ckbGreenOlives.Location = new System.Drawing.Point(428, 754);
            this.ckbGreenOlives.Name = "ckbGreenOlives";
            this.ckbGreenOlives.Size = new System.Drawing.Size(126, 24);
            this.ckbGreenOlives.TabIndex = 12;
            this.ckbGreenOlives.Text = "Green Olives";
            this.ckbGreenOlives.UseVisualStyleBackColor = true;
            // 
            // ckbBananaPeppers
            // 
            this.ckbBananaPeppers.AutoSize = true;
            this.ckbBananaPeppers.Location = new System.Drawing.Point(639, 573);
            this.ckbBananaPeppers.Name = "ckbBananaPeppers";
            this.ckbBananaPeppers.Size = new System.Drawing.Size(154, 24);
            this.ckbBananaPeppers.TabIndex = 13;
            this.ckbBananaPeppers.Text = "Banana Peppers";
            this.ckbBananaPeppers.UseVisualStyleBackColor = true;
            // 
            // ckbJalapeno
            // 
            this.ckbJalapeno.AutoSize = true;
            this.ckbJalapeno.Location = new System.Drawing.Point(639, 632);
            this.ckbJalapeno.Name = "ckbJalapeno";
            this.ckbJalapeno.Size = new System.Drawing.Size(100, 24);
            this.ckbJalapeno.TabIndex = 14;
            this.ckbJalapeno.Text = "Jalapeno";
            this.ckbJalapeno.UseVisualStyleBackColor = true;
            // 
            // ckbExtraCheese
            // 
            this.ckbExtraCheese.AutoSize = true;
            this.ckbExtraCheese.Location = new System.Drawing.Point(639, 690);
            this.ckbExtraCheese.Name = "ckbExtraCheese";
            this.ckbExtraCheese.Size = new System.Drawing.Size(131, 24);
            this.ckbExtraCheese.TabIndex = 15;
            this.ckbExtraCheese.Text = "Extra Cheese";
            this.ckbExtraCheese.UseVisualStyleBackColor = true;
            // 
            // ckbMushroom
            // 
            this.ckbMushroom.AutoSize = true;
            this.ckbMushroom.Location = new System.Drawing.Point(639, 755);
            this.ckbMushroom.Name = "ckbMushroom";
            this.ckbMushroom.Size = new System.Drawing.Size(110, 24);
            this.ckbMushroom.TabIndex = 16;
            this.ckbMushroom.Text = "Mushroom";
            this.ckbMushroom.UseVisualStyleBackColor = true;
            // 
            // lblSize
            // 
            this.lblSize.AutoSize = true;
            this.lblSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSize.Location = new System.Drawing.Point(75, 423);
            this.lblSize.Name = "lblSize";
            this.lblSize.Size = new System.Drawing.Size(68, 25);
            this.lblSize.TabIndex = 17;
            this.lblSize.Text = "Size: ";
            // 
            // lblToppings
            // 
            this.lblToppings.AutoSize = true;
            this.lblToppings.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblToppings.Location = new System.Drawing.Point(75, 514);
            this.lblToppings.Name = "lblToppings";
            this.lblToppings.Size = new System.Drawing.Size(109, 25);
            this.lblToppings.TabIndex = 18;
            this.lblToppings.Text = "Toppings:";
            // 
            // lblOrderSummary
            // 
            this.lblOrderSummary.AutoSize = true;
            this.lblOrderSummary.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOrderSummary.Location = new System.Drawing.Point(75, 853);
            this.lblOrderSummary.Name = "lblOrderSummary";
            this.lblOrderSummary.Size = new System.Drawing.Size(164, 25);
            this.lblOrderSummary.TabIndex = 19;
            this.lblOrderSummary.Text = "Order Summary";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(737, 944);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(61, 25);
            this.lblTotal.TabIndex = 20;
            this.lblTotal.Text = "Total";
            // 
            // lblTax
            // 
            this.lblTax.AutoSize = true;
            this.lblTax.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTax.Location = new System.Drawing.Point(737, 894);
            this.lblTax.Name = "lblTax";
            this.lblTax.Size = new System.Drawing.Size(56, 25);
            this.lblTax.TabIndex = 21;
            this.lblTax.Text = "Tax:";
            // 
            // lblSubtotal
            // 
            this.lblSubtotal.AutoSize = true;
            this.lblSubtotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubtotal.Location = new System.Drawing.Point(736, 852);
            this.lblSubtotal.Name = "lblSubtotal";
            this.lblSubtotal.Size = new System.Drawing.Size(113, 25);
            this.lblSubtotal.TabIndex = 22;
            this.lblSubtotal.Text = "SubTotal: ";
            // 
            // txtSubtotal
            // 
            this.txtSubtotal.Location = new System.Drawing.Point(875, 851);
            this.txtSubtotal.Name = "txtSubtotal";
            this.txtSubtotal.Size = new System.Drawing.Size(146, 26);
            this.txtSubtotal.TabIndex = 23;
            // 
            // txtTax
            // 
            this.txtTax.Location = new System.Drawing.Point(875, 894);
            this.txtTax.Name = "txtTax";
            this.txtTax.Size = new System.Drawing.Size(146, 26);
            this.txtTax.TabIndex = 24;
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(875, 944);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(146, 26);
            this.txtTotal.TabIndex = 25;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Old English Text MT", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(380, 156);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(710, 114);
            this.lblName.TabIndex = 26;
            this.lblName.Text = "Al\'s Pizza Place";
            // 
            // picPizza
            // 
            this.picPizza.Image = global::CS311_Project3_ADH.Properties.Resources._2dd809b7c15968cb7cc577b2cb49c84f_pizza_food_restaurant_logo;
            this.picPizza.Location = new System.Drawing.Point(86, 100);
            this.picPizza.Name = "picPizza";
            this.picPizza.Size = new System.Drawing.Size(250, 243);
            this.picPizza.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picPizza.TabIndex = 27;
            this.picPizza.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1131, 1157);
            this.Controls.Add(this.picPizza);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.txtTax);
            this.Controls.Add(this.txtSubtotal);
            this.Controls.Add(this.lblSubtotal);
            this.Controls.Add(this.lblTax);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.lblOrderSummary);
            this.Controls.Add(this.lblToppings);
            this.Controls.Add(this.lblSize);
            this.Controls.Add(this.ckbMushroom);
            this.Controls.Add(this.ckbExtraCheese);
            this.Controls.Add(this.ckbJalapeno);
            this.Controls.Add(this.ckbBananaPeppers);
            this.Controls.Add(this.ckbGreenOlives);
            this.Controls.Add(this.ckbBlackOlives);
            this.Controls.Add(this.ckbGreenPepper);
            this.Controls.Add(this.ckbOnion);
            this.Controls.Add(this.rtfOutput);
            this.Controls.Add(this.ckbSpicyItalianSausage);
            this.Controls.Add(this.ckbCanadianBacon);
            this.Controls.Add(this.ckbSausage);
            this.Controls.Add(this.ckbPepperoni);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.grpCrust);
            this.Controls.Add(this.cboPizzaSize);
            this.Name = "Form1";
            this.Text = "Form1";
            this.grpCrust.ResumeLayout(false);
            this.grpCrust.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picPizza)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cboPizzaSize;
        private System.Windows.Forms.GroupBox grpCrust;
        private System.Windows.Forms.RadioButton rdoRegular;
        private System.Windows.Forms.RadioButton rdoThick;
        private System.Windows.Forms.RadioButton rdoThin;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.CheckBox ckbPepperoni;
        private System.Windows.Forms.CheckBox ckbSausage;
        private System.Windows.Forms.CheckBox ckbCanadianBacon;
        private System.Windows.Forms.CheckBox ckbSpicyItalianSausage;
        private System.Windows.Forms.RichTextBox rtfOutput;
        private System.Windows.Forms.CheckBox ckbOnion;
        private System.Windows.Forms.CheckBox ckbGreenPepper;
        private System.Windows.Forms.CheckBox ckbBlackOlives;
        private System.Windows.Forms.CheckBox ckbGreenOlives;
        private System.Windows.Forms.CheckBox ckbBananaPeppers;
        private System.Windows.Forms.CheckBox ckbJalapeno;
        private System.Windows.Forms.CheckBox ckbExtraCheese;
        private System.Windows.Forms.CheckBox ckbMushroom;
        private System.Windows.Forms.Label lblSize;
        private System.Windows.Forms.Label lblToppings;
        private System.Windows.Forms.Label lblOrderSummary;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblTax;
        private System.Windows.Forms.Label lblSubtotal;
        private System.Windows.Forms.TextBox txtSubtotal;
        private System.Windows.Forms.TextBox txtTax;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.PictureBox picPizza;
    }
}

