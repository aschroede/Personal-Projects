using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using StarryNight.View;

namespace StarryNight.Model
{
    class BeeStarModel
    {
        public static readonly Size StarSize = new Size(150, 100);

        private readonly Dictionary<Bee, Point> _bees = new Dictionary<Bee, Point>();
        private readonly Dictionary<Star, Point> _stars = new Dictionary<Star, Point>();
        private Random _random = new Random();

        public event EventHandler<BeeMovedEventArgs> BeeMoved;
        public event EventHandler<StarChangedEventArgs> StarChanged;

        public BeeStarModel()
        {
            _playAreaSize = Size.Empty;
        }

        public void Update()
        {
            MoveOneBee();
            AddOrRemoveAStar();
        }

        private static bool RectsOverlap(Rect r1, Rect r2)
        {
            r1.Intersect(r2);
            if (r1.Width > 0 || r1.Height > 0)
                return true;
            return false;
        }

        private Size _playAreaSize;

        public Size PlayAreaSize
        {
            get
            {
                return _playAreaSize;
            }
            set
            {
                _playAreaSize = value;
                CreateBees();
                CreateStars();
            }
        }

        private void CreateBees()
        {
            // TODO: If the play area is empty, return
            if(_bees.Count > 0)
            {
                for (int i = 0; i < _bees.Count; i++)
                {
                    MoveOneBee(_bees.ElementAt(i).Key);
                }
            }
            else
            {
                int numberOfBees = _random.Next(5, 15);
                for (int i = 0; i < numberOfBees; i++)
                {
                    Bee bee = new Bee(GetPointForObject(),
                        new Size(_random.Next(40, 150), _random.Next(40, 150)));
                    bee.Location = FindNonOverlappingPoint(bee.Size);
                    _bees.Add(bee, bee.Location);
                    OnBeeMoved(bee, bee.Location.X, bee.Location.Y);
                    
                }
            }
        }

        private Point GetPointForObject()
        {
            return new Point(_random.Next(75, (int)PlayAreaSize.Width - 75), _random.Next(50, (int)PlayAreaSize.Height - 50));
        }

        private void OnBeeMoved(Bee bee, double x, double y)
        {
            EventHandler<BeeMovedEventArgs> beeMoved = BeeMoved;
            if(beeMoved != null)
            {
                beeMoved(this, new BeeMovedEventArgs(bee, x, y));
            }
        }

        private void CreateStars()
        {
            // TODO: If the play area is empty, return
            if(_stars.Count > 0)
            {
                foreach (Star star in _stars.Keys)
                {
                    star.Location = FindNonOverlappingPoint(new Size(100,150));

                    OnStarChanged(star, false); // TODO: Not sure if the "removed" parameter should be true or false?
                }
            }

            else
            {
                int numberOfStars = _random.Next(5, 10);
                for (int i = 0; i < numberOfStars; i++)
                {
                    CreateAStar();
                }
            }
        }

        private void OnStarChanged(Star star, bool removed)
        {
            EventHandler<StarChangedEventArgs> starChanged = StarChanged;
            if (StarChanged != null)
            {
                starChanged(this, new StarChangedEventArgs(star, removed));
            }
        }

        private void CreateAStar()
        {
            Point newPoint = FindNonOverlappingPoint(new Size(150, 100));
            Star newStar = new Star(newPoint);
            _stars.Add(newStar, newStar.Location);
            OnStarChanged(newStar, false); // TODO: Not sure if the "removed" parameter should be true or false?
        }

        private Point FindNonOverlappingPoint(Size size)
        {
            Rect newRect = new Rect(size);
            bool overlapping = false;
            int i = 0;

            do
            {
                newRect.X = _random.Next(75, (int)PlayAreaSize.Width-75);
                newRect.Y = _random.Next(50, (int)PlayAreaSize.Height-50);


                foreach (Bee bee in _bees.Keys)
                {
                    if (RectsOverlap(newRect, bee.Position))
                        overlapping = true;
                }
                foreach (Star star in _stars.Keys)
                {
                    if (RectsOverlap(newRect, new Rect(star.Location, new Size(150, 100))))
                        overlapping = true;
                }
                ++i;

                if (i >= 1000)
                    break;
            } while (overlapping == true);

            return new Point(newRect.Left, newRect.Top);
        }

        private void MoveOneBee(Bee bee = null)
        {
            if (_bees.Count == 0)
                return;
            if (bee == null)
                bee = _bees.ElementAt(_random.Next(0, _bees.Count)).Key;

            _bees.Remove(bee);
            bee.Location = FindNonOverlappingPoint(bee.Size);
            _bees.Add(bee, bee.Location);
            OnBeeMoved(bee, bee.Location.X, bee.Location.Y);
        }

        private void AddOrRemoveAStar()
        {
            if (_random.Next(2) == 0)
                CreateAStar();
            else
                RemoveRandomStar();
            if (_stars.Count <= 5)
                CreateAStar();
            if (_stars.Count >= 20)
                RemoveRandomStar();
        }

        private void RemoveRandomStar()
        {
            Star removedStar = _stars.ElementAt(_random.Next(0, _stars.Count)).Key;
            _stars.Remove(removedStar);
            OnStarChanged(removedStar, true);
        }
    }
}
