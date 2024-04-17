using System;
using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;

public class Ice : MonoBehaviour
{
    [SerializeField] private float _timeSpawn = 5;

    private float count = 0;

    private void Start()
    {
        transform.DOMoveY(7, _timeSpawn).SetEase(Ease.Linear).OnComplete(() => { DestroyImmediate(gameObject); });
    }
}