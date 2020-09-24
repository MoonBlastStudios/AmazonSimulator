using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthUi : MonoBehaviour
{
    [Header("Components")]
    [SerializeField] private Transform m_healthHolder = null;
    [SerializeField] private Transform m_emptyHealthHolder = null;

    [Header("Prefabs To Use")] 
    [SerializeField] private GameObject m_healthPrefab = null;
    [SerializeField] private GameObject m_emptyHealthPrefab = null;
        
    private static HealthUi _instance;


    private void Awake()
    {
        BindInstance();
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
    
    public static void CreateHearts(int p_lifeCount)
            {
                for (var i = 0; i < p_lifeCount; i++)
                {
                    var heart = _instance.CreateSingleHeart();
                    var backgroundheart = _instance.CreateSingleBackgroundHeart();
                }
            }
    
    private GameObject CreateSingleHeart()
    {
        return Instantiate(m_healthPrefab, Vector3.zero, Quaternion.identity, m_healthHolder);
    }
    
    private GameObject CreateSingleBackgroundHeart()
    {
        return Instantiate(m_emptyHealthPrefab, Vector3.zero, Quaternion.identity, m_emptyHealthHolder);
    }

    public static void RemoveHeart()
    {
        Destroy(_instance.m_healthHolder.GetChild(0).gameObject);
    }
}

