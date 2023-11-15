using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AG_SecureCore
{
    
    class LoadingGraphic
    {
        private Brush colorBrush;
        private Graphics loadingIcon;
        private const int DOTS_COUNT = 8;
        private const int TOTAL_ICON_CICLE_STEPS = 1;
        private int cycle = 0;
        private const int cycles = DOTS_COUNT * TOTAL_ICON_CICLE_STEPS * 2;
        private float center = 0;
        private float radius = 0;
        private const float angleBetweenDots = ((float)Math.PI * 2 / DOTS_COUNT)/2;
        private Color backgroundColor;
        //private Color accentColor;

        public LoadingGraphic(System.Windows.Forms.PictureBox pbLoading,Color backgroundColor,Color accentColor)
        {
            loadingIcon = pbLoading.CreateGraphics();
            center = pbLoading.Size.Width / 2;
            radius = pbLoading.Size.Width / 3;
            colorBrush = new SolidBrush(accentColor);
            this.backgroundColor = backgroundColor;
            //this.accentColor = accentColor;

        }
        public void step()
        {
            cycle++;
            cycle %= cycles;
            drawLoadingIcon();

        }
        private void drawLoadingIcon()
        {
            loadingIcon.Clear(backgroundColor);
            float dotSize;
            float baseDotSize = 10;

            float x, y;
            for (int i = 0; i < DOTS_COUNT; i++)
            {
                x = center + radius * (float)Math.Cos(angleBetweenDots * ( i + (float)cycle/ TOTAL_ICON_CICLE_STEPS));
                y = center + radius * (float)Math.Sin(angleBetweenDots * ( i + (float)cycle / TOTAL_ICON_CICLE_STEPS));
                dotSize = (float)Math.Sqrt(i) * baseDotSize / 2;
                loadingIcon.FillEllipse(colorBrush, x - dotSize, y - dotSize, dotSize, dotSize);
            }
        }
   
    }
}
