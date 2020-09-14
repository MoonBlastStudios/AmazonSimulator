using Tools;
using UnityEngine;
using UnityEngine.Serialization;

namespace Character
{
    public class EntityController : MonoBehaviour
    {
        [Header("Character Values")]
        //current speed
        [Tooltip("The speed at to which the character moves")]
        [SerializeField] private float m_speed = 0;

        [SerializeField] private Range m_screenRange; 
        [Header("Components")]
        [SerializeField] private Rigidbody2D m_rigidbody2D = null;
        //current direction
        private float m_direction = 1;
        
        // Start is called before the first frame update
        void Start()
        {
            SetSpeed();
        }

        // Update is called once per frame
        void Update()
        {
            ChangeDirections();
        }

        private void SetSpeed()
        {
            //sets speed while keeping y velocity 
            m_rigidbody2D.velocity = new Vector2(m_speed*m_direction, m_rigidbody2D.velocity.y);
        }
        
        private void ChangeDirections()
        {
            //finds the position of the object the script is attached to in viewport space 
            var viewportPosition = CameraTools.GetViewportPosition(transform.position);
            Debug.Log(viewportPosition);
            //when avatar hits edge of the screen, will make it change directions
            if (viewportPosition.x > m_screenRange.MAX && m_direction > 0)
            {
                m_direction = -1;
                SetSpeed();
            }
            if (viewportPosition.x < m_screenRange.MIN && m_direction < 0)
            {
                m_direction = 1;
                SetSpeed();
            }
        }
    }
}
