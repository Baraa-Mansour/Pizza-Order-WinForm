using System;
using System.Windows.Forms;

namespace Pizza_Order_WinForm
{
    public partial class FrmPizzaOrder : Form
    {
        public FrmPizzaOrder()
        {
            InitializeComponent();
        }

        private float CalculateTotalPrice()
        {
            float totalPrice = 0;

            totalPrice += GetSizePrice();
            totalPrice += GetCrustPrice();
            totalPrice += GetEatPlacePrice();
            totalPrice += GetToppingsPrice();

            return totalPrice;
        }
        private float GetSizePrice()
        {
            string strPrice = "";
            if (rdBtnSmall.Checked)
                strPrice = rdBtnSmall.Tag.ToString();
            else if (rdBtnLarge.Checked)
                strPrice = rdBtnLarge.Tag.ToString();
            else if (rdBtnMid.Checked)
                strPrice = rdBtnMid.Tag.ToString();

            return Convert.ToSingle(strPrice);
        }
        private float GetCrustPrice()
        {
            string strPrice = (rdBtnThin.Checked ? rdBtnThin.Tag : rdBtnThink.Tag).ToString();

            return Convert.ToSingle(strPrice);
        }
        private float GetEatPlacePrice()
        {
            string strPrice = (rdBtnInDoor.Checked ? rdBtnInDoor.Tag : rdBtnTakeAway.Tag).ToString();

            return Convert.ToSingle(strPrice);
        }
        private float GetToppingsPrice()
        {
            float totalPrice = 0;

            if(chkExtraChees.Checked)
                totalPrice += Convert.ToSingle(chkExtraChees.Tag.ToString());
            if (chkGreenPeppers.Checked)
                totalPrice += Convert.ToSingle(chkGreenPeppers.Tag.ToString());
            if (chkMushrooms.Checked)
                totalPrice += Convert.ToSingle(chkMushrooms.Tag.ToString());
            if (chkOlives.Checked)
                totalPrice += Convert.ToSingle(chkOlives.Tag.ToString());
            if (chkOnion.Checked)
                totalPrice += Convert.ToSingle(chkOnion.Tag.ToString());
            if(chkTomatoes.Checked)
                totalPrice += Convert.ToSingle(chkTomatoes.Tag.ToString());

            return totalPrice;
        }


        private void UpdateTotalPriceLbl()
        {
            float TotalPrice = CalculateTotalPrice();
            lblTotalPriceValue.Text = "$" + TotalPrice.ToString();
            lblTotalPriceValue.Tag = TotalPrice;
        }


        private void UpdateSizeLbl()
        {
            if (rdBtnSmall.Checked)
                lblSizeChoise.Text = rdBtnSmall.Text;
            else if (rdBtnMid.Checked)
                lblSizeChoise.Text = rdBtnMid.Text;
            else if (rdBtnLarge.Checked)
                lblSizeChoise.Text = rdBtnLarge.Text;
        }

        private void UpdateCrustLbl()
        {
            if (rdBtnThin.Checked)
                lblCrustChoise.Text = rdBtnThin.Text;
            else if (rdBtnThink.Checked)
                lblCrustChoise.Text = rdBtnThink.Text;
        }

        private void UpdateEatPlaceLbl()
        {
            if (rdBtnInDoor.Checked)
                lblPlaceChoice.Text = rdBtnInDoor.Text;
            else if (rdBtnTakeAway.Checked)
                lblPlaceChoice.Text = rdBtnTakeAway.Text;
        }

        private void GetDefaultSize()
        {
            rdBtnSmall.Checked = true;
        }
        private void GetDafaultCrust()
        {
            rdBtnThin.Checked = true;
        }
        private void GetDafaultPlace()
        {
            rdBtnInDoor.Checked = true;
        }
        private void GetDefaultToppings()
        {
            chkExtraChees.Checked = false;
            chkGreenPeppers.Checked = false;
            chkMushrooms.Checked = false;
            chkOlives.Checked = false;
            chkOnion.Checked = false;
            chkTomatoes.Checked = false;
        }

        private void Reset()
        {
            GetDafaultCrust();
            GetDafaultPlace();
            GetDefaultSize();
            GetDefaultToppings();

            btnOrder.Enabled = true;
            grbCrust.Enabled = true;
            grbSize.Enabled = true;
            grbToopings.Enabled = true;
            grbWherToEat.Enabled = true;
        }

        private void rdBtnThin_CheckedChanged(object sender, EventArgs e)
        {
            UpdateCrustLbl();
            UpdateTotalPriceLbl();
        }
        private void rdBtnThink_CheckedChanged(object sender, EventArgs e)
        {
            UpdateCrustLbl();
            UpdateTotalPriceLbl();
        }

        private void rdBtnInDoor_CheckedChanged(object sender, EventArgs e)
        {
            UpdateEatPlaceLbl();
            UpdateTotalPriceLbl();
        }
        private void rdBtnTakeAway_CheckedChanged(object sender, EventArgs e)
        {
            UpdateEatPlaceLbl();
            UpdateTotalPriceLbl();
        }

        private void UpdateToppingsLbl()
        {
            string toppings = "";

            if (chkExtraChees.Checked)
                toppings += chkExtraChees.Text + ", ";
            if (chkGreenPeppers.Checked)
                toppings += chkGreenPeppers.Text + ", ";
            if (chkMushrooms.Checked)
                toppings += chkMushrooms.Text + ", ";
            if (chkOlives.Checked)
                toppings += chkOlives.Text + ", ";
            if (chkOnion.Checked)
                toppings += chkOnion.Text + ", ";
            if (chkTomatoes.Checked)
                toppings += chkTomatoes.Text + ", ";

            if(!string.IsNullOrEmpty(toppings))
            {
                toppings = toppings.Substring(0, toppings.Length - 2);
                lblToppingsChoice.Text = toppings;
            }
            else
                lblToppingsChoice.Text = "No Toppings";
        }
        private void chkToppings_CheckedChanged(object sender, EventArgs e)
        {
            UpdateToppingsLbl();
            UpdateTotalPriceLbl();
        }

        private void rdBtnSmall_CheckedChanged(object sender, EventArgs e)
        {
            UpdateSizeLbl();
            UpdateTotalPriceLbl();
        }
        private void rdBtnMid_CheckedChanged(object sender, EventArgs e)
        {
            UpdateSizeLbl();
            UpdateTotalPriceLbl();
        }
        private void rdBtnLarge_CheckedChanged(object sender, EventArgs e)
        {
            UpdateSizeLbl();
            UpdateTotalPriceLbl();
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            bool Ok = MessageBox.Show("Confirm Order",
                "Confirm",
                MessageBoxButtons.OKCancel,
                MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button1) == DialogResult.OK;

            if (Ok)
            {
                grbCrust.Enabled = false;
                grbSize.Enabled = false;
                grbToopings.Enabled = false;
                grbWherToEat.Enabled = false;
                btnOrder.Enabled = false;
            }

        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            Reset();
        }

        private void FrmPizzaOrder_Load(object sender, EventArgs e)
        {
            Reset();
        }
    }
}
