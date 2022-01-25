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
    private int pathS;

    public void Awake()
    {
        _instance = this;
        friendshipS = 5;
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void IncrementScore(int pathId, int friend)
    {
        friendshipS += friend;
        pathS = pathId; 
        Debug.Log("le score amitié : " + friendshipS + " le path est : " + pathS);

        PlayerPrefs.SetInt("friendValue", friendshipS);
        PlayerPrefs.SetInt("pathValue", pathS);
        PlayerPrefs.Save();
    }


}
