using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EScoreManager : MonoBehaviour
{
    // Instance -------------------------------------
    private static EScoreManager _instance = null;
    public static EScoreManager Instance { get => _instance; }

    private int friendshipS;
    private int loveshipS;

    public void Awake()
    {
        _instance = this;

    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void IncrementScore(int loveS, int friend)
    {
        friendshipS += friend;
        loveshipS += loveS; 
        Debug.Log("le score amitié : " + friendshipS + " le score amour : " + loveshipS);

    }

}
