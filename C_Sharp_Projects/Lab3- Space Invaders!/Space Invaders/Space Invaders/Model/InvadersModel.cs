using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media;
using Microsoft.Win32;
using System.Media;
using Space_Invaders.Model.Event_Arguments;
using System.Threading;

namespace Space_Invaders.Model
{
    class InvadersModel
    {
        public readonly static Size PlayAreaSize = new Size(400, 300);
        public const int MaximumPlayerShots = 50;
        public const int InitialStarCount = 50;
        private const double shipSpacingConst = 1.4;
        private const int invaderSize = 15;
        private int sideWaysMovesRequired = 0;
        
        private readonly Random random = new Random();

        public int Score { get; private set; }
        public int Wave { get; private set; }
        public int Lives { get; private set; }

        public bool GameOver { get; private set; }
        public bool Paused { get; set; }

        private DateTime? _playerDied = null;
        public bool PlayerDying { get { return _playerDied.HasValue; } }

        private Player _player;

        private readonly List<Invader> _invaders = new List<Invader>();
        private readonly List<Shot> _playerShots = new List<Shot>();
        private readonly List<Shot> _invaderShots = new List<Shot>();
        private readonly List<Point> _stars = new List<Point>();

        private Direction _invaderDirection = Direction.Left;
        private bool _justMovedDown = false;

        private DateTime _lastUpdated = DateTime.MinValue;
        private TimeSpan minimumTimeBetweenMoves = TimeSpan.FromSeconds(0.5);

        private const string shotSound = @"Sounds/SciFiGun5.wav";
        private const string music = @"Sounds/Player One - Space Invaders (1980).wav";
        private SoundPlayer shotmusicplayer = new SoundPlayer();
        

        public InvadersModel()
        {
            shotmusicplayer.SoundLocation = music;
            shotmusicplayer.LoadAsync();
            shotmusicplayer.PlayLooping();
            EndGame();
        }


        internal void UpdateAllShipsAndStars() // TODO: double check this method is working correctly
        {
            foreach (Invader invader in _invaders)
            {
                OnShipChanged(invader, false);
            }

            OnShipChanged(_player, false);

            foreach (Point point in _stars)
            {
                OnStarChanged(point, false);
            }
        }

        public void EndGame()
        {
            GameOver = true; 
        }

        public void StartGame()
        {
            GameOver = false;
            Score = 0;
            sideWaysMovesRequired = 0;
           
            foreach (Shot shot in _playerShots)
            {
                OnShotMoved(shot, true, true);
            }
            _playerShots.Clear();

            foreach (Shot shot in _invaderShots)
            {
                OnShotMoved(shot, true, false);
            }
            _invaderShots.Clear();

            foreach (Invader invader in _invaders)
            {
                OnShipChanged(invader, true);
            }
            _invaders.Clear();

            foreach (Point point in _stars)
            {
                OnStarChanged(point, true);
            }
            _stars.Clear();

            for (int i = 0; i < 50; i++)
            {
                int X = random.Next(0, (int)PlayAreaSize.Width);
                int Y = random.Next(0, (int)PlayAreaSize.Height);
                _stars.Add(new Point(X, Y));
            }

            _player = new Player(new Point(200, 300-15), new Size(25, 15));
            OnShipChanged(_player, false);
            Lives = 2;
            Wave = 0;
        }

        public void FireShot()
        {
            if (_playerShots.Count < MaximumPlayerShots)
            {
                Point shotLocation = new Point(_player.Location.X + 12, _player.Location.Y-5);
                Shot newShot = new Shot(shotLocation, Direction.Up, true);
                _playerShots.Add(newShot);
                OnShotMoved(newShot, false, true);
            }
        }


        public void MovePlayer(Direction direction)
        {
            if (_playerDied.HasValue == true)
                return;
            _player.Move(direction);
            OnShipChanged(_player, false);
        }

        public void Twinkle()
        {
            if (random.Next(2) == 0)
            {
                if (_stars.Count < InitialStarCount *1.5)
                {
                    Point newStar = new Point(random.Next((int)PlayAreaSize.Width), random.Next((int)PlayAreaSize.Height));
                    _stars.Add(newStar);
                    OnStarChanged(newStar, false);
                }
            }

            else
            {
                if (_stars.Count > InitialStarCount * 0.85)
                {
                    int randomStar = random.Next(_stars.Count);
                    Point star = _stars.ElementAt(randomStar);
                    OnStarChanged(star, true);
                    _stars.Remove(star);
                }
            }
        }

