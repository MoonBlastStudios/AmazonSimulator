using System;
using System.Collections;
using System.Collections.Generic;
using Managers;
using Tools.Managers;
using UnityEngine;
using UnityEngine.InputSystem;
using Random = UnityEngine.Random;

public class CamController : MonoBehaviour
{
    [SerializeField] private GameObject[] m_layers = null;
    [SerializeField] private int[] m_unityBindLayer = null;
    [SerializeField] private GameObject m_defaultCam = null;
    
    private MasterInput m_masterInput = null;
    [SerializeField] private int m_activeLayer = -1;
    

    private void Start()
    {
        Initialize();
    }


    // Update is called once per frame
    void Update()
    {
        
    }

    private void Initialize()
    {
        BaseGameManager.MasterInputs.Game.LayerCam.performed += ActivateLayer1;
        BaseGameManager.MasterInputs.Game.LayerCam1.performed += ActivateLayer2;
        BaseGameManager.MasterInputs.Game.LayerCam2.performed += ActivateLayer3;
        BaseGameManager.MasterInputs.Game.LayerCam3.performed += ActivateLayer4 ;
        BaseGameManager.MasterInputs.Game.LayerCam4.performed += ActivateLayer5 ;
    }
    
    
    private void ActivateLayer1(InputAction.CallbackContext p_obj)
    {
        TriggerLayerLogic(0, p_obj.action);
    }
    
    private void ActivateLayer2(InputAction.CallbackContext p_obj)
    {
        TriggerLayerLogic(1, p_obj.action);
    }
    
    private void ActivateLayer3(InputAction.CallbackContext p_obj)
    {
        TriggerLayerLogic(2, p_obj.action);
    }
    
    private void ActivateLayer4(InputAction.CallbackContext p_obj)
    {
        TriggerLayerLogic(3, p_obj.action);
    }
    
    private void ActivateLayer5(InputAction.CallbackContext p_obj)
    {
        TriggerLayerLogic(4, p_obj.action);
    }


    private void TriggerLayerLogic(int p_id, InputAction p_action)
    {
        var val = (int)p_action.ReadValue<float>();
        BoxManager.UpdateBox();
        
        Debug.Log(val);
        
        if(val == 1)
            ActivateLayer(p_id);
        else
        {
            EnableDefaultCam(p_id);
        }
    }

    private void EnableDefaultCam(int p_deactivationID)
    {
        if (p_deactivationID != m_activeLayer) return;
        
        Debug.Log("Activating Default cam");
        
        m_layers[m_activeLayer].SetActive(false);
        m_activeLayer = -1;
        m_defaultCam.SetActive(true);
    }



    private void ActivateLayer(int p_activate)
    {
        if(m_activeLayer != -1)
            m_layers[m_activeLayer].SetActive(false);
        
        if(m_defaultCam.activeInHierarchy)
            m_defaultCam.SetActive(false);
        
        m_layers[p_activate].SetActive(true);
        m_activeLayer = p_activate;
    }

    public void GetRandomLayer(out int p_layer, out int p_gameLayer)
    {
        var pos = Random.Range(0, m_unityBindLayer.Length);
        p_layer = pos;
        p_gameLayer = m_unityBindLayer[pos];
    }

    public int GetCurrentLayer()
    {
        return m_activeLayer;
    }

    private void OnDestroy()
    {
        if (BaseGameManager.Instance == null) return;
        
        BaseGameManager.MasterInputs.Game.LayerCam.performed -= ActivateLayer1;
        BaseGameManager.MasterInputs.Game.LayerCam1.performed -= ActivateLayer2;
        BaseGameManager.MasterInputs.Game.LayerCam2.performed -= ActivateLayer3;
        BaseGameManager.MasterInputs.Game.LayerCam3.performed -= ActivateLayer4 ;
        BaseGameManager.MasterInputs.Game.LayerCam4.performed -= ActivateLayer5 ;
    }
}
