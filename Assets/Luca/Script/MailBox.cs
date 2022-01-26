using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MailBox : MonoBehaviour
{
    [SerializeField] private Sprite open;
    [SerializeField] private Sprite close;

    private Image image;
    
    void Start()
    {
        image = GetComponent<Image>();
    }

    void Update()
    {
        
    }

    private void OnMouseDown()
    {
        image.sprite = open;
    }
}
