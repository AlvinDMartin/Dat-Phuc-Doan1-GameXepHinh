using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Picture_Puzzle_1._0
{
	public partial class HighScore : Form
	{
		// chuan bi cac doi tuong
		// Chuỗi kết nối
		string strConnectionString = @"Data Source=DESKTOP-4KL0P5K\SQLEXPRESS;" +
		"Initial Catalog=GamePuzzle;" +
		"Integrated Security=True";
		// Đối tượng kết nối
		SqlConnection conn = null;
		SqlDataAdapter daScore = null;
		// Đối tượng hiển thị dữ liệu lên Form
		DataTable dtScore = null;
		public HighScore()
		{
			InitializeComponent();
		}
		void LoadData()
		{ 
			try
			{
				// Khởi động connection
				conn = new SqlConnection(strConnectionString);
				// Vận chuyển dữ liệu vào DataTable dtThanhPho
				daScore = new SqlDataAdapter(
				"SELECT * FROM	DBSCORE", conn);
				dtScore = new DataTable();
				daScore.Fill(dtScore);
				// Đưa dữ liệu lên DataGridView
				dGVScore.DataSource = dtScore;
			}
			catch (SqlException)
			{
				MessageBox.Show("Không lấy được nội dung trong table Score. Lỗi rồi!!!");
			}
		}

		private void HighScore_Load(object sender, EventArgs e)
		{
			LoadData();
		}

		private void btnClose_Click(object sender, EventArgs e)
		{
			this.Close();
		}
	}
}
