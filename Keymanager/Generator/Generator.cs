using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;
using MySql.Data.MySqlClient;

namespace Generator
{
	// Token: 0x02000002 RID: 2
	public partial class Generator : MaterialForm
	{
		// Token: 0x06000001 RID: 1 RVA: 0x00002050 File Offset: 0x00000250
		public Generator()
		{
			this.InitializeComponent();
		}

		// Token: 0x06000002 RID: 2 RVA: 0x00002064 File Offset: 0x00000264
		private void button2_Click(object sender, EventArgs e)
		{
			string value = this.textBox1.Text.ToString();
			MySqlConnection mySqlConnection = new MySqlConnection(Generator.connectionString);
			try
			{
				mySqlConnection.Open();
				MessageBox.Show("Whitelisted");
				MySqlCommand mySqlCommand = mySqlConnection.CreateCommand();
				mySqlCommand.CommandText = "INSERT INTO serials(kay, black, used, IP, HWID)VALUES(@Key,@Blacklisted,@Used,@IP,@HWID)";
				mySqlCommand.Parameters.AddWithValue("@Key", value);
				mySqlCommand.Parameters.AddWithValue("@Used", 0);
				mySqlCommand.Parameters.AddWithValue("@Blacklisted", 0);
				mySqlCommand.Parameters.AddWithValue("@IP", 0);
				mySqlCommand.Parameters.AddWithValue("@HWID", 0);
				mySqlCommand.ExecuteNonQuery();
				mySqlConnection.Close();
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.ToString());
			}
		}

		// Token: 0x06000003 RID: 3 RVA: 0x00002154 File Offset: 0x00000354
		private void button1_Click(object sender, EventArgs e)
		{
			string text = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
			char[] array = new char[20];
			Random random = new Random();
			for (int i = 0; i < array.Length; i++)
			{
				array[i] = text[random.Next(text.Length)];
			}
			string text2 = new string(array);
			this.textBox1.Text = text2.ToString();
		}

		// Token: 0x06000004 RID: 4 RVA: 0x000021C0 File Offset: 0x000003C0
		private void button3_Click(object sender, EventArgs e)
		{
			MySqlConnection mySqlConnection = new MySqlConnection(Generator.connectionString);
			mySqlConnection.Open();
			try
			{
				MySqlCommand mySqlCommand = mySqlConnection.CreateCommand();
				mySqlCommand.CommandText = "SELECT * FROM serials";
				DataAdapter dataAdapter = new MySqlDataAdapter(mySqlCommand);
				DataSet dataSet = new DataSet();
				dataAdapter.Fill(dataSet);
				this.dataGridView1.DataSource = dataSet.Tables[0].DefaultView;
			}
			catch (Exception)
			{
				throw;
			}
			finally
			{
				bool flag = mySqlConnection.State == ConnectionState.Open;
				if (flag)
				{
					mySqlConnection.Clone();
				}
			}
		}

		// Token: 0x06000005 RID: 5 RVA: 0x00002268 File Offset: 0x00000468
		private void button4_Click(object sender, EventArgs e)
		{
			string value = this.textBox2.Text.ToString();
			this.dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
			try
			{
				foreach (object obj in ((IEnumerable)this.dataGridView1.Rows))
				{
					DataGridViewRow dataGridViewRow = (DataGridViewRow)obj;
					bool flag = dataGridViewRow.Cells[3].Value.ToString().Equals(value);
					if (flag)
					{
						dataGridViewRow.Selected = true;
						break;
					}
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.ToString());
			}
		}

