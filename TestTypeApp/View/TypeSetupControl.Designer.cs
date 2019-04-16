namespace TestTypeApp
{
    partial class TypeSetupControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TypeSetupControl));
            this.typesListBox = new System.Windows.Forms.ListBox();
            this.AddButton = new DevExpress.XtraEditors.SimpleButton();
            this.SaveButton = new DevExpress.XtraEditors.SimpleButton();
            this.DeleteButton = new DevExpress.XtraEditors.SimpleButton();
            this.RefreshButton = new DevExpress.XtraEditors.SimpleButton();
            this.typeControl1 = new TestTypeApp.View.TypeControl();
            this.SuspendLayout();
            // 
            // typesListBox
            // 
            this.typesListBox.FormattingEnabled = true;
            this.typesListBox.Location = new System.Drawing.Point(8, 11);
            this.typesListBox.Name = "typesListBox";
            this.typesListBox.Size = new System.Drawing.Size(308, 160);
            this.typesListBox.TabIndex = 1;
            this.typesListBox.SelectedIndexChanged += new System.EventHandler(this.typesListBox_SelectedIndexChanged);
            // 
            // AddButton
            // 
            this.AddButton.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003;
            this.AddButton.Image = ((System.Drawing.Image)(resources.GetObject("AddButton.Image")));
            this.AddButton.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.AddButton.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.AddButton.Location = new System.Drawing.Point(578, 108);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(63, 63);
            this.AddButton.TabIndex = 7;
            // 
            // SaveButton
            // 
            this.SaveButton.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003;
            this.SaveButton.Image = ((System.Drawing.Image)(resources.GetObject("SaveButton.Image")));
            this.SaveButton.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.SaveButton.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.SaveButton.Location = new System.Drawing.Point(496, 108);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(63, 63);
            this.SaveButton.TabIndex = 6;
            this.SaveButton.Click += new System.EventHandler(this.Save_Click);
            // 
            // DeleteButton
            // 
            this.DeleteButton.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003;
            this.DeleteButton.Image = ((System.Drawing.Image)(resources.GetObject("DeleteButton.Image")));
            this.DeleteButton.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.DeleteButton.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.DeleteButton.Location = new System.Drawing.Point(414, 108);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(63, 63);
            this.DeleteButton.TabIndex = 5;
            // 
            // RefreshButton
            // 
            this.RefreshButton.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003;
            this.RefreshButton.Image = ((System.Drawing.Image)(resources.GetObject("RefreshButton.Image")));
            this.RefreshButton.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.RefreshButton.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.RefreshButton.Location = new System.Drawing.Point(334, 108);
            this.RefreshButton.Name = "RefreshButton";
            this.RefreshButton.Size = new System.Drawing.Size(63, 63);
            this.RefreshButton.TabIndex = 4;
            this.RefreshButton.Click += new System.EventHandler(this.RefreshButton_Click);
            // 
            // typeControl1
            // 
            this.typeControl1.DataSource = null;
            this.typeControl1.Location = new System.Drawing.Point(332, 8);
            this.typeControl1.Name = "typeControl1";
            this.typeControl1.Size = new System.Drawing.Size(236, 64);
            this.typeControl1.TabIndex = 2;
            // 
            // TypeSetupControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.RefreshButton);
            this.Controls.Add(this.typeControl1);
            this.Controls.Add(this.typesListBox);
            this.Name = "TypeSetupControl";
            this.Size = new System.Drawing.Size(667, 196);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox typesListBox;
        private View.TypeControl typeControl1;
        private DevExpress.XtraEditors.SimpleButton AddButton;
        private DevExpress.XtraEditors.SimpleButton SaveButton;
        private DevExpress.XtraEditors.SimpleButton DeleteButton;
        private DevExpress.XtraEditors.SimpleButton RefreshButton;
    }
}
