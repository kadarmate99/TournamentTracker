using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TrackerLibrary.DataAccess;
using TrackerLibrary.Models;

namespace TrackerUI
{
    public partial class CreatePrizeForm : Form
    {
        private readonly IEnumerable<IDataConnection> _dataConnections;

        public CreatePrizeForm(IEnumerable<IDataConnection> dataConnections)
        {
            InitializeComponent();
            _dataConnections = dataConnections;
        }

        private void createPrizeButton_Click(object sender, EventArgs e)
        {
            if (IsCreatePrizeFormValid())
            {
                PrizeModel model = new PrizeModel
                    (
                    placeNameValue.Text,
                    placeNumberValue.Text,
                    prizeAmmountValue.Text,
                    prizePercentageValue.Text
                    );

                foreach (IDataConnection dataConnection in _dataConnections)
                {
                    dataConnection.CreatePrize(model);
                }

                // restore default values on from if validation was successfull
                placeNameValue.Text = "";
                placeNumberValue.Text = "";
                prizeAmmountValue.Text = "0";
                prizePercentageValue.Text = "0";
            }
            else
            {
                MessageBox.Show("This form has invalid information");
            }
        }

        private bool IsCreatePrizeFormValid()
        {
            bool isValid = true;

            // Validate place number
            int placeNumber = 0;
            bool isPlaceNumberValid = int.TryParse(placeNumberValue.Text, out placeNumber);
            if (string.IsNullOrWhiteSpace(placeNumberValue.Text)
                || isPlaceNumberValid == false
                || placeNumber < 1)
            {
                isValid = false;
            }

            // Validate prize amount and percentage
            decimal prizeAmmount = 0;
            bool isPrizeAmmountValid = decimal.TryParse(prizeAmmountValue.Text, out prizeAmmount);

            double prizePercentage = 0;
            bool isPrizePercentageValid = double.TryParse(prizePercentageValue.Text, out prizePercentage);

            if (isPrizeAmmountValid == false &&  isPrizePercentageValid == false)
            {
                isValid = false;
            }

            if ((prizeAmmount <= 0) && (prizePercentage <= 0)
                || (prizePercentage < 0 || prizePercentage > 0))
            {
                isValid = false;
            }

            return isValid;
        }
    }
}
