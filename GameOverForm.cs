using System;
using System.Drawing;
using System.Windows.Forms;

namespace CatchButton
{
    public class GameOverForm : Form
    {
        public GameOverForm()
        {
            this.Text = "Game Over";
            this.StartPosition = FormStartPosition.CenterParent;
            this.ClientSize = new Size(360, 160);
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.ShowInTaskbar = false;

            var label = new Label()
            {
                Text = "Game Over\n놓친 횟수 20회",
                Dock = DockStyle.Top,
                Height = 80,
                TextAlign = ContentAlignment.MiddleCenter,
                Font = new Font("맑은 고딕", 14F, FontStyle.Bold)
            };
            this.Controls.Add(label);

            var btnRestart = new Button()
            {
                Text = "다시시작",
                DialogResult = DialogResult.Retry,
                Size = new Size(120, 36),
            };

            var btnExit = new Button()
            {
                Text = "종료",
                DialogResult = DialogResult.Cancel,
                Size = new Size(120, 36),
            };

            btnRestart.Location = new Point(40, label.Bottom + 10);
            btnExit.Location = new Point(200, label.Bottom + 10);

            this.Controls.Add(btnRestart);
            this.Controls.Add(btnExit);

            this.AcceptButton = btnRestart;
            this.CancelButton = btnExit;
        }
    }
}
