using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] private Enemy _enemyPrefab;
    [SerializeField] private Transform _spawnPoint;
    [SerializeField] private Transform _enemyTarget;
    
    private float _minAngle = -180.0f;
    private float _maxAngle = 180.0f;

    public void GenerateEnemy()
    {
        Enemy enemy = Instantiate(_enemyPrefab, _spawnPoint);
        enemy.SetTarget(_enemyTarget);
    }
}
