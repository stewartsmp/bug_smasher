
namespace WindowsFormsApp1
{
    partial class AddBug
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddBug));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this._csci455_emrDataSet = new WindowsFormsApp1._csci455_emrDataSet();
            this.userInformationUpdatedBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.user_Information_UpdatedTableAdapter = new WindowsFormsApp1._csci455_emrDataSetTableAdapters.User_Information_UpdatedTableAdapter();
            this.comboBox5 = new System.Windows.Forms.ComboBox();
            this._csci455_emrDataSet1 = new WindowsFormsApp1._csci455_emrDataSet1();
            this.userInformationBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.user_InformationTableAdapter = new WindowsFormsApp1._csci455_emrDataSet1TableAdapters.User_InformationTableAdapter();
            this._csci455_emrDataSet2 = new WindowsFormsApp1._csci455_emrDataSet2();
            this.userInformationUpdatedBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.user_Information_UpdatedTableAdapter1 = new WindowsFormsApp1._csci455_emrDataSet2TableAdapters.User_Information_UpdatedTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this._csci455_emrDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userInformationUpdatedBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._csci455_emrDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userInformationBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._csci455_emrDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userInformationUpdatedBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label1.Location = new System.Drawing.Point(97, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Bug Status*";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label2.Location = new System.Drawing.Point(69, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Bug Description*";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label3.Location = new System.Drawing.Point(76, 167);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Owner User ID*";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label4.Location = new System.Drawing.Point(85, 289);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Priority Level*";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label5.Location = new System.Drawing.Point(66, 208);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(105, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Date of Creation*";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label6.Location = new System.Drawing.Point(8, 246);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(163, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Projected Completion Date*";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label7.Location = new System.Drawing.Point(17, 331);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(154, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Secondary Owner User ID";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label8.Location = new System.Drawing.Point(84, 364);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(85, 17);
            this.label8.TabIndex = 7;
            this.label8.Text = "* Required";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Low",
            "Medium",
            "High",
            "Emergent"});
            this.comboBox1.Location = new System.Drawing.Point(186, 286);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(251, 21);
            this.comboBox1.TabIndex = 8;
            // 
            // comboBox2
            // 
            this.comboBox2.DataSource = this.userInformationUpdatedBindingSource;
            this.comboBox2.DisplayMember = "User_ID";
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(186, 164);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(251, 21);
            this.comboBox2.TabIndex = 9;
            this.comboBox2.ValueMember = "User_ID";
            // 
            // comboBox3
            // 
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Items.AddRange(new object[] {
            "New",
            "Progress",
            "Complete"});
            this.comboBox3.Location = new System.Drawing.Point(186, 39);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(251, 21);
            this.comboBox3.TabIndex = 10;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(186, 201);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(251, 20);
            this.dateTimePicker1.TabIndex = 11;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(186, 240);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(251, 20);
            this.dateTimePicker2.TabIndex = 12;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(186, 77);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(251, 70);
            this.textBox1.TabIndex = 15;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button1.FlatAppearance.BorderSize = 3;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(186, 388);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(224, 50);
            this.button1.TabIndex = 16;
            this.button1.Text = "SUBMIT BUG";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // _csci455_emrDataSet
            // 
            this._csci455_emrDataSet.DataSetName = "_csci455_emrDataSet";
            this._csci455_emrDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // userInformationUpdatedBindingSource
            // 
            this.userInformationUpdatedBindingSource.DataMember = "User_Information_Updated";
            this.userInformationUpdatedBindingSource.DataSource = this._csci455_emrDataSet;
            // 
            // user_Information_UpdatedTableAdapter
            // 
            this.user_Information_UpdatedTableAdapter.ClearBeforeFill = true;
            // 
            // comboBox5
            // 
            this.comboBox5.DataSource = this.userInformationUpdatedBindingSource1;
            this.comboBox5.DisplayMember = "User_ID";
            this.comboBox5.FormattingEnabled = true;
            this.comboBox5.Location = new System.Drawing.Point(186, 323);
            this.comboBox5.Name = "comboBox5";
            this.comboBox5.Size = new System.Drawing.Size(251, 21);
            this.comboBox5.TabIndex = 17;
            this.comboBox5.ValueMember = "User_ID";
            // 
            // _csci455_emrDataSet1
            // 
            this._csci455_emrDataSet1.DataSetName = "_csci455_emrDataSet1";
            this._csci455_emrDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // userInformationBindingSource
            // 
            this.userInformationBindingSource.DataMember = "User_Information";
            this.userInformationBindingSource.DataSource = this._csci455_emrDataSet1;
            // 
            // user_InformationTableAdapter
            // 
            this.user_InformationTableAdapter.ClearBeforeFill = true;
            // 
            // _csci455_emrDataSet2
            // 
            this._csci455_emrDataSet2.DataSetName = "_csci455_emrDataSet2";
            this._csci455_emrDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // userInformationUpdatedBindingSource1
            // 
            this.userInformationUpdatedBindingSource1.DataMember = "User_Information_Updated";
            this.userInformationUpdatedBindingSource1.DataSource = this._csci455_emrDataSet2;
            // 
            // user_Information_UpdatedTableAdapter1
            // 
            this.user_Information_UpdatedTableAdapter1.ClearBeforeFill = true;
            // 
            // AddBug
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(484, 450);
            this.Controls.Add(this.comboBox5);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.comboBox3);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AddBug";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add a Bug";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.AddBug_Load);
            ((System.ComponentModel.ISupportInitialize)(this._csci455_emrDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userInformationUpdatedBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._csci455_emrDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userInformationBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._csci455_emrDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userInformationUpdatedBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private _csci455_emrDataSet _csci455_emrDataSet;
        private System.Windows.Forms.BindingSource userInformationUpdatedBindingSource;
        private _csci455_emrDataSetTableAdapters.User_Information_UpdatedTableAdapter user_Information_UpdatedTableAdapter;
        private System.Windows.Forms.ComboBox comboBox5;
        private _csci455_emrDataSet1 _csci455_emrDataSet1;
        private System.Windows.Forms.BindingSource userInformationBindingSource;
        private _csci455_emrDataSet1TableAdapters.User_InformationTableAdapter user_InformationTableAdapter;
        private _csci455_emrDataSet2 _csci455_emrDataSet2;
        private System.Windows.Forms.BindingSource userInformationUpdatedBindingSource1;
        private _csci455_emrDataSet2TableAdapters.User_Information_UpdatedTableAdapter user_Information_UpdatedTableAdapter1;
    }
}