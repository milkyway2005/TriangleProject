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
                MessageBox.Show("��������� ��� ����");
                return;
            }
            if(!double.TryParse(tbA.Text, out double A))
            {
                tbA.Text = "";
                MessageBox.Show("������� � ������� �����������");
                return;
            }
            if (!double.TryParse(tbB.Text, out double B))
            {
                tbB.Text = "";
                MessageBox.Show("������� B ������� �����������");
                return;
            }
            if (!double.TryParse(tbC.Text, out double C))
            {
                tbC.Text = "";
                MessageBox.Show("������� C ������� �����������");
                return;
            }

            triangleType = new CheckTriangleType(new Triangle(A, B, C));
            tbResult.Text = triangleType.ToString();
        }
    }
}