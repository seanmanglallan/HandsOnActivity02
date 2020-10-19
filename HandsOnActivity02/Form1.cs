using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HandsOnActivity02
{
    public partial class frmAddProduct : Form
    {
        public frmAddProduct()
        {
            InitializeComponent();
        }

        private string _ProductName;
        private string _Category;
        private string _MfgDate;
        private string _ExpDate;
        private string _Description;
        private int _Quantity;
        private double _SellPrice;

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void frmAddProduct_Load(object sender, EventArgs e)
        {

        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            string[] ListOfProductCategory = new string[] {

                "Beverages",
                "Bread/Bakery",
                "Canned/Jarred Goods",
                "Dairy",
                "Frozen Goods",
                "Meat",
                "Personal Care",
                "Other"
            };

             foreach (string variableName in arrayName)
            {
                comboBox.Items.Add(variableName);
            }

            public string Product_Name(string name)
            {
                if (!Regex.IsMatch(name, @"^[a-zA-Z]+$"))
                    //Exception here
                    return name;
            }
            public int Quantity(string qty)
            {
                if (!Regex.IsMatch(qty, @"^[0-9]"))
                    //Exception here
                    return Convert.ToInt32(qty);
            }
            public double SellingPrice(string price)
            {
                if (!Regex.IsMatch(price.ToString(), @"^(\d*\.)?\d+$"))
                    //Exception here
                    return Convert.ToDouble(price);
            }

            _ProductName = Product_Name(txtProductName.Text);
            _Category = cbCategory.Text;
            _MfgDate = dtPickerMfgDate.Value.ToString("yyyy-MM-dd");
            _ExpDate = dtPickerExpDate.Value.ToString("yyyy-MM-dd");
            _Description = richTxtDescription.Text;
            _Quantity = Quantity(txtQuantity.Text);
            _SellPrice = SellingPrice(txtSellPrice.Text);
            showProductList.Add(new ProductClass(_ProductName, _Category, _MfgDate,
            _ExpDate, _SellPrice, _Quantity, _Description)); gridViewProductList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill; gridViewProductList.DataSource = showProductList;



        }
    }
}
