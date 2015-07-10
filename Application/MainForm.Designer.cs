namespace Application
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.dataSet_Psoptsys = new System.Data.DataSet();
            this.Chk_TimeWorking = new System.Data.DataTable();
            this.Tch_ID = new System.Data.DataColumn();
            this.Chk_WorkDate = new System.Data.DataColumn();
            this.Chk_StartTime = new System.Data.DataColumn();
            this.Chk_KindComing = new System.Data.DataColumn();
            this.Chk_TimeLate = new System.Data.DataColumn();
            this.Chk_FinishTime = new System.Data.DataColumn();
            this.Chk_Grade = new System.Data.DataColumn();
            this.Chk_Memo = new System.Data.DataColumn();
            this.Chk_Term = new System.Data.DataColumn();
            this.chk_EduYear = new System.Data.DataColumn();
            this.Chk_Coming = new System.Data.DataColumn();
            this.Chk_CancelSpTime = new System.Data.DataColumn();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet_Psoptsys)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Chk_TimeWorking)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(40, 57);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(733, 100);
            this.dataGridView1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(40, 163);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "เปิด";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(160, 163);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "ทำการแก้ไข";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // dataSet_Psoptsys
            // 
            this.dataSet_Psoptsys.DataSetName = "dataSet_Psoptsys";
            this.dataSet_Psoptsys.Tables.AddRange(new System.Data.DataTable[] {
            this.Chk_TimeWorking});
            // 
            // Chk_TimeWorking
            // 
            this.Chk_TimeWorking.Columns.AddRange(new System.Data.DataColumn[] {
            this.Tch_ID,
            this.Chk_WorkDate,
            this.Chk_StartTime,
            this.Chk_KindComing,
            this.Chk_TimeLate,
            this.Chk_FinishTime,
            this.Chk_Grade,
            this.Chk_Memo,
            this.Chk_Term,
            this.chk_EduYear,
            this.Chk_Coming,
            this.Chk_CancelSpTime});
            this.Chk_TimeWorking.Constraints.AddRange(new System.Data.Constraint[] {
            new System.Data.UniqueConstraint("Constraint1", new string[] {
                        "Tch_ID",
                        "Chk_WorkDate"}, true)});
            this.Chk_TimeWorking.PrimaryKey = new System.Data.DataColumn[] {
        this.Tch_ID,
        this.Chk_WorkDate};
            this.Chk_TimeWorking.TableName = "Chk_TimeWorking";
            // 
            // Tch_ID
            // 
            this.Tch_ID.AllowDBNull = false;
            this.Tch_ID.Caption = "Tch_ID";
            this.Tch_ID.ColumnName = "Tch_ID";
            this.Tch_ID.DataType = typeof(int);
            // 
            // Chk_WorkDate
            // 
            this.Chk_WorkDate.AllowDBNull = false;
            this.Chk_WorkDate.Caption = "Chk_WorkDate";
            this.Chk_WorkDate.ColumnName = "Chk_WorkDate";
            this.Chk_WorkDate.DataType = typeof(System.DateTime);
            // 
            // Chk_StartTime
            // 
            this.Chk_StartTime.Caption = "Chk_StartTime";
            this.Chk_StartTime.ColumnName = "Chk_StartTime";
            this.Chk_StartTime.DataType = typeof(System.DateTime);
            // 
            // Chk_KindComing
            // 
            this.Chk_KindComing.Caption = "Chk_KindComing";
            this.Chk_KindComing.ColumnName = "Chk_KindComing";
            // 
            // Chk_TimeLate
            // 
            this.Chk_TimeLate.Caption = "Chk_TimeLate";
            this.Chk_TimeLate.ColumnName = "Chk_TimeLate";
            // 
            // Chk_FinishTime
            // 
            this.Chk_FinishTime.Caption = "Chk_FinishTime";
            this.Chk_FinishTime.ColumnName = "Chk_FinishTime";
            this.Chk_FinishTime.DataType = typeof(System.DateTime);
            // 
            // Chk_Grade
            // 
            this.Chk_Grade.Caption = "Chk_Grade";
            this.Chk_Grade.ColumnName = "Chk_Grade";
            this.Chk_Grade.DataType = typeof(int);
            // 
            // Chk_Memo
            // 
            this.Chk_Memo.Caption = "Chk_Memo";
            this.Chk_Memo.ColumnName = "Chk_Memo";
            // 
            // Chk_Term
            // 
            this.Chk_Term.Caption = "Chk_Term";
            this.Chk_Term.ColumnName = "Chk_Term";
            this.Chk_Term.DataType = typeof(int);
            // 
            // chk_EduYear
            // 
            this.chk_EduYear.Caption = "chk_EduYear";
            this.chk_EduYear.ColumnName = "chk_EduYear";
            this.chk_EduYear.DataType = typeof(int);
            // 
            // Chk_Coming
            // 
            this.Chk_Coming.Caption = "Chk_Coming";
            this.Chk_Coming.ColumnName = "Chk_Coming";
            // 
            // Chk_CancelSpTime
            // 
            this.Chk_CancelSpTime.Caption = "Chk_CancelSpTime";
            this.Chk_CancelSpTime.ColumnName = "Chk_CancelSpTime";
            this.Chk_CancelSpTime.DataType = typeof(int);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(236, 21);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 3;
            // 
            // comboBox1
            // 
            this.comboBox1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboBox1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(40, 20);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(171, 21);
            this.comboBox1.TabIndex = 4;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(790, 199);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "CheckOut";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet_Psoptsys)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Chk_TimeWorking)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Data.DataSet dataSet_Psoptsys;
        private System.Data.DataTable Chk_TimeWorking;
        private System.Data.DataColumn Tch_ID;
        private System.Data.DataColumn Chk_WorkDate;
        private System.Data.DataColumn Chk_StartTime;
        private System.Data.DataColumn Chk_KindComing;
        private System.Data.DataColumn Chk_TimeLate;
        private System.Data.DataColumn Chk_FinishTime;
        private System.Data.DataColumn Chk_Grade;
        private System.Data.DataColumn Chk_Memo;
        private System.Data.DataColumn Chk_Term;
        private System.Data.DataColumn chk_EduYear;
        private System.Data.DataColumn Chk_Coming;
        private System.Data.DataColumn Chk_CancelSpTime;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}