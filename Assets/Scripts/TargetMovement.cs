using System;
using UnityEngine;

public class TargetMovement : MonoBehaviour
{
    [SerializeField] private Transform[] _checkpoints;

    private int _index;

    private void Update()
    {
        MoveToCheckpoint();
    }

    private void MoveToCheckpoint()
    {
        Vector3 direction = _checkpoints[_index].transform.position - transform.position;
        transform.Translate(direction * Time.deltaTime);
        Debug.Log(direction.magnitude);

        /*if (direction.magnitude <= 0)
        {
            _index++;

            if (_index == _checkpoints.Length)
                _index = 0;
        }*/
    }
}