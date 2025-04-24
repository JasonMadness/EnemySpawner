using UnityEngine;

public class Mover : MonoBehaviour
{
    private void Update()
    {
        transform.Translate(Vector3.forward);
    }
}
