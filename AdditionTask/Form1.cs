using System;
using System.Linq;
using System.Windows.Forms;

namespace AdditionTask
{
    public partial class ShowData : Form
    {
        public ShowData()
        {
            InitializeComponent();
        }


        ModelEntityContainer db;
        private void ShowData_Load(object sender, EventArgs e)
        {

            db = new ModelEntityContainer(); // створюємо модель БД (привязуємо обєкт)
            //db.MyTables.

            // налаштування DataGridView (щоб заповнив все поле)
            dataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect; // як видіятиметься клітинка - вибереться вся строка
            dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill; // заповнення колонки

            
        }
        private void ShowData_FormClosed(object sender, FormClosedEventArgs e)
        {
            db.Dispose();
        }

        // заповнення таблиці
        private void ButtonShowData_Click(object sender, EventArgs e)
        {
            dataGridView.DataSource = db.MyTables.ToList();

            // так не хоче (хоча я підвязав Data Source у випадаючому вікні DataGridView на формі)
            // this.databaseBindingSource.DataSource = db.MyTables.Local.ToList();
        }
    }
}
