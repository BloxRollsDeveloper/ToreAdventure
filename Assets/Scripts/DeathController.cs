using UnityEngine;

public class DeathController : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision other)
    {
        if (other.gameObject.CompareTag("Death"))
            Destroy(gameObject);
    }
}
