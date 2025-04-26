using UnityEngine;

public class TargetMovement : MonoBehaviour
{
    [SerializeField] private Transform[] _checkpoints;
    [SerializeField] private float _moveSpeed = 1f;
    [SerializeField] private float _reachedDistance = 0.1f;

    private int _index;

    private void Update()
    {
        MoveToCheckpoint();
    }

    private void MoveToCheckpoint()
    {
        Vector3 direction = _checkpoints[_index].position - transform.position;
        float distance = direction.magnitude;

        if (distance <= _reachedDistance)
        {
            _index++;
            
            if (_index >= _checkpoints.Length)
                _index = 0;
                
            return;
        }

        Vector3 moveDirection = direction.normalized;
        transform.Translate(moveDirection * _moveSpeed * Time.deltaTime, Space.World);
    }
}