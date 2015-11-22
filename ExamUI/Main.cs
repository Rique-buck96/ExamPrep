using System;
using System.Windows.Forms;

namespace ExamUI
{
    public partial class Main : Form
    {
        readonly Create _create = new Create();

        public Main()
        {
            InitializeComponent();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            _create.Show();
            Hide();
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            _create.IsAdd = false;
            _create.Show();
            Hide();
        }
    }
}
