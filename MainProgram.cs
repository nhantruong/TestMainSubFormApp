using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TestApp.Forms;

namespace TestApp
{
    public partial class MainProgram : Form
    {
        public bool IsLogin { get; set; }
        public List<string> ProjectList { get; private set; }

        public MainProgram()
        {
            InitializeComponent();
        }

        private void FrmLogin_FormClosed(object sender, FormClosedEventArgs e)
        {
            TreeNode login = new TreeNode("1. Login thành công");
            TreeView_Projects.Nodes.Add(login);
        }

        private void FrmLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            LblStatus.Text = "Login đang đóng Form";
        }

        private void Btn_NewProject_Click(object sender, EventArgs e)
        {
            TreeView_Projects.Nodes.Clear();
            NewProject frmNewProject = new NewProject();
            //frmNewProject.MdiParent = this;
            frmNewProject.Show(this);
            
        }

        private void MainProgram_Load(object sender, EventArgs e)
        {
            if (!IsLogin)
            {               
                this.Shown += MainProgram_Shown;                
            }
        }

        private void MainProgram_Shown(object sender, EventArgs e)
        {
            Login frmLogin = new Login();            
            frmLogin.ShowDialog();
            IsLogin = frmLogin.IsLogin;
            ProjectList = frmLogin.ProjectList;
            AddDataToTreeView(ProjectList);
        }

        private void AddDataToTreeView(List<string> projectList)
        {
            foreach (string item in projectList)
            {
                TreeView_Projects.Nodes.Add(item);
            }

        }

        private void Btn_GetData_Click(object sender, EventArgs e)
        {

        }
    }
}
