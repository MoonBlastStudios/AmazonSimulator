using System;
using System.Collections;
using System.Collections.Generic;
using Character;
using Managers;
using TMPro;
using Tools;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using Random = UnityEngine.Random;

public class QtePanelController : MonoBehaviour
{
    [SerializeField] private Slider m_timeSlider;
    [SerializeField] private float m_maxTime;
    [SerializeField] private TMP_InputField m_inputField;
    [SerializeField] private TextMeshProUGUI m_item;
    [SerializeField] private Transform m_boxHolder;

    private CustomTimer m_customTimer;
    private static QtePanelController _instance = null;
    private string m_itemToWrite;

    private float m_pauseTime = 0.1f;

    private void Awake()
    {
        m_customTimer = new CustomTimer(m_maxTime,false);
        _instance = this;
        gameObject.SetActive(false);
    }
    
    
    // Start is called before the first frame update
    void Start()
    {
           
    }

    // Update is called once per frame
    void Update()
    {
        m_timeSlider.value = 1 - m_customTimer.GetTimerPercentage();
        
        if (m_customTimer.Tick(Time.deltaTime))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }

    public static void EnablePanel()
    {
        _instance.gameObject.SetActive(true);
        var item = GameManager.QtePhrases[Random.Range(0, GameManager.QtePhrases.Length)];
        _instance.m_itemToWrite = item;
        _instance.m_item.text = _instance.m_itemToWrite;
    }

    public void CheckValid()
    {
        var labelValue = m_inputField.text.ToLower();
        var item = m_itemToWrite.ToLower();
        
        if (labelValue.Equals(item))
        {
            EntityController.SetMaxLife();
            gameObject.SetActive(false);
            m_customTimer.Reset();

            while (m_boxHolder.childCount > 0)
            {
                var box = m_boxHolder.GetChild(0).gameObject.GetComponent<TestBox>();
                box.DestroyInstant();
            }
        }
        else
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }

    
    public QtePanelController Instance => _instance;
    public static bool Active => _instance.gameObject.activeInHierarchy;
    public static float PauseTime => _instance.m_pauseTime;
}
