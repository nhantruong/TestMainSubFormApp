using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestApp.Forms
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        public bool IsLogin { get; private set; }
        public List<string> ProjectList { get; set; }
        private void Btn_Login_Click(object sender, EventArgs e)
        {
            IsLogin = true;
            ProjectList = GetData();
            this.Close();
        }

        private List<string> GetData()
        {
            List<string> items = new List<string>();
            for (int i = 0; i < 40; i++) items.Add("ProjectName " + i);
            return items;
        }
    }
}
