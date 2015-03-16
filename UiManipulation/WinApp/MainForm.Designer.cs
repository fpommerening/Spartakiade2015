namespace FP.Spartakiade2015.UiManipulation.WinApp
{
    partial class MainForm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tsmiCustomer = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiCustomerOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiUser = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiUserOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiCustomer,
            this.tsmiUser});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(284, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tsmiCustomer
            // 
            this.tsmiCustomer.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiCustomerOpen});
            this.tsmiCustomer.Name = "tsmiCustomer";
            this.tsmiCustomer.Size = new System.Drawing.Size(60, 20);
            this.tsmiCustomer.Text = "Kunden";
            // 
            // tsmiCustomerOpen
            // 
            this.tsmiCustomerOpen.Name = "tsmiCustomerOpen";
            this.tsmiCustomerOpen.Size = new System.Drawing.Size(152, 22);
            this.tsmiCustomerOpen.Text = "Öffnen";
            this.tsmiCustomerOpen.Click += new System.EventHandler(this.tsmiCustomerOpen_Click);
            // 
            // tsmiUser
            // 
            this.tsmiUser.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiUserOpen});
            this.tsmiUser.Name = "tsmiUser";
            this.tsmiUser.Size = new System.Drawing.Size(65, 20);
            this.tsmiUser.Text = "Benutzer";
            // 
            // tsmiUserOpen
            // 
            this.tsmiUserOpen.Name = "tsmiUserOpen";
            this.tsmiUserOpen.Size = new System.Drawing.Size(152, 22);
            this.tsmiUserOpen.Text = "Öffnen";
            this.tsmiUserOpen.Click += new System.EventHandler(this.tsmiUserOpen_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tsmiCustomer;
        private System.Windows.Forms.ToolStripMenuItem tsmiCustomerOpen;
        private System.Windows.Forms.ToolStripMenuItem tsmiUser;
        private System.Windows.Forms.ToolStripMenuItem tsmiUserOpen;
    }
}