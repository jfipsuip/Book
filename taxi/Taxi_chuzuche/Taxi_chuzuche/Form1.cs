using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ExcelDataReader;

namespace Taxi_chuzuche
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void 文件ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void 打开ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
        DataTableCollection tableCollection;
        private void 输入数据ToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void 退出ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cbosheet_SelectedIndexChanged(object sender, EventArgs e)
        {
          
        }

        private void dataGridviews1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void 打卡ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// 读取Excel文件
        ///
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void excel格式ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            dataGridView1.Rows.Clear();
            dataGridView1.Columns.Clear();
            OpenFileDialog file = new OpenFileDialog();
            file.Filter = "Excel文件1|*.xls|Excel文件2|*.xlsx";
            if (file.ShowDialog() == DialogResult.OK)
            {
                string fname = file.FileName;
                string strSource = @"provider=Microsoft.ACE.OLEDB.12.0;" + "Data Source=" + fname + ";Extended Properties='Excel 8.0;HDR=Yes;IMEX=1'";
                OleDbConnection conn = new OleDbConnection(strSource);
                string sqlstring = @"SELECT * FROM [Sheet1$]";
                OleDbDataAdapter adapter = new OleDbDataAdapter(sqlstring, conn);
                DataSet da = new DataSet();
                adapter.Fill(da);
                dataGridView1.DataSource = da.Tables[0];
            }
            else
            { return; }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
        /// <summary>
        /// 读取txt文件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
       
}
