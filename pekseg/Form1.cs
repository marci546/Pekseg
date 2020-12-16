using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pekseg
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void bttn_pekaruHozza_Click(object sender, EventArgs e)
        {
            if (txt_pekaruNev.Text != "")
            {
                Pekaru pe = new Pekaru(txt_pekaruNev.Text, int.Parse(num_ar.Value.ToString()), checkBox_Laktoz.Checked);

                
                list_pekaru.Items.Add(pe);
            }
        }

        private void bttn_peksegHozz_Click(object sender, EventArgs e)
        {
            if (txt_peksegNev.Text != "")
            {
                Pekseg ps = new Pekseg(txt_peksegNev.Text, DateTime.Now);


                list_pekseg.Items.Add(ps);
            }
        }

        private void list_pekseg_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<Pekseg> peksegek = new List<Pekseg>();
            
            foreach (var pekseg in list_pekseg.Items)
            {
                peksegek.Add((Pekseg)pekseg);
            }

            list_peksegPekaru.Items.Clear();
            if (list_pekseg.SelectedIndex != -1 && peksegek[list_pekseg.SelectedIndex].Termekek != null)
            {
                foreach (var peksegPekaru in peksegek[list_pekseg.SelectedIndex].Termekek)
                {
                    list_peksegPekaru.Items.Add(peksegPekaru);
                }
            }
        }

        private void bttn_peksegPekaruHozz_Click(object sender, EventArgs e)
        {
            if (list_pekseg.SelectedIndex != -1 && list_pekaru.SelectedIndex != -1)
            {
                ((Pekseg)list_pekseg.SelectedItem).Termekek.Add((Pekaru)list_pekaru.SelectedItem);

                list_peksegPekaru.Items.Clear(); 
                foreach (var pekaru in ((Pekseg)list_pekseg.SelectedItem).Termekek) 
                {
                    list_peksegPekaru.Items.Add(pekaru);
                }
            }
        }

        private void bttn_pekaruTorol_Click(object sender, EventArgs e)
        {
            if (list_pekaru.SelectedIndex != -1) 
            {
                List<Pekseg> peksegek = new List<Pekseg>();

                foreach (var pekseg in peksegek)
                {
                    if (pekseg.Termekek.Contains(list_pekaru.Items[list_pekaru.SelectedIndex]))
                    {
                        pekseg.Termekek.Remove((Pekaru)list_pekaru.Items[list_pekaru.SelectedIndex]);
                    }
                }
                list_peksegPekaru.Items.Remove((Pekaru)list_pekaru.Items[list_pekaru.SelectedIndex]);
                list_pekaru.Items.RemoveAt(list_pekaru.SelectedIndex);
            }
        }
    }
}
