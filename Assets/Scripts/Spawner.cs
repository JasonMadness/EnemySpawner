using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] private Enemy _enemyPrefab;
    [SerializeField] private Transform _spawnPoint;
    
    private float _minAngle = -180.0f;
    private float _maxAngle = 180.0f;

    public void GenerateEnemy()
    {
        Enemy enemy = Instantiate(_enemyPrefab, _spawnPoint);
        enemy.SetDirection(RandomizeDirection());
    }

    private Vector3 RandomizeDirection()
    {
        float directionX = Random.Range(_minAngle, _maxAngle);
        float directionZ = Random.Range(_minAngle, _maxAngle);
        return new Vector3(directionX, 0.0f, directionZ);
    }
}
