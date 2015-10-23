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
        #region 杂

        private string scfilepathstr = null;


        public mainform()
        {
            InitializeComponent();
        }

        enum menustate
        {
            no_open_file = 0,
            edit_file = 1,
            start_demo = 2,

        }
        /// <summary>
        /// 根据软件状态更改菜单栏各项属性
        /// </summary>
        /// <param name="state"></param>
        private void menustatechange(menustate state)
        {
            switch (state)
            {
                case menustate.no_open_file:

                    break;
                case menustate.edit_file:

                    break;
                case menustate.start_demo:

                    break;
                default:

                    break;
            }
        }

        #endregion



        #region 菜单栏


        #region 文件
        private void 新建NToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void 打开OToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.InitialDirectory = Application.StartupPath;
            openFileDialog1.Filter = "scenario files (*.sc)|*.sc|All files (*.*)|*.*";
            openFileDialog1.FilterIndex = 1;
            openFileDialog1.RestoreDirectory = true;
            openFileDialog1.Multiselect = false;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                scfilepathstr = openFileDialog1.FileName;
                

            }


        }

        private void 保存SToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void 另存为AToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void 退出XToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }




        #endregion

        #region 编辑
        private void 建立模型ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            staticpara newmodeform = staticpara.createform();
            newmodeform.MdiParent = this;

            newmodeform.Show();
        }

        private void 参数修改ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            staticpara setparaform = staticpara.createform();
            setparaform.MdiParent = this;

            setparaform.Show();
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
            STK2D STK2Dform = STK2D.createform();
            STK2Dform.Show();
        }
        /// <summary>
        /// 3D窗口
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            STK3D STK3Dform = STK3D.createform();
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

        #endregion

    }
}
