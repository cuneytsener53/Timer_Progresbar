namespace Timer_Donguler
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            progressBar1.Value += 10;

            if (progressBar1.Value%20 == 10)
            {
                label1.BackColor = Color.Red;
            }
            if (progressBar1.Value%20 == 0)
            {
                label1.BackColor = Color.White;
            }
            if (progressBar1.Value == 100)
            {
                timer1.Stop();
                MessageBox.Show("Pasta Pi�irme Tamamland�");
                timer2.Start();
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            progressBar2.Value +=5;
            if (progressBar2.Value%10 == 0)
            {
                label2.BackColor = Color.Red;
            }
            if (progressBar2.Value%10 == 5)
            {
                label2.BackColor = Color.White;
            }
            if (progressBar2.Value ==100)
            {
                timer2.Stop();
                MessageBox.Show("��rpma ��lemi Yap�lm��t�r");
                timer3.Start();
            }
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            progressBar3.Value += 20;
            if(progressBar3.Value%40 == 0)
            {
                label3.BackColor = Color.Red;
            }
            if (progressBar3.Value%40 == 20)
            {
                label3.BackColor = Color.White;
            }
            if (progressBar3.Value == 100)
            {
                timer3.Stop();
                MessageBox.Show("��lem Tamamland�");
                timer4.Start();
            }
        }

        private void timer4_Tick(object sender, EventArgs e)
        {
            progressBar4.Value += 10;

            if (progressBar4.Value%40 == 0)
            {
                label4.BackColor = Color.Red;
            }
            if (progressBar4.Value%40 == 20)
            {
                label4.BackColor = Color.White;
            }

            if (progressBar4.Value ==100)
            {
                timer4.Stop();
                MessageBox.Show("Pastam�z Haz�rd�r Afiyetle yiyebilirsiniz.");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
           this.Close();
            Application.Exit();
        }
    }
}