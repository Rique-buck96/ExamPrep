using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace ExamUI
{
    public partial class TestCreate : Form
    {
        private readonly List<ExamDetails> _examDetailList = new List<ExamDetails>();
        private readonly ExamDetails _examDetails = new ExamDetails();
        private readonly Create _create = new Create();

        public TestCreate()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Register Question, Answers and Keywords
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAddQuestion_Click(object sender, EventArgs e)
        {
            
            _examDetails.Question = rtxtQestion.Text;
            _examDetails.UnitCode = _create.UnitCode;
            _examDetails.Keywords = lstKeywords.Items.Cast<string>().ToList();

            if (_examDetails == null) return;

            _examDetails.SaveFile("Exams.xml", _examDetailList);

            rtxtAnswer.Clear();
            rtxtQestion.Clear();
            lstKeywords.Items.Clear();
        }

        /// <summary>
        /// Add keywords
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAddKWords_Click(object sender, EventArgs e)
        {
            lstKeywords.Items.Add(txtKey.Text);
            txtKey.Clear();
        }

        /// <summary>
        /// Navigate back
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnBack_Click(object sender, EventArgs e)
        {
            var testMenu = new TestMenu();

            testMenu.Show();
            Hide();
        }
    }
}
