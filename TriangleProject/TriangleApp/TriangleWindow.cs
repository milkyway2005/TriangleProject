using TriangleLibrary;

namespace TriangleApp
{
    public partial class TriangleWindow : Form
    {
        public CheckTriangleType triangleType;
        public TriangleWindow()
        {
            InitializeComponent();
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            if(tbA.Text == "" || tbB.Text == "" || tbC.Text == "")
            {
                MessageBox.Show("Заполните все поля");
                return;
            }
            if(!double.TryParse(tbA.Text, out double A))
            {
                tbA.Text = "";
                MessageBox.Show("Сторона А введена некорректно");
                return;
            }
            if (!double.TryParse(tbB.Text, out double B))
            {
                tbB.Text = "";
                MessageBox.Show("Сторона B введена некорректно");
                return;
            }
            if (!double.TryParse(tbC.Text, out double C))
            {
                tbC.Text = "";
                MessageBox.Show("Сторона C введена некорректно");
                return;
            }

            triangleType = new CheckTriangleType(new Triangle(A, B, C));
            tbResult.Text = triangleType.ToString();
        }
    }
}