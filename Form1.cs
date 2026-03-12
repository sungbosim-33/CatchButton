using System.Media;
using System.IO;
using System.Threading.Tasks;

namespace CatchButton
{
    public partial class Form1 : Form
    {
        private int score = 1000;

        public Form1()
        {
            InitializeComponent();
            // 기본 점수 초기화
            score = 1000;
            this.Text = $"점수: {score}";

        }

        private void Catchbutton_Click(object sender, EventArgs e)
        {
            // 잡았을 때(클릭) 사운드 재생
            PlaySoundAsync("caught.wav");

            // 점수 보상: 잡으면 +100점
            score += 100;

            // 버튼을 10% 축소 (가운데 기준 유지)
            const double shrinkFactor = 0.9; // 10% 작아짐
            const int minWidth = 20;
            const int minHeight = 20;

            // 현재 버튼의 중심 좌표 계산
            int centerX = Catchbutton.Location.X + Catchbutton.Width / 2;
            int centerY = Catchbutton.Location.Y + Catchbutton.Height / 2;

            // 새 크기 계산
            int newWidth = Math.Max(minWidth, (int)Math.Round(Catchbutton.Width * shrinkFactor));
            int newHeight = Math.Max(minHeight, (int)Math.Round(Catchbutton.Height * shrinkFactor));

            // 새 위치를 가운데 기준으로 맞춤
            int newX = centerX - newWidth / 2;
            int newY = centerY - newHeight / 2;

            // 폼 내부에 남도록 보정
            int maxX = this.ClientSize.Width - newWidth;
            int maxY = this.ClientSize.Height - newHeight;
            newX = Math.Max(0, Math.Min(newX, Math.Max(0, maxX)));
            newY = Math.Max(0, Math.Min(newY, Math.Max(0, maxY)));

            Catchbutton.Size = new System.Drawing.Size(newWidth, newHeight);
            Catchbutton.Location = new System.Drawing.Point(newX, newY);

            // UI에 점수 반영
            this.Text = $"점수: {score}";

            // 버튼 클릭 시 축하 메시지 및 현재 점수 표시
            MessageBox.Show($"축하합니다~!\n+100점\n총점수: {score}");

        }

        private void Catchbutton_MouseEnter(object sender, EventArgs e)
        {
            // 도망갈 때(마우스가 들어올 때) 사운드 재생
            PlaySoundAsync("escape.wav");

            // 놓치면 -5점
            score = Math.Max(0, score - 5);

            // 1. 난수생성기준비
            Random rd = new Random();
            // 2. 가용영역계산(버튼이폼테두리에걸리지않게보호)
            // ClientSize는타이틀바와테두리를제외한실제흰도화지영역임
            //버튼이 밖으로 나가지않게하려면 최대좌표는 폼의 가용영역에서 버튼의 크기만큼 빼야함
            int maxX = this.ClientSize.Width - Catchbutton.Width;
            int maxY = this.ClientSize.Height - Catchbutton.Height;
            // 3. 랜덤좌표추출(0 ~ 최대가용치사이)
            int nextX = rd.Next(0, maxX);
            int nextY = rd.Next(0, maxY);
            // 4. 위치할당(새로운Point 객체생성)
            Catchbutton.Location = new Point(nextX, nextY);
            // 5. 시각적피드백(폼제목표시줄에좌표출력)
 
        }

        private void Catchbutton_MouseDown(object sender, MouseEventArgs e)
        {

         
          
        }
        private void Catchbutton_MouseUp(object sender, MouseEventArgs e)
        {
            // 1. 사운드재생
            // SoundPlayer player = new SoundPlayer("success.wav");
            // player.Play();
            // 2. 점수계산
            // 3. 시각적피드백(폼제목표시줄에점수출력)

        }

        private void PlaySoundAsync(string relativePath)
        {
            Task.Run(() =>
            {
                try
                {
                    var path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, relativePath);
                    if (File.Exists(path))
                    {
                        using var player = new SoundPlayer(path);
                        player.PlaySync();
                    }
                    else
                    {
                        SystemSounds.Asterisk.Play();
                    }
                }
                catch
                {
                    SystemSounds.Beep.Play();
                }
            });
        }
    }
}
