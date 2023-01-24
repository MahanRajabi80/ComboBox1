using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ComboBox1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            object[] ostan = { "ilam", "Tehran", "Mazandaran", "Gilan", "Golestan" };
            cmBoxOstan.Items.AddRange(ostan);
        }

        private void cmBoxOstan_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmBoxCity.Items.Clear();
            switch (cmBoxOstan.SelectedItem.ToString())
            {
                case "ilam":
                    cmBoxCity.Items.Add("ilam");
                    break;
                case "Tehran":
                    cmBoxCity.Items.Add("Tehran");
                    cmBoxCity.Items.Add("Rodehen");
                    cmBoxCity.Items.Add("Damavand");
                    break;
                case "Mazandaran":
                    cmBoxCity.Items.Add("Babol");
                    cmBoxCity.Items.Add("Sari");
                    break;
                case "Gilan":
                    cmBoxCity.Items.Add("Rasht");
                    cmBoxCity.Items.Add("Masole");
                    cmBoxCity.Items.Add("Anzali");
                    break;
                case "Golestan":
                    cmBoxCity.Items.Add("Gorgan");
                    cmBoxCity.Items.Add("Bandar Torkman");
                    break;
            }
            cmBoxCity.SelectedIndex = 0;
        }
    }
}
