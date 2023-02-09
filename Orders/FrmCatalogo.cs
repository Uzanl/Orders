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
            //pictureBox2.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
            //pictureBox2.Refresh();
            //vScrollBar1.Value = flowLayoutPanel1.VerticalScroll.Value;
            //vScrollBar1.Minimum = flowLayoutPanel1.VerticalScroll.Minimum;
            //vScrollBar1.Maximum = flowLayoutPanel1.VerticalScroll.Maximum;

            var orientation = SystemInformation.ScreenOrientation;
            //label1.Text = orientation.ToString();

            if (orientation.ToString() =="Angle0")
            {
                //this.Size = new Size(1920, 1080);
                flowLayoutPanel1.Size = new Size(1510, 600);
                flowLayoutPanel1.Location = new Point(210,240);
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

        private void vScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
           // flowLayoutPanel1.VerticalScroll.Value = vScrollBar1.Value;
        }
    }
}
