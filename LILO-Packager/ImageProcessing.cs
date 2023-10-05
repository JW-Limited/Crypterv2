using System;
using System.Collections.Generic;
using System.Linq;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;

namespace LILO.Shell;
public partial class ImageProcessing
{
    public class Templates
    {
        public Bitmap source;

        public Templates(Bitmap sourceImage)
        {
            this.source = sourceImage;   
        }

        public async Task<Bitmap> BlurredImage()
        {
            ScaleFilter scale = new ScaleFilter(0.01f);
            BlurFilter blur = new BlurFilter(60);
            DarkenFilter darker = new DarkenFilter(0.2f);

            Bitmap scaledPic = scale.ApplyFilter(source);
            Bitmap blurredPic = blur.ApplyFilter(scaledPic);
            Bitmap finalPic = darker.ApplyFilter(blurredPic);
            return finalPic;
        }
    }

    public class BlurFilterv2
    {
        private int kernelSize;

        public BlurFilterv2(int kernelSize)
        {
            this.kernelSize = kernelSize;
        }

        public Bitmap ApplyFilter(Bitmap sourceImage)
        {
            Bitmap outputImage = new Bitmap(sourceImage.Width, sourceImage.Height);

            int kernelWeightSum = 0;
            for (int i = -kernelSize / 2; i <= kernelSize / 2; i++)
            {
                for (int j = -kernelSize / 2; j <= kernelSize / 2; j++)
                {
                    kernelWeightSum += Math.Abs(i) + Math.Abs(j);
                }
            }

            for (int x = 0; x < sourceImage.Width; x++)
            {
                for (int y = 0; y < sourceImage.Height; y++)
                {
                    int red = 0, green = 0, blue = 0;
                    for (int i = -kernelSize / 2; i <= kernelSize / 2; i++)
                    {
                        for (int j = -kernelSize / 2; j <= kernelSize / 2; j++)
                        {
                            if (x + i >= 0 && x + i < sourceImage.Width && y + j >= 0 && y + j < sourceImage.Height)
                            {
                                Color pixelColor = sourceImage.GetPixel(x + i, y + j);
                                int weight = Math.Abs(i) + Math.Abs(j);
                                red += pixelColor.R * weight;
                                green += pixelColor.G * weight;
                                blue += pixelColor.B * weight;
                            }
                        }
                    }

                    red /= kernelWeightSum;
                    green /= kernelWeightSum;
                    blue /= kernelWeightSum;

                    outputImage.SetPixel(x, y, Color.FromArgb(red, green, blue));
                }
            }

            return outputImage;
        }
    }

    public class BlurFilter
    {

        private readonly int kernelSize;

        public BlurFilter(int kernelSize)
        {
            this.kernelSize = kernelSize;
        }

        public Bitmap ApplyFilter(Bitmap sourceImage)
        {
            Bitmap outputImage = new Bitmap(sourceImage.Width, sourceImage.Height);

            for (int x = 0; x < sourceImage.Width; x++)
            {
                for (int y = 0; y < sourceImage.Height; y++)
                {
                    int red = 0, green = 0, blue = 0;
                    int count = 0;
                    for (int i = -kernelSize / 2; i <= kernelSize / 2; i++)
                    {
                        for (int j = -kernelSize / 2; j <= kernelSize / 2; j++)
                        {
                            if (x + i >= 0 && x + i < sourceImage.Width && y + j >= 0 && y + j < sourceImage.Height)
                            {
                                Color pixelColor = sourceImage.GetPixel(x + i, y + j);
                                red += pixelColor.R;
                                green += pixelColor.G;
                                blue += pixelColor.B;
                                count++;
                            }
                        }
                    }

                    red /= count;
                    green /= count;
                    blue /= count;

                    outputImage.SetPixel(x, y, Color.FromArgb(red, green, blue));
                }
            }

            return outputImage;
        }
    }


    public class ScaleFilter
    {
        // The scale factor for the image
        private float scaleFactor;

        public ScaleFilter(float scaleFactor)
        {
            this.scaleFactor = scaleFactor;
        }

        public Bitmap ApplyFilter(Bitmap sourceImage)
        {
            // Calculate the new width and height of the image
            int newWidth = (int)(sourceImage.Width * scaleFactor);
            int newHeight = (int)(sourceImage.Height * scaleFactor);

            // Create a new bitmap to store the output image
            Bitmap outputImage = new Bitmap(newWidth, newHeight);

            // Create a graphics object to draw on the output image
            using (Graphics graphics = Graphics.FromImage(outputImage))
            {
                // Set the interpolation mode to high quality
                graphics.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;

                // Draw the source image onto the output image, scaling it to the new size
                graphics.DrawImage(sourceImage, 0, 0, newWidth, newHeight);
            }

            return outputImage;
        }
    }

    public class DarkenFilter
    {
        // The amount to darken the image (between 0 and 1)
        private float darknessAmount;

        public DarkenFilter(float darknessAmount)
        {
            this.darknessAmount = darknessAmount;
        }

        public Bitmap ApplyFilter(Bitmap sourceImage)
        {
            // Create a new bitmap to store the output image
            Bitmap outputImage = new Bitmap(sourceImage.Width, sourceImage.Height);

            // Loop through each pixel in the image
            for (int x = 0; x < sourceImage.Width; x++)
            {
                for (int y = 0; y < sourceImage.Height; y++)
                {
                    // Get the color of the pixel
                    Color pixelColor = sourceImage.GetPixel(x, y);

                    // Darken the pixel
                    int red = (int)(pixelColor.R * darknessAmount);
                    int green = (int)(pixelColor.G * darknessAmount);
                    int blue = (int)(pixelColor.B * darknessAmount);

                    // Set the pixel in the output image to the darkened color
                    outputImage.SetPixel(x, y, Color.FromArgb(red, green, blue));
                }
            }

            return outputImage;
        }
    }
}
