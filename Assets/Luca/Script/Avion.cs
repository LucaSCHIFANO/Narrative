using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;

public class Avion : MonoBehaviour
{
    public List<Transform> basicPosition;
    public void flyLittlePlane(float flyTime)
    {
               
        Sequence sequence = DOTween.Sequence();

        sequence.Append(transform.DOMove(basicPosition[1].position, flyTime / 4));
        
        sequence.Append(transform.DOMove(new Vector2(basicPosition[1].position.x, basicPosition[1].position.y - Random.Range(0.5f, 2)), flyTime / 4));
        sequence.Append(transform.DOMove(new Vector2(basicPosition[1].position.x, basicPosition[1].position.y + Random.Range(0.5f, 2)), flyTime / 4));
        
        sequence.Append(transform.DOMove(basicPosition[2].position, flyTime / 4));
        
        Sequence sequence2 = DOTween.Sequence();

        
        sequence2.Append(transform.DOScale(1, (flyTime / 4)));
        sequence2.Append(transform.DOScale(1, (flyTime / 4) * 2));
        sequence2.Append(transform.DOScale(0.01f, (flyTime / 4)));

        sequence.Play();
        sequence2.Play();
    }
}
