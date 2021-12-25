using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace 테트리스
{
    public partial class frmTetris : Form
    {
        block[] BlockSet = { new stick(), new shapeT(), new shapeL1(), new shapeL2(), new chair1(), new chair2(), new square() };
        block currentBlock;
        board board;
        Random rnd = new Random();
        int level;

        public frmTetris()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            picBoard.Width = 30 * 8;
            picBoard.Height = 30 * 17;
            currentBlock = BlockSet[rnd.Next(BlockSet.Length)];
            board = new board(picBoard);
            tmrDown.Interval = 500;
            level = (int)((500 - tmrDown.Interval) / 50) + 1;
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            board.draw(currentBlock);
            tmrDown.Start();
            picBoard.Focus();
        }

        private void btnRest_Click(object sender, EventArgs e)
        {
            if (tmrDown.Enabled)
            {
                tmrDown.Stop();
                btnRest.Text = "재개";
            }
            else
            {
                tmrDown.Start();
                btnRest.Text = "휴식";
            }
        }

        private void btnEnd_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void tmrDown_Tick(object sender, EventArgs e)
        {
            if (!board.moveDown(currentBlock))
            {
                newBlock();
            }
        }

        private void txtKeyIn_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Left:
                    board.moveLeft(currentBlock);
                    break;
                case Keys.Right:
                    board.moveRight(currentBlock);
                    break;
                case Keys.Up:
                    board.rotate(currentBlock);
                    break;
                case Keys.Down:
                    board.moveDown(currentBlock);
                    break;
                case Keys.Space:
                    while (board.moveDown(currentBlock)) ;
                    break;
                case Keys.A:
                    board.remove(currentBlock);
                    currentBlock = BlockSet[0];
                    currentBlock.Reset();
                    board.draw(currentBlock);
                    break;
                case Keys.T:
                    tmrDown.Stop();
                    break;
                case Keys.S:
                    tmrDown.Start();
                    break;
            }
        }
        private void newBlock()
        {
            lblScore.Text = board.Score.ToString();
            level = (int)((500 - tmrDown.Interval) / 50) + 1;
            lblLevel.Text = level.ToString();
            board.set_boards(currentBlock);
            currentBlock = BlockSet[rnd.Next(BlockSet.Length)];
            currentBlock.Reset();
            if (!board.BoardFull(currentBlock))
            {
                board.draw(currentBlock);
                tmrDown.Interval -= 5;
            }
            else
            {
                tmrDown.Stop(); MessageBox.Show("게임종료", "게임종료",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (MessageBox.Show("게임을 다시 합니까?", "게임 다시시작",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
                {
                    btnEnd.PerformClick();
                }
                else
                {
                    board.Reset();
                    board.draw(currentBlock);
                    tmrDown.Interval = 500;
                    lblScore.Text = board.Score.ToString();
                    level = (int)((500 - tmrDown.Interval) / 50) + 1;
                    lblLevel.Text = level.ToString();
                    tmrDown.Start();

                }



            }

        }
    }
}
