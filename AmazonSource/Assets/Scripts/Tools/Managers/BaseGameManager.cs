using UnityEngine;

namespace Tools.Managers
{
    public class BaseGameManager : MonoBehaviour
    {
        private static BaseGameManager _instance;

        protected void BindInstance()
        {
            if (_instance != null)
            {
                Destroy(gameObject);
                return;
            }
            else
            {
                _instance = this;
            }
        }

        public static BaseGameManager Instance => _instance;
    }
}
