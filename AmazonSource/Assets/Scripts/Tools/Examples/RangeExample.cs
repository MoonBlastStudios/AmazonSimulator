using System;
using UnityEngine;

namespace Tools.Examples
{
    public class RangeExample : MonoBehaviour
    {
        [SerializeField] private Range m_range = null;
        
        // Start is called before the first frame update
        private void Start()
        {
            //Will Get a Random float in the range given in the inspector
            float val = m_range.GetRandom();
            //Will Get a Random int in the range given in the inspector
            int val2 = m_range.GetRandomInt();
            
            Debug.Log(val);
            Debug.Log(val2);
        }
    }
}
