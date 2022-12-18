using UnityEngine;

namespace DisposableUtil
{
    public class DestroyTrigger : MonoBehaviour
    {
        public DisposableAction onDestroy = new DisposableAction();


        private void OnDestroy()
        {
            onDestroy.Call();
            onDestroy.Dispose();
        }
    }
}