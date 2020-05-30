namespace OfficeSupplies
{
    partial class Register
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
            this.BtnCLose = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvEmployeeList = new System.Windows.Forms.DataGridView();
            this.txtbxLastName = new System.Windows.Forms.TextBox();
            this.txtbxFirstName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployeeList)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // BtnCLose
            // 
            this.BtnCLose.Location = new System.Drawing.Point(531, 650);
            this.BtnCLose.Name = "BtnCLose";
            this.BtnCLose.Size = new System.Drawing.Size(154, 48);
            this.BtnCLose.TabIndex = 3;
            this.BtnCLose.Text = "Close";
            this.BtnCLose.UseVisualStyleBackColor = true;
            this.BtnCLose.Click += new System.EventHandler(this.BtnCLose_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(371, 650);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(154, 48);
            this.btnClear.TabIndex = 4;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvEmployeeList);
            this.groupBox2.Location = new System.Drawing.Point(24, 280);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(673, 341);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Employees";
            // 
            // dgvEmployeeList
            // 
            this.dgvEmployeeList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmployeeList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvEmployeeList.Location = new System.Drawing.Point(3, 24);
            this.dgvEmployeeList.Name = "dgvEmployeeList";
            this.dgvEmployeeList.RowHeadersWidth = 51;
            this.dgvEmployeeList.RowTemplate.Height = 24;
            this.dgvEmployeeList.Size = new System.Drawing.Size(667, 314);
            this.dgvEmployeeList.TabIndex = 0;
            // 
            // txtbxLastName
            // 
            this.txtbxLastName.Location = new System.Drawing.Point(189, 103);
            this.txtbxLastName.Name = "txtbxLastName";
            this.txtbxLastName.Size = new System.Drawing.Size(449, 28);
            this.txtbxLastName.TabIndex = 1;
            // 
            // txtbxFirstName
            // 
            this.txtbxFirstName.Location = new System.Drawing.Point(189, 53);
            this.txtbxFirstName.Name = "txtbxFirstName";
            this.txtbxFirstName.Size = new System.Drawing.Size(449, 28);
            this.txtbxFirstName.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(61, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 24);
            this.label2.TabIndex = 6;
            this.label2.Text = "Last Name";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(484, 161);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(154, 50);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(59, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 24);
            this.label1.TabIndex = 5;
            this.label1.Text = "First Name";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnAdd);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtbxFirstName);
            this.groupBox1.Controls.Add(this.txtbxLastName);
            this.groupBox1.Location = new System.Drawing.Point(24, 21);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(673, 241);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Registration";
            // 
            // Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(725, 726);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.BtnCLose);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Register";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Register";
            this.Load += new System.EventHandler(this.Register_Load);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployeeList)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button BtnCLose;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgvEmployeeList;
        private System.Windows.Forms.TextBox txtbxLastName;
        private System.Windows.Forms.TextBox txtbxFirstName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}