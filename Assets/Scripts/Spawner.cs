using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] private GameObject _enemyPrefab;
    [SerializeField] private Transform _spawnPoint;
    
    private float _maxAngle = 360.0f;

    public void GenerateEnemy()
    {
        Instantiate(_enemyPrefab, _spawnPoint.position, RandomizeDirection());
    }

    private Quaternion RandomizeDirection()
    {
        float angle = Random.Range(0, _maxAngle);
        return Quaternion.Euler(0.0f, angle, 0.0f);
    }
}
