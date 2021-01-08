using System;
using System.Collections.Generic;
using System.Text;

namespace Pattern.Singleton
{
    public static class SingletonContainer
    {
        public static Lazy<EpicFactory> Instance = new Lazy<EpicFactory>();
    }
}
