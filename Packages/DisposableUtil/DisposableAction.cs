using System;

namespace DisposableUtil
{
    //IDisposableで解放できるAction
    public class DisposableAction : IDisposable
    {
        private Action action;

        private Action onDispose;
        public Action OnDispose
        {
            set
            {
                onDispose += value;
            }
        }

        public bool IsDisposed { get; private set; }

        public bool Call()
        {
            return action.Call();
        }

        //再利用用
        public void Clear()
        {
            Dispose();
            IsDisposed = false;
        }

        public void Dispose()
        {
            onDispose.Call();
            IsDisposed = true;
            action = null;
        }

        public static DisposableAction operator +(DisposableAction a, Action b)
        {
            a.action += b;
            return a;
        }
        public static DisposableAction operator -(DisposableAction a, Action b)
        {
            a.action -= b;
            return a;
        }
    }

    //IDisposableで解放できるAction
    public class DisposableAction<T1> : IDisposable
    {
        private Action<T1> action;

        private Action onDispose;
        public Action OnDispose
        {
            set
            {
                onDispose += value;
            }
        }

        public bool IsDisposed { get; private set; }

        public bool Call(T1 t1)
        {
            return action.Call(t1);
        }

        //再利用用
        public void Clear()
        {
            Dispose();
            IsDisposed = false;
        }

        public void Dispose()
        {
            onDispose.Call();
            IsDisposed = true;
            action = null;
        }

        public static DisposableAction<T1> operator +(DisposableAction<T1> a, Action<T1> b)
        {
            a.action += b;
            return a;
        }
        public static DisposableAction<T1> operator -(DisposableAction<T1> a, Action<T1> b)
        {
            a.action -= b;
            return a;
        }
    }

    //IDisposableで解放できるAction
    public class DisposableAction<T1, T2> : IDisposable
    {
        private Action<T1, T2> action;

        private Action onDispose;
        public Action OnDispose
        {
            set
            {
                onDispose += value;
            }
        }

        public bool IsDisposed { get; private set; }

        public bool Call(T1 t1, T2 t2)
        {
            return action.Call(t1, t2);
        }

        //再利用用
        public void Clear()
        {
            Dispose();
            IsDisposed = false;
        }

        public void Dispose()
        {
            onDispose.Call();
            IsDisposed = true;
            action = null;
        }

        public static DisposableAction<T1, T2> operator +(DisposableAction<T1, T2> a, Action<T1, T2> b)
        {
            a.action += b;
            return a;
        }
        public static DisposableAction<T1, T2> operator -(DisposableAction<T1, T2> a, Action<T1, T2> b)
        {
            a.action -= b;
            return a;
        }
    }

    //IDisposableで解放できるAction
    public class DisposableAction<T1, T2, T3> : IDisposable
    {
        private Action<T1, T2, T3> action;

        private Action onDispose;
        public Action OnDispose
        {
            set
            {
                onDispose += value;
            }
        }

        public bool IsDisposed { get; private set; }

        public bool Call(T1 t1, T2 t2, T3 t3)
        {
            return action.Call(t1, t2, t3);
        }

        //再利用用
        public void Clear()
        {
            Dispose();
            IsDisposed = false;
        }

        public void Dispose()
        {
            onDispose.Call();
            IsDisposed = true;
            action = null;
        }

        public static DisposableAction<T1, T2, T3> operator +(DisposableAction<T1, T2, T3> a, Action<T1, T2, T3> b)
        {
            a.action += b;
            return a;
        }
        public static DisposableAction<T1, T2, T3> operator -(DisposableAction<T1, T2, T3> a, Action<T1, T2, T3> b)
        {
            a.action -= b;
            return a;
        }
    }

    //IDisposableで解放できるAction
    public class DisposableAction<T1, T2, T3, T4> : IDisposable
    {
        private Action<T1, T2, T3, T4> action;

        private Action onDispose;
        public Action OnDispose
        {
            set
            {
                onDispose += value;
            }
        }

        public bool IsDisposed { get; private set; }

        public bool Call(T1 t1, T2 t2, T3 t3, T4 t4)
        {
            return action.Call(t1, t2, t3, t4);
        }

        //再利用用
        public void Clear()
        {
            Dispose();
            IsDisposed = false;
        }

        public void Dispose()
        {
            onDispose.Call();
            IsDisposed = true;
            action = null;
        }

        public static DisposableAction<T1, T2, T3, T4> operator +(DisposableAction<T1, T2, T3, T4> a, Action<T1, T2, T3, T4> b)
        {
            a.action += b;
            return a;
        }
        public static DisposableAction<T1, T2, T3, T4> operator -(DisposableAction<T1, T2, T3, T4> a, Action<T1, T2, T3, T4> b)
        {
            a.action -= b;
            return a;
        }
    }

    //IDisposableで解放できるAction
    public class DisposableAction<T1, T2, T3, T4, T5> : IDisposable
    {
        private Action<T1, T2, T3, T4, T5> action;

        private Action onDispose;
        public Action OnDispose
        {
            set
            {
                onDispose += value;
            }
        }

        public bool IsDisposed { get; private set; }

        public bool Call(T1 t1, T2 t2, T3 t3, T4 t4, T5 t5)
        {
            return action.Call(t1, t2, t3, t4, t5);
        }

        //再利用用
        public void Clear()
        {
            Dispose();
            IsDisposed = false;
        }

        public void Dispose()
        {
            onDispose.Call();
            IsDisposed = true;
            action = null;
        }

        public static DisposableAction<T1, T2, T3, T4, T5> operator +(DisposableAction<T1, T2, T3, T4, T5> a, Action<T1, T2, T3, T4, T5> b)
        {
            a.action += b;
            return a;
        }
        public static DisposableAction<T1, T2, T3, T4, T5> operator -(DisposableAction<T1, T2, T3, T4, T5> a, Action<T1, T2, T3, T4, T5> b)
        {
            a.action -= b;
            return a;
        }
    }

    //IDisposableで解放できるAction
    public class DisposableAction<T1, T2, T3, T4, T5, T6> : IDisposable
    {
        private Action<T1, T2, T3, T4, T5, T6> action;

        private Action onDispose;
        public Action OnDispose
        {
            set
            {
                onDispose += value;
            }
        }

        public bool IsDisposed { get; private set; }

        public bool Call(T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6)
        {
            return action.Call(t1, t2, t3, t4, t5, t6);
        }

        //再利用用
        public void Clear()
        {
            Dispose();
            IsDisposed = false;
        }

        public void Dispose()
        {
            onDispose.Call();
            IsDisposed = true;
            action = null;
        }

        public static DisposableAction<T1, T2, T3, T4, T5, T6> operator +(DisposableAction<T1, T2, T3, T4, T5, T6> a, Action<T1, T2, T3, T4, T5, T6> b)
        {
            a.action += b;
            return a;
        }
        public static DisposableAction<T1, T2, T3, T4, T5, T6> operator -(DisposableAction<T1, T2, T3, T4, T5, T6> a, Action<T1, T2, T3, T4, T5, T6> b)
        {
            a.action -= b;
            return a;
        }
    }
}
