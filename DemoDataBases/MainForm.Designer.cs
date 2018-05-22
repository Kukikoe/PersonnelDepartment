namespace DemoDataBases
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
            this.listViewOfDepartment = new System.Windows.Forms.ListView();
            this.FirstName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.LastName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Sername = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Birthday = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Position = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.OrderNumberOfEmployment = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.OrderNumberOfDismissal = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Photo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.AddToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removePersonToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.watchTableToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addNewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addNewUser1 = new DemoDataBases.AddNewUser();
            this.addPerson1 = new DemoDataBases.AddPerson();
            this.removeRerson1 = new DemoDataBases.RemoveRerson();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // listViewOfDepartment
            // 
            this.listViewOfDepartment.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.FirstName,
            this.LastName,
            this.Sername,
            this.Birthday,
            this.Position,
            this.OrderNumberOfEmployment,
            this.OrderNumberOfDismissal,
            this.Photo});
            this.listViewOfDepartment.Location = new System.Drawing.Point(12, 38);
            this.listViewOfDepartment.Name = "listViewOfDepartment";
            this.listViewOfDepartment.Size = new System.Drawing.Size(514, 295);
            this.listViewOfDepartment.TabIndex = 1;
            this.listViewOfDepartment.UseCompatibleStateImageBehavior = false;
            this.listViewOfDepartment.View = System.Windows.Forms.View.Details;
            // 
            // FirstName
            // 
            this.FirstName.Text = "FirstName";
            this.FirstName.Width = 73;
            // 
            // LastName
            // 
            this.LastName.Text = "LastName";
            this.LastName.Width = 76;
            // 
            // Sername
            // 
            this.Sername.Text = "Sername";
            this.Sername.Width = 78;
            // 
            // Birthday
            // 
            this.Birthday.Text = "Birthday";
            this.Birthday.Width = 66;
            // 
            // Position
            // 
            this.Position.Text = "Position";
            this.Position.Width = 70;
            // 
            // OrderNumberOfEmployment
            // 
            this.OrderNumberOfEmployment.Text = "OrderNumberOfEmployment";
            this.OrderNumberOfEmployment.Width = 145;
            // 
            // OrderNumberOfDismissal
            // 
            this.OrderNumberOfDismissal.Text = "OrderNumberOfDismissal";
            this.OrderNumberOfDismissal.Width = 129;
            // 
            // Photo
            // 
            this.Photo.Text = "Photo";
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AddToolStripMenuItem,
            this.removePersonToolStripMenuItem,
            this.watchTableToolStripMenuItem,
            this.addNewToolStripMenuItem,
            this.logOutToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(543, 24);
            this.menuStrip.TabIndex = 21;
            this.menuStrip.Text = "menuStrip1";
            // 
            // AddToolStripMenuItem
            // 
            this.AddToolStripMenuItem.Name = "AddToolStripMenuItem";
            this.AddToolStripMenuItem.Size = new System.Drawing.Size(80, 20);
            this.AddToolStripMenuItem.Text = "Add person";
            this.AddToolStripMenuItem.Click += new System.EventHandler(this.AddToolStripMenuItem_Click);
            // 
            // removePersonToolStripMenuItem
            // 
            this.removePersonToolStripMenuItem.Name = "removePersonToolStripMenuItem";
            this.removePersonToolStripMenuItem.Size = new System.Drawing.Size(101, 20);
            this.removePersonToolStripMenuItem.Text = "Remove person";
            this.removePersonToolStripMenuItem.Click += new System.EventHandler(this.removePersonToolStripMenuItem_Click);
            // 
            // watchTableToolStripMenuItem
            // 
            this.watchTableToolStripMenuItem.Name = "watchTableToolStripMenuItem";
            this.watchTableToolStripMenuItem.Size = new System.Drawing.Size(82, 20);
            this.watchTableToolStripMenuItem.Text = "Watch table";
            this.watchTableToolStripMenuItem.Click += new System.EventHandler(this.watchTableToolStripMenuItem_Click);
            // 
            // logOutToolStripMenuItem
            // 
            this.logOutToolStripMenuItem.Name = "logOutToolStripMenuItem";
            this.logOutToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
            this.logOutToolStripMenuItem.Text = "Log Out";
            this.logOutToolStripMenuItem.Click += new System.EventHandler(this.logOutToolStripMenuItem_Click);
            // 
            // addNewToolStripMenuItem
            // 
            this.addNewToolStripMenuItem.Name = "addNewToolStripMenuItem";
            this.addNewToolStripMenuItem.Size = new System.Drawing.Size(91, 20);
            this.addNewToolStripMenuItem.Text = "Add new user";
            this.addNewToolStripMenuItem.Click += new System.EventHandler(this.addNewToolStripMenuItem_Click);
            // 
            // addNewUser1
            // 
            this.addNewUser1.Location = new System.Drawing.Point(12, 38);
            this.addNewUser1.Name = "addNewUser1";
            this.addNewUser1.Size = new System.Drawing.Size(519, 179);
            this.addNewUser1.TabIndex = 24;
            // 
            // addPerson1
            // 
            this.addPerson1.Location = new System.Drawing.Point(12, 38);
            this.addPerson1.Name = "addPerson1";
            this.addPerson1.Size = new System.Drawing.Size(425, 246);
            this.addPerson1.TabIndex = 23;
            // 
            // removeRerson1
            // 
            this.removeRerson1.Location = new System.Drawing.Point(12, 38);
            this.removeRerson1.Name = "removeRerson1";
            this.removeRerson1.Size = new System.Drawing.Size(425, 124);
            this.removeRerson1.TabIndex = 22;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(543, 355);
            this.Controls.Add(this.addNewUser1);
            this.Controls.Add(this.addPerson1);
            this.Controls.Add(this.removeRerson1);
            this.Controls.Add(this.listViewOfDepartment);
            this.Controls.Add(this.menuStrip);
            this.MainMenuStrip = this.menuStrip;
            this.Name = "MainForm";
            this.Text = "Department of personnel";
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListView listViewOfDepartment;
        private System.Windows.Forms.ColumnHeader FirstName;
        private System.Windows.Forms.ColumnHeader LastName;
        private System.Windows.Forms.ColumnHeader Sername;
        private System.Windows.Forms.ColumnHeader Birthday;
        private System.Windows.Forms.ColumnHeader Position;
        private System.Windows.Forms.ColumnHeader OrderNumberOfEmployment;
        private System.Windows.Forms.ColumnHeader OrderNumberOfDismissal;
        private System.Windows.Forms.ColumnHeader Photo;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem AddToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem removePersonToolStripMenuItem;
        private RemoveRerson removeRerson1;
        private AddPerson addPerson1;
        private System.Windows.Forms.ToolStripMenuItem watchTableToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logOutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addNewToolStripMenuItem;
        private AddNewUser addNewUser1;
    }
}

