using UnityEngine;

namespace Tools.Managers
{
    public class CustomTime
    {
        private static float _timeScale = 1.0f;
        
        public static float CustomDeltaTime()
        {
            return Time.deltaTime * _timeScale;
        }


        public static void SetTimeScale(float p_newTimeScale)
        {
            _timeScale = p_newTimeScale;
        }
    }
}
