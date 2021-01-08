using System;
using System.Collections.Generic;
using System.Text;

namespace Pattern.Singleton
{
    public class EpicFactory
    {
        public int CreateAValue()
        {
            return new Random().Next(int.MaxValue);
        }
    }
}
