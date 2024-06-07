using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project___Vehicle_for_rent
{
    public partial class Form1 : Form
    {
        
        //date var
        DateTime rentdate = new DateTime();
        DateTime returndate = new DateTime();

        //sum var
        int sum = 0;

        public Form1()
        {
            InitializeComponent();

            //date init
            rentdate = DateTime.Now;
            returndate = DateTime.Now;
        }

        //get dates
        private void dateRent_ValueChanged(object sender, EventArgs e)
        {
            rentdate = dateRent.Value;
        }
        private void dateReturn_ValueChanged(object sender, EventArgs e)
        {
            returndate = dateReturn.Value;
        }


        //is date valid
        private bool CheckDateValid(DateTime rentdate, DateTime returndate)
        {
            if (returndate<rentdate)
            {
                return false;
            }
            else if (returndate == rentdate)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        //get rental duration
        private int GetRentDays(DateTime rentdate, DateTime returndate)
        {
            var difference = returndate - rentdate;
            int rentalDuration = difference.Days;
            return rentalDuration + 1;
        }

        //set car price
        private void cboxModel_SelectedIndexChanged(object sender, EventArgs e)
        {

            //get car collection
            ComboBox.ObjectCollection carCollection = cboxModel.Items;

            if (cboxModel.SelectedItem == carCollection[0])
            {
                tboxCarprice.Text = "40лв.";
            }
            else if (cboxModel.SelectedItem == carCollection[1])
            {
                tboxCarprice.Text = "35лв.";
            }
            else if (cboxModel.SelectedItem == carCollection[2])
            {
                tboxCarprice.Text = "30лв.";
            }
            else if (cboxModel.SelectedItem == carCollection[3])
            {
                tboxCarprice.Text = "50лв.";
            }
            else if (cboxModel.SelectedItem == carCollection[4])
            {
                tboxCarprice.Text = "60лв.";
            }
            else if (cboxModel.SelectedItem == carCollection[5])
            {
                tboxCarprice.Text = "55лв.";
            }
        }

        //check if there is payway selected
        private bool CheckPayway()
        {
            if (rbuttonBank.Checked == true || rbuttonCard.Checked == true || rbuttonCash.Checked == true)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        // BUTTON EVENTS

        //sum button
        private void button1_Click(object sender, EventArgs e)
        {
            if (CheckPayway() == true)
            {
                lblPayError.Visible = false;

                if (CheckDateValid(rentdate, returndate) == true)
                {
                    lblDateError.Visible = false;
                    sum = 0;

                    //get car collection
                    ComboBox.ObjectCollection carCollection = cboxModel.Items;

                    //add car price to the sum
                    if (cboxModel.SelectedItem == carCollection[0])
                    {
                        sum = sum + 40 * GetRentDays(rentdate, returndate);
                    }
                    else if (cboxModel.SelectedItem == carCollection[1])
                    {
                        sum = sum + 35 * GetRentDays(rentdate, returndate);
                    }
                    else if (cboxModel.SelectedItem == carCollection[2])
                    {
                        sum = sum + 30 * GetRentDays(rentdate, returndate);
                    }
                    else if (cboxModel.SelectedItem == carCollection[3])
                    {
                        sum = sum + 50 * GetRentDays(rentdate, returndate);
                    }
                    else if (cboxModel.SelectedItem == carCollection[4])
                    {
                        sum = sum + 60 * GetRentDays(rentdate, returndate);
                    }
                    else if (cboxModel.SelectedItem == carCollection[5])
                    {
                        sum = sum + 55 * GetRentDays(rentdate, returndate);
                    }

                    //add additional price to the sum
                    if (checkChair.Checked == true)
                    {
                        sum = sum + 40;
                    }
                    if (checkChains.Checked == true)
                    {
                        sum = sum + 45;
                    }
                    if (checkSkitrunk.Checked == true)
                    {
                        sum = sum + 30;
                    }

                    tboxSum.Text = $"{sum}лв.";
                }
                else
                {
                    lblDateError.Visible = true;
                }

            }
            else
            {
                lblPayError.Visible = true;
            }
        }
        //clear button
        private void btnClear_Click(object sender, EventArgs e)
        {
            tboxName.Clear();
            tboxLastname.Clear();
            tboxAdress.Clear();
            tboxNumber.Clear();
            tboxSum.Clear();
            cboxModel.ResetText();
            checkChains.Checked = false;
            checkChair.Checked = false;
            checkSkitrunk.Checked = false;
            rbuttonBank.Checked = false;
            rbuttonCard.Checked = false;
            rbuttonCash.Checked = false;
            dateRent.Value = DateTime.Now;
            dateReturn.Value = DateTime.Now;
            tboxCarprice.Clear();
            lblDateError.Visible = false;
        }
    }
}
