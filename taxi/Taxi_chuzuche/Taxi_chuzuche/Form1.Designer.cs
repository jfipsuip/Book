using System;

namespace Taxi_chuzuche
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.文件ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.打卡ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.excel格式ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.txt格式ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.保存ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.excel模式ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.txt模式ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.退出ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.绘制轨迹图ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.绘制轨迹点ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.文件ToolStripMenuItem,
            this.绘制轨迹图ToolStripMenuItem,
            this.绘制轨迹点ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 25);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 文件ToolStripMenuItem
            // 
            this.文件ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.打卡ToolStripMenuItem,
            this.保存ToolStripMenuItem,
            this.退出ToolStripMenuItem});
            this.文件ToolStripMenuItem.Name = "文件ToolStripMenuItem";
            this.文件ToolStripMenuItem.Size = new System.Drawing.Size(44, 21);
            this.文件ToolStripMenuItem.Text = "文件";
            this.文件ToolStripMenuItem.Click += new System.EventHandler(this.文件ToolStripMenuItem_Click);
            // 
            // 打卡ToolStripMenuItem
            // 
            this.打卡ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.excel格式ToolStripMenuItem,
            this.txt格式ToolStripMenuItem});
            this.打卡ToolStripMenuItem.Name = "打卡ToolStripMenuItem";
            this.打卡ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.打卡ToolStripMenuItem.Text = "打开";
            this.打卡ToolStripMenuItem.Click += new System.EventHandler(this.打卡ToolStripMenuItem_Click);
            // 
            // excel格式ToolStripMenuItem
            // 
            this.excel格式ToolStripMenuItem.Name = "excel格式ToolStripMenuItem";
            this.excel格式ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.excel格式ToolStripMenuItem.Text = "Excel格式";
            this.excel格式ToolStripMenuItem.Click += new System.EventHandler(this.excel格式ToolStripMenuItem_Click);
            // 
            // txt格式ToolStripMenuItem
            // 
            this.txt格式ToolStripMenuItem.Name = "txt格式ToolStripMenuItem";
            this.txt格式ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.txt格式ToolStripMenuItem.Text = "txt格式";
            this.txt格式ToolStripMenuItem.Click += new System.EventHandler(this.txt格式ToolStripMenuItem_Click);
            // 
            // 保存ToolStripMenuItem
            // 
            this.保存ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.excel模式ToolStripMenuItem,
            this.txt模式ToolStripMenuItem});
            this.保存ToolStripMenuItem.Name = "保存ToolStripMenuItem";
            this.保存ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.保存ToolStripMenuItem.Text = "保存";
            // 
            // excel模式ToolStripMenuItem
            // 
            this.excel模式ToolStripMenuItem.Name = "excel模式ToolStripMenuItem";
            this.excel模式ToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.excel模式ToolStripMenuItem.Text = "Excel模式";
            // 
            // txt模式ToolStripMenuItem
            // 
            this.txt模式ToolStripMenuItem.Name = "txt模式ToolStripMenuItem";
            this.txt模式ToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.txt模式ToolStripMenuItem.Text = "txt模式";
            // 
            // 退出ToolStripMenuItem
            // 
            this.退出ToolStripMenuItem.Name = "退出ToolStripMenuItem";
            this.退出ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.退出ToolStripMenuItem.Text = "退出";
            this.退出ToolStripMenuItem.Click += new System.EventHandler(this.退出ToolStripMenuItem_Click);
            // 
            // 绘制轨迹图ToolStripMenuItem
            // 
            this.绘制轨迹图ToolStripMenuItem.Name = "绘制轨迹图ToolStripMenuItem";
            this.绘制轨迹图ToolStripMenuItem.Size = new System.Drawing.Size(80, 21);
            this.绘制轨迹图ToolStripMenuItem.Text = "绘制轨迹图";
            // 
            // 绘制轨迹点ToolStripMenuItem
            // 
            this.绘制轨迹点ToolStripMenuItem.Name = "绘制轨迹点ToolStripMenuItem";
            this.绘制轨迹点ToolStripMenuItem.Size = new System.Drawing.Size(80, 21);
            this.绘制轨迹点ToolStripMenuItem.Text = "绘制轨迹点";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 28);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(240, 150);
            this.dataGridView1.TabIndex = 1;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(12, 184);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowTemplate.Height = 23;
            this.dataGridView2.Size = new System.Drawing.Size(240, 150);
            this.dataGridView2.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "出租车轨迹数据计算";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void txt格式ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 文件ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 保存ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 绘制轨迹图ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 退出ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 绘制轨迹点ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem excel模式ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem txt模式ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 打卡ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem excel格式ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem txt格式ToolStripMenuItem;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
    }
}