        public void Update()
        {
            Twinkle();

            if (_playerDied.HasValue && DateTime.Now - _playerDied.Value > TimeSpan.FromSeconds(2.5))
            {
                _playerDied = null;
                OnShipChanged(_player, false);
            }

            if (Paused)
                return;

            if (_invaders.Count == 0)
                NextWave();
            
            MoveInvaders();

            if(!PlayerDying)
                MoveShots();

            ReturnFire();
            CheckForInvaderCollisions();
            CheckForPlayerCollisions();
            CheckForInvaderReachingBottom();
        }

        private void CheckForInvaderReachingBottom()
        {
            foreach (Invader invader in _invaders)
            {
                if (invader.Location.Y > PlayAreaSize.Height - (invaderSize * 2))
                    EndGame();
            }
        }

        private void ReturnFire()
        {
            if (_invaderShots.Count == Wave + 1 || random.Next(10) < 10 - Wave)
                return;

            var invaderColumns =
                    from invader in _invaders
                    group invader by invader.Location.X into columns
                    orderby columns.Key descending
                    select columns;

            Invader shootingInvader = invaderColumns.ElementAt(random.Next(invaderColumns.Count())).Last();
            Point shotLocation = new Point(shootingInvader.Location.X + invaderSize / 2, shootingInvader.Location.Y + invaderSize);
            Shot newShot = new Shot(shotLocation, Direction.Down, false);
            _invaderShots.Add(newShot);
            OnShotMoved(newShot, false, false);
        }

        private void MoveShots()
        {
            if (_playerDied == null)
            {
                for (int i = 0; i < _invaderShots.Count; i++)
                {
                    _invaderShots[i].Move();
                    if (ShotOutOfBounds(_invaderShots[i]))
                    {
                        OnShotMoved(_invaderShots[i], true, false);
                        _invaderShots.RemoveAt(i);
                    }
                    else
                        OnShotMoved(_invaderShots[i], false, false);
                }

                for (int i = 0; i < _playerShots.Count; i++)
                {
                    _playerShots[i].Move();
                    if (ShotOutOfBounds(_playerShots[i]))
                    {
                        OnShotMoved(_playerShots[i], true, true);
                        _playerShots.RemoveAt(i);
                    }
                    else
                        OnShotMoved(_playerShots[i], false, true);
                }
            }
        }

        private void MoveInvaders()
        {
            if (DateTime.Now - _lastUpdated < minimumTimeBetweenMoves)
                return;
            if(_playerDied == null)
            {
                if (sideWaysMovesRequired == 0)
                {
                    foreach (Invader invader in _invaders)
                    {
                        if (invader.Location.X >= (PlayAreaSize.Width - 10) || invader.Location.X <= 10)
                            _justMovedDown = true;
                    }
                
                    if(_justMovedDown == true)
                    {
                        foreach (Invader invader in _invaders)
                        {
                            invader.Move(Direction.Down);
                            OnShipChanged(invader, false);
                        }
                        _justMovedDown = false;

                        if (_invaderDirection == Direction.Right)
                            _invaderDirection = Direction.Left;
                        else
                            _invaderDirection = Direction.Right;

                        _lastUpdated = DateTime.Now;
                        sideWaysMovesRequired = 10;
                        return;
                    }
                }

                foreach (Invader invader in _invaders)
                {
                    invader.Move(_invaderDirection);
                    OnShipChanged(invader, false);
                }
                _lastUpdated = DateTime.Now;

                if (sideWaysMovesRequired > 0)
                    --sideWaysMovesRequired;
            }

            //Decrease the time between each invader move as invaders die off
            
        }

        private void CheckForPlayerCollisions()
        {
            for (int i = 0; i < _invaderShots.Count; i++)
            {
                if (RectsOverlap(_player.Area, new Rect(_invaderShots[i].Location, _invaderShots[i].ShotSize)))
                {
                    OnShotMoved(_invaderShots[i], true, false);
                    _invaderShots.RemoveAt(i);
                    _playerDied = DateTime.Now;
                    OnShipChanged(_player, true);
                    if (Lives > 1)
                    {
                        --Lives;
                        return;
                    }
                    else
                    {
                        GameOver = true;
                        return;
                    }
                }
            }
        }

