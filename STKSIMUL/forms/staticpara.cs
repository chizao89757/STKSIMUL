using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace STKSIMUL
{
    public partial class staticpara : Form
    {
        private static staticpara defstaticpara;

        /// <summary>
        /// 将默认的构造函数私有化
        /// 实现单例模式
        /// </summary>
        /// <returns></returns>
        public static staticpara createform()
        {
            if ((defstaticpara == null) || (defstaticpara.IsDisposed == true))
            {
                defstaticpara = new staticpara();
            }
            return defstaticpara;
        }


        /// <summary>
        /// 生成函数
        /// </summary>
        private staticpara()
        {
            InitializeComponent();
        }



    }
}
