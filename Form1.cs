namespace CatchButton
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Catchbutton_MouseEnter(object sender, EventArgs e)
        {
            // 새로운위치값세팅. 새로운X,Y 좌표값
            int x_position= 100;int y_position= 150;
            // 버튼을새로운위치로옮김(새로운Point 객체생성)
            Catchbutton.Location= new Point(x_position, y_position);
        }

        private void Catchbutton_Click(object sender, EventArgs e)
        {

        }
    }
}