        private void CheckForInvaderCollisions()
        {

            List<Shot> temporaryShotList = new List<Shot>();
            List<Invader> temporaryInvaderList = new List<Invader>();
            for (int i = 0; i < _playerShots.Count; i++)
            {
                for (int j = 0; j < _invaders.Count; j++)
                {
                    if (RectsOverlap(new Rect(_playerShots[i].Location, _playerShots[i].ShotSize), _invaders[j].Area))
                    {
                        Score += _invaders[j].Score;
                        OnShotMoved(_playerShots[i], true, true);
                        temporaryShotList.Add(_playerShots[i]);
                        OnShipChanged(_invaders[j], true);
                        temporaryInvaderList.Add(_invaders[j]);
                        
                        minimumTimeBetweenMoves -= TimeSpan.FromMilliseconds(1);
                    }
                }
            }

            foreach (Shot shot in temporaryShotList)
            {
                _playerShots.Remove(shot);
            }

            foreach (Invader invader in temporaryInvaderList)
            {
                _invaders.Remove(invader);
            }
        }

        private void NextWave()
        {
            ++Lives;
            ++Wave;
            _invaders.Clear();
            Point firstShip = new Point(0,0);
            _invaderDirection = Direction.Left;
            minimumTimeBetweenMoves = TimeSpan.FromSeconds(0.5*Math.Pow(0.8,Wave));

            for (int i = 0; i < 6; i++)
            {
                for (int j = 0; j < 11; j++)
                {
                    switch (i)
                    {
                        case 0:
                            _invaders.Add(new Invader(InvaderType.Spaceship, new Point(firstShip.X + shipSpacingConst * j * invaderSize, 
                                firstShip.Y + shipSpacingConst * invaderSize * i), new Size(invaderSize, invaderSize), 50));
                            break;
                        case 1:
                            _invaders.Add(new Invader(InvaderType.Bug, new Point(firstShip.X + shipSpacingConst * j * invaderSize,
                                firstShip.Y + shipSpacingConst * invaderSize * i), new Size(invaderSize, invaderSize), 40));
                            break;
                        case 2:
                            _invaders.Add(new Invader(InvaderType.Saucer, new Point(firstShip.X + shipSpacingConst * j * invaderSize,
                                firstShip.Y + shipSpacingConst * invaderSize * i), new Size(invaderSize, invaderSize), 30));
                            break;
                        case 3:
                            _invaders.Add(new Invader(InvaderType.Satellite, new Point(firstShip.X + shipSpacingConst * j * invaderSize,
                                firstShip.Y + shipSpacingConst * invaderSize * i), new Size(invaderSize, invaderSize), invaderSize));
                            break;
                        case 4:
                            _invaders.Add(new Invader(InvaderType.Star, new Point(firstShip.X + shipSpacingConst * j * invaderSize,
                                firstShip.Y + shipSpacingConst * invaderSize * i), new Size(invaderSize, invaderSize), 10));
                            break;
                        case 5:
                            _invaders.Add(new Invader(InvaderType.Star, new Point(firstShip.X + shipSpacingConst * j * invaderSize,
                                firstShip.Y + shipSpacingConst * invaderSize * i), new Size(invaderSize, invaderSize), 10));
                            break;
                    }
                }
            }
        }

        public bool ShotOutOfBounds(Shot shot)
        {
            if (shot.Location.Y > 300 || shot.Location.Y < 0)
                return true;
            return false;
        }

        private static bool RectsOverlap(Rect r1, Rect r2)
        {
            r1.Intersect(r2);
            if (r1.Width > 0 || r1.Height > 0)
                return true;
            return false;
        }

        #region Events & Event Firing Methods

        public event EventHandler<ShipChangedEventArgs> ShipChanged;
        private void OnShipChanged(Ship shipUpdated, bool killed)
        {
            EventHandler<ShipChangedEventArgs> shipChanged = ShipChanged;
            if(shipChanged != null)
            {
                shipChanged(this, new ShipChangedEventArgs(shipUpdated, killed));
            }
        }

        public event EventHandler<ShotMovedEventArgs> ShotMoved;
        private void OnShotMoved(Shot shot, bool disappeared, bool playerShot)
        {
            EventHandler<ShotMovedEventArgs> shotMoved = ShotMoved;
            if (shotMoved != null)
            {
                shotMoved(this, new ShotMovedEventArgs(shot, disappeared, playerShot));
            }
        }

        public event EventHandler<StarChangedEventArgs> StarChanged;
        private void OnStarChanged(Point point, bool disappeared)
        {
            EventHandler<StarChangedEventArgs> starChanged = StarChanged;
            if (starChanged != null)
            {
                starChanged(this, new StarChangedEventArgs(point, disappeared));
            }
        }

        #endregion
    }
}
