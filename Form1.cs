

namespace Lottery

{
    public partial class Form1 : Form
    {

        


        public Form1()
        {
            InitializeComponent();

            clearLabels();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {

        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
         
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
          
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
           
        }

        private void cutToolStripButton_Click(object sender, EventArgs e)
        {
          
        }

        private void copyToolStripButton_Click(object sender, EventArgs e)
        {
            
        }

        private void pasteToolStripButton_Click(object sender, EventArgs e)
        {
           
        }

        private void newToolStripButton_Click(object sender, EventArgs e)
        {
          
        }

        private void openToolStripButton_Click(object sender, EventArgs e)
        {

        }

        private void openFileDialog1_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
        {

           

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }




        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
           Random generator = new Random();

            int newNumber = generator.Next(1,100);
            label3.Text = newNumber.ToString();

        } 



            private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void timer3_Tick(object sender, EventArgs e)
        {

        }

      

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

      
        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void clearLabels()
        {
            for (int x = 0; x < 1; x++)
            {
                label3.Text = String.Empty;

            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            Random r = new Random();
            int n = r.Next();
            int x = 5;

            do
            {
                n = r.Next(0, 100);
                if (!listBox1.Items.Contains(n))
                    listBox1.Items.Add(n);

            } while ((listBox1.Items.Count != x));
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {

        }

        private void button14_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click_1(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Double CostofItem = 10;
            foreach (DataGridViewRow row in this.dataGridView1.SelectedRows)
            {
                if ((bool)(row.Cells[0].Value = "3"))
                {
                    row.Cells[1].Value = Double.Parse((String)row.Cells[1].Value + 1);
                    row.Cells[2].Value = Double.Parse((String)row.Cells[1].Value) * CostofItem;
                }
            }
            dataGridView1.Rows.Add("3", "1", CostofItem);
          
        }
      

        //public double Cost_of_Items()
        //{
        //    Double sum = 0;
        //    int i = 0;

        //    for (i = 0; i < (dataGrid)

        //}
    }
}