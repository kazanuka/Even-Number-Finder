namespace Quiz
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonSonuc_Click(object sender, EventArgs e)
        {
          
            int highNumber = Convert.ToInt32(textBoxHigh.Text);
            int lowNumber = Convert.ToInt32(textBoxLow.Text);
            labelNums.Text = "Even Numbers: ";
            
            while (lowNumber <= highNumber)
            {
                if(lowNumber % 2 == 0)
                {
                    labelNums.Text = labelNums.Text + "," + lowNumber;
                }

                lowNumber++;
            }
            //OR WE CAN DO THIS WITH FOR LOOP LIKE THAT
            
            /*for (int i = lowNumber; i <= highNumber; i++)
            {
                if (i % 2 == 0)
                {
                    labelNums.Text = labelNums.Text + "," + i;
                }
            } 
            */
         
        }
        private void textBoxDeger1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
//14.09.22 github.com/kazanuka