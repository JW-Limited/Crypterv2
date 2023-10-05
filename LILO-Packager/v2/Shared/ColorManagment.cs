namespace LILO.Shell;
public partial class ImageProcessing
{
    public class ColorManagment
    {
        public class ColorDetector
        {
            public Bitmap image;

            public ColorDetector(Bitmap sourceImage)
            {
               this.image = sourceImage;
            }

            public async Task<Color> DetectMainColor()
            {
                // Create a dictionary to store the count of each color
                Dictionary<Color, int> colorCounts = new Dictionary<Color, int>();

                // Loop through each pixel in the image
                for (int x = 0; x < image.Width; x++)
                {
                    for (int y = 0; y < image.Height; y++)
                    {
                        // Get the color of the pixel
                        Color pixelColor = image.GetPixel(x, y);

                        // Add the color to the dictionary or increment the count if it already exists
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

                // Find the color with the highest count
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

            public async Task<Color> GetOppositeColor(Color color)
            {
                // Calculate the opposite color by subtracting each component from 255
                int red = 255 - color.R;
                int green = 255 - color.G;
                int blue = 255 - color.B;

                return Color.FromArgb(red, green, blue);
            }
        }
    }
}
