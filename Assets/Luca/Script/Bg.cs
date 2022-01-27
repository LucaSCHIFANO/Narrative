using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;

public class Bg : MonoBehaviour
{
    public ONOFF goToONOFF;

    private Image image;
    
    
    public enum  ONOFF
    {
        ON,
        OFF,
    }

    private void Awake()
    {
        image = GetComponent<Image>();
    }

    void Start()
    {
        switch (goToONOFF)
        {
           case ONOFF.ON:
               image.DOFade(1, 1.5f);
               break;
           
           case ONOFF.OFF:
               image.DOFade(0, 1.5f);
               break;
        }
        
        Destroy(gameObject, 1.5f);
    }
}
