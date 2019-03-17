using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Accounter
{
    public partial class Form1 : Form
    {
        private AccounterWorkspace workspace;

        public Form1()
        { 
            InitializeComponent();
            workspace = Accounter.AccounterWorkspace.OpenWorkspace("./my_export.xml");


            summaryFromDateTime.Value = summaryFromDateTime.Value.AddMonths(-1);

            UpdateReport();
            UpdateSummary();
        }

       

        private void Form1_Load(object sender, EventArgs e)
        {
            this.importPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.summaryPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.reportPanel.Dock = System.Windows.Forms.DockStyle.Fill;
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }

        private void menuPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void switchOffAllHighlights()
        {
            this.importHighlightPanel.Visible = false;
            this.summaryHighlightPanel.Visible = false;
            this.reportHighlightPanel.Visible = false;
            this.exitHighlightPanel.Visible = false;
        }

        private void hideViewPanels()
        {
            this.importPanel.Visible = false;
            this.summaryPanel.Visible = false;
            this.reportPanel.Visible = false;
        }

        private void selectViewPanel(int i)
        {
            switch(i)
            {
                case 0:
                    this.importPanel.Visible = true;
                    this.summaryPanel.Visible = false;
                    this.reportPanel.Visible = false;
                    break;
                case 1:
                    this.summaryPanel.Visible = true;
                    this.importPanel.Visible = false;
                    this.reportPanel.Visible = false;
                    break;
                case 2:
                    this.reportPanel.Visible = true;
                    this.importPanel.Visible = false;
                    this.summaryPanel.Visible = false;
                    break;
            }
        }

        private void importButton_Click(object sender, EventArgs e)
        {
            switchOffAllHighlights();
            this.importHighlightPanel.Visible = true;
            this.selectViewPanel(0);


        }


        private void UpdateSummary()
        {
            DateTime from = this.summaryFromDateTime.Value;
            DateTime to = this.summaryToDateTime.Value;


            List<Transaction> trs = workspace.DataBase.GetTransactions(from, to);

            ListViewItem[] items = trs.Select(tr => new ListViewItem(tr.getStringArray())).ToArray();


            transactionListView.Items.Clear();
            transactionListView.Items.AddRange(items);

        }

        private void UpdateReport()
        {
            DateTime selectedMonth = this.reportDateTime.Value;
            CategoryNode root = workspace.GetFullCategoryReportTree(selectedMonth.Year, selectedMonth.Month);
            FillCategoryTreeView(this.categoryReport, root);
        }

        private void summaryButton_Click(object sender, EventArgs e)
        {
            switchOffAllHighlights();
            this.summaryHighlightPanel.Visible = true;
            this.selectViewPanel(1);


        }

        private void reportButton_Click(object sender, EventArgs e)
        {
            switchOffAllHighlights();
            this.reportHighlightPanel.Visible = true;
            this.selectViewPanel(2);

        }


        private void FillCategoryTreeNode(TreeNode node, CategoryNode elem, int level)
        {
            string label = string.Format("{0}    {1}", elem.Name, elem.Value);

            node.Text = label;
            if (level < 4)
                node.Expand();
            foreach(CategoryNode child in elem.Children)
            {
                FillCategoryTreeNode(node.Nodes.Add(""), child,level+1);
            }
        }

        private void FillCategoryTreeView(TreeView view, CategoryNode root)
        {
            view.BeginUpdate();
            view.Nodes.Clear();

            FillCategoryTreeNode(view.Nodes.Add("sum"), root, 0);

            view.ExpandAll();
            view.EndUpdate();

        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void reportDateTime_ValueChanged(object sender, EventArgs e)
        {
            UpdateReport();
        }

        private void summaryFromDateTime_ValueChanged(object sender, EventArgs e)
        {
            UpdateSummary();
        }

        private void summaryToDateTime_ValueChanged(object sender, EventArgs e)
        {
            UpdateSummary();
        }

        private void transactionListView_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void summaryGroupBox_Enter(object sender, EventArgs e)
        {
            
        }
    }
}
