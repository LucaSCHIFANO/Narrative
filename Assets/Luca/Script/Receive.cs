using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Receive : MonoBehaviour
{
    public GameObject phase1;

    public void replyButton()
    {
        gameObject.SetActive(false);
        phase1.SetActive(true);
    }
}
