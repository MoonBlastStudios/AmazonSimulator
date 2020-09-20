using System;
using UnityEngine;
using UnityEngine.UI;

namespace AngeloExamples.UI
{
    public class UIController : MonoBehaviour
    {
        [Header("Components")]
        [SerializeField] private Transform m_heartHolder = null;

        [Header("Prefabs To Use")] 
        [SerializeField] private GameObject m_heartPrefab = null;
        
        private static UIController _instance;


        private void Awake()
        {
            BindInstance();
        }

        // Start is called before the first frame update
        void Start()
        {
        
        }

        // Update is called once per frame
        void Update()
        {
        
        }

        private void BindInstance()
        {
            if (_instance == null)
            {
                _instance = this;
            }
            else
            {
                Destroy(gameObject);
            }
        }


        /// <summary>
        /// This function will startup the UI and add all the elements that we need
        /// </summary>
        /// <param name="p_lifeCount">The maximum life count of the player</param>
        public void InitializeUI(int p_lifeCount)
        {
            CreateHearts(p_lifeCount);
        }

        
        /// <summary>
        /// Will Generate the hearts based on the heart prefab
        /// </summary>
        /// <param name="p_lifeCount">The amount of hearts to generate</param>
        private void CreateHearts(int p_lifeCount)
        {
            for (var i = 0; i < p_lifeCount; i++)
            {
                var heart = CreateHeart();
            }
        }


        /// <summary>
        /// Will increase the amount of hearst to display by 1
        /// </summary>
        public void IncreaseHeart()
        {
            CreateHeart();
        }

        /// <summary>
        /// Destroys/Disable a single heart in the holder
        /// </summary>
        /// <param name="p_destroy">whether to disable or destroy the gameobject</param>
        public void DecreaseHeart(bool p_destroy)
        {
            DestroyHeart(p_destroy);
        }

        /// <summary>
        /// Destroys/Disables Multiple Hearts
        /// </summary>
        /// <param name="p_destroy">Whether to destroy or disable the heart</param>
        /// <param name="p_count">The amount of hearts to disable or destroy</param>
        public void DestroyMultipleHearts(int p_count, bool p_destroy = false)
        {
            //We grab the total amount of hearts at the beginning
            var currentHeartCount = m_heartHolder.childCount;
            
            for (var i = 0; i < p_count; i++)
            {
                //we check if there are no more hearts available
                if (currentHeartCount == 0) return;
                
                //We Destroy the heart
                DestroyHeart(p_destroy);
                
                //We reduce the amount of hearts left by 1
                currentHeartCount--;
            }
        }


        /// <summary>
        /// Creates a new heart object and returns it
        /// </summary>
        /// <returns>the heart object to return</returns>
        private GameObject CreateHeart()
        {
            return Instantiate(m_heartPrefab, Vector3.zero, Quaternion.identity, m_heartHolder);
        }

        /// <summary>
        /// Destroys a Single Heart
        /// </summary>
        /// <param name="p_destroy">Whether to use destroy or not</param>
        private void DestroyHeart(bool p_destroy = false)
        {
            if (p_destroy)
            {
                //Destroy the object completely from the holder 
                Destroy(m_heartHolder.GetChild(0).gameObject);
            }
            else
            {
                foreach (Transform heart in m_heartHolder)
                {
                    //Grab the heart gameobject
                    var heartGameObject = heart.gameObject;

                    //check if its active or not -- if it is not active the skip over this item
                    if (!heartGameObject.activeInHierarchy) continue;
                    
                    //set the heart object to false
                    heartGameObject.SetActive(false);
                    
                    //exit out of the loop
                    break;
                }
            }
        }
        
        public static UIController Instance => _instance;
    }
}
