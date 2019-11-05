using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; //Make sure to add this for access to the SceneManagment class.


public class collisionTester : MonoBehaviour
{
    public GameObject spikes;
    public GameObject spike;
    public GameObject trap;
    public GameObject spikeTrap;
    public GameObject win;
    public GameObject win2;
    public GameObject finalWin;



    //Any Collider2D component will call this function on
    //any attached scripts when the collider enters a collision with another collider.
    //The gameobject must also have a RigidBody2D attached.
    private void OnCollisionEnter2D(Collision2D collision)
    {



        if (collision.collider.gameObject == spikes)
        {
            SceneManager.LoadScene(0);
        }
        if (collision.collider.gameObject == spike)
        {
            SceneManager.LoadScene(0);
        }

        if (collision.collider.gameObject == trap)
        {
            GameObject newBall = Instantiate(spikeTrap, new Vector3(4, 10, 0f), Quaternion.Euler(new Vector3(0,0,180f)));
          
        }
        if (collision.collider.GetComponent <spikeScript> ())
        {
            SceneManager.LoadScene(0);
        }


        if (collision.collider.gameObject == win)
        {
            SceneManager.LoadScene(1);
        }


        if (collision.collider.gameObject == win2)
        {
            SceneManager.LoadScene(2);
        }
        if (collision.collider.gameObject == finalWin)
        {
            SceneManager.LoadScene(3);
        }
    }


}


