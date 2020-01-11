using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;

namespace Baseball_Simulator
{
    class Fan
    {
        public ObservableCollection<string> FanSays = new ObservableCollection<string>();
        public Fan(Ball ball)
        {
            //ball.BallInPlay += Ball_BallInPlay;
            ball.BallInPlay += new EventHandler<BallEventArgs>(Ball_BallInPlay);
        }

        private void Ball_BallInPlay(object sender, EventArgs e)
        {
            if (e is BallEventArgs)
            {
                BallEventArgs ballEventArgs = e as BallEventArgs;
                if ((ballEventArgs.Distance > 400) && ballEventArgs.Trajectory > 30)
                {
                    FanSays.Add("Home run! I'm going for the ball!");
                }
                else
                    FanSays.Add("Woo-hoo! Yeah!");
            }
        }
    }
}
