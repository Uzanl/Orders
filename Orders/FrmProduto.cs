using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Orders
{
    public partial class FrmProduto : Form
    {
        public FrmProduto()
        {
            InitializeComponent();
        }

        private void DynamicButton_Click(object sender, EventArgs e)

        {
            //FrmProduto p = new FrmProduto();
            //p.Owner = this;
            //p.ShowDialog();
        }

        private void btnProvisorio_Click(object sender, EventArgs e)
        {

            // Create a Button object 
            Button dynamicButton = new Button();



            // Set Button properties
            dynamicButton.Height = 300;
            dynamicButton.Width = 292;
            // dynamicButton.BackColor = Color.Red;
            //dynamicButton.ForeColor = Color.Blue;
            // dynamicButton.Location = new Point(20, 150);
            // dynamicButton.Text = "I am Dynamic Button";
            // dynamicButton.Name = "DynamicButton";
            // dynamicButton.Font = new Font("Georgia", 16);
            // Add a Button Click Event handler
            dynamicButton.Click += new EventHandler(DynamicButton_Click);
            // Add Button to the Form. Placement of the Button

            // will be based on the Location and Size of button

            flowLayoutPanel1.Controls.Add(dynamicButton);
        }
    }
}
