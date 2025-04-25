using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] private Enemy _enemyPrefab;
    [SerializeField] private Transform _spawnPoint;
    [SerializeField] private Target _enemyTarget;

    public void GenerateEnemy()
    {
        Enemy enemy = Instantiate(_enemyPrefab, _spawnPoint);
        enemy.SetTarget(_enemyTarget);
    }
}
