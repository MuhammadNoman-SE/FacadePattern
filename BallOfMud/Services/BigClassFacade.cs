using System;
using System.Collections.Generic;
using System.Text;

namespace BallOfMud.Services
{
    public class BigClassFacade
    {
        public readonly BigClass _bigClass;
        public BigClassFacade() 
        {
            _bigClass = new BigClass();
            _bigClass.SetValueI(0);
        }
        public int IncrementBy(int addMe)
        {

            return _bigClass.AddToI(addMe);
        }
        public int DecrementBy(int addMe)
        {
            return _bigClass.AddToI(-addMe);

        }
        public int GetCurrent()
        {
            return _bigClass.GetValueA();
        }
    }
}
