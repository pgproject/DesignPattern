using System;

namespace SingletonImplement
{
    public class SingletonTester
    {
        public static bool IsSingleton(Func<object> func)
        {
            var obj = func();
            var obj2 = func();

            return ReferenceEquals(obj, obj2);
        }
    }
}