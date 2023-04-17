using Microsoft.VisualBasic;
using System.Windows.Forms;

namespace veter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
            private string[] nombre = new string[6];
         private string[] Nombree = new string[6];
      private   DateTime?[] FechadeNacimiento = new DateTime?[6];
       private DateTime?[] FechadeNacimientoo = new DateTime?[6];

        private  int i = 0;

         private void Button1_Click(object sender, EventArgs e)
        {
            nombre[i] = textBox1.Text;
            Nombree[i] = textBox2.Text;
            FechadeNacimiento[i] = dtmp.Value;
            FechadeNacimientoo[i] = dtm2.Value;

            Interaction.MsgBox("arreglo" + (i) + "registrado");

            if (i == 5)
                Interaction.MsgBox("esta lleno");
            else
                i = i + 1;
        }

        private  void Button2_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Add(textBox1.Text, dtmp.Value, textBox2.Text, dtm2.Value);

            textBox1.Text = "";
            textBox2.Text = "";
        }

       
    }
}
