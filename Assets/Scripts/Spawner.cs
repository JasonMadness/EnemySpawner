using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] private GameObject _enemyPrefab;
    [SerializeField] private Transform _spawnPoint;

    public void GenerateEnemy(Quaternion direction)
    {
        Instantiate(_enemyPrefab, _spawnPoint.position, direction);
    }
}
