using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Linq;
using System.Data.SqlClient;
namespace УП______________________
{
    public partial class Form1 : Form
    {
        static string conStr = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=abd_12;Integrated Security=True";
        DataContext context = new DataContext(conStr);
        public Form1()
        {
            InitializeComponent();
            Table<Service> service = context.GetTable<Service>();
            dataGridView1.DataSource = service.ToList();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "abd_12DataSet.Service". При необходимости она может быть перемещена или удалена.
            this.serviceTableAdapter.Fill(this.abd_12DataSet.Service);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Service it = context.GetTable<Service>().FirstOrDefault(x => x.id == Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value));
            it.Title = comboBox1.Text;
            it.Cost = Convert.ToInt32(textBox1.Text);
            it.DurationInSeconds = Convert.ToInt32(textBox2.Text);
            it.Description = Convert.ToString(textBox3.Text);
            it.Discount = Convert.ToInt32(textBox4.Text);
            it.MainImagePath = comboBox2.Text;
            context.SubmitChanges();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form3 f3 = new Form3();
            f3.Show();
            Close();
        }
    }
}
