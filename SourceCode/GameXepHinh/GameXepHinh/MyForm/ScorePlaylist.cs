using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameXepHinh.MyForm
{
    public partial class ScorePlaylist : Form
    {

        string strConnectionString = @"Data Source=ALVIND-MARTIN-P\SQLEXPRESS;" +
        "Initial Catalog=GamePuzzle;" +
        "Integrated Security=True";

        SqlConnection conn = null;
        SqlDataAdapter daScore = null;
        DataTable dtScore = null;

        public ScorePlaylist()
        {
            InitializeComponent();
        }
        void LoadData()
        {
            try
            {
                conn = new SqlConnection(strConnectionString);
                daScore = new SqlDataAdapter(
                "SELECT * FROM	DBSCORE", conn);
                dtScore = new DataTable();
                daScore.Fill(dtScore);
                dGVScore.DataSource = dtScore;
            }
            catch (SqlException)
            {
                MessageBox.Show("Không lấy được nội dung.");
            }
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {

            DialogResult traloi;
            traloi = MessageBox.Show("Chắc chắn xóa không?", "Trả lời",
            MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (traloi == DialogResult.OK)
            {
                if (conn.State == ConnectionState.Open)
                    conn.Close();
                conn.Open();
                try
                {
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = conn;
                    cmd.CommandType = CommandType.Text;
                    int r = dGVScore.CurrentCell.RowIndex;
                    string strScore =
                    dGVScore.Rows[r].Cells[0].Value.ToString();

                    cmd.CommandText =
                    "Delete From DBSCORE Where UserName='"
                    + strScore.Trim() + "'";
                    cmd.CommandType = CommandType.Text;

                    cmd.ExecuteNonQuery();

                    LoadData();

                    MessageBox.Show("Đã xóa xong!");
                }
                catch (SqlException)
                {
                    MessageBox.Show("I'm Sorry , Tôi không thể xóa !");
                }
                finally
                {
                    conn.Close();
                }
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ScorePlaylist_Load(object sender, EventArgs e)
        {
            LoadData();
        }
    }
}
