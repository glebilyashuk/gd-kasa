using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
	public partial class Form1 : Form
	{
		string ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;" +
			  "Data Source = C:/Users/Gleb/Desktop/Диплом/WindowsFormsApp1/WindowsFormsApp1/02_02_00_009_Baza_ru.mdb";

		private int act_table = 1;

		public string Connection { get; internal set; }

		public Form1()
		{
			InitializeComponent();
		}

		private void Form1_Load(object sender, EventArgs e)
		{
	        comboBox1.SelectedIndex = 0;
			button1_Click(sender, e);
			Get_Bilets();

		}

		private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
		{

		}

		private void toolStripMenuItem1_Click(object sender, EventArgs e)
		{

		}

		private void groupBox1_Enter(object sender, EventArgs e)
		{

		}

		private void button1_Click(object sender, EventArgs e)
		{
			string CommandText = "SELECT " +
	"[Перевозка].[Номер], " +
	"[Маршрут].[Номер маршрута], " +
	"[Маршрут].[Пункт назначения], " +
	"[Маршрут].[Время отправки], " +
	"[Маршрут].[Время прибытия], " +
	"[Билет].[Место], " +
	"[Билет].[Ф_И_О], " +
	"[Билет].[Стоимость], " +
	"[Водитель].[Ф_И_О] " +
  "FROM " +
	"[Перевозка], " +
	"[Маршрут], " +
	"[Билет], " +
	"[Водитель] " +
  "WHERE " +
	"([Перевозка].[ID_Marshrut]=[Маршрут].[ID_Marshrut]) AND " +
	"([Перевозка].[ID_Bilet] = [Билет].[ID_Bilet]) AND " +
	"([Перевозка].[ID_Voditel] = [Водитель].[ID_Voditel]) ";

			if (textBox1.Text != "")  // если набран текст в поле фильтра
			{
				if (comboBox1.SelectedIndex == 0) // № перевозки
					CommandText = CommandText + " AND ([Перевозка].[Номер] = '" + textBox1.Text + "')";
				if (comboBox1.SelectedIndex == 1) // № маршрута
					CommandText = CommandText + " AND (Маршрут.[Номер маршрута] = '" + textBox1.Text + "') ";

				if (comboBox1.SelectedIndex == 2) // Пункт назначения
					CommandText = CommandText + " AND (Маршрут.[Пункт назначения] LIKE '" + textBox1.Text + "%') ";
				if (comboBox1.SelectedIndex == 3) // Пассажир
					CommandText = CommandText + " AND (Билет.[Ф_И_О] LIKE '" + textBox1.Text + "%') ";
				if (comboBox1.SelectedIndex == 4) // Водитель
					CommandText = CommandText + " AND ([Водитель].[Ф_И_О] LIKE '" + textBox1.Text + "%') ";
			}

			OleDbDataAdapter dataAdapter = new OleDbDataAdapter(CommandText, ConnectionString);
			DataSet ds = new DataSet();
			dataAdapter.Fill(ds, "[Перевозка]");
			dataGridView1.DataSource = ds.Tables["[Перевозка]"].DefaultView;
		}

		private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
		{

		}

		private void button2_Click(object sender, EventArgs e)
		{
			string CommandText;
			string num_per, ID_M, ID_B, ID_D, ID_A, ID_V;
			int row;
			Form2 f = new Form2();
			if (f.ShowDialog() == DialogResult.OK) ;


		}
		private void Get_Bilets()  // читает все поля из таблицы "Билет"
		{
			string CommandText = "SELECT ID_Bilet, [Место], [Стоимость], [Время], [Ф_И_О], [Паспорт], [Льготы] FROM [Билет]";
			OleDbDataAdapter dataAdapter = new OleDbDataAdapter(CommandText, ConnectionString);

			// создаем объект DataSet
			DataSet ds = new DataSet();
			// заполняем dataGridView1 данными из таблицы "Билет" базы данных
			dataAdapter.Fill(ds, "[Билет]");
			dataGridView2.DataSource = ds.Tables[0].DefaultView;
			dataGridView2.Columns[0].Visible = false; // Прячем поле ID_Bilets
		}
		private void button4_Click(object sender, EventArgs e)
		{
			Get_Bilets();
			act_table = 1;
		}

		private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{

		}
		private void Get_Marshruts()  // читает все поля из таблицы "Маршрут"
		{
			string CommandText = "SELECT * FROM [Маршрут]";
			OleDbDataAdapter dataAdapter = new OleDbDataAdapter(CommandText, ConnectionString);
			DataSet ds = new DataSet();  // создаем объект DataSet
			dataAdapter.Fill(ds, "[Маршрут]");
			dataGridView2.DataSource = ds.Tables[0].DefaultView;
		}
		private void button5_Click(object sender, EventArgs e)
		{
			Get_Marshruts();
			act_table = 2;
		}
		private void Get_Avtobus()  // читает все поля из таблицы "Автобус"
		{
			string CommandText = "SELECT * FROM Автобус";
			OleDbDataAdapter dataAdapter = new OleDbDataAdapter(CommandText, ConnectionString);
			DataSet ds = new DataSet();  // создаем объект DataSet
			dataAdapter.Fill(ds, "Автобус"); // заполняем набор данных данными из таблицы "Автобус"
			dataGridView2.DataSource = ds.Tables[0].DefaultView;
			dataGridView2.Columns[0].Visible = false; // спрятать нулевой столбец (поле ID_Avtobus)
		}
		private void button6_Click(object sender, EventArgs e)
		{
			Get_Avtobus();
			act_table = 3;
		}
		private void Get_Voditel()  // читает все поля из таблицы "Водитель"
		{
			string CommandText = "SELECT * FROM Водитель";
			OleDbDataAdapter dataAdapter = new OleDbDataAdapter(CommandText, ConnectionString);
			DataSet ds = new DataSet();
			dataAdapter.Fill(ds, "Водитель");
			dataGridView2.DataSource = ds.Tables[0].DefaultView;
			dataGridView2.Columns[0].Visible = false;
		}
		private void button7_Click(object sender, EventArgs e)
		{
			Get_Voditel();
			act_table = 4;
		}

		private void button3_Click(object sender, EventArgs e)
		{
			Form4 f = new Form4();

			if (f.ShowDialog() == DialogResult.OK)
			{
				int index, index_old;
				string ID;
				string CommandText = "DELETE FROM ";

				index = dataGridView1.CurrentRow.Index; // № по порядку в таблице представления
				index_old = index;
				ID = Convert.ToString(dataGridView1[0, index].Value); // ID подаем в запрос как строку

				// Формируем строку CommandText
				CommandText = "DELETE FROM [Перевозка] WHERE [Перевозка].[Номер] = '" + ID + "'";

				// выполняем SQL-запрос
				//My_Execute_Non_Query(CommandText);

				// перерисовывание dbGridView1
				button1_Click(sender, e);

				if (index_old >= 0)
				{
					dataGridView1.ClearSelection();
					dataGridView1[0, index_old].Selected = true;
				}
			}
		}

		private void добавитьToolStripMenuItem_Click(object sender, EventArgs e)
		{

		}
	}
	}


