using System;
using System.Runtime.InteropServices;

namespace my_homework

{
    public struct Figur
    {
        private int _x;
        private int _y;
        private readonly int _hw;
        private static bool key;

        public Figur(int x, int y,int hw)
        {
            _x = x;
            _y = y;
            _hw = hw;
        }

        public void SetNewPosX(int x)
        {
            var tempx = _x;
            _x = _x + x;
            if (_x < 0 || _x > Console.WindowWidth-6)
            {
                _x = tempx;
            }
        }
        public void SetNewPosY(int y)
        {
            var tempy = _y;
            _y = _y + y;
            if (_y < 0 || _y > Console.WindowHeight-6)
            {
                _y = tempy;
            }
        }
        public void Show()
        {
            var x=_x;
            var y=_y;
            for (var i = 1; i <= _hw; i++)
            {
                Console.SetCursorPosition(x, y + i);
                Console.Write(i == _hw ? "+" : "|");
                if (i == _hw)
                {
                    y = _y;
                    for (var j = 1; j < _hw + 1; j++)
                    {
                        Console.SetCursorPosition(x + j, y + i);
                        Console.Write(j == _hw ? "+" : "-");
                    }
                    x = _x;
                    y = _y;
                }
            }
            for (var i = _hw - 1; i >= 0; i--)
            {
                Console.SetCursorPosition(x+_hw, y + i);
                Console.Write(i == 0 ? "+" : "|");
                if (i == 0)
                {
                    x = _x;
                    y = _y;
                    for (var j = _hw - 1; j >= 0; j--)
                    {
                        Console.SetCursorPosition(x + j, y + i);
                        Console.Write(j == 0 ? "+" : "-");
                    }
                }
            }
            
        }

        public static bool operator ==(Figur a, Figur b)
        {
            int ax = a._x;
            int ay = a._y;
            int bx = b._x;
            int by = b._y;
            for (int i = 0; i < a._hw; i++)
            {
                for (int j = 0; j <b._hw; j++)
                {
                    if (ax + i == bx + j)
                    {
                        for (int k = 0; k < a._hw; k++)
                        {
                            for (int l = 0; l < b._hw; l++)
                            {
                                if (ay + k == by + l)
                                {
                                    key = true;
                                }
                                else
                                {
                                    key = false;
                                }
                            }
                        }
                    }
                }

            }
            return (key);
        }

        public static bool operator !=(Figur a, Figur b)
        {
            return (true);
        }
    }
}