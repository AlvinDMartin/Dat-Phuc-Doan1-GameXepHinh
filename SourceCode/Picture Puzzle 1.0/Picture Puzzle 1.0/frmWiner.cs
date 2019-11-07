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
	public partial class frmWiner : Form
	{
		// chuan bi cac doi tuong
		// Chuỗi kết nối
		string strConnectionString = @"Data Source=DESKTOP-4KL0P5K\SQLEXPRESS;" +
		"Initial Catalog=GamePuzzle;" +
		"Integrated Security=True";
		// Đối tượng kết nối
		SqlConnection conn = null;
		// Khai báo biến kiểm tra việc Thêm dữ liệu.
		bool Them = false;
		public frmWiner(string count, string level)
		{
			InitializeComponent();

			txtCount.Enabled = false;
			txtLevel.Enabled = false;
			txtCount.Text = count;
			txtLevel.Text = level;
		}

		private void btnClose_Click(object sender, EventArgs e)
		{
			DialogResult traloi;
			traloi = MessageBox.Show("Chắc không?", "Trả lời",
			MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
			if (traloi == DialogResult.OK)
				Close();
		}

		private void btnSave_Click(object sender, EventArgs e)
		{
			conn = new SqlConnection(strConnectionString);
			Them = true;
			// kiem chung du lieu
			if (!txtName.Text.Trim().Equals(""))
			{
				// Mở kết nối
				if (conn.State == ConnectionState.Open)
					conn.Close();
				conn.Open();
				// Thêm dữ liệu
				if (Them)
				{
					try
					{
						// Thực hiện lệnh
						SqlCommand cmd = new SqlCommand();
						cmd.Connection = conn;
						cmd.CommandType = CommandType.Text;
						// Lệnh Insert InTo
						cmd.CommandText = "Insert Into dbScore Values(N'" + txtName.Text.Trim() + "',N'" + txtCount.Text + "',N'" + txtLevel.Text + "')";
						cmd.ExecuteNonQuery();
						//LoadData();
						// Thông báo
						MessageBox.Show("Đã thêm xong!");
						this.Close();
					}
					catch (SqlException)
					{
						MessageBox.Show("Không thêm được. Lỗi rồi!");
					}
				}
				conn.Close();
			}
			else
			{
				MessageBox.Show("Chưa đặt tên kìa !!!");
				txtName.Focus();
			}
		}
		// _end_
	}
}
