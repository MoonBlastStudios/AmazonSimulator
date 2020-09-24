using System;
using System.Collections;
using System.Collections.Generic;
using Character;
using Tools;
using UnityEngine;
using UnityEngine.Serialization;

public class TestBox : MonoBehaviour
{
    [Header("Data")] 
    [SerializeField] private float m_minimumScale = 0.4f;
    [SerializeField] private bool m_destructionBox;
    
    [Header("Components")]
    [SerializeField] private Rigidbody2D m_rigidbody2D;
    [SerializeField] private CustomTimer m_deathTimer;

    [Header("Tags")]
    [SerializeField] private string m_groundTag = "Ground";
    [SerializeField] private string m_characterTag = "Character";
    [SerializeField] private string m_boxTag = "Box";


    private bool m_destroy = false;
    private Vector3 m_initialScale = Vector3.zero;

    private void Start()
    {
        Initialize();
    }

    private void Update()
    {
        DestructionLogic();
    }
    
    private void OnCollisionEnter2D(Collision2D p_collision)
    {
        var collisionGameObject = p_collision.gameObject;

        if (collisionGameObject.CompareTag(m_groundTag))
        {
            DestroyBox();   
        }

        if (collisionGameObject.CompareTag(m_characterTag))
        {
            HitPlayer(collisionGameObject);
        }

        if (collisionGameObject.CompareTag(m_boxTag))
        {
            HitBox(collisionGameObject);
        }
    }


    private void Initialize()
    {
        m_initialScale = transform.localScale;
    }

    private void DestructionLogic()
    {
        //if we do not want to destroy return
        if (!m_destroy) return;
        
        if (m_deathTimer.Tick(Time.deltaTime))
        {
            Destroy(gameObject);
        }
        //if the timer is currently still running
        else
        {
            var timerPercentage = m_deathTimer.GetTimerPercentage(true);
            if (transform.localScale.x < m_minimumScale) return;
            transform.localScale = m_initialScale * timerPercentage;
        }
    }

    private void HitBox(GameObject p_hitObject)
    {
        if (m_destructionBox)
        {
            var box = p_hitObject.GetComponent<TestBox>();
            box.DestroyInstant();
        }
    }
    
    private void DestroyBox()
    {
        m_destroy = true;
    }

    public void DestroyInstant()
    {
        Destroy(gameObject);
    }

    private void HitPlayer(GameObject p_hitObject)
    {
        DestroyInstant();
        var playerController = p_hitObject.GetComponent<EntityController>();
        playerController.PlayerHit();

    }
}
