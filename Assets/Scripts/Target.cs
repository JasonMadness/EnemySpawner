using UnityEngine;

public class Target : MonoBehaviour
{
    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.TryGetComponent(typeof(Enemy), out _))
            Destroy(other.gameObject);
    }
}