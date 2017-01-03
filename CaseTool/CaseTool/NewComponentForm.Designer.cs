namespace CaseTool
{
    partial class NewComponentForm
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.classes = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.classNameValue = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.varNameValue = new System.Windows.Forms.TextBox();
            this.varTypeValue = new System.Windows.Forms.ComboBox();
            this.methodValue = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.addClass = new System.Windows.Forms.Button();
            this.addVar = new System.Windows.Forms.Button();
            this.addMethod = new System.Windows.Forms.Button();
            this.vars = new System.Windows.Forms.RichTextBox();
            this.methods = new System.Windows.Forms.RichTextBox();
            this.methodTypeValue = new System.Windows.Forms.ComboBox();
            this.button2 = new System.Windows.Forms.Button();
            this.classSelect = new System.Windows.Forms.ComboBox();
            this.varStatus = new System.Windows.Forms.ComboBox();
            this.methodStatus = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(118, 16);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(186, 20);
            this.textBox1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Name :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Description :";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(118, 42);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(185, 57);
            this.richTextBox1.TabIndex = 3;
            this.richTextBox1.Text = "";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(228, 231);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Add";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.classSelect);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.classes);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.richTextBox1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(311, 262);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "New - Component";
            // 
            // classes
            // 
            this.classes.Location = new System.Drawing.Point(119, 139);
            this.classes.Name = "classes";
            this.classes.ReadOnly = true;
            this.classes.Size = new System.Drawing.Size(185, 77);
            this.classes.TabIndex = 6;
            this.classes.Text = "";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Classes :";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.methodStatus);
            this.groupBox2.Controls.Add(this.varStatus);
            this.groupBox2.Controls.Add(this.methods);
            this.groupBox2.Controls.Add(this.vars);
            this.groupBox2.Controls.Add(this.addMethod);
            this.groupBox2.Controls.Add(this.addVar);
            this.groupBox2.Controls.Add(this.addClass);
            this.groupBox2.Controls.Add(this.methodTypeValue);
            this.groupBox2.Controls.Add(this.methodValue);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.varTypeValue);
            this.groupBox2.Controls.Add(this.varNameValue);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.classNameValue);
            this.groupBox2.Location = new System.Drawing.Point(353, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(484, 387);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Add Class";
            // 
            // classNameValue
            // 
            this.classNameValue.Location = new System.Drawing.Point(76, 16);
            this.classNameValue.Name = "classNameValue";
            this.classNameValue.Size = new System.Drawing.Size(215, 20);
            this.classNameValue.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 19);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Name :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(26, 45);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Var :";
            // 
            // varNameValue
            // 
            this.varNameValue.Location = new System.Drawing.Point(157, 42);
            this.varNameValue.Name = "varNameValue";
            this.varNameValue.Size = new System.Drawing.Size(95, 20);
            this.varNameValue.TabIndex = 11;
            // 
            // varTypeValue
            // 
            this.varTypeValue.AutoCompleteCustomSource.AddRange(new string[] {
            "Int",
            "String"});
            this.varTypeValue.FormattingEnabled = true;
            this.varTypeValue.Items.AddRange(new object[] {
            "bool",
            "char",
            "int",
            "float",
            "double",
            "void"});
            this.varTypeValue.Location = new System.Drawing.Point(257, 42);
            this.varTypeValue.Name = "varTypeValue";
            this.varTypeValue.Size = new System.Drawing.Size(115, 21);
            this.varTypeValue.TabIndex = 12;
            // 
            // methodValue
            // 
            this.methodValue.Location = new System.Drawing.Point(157, 69);
            this.methodValue.Name = "methodValue";
            this.methodValue.Size = new System.Drawing.Size(95, 20);
            this.methodValue.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 72);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Method :";
            // 
            // addClass
            // 
            this.addClass.Location = new System.Drawing.Point(155, 272);
            this.addClass.Name = "addClass";
            this.addClass.Size = new System.Drawing.Size(75, 23);
            this.addClass.TabIndex = 16;
            this.addClass.Text = "Add Class";
            this.addClass.UseVisualStyleBackColor = true;
            this.addClass.Click += new System.EventHandler(this.addClass_Click);
            // 
            // addVar
            // 
            this.addVar.Location = new System.Drawing.Point(378, 41);
            this.addVar.Name = "addVar";
            this.addVar.Size = new System.Drawing.Size(75, 23);
            this.addVar.TabIndex = 17;
            this.addVar.Text = "Add Var";
            this.addVar.UseVisualStyleBackColor = true;
            this.addVar.Click += new System.EventHandler(this.addVar_Click);
            // 
            // addMethod
            // 
            this.addMethod.Location = new System.Drawing.Point(378, 67);
            this.addMethod.Name = "addMethod";
            this.addMethod.Size = new System.Drawing.Size(75, 23);
            this.addMethod.TabIndex = 18;
            this.addMethod.Text = "Add Method";
            this.addMethod.UseVisualStyleBackColor = true;
            this.addMethod.Click += new System.EventHandler(this.addMethod_Click_1);
            // 
            // vars
            // 
            this.vars.Location = new System.Drawing.Point(9, 113);
            this.vars.Name = "vars";
            this.vars.Size = new System.Drawing.Size(363, 71);
            this.vars.TabIndex = 19;
            this.vars.Text = "";
            // 
            // methods
            // 
            this.methods.Location = new System.Drawing.Point(9, 195);
            this.methods.Name = "methods";
            this.methods.Size = new System.Drawing.Size(363, 71);
            this.methods.TabIndex = 20;
            this.methods.Text = "";
            // 
            // methodTypeValue
            // 
            this.methodTypeValue.FormattingEnabled = true;
            this.methodTypeValue.Items.AddRange(new object[] {
            "bool",
            "char",
            "int",
            "float",
            "double",
            "void"});
            this.methodTypeValue.Location = new System.Drawing.Point(257, 69);
            this.methodTypeValue.Name = "methodTypeValue";
            this.methodTypeValue.Size = new System.Drawing.Size(115, 21);
            this.methodTypeValue.TabIndex = 15;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(9, 231);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(113, 23);
            this.button2.TabIndex = 7;
            this.button2.Text = "Generate Code";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // classSelect
            // 
            this.classSelect.FormattingEnabled = true;
            this.classSelect.Location = new System.Drawing.Point(118, 106);
            this.classSelect.Name = "classSelect";
            this.classSelect.Size = new System.Drawing.Size(184, 21);
            this.classSelect.TabIndex = 8;
            this.classSelect.SelectedIndexChanged += new System.EventHandler(this.classSelect_SelectedIndexChanged);
            // 
            // varStatus
            // 
            this.varStatus.FormattingEnabled = true;
            this.varStatus.Items.AddRange(new object[] {
            "private",
            "public"});
            this.varStatus.Location = new System.Drawing.Point(76, 42);
            this.varStatus.Name = "varStatus";
            this.varStatus.Size = new System.Drawing.Size(75, 21);
            this.varStatus.TabIndex = 21;
            // 
            // methodStatus
            // 
            this.methodStatus.FormattingEnabled = true;
            this.methodStatus.Items.AddRange(new object[] {
            "private",
            "public"});
            this.methodStatus.Location = new System.Drawing.Point(76, 69);
            this.methodStatus.Name = "methodStatus";
            this.methodStatus.Size = new System.Drawing.Size(75, 21);
            this.methodStatus.TabIndex = 22;
            // 
            // NewComponentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1003, 537);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "NewComponentForm";
            this.Text = "NewComponentForm";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RichTextBox classes;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RichTextBox methods;
        private System.Windows.Forms.RichTextBox vars;
        private System.Windows.Forms.Button addMethod;
        private System.Windows.Forms.Button addVar;
        private System.Windows.Forms.Button addClass;
        private System.Windows.Forms.TextBox methodValue;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox varTypeValue;
        private System.Windows.Forms.TextBox varNameValue;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox classNameValue;
        private System.Windows.Forms.ComboBox methodTypeValue;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox classSelect;
        private System.Windows.Forms.ComboBox methodStatus;
        private System.Windows.Forms.ComboBox varStatus;
    }
}