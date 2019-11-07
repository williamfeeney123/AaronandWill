using UnityEngine;

public class BoxController : MonoBehaviour
{
    public float SceneLength = 40f;

    private float speed = 0.5f;

    public float gravity;

    void Update()
    {
        //Draw a ling to show how wide our scene is.
        Debug.DrawLine(new Vector2(0f, SceneLength), new Vector2(0f, SceneLength));

        //Create a new Vector2 and set it to where the box should move.
        // 'transform' refers the transform component of the gameobject this script is attached to (Box).

        Vector2 newPosition = new Vector2(transform.position.x, transform.position.y + speed);
        
        //Check if the box is outside the scene.
        if (newPosition.y >= SceneLength)
        {
            speed = -0.5f; //Move left.
            newPosition = new Vector2(transform.position.x, -10f);
        }
        else if (newPosition.y <= SceneLength)
        {
            speed = 0.5f; //Move right.
            

        }

        //Set the transforms position variable to equal our Vector2.

        transform.position = newPosition;
    }
}
