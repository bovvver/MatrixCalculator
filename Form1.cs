using System.Data;

namespace MatrixCalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void readA_Button_Click(object sender, EventArgs e)
        {
            MatrixDisplayHandler.MatrixA = GetCellsArray();
        }

        private void readB_Button_Click(object sender, EventArgs e)
        {
            MatrixDisplayHandler.MatrixB = GetCellsArray();
        }

        private double[,] GetCellsArray()
        {
            var selectedCells = dataGridView.SelectedCells.Cast<DataGridViewCell>().ToList();

            selectedCells = selectedCells.OrderBy(cell => cell.RowIndex).ThenBy(cell => cell.ColumnIndex).ToList();

            int minRowIndex = selectedCells.First().RowIndex;
            int maxRowIndex = selectedCells.Last().RowIndex;
            int minColIndex = selectedCells.Min(cell => cell.ColumnIndex);
            int maxColIndex = selectedCells.Max(cell => cell.ColumnIndex);

            int numRows = maxRowIndex - minRowIndex + 1;
            int numCols = maxColIndex - minColIndex + 1;
            double[,] array = new double[numRows, numCols];

            foreach (var cell in selectedCells)
            {
                if (double.TryParse(cell.Value?.ToString(), out double value))
                {
                    array[cell.RowIndex - minRowIndex, cell.ColumnIndex - minColIndex] = value;
                }
            }

            return array;
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            dataGridView.Rows.Clear();
            dataGridView.Refresh();

            dataGridView.RowCount = 12;
        }

        private void runButton_Click(object sender, EventArgs e)
        {
            double[,] A = MatrixDisplayHandler.MatrixA;
            double[,] B = MatrixDisplayHandler.MatrixB;

            double[,] resultArray;

            int.TryParse(scalarBox.Text, out int scalar);

            try { 
                switch (comboBox1.SelectedItem)
                {
                    case "A + B":
                        resultArray = MatrixCalculationsHandler.MatrixAddition(A, B);
                        break;
                    case "A - B":
                        resultArray = MatrixCalculationsHandler.MatrixRemoval(A, B);
                        break;
                    case "A * B":
                        resultArray = MatrixCalculationsHandler.MatrixMultiplication(A, B);
                        break;
                    case "A * N":
                        resultArray = MatrixCalculationsHandler.MatrixScalarMultiplication(A, scalar);
                        break;
                    default:
                        throw new InvalidOperationException("Invalid operation selected.");
                }

                var selectedCell = dataGridView.SelectedCells[0];

                int startRow = selectedCell.RowIndex;
                int startCol = selectedCell.ColumnIndex;

                for (int i = 0; i < resultArray.GetLength(0); i++)
                {
                    for (int j = 0; j < resultArray.GetLength(1); j++)
                    {
                        int targetRow = startRow + i;
                        int targetCol = startCol + j;

                        if (targetRow < dataGridView.RowCount && targetCol < dataGridView.ColumnCount)
                        {
                            dataGridView[targetCol, targetRow].Value = resultArray[i, j];
                        }
                    }
                }
            } 
            catch (Exception ex) when (ex is InvalidOperationException || ex is ArgumentException)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                comboBox1.Text = "";
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem == null)
            {
                MessageBox.Show("Operation not selected.");
            }
            else if ((string)comboBox1.SelectedItem != "A * N")
            {
                scalarBox.Enabled = false;
            }
            else if ((string)comboBox1.SelectedItem == "A * N")
            {
                scalarBox.Enabled = true;
            }
        }

        private void scalarBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
