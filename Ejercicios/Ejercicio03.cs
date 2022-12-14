using UnityEngine;

public class Ejercicio03 : MonoBehaviour
{
    private Rigidbody2D rb;

    bool isJumping;

    public float jumpForce;

    public float speed;

    public float rotation;

    public float rotationSpeed = 10;


    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    private void Update()
    {
        Movement();
    }

    public void Movement()
    {
        //Movimiento del jugador - Derecha
        if (Input.GetKeyDown(KeyCode.D))
        {
            rb.velocity = new Vector2(speed, rb.velocity.y);
        }

        //Movimiento del jugador - Izquierda
        if (Input.GetKeyDown(KeyCode.A))
        {
            rb.velocity = new Vector2(-speed, rb.velocity.y);
        }

        //Rotacion del jugador
        if (Input.GetKeyDown(KeyCode.R))
        {
            rotation += Time.deltaTime * rotationSpeed;
            transform.rotation = Quaternion.Euler(0, 0, rotation):
        }

        //Salto del jugador 
        if (Input.GetButton("Jump") && !isJumping)
        {
            rb2d.AddForce(Vector2.up * jumpForce, ForceMode2D.Impulse);
            Debug.Log("I?m jumping Wiiii");
            isJumping = true;
        }
    }

    //.... Funci?n para resetear el salto
}
