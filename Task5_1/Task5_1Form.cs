using MaterialSkin.Controls;

namespace Task5_1
{
    public partial class Task5_1Form : MaterialForm
    {
        void BubbleSort(int[] arr)
        {
            bool swapped;
            for (int i = 0; i < arr.Length - 1; i++)
            {
                swapped = false;
                for (int j = 0; j < arr.Length - i - 1; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        int temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                        swapped = true;
                    }
                }
                if (!swapped)
                    break;
            }
        }
        public Task5_1Form()
        {
            InitializeComponent();
        }

        int[] numbers = new int[9];
        private void btnGenerate_Click(object sender, EventArgs e)
        {
            listBoxResults.Items.Clear();
            Random random = new Random();

            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = random.Next(1, 101);
                listBoxResults.AddItem(numbers[i].ToString());
            }
        }

        private void btnSort_Click(object sender, EventArgs e)
        {
            listBoxResults.Items.Clear();
            BubbleSort(numbers);
            foreach(int i in numbers)
            {
                listBoxResults.AddItem(i.ToString());
            }
        }
    }
}
