using Lab4_PhoneBook.Context;
using Lab4_PhoneBook.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab4_PhoneBook.Entities.Concrete
{
    public class Islemler
    {
        static int id;
        public static void ListOfCategories(DataGridView dataGrid)
        {
           ProjectContext db = new ProjectContext();
            
            dataGrid.DataSource = db.Userss.Where(x => x.Status != Status.Passive).ToList();
        }


        public static void Ekle (TextBox txtUser,TextBox txtPhone,DataGridView dataGrid,GroupBox groupBox)
       {
           ProjectContext db = new ProjectContext();
            Users users = new Users();
            users.NameSurname = txtUser.Text;
            users.PhoneNumber = txtPhone.Text;
            users.CreateDate = DateTime.Now;
            db.Userss.Add(users);
            db.SaveChanges();
            ListOfCategories(dataGrid);
            Eraser(groupBox);
       }
     
        public static void Guncelle(TextBox txtupdateUser, TextBox txtupdatephone,DataGridView dataGrid,GroupBox groupBox)
        {
            
            ProjectContext db = new ProjectContext();
            Users users = new Users();
            users = db.Userss.FirstOrDefault(x => x.Id == id);
            users.NameSurname = txtupdateUser.Text;
            users.PhoneNumber = txtupdatephone.Text;
            users.ModifiedDate = DateTime.Now;
            users.Status = Status.Modified;
            db.SaveChanges();
            ListOfCategories(dataGrid);
            Eraser(groupBox);
        }

        public static void Sil(GroupBox groupBox,DataGridView dataGrid)
        {
            ProjectContext db = new ProjectContext();
            Users users = new Users();
            users = db.Userss.FirstOrDefault(x => x.Id == id);
            users.PassivedDate = DateTime.Now;
            users.Status = Status.Passive;
            db.SaveChanges();
            ListOfCategories(dataGrid);
            Eraser(groupBox);

        }

         public static void Eraser(GroupBox groupBox )
        {
            foreach (Control item in groupBox.Controls)
            {
                if (item is TextBox)
                {
                    item.Text = "";
                }
            }
        }
        

        
       public static void KayitSatiriSec(DataGridView dataGridView ,TextBox txtnmesrnme,TextBox txtphnnmbr)
        {

            id = Convert.ToInt32(dataGridView.CurrentRow.Cells["Id"].Value);
            txtnmesrnme.Text= dataGridView.CurrentRow.Cells["NameSurname"].Value.ToString();
            txtphnnmbr.Text= dataGridView.CurrentRow.Cells["PhoneNumber"].Value.ToString();

        } 
    
    }


}
