using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ExamUI
{
    public partial class Create : Form
    {
        private readonly List<ExamDetails> _examDetailsList = new List<ExamDetails>(); 
        private readonly ExamDetails _examDetails = null;
        public string UnitCode;
        public bool IsAdd = true;

        public Create()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Either create a new unit or load one which already exists.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            
            var test = new TestCreate();
 
                var testMenu =  new TestMenu();

                UnitCode = txtUName.Text;

                if (txtUName.Text == null)
                    MessageBox.Show(@"Please enter a unit code");
                else if (IsAdd)
                    test.Show();
                else if (!IsAdd)
                {
                    _examDetails.LoadFromFile("Exams.xml", _examDetailsList);
                    testMenu.Show();
                }
        }
    }
}
