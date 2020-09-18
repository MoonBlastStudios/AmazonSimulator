using UnityEngine;

namespace Tools
{
    [System.Serializable]
    public class CustomTimer
    {
        [SerializeField]
        private float m_maxTime = 0;
        
        private float m_currentTime = 0;

        /// <summary>
        /// Starts up the timer
        /// </summary>
        /// <param name="p_maxTime"></param>
        /// <param name="p_startCompleted"></param>
        public CustomTimer(float p_maxTime, bool p_startCompleted)
        {
            if (p_startCompleted)
                m_currentTime = p_maxTime;
            
            m_maxTime = p_maxTime;
        }

        /// <summary>
        /// The main tick function for the timer
        /// </summary>
        /// <param name="p_delta">The delta time to increase ethe timer by</param>
        /// <returns>Returns true if the timer finishes, and false if the timer is runnig</returns>
        public bool Tick(float p_delta)
        {
            if (m_currentTime < m_maxTime)
            {
                m_currentTime += p_delta;
                return false;
            }

            m_currentTime = 0;
            return true;
        }


        /// <summary>
        /// Sets the max time
        /// </summary>
        /// <param name="p_maxTime">The new value of max time</param>
        public void SetMaxTime(float p_maxTime)
        {
            m_maxTime = p_maxTime;
        }

        /// <summary>
        /// Gets the current time
        /// </summary>
        /// <returns>The current time</returns>
        public float GetCurrentTime()
        {
            return m_currentTime;
        }
    }
}
