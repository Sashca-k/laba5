using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace suspliers
{
    public partial class Form1 : Form
    {
        Model1 db = new Model1();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            suppBindingSource.DataSource = db.supps.ToList();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 frm = new Form2();
            frm.sr = null;
            frm.db = db;
            DialogResult dr = frm.ShowDialog();
            

            if(dr == DialogResult.OK)
            {
                suppBindingSource.DataSource = db.supps.ToList();
            }
            try
            {
                db.SaveChanges();
                DialogResult = DialogResult.OK;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.InnerException.InnerException.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 frm = new Form2();
            supp sr = (supp)suppBindingSource.Current;
            frm.db = db;
            frm.sr = sr;

            DialogResult dr = frm.ShowDialog();
            if(dr == DialogResult.OK)
            {
                suppBindingSource.DataSource = db.supps.ToList();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            supp sr = (supp)suppBindingSource.Current;
            DialogResult dr = MessageBox.Show("Удалить учетную запись " + sr.ID + "?", "Удаление учетной записи", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            
            if(dr == DialogResult.Yes)
            {
                db.supps.Remove(sr);

                try
                {
                    db.SaveChanges();
                    suppBindingSource.DataSource = db.supps.ToList();
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.InnerException.InnerException.Message);
                }
            }
        }
    }
}
