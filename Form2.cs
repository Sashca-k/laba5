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
    public partial class Form2 : Form
    {
        public Model1 db { get; set; }
        public supp sr { get; set; }
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (sr == null)
            {
                sr = (supp)suppBindingSource.List[0];
                db.SaveChanges();
            }
            try
            {
                db.SaveChanges();
                DialogResult = DialogResult.OK;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка", ex.Message);
            }

        }


        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            if(sr == null)
            {
                suppBindingSource.AddNew();
                this.Text = "Добавление новый учетной записи ";

            }
            else
            {
                suppBindingSource.Add(sr);
                iDTextBox.ReadOnly = true;
                this.Text = "Корректировка учетной записи! " + sr.ID;
            }
        }
    }
}
