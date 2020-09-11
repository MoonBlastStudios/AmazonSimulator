using System;
using UnityEngine;
using Random = UnityEngine.Random;

namespace Tools
{
    [Serializable]
    public class Range
    {
        //The minimum value of the range, this value will get exposed to the inspector
        [SerializeField] private float m_min;
        //The maximum value of the range, this value will get exposed to the inspector
        [SerializeField] private float m_max;


        public Range(float p_min, float p_max)
        {
            m_min = p_min;
            m_max = p_max;
        }

        /// <summary>
        /// Generate Random number within the min and max
        /// </summary>
        /// <returns>The Random number generated within the range</returns>
        public float GetRandom()
        {
            return Random.Range(m_min, m_max);
        }

        /// <summary>
        /// Will Return The Random Number as a rounded integer instead of a decimal float
        /// </summary>
        /// <returns>The Random Number generated</returns>
        public int GetRandomInt()
        {
            return (int) Random.Range(m_min, m_max);
        }


        /// <summary>
        /// If Creating it as an object is not desirable this function will generate a value between the given range
        /// </summary>
        /// <param name="p_min">The lower end of the range</param>
        /// <param name="p_max">The upper end of the range</param>
        /// <returns>Will return a random float within the range</returns>
        public static float GetRandomInRange(float p_min, float p_max)
        {
            return Random.Range(p_min, p_max);
        }
        
        /// <summary>
        /// If Creating it as an object is not desirable this function will generate a value between the given range
        /// </summary>
        /// <param name="p_min">The lower end of the range</param>
        /// <param name="p_max">The upper end of the range</param>
        /// <returns>Will return a random int within the range</returns>
        public static int GetRandomIntInRange(float p_min, float p_max)
        {
            return (int)Random.Range(p_min, p_max);
        }
        

        public float MIN => m_min;
        public float MAX => m_max;
    }
}
