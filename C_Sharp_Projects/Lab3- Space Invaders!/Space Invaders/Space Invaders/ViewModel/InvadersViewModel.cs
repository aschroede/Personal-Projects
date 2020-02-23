using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using Space_Invaders.View;
using Space_Invaders.Model;
using System.ComponentModel;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using DispatcherTimer = System.Windows.Threading.DispatcherTimer;
using FrameworkElement = System.Windows.FrameworkElement;
using System.Runtime.CompilerServices;
using System.Windows.Controls;
using System.Windows.Shapes;


namespace Space_Invaders.ViewModel
{
    class InvadersViewModel : INotifyPropertyChanged
    {
        private readonly ObservableCollection<FrameworkElement>
            _sprites = new ObservableCollection<FrameworkElement>();
        public INotifyCollectionChanged Sprites { get { return _sprites; } }

        public bool GameOver { get { return _model.GameOver; } }
        private readonly ObservableCollection<object> _lives =
            new ObservableCollection<object>();
        public INotifyCollectionChanged Lives { get { return _lives; } }

        private bool paused;
        public bool Paused
        {
            get
            {
                return paused;
            }
            set
            {
                paused = value;
                _model.Paused = paused;
            }
        }
        private bool _lastPaused = false;

        public static double Scale { get; private set; }
        public int Score { get; private set; }
        public int Wave { get; private set; }

        public Size PlayAreaSize
        {
            set
            {
                Scale = value.Width / 405;
                _model.UpdateAllShipsAndStars();
                RecreateScanLines();
            }
        }

        private readonly InvadersModel _model = new InvadersModel();
        private readonly DispatcherTimer _timer = new DispatcherTimer();
        private AnimatedImage _playerControl = null;
        private bool _playerFlashing = false;
        private readonly Dictionary<Invader, FrameworkElement> _invaders =
            new Dictionary<Invader, FrameworkElement>();
        private readonly Dictionary<FrameworkElement, DateTime> _shotInvaders =
            new Dictionary<FrameworkElement, DateTime>();
        private readonly Dictionary<Shot, FrameworkElement> _shots =
            new Dictionary<Shot, FrameworkElement>();
        private readonly Dictionary<Point, FrameworkElement> _stars =
            new Dictionary<Point, FrameworkElement>();
        private readonly List<FrameworkElement> _scanLines =
            new List<FrameworkElement>();

        private DateTime? _leftAction = null;
        private DateTime? _rightAction = null;
        private TimeSpan invaderAnimationInterval = TimeSpan.FromMilliseconds(120);

        public event PropertyChangedEventHandler PropertyChanged;

        public InvadersViewModel()
        {
            Scale = 1;

            _model.ShipChanged += ModelShipChangedEventHandler;
            _model.ShotMoved += ModelShotMovedEventHandler;
            _model.StarChanged += ModelStarChangedEventHandler;

            _timer.Interval = TimeSpan.FromMilliseconds(30);
            _timer.Tick += TimerTickEventHandler;

            EndGame();
        }

        internal void Restart()
        {
            StartGame();
        }

        public void StartGame()
        {
            Paused = false;
            foreach (FrameworkElement invader in _invaders.Values) _sprites.Remove(invader);
            _invaders.Clear();
            foreach (var shot in _shots.Values) _sprites.Remove(shot);
            _shots.Clear();
            foreach (FrameworkElement star in _stars.Values) _sprites.Remove(star);
            _stars.Clear();
            _model.StartGame();
            OnPropertyChanged("GameOver"); // TODO: not sure why this is necessary. May cause problems
            _timer.Start();
        }

        private void RecreateScanLines()
        {
            foreach (FrameworkElement scanLine in _scanLines)
            {
                if (_sprites.Contains(scanLine))
                    _sprites.Remove(scanLine);
            }
            _scanLines.Clear();
            for (int y = 0; y < 300; y+=4)
            {
                FrameworkElement scanLine = InvadersHelper.ScanLineFactory();
                _scanLines.Add(scanLine);
                _sprites.Add(scanLine);
                InvadersHelper.ResizeElement(scanLine, 400 * Scale, 1 * Scale);
                InvadersHelper.RepositionElement(scanLine, 0, y * Scale);
            }
        }

        private void EndGame()
        {
            // OnPropertyChanged("GameOver"); TODO: throwing an error with this code
        }

        private void TimerTickEventHandler(object sender, EventArgs e)
        {
            if(_lastPaused != Paused)
            {
                OnPropertyChanged("Paused");
                _lastPaused = Paused;
            }

            if (!Paused)
            {
                if(_leftAction.HasValue && _rightAction.HasValue)
                {
                    if (_leftAction.Value > _rightAction.Value)
                        _model.MovePlayer(Direction.Left);
                    else
                        _model.MovePlayer(Direction.Right);
                }
                else
                {
                    if (_leftAction.HasValue)
                        _model.MovePlayer(Direction.Left);
                    if (_rightAction.HasValue)
                        _model.MovePlayer(Direction.Right);
                }
            }

            _model.Update();

            if (Score != _model.Score)
            {
                Score = _model.Score;
                OnPropertyChanged("Score");
            }

            if(Wave != _model.Wave)
            {
                Wave = _model.Wave;
                OnPropertyChanged("Wave");
            }

            if(_model.Lives != _lives.Count)
            {
                int difference = _model.Lives - _lives.Count;

                if(difference > 0)
                {
                    for (int i = 0; i < difference; i++)
                    {
                        _lives.Add(new object());
                    }
                }

                else
                {
                    for (int i = 0; i < Math.Abs(difference); i++)
                    {
                        _lives.RemoveAt(0);
                    }
                }

            }

            foreach (FrameworkElement control in _shotInvaders.Keys.ToList())
            {
                if(DateTime.Now - _shotInvaders[control] > TimeSpan.FromSeconds(0.5))
                {
                    _sprites.Remove(control);
                    _shotInvaders.Remove(control);
                }
            }

            if (GameOver)
            {
                _lives.Clear();
                OnPropertyChanged("GameOver");
                _timer.Stop();
            }
        }

