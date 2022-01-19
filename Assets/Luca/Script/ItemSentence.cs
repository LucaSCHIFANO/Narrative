using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemSentence : MonoBehaviour
{

    private Image image;
    private Color baseColor;
    
    private bool clicked;
    private Vector3 initialTrans;

    private float timer;
    private bool okayTimer;


    private void Start()
    {
        image = GetComponent<Image>();
        baseColor = image.color;
    }

    private void Update()
    {
        if (okayTimer)
        {
            timer += Time.deltaTime;
        }

        if (timer > 0.5f)
        {
            okayTimer = false;
            timer = 0;
            //image.color = baseColor;
        }
    }

    private void OnMouseDown()
    {
        initialTrans = transform.position;
        okayTimer = true;
        image.color = new Color(0.5f, 0.5f, 0.5f);

    }

    private void OnMouseUp()
    {
        if (Vector3.Distance(initialTrans, transform.position) < 0.25f && okayTimer)
        {
            Debug.Log("Audible, raconte moi une histoire");
            Letter.Instance.setNewImage(image.sprite, baseColor, gameObject.name);
        }
        
        image.color = baseColor;
        initialTrans = Vector3.zero;
        

    }
    

}
