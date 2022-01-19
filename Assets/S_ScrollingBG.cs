using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class S_ScrollingBG : MonoBehaviour
{
    [SerializeField] private Transform pointBase;
    [SerializeField] private float speed;

    // Start is called before the first frame update
    void Start()
    {
        transform.DOMove(pointBase.position, Vector2.Distance(transform.position,pointBase.position) / speed);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