		// Token: 0x06000006 RID: 6 RVA: 0x00002338 File Offset: 0x00000538
		private void button5_Click(object sender, EventArgs e)
		{
			MySqlConnection mySqlConnection = new MySqlConnection(Generator.connectionString);
			string str = this.textBox2.Text.ToString();
			try
			{
				mySqlConnection.Open();
				MessageBox.Show("Blacklisted");
				MySqlCommand mySqlCommand = mySqlConnection.CreateCommand();
				mySqlCommand.CommandText = "UPDATE serials SET black = '1' WHERE `serials`.`kay` = '" + str + "';";
				mySqlCommand.ExecuteNonQuery();
				mySqlConnection.Close();
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.ToString());
			}
		}

		// Token: 0x06000007 RID: 7 RVA: 0x000023C8 File Offset: 0x000005C8
		private void button6_Click(object sender, EventArgs e)
		{
			MySqlConnection mySqlConnection = new MySqlConnection(Generator.connectionString);
			string str = this.textBox2.Text.ToString();
			try
			{
				mySqlConnection.Open();
				MessageBox.Show("Whitelisted");
				MySqlCommand mySqlCommand = mySqlConnection.CreateCommand();
				mySqlCommand.CommandText = "UPDATE serials SET black = '0' WHERE `serials`.`kay` = '" + str + "';";
				mySqlCommand.ExecuteNonQuery();
				mySqlConnection.Close();
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.ToString());
			}
		}

		// Token: 0x06000008 RID: 8 RVA: 0x00002458 File Offset: 0x00000658
		private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
		}

		// Token: 0x06000009 RID: 9 RVA: 0x00002458 File Offset: 0x00000658
		private void Generator_Load(object sender, EventArgs e)
		{
		}

		// Token: 0x0600000A RID: 10 RVA: 0x00002458 File Offset: 0x00000658
		private void domainUpDown2_SelectedItemChanged(object sender, EventArgs e)
		{
		}

		// Token: 0x0600000B RID: 11 RVA: 0x0000245C File Offset: 0x0000065C
		private void button5_Click_1(object sender, EventArgs e)
		{
			MySqlConnection mySqlConnection = new MySqlConnection(Generator.connectionString);
			string str = this.textBox2.Text.ToString();
			try
			{
				mySqlConnection.Open();
				MessageBox.Show("Blacklisted");
				MySqlCommand mySqlCommand = mySqlConnection.CreateCommand();
				mySqlCommand.CommandText = "UPDATE serials SET black = '1' WHERE `serials`.`kay` = '" + str + "';";
				mySqlCommand.ExecuteNonQuery();
				mySqlConnection.Close();
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.ToString());
			}
		}

		// Token: 0x0600000C RID: 12 RVA: 0x000024EC File Offset: 0x000006EC
		private void button6_Click_1(object sender, EventArgs e)
		{
			MySqlConnection mySqlConnection = new MySqlConnection(Generator.connectionString);
			string str = this.textBox2.Text.ToString();
			try
			{
				mySqlConnection.Open();
				MessageBox.Show("Whitelisted");
				MySqlCommand mySqlCommand = mySqlConnection.CreateCommand();
				mySqlCommand.CommandText = "UPDATE serials SET black = '0' WHERE `serials`.`kay` = '" + str + "';";
				mySqlCommand.ExecuteNonQuery();
				mySqlConnection.Close();
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.ToString());
			}
		}

		// Token: 0x0600000D RID: 13 RVA: 0x00002458 File Offset: 0x00000658
		private void textBox1_TextChanged(object sender, EventArgs e)
		{
		}

		// Token: 0x0600000E RID: 14 RVA: 0x00002458 File Offset: 0x00000658
		private void button4_Click_1(object sender, EventArgs e)
		{
		}

		// Token: 0x0600000F RID: 15 RVA: 0x0000257C File Offset: 0x0000077C
		private void materialRaisedButton1_Click(object sender, EventArgs e)
		{
			string text = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
			char[] array = new char[20];
			Random random = new Random();
			for (int i = 0; i < array.Length; i++)
			{
				array[i] = text[random.Next(text.Length)];
			}
			string text2 = new string(array);
			this.textBox1.Text = text2.ToString();
		}

		// Token: 0x06000010 RID: 16 RVA: 0x000025E8 File Offset: 0x000007E8
		private void materialRaisedButton5_Click(object sender, EventArgs e)
		{
			string value = this.textBox1.Text.ToString();
			MySqlConnection mySqlConnection = new MySqlConnection(Generator.connectionString);
			try
			{
				mySqlConnection.Open();
				MessageBox.Show("Whitelisted");
				MySqlCommand mySqlCommand = mySqlConnection.CreateCommand();
				mySqlCommand.CommandText = "INSERT INTO serials(kay, black, used, IP, HWID)VALUES(@Key,@Blacklisted,@Used,@IP,@HWID)";
				mySqlCommand.Parameters.AddWithValue("@Key", value);
				mySqlCommand.Parameters.AddWithValue("@Used", 0);
				mySqlCommand.Parameters.AddWithValue("@Blacklisted", 0);
				mySqlCommand.Parameters.AddWithValue("@IP", 0);
				mySqlCommand.Parameters.AddWithValue("@HWID", 0);
				mySqlCommand.ExecuteNonQuery();
				mySqlConnection.Close();
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.ToString());
			}
		}

		// Token: 0x06000011 RID: 17 RVA: 0x000026D8 File Offset: 0x000008D8
		private void materialRaisedButton3_Click(object sender, EventArgs e)
		{
			MySqlConnection mySqlConnection = new MySqlConnection(Generator.connectionString);
			mySqlConnection.Open();
			try
			{
				MySqlCommand mySqlCommand = mySqlConnection.CreateCommand();
				mySqlCommand.CommandText = "SELECT * FROM serials";
				DataAdapter dataAdapter = new MySqlDataAdapter(mySqlCommand);
				DataSet dataSet = new DataSet();
				dataAdapter.Fill(dataSet);
				this.dataGridView1.DataSource = dataSet.Tables[0].DefaultView;
			}
			catch (Exception)
			{
				throw;
			}
			finally
			{
				bool flag = mySqlConnection.State == ConnectionState.Open;
				if (flag)
				{
					mySqlConnection.Clone();
				}
			}
		}

		// Token: 0x06000012 RID: 18 RVA: 0x00002780 File Offset: 0x00000980
		private void materialRaisedButton4_Click(object sender, EventArgs e)
		{
			MySqlConnection mySqlConnection = new MySqlConnection(Generator.connectionString);
			string str = this.textBox2.Text.ToString();
			try
			{
				mySqlConnection.Open();
				MessageBox.Show("Removed Key");
				MySqlCommand mySqlCommand = mySqlConnection.CreateCommand();
				mySqlCommand.CommandText = "DELETE FROM `serials` WHERE kay='" + str + "'";
				mySqlCommand.ExecuteNonQuery();
				mySqlConnection.Close();
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.ToString());
			}
		}

		// Token: 0x04000001 RID: 1
		public static string host = "remotemysql.com";

		// Token: 0x04000002 RID: 2
		public static string database = "utv6WwnN7N";

		// Token: 0x04000003 RID: 3
		public static string user = "utv6WwnN7N";

		// Token: 0x04000004 RID: 4
		public static string password = "5rUdiMAZLG";

		// Token: 0x04000005 RID: 5
		public static string connectionString = string.Concat(new string[]
		{
			"Data Source=",
			Generator.host,
			";Initial Catalog= ",
			Generator.database,
			";User ID=utv6WwnN7N;password=",
			Generator.password
		});
	}
}
