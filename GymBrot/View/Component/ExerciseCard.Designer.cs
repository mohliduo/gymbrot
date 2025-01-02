namespace GymBrot.View.Component
{
    partial class ExerciseCard
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
            this.image = new Guna.UI2.WinForms.Guna2PictureBox();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.labelMuscle = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.image)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // image
            // 
            this.image.Dock = System.Windows.Forms.DockStyle.Right;
            this.image.FillColor = System.Drawing.Color.Transparent;
            this.image.ImageRotate = 0F;
            this.image.Location = new System.Drawing.Point(269, 0);
            this.image.Name = "image";
            this.image.Size = new System.Drawing.Size(116, 123);
            this.image.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.image.TabIndex = 0;
            this.image.TabStop = false;
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 20;
            this.guna2Elipse1.TargetControl = this;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.labelMuscle);
            this.flowLayoutPanel1.Controls.Add(this.labelName);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Padding = new System.Windows.Forms.Padding(16, 36, 0, 0);
            this.flowLayoutPanel1.Size = new System.Drawing.Size(263, 123);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // labelMuscle
            // 
            this.labelMuscle.AutoSize = true;
            this.labelMuscle.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMuscle.Location = new System.Drawing.Point(19, 36);
            this.labelMuscle.Name = "labelMuscle";
            this.labelMuscle.Size = new System.Drawing.Size(65, 16);
            this.labelMuscle.TabIndex = 0;
            this.labelMuscle.Text = "Shoulder";
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelName.Location = new System.Drawing.Point(19, 52);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(120, 19);
            this.labelName.TabIndex = 1;
            this.labelName.Text = "Dumbell Raise";
            // 
            // ExerciseCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(186)))), ((int)(((byte)(47)))));
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.image);
            this.Name = "ExerciseCard";
            this.Size = new System.Drawing.Size(385, 123);
            ((System.ComponentModel.ISupportInitialize)(this.image)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2PictureBox image;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label labelMuscle;
        private System.Windows.Forms.Label labelName;
    }
}
