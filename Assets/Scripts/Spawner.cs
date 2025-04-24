using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] private GameObject _prefab;
    [SerializeField] private Transform _spawnPoint;

    public void GenerateEnemy()
    {
        Instantiate(_prefab, _spawnPoint.position, transform.rotation);
    }
}
