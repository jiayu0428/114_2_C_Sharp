namespace Review_Q1
{
    public partial class Form1 : Form
    {
        private const string STONE = "石頭";
        private const string PAPER = "布";
        private const string SCISSOR = "剪刀";

        private string computerChoice = "";
        private string playerChoice = "";
        private int playerWins = 0;
        private int computerWins = 0;
        private int draws = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ClearDisplay();
        }

        /// <summary>
        /// 清空圖片和結果顯示
        /// </summary>
        private void ClearDisplay()
        {
            computerPictureBox.Image = null;
            playerPictureBox.Image = null;
            resultLabel.Text = "";
        }

        /// <summary>
        /// 產生電腦的隨機選擇
        /// </summary>
        private void GetCompChoice()
        {
            Random random = new Random();
            int choice = random.Next(0, 3);

            computerChoice = choice switch
            {
                0 => STONE,
                1 => PAPER,
                2 => SCISSOR,
                _ => STONE
            };
        }

        /// <summary>
        /// 根據電腦的選擇顯示圖片
        /// </summary>
        private void ShowComputerImage()
        {
            computerPictureBox.Image = computerChoice switch
            {
                STONE => Properties.Resources.stone ?? null,
                PAPER => Properties.Resources.Paper ?? null,
                SCISSOR => Properties.Resources.Scissor ?? null,
                _ => null
            };
        }

        /// <summary>
        /// 根據玩家的選擇顯示圖片
        /// </summary>
        private void ShowPlayerImage()
        {
            playerPictureBox.Image = playerChoice switch
            {
                STONE => Properties.Resources.Stone ?? null,
                PAPER => Properties.Resources.Paper ?? null,
                SCISSOR => Properties.Resources.Scissor ?? null,
                _ => null
            };
        }

        /// <summary>
        /// 比較玩家和電腦的選擇，判斷勝負
        /// </summary>
        private void ShowWinner()
        {
            if (computerChoice == playerChoice)
            {
                resultLabel.Text = "平手";
                draws++;
            }
            else if (IsPlayerWin())
            {
                resultLabel.Text = "玩家贏";
                playerWins++;
            }
            else
            {
                resultLabel.Text = "電腦贏";
                computerWins++;
            }
        }

        /// <summary>
        /// 判斷玩家是否獲勝
        /// </summary>
        private bool IsPlayerWin()
        {
            return (playerChoice == STONE && computerChoice == SCISSOR) ||
                   (playerChoice == PAPER && computerChoice == STONE) ||
                   (playerChoice == SCISSOR && computerChoice == PAPER);
        }

        private void StoneButton_Click(object sender, EventArgs e)
        {
            playerChoice = STONE;
            PlayGame();
        }

        private void PaperButton_Click(object sender, EventArgs e)
        {
            playerChoice = PAPER;
            PlayGame();
        }

        private void ScissorButton_Click(object sender, EventArgs e)
        {
            playerChoice = SCISSOR;
            PlayGame();
        }

        /// <summary>
        /// 執行遊戲流程
        /// </summary>
        private void PlayGame()
        {
            GetCompChoice();
            ShowComputerImage();
            ShowPlayerImage();
            ShowWinner();
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            string statistics = $"玩家贏：{playerWins} 場\n電腦贏：{computerWins} 場\n平手：{draws} 場";
            MessageBox.Show(statistics, "遊戲統計", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Application.Exit();
        }
    }
}
