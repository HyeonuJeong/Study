using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Windows.Forms;
using System.Threading;

namespace 테트리스
{
    class board
    {
        private Pen p = new Pen(Color.Red);
        private Graphics g;
        private PictureBox picBoard;
        private bool[,] boards;
        private Color[,] colors;
        private int width = 8;
        private int height = 17;
        private int blockSize = 30;
        private int score;

        public board(PictureBox picBoard)
        {
            width = 8;
            height = 17;
            blockSize = 30;
            this.picBoard = new PictureBox();
            this.picBoard = picBoard;
            this.g = picBoard.CreateGraphics();
            boards = new bool[height, width];
            colors = new Color[height, width];
            boards.Initialize();
            Reset();
        }

        public int Width
        {
            get
            {
                return width;
            }
        }

        public int Height
        {
            get
            {
                return height;
            }
        }
        public int Size
        {
            get
            {
                return blockSize;
            }
        }
        public int Score
        {
            get
            {
                return score;
            }
        }
        public void remove(block b)
        {
            int start, x;
            int y = b.Y;
            if (y >= b.Height)
            {
                y = y - b.Height + 1;
                start = 0;
            }
            else
            {
                start = (b.Height - 1) - y;
                y = 0;
            }
            for (int i = start; i < b.Height; i++, y++)
            {
                x = b.X; 
                for(int j = 0; j < b.Width; j++, x++)
                {
                    if (b.shape[b.SelectedIndex][i, j])
                    {
                        remove_Block(picBoard.BackColor, x, y);
                    }
                }
            }
        }
        private void remove_Block(Color c, int x, int y)
        {
            SolidBrush sb = new SolidBrush(c);
            g.FillRectangle(sb, x * blockSize, y * blockSize, blockSize, blockSize);
        }
        private void remove_Line(int lineNo)
        {
            Color c = picBoard.BackColor;
            for(int i =0; i<width; i++)
            {
                remove_Block(c, i, lineNo);
            }
        }
        public bool drawable(block b, int x, int y)
        {
            if (y > (height - 1))
                return false;
            else if (x < 0)
                return false;
            else if ((x + b.Width) > this.width)
                return false;

            int l, m;
            int k = x;
            if(y>=b.Height)
            {
                l = b.Height;
            }
            else
            {
                l = y;
            }
            m = y - l + 1;
            for(int j =0; j<l; j++,m++)
            {
                k = x;
                for(int i =0; i<b.Width; i++, k++)
                {
                    if((boards[m,k])&&(b.shape[b.SelectedIndex][j,i]))
                    {
                        return false;
                    }
                }
            }
            return true;
        }
        public bool draw(block b)
        {
            int x, start;
            int y = b.Y;
            if(y>=b.Height)
            {
                y = y - b.Height + 1;
                start = 0;
            }
            else
            {
                start = (b.Height - 1) - y;
                y = 0;
            }
            for(int i = start; i<b.Height; i++)
            {
                x = b.X;
                for(int j=0; j<b.Width; j++)
                {
                    if(b.shape[b.SelectedIndex][i,j])
                    {
                        draw_Block(b.color, x, y);
                    }
                    x++;
                }
                y++;
            }
            return true;
        }
        public void moveLeft(block b)
        {
            if(drawable(b,b.X-1,b.Y))
            {
                remove(b);
                b.X -= 1;
            }
            draw(b);
        }
        public void moveRight(block b)
        {
            if(drawable(b,b.X+1,b.Y))
            {
                remove(b);
                b.X += 1;
            }
            draw(b);
        }
        public void rotate(block b)
        {
            remove(b);
            b.getNext();
            if (!drawable(b, b.X, b.Y))
            {
                b.getPrevious();
            }
            draw(b);
        }
        public bool moveDown(block b)
        {
            if (drawable(b, b.X, b.Y+1))
            {
                remove(b);
                b.Y += 1;
                draw(b);
                return true;
            }
            else
            {
                return false;
            }
        }
        public void Reset()
        {
            for (int i =0; i<height; i++)
            {
                for(int j =0; j<width; j++)
                {
                    boards[i, j] = false;
                    colors[i, j] = picBoard.BackColor;
                    remove_Block(picBoard.BackColor, i, j);
                }
            }
            score = 0;
        }
        private void draw_Block(Color c, int x, int y)
        {
            SolidBrush sb;
            x *= blockSize;
            y *= blockSize;
            p.Color = Color.FromArgb(255, 255, 128);
            g.DrawLine(p, x, y, x + 26, y);
            p.Color = Color.FromArgb(255, 128, 255);
            g.DrawLine(p, x, y, x, y + 26);
            p.Color = Color.FromArgb(128, 255, 255);
            g.DrawLine(p, x, y + 26, x + 26, y + 26);
            p.Color = Color.FromArgb(128, 128, 0);
            g.DrawLine(p, x + 26, y, x + 26, y + 26);
            sb = new SolidBrush(c);
            g.FillRectangle(sb, x + 1, y + 1, 24, 24);
        }
        public bool BoardFull(block b)
        {
            if (boards[b.Y, b.X])
                return true;
            else
                return false;
        }
        public void set_boards(block b)
        {
            int x = b.X; 
            int start;
            int y = b.Y;
            if (y >= b.Height)
            {
                y = y - b.Height + 1; 
                start = 0;
            }
            else
            {
                start = (b.Height - 1) - y;
                y = 0;
            }   
            for (int i = start; i < b.Height; i++, y++)
            {
                x = b.X;
                for (int j = 0; j < b.Width; j++, x++)
                {
                    if (b.shape[b.SelectedIndex][i, j])
                    {
                        colors[y, x] = b.color;
                        boards[y, x] = true;
                    }
                }

            }
            breakLine();
        }
        private bool breakLine()
        {
            int i, j;
            for ( i=height-1;i>=0; i--)
            {
                for(j=0;j<width;j++)
                {
                    if (boards[i, j] == false)
                        break;
                }
                if(j==width)
                {
                    downBlocks(i);
                    i++;
                }
            }
            return true;
        }
        private void downBlocks(int start)
        {
            remove_Line(start); 
            SolidBrush sb = new SolidBrush(Color.Red); 
            int i, j; 
            for (i = 0; i < width; i++)
            {
                for (j = start; j > 0; j--)
                {
                    remove_Block(picBoard.BackColor, i, j - 1);
                    if (boards[j - 1, i])
                    {
                        draw_Block(colors[j - 1, i], i, j);
                    }
                    else
                    {
                        remove_Block(picBoard.BackColor, i, j);
                    }
                        
                    boards[j, i] = boards[j - 1, i]; 
                    colors[j, i] = colors[j - 1, i];
                }
            }
            score += 30;

        }
    }
}
