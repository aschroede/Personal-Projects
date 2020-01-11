using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;

namespace Baseball_Simulator
{
    class Pitcher
    {
        public ObservableCollection<string> PitcherSays = new ObservableCollection<string>();
        public Pitcher(Ball ball)
        {
            ball.BallInPlay += Ball_BallInPlay; 
        }

        private void Ball_BallInPlay(object sender, EventArgs e)
        {
            if(e is BallEventArgs)
            {
                BallEventArgs ballEventArgs = e as BallEventArgs;
                if ((ballEventArgs.Distance < 95) && ballEventArgs.Trajectory < 60)
                {
                    CatchBall();
                }
                else
                    CoverFirstBase();
            }
        }

        private void CoverFirstBase()
        {
            PitcherSays.Add("I covered first base");
        }

        private void CatchBall()
        {
            PitcherSays.Add("I caught the ball");
        }
    }
}
