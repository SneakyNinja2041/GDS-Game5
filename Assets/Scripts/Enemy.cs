using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Enemy : MonoBehaviour
{
    // enemy movement
    public Transform target;
    public float speed = 2f;
    public Rigidbody rb;


    void Update()
    {

    }

    public void FollowPlayer()
    {
        Vector3 pos = Vector3.MoveTowards(transform.position, target.position, speed * Time.deltaTime);

        rb.MovePosition(pos);
        //transform.LookAt(target);
    }

    void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            FollowPlayer();
        }
        
    }
    


}
