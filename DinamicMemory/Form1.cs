namespace DinamicMemory
{
    public partial class Form1 : Form
    {
        private DinamicArray dinamicArray;
        public Form1()
        {

            InitializeComponent();
            dinamicArray = new DinamicArray();
        }
        
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtValue.Text, out int value))
            {
                dinamicArray.Add(value);
                UpdateList();
                txtValue.Clear();
            }
            else
            {
                MessageBox.Show("Please enter a valid number.");
            }
        }

        private void btnEliminate_Click(object sender, EventArgs e)
        {
            if (lstValue.SelectedIndex >= 0)
            {
                dinamicArray.Eliminate(lstValue.SelectedIndex);
                UpdateList();
            }
            else
            {
                MessageBox.Show("Please select an item from the list.");
            }
        }

        private void btnModify_Click(object sender, EventArgs e)
        {
            if (lstValue.SelectedIndex >= 0)
            {
                if (int.TryParse(txtValue.Text, out int newValue))
                {
                    int index = lstValue.SelectedIndex;
                    dinamicArray.Modify(index, newValue);
                    UpdateList();
                    txtValue.Clear(); 
                }
                else
                {
                    MessageBox.Show("Please enter a valid number to modify the selected item.");
                }
            }
            else
            {
                MessageBox.Show("Please select an item from the list to modify.");
            }
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            UpdateList();
        }
        private void UpdateList()
        {
            lstValue.Items.Clear();
            var elementos = dinamicArray.ObtainElements();
            foreach (var item in elementos)
            {
                lstValue.Items.Add(item);
            }
        }
    }
}
