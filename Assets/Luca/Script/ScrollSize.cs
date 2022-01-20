using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class ScrollSize : MonoBehaviour
{
    // Instance -------------------------------------
    private static ScrollSize _instance = null;
    public static ScrollSize Instance { get => _instance; }
    
    
    
    public List<GameObject> scrollObject = new List<GameObject>();
    
    
    public void Awake()
    {
        _instance = this;
    }

    public void destroyList()
    {
        for (int i = 0; i < scrollObject.Count; i++)
        {
            Destroy(scrollObject[i]); 
        }
        
        scrollObject.Clear();
    }
    
    
    public void resizeScrolling()
    {
        RectTransform rt = GetComponent<RectTransform>();

        rt.offsetMax = new Vector2(rt.offsetMin.x, 175f * (scrollObject.Count - 3));

    }
    
}
