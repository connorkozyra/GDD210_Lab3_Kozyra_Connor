using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EnemyControl : MonoBehaviour
{
    public GameObject player;// player to track

    public Vector3 playerLocation;// where is that player (notuseful)

    //public float randomSpeed = Random.Range(0.2f, 1f);

    public float speed = 0.5f;// how fast should i follow that player

    public float acceleration = 0.01f;

    public GameObject whoHitMe;
    // Start is called before the first frame update
    void Start()
    {
        //speed = Random.Range(0.5f, 1f);
    }

    // Update is called once per frame
    void Update()
    {


        //speed = speed + acceleration;
        playerLocation = player.transform.position;//updating the player location 
        transform.LookAt(player.transform);// looks at player --- faces Z at player
        //Debug.Log(randomSpeed);
        transform.Translate(0f, 0f, speed * Time.deltaTime);// moving (1 Z unit per frame) towards the player

    }

    private void OnTriggerEnter(Collider other) // when as trigger is CHECKED
    {
        Debug.Log("ouch");
        CollidedWithPlayer();
    }

    /*void OnCollisionEnter(Collision collision)
    {
        whoHitMe = collision.gameObject;

        if(whoHitMe == player)
        {
            CollidedWithPlayer();
        }

    }*/

    void CollidedWithPlayer()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
