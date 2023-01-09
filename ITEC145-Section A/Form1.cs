namespace ITEC145_Section_A
{
    

    public partial class Form1 : Form
    {
        int[] ints = new int[30];           //Array to hold ints
        Random random = new Random();       //Random variable
        int count = 0;                      //Counter variable for do-while loop
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            lstOutput.Items.Clear();                //Clears listbox before filling it.
            count = 0;                              //Initializes count variable.

            for(int i = 0; i < ints.Length; i++)
            {
                ints[i] = random.Next(0, 101);      //For loop to fill each integer location in ints array
            }
            

            do
            {
                lstOutput.Items.Add(ints.GetValue(count));      //Gets the value of each integer in each location using count variable
                count++;    //increments count each time do runs
            } 
            while (count < ints.Length);     //do iterates until count hits ints array length
        }

        private void btnSum_Click(object sender, EventArgs e)
        {
            int sum = 0;        //intialises sum variable

            foreach(int i in ints)      //foreach to add each value stored in the array to sum
            {
                sum += i;
            }
            lstOutput.Items.Clear();    //clears listbox
            lstOutput.Items.Add(sum);   //adds sum variable to listbox
        }
    }
}