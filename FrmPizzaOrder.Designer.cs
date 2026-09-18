namespace Pizza_Order_WinForm
{
    partial class FrmPizzaOrder
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPizzaOrder));
            this.Title = new System.Windows.Forms.Label();
            this.grbSize = new System.Windows.Forms.GroupBox();
            this.rdBtnLarge = new System.Windows.Forms.RadioButton();
            this.rdBtnMid = new System.Windows.Forms.RadioButton();
            this.rdBtnSmall = new System.Windows.Forms.RadioButton();
            this.grbCrust = new System.Windows.Forms.GroupBox();
            this.rdBtnThick = new System.Windows.Forms.RadioButton();
            this.rdBtnThin = new System.Windows.Forms.RadioButton();
            this.grbToppings = new System.Windows.Forms.GroupBox();
            this.chkTomatoes = new System.Windows.Forms.CheckBox();
            this.chkGreenPeppers = new System.Windows.Forms.CheckBox();
            this.chkMushrooms = new System.Windows.Forms.CheckBox();
            this.chkOlives = new System.Windows.Forms.CheckBox();
            this.chkExtraCheese = new System.Windows.Forms.CheckBox();
            this.chkOnion = new System.Windows.Forms.CheckBox();
            this.grbWherToEat = new System.Windows.Forms.GroupBox();
            this.rdBtnTakeAway = new System.Windows.Forms.RadioButton();
            this.rdBtnInDoor = new System.Windows.Forms.RadioButton();
            this.lblSummary = new System.Windows.Forms.Label();
            this.lblSize = new System.Windows.Forms.Label();
            this.lblCrust = new System.Windows.Forms.Label();
            this.lblWhereToEat = new System.Windows.Forms.Label();
            this.lblSizeChoise = new System.Windows.Forms.Label();
            this.lblCrustChoise = new System.Windows.Forms.Label();
            this.lblPlaceChoice = new System.Windows.Forms.Label();
            this.lblToppings = new System.Windows.Forms.Label();
            this.lblToppingsChoice = new System.Windows.Forms.Label();
            this.lblTotalPrice = new System.Windows.Forms.Label();
            this.lblTotalPriceValue = new System.Windows.Forms.Label();
            this.btnOrder = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.grbSize.SuspendLayout();
            this.grbCrust.SuspendLayout();
            this.grbToppings.SuspendLayout();
            this.grbWherToEat.SuspendLayout();
            this.SuspendLayout();
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.Font = new System.Drawing.Font("Viner Hand ITC", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Title.ForeColor = System.Drawing.Color.Maroon;
            this.Title.Location = new System.Drawing.Point(298, 9);
            this.Title.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(709, 129);
            this.Title.TabIndex = 0;
            this.Title.Text = "Make Your Pizza";
            this.Title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // grbSize
            // 
            this.grbSize.Controls.Add(this.rdBtnLarge);
            this.grbSize.Controls.Add(this.rdBtnMid);
            this.grbSize.Controls.Add(this.rdBtnSmall);
            this.grbSize.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbSize.Location = new System.Drawing.Point(40, 169);
            this.grbSize.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.grbSize.Name = "grbSize";
            this.grbSize.Padding = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.grbSize.Size = new System.Drawing.Size(212, 207);
            this.grbSize.TabIndex = 1;
            this.grbSize.TabStop = false;
            this.grbSize.Text = "Size";
            // 
            // rdBtnLarge
            // 
            this.rdBtnLarge.AutoSize = true;
            this.rdBtnLarge.Location = new System.Drawing.Point(30, 160);
            this.rdBtnLarge.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.rdBtnLarge.Name = "rdBtnLarge";
            this.rdBtnLarge.Size = new System.Drawing.Size(72, 25);
            this.rdBtnLarge.TabIndex = 2;
            this.rdBtnLarge.Tag = "9.5";
            this.rdBtnLarge.Text = "Large";
            this.rdBtnLarge.UseVisualStyleBackColor = true;
            this.rdBtnLarge.CheckedChanged += new System.EventHandler(this.rdBtnLarge_CheckedChanged);
            // 
            // rdBtnMid
            // 
            this.rdBtnMid.AutoSize = true;
            this.rdBtnMid.Location = new System.Drawing.Point(30, 102);
            this.rdBtnMid.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.rdBtnMid.Name = "rdBtnMid";
            this.rdBtnMid.Size = new System.Drawing.Size(57, 25);
            this.rdBtnMid.TabIndex = 1;
            this.rdBtnMid.Tag = "7.5";
            this.rdBtnMid.Text = "Mid";
            this.rdBtnMid.UseVisualStyleBackColor = true;
            this.rdBtnMid.CheckedChanged += new System.EventHandler(this.rdBtnMid_CheckedChanged);
            // 
            // rdBtnSmall
            // 
            this.rdBtnSmall.AutoSize = true;
            this.rdBtnSmall.Checked = true;
            this.rdBtnSmall.Location = new System.Drawing.Point(30, 44);
            this.rdBtnSmall.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.rdBtnSmall.Name = "rdBtnSmall";
            this.rdBtnSmall.Size = new System.Drawing.Size(71, 25);
            this.rdBtnSmall.TabIndex = 0;
            this.rdBtnSmall.TabStop = true;
            this.rdBtnSmall.Tag = "5";
            this.rdBtnSmall.Text = "Small";
            this.rdBtnSmall.UseVisualStyleBackColor = true;
            this.rdBtnSmall.CheckedChanged += new System.EventHandler(this.rdBtnSmall_CheckedChanged);
            // 
            // grbCrust
            // 
            this.grbCrust.Controls.Add(this.rdBtnThick);
            this.grbCrust.Controls.Add(this.rdBtnThin);
            this.grbCrust.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbCrust.Location = new System.Drawing.Point(698, 169);
            this.grbCrust.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.grbCrust.Name = "grbCrust";
            this.grbCrust.Padding = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.grbCrust.Size = new System.Drawing.Size(212, 162);
            this.grbCrust.TabIndex = 3;
            this.grbCrust.TabStop = false;
            this.grbCrust.Text = "Crust";
            // 
            // rdBtnThick
            // 
            this.rdBtnThick.AutoSize = true;
            this.rdBtnThick.Location = new System.Drawing.Point(30, 111);
            this.rdBtnThick.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.rdBtnThick.Name = "rdBtnThick";
            this.rdBtnThick.Size = new System.Drawing.Size(70, 25);
            this.rdBtnThick.TabIndex = 1;
            this.rdBtnThick.Tag = "3";
            this.rdBtnThick.Text = "Thick";
            this.rdBtnThick.UseVisualStyleBackColor = true;
            this.rdBtnThick.CheckedChanged += new System.EventHandler(this.rdBtnThink_CheckedChanged);
            // 
            // rdBtnThin
            // 
            this.rdBtnThin.AutoSize = true;
            this.rdBtnThin.Checked = true;
            this.rdBtnThin.Location = new System.Drawing.Point(30, 53);
            this.rdBtnThin.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.rdBtnThin.Name = "rdBtnThin";
            this.rdBtnThin.Size = new System.Drawing.Size(63, 25);
            this.rdBtnThin.TabIndex = 0;
            this.rdBtnThin.TabStop = true;
            this.rdBtnThin.Tag = "0";
            this.rdBtnThin.Text = "Thin";
            this.rdBtnThin.UseVisualStyleBackColor = true;
            this.rdBtnThin.CheckedChanged += new System.EventHandler(this.rdBtnThin_CheckedChanged);
            // 
            // grbToppings
            // 
            this.grbToppings.Controls.Add(this.chkTomatoes);
            this.grbToppings.Controls.Add(this.chkGreenPeppers);
            this.grbToppings.Controls.Add(this.chkMushrooms);
            this.grbToppings.Controls.Add(this.chkOlives);
            this.grbToppings.Controls.Add(this.chkExtraCheese);
            this.grbToppings.Controls.Add(this.chkOnion);
            this.grbToppings.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbToppings.Location = new System.Drawing.Point(320, 169);
            this.grbToppings.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.grbToppings.Name = "grbToppings";
            this.grbToppings.Padding = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.grbToppings.Size = new System.Drawing.Size(310, 207);
            this.grbToppings.TabIndex = 4;
            this.grbToppings.TabStop = false;
            this.grbToppings.Text = "Toppings";
            // 
            // chkTomatoes
            // 
            this.chkTomatoes.AutoSize = true;
            this.chkTomatoes.Location = new System.Drawing.Point(31, 149);
            this.chkTomatoes.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.chkTomatoes.Name = "chkTomatoes";
            this.chkTomatoes.Size = new System.Drawing.Size(106, 25);
            this.chkTomatoes.TabIndex = 9;
            this.chkTomatoes.Tag = "1";
            this.chkTomatoes.Text = "Tomatoes";
            this.chkTomatoes.UseVisualStyleBackColor = true;
            this.chkTomatoes.CheckedChanged += new System.EventHandler(this.chkToppings_CheckedChanged);
            // 
            // chkGreenPeppers
            // 
            this.chkGreenPeppers.AutoSize = true;
            this.chkGreenPeppers.Location = new System.Drawing.Point(164, 149);
            this.chkGreenPeppers.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.chkGreenPeppers.Name = "chkGreenPeppers";
            this.chkGreenPeppers.Size = new System.Drawing.Size(140, 25);
            this.chkGreenPeppers.TabIndex = 8;
            this.chkGreenPeppers.Tag = "1";
            this.chkGreenPeppers.Text = "Green Peppers";
            this.chkGreenPeppers.UseVisualStyleBackColor = true;
            this.chkGreenPeppers.CheckedChanged += new System.EventHandler(this.chkToppings_CheckedChanged);
            // 
            // chkMushrooms
            // 
            this.chkMushrooms.AutoSize = true;
            this.chkMushrooms.Location = new System.Drawing.Point(164, 55);
            this.chkMushrooms.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.chkMushrooms.Name = "chkMushrooms";
            this.chkMushrooms.Size = new System.Drawing.Size(117, 25);
            this.chkMushrooms.TabIndex = 7;
            this.chkMushrooms.Tag = "1";
            this.chkMushrooms.Text = "Mushrooms";
            this.chkMushrooms.UseVisualStyleBackColor = true;
            this.chkMushrooms.CheckedChanged += new System.EventHandler(this.chkToppings_CheckedChanged);
            // 
            // chkOlives
            // 
            this.chkOlives.AutoSize = true;
            this.chkOlives.Location = new System.Drawing.Point(164, 102);
            this.chkOlives.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.chkOlives.Name = "chkOlives";
            this.chkOlives.Size = new System.Drawing.Size(77, 25);
            this.chkOlives.TabIndex = 6;
            this.chkOlives.Tag = "1";
            this.chkOlives.Text = "Olives";
            this.chkOlives.UseVisualStyleBackColor = true;
            this.chkOlives.CheckedChanged += new System.EventHandler(this.chkToppings_CheckedChanged);
            // 
            // chkExtraCheese
            // 
            this.chkExtraCheese.AutoSize = true;
            this.chkExtraCheese.Location = new System.Drawing.Point(31, 102);
            this.chkExtraCheese.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.chkExtraCheese.Name = "chkExtraCheese";
            this.chkExtraCheese.Size = new System.Drawing.Size(130, 25);
            this.chkExtraCheese.TabIndex = 5;
            this.chkExtraCheese.Tag = "1";
            this.chkExtraCheese.Text = "Extra Cheese";
            this.chkExtraCheese.UseVisualStyleBackColor = true;
            this.chkExtraCheese.CheckedChanged += new System.EventHandler(this.chkToppings_CheckedChanged);
            // 
            // chkOnion
            // 
            this.chkOnion.AutoSize = true;
            this.chkOnion.Location = new System.Drawing.Point(31, 55);
            this.chkOnion.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.chkOnion.Name = "chkOnion";
            this.chkOnion.Size = new System.Drawing.Size(75, 25);
            this.chkOnion.TabIndex = 0;
            this.chkOnion.Tag = "1";
            this.chkOnion.Text = "Onion";
            this.chkOnion.UseVisualStyleBackColor = true;
            this.chkOnion.CheckedChanged += new System.EventHandler(this.chkToppings_CheckedChanged);
            // 
            // grbWherToEat
            // 
            this.grbWherToEat.Controls.Add(this.rdBtnTakeAway);
            this.grbWherToEat.Controls.Add(this.rdBtnInDoor);
            this.grbWherToEat.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbWherToEat.Location = new System.Drawing.Point(978, 169);
            this.grbWherToEat.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.grbWherToEat.Name = "grbWherToEat";
            this.grbWherToEat.Padding = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.grbWherToEat.Size = new System.Drawing.Size(212, 162);
            this.grbWherToEat.TabIndex = 4;
            this.grbWherToEat.TabStop = false;
            this.grbWherToEat.Text = "Where To Eat";
            // 
            // rdBtnTakeAway
            // 
            this.rdBtnTakeAway.AutoSize = true;
            this.rdBtnTakeAway.Location = new System.Drawing.Point(30, 111);
            this.rdBtnTakeAway.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.rdBtnTakeAway.Name = "rdBtnTakeAway";
            this.rdBtnTakeAway.Size = new System.Drawing.Size(113, 25);
            this.rdBtnTakeAway.TabIndex = 1;
            this.rdBtnTakeAway.Tag = "0";
            this.rdBtnTakeAway.Text = "Take Away";
            this.rdBtnTakeAway.UseVisualStyleBackColor = true;
            this.rdBtnTakeAway.CheckedChanged += new System.EventHandler(this.rdBtnTakeAway_CheckedChanged);
            // 
            // rdBtnInDoor
            // 
            this.rdBtnInDoor.AutoSize = true;
            this.rdBtnInDoor.Checked = true;
            this.rdBtnInDoor.Location = new System.Drawing.Point(30, 53);
            this.rdBtnInDoor.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.rdBtnInDoor.Name = "rdBtnInDoor";
            this.rdBtnInDoor.Size = new System.Drawing.Size(87, 25);
            this.rdBtnInDoor.TabIndex = 0;
            this.rdBtnInDoor.TabStop = true;
            this.rdBtnInDoor.Tag = "5";
            this.rdBtnInDoor.Text = "In Door";
            this.rdBtnInDoor.UseVisualStyleBackColor = true;
            this.rdBtnInDoor.CheckedChanged += new System.EventHandler(this.rdBtnInDoor_CheckedChanged);
            // 
            // lblSummary
            // 
            this.lblSummary.AutoSize = true;
            this.lblSummary.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSummary.Location = new System.Drawing.Point(35, 427);
            this.lblSummary.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSummary.Name = "lblSummary";
            this.lblSummary.Size = new System.Drawing.Size(171, 28);
            this.lblSummary.TabIndex = 5;
            this.lblSummary.Text = "Order Summary";
            // 
            // lblSize
            // 
            this.lblSize.AutoSize = true;
            this.lblSize.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSize.Location = new System.Drawing.Point(52, 482);
            this.lblSize.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSize.Name = "lblSize";
            this.lblSize.Size = new System.Drawing.Size(67, 28);
            this.lblSize.TabIndex = 6;
            this.lblSize.Text = "Size: ";
            // 
            // lblCrust
            // 
            this.lblCrust.AutoSize = true;
            this.lblCrust.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCrust.Location = new System.Drawing.Point(52, 526);
            this.lblCrust.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCrust.Name = "lblCrust";
            this.lblCrust.Size = new System.Drawing.Size(129, 28);
            this.lblCrust.TabIndex = 7;
            this.lblCrust.Text = "Crust Type:";
            // 
            // lblWhereToEat
            // 
            this.lblWhereToEat.AutoSize = true;
            this.lblWhereToEat.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWhereToEat.Location = new System.Drawing.Point(52, 570);
            this.lblWhereToEat.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblWhereToEat.Name = "lblWhereToEat";
            this.lblWhereToEat.Size = new System.Drawing.Size(165, 28);
            this.lblWhereToEat.TabIndex = 8;
            this.lblWhereToEat.Text = "Where To Eat: ";
            // 
            // lblSizeChoise
            // 
            this.lblSizeChoise.AutoSize = true;
            this.lblSizeChoise.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSizeChoise.Location = new System.Drawing.Point(126, 487);
            this.lblSizeChoise.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSizeChoise.Name = "lblSizeChoise";
            this.lblSizeChoise.Size = new System.Drawing.Size(50, 21);
            this.lblSizeChoise.TabIndex = 9;
            this.lblSizeChoise.Text = "Small";
            // 
            // lblCrustChoise
            // 
            this.lblCrustChoise.AutoSize = true;
            this.lblCrustChoise.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCrustChoise.Location = new System.Drawing.Point(188, 533);
            this.lblCrustChoise.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCrustChoise.Name = "lblCrustChoise";
            this.lblCrustChoise.Size = new System.Drawing.Size(42, 21);
            this.lblCrustChoise.TabIndex = 10;
            this.lblCrustChoise.Text = "Thin";
            // 
            // lblPlaceChoice
            // 
            this.lblPlaceChoice.AutoSize = true;
            this.lblPlaceChoice.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlaceChoice.Location = new System.Drawing.Point(224, 577);
            this.lblPlaceChoice.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPlaceChoice.Name = "lblPlaceChoice";
            this.lblPlaceChoice.Size = new System.Drawing.Size(66, 21);
            this.lblPlaceChoice.TabIndex = 11;
            this.lblPlaceChoice.Text = "In Door";
            // 
            // lblToppings
            // 
            this.lblToppings.AutoSize = true;
            this.lblToppings.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblToppings.Location = new System.Drawing.Point(52, 618);
            this.lblToppings.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblToppings.Name = "lblToppings";
            this.lblToppings.Size = new System.Drawing.Size(119, 28);
            this.lblToppings.TabIndex = 12;
            this.lblToppings.Text = "Toppings: ";
            // 
            // lblToppingsChoice
            // 
            this.lblToppingsChoice.AutoSize = true;
            this.lblToppingsChoice.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblToppingsChoice.Location = new System.Drawing.Point(178, 624);
            this.lblToppingsChoice.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblToppingsChoice.Name = "lblToppingsChoice";
            this.lblToppingsChoice.Size = new System.Drawing.Size(102, 21);
            this.lblToppingsChoice.TabIndex = 14;
            this.lblToppingsChoice.Text = "No Toppings";
            // 
            // lblTotalPrice
            // 
            this.lblTotalPrice.AutoSize = true;
            this.lblTotalPrice.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalPrice.Location = new System.Drawing.Point(52, 671);
            this.lblTotalPrice.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTotalPrice.Name = "lblTotalPrice";
            this.lblTotalPrice.Size = new System.Drawing.Size(133, 28);
            this.lblTotalPrice.TabIndex = 15;
            this.lblTotalPrice.Text = "Total Price: ";
            // 
            // lblTotalPriceValue
            // 
            this.lblTotalPriceValue.AutoSize = true;
            this.lblTotalPriceValue.Font = new System.Drawing.Font("Tahoma", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalPriceValue.ForeColor = System.Drawing.Color.Green;
            this.lblTotalPriceValue.Location = new System.Drawing.Point(192, 671);
            this.lblTotalPriceValue.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTotalPriceValue.Name = "lblTotalPriceValue";
            this.lblTotalPriceValue.Size = new System.Drawing.Size(90, 40);
            this.lblTotalPriceValue.TabIndex = 16;
            this.lblTotalPriceValue.Tag = "0";
            this.lblTotalPriceValue.Text = "$ 11";
            // 
            // btnOrder
            // 
            this.btnOrder.BackColor = System.Drawing.SystemColors.Control;
            this.btnOrder.Location = new System.Drawing.Point(978, 434);
            this.btnOrder.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.btnOrder.Name = "btnOrder";
            this.btnOrder.Size = new System.Drawing.Size(122, 76);
            this.btnOrder.TabIndex = 17;
            this.btnOrder.Text = "Order";
            this.btnOrder.UseVisualStyleBackColor = false;
            this.btnOrder.Click += new System.EventHandler(this.btnOrder_Click);
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.SystemColors.Control;
            this.btnReset.Location = new System.Drawing.Point(978, 550);
            this.btnReset.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(122, 76);
            this.btnReset.TabIndex = 18;
            this.btnReset.Text = "Reset Form";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // FrmPizzaOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1245, 770);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnOrder);
            this.Controls.Add(this.lblTotalPriceValue);
            this.Controls.Add(this.lblTotalPrice);
            this.Controls.Add(this.lblToppingsChoice);
            this.Controls.Add(this.lblToppings);
            this.Controls.Add(this.lblPlaceChoice);
            this.Controls.Add(this.lblCrustChoise);
            this.Controls.Add(this.lblSizeChoise);
            this.Controls.Add(this.lblWhereToEat);
            this.Controls.Add(this.lblCrust);
            this.Controls.Add(this.lblSize);
            this.Controls.Add(this.lblSummary);
            this.Controls.Add(this.grbWherToEat);
            this.Controls.Add(this.grbToppings);
            this.Controls.Add(this.grbCrust);
            this.Controls.Add(this.grbSize);
            this.Controls.Add(this.Title);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.Name = "FrmPizzaOrder";
            this.Text = "Pizza Order";
            this.Load += new System.EventHandler(this.FrmPizzaOrder_Load);
            this.grbSize.ResumeLayout(false);
            this.grbSize.PerformLayout();
            this.grbCrust.ResumeLayout(false);
            this.grbCrust.PerformLayout();
            this.grbToppings.ResumeLayout(false);
            this.grbToppings.PerformLayout();
            this.grbWherToEat.ResumeLayout(false);
            this.grbWherToEat.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.GroupBox grbSize;
        private System.Windows.Forms.RadioButton rdBtnLarge;
        private System.Windows.Forms.RadioButton rdBtnMid;
        private System.Windows.Forms.RadioButton rdBtnSmall;
        private System.Windows.Forms.GroupBox grbCrust;
        private System.Windows.Forms.RadioButton rdBtnThick;
        private System.Windows.Forms.RadioButton rdBtnThin;
        private System.Windows.Forms.GroupBox grbToppings;
        private System.Windows.Forms.CheckBox chkOnion;
        private System.Windows.Forms.CheckBox chkExtraCheese;
        private System.Windows.Forms.CheckBox chkTomatoes;
        private System.Windows.Forms.CheckBox chkGreenPeppers;
        private System.Windows.Forms.CheckBox chkMushrooms;
        private System.Windows.Forms.CheckBox chkOlives;
        private System.Windows.Forms.GroupBox grbWherToEat;
        private System.Windows.Forms.RadioButton rdBtnTakeAway;
        private System.Windows.Forms.RadioButton rdBtnInDoor;
        private System.Windows.Forms.Label lblSummary;
        private System.Windows.Forms.Label lblSize;
        private System.Windows.Forms.Label lblCrust;
        private System.Windows.Forms.Label lblWhereToEat;
        private System.Windows.Forms.Label lblSizeChoise;
        private System.Windows.Forms.Label lblCrustChoise;
        private System.Windows.Forms.Label lblPlaceChoice;
        private System.Windows.Forms.Label lblToppings;
        private System.Windows.Forms.Label lblToppingsChoice;
        private System.Windows.Forms.Label lblTotalPrice;
        private System.Windows.Forms.Label lblTotalPriceValue;
        private System.Windows.Forms.Button btnOrder;
        private System.Windows.Forms.Button btnReset;
    }
}

