using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] private GameObject _enemyPrefab;
    [SerializeField] private Transform _spawnPoint;

    public void GenerateEnemy()
    {
        Instantiate(_enemyPrefab, _spawnPoint.position, transform.rotation);
    }
}
