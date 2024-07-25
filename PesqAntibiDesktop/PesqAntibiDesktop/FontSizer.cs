using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PesqAntibiDesktop
{
    public abstract class FontSizer
    {
        public static void updateFontSize(Control label, int maxFontSize)
        {
            // Desired font size and adjustment factor (you may adjust these as needed)
            float scaleFactor = Math.Min(label.Width / TextRenderer.MeasureText(label.Text, label.Font).Width,
                                         label.Height / TextRenderer.MeasureText(label.Text, label.Font).Height);
            float sizeIncrease = 1.0f;

            // Calculate the new font size
            float newFontSize = label.Font.Size * scaleFactor * sizeIncrease;

            if (newFontSize < 8)
            {
                newFontSize = 8;
            }

            if (newFontSize > maxFontSize)
            {
                newFontSize = maxFontSize;
            }

            // Create a new font instance with the new size
            label.Font = new Font(label.Font.FontFamily, newFontSize, label.Font.Style);
        }
    }
}
