using MaterialSkin.Controls;

namespace Task5_2
{
    public partial class Task5_2Form : MaterialForm
    {
        int[] numbers = new int[9];
        public Task5_2Form()
        {
            InitializeComponent();
        }

        private void btnSort_Click(object sender, EventArgs e)
        {
            listBoxResults.Items.Clear();
            Sorter sorter = new Sorter(numbers);
            sorter.SortDescending();

            foreach (int i in sorter.GetSortedArray())
            {
                listBoxResults.AddItem(i.ToString());
            }
        }

        private void btnGen_Click(object sender, EventArgs e)
        {
            listBoxResults.Items.Clear();
            Random random = new Random();
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = random.Next(1, 101);
                listBoxResults.AddItem(numbers[i].ToString());
            }
        }

    }
}
