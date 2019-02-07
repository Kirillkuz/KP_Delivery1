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
using System.IO;

namespace KP_Delivery3
{
	public partial class Form1 : Form
	{
		SqlConnection sqlConnection;
		SqlConnection sqlConnection1;
		SqlConnection sqlConnection2;
		SqlConnection sqlConnection3;

		public Form1()
		{
			InitializeComponent();
		}

		private void deliveryBindingNavigatorSaveItem_Click(object sender, EventArgs e)
		{
			this.Validate();
			this.deliveryBindingSource.EndEdit();
			this.orderBindingSource.EndEdit();
			this.prodBindingSource.EndEdit();
			this.userBindingSource.EndEdit();
			this.tableAdapterManager.UpdateAll(this.database1DataSet);

		}

		private async void UpdateUser()
		{
			//Загружаем таблицу User в ListBox

			listBox1.Items.Clear();

			SqlDataReader sqlReader = null;

			SqlCommand command = new SqlCommand("SELECT * FROM [User]", sqlConnection);

			try
			{
				
				

				sqlReader = await command.ExecuteReaderAsync();
				
				while (await sqlReader.ReadAsync())
				{	
					
					listBox1.Items.Add(Convert.ToString(sqlReader["User_ID"]) + "		" + Convert.ToString(sqlReader["User_Name"]));
					
				}
				
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message.ToString(), ex.Source.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			finally
			{
				if (sqlReader != null)
					sqlReader.Close();
				
			}
			
		}
		private async void UpdateProd()
		{
			//Загружаем таблицу Prod в ListBox

			listBox2.Items.Clear();
			listBox5.Items.Clear();
			SqlDataReader sqlReader1 = null;

			SqlCommand command1 = new SqlCommand("SELECT * FROM [Prod]", sqlConnection1);

			try
			{
				sqlReader1 = await command1.ExecuteReaderAsync();

				while (await sqlReader1.ReadAsync())
				{
					if (Convert.ToBoolean(sqlReader1["Prod_Visibl"])==true)
					{
						listBox2.Items.Add(Convert.ToString(sqlReader1["Prod_Code"])
							+ "		" + Convert.ToString(sqlReader1["Prod_Name"])
							+ "		" + Convert.ToString(sqlReader1["Prod_Price"]));
					}
					else
					{
						listBox5.Items.Add(Convert.ToString(sqlReader1["Prod_Code"])
							+ "		" + Convert.ToString(sqlReader1["Prod_Name"])
							+ "		" + Convert.ToString(sqlReader1["Prod_Price"]));
					}
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message.ToString(), ex.Source.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			finally
			{
				if (sqlReader1 != null)
					sqlReader1.Close();
			}
		}

		private async void UpdateDelivery()
		{
			//Загружаем таблицу Delivery в ListBox

			listBox3.Items.Clear();

			SqlDataReader sqlReader2 = null;

			SqlCommand command2 = new SqlCommand("SELECT * FROM [Delivery]", sqlConnection2);

			try
			{
				sqlReader2 = await command2.ExecuteReaderAsync();

				while (await sqlReader2.ReadAsync())
				{
					DateTime date1 = Convert.ToDateTime(sqlReader2["Order_Date_1"]);
					DateTime date2 = Convert.ToDateTime(sqlReader2["Order_Date_2"]);

					listBox3.Items.Add(Convert.ToString(sqlReader2["Order_Code"])
						+ "	" + date1.ToString("dd/MM/yyyy")
						+ "	" + Convert.ToString(sqlReader2["Order_Address"])
						+ "	" + date2.ToString("dd/MM/yyyy")
						+ "	" + Convert.ToString(sqlReader2["User_Code"])
						+ "	" + Convert.ToString(sqlReader2["Order_Total_Price"]));
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message.ToString(), ex.Source.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			finally
			{
				if (sqlReader2 != null)
					sqlReader2.Close();
			}
		}

		private async void UpdateOrder()
		{
			//Загружаем таблицу Order в ListBox

			listBox4.Items.Clear();

			SqlDataReader sqlReader3 = null;

			SqlCommand command3 = new SqlCommand("SELECT * FROM [Order]", sqlConnection3);

			try
			{
				sqlReader3 = await command3.ExecuteReaderAsync();

				while (await sqlReader3.ReadAsync())
				{
					listBox4.Items.Add(Convert.ToString(sqlReader3["Prod_Code"])
						+ "		" + Convert.ToString(sqlReader3["Order_Code"])
						+ "		" + Convert.ToString(sqlReader3["Delivery_Prod_Sum"]));
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message.ToString(), ex.Source.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			finally
			{
				if (sqlReader3 != null)
					sqlReader3.Close();
			}
		}

		private async void Form1_Load(object sender, EventArgs e)
		{
			this.userTableAdapter.Fill(this.database1DataSet.User);

			// TODO: данная строка кода позволяет загрузить данные в таблицу "database1DataSet.Prod". При необходимости она может быть перемещена или удалена.
			this.prodTableAdapter.Fill(this.database1DataSet.Prod);
			// TODO: данная строка кода позволяет загрузить данные в таблицу "database1DataSet.Delivery". При необходимости она может быть перемещена или удалена.
			this.deliveryTableAdapter1.Fill(this.database1DataSet.Delivery);		// TODO: данная строка кода позволяет загрузить данные в таблицу "database1DataSet.Order". При необходимости она может быть перемещена или удалена.
			this.orderTableAdapter.Fill(this.database1DataSet.Order);

            //Добавили путь к базе
            string dir = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location);
            dir = dir.Substring(0, dir.Length - 10);
            dir = Path.Combine(dir, @"Database1.mdf");
            string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename="+dir+";Integrated Security=True";
            //C:\Users\Diablo\source\repos\KP_Delivery3\KP_Delivery3\Database1.mdf
            comboBox1.DataSource = userBindingSource;
			comboBox1.DisplayMember = "User_Name";// столбец для отображения
			comboBox1.ValueMember = "User_ID";//столбец с id

			comboBox2.DataSource = userBindingSource;
			comboBox2.DisplayMember = "User_Name";// столбец для отображения
			comboBox2.ValueMember = "User_ID";//столбец с id

			comboBox3.DataSource = prodBindingSource;
			comboBox3.DisplayMember = "Prod_Name";// столбец для отображения
			comboBox3.ValueMember = "Prod_Code";//столбец с id

			comboBox4.DataSource = deliveryBindingSource;
			comboBox4.DisplayMember = "Order_Code";// столбец для отображения
			comboBox4.ValueMember = "Order_Code";//столбец с id

			comboBox5.DataSource = prodBindingSource;
			comboBox5.DisplayMember = "Prod_Name";// столбец для отображения
			comboBox5.ValueMember = "Prod_Code";//столбец с id

			comboBox6.DataSource = deliveryBindingSource;
			comboBox6.DisplayMember = "Order_Code";// столбец для отображения
			comboBox6.ValueMember = "Order_Code";//столбец с id

			comboBox7.DataSource = prodBindingSource;
			comboBox7.DisplayMember = "Prod_Name";// столбец для отображения
			comboBox7.ValueMember = "Prod_Code";//столбец с id

			comboBox8.DataSource = deliveryBindingSource;
			comboBox8.DisplayMember = "Order_Code";// столбец для отображения
			comboBox8.ValueMember = "Order_Code";//столбец с id


			sqlConnection = new SqlConnection(connectionString);
			sqlConnection1 = new SqlConnection(connectionString);
			sqlConnection2 = new SqlConnection(connectionString);
			sqlConnection3 = new SqlConnection(connectionString);

			await sqlConnection.OpenAsync();
			await sqlConnection1.OpenAsync();
			await sqlConnection2.OpenAsync();
			await sqlConnection3.OpenAsync();
			//Загружаем таблицу User в ListBox
			UpdateUser();
			//Загружаем таблицу Prod в ListBox
			UpdateProd();
			//Загружаем таблицу Delivery в ListBox
			UpdateDelivery();
			//Загружаем таблицу Order в ListBox
			UpdateOrder();

		}

		private void toolStripButton1_Click(object sender, EventArgs e)
		{
			if (sqlConnection != null && sqlConnection.State != ConnectionState.Closed)
				sqlConnection.Close();
		}

		private void Form1_FormClosing(object sender, FormClosingEventArgs e)
		{
			if (sqlConnection != null && sqlConnection.State != ConnectionState.Closed)
				sqlConnection.Close();
		}
		//Добавление User
		private async void button1_Click(object sender, EventArgs e)
		{
			if (label2.Visible)
				label2.Visible = false;
			if (!string.IsNullOrEmpty(textBox1.Text) && !string.IsNullOrWhiteSpace(textBox1.Text))
			{
				SqlCommand command = new SqlCommand("INSERT INTO [User] (User_Name)VALUES(@User_Name)", sqlConnection);

				command.Parameters.AddWithValue("User_Name", textBox1.Text);

				await command.ExecuteNonQueryAsync();

				UpdateUser();

				textBox1.Text = "";
			}
			else
			{
				label2.Visible = true;
				label2.Text = "Поле имя должно быть заполнено";
			}

		}

		
		//Изменение User
		private async void button2_Click(object sender, EventArgs e)
		{
			if (label2.Visible)
				label2.Visible = false;
			if (!string.IsNullOrEmpty(textBox2.Text) && !string.IsNullOrWhiteSpace(textBox2.Text) 
				&& !string.IsNullOrEmpty(textBox3.Text) && !string.IsNullOrWhiteSpace(textBox3.Text))
			{
				SqlCommand command = new SqlCommand("UPDATE [User] SET [User_Name]=@User_Name WHERE [User_ID]=@User_ID",sqlConnection);

				command.Parameters.AddWithValue("User_ID", textBox2.Text);

				command.Parameters.AddWithValue("User_Name",textBox3.Text);

				await command.ExecuteNonQueryAsync();

				textBox2.Text = "";

				textBox3.Text = "";

				UpdateUser();
			}
			else if (!string.IsNullOrEmpty(textBox2.Text) && !string.IsNullOrWhiteSpace(textBox2.Text))
			{
				label2.Visible = true;
				label2.Text = "Поле ID должно быть заполнено";
			}
			else
			{
				label2.Visible = true;
				label2.Text = "Поле Имя должно быть заполнено";
			}
		}
		//Удаление User
		private async void button3_Click(object sender, EventArgs e)
		{
			if (label2.Visible)
				label2.Visible = false;

			if (!string.IsNullOrEmpty(textBox4.Text) && !string.IsNullOrWhiteSpace(textBox4.Text))
			{
				SqlCommand command = new SqlCommand("DELETE FROM [User] WHERE [User_ID]=@User_ID",sqlConnection);
				SqlCommand command1 = new SqlCommand("DELETE FROM[Delivery] WHERE[User_Code] = @User_ID", sqlConnection2);
				command.Parameters.AddWithValue("User_ID", textBox4.Text);
				command1.Parameters.AddWithValue("User_ID", textBox4.Text);
				await command1.ExecuteNonQueryAsync();
				await command.ExecuteNonQueryAsync();
				textBox4.Text = "";
				UpdateUser();
				UpdateDelivery();
			}
			else
			{
				label2.Visible = true;
				label2.Text = "Поле ID должно быть заполнено";
			}
		}
		//Добавление Prod
		private async void button6_Click(object sender, EventArgs e)
		{
			if (label9.Visible)
				label9.Visible = false;
			if (!string.IsNullOrEmpty(textBox8.Text) && !string.IsNullOrWhiteSpace(textBox8.Text)
				&& !string.IsNullOrEmpty(textBox9.Text) && !string.IsNullOrWhiteSpace(textBox9.Text))
			{
				SqlCommand command1 = new SqlCommand("INSERT INTO [Prod] (Prod_Name, Prod_Price)VALUES(@Prod_Name, @Prod_Price)", sqlConnection1);

				command1.Parameters.AddWithValue("Prod_Name", textBox8.Text);

				command1.Parameters.AddWithValue("Prod_Price", textBox9.Text);

				await command1.ExecuteNonQueryAsync();

				UpdateProd();

				textBox8.Text = "";
				textBox9.Text = "";
			}
			else
			{
				label9.Visible = true;
				label9.Text = "Поля имя продукта и цена продукта должны быть заполнены";
			}

		}
		//Изменение Prod
		private async void button5_Click(object sender, EventArgs e)
		{
			if (label9.Visible)
				label9.Visible = false;
			if (!string.IsNullOrEmpty(textBox7.Text) && !string.IsNullOrWhiteSpace(textBox7.Text)
				&& !string.IsNullOrEmpty(textBox6.Text) && !string.IsNullOrWhiteSpace(textBox6.Text)
				&& !string.IsNullOrEmpty(textBox10.Text) && !string.IsNullOrWhiteSpace(textBox10.Text))
			{
				SqlCommand command1 = new SqlCommand("UPDATE [Prod] SET [Prod_Name]=@Prod_Name, [Prod_Price]=@Prod_Price " +
					"WHERE [Prod_Code]=@Prod_Code", sqlConnection1);

				command1.Parameters.AddWithValue("Prod_Code", textBox7.Text);

				command1.Parameters.AddWithValue("Prod_Name", textBox6.Text);

				command1.Parameters.AddWithValue("Prod_Price", textBox10.Text);

				await command1.ExecuteNonQueryAsync();

				textBox7.Text = "";

				textBox6.Text = "";

				textBox10.Text = "";

				UpdateProd();
			}
			else if (!string.IsNullOrEmpty(textBox7.Text) && !string.IsNullOrWhiteSpace(textBox7.Text))
			{
				label9.Visible = true;
				label9.Text = "Поле ID должно быть заполнено";
			}
			else
			{
				label9.Visible = true;
				label9.Text = "Поля имя продукта и цена продукта должны быть заполнены";
			}
		}
		//Удаление Prod
		private async void button4_Click(object sender, EventArgs e)
		{
			if (label9.Visible)
				label9.Visible = false;

			if (!string.IsNullOrEmpty(textBox5.Text) && !string.IsNullOrWhiteSpace(textBox5.Text))
			{
				SqlCommand command1 = new SqlCommand("UPDATE [Prod] SET [Prod_Visibl]=@Prod_Visibl WHERE [Prod_Code]=@Prod_Code", sqlConnection1);
				command1.Parameters.AddWithValue("Prod_Visibl", false);
				command1.Parameters.AddWithValue("Prod_Code", textBox5.Text);
				await command1.ExecuteNonQueryAsync();
				textBox5.Text = "";
				UpdateProd();
			}
			else
			{
				label9.Visible = true;
				label9.Text = "Поле ID должно быть заполнено";
			}
		}
		//Добавление Delivery
		private async void button9_Click(object sender, EventArgs e)
		{
			if (label18.Visible)
				label18.Visible = false;
			if (!string.IsNullOrEmpty(textBox16.Text) && !string.IsNullOrWhiteSpace(textBox16.Text))
			{
				SqlCommand command2 = new SqlCommand("INSERT INTO [Delivery] (Order_Address, Order_Date_2, User_Code)VALUES(@Order_Address, @Order_Date_2, @User_Code)", sqlConnection2);

				command2.Parameters.AddWithValue("Order_Address", textBox16.Text);

				command2.Parameters.AddWithValue("Order_Date_2", dateTimePicker1.Value);

				command2.Parameters.AddWithValue("User_Code", comboBox1.SelectedValue);

				await command2.ExecuteNonQueryAsync();

				UpdateDelivery();

				textBox16.Text = "";
				
			}
			else
			{
				label18.Visible = true;
				label18.Text = "Поля имя продукта и цена продукта должны быть заполнены";
			}
		}
		//Изменение Delivery
		private async void button8_Click(object sender, EventArgs e)
		{
			if (label9.Visible)
				label9.Visible = false;
			if (!string.IsNullOrEmpty(textBox15.Text) && !string.IsNullOrWhiteSpace(textBox15.Text)
				&& !string.IsNullOrEmpty(textBox11.Text) && !string.IsNullOrWhiteSpace(textBox11.Text))
			{
				SqlCommand command2 = new SqlCommand("UPDATE [Delivery] SET [Order_Address]=@Order_Address, [Order_Date_2]=@Order_Date_2, [User_Code]=@OUser_Code" +
					"WHERE [Order_Code]=@Order_Code", sqlConnection2);

				command2.Parameters.AddWithValue("Order_Code", textBox15.Text);

				command2.Parameters.AddWithValue("Order_Address", textBox11.Text);

				command2.Parameters.AddWithValue("Order_Date_2", dateTimePicker2.Value);

				command2.Parameters.AddWithValue("User_Code", comboBox2.SelectedValue);

				await command2.ExecuteNonQueryAsync();

				textBox15.Text = "";

				textBox11.Text = "";

				

				UpdateDelivery();
			}
			else if (!string.IsNullOrEmpty(textBox15.Text) && !string.IsNullOrWhiteSpace(textBox15.Text))
			{
				label9.Visible = true;
				label9.Text = "Поле ID должно быть заполнено";
			}
			else
			{
				label9.Visible = true;
				label9.Text = "Поля имя продукта и цена продукта должны быть заполнены";
			}
		}
		//Удаление Delivery
		private async void button7_Click(object sender, EventArgs e)
		{
			if (label18.Visible)
				label18.Visible = false;

			if (!string.IsNullOrEmpty(textBox13.Text) && !string.IsNullOrWhiteSpace(textBox13.Text))
			{
				SqlCommand command2 = new SqlCommand("DELETE FROM [Delivery] WHERE [Order_Code]=@Order_Code", sqlConnection2);
				SqlCommand command5 = new SqlCommand("DELETE FROM [Order] WHERE [Order_Code]=@Order_Code", sqlConnection3);
				command2.Parameters.AddWithValue("Order_Code", textBox13.Text);
				command5.Parameters.AddWithValue("Order_Code", textBox13.Text);
				await command5.ExecuteNonQueryAsync();
				await command2.ExecuteNonQueryAsync();
				textBox13.Text = "";
				UpdateDelivery();
				UpdateOrder();
			}
			else
			{
				label18.Visible = true;
				label18.Text = "Поле ID должно быть заполнено";
			}
		}
		//Добавление Order
		private async void button12_Click(object sender, EventArgs e)
		{
			if (label25.Visible)
				label25.Visible = false;
			if (!string.IsNullOrEmpty(textBox22.Text) && !string.IsNullOrWhiteSpace(textBox22.Text))
			{
				SqlCommand command3 = new SqlCommand("INSERT INTO [Order] (Prod_Code, Order_Code, Delivery_Prod_Sum)VALUES(@Prod_Code, @Order_Code, @Delivery_Prod_Sum)", sqlConnection3);

				command3.Parameters.AddWithValue("Prod_Code", comboBox3.SelectedValue);

				command3.Parameters.AddWithValue("Order_Code", comboBox4.SelectedValue);

				command3.Parameters.AddWithValue("Delivery_Prod_Sum", textBox22.Text);

				await command3.ExecuteNonQueryAsync();

				UpdateOrder();

				textBox22.Text = "";

			}
			else
			{
				label25.Visible = true;
				label25.Text = "Поля имя продукта и цена продукта должны быть заполнены";
			}
		}
		//Изменение Order
		private async void button11_Click(object sender, EventArgs e)
		{
			if (label25.Visible)
				label25.Visible = false;
			if (!string.IsNullOrEmpty(textBox21.Text) && !string.IsNullOrWhiteSpace(textBox21.Text))
			{
				SqlCommand command3 = new SqlCommand("UPDATE [Order] SET [Delivery_Prod_Sum]=@Delivery_Prod_Sum WHERE [Prod_Code]=@Prod_Code AND [Order_Code]=@Order_Code", sqlConnection3);
				command3.Parameters.AddWithValue("Delivery_Prod_Sum", textBox21.Text);
				command3.Parameters.AddWithValue("Order_Code", comboBox6.SelectedValue);
				command3.Parameters.AddWithValue("Prod_Code", comboBox5.SelectedValue);
				await command3.ExecuteNonQueryAsync();
				textBox21.Text = "";
				UpdateOrder();
			}
			else if (!string.IsNullOrEmpty(textBox21.Text) && !string.IsNullOrWhiteSpace(textBox21.Text))
			{
				label25.Visible = true;
				label25.Text = "Поле ID должно быть заполнено";
			}
			else
			{
				label25.Visible = true;
				label25.Text = "Поля имя продукта и цена продукта должны быть заполнены";
			}
		}

		private async void button10_Click(object sender, EventArgs e)
		{
			if (label18.Visible)
				label18.Visible = false;

			if (1==1)
			{
				SqlCommand command3 = new SqlCommand("DELETE FROM [Order] WHERE [Order_Code]=@Order_Code and [Prod_Code]=@Prod_Code ", sqlConnection3);
				
				command3.Parameters.AddWithValue("Order_Code", comboBox8.SelectedValue);

				command3.Parameters.AddWithValue("Prod_Code", comboBox7.SelectedValue);
				await command3.ExecuteNonQueryAsync();
				//textBox13.Text = "";
				UpdateOrder();
			}
			else
			{
				label18.Visible = true;
				label18.Text = "Поле ID должно быть заполнено";
			}
		}

		private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
			{
				e.Handled = true;
			}

		}

		private async void button13_Click(object sender, EventArgs e)
		{
			if (label9.Visible)
				label9.Visible = false;

			if (!string.IsNullOrEmpty(textBox12.Text) && !string.IsNullOrWhiteSpace(textBox12.Text))
			{
				SqlCommand command1 = new SqlCommand("UPDATE [Prod] SET [Prod_Visibl]=@Prod_Visibl WHERE [Prod_Code]=@Prod_Code", sqlConnection1);
				command1.Parameters.AddWithValue("Prod_Visibl", true);
				command1.Parameters.AddWithValue("Prod_Code", textBox12.Text);
				await command1.ExecuteNonQueryAsync();
				textBox12.Text = "";
				UpdateProd();
			}
			else
			{
				label9.Visible = true;
				label9.Text = "Поле ID должно быть заполнено";
			}
		}
	}
}
