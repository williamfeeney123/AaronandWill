using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Moving : MonoBehaviour
{

    [SerializeField] private LayerMask PlatformsLayerMask;
    public float speed;

    private Rigidbody2D rigidbody2d;
    private BoxCollider2D boxCollider2d;
    // Start is called before the first frame update
    void Start()
    {
        speed = 0.03f;
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


        if (IsGrounded() && Input.GetKeyDown(KeyCode.Space))
        {
            float jumpVelocity = 10f;
            rigidbody2d.velocity = Vector2.up * jumpVelocity;
        }


    }
    private bool  IsGrounded()
    {
        RaycastHit2D raycastHit2d = Physics2D.BoxCast(boxCollider2d.bounds.center, boxCollider2d.bounds.size, 0f, Vector2.down * .1f, PlatformsLayerMask);
    
        return raycastHit2d.collider != null;
        }

}
