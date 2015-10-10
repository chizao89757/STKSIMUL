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
using System.Collections;
using System.Diagnostics;


namespace STKSIMUL
{
    public partial class mainform : Form
    {
        public mainform()
        {
            InitializeComponent();
        }







        #region 文件
        private void 新建NToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void 打开OToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void 保存SToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void 另存为AToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void 退出XToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
        #endregion

        #region 编辑
        private void 建立模型ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            staticpara newmodeform = new staticpara();
            newmodeform.ShowDialog();
        }

        private void 参数修改ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            staticpara setparaform = new staticpara();
            setparaform.ShowDialog();
        }
        #endregion

        #region 工具

        #endregion

        #region 窗口
        /// <summary>
        /// 2D窗口
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dToolStripMenuItem_Click(object sender, EventArgs e)
        {
            STK2D STK2Dform = new STK2D();
            STK2Dform.Show();
        }
        /// <summary>
        /// 3D窗口
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            STK3D STK3Dform = new STK3D();
            STK3Dform.Show();
        }
        private void sIMULATIONToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SIMULATION simlationform = new SIMULATION();
            simlationform.Show();
        }
        #endregion

        #region 仿真

        #endregion

        #region 帮助
        private void 关于AToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutBox1 aboutbox = new AboutBox1();
            aboutbox.ShowDialog();
        }
        #endregion



    }
}
