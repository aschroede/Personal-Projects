using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Media.Animation;

namespace Space_Invaders.View
{
    /// <summary>
    /// Interaction logic for AnimatedImage.xaml
    /// </summary>
    public partial class AnimatedImage : UserControl
    {

        private Storyboard invaderShotStoryboard;
        private Storyboard flashStoryboard;

        public AnimatedImage()
        {
            InitializeComponent();
        }

        public AnimatedImage(IEnumerable<string> imageNames, TimeSpan interval) : this()
        {
            StartAnimation(imageNames, interval);
            CreateInvaderFadingStoryboard();
            CreatePlayerFlashingStoryboard();
        }

        public void StartAnimation(IEnumerable<string> imageNames, TimeSpan interval)
        {
            Storyboard storyboard = new Storyboard();
            ObjectAnimationUsingKeyFrames animation = new ObjectAnimationUsingKeyFrames();
            Storyboard.SetTarget(animation, image);
            Storyboard.SetTargetProperty(animation, new PropertyPath(Image.SourceProperty));

            TimeSpan currentInterval = TimeSpan.FromMilliseconds(0);
            foreach (string imageName in imageNames)
            {
                ObjectKeyFrame keyFrame = new DiscreteObjectKeyFrame();
                keyFrame.Value = CreateImageFromAssets(imageName);
                keyFrame.KeyTime = currentInterval;
                animation.KeyFrames.Add(keyFrame);
                currentInterval = currentInterval.Add(interval);
            }

            storyboard.RepeatBehavior = RepeatBehavior.Forever;
            //storyboard.AutoReverse = true;
            storyboard.Children.Add(animation);
            storyboard.Begin();
        }

        private static BitmapImage CreateImageFromAssets(string imageFilename)
        {
            try
            {
                Uri uri = new Uri(imageFilename, UriKind.RelativeOrAbsolute);
                return new BitmapImage(uri);
            }
            catch (System.IO.IOException)
            {
                return new BitmapImage();
            }
        }

        private void CreateInvaderFadingStoryboard()
        {
            invaderShotStoryboard = new Storyboard();
            DoubleAnimation invaderAnimation = new DoubleAnimation();
            Storyboard.SetTarget(invaderAnimation, image);
            Storyboard.SetTargetProperty(invaderAnimation, new PropertyPath(Image.OpacityProperty));
            invaderAnimation.From = 1;
            invaderAnimation.To = 0;
            invaderAnimation.Duration = TimeSpan.FromSeconds(0.5);
            invaderAnimation.AutoReverse = false;
            invaderShotStoryboard.Children.Add(invaderAnimation);
        }

        private void CreatePlayerFlashingStoryboard()
        {
            flashStoryboard = new Storyboard();
            ObjectAnimationUsingKeyFrames playerAnimation = new ObjectAnimationUsingKeyFrames();
            Storyboard.SetTarget(playerAnimation, image);
            Storyboard.SetTargetProperty(playerAnimation, new PropertyPath(Image.VisibilityProperty));
            playerAnimation.RepeatBehavior = RepeatBehavior.Forever; 

            TimeSpan currentTime = TimeSpan.FromMilliseconds(0);
            bool visibile = true;

            for (int i = 0; i < 6; i++)
            {
                TimeSpan interval = TimeSpan.FromSeconds(0.5 * i);

                if(visibile == true)
                {
                    ObjectKeyFrame keyFrame = new DiscreteObjectKeyFrame();
                    keyFrame.Value = Visibility.Hidden;
                    keyFrame.KeyTime = currentTime + interval;
                    playerAnimation.KeyFrames.Add(keyFrame);
                    visibile = false;
                }
                else
                {
                    ObjectKeyFrame keyFrame = new DiscreteObjectKeyFrame();
                    keyFrame.Value = Visibility.Visible;
                    keyFrame.KeyTime = currentTime + interval;
                    playerAnimation.KeyFrames.Add(keyFrame);
                    visibile = true;
                }
            }

            flashStoryboard.Children.Add(playerAnimation);
        }

        public void InvaderShot()
        {
            invaderShotStoryboard.Begin();
        }

        public void StartFlashing()
        {
            flashStoryboard.Begin();
        }

        public void StopFlashing()
        {
            flashStoryboard.Stop(); // TODO: May not need this method. Consider removing it.
        }
    }
}
