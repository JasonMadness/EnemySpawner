using UnityEngine;

public class Enemy : MonoBehaviour
{
    private Target _target;

    private void Update()
    {
        FollowTarget();
    }

    public void SetTarget(Target target)
    {
        _target = target;
    }

    private void FollowTarget()
    {
        transform.LookAt(_target.transform.position);
        transform.Translate(Vector3.forward * Time.deltaTime);
    }
}
