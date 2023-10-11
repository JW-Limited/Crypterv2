using LILO_Packager.v2.Shared.Interfaces;

namespace LILO.Shell;
public partial class ImageProcessing
{
    public class ColorManagment
    {
        public class ColorDetector : ILILOColorDetector
        {
            public Bitmap image;

            public ColorDetector(Bitmap sourceImage)
            {
                this.image = sourceImage;
            }

            public async Task<Color> DetectMainColor()
            {
                Dictionary<Color, int> colorCounts = new Dictionary<Color, int>();

                for (int x = 0; x < image.Width; x++)
                {
                    for (int y = 0; y < image.Height; y++)
                    {
                        Color pixelColor = image.GetPixel(x, y);

                        if (colorCounts.ContainsKey(pixelColor))
                        {
                            colorCounts[pixelColor]++;
                        }
                        else
                        {
                            colorCounts[pixelColor] = 1;
                        }
                    }
                }

                Color mainColor = Color.Black;
                int maxCount = 0;
                foreach (KeyValuePair<Color, int> colorCount in colorCounts)
                {
                    if (colorCount.Value > maxCount)
                    {
                        mainColor = colorCount.Key;
                        maxCount = colorCount.Value;
                    }
                }

                return mainColor;
            }

            public static Color GetOppositeColorForControls(Color color)
            {
                int red = 255 - color.R;
                int green = 255 - color.G;
                int blue = 255 - color.B;

                return Color.FromArgb(red, green, blue);
            }

            public async Task<Color> GetOppositeColor(Color color)
            {
                int red = 255 - color.R;
                int green = 255 - color.G;
                int blue = 255 - color.B;

                return Color.FromArgb(red, green, blue);
            }
        }
    }
}
