using UnityEngine;

public class Player : MonoBehaviour
{
    // The force which is added when the player jumps
    // This can be changed in the Inspector window
    public Vector2 jumpForce = new Vector2(0, 300);
    public Vector2 forwardForce = new Vector2(300, 0);
    float scalex = 0.25f;
    float scaley = -0.25f;


    // Update is called once per frame
    void Update()
    {
        // Jump
        if (Input.GetKeyUp("up"))
        {
            //GetComponent<Rigidbody2D>().velocity = Vector2.zero;
            GetComponent<Rigidbody2D>().AddForce(jumpForce);
        }
        if(Input.GetKeyUp("down"))
        {
            //GetComponent<Rigidbody2D>().velocity = Vector2.zero;
            GetComponent<Rigidbody2D>().AddForce(-jumpForce);
        }
        if (Input.GetKeyUp("right"))
        {
            //GetComponent<Rigidbody2D>().velocity = Vector2.zero;
            GetComponent<Rigidbody2D>().AddForce(forwardForce);
            transform.localScale = new Vector3(scalex, transform.localScale.y, transform.localScale.z);
        }
        if (Input.GetKeyUp("left"))
        {
            //GetComponent<Rigidbody2D>().velocity = Vector2.zero;
            GetComponent<Rigidbody2D>().AddForce(-forwardForce);
            transform.localScale = new Vector3( -scalex, transform.localScale.y, transform.localScale.z);
        }
        // Die by being off screen
        Vector2 screenPosition = Camera.main.WorldToScreenPoint(transform.position);
        if (screenPosition.y > Screen.height)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y - 0.2f, transform.position.z);
            GetComponent<Rigidbody2D>().velocity = Vector2.zero;
        }
        if (screenPosition.y < 0.5)
        {
            //transform.position = new Vector3(transform.position.x, transform.position.y + 0.2f, transform.position.z);
            GetComponent<Rigidbody2D>().velocity = Vector2.zero;
        }
        if (screenPosition.x < -8)
        {
            //transform.position = new Vector3(transform.position.x, transform.position.y + 0.2f, transform.position.z);
            GetComponent<Rigidbody2D>().velocity = Vector2.zero;
        }
       
        if (Health.health < 0)
        {
            Application.LoadLevel(Application.loadedLevel);
        }
    }

    // Die by collision
    void OnCollisionEnter2D(Collision2D other)
    {
        //Die();
        //transform.localScale = new Vector3(transform.localScale.x * Health.health / 100, transform.localScale.y * Health.health / 100, transform.localScale.z);
    }

    void Die()
    {
        //Application.LoadLevel(Application.loadedLevel);
    }
}