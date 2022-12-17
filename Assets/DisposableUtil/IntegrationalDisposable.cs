using System;
using System.Collections.Generic;

namespace DisposableUtil
{
    public class IntegrationalDisposable : IDisposable
    {
        private List<IDisposable> disposables;


        public IntegrationalDisposable()
        {
            this.disposables = new List<IDisposable>();
        }

        public IntegrationalDisposable(params IDisposable[] disposables)
        {
            this.disposables = new List<IDisposable>(disposables);
        }

        public void Add(IDisposable disposable)
        {
            this.disposables.Add(disposable);
        }

        public void AddRange(params IDisposable[] disposables)
        {
            this.disposables.AddRange(disposables);
        }

        public void Remove(IDisposable disposable)
        {
            this.disposables.Remove(disposable);
        }


        public void Dispose()
        {
            for(int i = 0; i < disposables.Count; i++)
            {
                if(disposables[i] != null)
                {
                    disposables[i].Dispose();
                    disposables[i] = null;
                }
            }

            disposables.Clear();
        }
    }
}
