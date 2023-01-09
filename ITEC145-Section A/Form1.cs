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
                                         //Initializes count variable.

            for(int i = 0; i < ints.Length; i++)
            {
                ints[i] = random.Next(0, 101);      //For loop to fill each integer location in ints array
            }
            

           
        }

        private void btnSum_Click(object sender, EventArgs e)
        {
            int sum = 0;        //intialises sum variable

            foreach(int i in ints)      //foreach to add each value stored in the array to sum
            {
                sum += i;
            }
            lstOutput.Items.Clear();    //clears listbox
            lstOutput.Items.Add("The sum of the array is: "+sum);   //adds sum variable to listbox
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnShowValues_Click(object sender, EventArgs e)
        {
            

            try          //exception handling
            {
                int subscript = int.Parse(txtStartSubscript.Text);  //converts textbox values to a variable
                int numberOfValues = int.Parse(txtValues.Text);

                if (subscript > 29 || numberOfValues > (30 - subscript))    //for when Steve tries to break program
                {
                    MessageBox.Show("Hi Steve, please stop trying to break my program :(");
                    MessageBox.Show("Just enter values that are within the bounds of my array...");
                    lstOutput.Items.Clear();
                    
                }
                else
                {
                    lstOutput.Items.Clear();
                    

                    for (int i = subscript; i < subscript + numberOfValues; i++)    //loop for index and value listboxes
                    {
                        lstOutput.Items.Add($"Index "+i+" has a value of " + ints[i]);
                        
                    }
                }
            }
            catch
            {
                MessageBox.Show("Please enter valid integers between 0-29!");
                lstOutput.Items.Clear();
                
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void btnShowArray_Click(object sender, EventArgs e)
        {
            lstOutput.Items.Clear();
            count = 0;

            do
            {
                lstOutput.Items.Add(ints.GetValue(count));      //Gets the value of each integer in each location using count variable
                count++;    //increments count each time do runs
            }
            while (count < ints.Length);     //do iterates until count hits ints array length
        }
    }
}