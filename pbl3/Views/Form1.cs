using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pbl3
{
    public partial class main : Form
    {
        public main()
        {
            InitializeComponent();
        }
        internal static List<byte> typePages = new List<byte>();
        //public void ThemTabPages(UserControl uct,byte typeControl,AutoCompleteStringCollection tenTab)
        //{// kt tồn tại trang này chưa
        //    for(int i = 0; i < tabHienthi.TabPages.Count; i++) {
        //        if (tabHienthi.TabPages[i].Contains(uct) == true) {
        //            tabHienthi.SelectedTab= tabHienthi.TabPages[i];
        //            return;
        //        }
        //    }
        //    TabPage tab= new TabPage();
        //    typePages.Add(typeControl);
        //    tab.Name =uct.Name;
        //    tab.Size = tabHienthi.Size;
        //   // tab.Text = tenTab;
        //    tabHienthi.TabPages.Add(tab);
        //    tabHienthi.SelectedTab = tab;
        //    uct.Dock = DockStyle.Fill;
        //    tab.Controls.Add(uct);
        //    uct.Focus();

        //}
        ////Đóng tab hiện tại
        //public void DongTabHienTai()
        //{
        //    tabHienthi.TabPages.Remove(tabHienthi.SelectedTab);
        //}
        //public void DongAllTab()
        //{
        //    while (tabHienthi.TabPages.Count > 0) {
        //        DongTabHienTai();
        //    }
        //    }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dr= MessageBox.Show("BAN CO MUON THOAT","Xac nhan",MessageBoxButtons.OKCancel,MessageBoxIcon.Question);
            if(dr == DialogResult.OK) {
                this.Close();
            }
            else  return; 
        }

    }
}
