using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows;
using System.Windows.Shapes;
using System.Windows.Media;
using Space_Invaders.Model;

namespace Space_Invaders.View
{
    class InvadersHelper
    {
        static Random random = new Random();

        public static UIElement StarControlFactory(double scale)
        {
            int randomStarType = random.Next(0, 3);

            if (randomStarType == 0)
            {
                Ellipse ellipse = new Ellipse();
                ellipse.Width = 1 * scale;
                ellipse.Height = 1 * scale;
                ellipse.Fill = GetRandomColor();
                return ellipse;
            }

            else if (randomStarType == 1)
            {
                Rectangle rectangle = new Rectangle();
                rectangle.Width = 1 * scale;
                rectangle.Height = 1 * scale;
                rectangle.Fill = GetRandomColor();
                return rectangle;
            }

            else
            {
                BigStar bigStar = new BigStar();
                bigStar.Width = 10 * scale;
                bigStar.Height = 10 * scale;
                bigStar.SetFill(GetRandomColor());
                return bigStar;
            }

        }

        public static AnimatedImage PlayerControlFactory(TimeSpan interval)
        {
            List<string> imageNames = new List<string>();
            imageNames.Add("Images/player.png");
            return new AnimatedImage(imageNames, interval);
        }

        public static AnimatedImage InvadersControlFactory(InvaderType invaderType, TimeSpan interval)
        {
            List<string> imageNames = new List<string>();

            if(invaderType == InvaderType.Bug)
            {
                imageNames.Add("Images/bug1.png");
                imageNames.Add("Images/bug2.png");
                imageNames.Add("Images/bug3.png");
                imageNames.Add("Images/bug4.png");
            }

            else if(invaderType == InvaderType.Satellite)
            {
                imageNames.Add("Images/satellite1.png");
                imageNames.Add("Images/satellite2.png");
                imageNames.Add("Images/satellite3.png");
                imageNames.Add("Images/satellite4.png");
            }

            else if(invaderType == InvaderType.Saucer)
            {
                imageNames.Add("Images/flyingsaucer1.png");
                imageNames.Add("Images/flyingsaucer2.png");
                imageNames.Add("Images/flyingsaucer3.png");
                imageNames.Add("Images/flyingsaucer4.png");
            }

            else if(invaderType == InvaderType.Spaceship)
            {
                imageNames.Add("Images/spaceship1.png");
                imageNames.Add("Images/spaceship2.png");
                imageNames.Add("Images/spaceship3.png");
                imageNames.Add("Images/spaceship4.png");
            }

            else if(invaderType == InvaderType.Star)
            {
                imageNames.Add("Images/star1.png");
                imageNames.Add("Images/star2.png");
                imageNames.Add("Images/star3.png");
                imageNames.Add("Images/star4.png");
            }

            return new AnimatedImage(imageNames, interval);
        }

        private static SolidColorBrush GetRandomColor()
        {
            Color randomColor = Color.FromRgb((byte)random.Next(256), (byte)random.Next(256), (byte)random.Next(256));
            SolidColorBrush randomStarColor = new SolidColorBrush(randomColor);
            return randomStarColor;
        }

        public static Shape ScanLineFactory()
        {
            Rectangle rectangle = new Rectangle();
            rectangle.Fill = new SolidColorBrush(Colors.White);
            rectangle.Opacity = 0.1;
            return rectangle;
        }

        public static Rectangle ShotFactory(Rect rect, bool playerShot)
        {
            Rectangle rectangle = new Rectangle();
            if(playerShot)
                rectangle.Fill = new SolidColorBrush(Colors.Lime);
            else
                rectangle.Fill = new SolidColorBrush(Colors.Red);
            return rectangle;
        }

        public static void ResizeElement(FrameworkElement animatedImage, double width, double height)
        {
            animatedImage.Width = width;
            animatedImage.Height = height;
        }

        public static void RepositionElement(FrameworkElement animatedImage, double X, double Y)
        {
            Canvas.SetLeft(animatedImage, X);
            Canvas.SetTop(animatedImage, Y);
        }

        public static void SendToBack(FrameworkElement newStar)
        {
            Canvas.SetZIndex(newStar, -1000);
        }
    }
}
