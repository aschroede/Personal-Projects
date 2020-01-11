using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StarryNight.View;
using StarryNight.Model;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.Windows;
using DispatcherTimer = System.Windows.Threading.DispatcherTimer;


namespace StarryNight.ViewModel
{
    class BeeStarViewModel
    {
        private readonly ObservableCollection<UIElement>
            _sprites = new ObservableCollection<UIElement>();
        public INotifyCollectionChanged Sprites { get { return _sprites; } }
        private readonly Dictionary<Star, StarControl> _stars = new Dictionary<Star, StarControl>();
        private readonly List<StarControl> _fadedStars = new List<StarControl>();

        private BeeStarModel _model = new BeeStarModel();
        private readonly Dictionary<Bee, AnimatedImage> _bees = new Dictionary<Bee, AnimatedImage>();
        private DispatcherTimer _timer = new DispatcherTimer();
        private Random _random = new Random();

        public Size PlayAreaSize
        {
            get
            {
                return _model.PlayAreaSize;
            }
            set
            {
                _model.PlayAreaSize = value;
            }
        }

        public BeeStarViewModel()
        {
            _model.BeeMoved += BeeMovedHandler;
            _model.StarChanged += StarChangedHandler;
            _timer.Tick += _timer_Tick;
            _timer.Interval = new TimeSpan(0, 0, 2);
            _timer.Start();
        }

        private void _timer_Tick(object sender, EventArgs e)
        {
            foreach (StarControl starControl in _fadedStars)
            {
                _sprites.Remove(starControl);
            }
            _model.Update();
        }

        private void StarChangedHandler(object sender, StarChangedEventArgs e)
        {
            if (_stars.ContainsKey(e.StarThatChanged))
            {
                if(e.Removed == true)
                {
                    _fadedStars.Add(_stars[e.StarThatChanged]);
                    _stars[e.StarThatChanged].FadeOut();
                    _stars.Remove(e.StarThatChanged);
                }

                else
                {
                    BeeStarHelper.SetCanvasLocation(_stars[e.StarThatChanged], e.StarThatChanged.Location.X, e.StarThatChanged.Location.Y);
                }
            }
            else
            {
                StarControl newStarControl = new StarControl();
                newStarControl.FadeIn();
                _stars.Add(e.StarThatChanged, newStarControl);
                _sprites.Add(newStarControl);
                BeeStarHelper.SendToBack(newStarControl);
                BeeStarHelper.SetCanvasLocation(newStarControl, e.StarThatChanged.Location.X, e.StarThatChanged.Location.Y);
            }

        }

        private void BeeMovedHandler(object sender, BeeMovedEventArgs e)
        {
            if (_bees.ContainsKey(e.BeeThatMoved))
            {
                BeeStarHelper.MoveElememtOnCanvas(_bees[e.BeeThatMoved], e.X, e.Y);
            }
            else
            {
                int newBeeSize = _random.Next(50, 100);
                AnimatedImage newBeeImage = BeeStarHelper.BeeFactory(newBeeSize, newBeeSize, TimeSpan.FromMilliseconds(50));
                BeeStarHelper.SetCanvasLocation(newBeeImage, e.X, e.Y);
                _bees.Add(e.BeeThatMoved, newBeeImage);
                _sprites.Add(newBeeImage);
            }
        }
    }
}