        private void ModelStarChangedEventHandler(object sender, Model.Event_Arguments.StarChangedEventArgs e)
        {
            if(e.Disappeared && _stars.ContainsKey(e.Point))
                _sprites.Remove(_stars[e.Point]);

            else
            {
                if (!_stars.ContainsKey(e.Point))
                {
                    FrameworkElement newStar = InvadersHelper.StarControlFactory(Scale) as FrameworkElement;
                    _stars.Add(e.Point, newStar);
                    _sprites.Add(newStar);
                    InvadersHelper.RepositionElement(newStar, e.Point.X * Scale, e.Point.Y * Scale);
                    InvadersHelper.SendToBack(newStar);
                }
            }
        }

        private void ModelShotMovedEventHandler(object sender, Model.Event_Arguments.ShotMovedEventArgs e)
        {
            if (!e.Disappeared)
            {
                if (!_shots.ContainsKey(e.Shot))
                {
                    Rectangle shot = InvadersHelper.ShotFactory(new Rect(e.Shot.Location, e.Shot.ShotSize), e.PlayerShot);
                    _shots.Add(e.Shot, shot);
                    _sprites.Add(shot);
                    InvadersHelper.ResizeElement(shot, shot.Width * Scale, shot.Height * Scale);
                    InvadersHelper.RepositionElement(shot, e.Shot.Location.X * Scale, e.Shot.Location.Y * Scale);
                }
                else
                {
                    InvadersHelper.ResizeElement(_shots[e.Shot], e.Shot.ShotSize.Width*Scale, e.Shot.ShotSize.Height * Scale);
                    InvadersHelper.RepositionElement(_shots[e.Shot], e.Shot.Location.X * Scale, e.Shot.Location.Y * Scale);
                }
            }

            else
            {
                if (_shots.ContainsKey(e.Shot))
                {
                    _sprites.Remove(_shots[e.Shot]);
                    _shots.Remove(e.Shot);
                }
            }
        }

        private void ModelShipChangedEventHandler(object sender, Model.Event_Arguments.ShipChangedEventArgs e)
        {
            if (!e.Killed)
            {
                if(e.ShipUdated is Invader)
                {
                    Invader invader = e.ShipUdated as Invader;

                    if (!_invaders.ContainsKey(invader))
                    {
                        AnimatedImage animatedImage = InvadersHelper.InvadersControlFactory(invader.InvaderType, invaderAnimationInterval);
                        _invaders.Add(invader, animatedImage);
                        _sprites.Add(animatedImage);
                        InvadersHelper.RepositionElement(_invaders[invader], invader.Location.X * Scale, invader.Location.Y * Scale);
                        InvadersHelper.ResizeElement(animatedImage, invader.Size.Width * Scale, invader.Size.Height * Scale);
                    }
                    else
                    {
                        InvadersHelper.RepositionElement(_invaders[invader], invader.Location.X * Scale, invader.Location.Y * Scale);
                        InvadersHelper.ResizeElement(_invaders[invader], invader.Size.Width * Scale, invader.Size.Height * Scale);
                    }
                }

                else if (e.ShipUdated is Player)
                {
                    Player player = e.ShipUdated as Player;
                    if (_playerFlashing == true)
                    {
                        _playerControl.StopFlashing();
                        _playerFlashing = false;
                    }
                    if(_playerControl == null)
                    {
                        _playerControl = InvadersHelper.PlayerControlFactory(invaderAnimationInterval);
                        _sprites.Add(_playerControl);
                        InvadersHelper.RepositionElement(_playerControl, player.Location.X * Scale, player.Location.Y * Scale);
                        InvadersHelper.ResizeElement(_playerControl, player.Size.Width * Scale, player.Size.Height * Scale);
                    }
                    else
                    {
                        InvadersHelper.RepositionElement(_playerControl, player.Location.X * Scale, player.Location.Y * Scale);
                        InvadersHelper.ResizeElement(_playerControl, player.Size.Width * Scale, player.Size.Height * Scale);
                    }
                }
            }

            else
            {
                if(e.ShipUdated is Invader)
                {
                    if(e.ShipUdated != null)
                    {
                        if(_invaders.ContainsKey(e.ShipUdated as Invader))
                        {
                            (_invaders[e.ShipUdated as Invader] as AnimatedImage).InvaderShot();
                            _shotInvaders.Add(_invaders[e.ShipUdated as Invader], DateTime.Now);
                            _invaders.Remove(e.ShipUdated as Invader);
                        }
                    }
                }
                   
                else if(e.ShipUdated is Player)
                {
                    _playerControl.StartFlashing();
                    _playerFlashing = true;
                }
            }
        }

        internal void KeyDown(Key key)
        {
            if (key == Key.Space)
                _model.FireShot();
            if (key == Key.Left)
                _leftAction = DateTime.Now;
            if (key == Key.Right)
                _rightAction = DateTime.Now;
        }

        internal void KeyUp(Key key)
        {
            if (key == Key.Left)
                _leftAction = null;
            if (key == Key.Right)
                _rightAction = null;
        }

        private void OnPropertyChanged([CallerMemberName] String propertyName = "")
        {
            PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
