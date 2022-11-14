namespace WinFormsApp4
{
    enum Curplayer { X, O }
    public partial class Form1 : Form
    {
        
       
        Curplayer ZK;
        public Form1()
        {
            InitializeComponent();
             ZK = Curplayer.X;


        }

        //layout panel
        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        //przyciski
        private void mark(object sender, EventArgs e)
        {
            Button senderButton = (Button)sender;
            if (ZK == Curplayer.X)
            {
               
                senderButton.Text = "X";
                ZK = Curplayer.O;
            } else {
                senderButton.Text = "O";
                ZK = Curplayer.X;
            }
            senderButton.Enabled = false;

        }


        //labelki
        private void gejmer_Click(object sender, EventArgs e)
        {

        }

        private void winner_Click(object sender, EventArgs e)
        {

        }


        public void changeLabel()
        {
            if(ZK == Curplayer.X)
            {

                gejmer.Text = "X";
            }
            if (ZK == Curplayer.O)
            {

                gejmer.Text = "O";
            }


        }

    }
}