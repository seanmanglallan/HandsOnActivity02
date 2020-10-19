using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnActivity02
{
    class ProductClass
    {
        private int _Quantity; private double _SellingPrice;
        private string _ProductName, _Category, _ManufacturingDate, _ExpirationDate, _Description;

        public ProductClass(string ProductName, string Category, string MfgDate, string ExpDate, double Price, int Quantity, string Description)
        {
            this._Quantity = Quantity; this._SellingPrice = Price; this._ProductName = ProductName; this._Category = Category; this._ManufacturingDate = MfgDate; this._ExpirationDate = ExpDate; this._Description = Description;
        }
        public string productName
        {
            get
            {
                return this._ProductName;
            }
            set
            {
                this._ProductName = value;
            }
        }
        public string category
        {
            get
            {

            }
            set
            {

            }
        }
 


return this._Category;




this._Category = value;
 
public string manufacturingDate
        {

            get
            {

            }
            set
            {

            }
        }
 



return this._ManufacturingDate;




this._ManufacturingDate = value;
 
public string expirationDate
        {

            get
            {

            }
            set
            {

            }
        }
 



return this._ExpirationDate;




this._ExpirationDate = value;
 
public string description
        {

            get
            {

            }
            set
            {

            }
        }
 



return this._Description;




this._Description = value;
 
public int quantity
        {

            get
            {

            }
            set
            {
                this._Quantity = value;
            }
        }
        public double sellingPrice
        {
            get
            {
                return this._SellingPrice;
            }
            set
            {
                this._SellingPrice = value;
            }
        }

    }
}
