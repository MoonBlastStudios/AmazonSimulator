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

        /// <summary>
        /// Gets the Time Percentage Whether its the current time or the time remaining
        /// </summary>
        /// <param name="p_remaining">If True = Get % of time remaining, if false get total percentage</param>
        /// <param name="p_int">Whether to return the value as a whole integer</param>
        /// <returns></returns>
        public float GetTimerPercentage(bool p_remaining = false, bool p_int = false)
        {
            float returnVal = 0;
            
            if (!p_remaining)
            {
                returnVal = (!p_int) ? (m_currentTime / m_maxTime) : (m_currentTime / m_maxTime) * 100;
            }
            else
            {
                var timeLeft = m_maxTime - m_currentTime;
                returnVal = (!p_int) ? (timeLeft / m_maxTime) : (timeLeft / m_maxTime) * 100;
            }

            return returnVal;
        }

        public void Reset()
        {
            m_currentTime = 0;
        }
    }
}
