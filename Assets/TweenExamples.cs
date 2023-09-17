using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;


public class TweenExamples : MonoBehaviour
{
    public GameObject Alarm_UI;
    public Vector3 TargetSize;
    public Vector3 TargetPos;
    public float TargetTime;
    public float moveSpeed;

    public GameObject Star_1, Star_2, Star_3;
    public Transform Star1, Star2, Star3;

    private void Start()
    {
        Star_1.transform.DOMove(Star1.position,1);
        Star_2.transform.DOMove(Star2.position,1);
        Star_3.transform.DOMove(Star3.position,1);
    }
    public void ResizeDown()
    {
        Alarm_UI.transform.DOScale(TargetSize, TargetTime).SetEase(Ease.InOutElastic);
    }

    public void ChangePosition()
    {
        Alarm_UI.transform.DOLocalMove(TargetPos, moveSpeed).OnComplete(()=> ResizeDown());
    }
}
