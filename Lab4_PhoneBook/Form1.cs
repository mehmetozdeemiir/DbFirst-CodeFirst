using Lab4_PhoneBook.Context;
using Lab4_PhoneBook.Entities.Concrete;
using Lab4_PhoneBook.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab4_PhoneBook
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Islemler.ListOfCategories(dataGridView1);
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            Islemler.Ekle(txtaddNameSurname, txtAddPhoneNumber,dataGridView1,grpAdd);
            
        
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            
            Islemler.Guncelle(txtUpdateNameSurname, txtUpdatePhoneNumber, dataGridView1,grpUpdate);
        }
     
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Islemler.KayitSatiriSec(dataGridView1,txtUpdateNameSurname,txtUpdatePhoneNumber);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            Islemler.Sil(grpDelete ,dataGridView1 );
        }
    }
}
