using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace 테트리스
{
    public class block
    {
        protected int x;
        protected int y;
        protected int shape_index;
        public bool[][,] shape;
        protected int width;
        protected int height;
        public Color color = new Color();


        public int X
        {
            get
            {
                return x;
            }
            set
            {
                x = value;
            }
        }

        public int Y
        {
            get
            {
                return y;
            }
            set
            {
                y = value;
            }
        }
        public int Width
        {
            get
            {
                return width;
            }
            set
            {
                width = value;
            }
        }

        public int Height
        {
            get
            {
                return height;
            }
            set
            {
                height = value;
            }
        }
        public int SelectedIndex
        {
            get
            {
                return shape_index;
            }
            set
            {
                shape_index = value;
            }
        }


        public void Reset()
        {
            SelectedIndex = 0;
            width = shape[SelectedIndex].GetLength(1);
            height = shape[SelectedIndex].GetLength(0);
            x = (width > 2) ? 2 : 3;
            y = 0;
        }

        public void getNext()
        {
            if (SelectedIndex < shape.GetLength(0) - 1)
            {
                SelectedIndex++;
            }
            else
            {
                SelectedIndex = 0;
            }
            int saveWidth = width;
            width = shape[SelectedIndex].GetLength(1);
            height = shape[SelectedIndex].GetLength(0);
            int differnce = saveWidth - width;
            if (differnce > 0)
                x++;
            else if (differnce < 0)
                x--;
        }
        public void getPrevious()
        {
            if(SelectedIndex > 0)
            {
                SelectedIndex--;
            }
            else
            {
                SelectedIndex = shape.GetLength(0) - 1;
            }
            int saveWidth = width;
            width = shape[SelectedIndex].GetLength(1);
            height = shape[SelectedIndex].GetLength(0);
            int differnce = saveWidth - width;
            if (differnce > 0)
                x++;
            else if (differnce < 0)
                x--;
        }
    }
    public class stick : block
    {
        public stick()
        {
            shape_index = 0;
            shape = new bool[2][,];
            shape[0] = new bool[4, 1] { { true }, { true }, { true }, { true } };
            shape[1] = new bool[1, 4] { { true, true, true, true } };
            color = Color.FromArgb(255, 0, 0);
            width = shape[SelectedIndex].GetLength(1);
            height = shape[SelectedIndex].GetLength(0);
            x = (width > 2) ? 2 : 3;
            y = 0;
        }
    }
    public class shapeT : block
    {
        public shapeT()
        {
            shape_index = 0;
            shape = new bool[4][,];
            shape[0] = new bool[2, 3] { { false, true, false }, { true, true, true } };
            shape[1] = new bool[3, 2] { { true, false }, { true, true }, { true, false } };
            shape[2] = new bool[2, 3] { { true, true, true }, { false, true, false } };
            shape[3] = new bool[3, 2] { { false, true }, { true, true }, { false, true } };
            color = Color.FromArgb(0, 255, 0);
            width = shape[0].GetLength(1);
            height = shape[0].GetLength(0);
            x = (width > 2) ? 2 : 3;
            y = 0;

        }
    }
    public class shapeL1 : block
    {
        public shapeL1()
        {
            shape_index = 0;
            shape = new bool[4][,];
            shape[0] = new bool[3, 2] { { true, false }, { true, false }, { true, true } };
            shape[1] = new bool[2, 3] { { true, true, true }, { true, false, false } };
            shape[2] = new bool[3, 2] { { true, true }, { false, true }, { false, true } };
            shape[3] = new bool[2, 3] { { false, false, true }, { true, true, true } };
            color = Color.FromArgb(0, 0, 255);
            width = shape[0].GetLength(1);
            height = shape[0].GetLength(0);
            x = (width > 2) ? 2 : 3;
            y = 0;

        }
    }

    public class shapeL2 : block
    {
        public shapeL2()
        {
            shape_index = 0;
            shape = new bool[4][,];
            shape[0] = new bool[3, 2] { { false, true }, { false, true }, { true, true } };
            shape[1] = new bool[2, 3] { { true, false, false }, { true, true, true } };
            shape[2] = new bool[3, 2] { { true, true }, { true, false }, { true, false } };
            shape[3] = new bool[2, 3] { { true, true, true }, { false, false, true } };
            color = Color.FromArgb(255, 255, 0);
            width = shape[0].GetLength(1);
            height = shape[0].GetLength(0);
            x = (width > 2) ? 2 : 3;
            y = 0;
        }
    }

    public class square : block
    {
        public square()
        {
            shape_index = 0;
            shape = new bool[1][,];
            shape[0] = new bool[2, 2] { { true, true }, { true, true } };
            color = Color.FromArgb(128, 128, 128);
            width = shape[0].GetLength(1);
            height = shape[0].GetLength(0);
            x = (width > 2) ? 2 : 3;
            y = 0;
        }
    }

    public class chair1 : block
    {
        public chair1()
        {
            shape_index = 0;
            shape = new bool[2][,];
            shape[0] = new bool[3, 2] { { true, false }, { true, true }, { false, true } };
            shape[1] = new bool[2, 3] { { false, true, true }, { true, true, false } };
            color = Color.FromArgb(0, 255, 255);
            width = shape[0].GetLength(1);
            height = shape[0].GetLength(0);
            x = (width > 2) ? 2 : 3;
            y = 0;
        }
    }
    public class chair2 : block
    {
        public chair2()
        {
            shape_index = 0;
            shape = new bool[2][,];
            shape[0] = new bool[3, 2] { { false, true }, { true, true }, { true, false } };
            shape[1] = new bool[2, 3] { { true, true, false }, { false, true, true } };
            color = Color.FromArgb(255, 0, 255);
            width = shape[0].GetLength(1);
            height = shape[0].GetLength(0);
            x = (width > 2) ? 2 : 3;
            y = 0;
        }
    }
}
