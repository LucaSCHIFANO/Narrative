using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemSentence : MonoBehaviour
{
    private bool clicked;
    private Vector3 initialTrans;

    private void OnMouseDown()
    {
        Debug.Log("Jeremy");
        initialTrans = transform.position;
    }

    private void OnMouseUp()
    {
        if (Vector3.Distance(initialTrans, transform.position) < 0.25f)
        {
            Debug.Log("Jeanne");
        }
        
        //Debug.Log(Vector3.Distance(initialTrans, transform.position));
        initialTrans = Vector3.zero;
        
    }
    //mettre avec le tps aussi
    

}
