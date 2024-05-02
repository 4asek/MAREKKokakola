namespace Lub_44
{
    public partial class fMain : Form
    {
        public fMain()
        {
            InitializeComponent();
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            int buttonsSize = 5 * btnAdd.Width + 2 * tsSeparator1.Width + 30;
            btnExit.Margin = new Padding(Width - buttonsSize, 0, 0, 0);
        }

        private void fMain_Load(object sender, EventArgs e)
        {


            DataGridViewColumn column = new DataGridViewTextBoxColumn();
            column.DataPropertyName = "Name";
            column.Name = "Назва";
            gvCars.Columns.Add(column);


            column = new DataGridViewTextBoxColumn();
            column.DataPropertyName = "Country";
            column.Name = "Країна";
            gvCars.Columns.Add(column);


            column = new DataGridViewTextBoxColumn();
            column.DataPropertyName = "Motor";
            column.Name = "Двигун";
            gvCars.Columns.Add(column);


            column = new DataGridViewTextBoxColumn();
            column.DataPropertyName = "ObDviguna";
            column.Name = "Об'єм двигуна";
            gvCars.Columns.Add(column);


            column = new DataGridViewTextBoxColumn();
            column.DataPropertyName = "PotugDviguna";
            column.Name = "Потужність двигуна";
            gvCars.Columns.Add(column);


            column = new DataGridViewTextBoxColumn();
            column.DataPropertyName = "MaxSpeed";
            column.Name = "Максимальна швидкість";
            gvCars.Columns.Add(column);


            column = new DataGridViewTextBoxColumn();
            column.DataPropertyName = "Rnasto";
            column.Name = "Розгін до 100 км/год";
            gvCars.Columns.Add(column);


            column = new DataGridViewTextBoxColumn();
            column.DataPropertyName = "DiameterDisk";
            column.Name = "Діаметр диска";
            gvCars.Columns.Add(column);


            DataGridViewCheckBoxColumn checkboxColumn = new DataGridViewCheckBoxColumn();
            checkboxColumn.DataPropertyName = "NewCar";
            checkboxColumn.Name = "Нова машина";
            gvCars.Columns.Add(checkboxColumn);


            checkboxColumn = new DataGridViewCheckBoxColumn();
            checkboxColumn.DataPropertyName = "Automaticgearbox";
            checkboxColumn.Name = "Автоматична коробка передач";
            gvCars.Columns.Add(checkboxColumn);

            bindSrcTowns.Add(new Cars("Toyota", "Japan", "Petrol", 2.0, 150, 200, 7.5, 18, true, true));
            bindSrcTowns.Add(new Cars("BMW", "UK", "Petrol", 2.0, 150, 200, 7.5, 18, true, false));

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Cars newCar = new Cars("Toyota", "Japan", "Petrol", 2.0, 150, 200, 7.5, 18, true, true);


            Form2 form = new Form2(newCar);


            if (form.ShowDialog() == DialogResult.OK)
            {

                bindSrcTowns.Add(newCar);
            }

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(
        "Очистити таблицю?\n\nВсі дані будуть втрачені",
        "Очищення даних", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                bindSrcTowns.Clear();
            }

        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Видалити поточний запис?", "Видалення запису", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                bindSrcTowns.RemoveCurrent();
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Закрити застосунок?", "Вихід з програми",
       MessageBoxButtons.OKCancel,
        MessageBoxIcon.Question) == DialogResult.OK)
            {
                Application.Exit();
            }

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            Cars cars = (Cars)bindSrcTowns.List[bindSrcTowns.Position];

            Form2 ft = new Form2(cars);
            if (ft.ShowDialog() == DialogResult.OK)
            {
                bindSrcTowns.List[bindSrcTowns.Position] = cars;
            }

        }
    }
}
