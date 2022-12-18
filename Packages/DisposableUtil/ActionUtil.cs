using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DisposableUtil
{
    public static class ActionExtension
    {
        public static bool Call(this Action action)
        {
            if(action != null)
            {
                action.Invoke();
                return true;
            }
            return false;
        }


        public static bool Call<T>(this Action<T> action, T t)
        {
            if (action != null)
            {
                action.Invoke(t);
                return true;
            }
            return false;
        }

        public static bool Call<T1, T2>(this Action<T1, T2> action, T1 t1, T2 t2)
        {
            if (action != null)
            {
                action.Invoke(t1, t2);
                return true;
            }
            return false;
        }

        public static bool Call<T1, T2, T3>(this Action<T1, T2, T3> action, T1 t1, T2 t2, T3 t3)
        {
            if (action != null)
            {
                action.Invoke(t1, t2, t3);
                return true;
            }
            return false;
        }

        public static bool Call<T1, T2, T3, T4>(this Action<T1, T2, T3, T4> action, T1 t1, T2 t2, T3 t3, T4 t4)
        {
            if (action != null)
            {
                action.Invoke(t1, t2, t3, t4);
                return true;
            }
            return false;
        }

        public static bool Call<T1, T2, T3, T4, T5>(this Action<T1, T2, T3, T4, T5> action, T1 t1, T2 t2, T3 t3, T4 t4, T5 t5)
        {
            if (action != null)
            {
                action.Invoke(t1, t2, t3, t4, t5);
                return true;
            }
            return false;
        }

        public static bool Call<T1, T2, T3, T4, T5, T6>(this Action<T1, T2, T3, T4, T5, T6> action, T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6)
        {
            if (action != null)
            {
                action.Invoke(t1, t2, t3, t4, t5, t6);
                return true;
            }
            return false;
        }
    }
}
