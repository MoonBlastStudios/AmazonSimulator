using UnityEngine;

namespace Tools.Examples
{
    public class RangeExample2 : MonoBehaviour
    {
        // Start is called before the first frame update
        private void Start()
        {
            var val = Range.GetRandomInRange(0, 50);
            var val2 = Range.GetRandomIntInRange(0, 50);
            
            Debug.Log(val);
            Debug.Log(val2);
        }
    }
}
