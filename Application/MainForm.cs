using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Globalization;

namespace Application
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            role_LoadTeacherList();
            comboBox1.SelectedIndex = 0;
        }

        OleDbCommand object_Cmd;
        OleDbConnection object_Con;
        CultureInfo USFormat = new CultureInfo("en-US", true);
        OleDbDataAdapter object_Adapter;


        private string var_ConnectionString = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=\\172.10.108.202\d\PSOPTSYS\Psoptsys.mdb;User Id=admin;Password=;";
        private string var_SelectAll = "select top 10 * from [Chk_TimeWorking] where [Tch_ID]=349 order by [Chk_WorkDate] desc";
        private string var_DateTime;

        private string _Tch_ID;
        private string _Chk_WorkDate;
        private string _Chk_StartTime;
        private string _Chk_KindComing;
        private string _Chk_TimeLate;
        private string _Chk_FinishTime;
        private string _Chk_Grade;
        private string _Chk_Memo;
        private string _Chk_Term;
        private string _chk_EduYear;
        private string _Chk_Coming;
        private string _Chk_CancelSpTime;

        public void role_LoadData()
        {
            _Tch_ID = (comboBox1.SelectedItem as ComboboxItem).Value.ToString();
            object_Con = new OleDbConnection(var_ConnectionString);
            var_DateTime = dateTimePicker1.Value.ToString(USFormat);
            DateTime object_Date = new DateTime();
            object_Date = Convert.ToDateTime(var_DateTime);
            var_DateTime = "#"+object_Date.ToShortDateString()+"#";
            var_SelectAll = "select * from [Chk_TimeWorking] where [Tch_ID]="+ _Tch_ID + " and [Chk_WorkDate]=" + var_DateTime + " order by [Chk_WorkDate] desc";

            try
            {
                object_Con.Open();
                Chk_TimeWorking.Clear();
                object_Adapter = new OleDbDataAdapter(var_SelectAll, object_Con);
                object_Adapter.Fill(Chk_TimeWorking);

                this.dataGridView1.DataSource = Chk_TimeWorking;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            object_Con.Close();
        }

        public void role_UpdateData()
        {
            object_Con = new OleDbConnection(var_ConnectionString);
            DateTime object_NewDate = new DateTime();

            _Tch_ID = dataGridView1.Rows[0].Cells[0].Value.ToString();
            _Chk_WorkDate = dataGridView1.Rows[0].Cells[1].Value.ToString();
            _Chk_StartTime = dataGridView1.Rows[0].Cells[2].Value.ToString();
            _Chk_KindComing = dataGridView1.Rows[0].Cells[3].Value.ToString();
            _Chk_TimeLate = dataGridView1.Rows[0].Cells[4].Value.ToString();
            _Chk_FinishTime = dataGridView1.Rows[0].Cells[5].Value.ToString();
            _Chk_Grade = dataGridView1.Rows[0].Cells[6].Value.ToString();
            _Chk_Memo = dataGridView1.Rows[0].Cells[7].Value.ToString();
            _Chk_Term = dataGridView1.Rows[0].Cells[8].Value.ToString();
            _chk_EduYear = dataGridView1.Rows[0].Cells[9].Value.ToString();
            _Chk_Coming = dataGridView1.Rows[0].Cells[10].Value.ToString();
            _Chk_CancelSpTime = dataGridView1.Rows[0].Cells[11].Value.ToString();

            if (_Chk_FinishTime.Length == 0) { _Chk_FinishTime = "null"; }
            else
            {
                object_NewDate = Convert.ToDateTime(_Chk_FinishTime);
                _Chk_FinishTime = "#" + object_NewDate.ToString(USFormat) + "#";
            }

            object_NewDate = Convert.ToDateTime(_Chk_WorkDate);
            _Chk_WorkDate = object_NewDate.ToString(USFormat);

            object_NewDate = Convert.ToDateTime(_Chk_StartTime);
            _Chk_StartTime = object_NewDate.ToString(USFormat);

            try
            {

                string var_UpdateCommand = "update [Chk_TimeWorking] " +
                                           "set " +
                                           "[Chk_StartTime]=#" + _Chk_StartTime + "#, " +
                                           "[Chk_KindComing]='" + _Chk_KindComing + "', " +
                                           "[Chk_TimeLate]='" + _Chk_TimeLate + "', " +
                                           "[Chk_FinishTime]=" + _Chk_FinishTime + ", " +
                                           "[Chk_Grade]=" + _Chk_Grade + ", " +
                                           "[Chk_Memo]='" + _Chk_Memo + "', " +
                                           "[Chk_Term]=" + _Chk_Term + ", " +
                                           "[chk_EduYear]=" + _chk_EduYear + ", " +
                                           "[Chk_Coming]='" + _Chk_Coming + "', " +
                                           "[Chk_CancelSpTime]=" + _Chk_CancelSpTime + " " +
                                           "Where [Tch_ID]=" + _Tch_ID + " and [Chk_WorkDate]=#" + _Chk_WorkDate + "#";
                object_Con.Open();
                object_Cmd = new OleDbCommand(var_UpdateCommand, object_Con);
                object_Cmd.ExecuteNonQuery();
                MessageBox.Show("Done.");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            object_Con.Close();
        }

        public void role_LoadTeacherList()
        {           
            string var_SelectCommand = "select [Tch_ID], [Tch_FrontName], [Tch_Name], [Tch_Name] from [Tch_Hist]";

            object_Con = new OleDbConnection(var_ConnectionString);
            object_Cmd = new OleDbCommand(var_SelectCommand,object_Con);
            OleDbDataReader object_Reader;
            
            try
            {
                object_Con.Open();
                object_Reader = object_Cmd.ExecuteReader();
                if (object_Reader.HasRows == true)
                {
                    while (object_Reader.Read())
                    {
                        ComboboxItem object_Item = new ComboboxItem();
                        object_Item.Text = object_Reader.GetValue(0).ToString() + " " +
                                           object_Reader.GetValue(1).ToString() +
                                           object_Reader.GetValue(2).ToString() + " " +
                                           object_Reader.GetValue(3).ToString();
                        object_Item.Value = object_Reader.GetValue(0).ToString();

                        comboBox1.Items.Add(object_Item);
                    }
                }
            }
            catch 
            {

            }
            object_Con.Close();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            role_LoadData();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            role_UpdateData();
        }
    }
    public class ComboboxItem
    {
        public string Text { get; set; }
        public object Value { get; set; }

        public override string ToString()
        {
            return Text;
        }
    }
}
