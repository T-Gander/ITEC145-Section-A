namespace ITEC145_Section_A
{
    

    public partial class Form1 : Form
    {
        int[] ints = new int[30];
        Random random = new Random();
        int count = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            lstOutput.Items.Clear();
            count = 0;

            for(int i = 0; i < ints.Length; i++)
            {
                ints[i] = random.Next(0, 101);
            }
            

            do
            {
                lstOutput.Items.Add(ints.GetValue(count));
                count++;
            } 
            while (count < 30);
        }

        private void btnSum_Click(object sender, EventArgs e)
        {
            int sum = 0;

            foreach(int i in ints)
            {
                sum += i;
            }
            lstOutput.Items.Clear();
            lstOutput.Items.Add(sum);
        }
    }
}