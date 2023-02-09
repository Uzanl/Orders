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
    public partial class FrmCatalogo : Form
    {
        public FrmCatalogo()
        {
            InitializeComponent();
        }

        private void Catalogo_Load(object sender, EventArgs e)
        {         
            var orientation = SystemInformation.ScreenOrientation;
            int screenWidth = Screen.PrimaryScreen.Bounds.Width;
            int screenHeight = Screen.PrimaryScreen.Bounds.Height;

            if (orientation.ToString() =="Angle0")
            {
                int x = screenWidth - (screenWidth * 25 / 100), y = screenHeight - (screenHeight * 25 / 100);
                flowLayoutPanel1.Size = new Size(x,y);
                flowLayoutPanel1.Location = new Point((screenWidth/2) - (x/2),(screenHeight/2) - (y/2));
                btnProvisorio.Location = new Point(200, 300);
            }
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

     

        private void DynamicButton_Click(object sender, EventArgs e)

        {
            FrmProduto p = new FrmProduto();
            p.Owner = this;
            p.ShowDialog();
        }

        private void btnProvisorio_Click(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Add(new Button() { Text = "Button Name" });
        }

        private void btnProvisorio_Click_1(object sender, EventArgs e)
        {

            var orientation = SystemInformation.ScreenOrientation;
            int screenWidth = Screen.PrimaryScreen.Bounds.Width;
            int screenHeight = Screen.PrimaryScreen.Bounds.Height;

            
            // Create a Button object 
            Button dynamicButton = new Button();



            // Set Button properties
            int x = screenWidth - (screenWidth * 25 / 100), y = screenHeight - (screenHeight * 25 / 100);
            dynamicButton.Width = (x/ 5) - 10;
            dynamicButton.Height = (y / 3);

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

        private void vScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
           // flowLayoutPanel1.VerticalScroll.Value = vScrollBar1.Value;
        }
    }
}
