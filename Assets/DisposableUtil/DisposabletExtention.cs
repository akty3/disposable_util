using System;
using System.Threading;
using UnityEngine;

namespace DisposableUtil
{
    public static class DisposabletExtension
    {
        /// disposableのDisposeをGameObjectの寿命と紐づける
        public static void AddLifecycle(this IDisposable disposable, GameObject obj)
        {
            var trigger = obj.AddComponent<DestroyTrigger>();

            trigger.onDestroy += () =>
            {
                if (disposable != null)
                {
                    disposable.Dispose();
                }
            };
        }

        /// CancellationTokenSourceのキャンセルをGameObjectの寿命と紐づける
        public static void AddLifecycle(this CancellationTokenSource tokenSource, GameObject obj)
        {
            var trigger = obj.AddComponent<DestroyTrigger>();

            trigger.onDestroy += () =>
            {
                if (tokenSource != null)
                {
                    tokenSource.Cancel();
                    tokenSource.Dispose();
                }
            };
        }

        /// disposableのIntegrationalDisposableの寿命と紐づける
        public static void AddLifecycle(this IDisposable disposable, IntegrationalDisposable integrationalDisposable)
        {
            integrationalDisposable.Add(disposable);
        }
    }
}
