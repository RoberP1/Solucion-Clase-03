using UnityEngine;


public class Ejercicio01 : MonoBehaviour
{
    private Rigidbody2D rb_2d; 

    public float speed; 

    private void Start()
    {
        rb_2d = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        //Movimiento del jugador
        float x = Input.GetAxis("Horizontal");
        float y = Input.GetAxis("Verical");

        rb_2d.velocity = new Vector2(x , y) * speed;
    }
}
