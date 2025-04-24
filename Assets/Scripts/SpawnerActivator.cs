using System;
using System.Collections;
using UnityEngine;
using Random = UnityEngine.Random;

public class SpawnerActivator : MonoBehaviour
{
    [SerializeField] private Spawner[] _spawners;
    
    private float _delay = 2.0f;
    private float _maxAngle = 360.0f;
    private bool _isNeedToSpawn = true;

    private void Start()
    {
        StartCoroutine(Work());
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.C))
            _isNeedToSpawn = false;
    }

    private IEnumerator Work()
    {
        WaitForSeconds delay = new(_delay);
        
        while (_isNeedToSpawn)
        {
            int index = Random.Range(0, _spawners.Length);
            float angle = Random.Range(0, _maxAngle);
            Quaternion direction = Quaternion.Euler(0.0f, angle, 0.0f);
            _spawners[index].GenerateEnemy(direction);
            yield return delay;
        }
    }
}
