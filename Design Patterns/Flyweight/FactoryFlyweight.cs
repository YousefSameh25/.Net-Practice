using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flyweight
{
    public enum FlyweightType
    {
        CountryWithCity,
    }

    // Must be static as if we create one object for every customer to get shared data
    // that means we failed in saving memory.
    public static class FactoryFlyweight <T>
    {
        private static readonly Dictionary<FlyweightType, T> _dic;

        static FactoryFlyweight()
        {
            _dic = new Dictionary<FlyweightType, T> ();
        }

        public static void AddSharedData(FlyweightType flyweightType, T data)
        {
            if (_dic.ContainsKey(flyweightType))
                return;
            _dic.Add(flyweightType, data);
        }

        public static T GetSharedData(FlyweightType flyweightType)
        { 
            if (_dic.ContainsKey(flyweightType))
                return _dic[flyweightType];

            throw new InvalidDataException();
        }



    }
}
