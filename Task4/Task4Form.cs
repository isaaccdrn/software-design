namespace Task4
{
    public partial class Task4Form : Form
    {
        public Task4Form()
        {
            InitializeComponent();
        }

        public int[] ProceduralSort(int[] arr)
        {
            Array.Sort(arr);
            return arr;
        }
        private void btnSort_Click(object sender, EventArgs e)
        {
            int[] numArray = [3, 1, 5, 2, 4, 9, 6, 8, 7, 10];
            int[] sortedArray = ProceduralSort(numArray);
            listBoxResults.DataSource = sortedArray;
        }
    }
}
