using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.SqlServer;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab1_DatabaseFirst_Example
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        NorthwindEntities db = new NorthwindEntities();
     

      

        private void button1_Click(object sender, EventArgs e)
        {
            //ToList()=> Metodu veritabanında bulunan tablodaki tüm veriyi herhangi bir şartta bakmaksızıın ram ın heap alanına cıkarır genellikle uygulama tarafnda veri tabanında bulunan varlıgın yani tablonun uygulama tarafındaki yansıması tipinde bir generic liste otusturması için kullanılır
            //select* from categories ile aynı alttaki kod

            dataGridView1.DataSource = db.Categories.ToList();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            //where()--> Veritabanımızdki tablolar üzerinde belirli filtrelemeler yapmaya saglar sartlar dogrultusunda. 
            dataGridView1.DataSource = db.Products.Where(x => x.UnitPrice > 20).ToList();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //Tsql deki mantık buradada kullanılmaktadır sorgu sonucunda donen generic list üzerine sıralama islemleri yapar default "asc" dir. descendig islemi icin ayrıca bir method bulunmaktadır

            //ascendig 
            //dataGridView1.DataSource = db.Products.OrderBy(x => x.ProductName).ToList();

            //Ürünleri birim fiyatına göre coktan aza sıralayarak ürünerin Id,Urun adını , stok miktarını ve birim fiyat bilgilerini getiriniz.
            dataGridView1.DataSource = db.Products.OrderByDescending(x => x.UnitPrice).Select(x => new
            {
                x.ProductID,
                x.ProductName,
                x.UnitsInStock,
                x.UnitPrice
            }).ToList();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = db.Products.GroupBy(x => x.Category.CategoryName).Select(x => new
            {
                KategoriAdi = x.Key,
                ToplamStok = x.Sum(z => z.UnitsInStock)
            }
                ).ToList();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            //Select 
            //Customer companyname, phone ve adress bilgilerini getiriniz

            dataGridView1.DataSource = db.Customers.Select(x => new
            {
                x.CompanyName, //ismini vermesekde olur veredebiliriz istediğimiz ismide verebiliriz.
                yetkili = x.CompanyName,
                telefon = x.Phone,
                adres = x.Address


            }).ToList();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            //first ()=> bir koleksiyonda sorgu sonucunda bize dönen veri kösesindeki ilk elemanı secmek icin kullanılmaktadır dikkat: null gelirse uygulama patlar ona göre try catch yada if bloklarıyla ile gerekli kontrol mekanzmaları kurulmak zorundadır tsql deki top komutuna benzetebiliriz.

            //first metodunu kullanırken su hususa dikkat etmek gerekir first methodu içerisine parametre girmezsek sorgu sonucunda bize dönen kümesinin ilk satırı bize default doner 
            Category category = db.Categories.First();
            MessageBox.Show("Bana şart vermedin sorgu sonuucunda dönen ilk satırı getirdim :" + category.CategoryName);
            //lakin bir sart belirtirek ssart sonucunda donen sorgu kümesindeki ilk satırı doner
            Category category_1 = db.Categories.First(x => x.CategoryID > 7);
            MessageBox.Show("Category ıd si 7 den büyük olan ilk category :" + category_1.CategoryName);
            //first methodu ile tolist() metodu ile kullanılmz cunku first methodu tek bir veri satırı döner bu yüzden ToList() kullanılmaz. 

            //Category category_2 = db.Categories.First(x => x.CategoryID > 10);
            //MessageBox.Show("Category ıd si 10 den büyük olan ilk category :" + category_2.CategoryName);
            //yukarıda ki sorgu patlıyo cunku database de 11 nolu bir ıd bulunmamaktadır. asagıda try catc ile kontrol edelim

            try
            {
                Category category_2 = db.Categories.First(x => x.CategoryID > 10);
                MessageBox.Show("Category ıd si 10 den büyük olan ilk category :" + category_2.CategoryName);
            }
            catch (Exception)
            {

                MessageBox.Show("Aradıgınız kategory  bulunamamaktadır...!!");
            }

        }

        private void button7_Click(object sender, EventArgs e)
        {
            //FirstOrDefault()=> first ile aynı kullanıma sahipir farklı olarak first methodu null deger geldıgında patlamaktaydı firstordefault bu hatayı yaşamıyor direk değer yoksa null dönmektedir. yani şart sağlamadıgında patlamak yerine Null dönüyor

            Category category = db.Categories.FirstOrDefault(x => x.CategoryID > 7);

            if (category == null)
            {
                MessageBox.Show("aradıgınız kategory bulunamamaktadır");
            }
            else
            {
                MessageBox.Show("aradıgınız kategory " + category.CategoryName);
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            //Find()=>SQL server üzerinde veriitabanı işlemleri incelerken identity key (ID) oldugunu ogrenmıssınızdır id oldugunu tek bir kayıtı temsil ettiğini unutmayın eğer bir tek kayıt erişmek istersek 
            //ıd den yararlnmamız cok olağandır  ve bu bağlamda find methodunu kullanabiliriz

            Employee employee = db.Employees.Find(1);
            if (employee == null)
            {
                MessageBox.Show("Aradığınız çalışan bulunamamaktadır..");

            }
            else
            {
                MessageBox.Show("Aradığınız calısanın adı :" + employee.FirstName);
            }

            //Kategori ve tedarikci id si 1 olan ürüneri isimlerine göre tersten sıralayınız

            dataGridView1.DataSource = db.Products.Where(x => x.CategoryID == 1 && x.SupplierID == 1).OrderByDescending(x => x.ProductName).ToList();

        }

        private void button10_Click(object sender, EventArgs e)
        {
            //Take() => metodu tsql sorgulam dilindeki top komutunun karşılığıdır diyebiliriz. sorgu sonucunda bize dönen küme üzerinden istediğimiz kadar satırı ekrana yazdırmamızı saglar.
            //product tablosundaki ürünleri unitprice göre coktan aza sıralaayınız ilk 5 ürün ıd ,product name ,unit price unitsınstock ilgilerini getirin

            dataGridView1.DataSource = db.Products.OrderByDescending(x => x.UnitPrice).Select(x => new
            {
                x.ProductID,
                x.ProductName,
                x.UnitPrice,
                x.UnitsInStock
            }).Take(5).ToList();


            /* 
              dataGridView1.DataSource = db.Products.Select(x=> new
            {

              x.ProductID,
                x.ProductName,
                x.UnitPrice,                                        Bu bir diğer hali.
                x.UnitsInStock            
            }).OrderByDescending(x=>x.UnitPrice).Take(5).ToList();
  
             
             */
        }

        private void button11_Click(object sender, EventArgs e)
        {
            //Sorgu sonucunda dönen sonuç kümesi üzerinde , methodun parametresine verilen değer kadar satırı görmezden gelir.
            //Product tablosundaki ürünleri UnitInStock bilgisine göre cokan aza sıralayınız dönen sonuç kümesi içerisinden 10 ve 20 satır arasındaki ürülerin ıd sini ProdctName UnitInStock UnitPrice bilgilerini listeleyin

            dataGridView1.DataSource = db.Products.OrderByDescending(x => x.UnitsInStock).Select(x => new
            {
                x.CategoryID,
                x.ProductName,
                x.UnitsInStock,
                x.UnitPrice
            }).Skip(10).Take(10).ToList();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            //Belirli bir harf hece yada söz öbeğinin ilgili alanda yer alıp almadığını kontrol eder where metodu ile birlikte kullanılır

            //çalışanlarım ın isimleri içerisinde a harfi gecenlerii listeleyin
            dataGridView1.DataSource = db.Employees.Where(x => x.FirstName.Contains("a")).Skip(5).Take(5).ToList();
        }
     private void button13_Click(object sender, EventArgs e)
        {
            //Any methodunun iki farklı kullanım şekli bulunmaktadır. İlk kullanımı olan bir tabloda kayıt var mı yok mu kontrol edebilirsiniz ikinci kullanım ise tablodan verilen sartlara uygun kayıt var mı yok mu onu kontrol eder any metodunun geri donus tipi boolenan dır.

            bool sonuc = db.Categories.Any(x => x.CategoryName == "SeaFood");
            MessageBox.Show(sonuc.ToString());

            //seafood varsa true doncek
        }

        private void button14_Click(object sender, EventArgs e)
        {
            //Count()-->toplam sayı erişimi.
            int urunSayisi = db.Products.Count();
            MessageBox.Show("Toplam urun sayisi:");
        }

        private void button15_Click(object sender, EventArgs e)
        {
            //Toplam veren fonksiyon
            int? stok = db.Products.Sum(x => x.UnitsInStock);
            MessageBox.Show("Stok durum:" + stok);
        }

        private void button16_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = db.Employees.Select(x => new
            {
                adi = x.FirstName,
                soyadi = x.LastName,
                dogumTarihi = x.BirthDate,
                Yasi = SqlFunctions.DateDiff("Year", x.BirthDate, DateTime.Now)
            }).ToList();
        }
    }
    }

