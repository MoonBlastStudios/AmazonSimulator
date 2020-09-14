using Tools;
using UnityEngine;
using UnityEngine.Serialization;

namespace Character
{
    public class EntityController : MonoBehaviour
    {
        [Header("Character Values")]
        [SerializeField] private float m_speed = 0;
        [Header("Components")]
        [SerializeField] private Rigidbody2D m_rigidbody2D = null;

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
            m_rigidbody2D.velocity = new Vector2(m_speed*m_direction, m_rigidbody2D.velocity.y);
        }
        
        private void ChangeDirections()
        {
            var viewportPosition = CameraTools.GetViewportPosition(transform.position);
            Debug.Log(viewportPosition);
        }
    }
}
