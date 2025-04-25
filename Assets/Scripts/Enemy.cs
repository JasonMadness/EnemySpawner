using System;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    private Transform _target;

    private void Update()
    {
        FollowTarget();
    }

    public void SetTarget(Transform target)
    {
        _target = target;
    }

    private void FollowTarget()
    {
        transform.LookAt(_target);
        transform.Translate(Vector3.forward * Time.deltaTime);
    }
}
