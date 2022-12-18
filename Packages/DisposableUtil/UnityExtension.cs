using UnityEngine.UI;

namespace DisposableUtil
{
    public static class UnityExtension
    {
        //ボタンの寿命と紐づいたActionが返される
        public static DisposableAction OnClickAsDisposableAction(this Button button)
        {
            var action = new DisposableAction();
            button.onClick.AddListener(() => action.Call());
            action.AddLifecycle(button.gameObject);
            return action;
        }

        //トグルの寿命と紐づいたActionが返される
        public static DisposableAction<bool> OnValueChangedAsDisposableAction(this Toggle toggle)
        {
            var action = new DisposableAction<bool>();
            toggle.onValueChanged.AddListener(flag => action.Call(flag));
            action.AddLifecycle(toggle.gameObject);
            return action;
        }
    }
}
