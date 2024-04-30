using UnityEngine;

public class EnemyProjectileCollisionDetection : MonoBehaviour {
    void OnCollisionEnter2D(Collision2D collision) 
    {
        if (collision.gameObject.name.Contains("Player Ship")) Debug.Log("Uh oh...ship down");
    }
}