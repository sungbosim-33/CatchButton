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
            // 1. 난수생성기준비
            Random rd= new Random();
            // 2. 가용영역계산(버튼이폼테두리에걸리지않게보호)
            // ClientSize는타이틀바와테두리를제외한실제흰도화지영역임
            //버튼이 밖으로 나가지않게하려면 최대좌표는 폼의 가용영역에서 버튼의 크기만큼 빼야함atchbuttonatchbutton
            int maxX = this.ClientSize.Width - Catchbutton.Width;
            int maxY= this.ClientSize.Height- Catchbutton.Height;
            // 3. 랜덤좌표추출(0 ~ 최대가용치사이)
            int nextX= rd.Next(0, maxX);
            int nextY= rd.Next(0, maxY);
            // 4. 위치할당(새로운Point 객체생성)
            Catchbutton.Location= new Point(nextX, nextY);
            // 5. 시각적피드백(폼제목표시줄에좌표출력)
            this.Text= $"버튼위치: ({nextX}, {nextY})";
        }

        private void Catchbutton_Click(object sender, EventArgs e)
        {

        }
    }
}
