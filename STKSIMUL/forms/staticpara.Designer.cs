namespace STKSIMUL
{
    partial class staticpara
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("主题颜色");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("主题", new System.Windows.Forms.TreeNode[] {
            treeNode1});
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("轨道");
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("卫星", new System.Windows.Forms.TreeNode[] {
            treeNode3});
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("轨迹");
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("飞机", new System.Windows.Forms.TreeNode[] {
            treeNode5});
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.SuspendLayout();
            // 
            // treeView1
            // 
            this.treeView1.Location = new System.Drawing.Point(12, 12);
            this.treeView1.Name = "treeView1";
            treeNode1.Name = "节点1";
            treeNode1.Text = "主题颜色";
            treeNode2.Name = "节点0";
            treeNode2.Text = "主题";
            treeNode3.Name = "节点4";
            treeNode3.Text = "轨道";
            treeNode4.Name = "节点3";
            treeNode4.Text = "卫星";
            treeNode5.Name = "节点7";
            treeNode5.Text = "轨迹";
            treeNode6.Name = "节点6";
            treeNode6.Text = "飞机";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode2,
            treeNode4,
            treeNode6});
            this.treeView1.Size = new System.Drawing.Size(125, 472);
            this.treeView1.TabIndex = 0;
            // 
            // staticpara
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(627, 496);
            this.Controls.Add(this.treeView1);
            this.Name = "staticpara";
            this.Text = "参数设置";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TreeView treeView1;
    }
}