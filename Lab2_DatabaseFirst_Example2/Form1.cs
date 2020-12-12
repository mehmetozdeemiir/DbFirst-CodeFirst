using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab2_DatabaseFirst_Example2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        NorthwindEntities db = new NorthwindEntities();
        private void Form1_Load(object sender, EventArgs e)
        {


        }

        private void btnornek1_Click(object sender, EventArgs e)
        {
            //Product tablosundaki ProductID i cokan aza sıralayınız dönen sonuç kümesi içerisinden 35 ve 65 satır arasındaki ürünlerin  ProdctName, UnitInStock, UnitPrice, ve RoerderLevel bilgilerini listeleyin

            dataGridView1.DataSource = db.Products.OrderByDescending(x => x.ProductID).Select(x => new
            {
                x.ProductName,
                x.UnitsInStock,
                x.UnitPrice,
                x.ReorderLevel
            }).Skip(35).Take(30).ToList();
 
        }

        private void btnOrnek2_Click(object sender, EventArgs e)
        {
            //Select Sorgusu örneği Customer tablosundaki herşeyi getiriyorum select * from Customers gibi

            dataGridView1.DataSource = db.Customers.Select(x => new
            {
                CustomerID = x.CustomerID,
                ŞirketAdı = x.CompanyName,
                Bağlantıİsmi = x.ContactName,
                BağlantıBaşlık = x.ContactTitle,
                Adres = x.Address,
                Şehir = x.City,
                Bölge = x.Region,
                PostaKodu = x.PostalCode,
                Ülke = x.Country,
                TelefonNumarası = x.Phone,
                Faks=x.Fax
            }).ToList();
        
        
        
        
        }

        private void btnornek3_Click(object sender, EventArgs e)
        {
            //EmployeeID ve Shipvia si 1 olan ürüneri ShipCountry sine göre tersten sıralayınız
            dataGridView1.DataSource = db.Orders.Where(x => x.EmployeeID == 1 && x.ShipVia == 1).OrderBy(x => x.ShipCountry).ToList();
        }

        private void btnornek4_Click(object sender, EventArgs e)
        {
            //Product tablosundaki ProductId değeri 67 olanı getir null sa bildir

            Product products = db.Products.FirstOrDefault(x => x.ProductID > 66);
            if (products==null)
            {
                MessageBox.Show("Aradığını Bulamadın Booooooolum");
            }
            else
            {
                MessageBox.Show("Aradığınız 67.Değer:" + products.ProductName);
            }
        }

        private void btnornek5_Click(object sender, EventArgs e)
        {
            //Territories tablosunda RegionID=1 ve TerritoryDescriptions=New York olanları getir
            dataGridView1.DataSource = db.Territories.Where(x => x.RegionID == 1 && x.TerritoryDescription == "New York").ToList();
        
        }
    }
}
