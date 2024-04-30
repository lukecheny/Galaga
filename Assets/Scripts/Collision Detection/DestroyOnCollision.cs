using UnityEngine;

public class DestroyOnCollision : MonoBehaviour {
    void OnCollisionEnter2D(Collision2D collision) 
    {
        Destroy(gameObject);
    }
}