using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class SpawnManager : MonoBehaviour
{
    [SerializeField] private GameObject[] _gameObjects;
    [SerializeField] private float _timeSpawn = 2;

    private float count = 2;

    private void FixedUpdate()
    {
        count += Time.fixedDeltaTime;

        if (count >= _timeSpawn)
        {
            count = 0;
            Spawn();
        }
    }

    private void Spawn()
    {
        var g = Instantiate(_gameObjects[Random.Range(0, _gameObjects.Length)], transform);

        g.transform.localPosition = Vector3.zero;
    }
}