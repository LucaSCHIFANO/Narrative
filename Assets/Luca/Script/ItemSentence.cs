using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemSentence : MonoBehaviour
{
    
    //private Color baseColor;
    
    private bool clicked;
    private Vector3 initialTrans;

    private float timer;
    private bool okayTimer;
    
    
    //GetCompo
    public Image image;
    public Text text;

    //Scoring
    public int friendS;
    public int path;
    public int step;

    private void Start()
    {

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

        }
    }

    private void OnMouseDown()
    {
        initialTrans = transform.position;
        okayTimer = true;


    }

    private void OnMouseUp()
    {
        if (Vector3.Distance(initialTrans, transform.position) < 0.25f && okayTimer)
        {
            //Debug.Log("Audible, raconte moi une histoire");
            Letter.Instance.setNewImage(this ,gameObject.name);
        }
        
        //image.color = baseColor;
        initialTrans = Vector3.zero;
        

    }
    
    public void SetScore(int pathId = 0, int friendS = 0, int stepId = 0)
    {
        this.path = pathId;
        this.friendS = friendS;
        this.step = stepId;
    }

}
