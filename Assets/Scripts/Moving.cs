using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Moving : MonoBehaviour
{

    [SerializeField] private LayerMask PlatformsLayerMask;
    public float speed;
    public float jumpSpeed;
    private bool onGround;
    public Rigidbody2D rigidbody2d;
    private BoxCollider2D boxCollider2d;
    // Start is called before the first frame update
    void Start()
    {
        speed = .3f;
   
        rigidbody2d = transform.GetComponent<Rigidbody2D>();
        boxCollider2d = transform.GetComponent<BoxCollider2D>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 movePosition = new Vector2(transform.position.x, transform.position.y);
        transform.position = movePosition;


      if (Input.GetKey(KeyCode.D))
        {
            transform.position = new Vector2(movePosition.x + speed, movePosition.y);
        }

        if (Input.GetKey(KeyCode.A))
        {
            transform.position = new Vector2(movePosition.x - speed, movePosition.y);
        }



        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (onGround)
            {
                rigidbody2d.AddForce(new Vector2(0f, jumpSpeed), ForceMode2D.Impulse);
                onGround = false;
            }
        }

    }

    private void OnCollisionStay2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Ground")
        {
            if (collision.transform.position.y < transform.position.y)
            {
                onGround = true;
            }
        }
    }


}
