using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class S_UnableThis : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void EnableThis()
    {
        gameObject.GetComponent<Button>().interactable = false;
        SoundManager.Instance.Play("Special");
    }
}
