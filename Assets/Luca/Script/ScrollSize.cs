using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScrollSize : MonoBehaviour
{
    public List<GameObject> scrollObject = new List<GameObject>();
    
    void Start()
    {
        RectTransform rt = GetComponent<RectTransform>();

        rt.offsetMax = new Vector2(rt.offsetMin.x, 177.5f * (scrollObject.Count - 3));

    }
    
}
