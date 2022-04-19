using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Taxi文件
{
    public partial class Form1 : Form
    {
        bool isTextChange = false;
        

        public Form1()
        {
            InitializeComponent();
        }

        private void 退出ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void 读入文件ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openfile = new OpenFileDialog();
            openfile.Title = "打开文件";                    //打开的文件的窗口标题
            openfile.Filter = "文本文件|*.txt|所有文件|*.*";
            if(openfile.ShowDialog() == DialogResult.OK)
            {
                //点击了对话框的打开文件，才要读取文件
                //txttext.text =  File.ReadLines(openfile.FileName)第一个是文本框的内容名字，后面是读取的东西，这个是一个简单方法
                //读取文件步骤
                //（1）读取一个文件首先声明一个文件流
                FileStream fs = new FileStream(openfile.FileName,FileMode.Open,FileAccess.Read,FileShare.Read);//Filemode表示这个文件六的功能的,fileshare表示这个文件打开时候其他能否打开这个文件
                //（2）。创建一个读写器)
                StreamReader sr = new StreamReader(fs,Encoding.UTF8);
                //(3)读操作
                //while(sr.EndOfStream == false） 单独读取一行选哟进行判断
                //{
                //string lines = sr.ReadLine();
                //textBox1.Text = textBox1.Text + LineS + "\r\n";
                //}

                textBox1.Text = sr.ReadToEnd();//读取到最后
                //(4)关闭读取器，关闭文件流对象
                sr.Close();
                fs.Close();
                isTextChange = false;
            }


        }

        private void 文件ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void 新建NToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void 帮助ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("这就是此次题目的解法！");
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            isTextChange = true;
        }

        private void 保存ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveText();
           
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(isTextChange == true)
            {
                DialogResult re = MessageBox.Show("文本文件已经改变是否保存", "询问", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                if(re == DialogResult.Yes)
                {
                    //需要保存,执行上面保存的代码就行
                    saveText();

                }
                else if(re == DialogResult.No)
                {
                    //不需要保存
                }
                else
                {
                    //取消关闭
                    e.Cancel = true;
                }
            }
        }
        /// <summary>
        /// 为了保存文件
        /// 
        /// </summary>
        protected void saveText()
        {
            SaveFileDialog savefile = new SaveFileDialog();
            savefile.Title = "保存文件";
            savefile.Filter = "文本文件|*.txt|所有文件|*.*";
            if (savefile.ShowDialog() == DialogResult.OK)
            {
                FileStream fs = new FileStream(savefile.FileName, FileMode.Create);//同样声明一个文件流对象
                //(2)写入器
                StreamWriter sw = new StreamWriter(fs, Encoding.Default);
                sw.WriteLine(textBox1);
                sw.Close();
                //
                fs.Close();
                isTextChange = false;
            }
        }

        private void 复制ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.Copy();
        }

        private void 剪贴ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.Cut();
        }

        private void 粘贴ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.Paste();
        }
    }
}
