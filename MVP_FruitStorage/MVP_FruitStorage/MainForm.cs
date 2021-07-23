using MVP_FruitStorage.Presenter;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MVP_FruitStorage
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void ФруктохранилищеToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
             FruitSoragePresenter fruit = new FruitSoragePresenter();
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e) => Application.Exit();

        private void отчетExelToolStripMenuItem_Click(object sender, EventArgs e)
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
                       fruit_storageDataSet1.FruitStorages.Columns)
                        StreamWritersclad.Write(Column.Caption + "\t");
                    StreamWritersclad.WriteLine();
                    // Экспорт записей
                    foreach (System.Data.DataRow Row in fruit_storageDataSet1.FruitStorages.Rows)
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
    }
}
