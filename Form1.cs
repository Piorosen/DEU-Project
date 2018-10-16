using DEU_Project.Server;
using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DEU_Project
{
    public partial class Form1 : MaterialForm
    {
        private readonly MaterialSkinManager materialSkinManager;
        public Form1()
        {
            InitializeComponent();

            // Initialize MaterialSkinManager
            materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);
        }

        List<Item> PrimeItems = new List<Item>();
        List<Item> DapItems = new List<Item>();

        private void Form1_Load(object sender, EventArgs e)
        {
            PrimeSite site = new PrimeSite();
            DapSite dapsite = new DapSite();
            PrimeItems = site.GetSite();
            DapItems = dapsite.GetSite();

            foreach (var item in PrimeItems)
            {
                var str = new[] { item.Title, item.Date };
                ListView.Items.Add(new ListViewItem(str));
            }

            foreach (var item in DapItems)
            {
                var str = new[] { item.Title, item.Date };
                DapListview.Items.Add(new ListViewItem(str));
            }
        }
        
        private void ListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            var w = (sender as ListView).SelectedItems;
            if (w.Count == 0)
                return;
            var item = (from c in PrimeItems where c.Title == w[0].Text select c).First();
            System.Diagnostics.Process.Start(item.Link);
        }

        private void DapListview_SelectedIndexChanged(object sender, EventArgs e)
        {
            var i = (sender as ListView).SelectedItems;
            if (i.Count == 0)
                return;
            var item = (from c in DapItems where c.Title == i[0].Text select c).First();
            System.Diagnostics.Process.Start("https://dap.deu.ac.kr/" + item.Link);
        }

    }
}
