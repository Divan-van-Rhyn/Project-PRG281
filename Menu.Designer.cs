
namespace Project_PRG281
{
    partial class Menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.butNewOrder = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.butAddRemove = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.butDisplaySales = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.butLogOut = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
            this.menuToolStrip = new System.Windows.Forms.ToolStrip();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.menuToolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Project_PRG281.Properties.Resources.BC_Logo;
            this.pictureBox1.Location = new System.Drawing.Point(0, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(200, 115);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Control;
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Location = new System.Drawing.Point(12, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 118);
            this.panel2.TabIndex = 3;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Black;
            this.panel4.Location = new System.Drawing.Point(197, 413);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1234, 100);
            this.panel4.TabIndex = 8;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.Gold;
            this.panel6.Location = new System.Drawing.Point(12, 116);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(28, 397);
            this.panel6.TabIndex = 21;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Maroon;
            this.panel1.Controls.Add(this.panel7);
            this.panel1.Location = new System.Drawing.Point(12, 116);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 397);
            this.panel1.TabIndex = 20;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel7.Location = new System.Drawing.Point(50, 0);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(150, 889);
            this.panel7.TabIndex = 1;
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Margin = new System.Windows.Forms.Padding(0, 10, 0, 10);
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(1439, 6);
            // 
            // butNewOrder
            // 
            this.butNewOrder.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.butNewOrder.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.butNewOrder.Image = ((System.Drawing.Image)(resources.GetObject("butNewOrder.Image")));
            this.butNewOrder.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.butNewOrder.Name = "butNewOrder";
            this.butNewOrder.Size = new System.Drawing.Size(1439, 25);
            this.butNewOrder.Text = "New Order";
            this.butNewOrder.Click += new System.EventHandler(this.butNewOrder_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Margin = new System.Windows.Forms.Padding(0, 10, 0, 10);
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(1439, 6);
            // 
            // butAddRemove
            // 
            this.butAddRemove.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.butAddRemove.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.butAddRemove.Image = ((System.Drawing.Image)(resources.GetObject("butAddRemove.Image")));
            this.butAddRemove.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.butAddRemove.Name = "butAddRemove";
            this.butAddRemove.Size = new System.Drawing.Size(1439, 25);
            this.butAddRemove.Text = "Add + Remove + Update";
            this.butAddRemove.Click += new System.EventHandler(this.butAddRemove_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Margin = new System.Windows.Forms.Padding(0, 10, 0, 10);
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(1439, 6);
            // 
            // butDisplaySales
            // 
            this.butDisplaySales.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.butDisplaySales.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.butDisplaySales.Image = ((System.Drawing.Image)(resources.GetObject("butDisplaySales.Image")));
            this.butDisplaySales.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.butDisplaySales.Name = "butDisplaySales";
            this.butDisplaySales.Size = new System.Drawing.Size(1439, 25);
            this.butDisplaySales.Text = "Display Sales";
            this.butDisplaySales.Click += new System.EventHandler(this.butDisplaySales_Click);
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Margin = new System.Windows.Forms.Padding(0, 10, 0, 10);
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(1439, 6);
            // 
            // butLogOut
            // 
            this.butLogOut.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.butLogOut.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.butLogOut.Image = ((System.Drawing.Image)(resources.GetObject("butLogOut.Image")));
            this.butLogOut.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.butLogOut.Name = "butLogOut";
            this.butLogOut.Padding = new System.Windows.Forms.Padding(0, 10, 0, 10);
            this.butLogOut.Size = new System.Drawing.Size(1439, 45);
            this.butLogOut.Text = "Log Out";
            this.butLogOut.Click += new System.EventHandler(this.butLogOut_Click);
            // 
            // toolStripSeparator7
            // 
            this.toolStripSeparator7.Name = "toolStripSeparator7";
            this.toolStripSeparator7.Size = new System.Drawing.Size(1439, 6);
            // 
            // menuToolStrip
            // 
            this.menuToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSeparator1,
            this.butNewOrder,
            this.toolStripSeparator2,
            this.butAddRemove,
            this.toolStripSeparator4,
            this.butDisplaySales,
            this.toolStripSeparator6,
            this.butLogOut,
            this.toolStripSeparator7});
            this.menuToolStrip.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.VerticalStackWithOverflow;
            this.menuToolStrip.Location = new System.Drawing.Point(0, 0);
            this.menuToolStrip.Name = "menuToolStrip";
            this.menuToolStrip.Size = new System.Drawing.Size(1441, 272);
            this.menuToolStrip.TabIndex = 2;
            this.menuToolStrip.Text = "toolStrip1";
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1441, 564);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.menuToolStrip);
            this.Name = "Menu";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Menu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.menuToolStrip.ResumeLayout(false);
            this.menuToolStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton butNewOrder;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton butAddRemove;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripButton butDisplaySales;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripButton butLogOut;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator7;
        private System.Windows.Forms.ToolStrip menuToolStrip;
    }
}