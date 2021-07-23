using MVP_FruitStorage.Models;
using MVP_FruitStorage.Presenter;
using MVP_FruitStorage.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MVP_FruitStorage
{
    public partial class Form2<T> : Form, Interface1
        where T : class
    {  
        FruitSoragePresenter insertFruit;     
        public Form2() => InitializeComponent();
        private void Form2_Load(object sender, EventArgs e)
        {
            insertFruit = new FruitSoragePresenter(this);
        }
        List<Sotr> Interface1.kod_sotr
        {
            set
            {
                comboBox1.DataSource = value;
                comboBox1.DisplayMember = "Fio";
                comboBox1.ValueMember = "kod_sotr";
                comboBox4.DataSource = value;
                comboBox4.DisplayMember = "Fio";
                comboBox4.ValueMember = "kod_sotr";
            }
        }

        List<FruitStorage> Interface1.fruitOut
        {
            set
            {
               
                dataGridView.DataSource = value;
                dataGridView.Columns["Sotr"].Width = 200;
                dataGridView.Columns["Kod_sotr"].Visible = false;
                dataGridView.Columns["Chamber"].Visible = false;
                dataGridView.Columns["FruitStorageKod"].Visible = false;

            }
        }

        List<Сell> Interface1.kod_cell
        {
            set
            {
                comboBox2.DataSource = value;
                comboBox2.DisplayMember = "Kod_cell";
                comboBox2.ValueMember = "Kod_cell";
            }
        }

        List<Сhamber> Interface1.kod_chamber
        {
            set
            {
                comboBox3.DataSource = value;
                comboBox3.DisplayMember = "Nomer";
                comboBox3.ValueMember = "Kod_chamber";
            }
        }
        public int Kod_cell => int.Parse(comboBox2.Text);
        public int Kod_chamber => int.Parse(comboBox3.SelectedValue.ToString());
        public int Kod_sotr => int.Parse(comboBox1.SelectedValue.ToString());
        public int SotrSort => int.Parse(comboBox4.SelectedValue.ToString());
        public int Wheight => int.Parse(textBox1.Text);

        public string Freecham
        {
            set => label6.Text = value;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            insertFruit.AddFruit();
          
        }

        private void Button2_Click(object sender, EventArgs e)
        {

          
            insertFruit.SortSotr();

        }
        private void ComboBox3_MouseClick(object sender, MouseEventArgs e)
        {
            insertFruit.FreeChamber();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            saveFileDialog1.DefaultExt = "xls";
            // фильтры, применяемые при сохранении
            saveFileDialog1.Filter = "Excel files(*.xls)|*.xls";
            // заголовок окна сохранения
            saveFileDialog1.Title = "Экспорт: Excel";
            if (saveFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                // создание потока записи данных
                FileStream VidStrahStream =
                    new FileStream(saveFileDialog1.FileName, FileMode.Create);
                try
                {
                    // экспорт данных в файл
                    StreamWriter StreamWritersclad =
                        new StreamWriter(VidStrahStream, System.Text.Encoding.Unicode);
                    // экспорт заголовков полей
                    foreach (System.Data.DataColumn Column in
                       dataGridView.Columns)
                        StreamWritersclad.Write(Column.Caption + "\t");
                    StreamWritersclad.WriteLine();
                    // Экспорт записей
                    foreach (System.Data.DataRow Row in dataGridView.Rows)
                    {
                        foreach (object Entity in Row.ItemArray)
                        {
                            StreamWritersclad.Write(Entity.ToString() + "\t");
                        }
                        StreamWritersclad.WriteLine();
                    }
                    StreamWritersclad.Flush(); // очистка
                }
                catch
                {
                    MessageBox.Show("При передаче данных возникла ошибка!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                VidStrahStream.Close();
            }
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

      

   

        private void dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            MessageBox.Show(dataGridView.SelectedCells.ToString());
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            var s = dataGridView.SelectedCells[0].RowIndex.ToString();
            int s1 = Convert.ToInt32(s);
            DataGridViewCell cell = dataGridView.Rows[s1].Cells[0];
            int i = Convert.ToInt32(cell.Value);
          

            insertFruit.deletedvalue(i);
            
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            insertFruit.AddFruit();
        }
    }
}
