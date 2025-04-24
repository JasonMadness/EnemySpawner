using System;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    private Vector3 _direction;

    private void Update()
    {
        transform.Translate(Vector3.forward * Time.deltaTime);
    }

    public void SetDirection(Vector3 direction)
    {
        _direction = direction;
        transform.LookAt(_direction);
    }
}
