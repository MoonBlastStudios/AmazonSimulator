using Managers;
using Tools.Managers;
using UnityEngine;

namespace Tools
{
    public class CameraTools
    {
        /// <summary>
        /// Will grab a world position and convert it to viewport space, by default will graph in orthographic view
        /// </summary>
        /// <param name="p_position">Current Position Of The Entity</param>
        /// <param name="p_cam">The Current Camera In The Level</param>
        /// <param name="p_orthographic">Whether The View is Orthographic or Perspective</param>
        public static Vector2 GetViewportPosition(Vector3 p_position, bool p_orthographic = true)
        {
            return BaseGameManager.Cam.WorldToViewportPoint(p_position);
        }
    }
}
