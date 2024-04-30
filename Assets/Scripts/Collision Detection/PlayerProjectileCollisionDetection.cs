using UnityEngine;

public class PlayerProjectileCollisionDetection : MonoBehaviour {
    public GameObject explosion;

    void OnCollisionEnter2D(Collision2D collision) 
    {
        // Instantiate(explosion, transform.position, transform.rotation);
        Destroy(gameObject);
    }

    private void OnBecameInvisible() 
    {
        Destroy(gameObject);
    }
}