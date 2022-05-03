
namespace WindowsFormsApp1
{
    partial class Staff_Bugs
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this._csci455_emrDataSet = new WindowsFormsApp1._csci455_emrDataSet();
            this.csci455emrDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.button2 = new System.Windows.Forms.Button();
            this.Bug_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Bug_Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Bug_Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Date_of_creation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Projected_Completion_Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Priority_Level = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._csci455_emrDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.csci455emrDataSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Bug_ID,
            this.Bug_Status,
            this.Bug_Description,
            this.Date_of_creation,
            this.Projected_Completion_Date,
            this.Priority_Level});
            this.dataGridView1.Location = new System.Drawing.Point(12, 74);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(776, 346);
            this.dataGridView1.TabIndex = 0;
            // 
            // _csci455_emrDataSet
            // 
            this._csci455_emrDataSet.DataSetName = "_csci455_emrDataSet";
            this._csci455_emrDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // csci455emrDataSetBindingSource
            // 
            this.csci455emrDataSetBindingSource.DataSource = this._csci455_emrDataSet;
            this.csci455emrDataSetBindingSource.Position = 0;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.Lime;
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(701, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(87, 25);
            this.button2.TabIndex = 8;
            this.button2.Text = "LOG OUT";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.MouseClick += new System.Windows.Forms.MouseEventHandler(this.button2_MouseClick);
            // 
            // Bug_ID
            // 
            this.Bug_ID.HeaderText = "Bug ID";
            this.Bug_ID.Name = "Bug_ID";
            this.Bug_ID.ReadOnly = true;
            // 
            // Bug_Status
            // 
            this.Bug_Status.HeaderText = "Bug Status";
            this.Bug_Status.Name = "Bug_Status";
            this.Bug_Status.ReadOnly = true;
            // 
            // Bug_Description
            // 
            this.Bug_Description.HeaderText = "Bug Description";
            this.Bug_Description.Name = "Bug_Description";
            this.Bug_Description.ReadOnly = true;
            // 
            // Date_of_creation
            // 
            this.Date_of_creation.HeaderText = "Date of Creation";
            this.Date_of_creation.Name = "Date_of_creation";
            this.Date_of_creation.ReadOnly = true;
            // 
            // Projected_Completion_Date
            // 
            this.Projected_Completion_Date.HeaderText = "Projected Completion Date";
            this.Projected_Completion_Date.Name = "Projected_Completion_Date";
            this.Projected_Completion_Date.ReadOnly = true;
            // 
            // Priority_Level
            // 
            this.Priority_Level.HeaderText = "Priority Level";
            this.Priority_Level.Name = "Priority_Level";
            this.Priority_Level.ReadOnly = true;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.Lime;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(295, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(164, 25);
            this.button1.TabIndex = 9;
            this.button1.Text = "RETURN TO ALL VIEW";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(297, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "label1";
            // 
            // Staff_Bugs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Staff_Bugs";
            this.Text = "Staff Bugs";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._csci455_emrDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.csci455emrDataSetBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private _csci455_emrDataSet _csci455_emrDataSet;
        private System.Windows.Forms.BindingSource csci455emrDataSetBindingSource;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Bug_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Bug_Status;
        private System.Windows.Forms.DataGridViewTextBoxColumn Bug_Description;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date_of_creation;
        private System.Windows.Forms.DataGridViewTextBoxColumn Projected_Completion_Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn Priority_Level;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
    }
}