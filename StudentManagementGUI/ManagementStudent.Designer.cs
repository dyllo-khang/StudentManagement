using System.Windows.Forms;

namespace StudentManagementGUI
{
    partial class ManagementStudent
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManagementStudent));
            btnUpdate = new Button();
            groupBox3 = new GroupBox();
            dgvStudent = new DataGridView();
            cbClass = new ComboBox();
            txtEmail = new TextBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            groupBox4 = new GroupBox();
            btnSearch = new Button();
            txtSearch = new TextBox();
            label7 = new Label();
            richAdress = new RichTextBox();
            dtpBirthday = new DateTimePicker();
            label3 = new Label();
            btnAdd = new Button();
            txtFullName = new TextBox();
            label2 = new Label();
            btnClose = new Button();
            groupBox2 = new GroupBox();
            btnDel = new Button();
            label1 = new Label();
            groupBox1 = new GroupBox();
            btnView = new Button();
            txtID = new TextBox();
            label8 = new Label();
            rdFemale = new RadioButton();
            rdMale = new RadioButton();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvStudent).BeginInit();
            groupBox4.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // btnUpdate
            // 
            btnUpdate.Image = (Image)resources.GetObject("btnUpdate.Image");
            btnUpdate.ImageAlign = ContentAlignment.MiddleLeft;
            btnUpdate.Location = new Point(51, 187);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(192, 74);
            btnUpdate.TabIndex = 1;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(dgvStudent);
            groupBox3.Location = new Point(6, 673);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(1584, 435);
            groupBox3.TabIndex = 6;
            groupBox3.TabStop = false;
            groupBox3.Text = "Student List";
            // 
            // dgvStudent
            // 
            dgvStudent.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvStudent.Location = new Point(6, 38);
            dgvStudent.Name = "dgvStudent";
            dgvStudent.RowHeadersWidth = 82;
            dgvStudent.RowTemplate.Height = 41;
            dgvStudent.Size = new Size(1567, 382);
            dgvStudent.TabIndex = 0;
            dgvStudent.CellClick += dgvStudent_CellClick;
            // 
            // cbClass
            // 
            cbClass.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cbClass.FormattingEnabled = true;
            cbClass.Location = new Point(807, 237);
            cbClass.Name = "cbClass";
            cbClass.Size = new Size(433, 53);
            cbClass.TabIndex = 11;
            // 
            // txtEmail
            // 
            txtEmail.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtEmail.Location = new Point(807, 146);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(433, 50);
            txtEmail.TabIndex = 10;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(674, 243);
            label6.Name = "label6";
            label6.Size = new Size(67, 32);
            label6.TabIndex = 8;
            label6.Text = "Class";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(674, 159);
            label5.Name = "label5";
            label5.Size = new Size(71, 32);
            label5.TabIndex = 7;
            label5.Text = "Email";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(31, 243);
            label4.Name = "label4";
            label4.Size = new Size(92, 32);
            label4.TabIndex = 6;
            label4.Text = "Gender";
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(btnSearch);
            groupBox4.Controls.Add(txtSearch);
            groupBox4.Controls.Add(label7);
            groupBox4.Location = new Point(12, 12);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(1292, 116);
            groupBox4.TabIndex = 7;
            groupBox4.TabStop = false;
            groupBox4.Text = "Search";
            // 
            // btnSearch
            // 
            btnSearch.Image = (Image)resources.GetObject("btnSearch.Image");
            btnSearch.ImageAlign = ContentAlignment.MiddleLeft;
            btnSearch.Location = new Point(1013, 26);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(214, 64);
            btnSearch.TabIndex = 2;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // txtSearch
            // 
            txtSearch.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtSearch.Location = new Point(183, 35);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(787, 50);
            txtSearch.TabIndex = 1;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(25, 42);
            label7.Name = "label7";
            label7.Size = new Size(116, 32);
            label7.TabIndex = 0;
            label7.Text = "FullName";
            // 
            // richAdress
            // 
            richAdress.Location = new Point(183, 308);
            richAdress.Name = "richAdress";
            richAdress.Size = new Size(433, 210);
            richAdress.TabIndex = 5;
            richAdress.Text = "";
            // 
            // dtpBirthday
            // 
            dtpBirthday.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dtpBirthday.Format = DateTimePickerFormat.Short;
            dtpBirthday.Location = new Point(807, 55);
            dtpBirthday.MaxDate = new DateTime(2015, 12, 31, 0, 0, 0, 0);
            dtpBirthday.MinDate = new DateTime(1990, 1, 1, 0, 0, 0, 0);
            dtpBirthday.Name = "dtpBirthday";
            dtpBirthday.Size = new Size(433, 50);
            dtpBirthday.TabIndex = 4;
            dtpBirthday.Value = new DateTime(2015, 12, 31, 0, 0, 0, 0);
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(25, 311);
            label3.Name = "label3";
            label3.Size = new Size(98, 32);
            label3.TabIndex = 2;
            label3.Text = "Address";
            // 
            // btnAdd
            // 
            btnAdd.Image = (Image)resources.GetObject("btnAdd.Image");
            btnAdd.ImageAlign = ContentAlignment.MiddleLeft;
            btnAdd.Location = new Point(51, 42);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(192, 74);
            btnAdd.TabIndex = 0;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // txtFullName
            // 
            txtFullName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtFullName.Location = new Point(183, 149);
            txtFullName.Name = "txtFullName";
            txtFullName.Size = new Size(433, 50);
            txtFullName.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(674, 65);
            label2.Name = "label2";
            label2.Size = new Size(102, 32);
            label2.TabIndex = 1;
            label2.Text = "Birthday";
            // 
            // btnClose
            // 
            btnClose.Image = (Image)resources.GetObject("btnClose.Image");
            btnClose.ImageAlign = ContentAlignment.MiddleLeft;
            btnClose.Location = new Point(51, 509);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(192, 74);
            btnClose.TabIndex = 3;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btnClose);
            groupBox2.Controls.Add(btnDel);
            groupBox2.Controls.Add(btnUpdate);
            groupBox2.Controls.Add(btnAdd);
            groupBox2.Location = new Point(1310, 12);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(280, 655);
            groupBox2.TabIndex = 5;
            groupBox2.TabStop = false;
            groupBox2.Text = "Action";
            // 
            // btnDel
            // 
            btnDel.Image = (Image)resources.GetObject("btnDel.Image");
            btnDel.ImageAlign = ContentAlignment.MiddleLeft;
            btnDel.Location = new Point(51, 342);
            btnDel.Name = "btnDel";
            btnDel.Size = new Size(192, 74);
            btnDel.TabIndex = 2;
            btnDel.Text = "Delete";
            btnDel.UseVisualStyleBackColor = true;
            btnDel.Click += btnDel_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(25, 159);
            label1.Name = "label1";
            label1.Size = new Size(116, 32);
            label1.TabIndex = 0;
            label1.Text = "FullName";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnView);
            groupBox1.Controls.Add(txtID);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(rdFemale);
            groupBox1.Controls.Add(rdMale);
            groupBox1.Controls.Add(cbClass);
            groupBox1.Controls.Add(txtEmail);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(richAdress);
            groupBox1.Controls.Add(dtpBirthday);
            groupBox1.Controls.Add(txtFullName);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(12, 134);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1292, 533);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            groupBox1.Text = "Profile";
            // 
            // btnView
            // 
            btnView.Location = new Point(807, 387);
            btnView.Name = "btnView";
            btnView.Size = new Size(433, 74);
            btnView.TabIndex = 16;
            btnView.Text = "View and Edit Student Score";
            btnView.UseVisualStyleBackColor = true;
            btnView.Click += btnView_Click;
            // 
            // txtID
            // 
            txtID.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtID.Location = new Point(183, 57);
            txtID.Name = "txtID";
            txtID.Size = new Size(433, 50);
            txtID.TabIndex = 15;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(25, 70);
            label8.Name = "label8";
            label8.Size = new Size(120, 32);
            label8.TabIndex = 14;
            label8.Text = "StudentID";
            // 
            // rdFemale
            // 
            rdFemale.AutoSize = true;
            rdFemale.Location = new Point(379, 237);
            rdFemale.Name = "rdFemale";
            rdFemale.Size = new Size(122, 36);
            rdFemale.TabIndex = 13;
            rdFemale.TabStop = true;
            rdFemale.Text = "Female";
            rdFemale.UseVisualStyleBackColor = true;
            // 
            // rdMale
            // 
            rdMale.AutoSize = true;
            rdMale.Location = new Point(183, 241);
            rdMale.Name = "rdMale";
            rdMale.Size = new Size(98, 36);
            rdMale.TabIndex = 12;
            rdMale.TabStop = true;
            rdMale.Text = "Male";
            rdMale.UseVisualStyleBackColor = true;
            // 
            // ManagementStudent
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1598, 1114);
            Controls.Add(groupBox3);
            Controls.Add(groupBox4);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "ManagementStudent";
            Text = "Management Student";
            Load += ManagementStudent_Load;
            groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvStudent).EndInit();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button btnUpdate;
        private GroupBox groupBox3;
        private DataGridView dgvStudent;
        private ComboBox cbClass;
        private TextBox txtEmail;
        private Label label6;
        private Label label5;
        private Label label4;
        private GroupBox groupBox4;
        private Button btnSearch;
        private TextBox txtSearch;
        private Label label7;
        private RichTextBox richAdress;
        private DateTimePicker dtpBirthday;
        private Label label3;
        private Button btnAdd;
        private TextBox txtFullName;
        private Label label2;
        private Button btnClose;
        private GroupBox groupBox2;
        private Button btnDel;
        private Label label1;
        private GroupBox groupBox1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private RadioButton rdFemale;
        private RadioButton rdMale;
        private Label label8;
        private TextBox txtID;
        private Button btnView;
    }
}