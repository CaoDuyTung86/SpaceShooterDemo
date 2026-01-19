using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Camera cam;
    private Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void FixedUpdate()
    {
        Vector3 mousePos = Input.mousePosition;
        mousePos.z = -cam.transform.position.z;

        Vector3 worldPos = cam.ScreenToWorldPoint(mousePos);
        rb.MovePosition(worldPos);
    }
}
