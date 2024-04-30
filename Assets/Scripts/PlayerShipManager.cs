using UnityEngine;

public class PlayerShipManager : MonoBehaviour 
{
    public float playerShipSpeed = 4;
    public float playerProjectileSpeed = 4;
    public Rigidbody2D playerProjectile;

    private float lastFireButtonPressTime = 0f;
    private float fireButtonPressDelay = 0.5f;
    private Vector2 playerShipDirection;
    private Rigidbody2D object2D;

    // Start is called before the first frame update
    private void Start() 
    {
        object2D = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    private void Update() 
    {
        float x = Input.GetAxisRaw("Horizontal");

        playerShipDirection = new Vector2(x, 0).normalized;

        if (transform.position.x < -3.503f) transform.position = new Vector2(-3.503f, transform.position.y);
        else if (transform.position.x > 3.535f) transform.position = new Vector2(3.535f, transform.position.y);

        if (Input.GetButtonDown("Fire1")) OnFireButtonPress();
    }

    // FixedUpdate() runs in sync with the physics engine itself (depends on how many physics frames per second)
    private void FixedUpdate() 
    {
        object2D.velocity = playerShipDirection * playerShipSpeed;
    }

    private void OnFireButtonPress()
    {
        if (lastFireButtonPressTime + fireButtonPressDelay > Time.unscaledTime) return;

        lastFireButtonPressTime = Time.unscaledTime;

        Rigidbody2D playerProjectileClone = Instantiate(playerProjectile, new Vector2(transform.position.x - 0.015f, transform.position.y + 0.4f), transform.rotation);
        playerProjectileClone.velocity = transform.up * playerProjectileSpeed;
    }
}
