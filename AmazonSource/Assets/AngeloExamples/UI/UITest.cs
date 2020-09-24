using Tools;
using UnityEngine;

namespace AngeloExamples.UI
{
    //This script will simulate an example player
    public class UITest : MonoBehaviour
    {
        //[SerializeField] private CustomTimer m_increaseTimer = null;
        [SerializeField] private int m_lifeCount = 5;
        
        // Start is called before the first frame update
        private void Start()
        {
            //UIController.Instance.InitializeUI(m_lifeCount);
            UIController.Instance.DestroyMultipleHearts(2);
        }

        // Update is called once per frame
        void Update()
        {
            /*if (m_increaseTimer.Tick(Time.deltaTime))
            {
                UIController.Instance.DecreaseHeart(false);
            }*/
        }
    }
}
