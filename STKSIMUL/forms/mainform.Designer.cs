﻿namespace STKSIMUL
{
    partial class mainform
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
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainform));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.文件FToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.新建NToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.打开OToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.保存SToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.另存为AToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.退出XToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.编辑EToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.建立模型ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.参数修改ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.工具TToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.窗口toolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.sIMULATIONToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.仿真ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.仿真控制ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.仿真参数设置ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.帮助HToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.关于AToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.帮助ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.文件FToolStripMenuItem,
            this.编辑EToolStripMenuItem,
            this.工具TToolStripMenuItem,
            this.窗口toolStripMenuItem,
            this.仿真ToolStripMenuItem,
            this.帮助HToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(754, 25);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 文件FToolStripMenuItem
            // 
            this.文件FToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.新建NToolStripMenuItem,
            this.打开OToolStripMenuItem,
            this.toolStripSeparator,
            this.保存SToolStripMenuItem,
            this.另存为AToolStripMenuItem,
            this.toolStripSeparator1,
            this.退出XToolStripMenuItem});
            this.文件FToolStripMenuItem.Name = "文件FToolStripMenuItem";
            this.文件FToolStripMenuItem.Size = new System.Drawing.Size(58, 21);
            this.文件FToolStripMenuItem.Text = "文件(&F)";
            // 
            // 新建NToolStripMenuItem
            // 
            this.新建NToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("新建NToolStripMenuItem.Image")));
            this.新建NToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.新建NToolStripMenuItem.Name = "新建NToolStripMenuItem";
            this.新建NToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.新建NToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.新建NToolStripMenuItem.Text = "新建(&N)";
            this.新建NToolStripMenuItem.Click += new System.EventHandler(this.新建NToolStripMenuItem_Click);
            // 
            // 打开OToolStripMenuItem
            // 
            this.打开OToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("打开OToolStripMenuItem.Image")));
            this.打开OToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.打开OToolStripMenuItem.Name = "打开OToolStripMenuItem";
            this.打开OToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.打开OToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.打开OToolStripMenuItem.Text = "打开(&O)";
            this.打开OToolStripMenuItem.Click += new System.EventHandler(this.打开OToolStripMenuItem_Click);
            // 
            // toolStripSeparator
            // 
            this.toolStripSeparator.Name = "toolStripSeparator";
            this.toolStripSeparator.Size = new System.Drawing.Size(162, 6);
            // 
            // 保存SToolStripMenuItem
            // 
            this.保存SToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("保存SToolStripMenuItem.Image")));
            this.保存SToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.保存SToolStripMenuItem.Name = "保存SToolStripMenuItem";
            this.保存SToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.保存SToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.保存SToolStripMenuItem.Text = "保存(&S)";
            this.保存SToolStripMenuItem.Click += new System.EventHandler(this.保存SToolStripMenuItem_Click);
            // 
            // 另存为AToolStripMenuItem
            // 
            this.另存为AToolStripMenuItem.Name = "另存为AToolStripMenuItem";
            this.另存为AToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.另存为AToolStripMenuItem.Text = "另存为(&A)";
            this.另存为AToolStripMenuItem.Click += new System.EventHandler(this.另存为AToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(162, 6);
            // 
            // 退出XToolStripMenuItem
            // 
            this.退出XToolStripMenuItem.Name = "退出XToolStripMenuItem";
            this.退出XToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.退出XToolStripMenuItem.Text = "退出(&X)";
            this.退出XToolStripMenuItem.Click += new System.EventHandler(this.退出XToolStripMenuItem_Click);
            // 
            // 编辑EToolStripMenuItem
            // 
            this.编辑EToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.建立模型ToolStripMenuItem,
            this.参数修改ToolStripMenuItem});
            this.编辑EToolStripMenuItem.Name = "编辑EToolStripMenuItem";
            this.编辑EToolStripMenuItem.Size = new System.Drawing.Size(59, 21);
            this.编辑EToolStripMenuItem.Text = "编辑(&E)";
            // 
            // 建立模型ToolStripMenuItem
            // 
            this.建立模型ToolStripMenuItem.Name = "建立模型ToolStripMenuItem";
            this.建立模型ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.建立模型ToolStripMenuItem.Text = "建立模型";
            this.建立模型ToolStripMenuItem.Click += new System.EventHandler(this.建立模型ToolStripMenuItem_Click);
            // 
            // 参数修改ToolStripMenuItem
            // 
            this.参数修改ToolStripMenuItem.Name = "参数修改ToolStripMenuItem";
            this.参数修改ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.参数修改ToolStripMenuItem.Text = "参数修改";
            this.参数修改ToolStripMenuItem.Click += new System.EventHandler(this.参数修改ToolStripMenuItem_Click);
            // 
            // 工具TToolStripMenuItem
            // 
            this.工具TToolStripMenuItem.Name = "工具TToolStripMenuItem";
            this.工具TToolStripMenuItem.Size = new System.Drawing.Size(59, 21);
            this.工具TToolStripMenuItem.Text = "工具(&T)";
            // 
            // 窗口toolStripMenuItem
            // 
            this.窗口toolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dToolStripMenuItem,
            this.dToolStripMenuItem1,
            this.sIMULATIONToolStripMenuItem,
            this.toolStripSeparator2});
            this.窗口toolStripMenuItem.Name = "窗口toolStripMenuItem";
            this.窗口toolStripMenuItem.Size = new System.Drawing.Size(44, 21);
            this.窗口toolStripMenuItem.Text = "窗口";
            // 
            // dToolStripMenuItem
            // 
            this.dToolStripMenuItem.Name = "dToolStripMenuItem";
            this.dToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.dToolStripMenuItem.Text = "2D";
            this.dToolStripMenuItem.Click += new System.EventHandler(this.dToolStripMenuItem_Click);
            // 
            // dToolStripMenuItem1
            // 
            this.dToolStripMenuItem1.Name = "dToolStripMenuItem1";
            this.dToolStripMenuItem1.Size = new System.Drawing.Size(153, 22);
            this.dToolStripMenuItem1.Text = "3D";
            this.dToolStripMenuItem1.Click += new System.EventHandler(this.dToolStripMenuItem1_Click);
            // 
            // sIMULATIONToolStripMenuItem
            // 
            this.sIMULATIONToolStripMenuItem.Name = "sIMULATIONToolStripMenuItem";
            this.sIMULATIONToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.sIMULATIONToolStripMenuItem.Text = "SIMULATION";
            this.sIMULATIONToolStripMenuItem.Click += new System.EventHandler(this.sIMULATIONToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(150, 6);
            // 
            // 仿真ToolStripMenuItem
            // 
            this.仿真ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.仿真控制ToolStripMenuItem,
            this.仿真参数设置ToolStripMenuItem});
            this.仿真ToolStripMenuItem.Name = "仿真ToolStripMenuItem";
            this.仿真ToolStripMenuItem.Size = new System.Drawing.Size(44, 21);
            this.仿真ToolStripMenuItem.Text = "仿真";
            // 
            // 仿真控制ToolStripMenuItem
            // 
            this.仿真控制ToolStripMenuItem.Name = "仿真控制ToolStripMenuItem";
            this.仿真控制ToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.仿真控制ToolStripMenuItem.Text = "仿真控制";
            // 
            // 仿真参数设置ToolStripMenuItem
            // 
            this.仿真参数设置ToolStripMenuItem.Name = "仿真参数设置ToolStripMenuItem";
            this.仿真参数设置ToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.仿真参数设置ToolStripMenuItem.Text = "仿真参数设置";
            // 
            // 帮助HToolStripMenuItem
            // 
            this.帮助HToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.关于AToolStripMenuItem,
            this.帮助ToolStripMenuItem});
            this.帮助HToolStripMenuItem.Name = "帮助HToolStripMenuItem";
            this.帮助HToolStripMenuItem.Size = new System.Drawing.Size(61, 21);
            this.帮助HToolStripMenuItem.Text = "帮助(&H)";
            // 
            // 关于AToolStripMenuItem
            // 
            this.关于AToolStripMenuItem.Name = "关于AToolStripMenuItem";
            this.关于AToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.关于AToolStripMenuItem.Text = "关于(&A)...";
            this.关于AToolStripMenuItem.Click += new System.EventHandler(this.关于AToolStripMenuItem_Click);
            // 
            // 帮助ToolStripMenuItem
            // 
            this.帮助ToolStripMenuItem.Name = "帮助ToolStripMenuItem";
            this.帮助ToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.帮助ToolStripMenuItem.Text = "帮助";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 465);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(754, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // mainform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(754, 487);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "mainform";
            this.Text = "SAR综合仿真演示系统";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 文件FToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 新建NToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 打开OToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator;
        private System.Windows.Forms.ToolStripMenuItem 保存SToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 另存为AToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem 退出XToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 编辑EToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 工具TToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 窗口toolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 仿真ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 帮助HToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 关于AToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem sIMULATIONToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 建立模型ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 参数修改ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 仿真控制ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 仿真参数设置ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 帮助ToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.StatusStrip statusStrip1;
    }
}

