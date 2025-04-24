using System;
using System.Collections;
using UnityEngine;
using Random = UnityEngine.Random;

public class SpawnerActivator : MonoBehaviour
{
    [SerializeField] private Spawner[] _spawners;
    
    private float _delay = 2.0f;
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
            _spawners[index].GenerateEnemy();
            yield return delay;
        }
    }
}
