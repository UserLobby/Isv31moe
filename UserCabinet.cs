using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp7.NewFolder1;

namespace WindowsFormsApp7
{
    public partial class UserCabinet : Form
    {
        int k = 1;
        public UserCabinet()
        {
            InitializeComponent();
            
        }
        public UserCabinet(Registration f)
        {
            InitializeComponent();
            f.BackColor = Color.Yellow;
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }


        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
           
        }

        private void button2_Click_1(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {
            
        }

        private void label3_Click_1(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        private void Output()
        {
            using (Model1 db = new Model1())
            {
                label2.Text = db.Product.Find(k).Title;
                label3.Text = db.Product.Find(k).ArticleNumber;
                label4.Text = db.Product.Find(k).MinCostForAgent.ToString();
                label5.Text = db.Product.Find(k).MinCostForAgent.ToString();
                label6.Text = db.Product.Find(k).Title;
                label7.Text = db.Product.Find(k).ArticleNumber;
                label8.Text = db.Product.Find(k).MinCostForAgent.ToString();
                label9.Text = db.Product.Find(k).MinCostForAgent.ToString();
                label10.Text = db.Product.Find(k).Title;
                label11.Text = db.Product.Find(k).ArticleNumber;
                label12.Text = db.Product.Find(k).MinCostForAgent.ToString();
                label13.Text = db.Product.Find(k).MinCostForAgent.ToString();
                label14.Text = db.Product.Find(k).Title;
                label15.Text = db.Product.Find(k).ArticleNumber;
                label16.Text = db.Product.Find(k).MinCostForAgent.ToString();
                label17.Text = db.Product.Find(k).MinCostForAgent.ToString();

            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            Output();
            using (var db = new Model1())
            {
                var counter = 0;
                foreach (var product in db.Product)
                {
                    counter++;
                    Label priceLabel;
                    Label nameLabel;
                    Label vendorCodeLabel;
                    Label materialsLabel;
                    PictureBox pictureBox;
                    if (counter == 1)
                    {
                        priceLabel = label5;
                        nameLabel = label2;
                        vendorCodeLabel = label3;
                        materialsLabel = label4;
                        pictureBox = pictureBox1;
                    }
                    else if (counter == 2)
                    {
                        priceLabel = label9;
                        nameLabel = label6;
                        vendorCodeLabel = label7;
                        materialsLabel = label8;
                        pictureBox = pictureBox2;
                    }
                    else if (counter == 3)
                    {
                        priceLabel = label13;
                        nameLabel = label10;
                        vendorCodeLabel = label11;
                        materialsLabel = label12;
                        pictureBox = pictureBox3;
                    }
                    else if (counter == 4)
                    {
                        priceLabel = label17;
                        nameLabel = label14;
                        vendorCodeLabel = label15;
                        materialsLabel = label16;
                        pictureBox = pictureBox4;
                    }
                    else
                    {
                        break;
                    }
                    priceLabel.Text = product.MinCostForAgent.ToString() + "P";
                    nameLabel.Text = $"{product.ProductType.Title} | {product.Title}";
                    vendorCodeLabel.Text = product.ArticleNumber.ToString();
                    materialsLabel.Text = "Материалы: " + String.Join(", ", product.ProductMaterial.Select(pm => { return pm.Material.Title; }).ToList());
                   if (product.Image != null)
                    {
                        pictureBox.Image = Image.FromFile(@"C:\Users\admin\Downloads" + product.Image);
                    }
                }
            }
            
        }

        private void Return_Click(object sender, EventArgs e)
        {
            Registration newForm1 = new Registration();
            newForm1.ShowDialog();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            k++;
            Output();
        }
    }
}
