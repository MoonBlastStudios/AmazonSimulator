using System;
using System.Collections;
using System.Collections.Generic;
using Character;
using Managers;
using Tools;
using UnityEngine;
using UnityEngine.Serialization;

public class TestBox : MonoBehaviour
{
    [Header("Data")] 
    [SerializeField] private int m_camLayerID;
    [SerializeField] private float m_minimumScale = 0.4f;
    [SerializeField] private bool m_destructionBox;
    [SerializeField] private float m_defaultSpeed;
    
    [Header("Components")]
    [SerializeField] private Rigidbody2D m_rigidbody2D;
    [SerializeField] private CustomTimer m_deathTimer;

    [Header("Tags")]
    [SerializeField] private string m_groundTag = "Ground";
    [SerializeField] private string m_characterTag = "Character";
    [SerializeField] private string m_boxTag = "Box";
    [SerializeField] private string m_aimCursorTag = "AimCursor";

    

    private bool m_destroy = false;
    private Vector3 m_initialScale = Vector3.zero;
    private bool m_grounded = false;

    private void Start()
    {
        Initialize();
    }

    private void Update()
    {
        if(!m_grounded)
            UpdateFall();
        
        DestructionLogic();
    }

    public void SetCamLayer(int p_pos, int p_unityLayer)
    {
        m_camLayerID = p_pos;
        SetLayerRecursively(gameObject, p_unityLayer);
    }

    private void SetLayerRecursively(GameObject p_gameObject, int p_layer)
    {
        if (null == p_gameObject)
        {
            return;
        }
       
        p_gameObject.layer = p_layer;
       
        foreach (Transform child in p_gameObject.transform)
        {
            if (null == child)
            {
                continue;
            }
            SetLayerRecursively(child.gameObject, p_layer);
        }
    }
    
    
    private void OnCollisionEnter2D(Collision2D p_collision)
    {
        var collisionGameObject = p_collision.gameObject;

        if (collisionGameObject.CompareTag(m_groundTag))
        {
            m_grounded = true;
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

    public void UpdateFall()
    {
        var speed = GameManager.ValidateBox(m_camLayerID) ? 1 * GameManager.DefaultSpeed : GameManager.SlowdownValue * GameManager.DefaultSpeed;

        if (QtePanelController.Active)
            speed *= QtePanelController.PauseTime;
        
            m_rigidbody2D.velocity = new Vector2(0, -speed);
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
            BoxManager.RemoveBox(this);
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
        BoxManager.RemoveBox(this);
        Destroy(gameObject);
    }

    private void HitPlayer(GameObject p_hitObject)
    {
        DestroyInstant();
        var playerController = p_hitObject.GetComponent<EntityController>();
        playerController.PlayerHit();

    }


    private void OnTriggerEnter2D(Collider2D p_other)
    {
        if (p_other.CompareTag(m_aimCursorTag))
        {
            GameManager.AimCursor.AddBoxToList(gameObject);
            Debug.Log("Added To List");
        }
    }

    private void OnTriggerExit2D(Collider2D p_other)
    {
        if (p_other.CompareTag(m_aimCursorTag))
        {
            GameManager.AimCursor.RemoveFromList(gameObject);
        }
    }
}
