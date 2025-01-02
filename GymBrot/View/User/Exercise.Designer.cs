namespace GymBrot.View.User
{
    partial class Exercise
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
            this.components = new System.ComponentModel.Container();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.muscleComboBox = new Guna.UI2.WinForms.Guna2ComboBox();
            this.guna2AnimateWindow1 = new Guna.UI2.WinForms.Guna2AnimateWindow(this.components);
            this.equipmentComboBox = new Guna.UI2.WinForms.Guna2ComboBox();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.Controls.Add(this.muscleComboBox);
            this.flowLayoutPanel1.Controls.Add(this.equipmentComboBox);
            this.flowLayoutPanel1.Cursor = System.Windows.Forms.Cursors.Default;
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(25, 25);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(869, 63);
            this.flowLayoutPanel1.TabIndex = 0;
            this.flowLayoutPanel1.WrapContents = false;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.AutoScroll = true;
            this.flowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(25, 88);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(869, 619);
            this.flowLayoutPanel2.TabIndex = 1;
            // 
            // muscleComboBox
            // 
            this.muscleComboBox.BackColor = System.Drawing.Color.Transparent;
            this.muscleComboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.muscleComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.muscleComboBox.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.muscleComboBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.muscleComboBox.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.muscleComboBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.muscleComboBox.ItemHeight = 30;
            this.muscleComboBox.Location = new System.Drawing.Point(3, 3);
            this.muscleComboBox.Name = "muscleComboBox";
            this.muscleComboBox.Size = new System.Drawing.Size(293, 36);
            this.muscleComboBox.TabIndex = 0;
            this.muscleComboBox.SelectedValueChanged += new System.EventHandler(this.muscleComboBox_SelectedValueChanged);
            // 
            // equipmentComboBox
            // 
            this.equipmentComboBox.BackColor = System.Drawing.Color.Transparent;
            this.equipmentComboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.equipmentComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.equipmentComboBox.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.equipmentComboBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.equipmentComboBox.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.equipmentComboBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.equipmentComboBox.ItemHeight = 30;
            this.equipmentComboBox.Location = new System.Drawing.Point(302, 3);
            this.equipmentComboBox.Name = "equipmentComboBox";
            this.equipmentComboBox.Size = new System.Drawing.Size(293, 36);
            this.equipmentComboBox.TabIndex = 1;
            this.equipmentComboBox.SelectedValueChanged += new System.EventHandler(this.equipmentComboBox_SelectedValueChanged);
            // 
            // Exercise
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.Controls.Add(this.flowLayoutPanel2);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Name = "Exercise";
            this.Padding = new System.Windows.Forms.Padding(25);
            this.Size = new System.Drawing.Size(919, 732);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private Guna.UI2.WinForms.Guna2ComboBox muscleComboBox;
        private Guna.UI2.WinForms.Guna2AnimateWindow guna2AnimateWindow1;
        private Guna.UI2.WinForms.Guna2ComboBox equipmentComboBox;
    }
}
