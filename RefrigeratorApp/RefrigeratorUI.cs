using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RefrigeratorApp
{
    public partial class RefrigeratorUI : Form
    {

        Refrigerator refrigeratorObj=new Refrigerator();
        public RefrigeratorUI()
        {
            InitializeComponent();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            refrigeratorObj.maxWeight = Convert.ToDouble(meximumWieghTextBox.Text);

            MessageBox.Show("Your weight is saved");
        }

        private void enterButton_Click(object sender, EventArgs e)
        {
            refrigeratorObj.noOfItem = Convert.ToInt16(NoOfItemTextBox.Text);

            refrigeratorObj.weightPerItem = Convert.ToDouble(weightPerItemTextBox.Text);

            refrigeratorObj.TotalWeight();


            currentWeightTextBox.Text = Convert.ToString(refrigeratorObj.GetCurrentWeight());

            remainingWeightTextBox.Text = Convert.ToString(refrigeratorObj.GetRemainingWeight());


        }
    }
}
