using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    protected float jump_speed = 12.0f;
    public bool is_landing = false;
    private void Start()
    {
        is_landing = false;
    }
    // Update is called once per frame
    void Update()
    {
        if(is_landing)
        {
            if (Input.GetMouseButtonDown(0))
            {
                is_landing = false;
                GetComponent<Rigidbody>().velocity =
                    Vector3.up * this.jump_speed;
                //Debug.Break();
            }
        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag=="Floor")
        {
            is_landing = true;
        }
        
    }
}
