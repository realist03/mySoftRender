using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Imaging;
using System.Runtime.InteropServices.WindowsRuntime;
using SharpDX;

namespace mySoftRender
{
    public class Device
    {
        byte[] backBuffer;
        WriteableBitmap bmp;

        public Device(WriteableBitmap bmp)
        {
            this.bmp = bmp;
            //后台缓冲区大小值是要绘制的像素
            //屏幕（width*height） * 4（r,g,b,a）
            backBuffer = new byte[bmp.PixelWidth * bmp.PixelHeight * 4];
        }

        //清楚后台缓冲区为指定颜色
        public void Clear(byte r,byte g,byte b,byte a)
        {
            for(var index = 0; index < backBuffer.Length;index +=4)
            {
                //windows使用BRGBA
                backBuffer[index] = b;
                backBuffer[index + 1] = g;
                backBuffer[index + 2] = r;
                backBuffer[index + 3] = a;
            }
        }

        //准备就绪时，刷新后台缓冲区到前台缓冲区
        public void Present()
        {
            using (var stream = bmp.)
        }
    }
}
