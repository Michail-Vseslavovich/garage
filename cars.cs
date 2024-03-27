using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace garage
{
    class Car
    {
        protected int _speed;
        protected int _maxSpeed;
        

        public Car(int speed =0, int maxSpeed = 10)
        {
            _speed = speed;
            _maxSpeed = maxSpeed;

        }
        public int Speed

        {
            get
            {
                return _speed;
            }
            set
            {
                if (value > _maxSpeed)
                {
                    _speed = _maxSpeed;
                }
                else
                {
                    _speed = value;
                }
            }
        }
        public virtual void Drift()
        {
            if (_speed > _maxSpeed / 2)
            {
                Console.WriteLine("Not drift  :((");
            }
            else
            {
                Console.WriteLine("Drift  :))");
            }
        }

    }





    sealed class SportCar : Car
    {
        private int super;
        public SportCar(int speed = 100, int maxspeed = 200, int supercharge = 1) : base(speed, maxspeed) 
        {
            super = supercharge;
        }

        public void SuperCharge()
        {
            if ( super>0) 
            {
                Console.WriteLine("Super  :)");
                super--;
            }
            else
            {   
                
                Console.WriteLine("Not super  :(");
            }
        }
        public override void Drift()
        {
            if (super > 0 && _speed < _maxSpeed)
            {
                Console.WriteLine("DRIFT!!!!");
                super--;
            }
            else
            {
                Console.WriteLine("Not drift  :(");
            }
             
        }
    }

}
