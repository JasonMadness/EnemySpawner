using UnityEngine;

public class SpawnerActivator : MonoBehaviour
{
    [SerializeField] private Spawner[] _spawners;
    
    private float _startingDelay = 2.0f;
    private float _delay;

    private void Update()
    {
        _delay -= Time.deltaTime;

        if (_delay <= 0)
        {
            int index = Random.Range(0, _spawners.Length);
            _spawners[index].GenerateEnemy();
            _delay = _startingDelay;
        }
    }
}
