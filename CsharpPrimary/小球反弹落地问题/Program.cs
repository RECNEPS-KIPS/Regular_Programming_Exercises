﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 小球反弹落地问题
{
    class Program
    {
        static void Main(string[] args)
        {
            float height= 100;
            float sumDistance=0;
            for (int i = 1; i < 11; i++)
            {
                sumDistance = sumDistance + height;
                height = height / 2;
                
            }
            Console.WriteLine("第十次高度为: "+height);
            Console.WriteLine();
            Console.WriteLine("反弹十次总距离为: " + sumDistance);
            Console.ReadLine();
        }
    }
}
