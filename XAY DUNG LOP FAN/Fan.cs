using System;
using System.Collections.Generic;
using System.Text;

namespace XAY_DUNG_LOP_FAN
{
    class Fan
    {
        private const byte _SLOW = 1;
        private const byte _MEDIUM = 2;
        private const byte _FAST = 3;
        private int _speed = SLOW;
        private bool _on = false;
        private double _radius = 5;
        private string _color = "blue";

        public static byte SLOW => _SLOW;
        public static byte MEDIUM => _MEDIUM;
        public static byte FAST => _FAST;
        public int Speed { get => _speed; set => _speed = value; }
        public bool On { get => _on; set => _on = value; }
        public double Radius { get => _radius; set => _radius = value; }
        public string Color { get => _color; set => _color = value; }



        public Fan()
        {

        }

        public string DisplayFan()
        {
            if (On)
            {
                return $"Tốc độ quạt {Speed}, màu quạt {Color}, bán kính quạt {Radius} và quạt đang bật";
            } else
            {
                return $"Màu quạt {Color}, bán kính quạt {Radius} và quạt đang tắt";
            }
        }
    }
}
