namespace CaseTool
{
    partial class Project
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.existComponent = new System.Windows.Forms.Button();
            this.newComponent = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.ProjectArea = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.AutoSize = true;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(219, 564);
            this.panel1.TabIndex = 5;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.existComponent);
            this.groupBox1.Controls.Add(this.newComponent);
            this.groupBox1.Location = new System.Drawing.Point(12, 37);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 121);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Components - Drag/Drop";
            // 
            // existComponent
            // 
            this.existComponent.Location = new System.Drawing.Point(7, 50);
            this.existComponent.Name = "existComponent";
            this.existComponent.Size = new System.Drawing.Size(187, 23);
            this.existComponent.TabIndex = 1;
            this.existComponent.Text = "Existing Component";
            this.existComponent.UseVisualStyleBackColor = true;
            this.existComponent.MouseDown += new System.Windows.Forms.MouseEventHandler(this.existComponent_MouseDown);
            // 
            // newComponent
            // 
            this.newComponent.Location = new System.Drawing.Point(7, 20);
            this.newComponent.Name = "newComponent";
            this.newComponent.Size = new System.Drawing.Size(187, 23);
            this.newComponent.TabIndex = 0;
            this.newComponent.Text = "New Component";
            this.newComponent.UseVisualStyleBackColor = true;
            this.newComponent.MouseDown += new System.Windows.Forms.MouseEventHandler(this.newComponent_MouseDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(69, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tools";
            // 
            // ProjectArea
            // 
            this.ProjectArea.AllowDrop = true;
            this.ProjectArea.AutoScroll = true;
            this.ProjectArea.AutoSize = true;
            this.ProjectArea.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.ProjectArea.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ProjectArea.Location = new System.Drawing.Point(219, 0);
            this.ProjectArea.Name = "ProjectArea";
            this.ProjectArea.Size = new System.Drawing.Size(851, 564);
            this.ProjectArea.TabIndex = 6;
            this.ProjectArea.DragDrop += new System.Windows.Forms.DragEventHandler(this.ProjectArea_DragDrop);
            this.ProjectArea.DragEnter += new System.Windows.Forms.DragEventHandler(this.ProjectArea_DragEnter);
            // 
            // panel2
            // 
            this.panel2.AutoSize = true;
            this.panel2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel2.Controls.Add(this.label2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(1002, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(68, 564);
            this.panel2.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "label2";
            // 
            // Project
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1070, 564);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.ProjectArea);
            this.Controls.Add(this.panel1);
            this.Name = "Project";
            this.Text = "New Project";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button existComponent;
        private System.Windows.Forms.Button newComponent;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel ProjectArea;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
    }
}

