using UnityEngine;
using System.Collections;

public class gravityScript : MonoBehaviour
{
    float gravity = 0f;
    // Update is called once per frame
    void Update()
    {
          gravity = Input.GetAxis("Vertical");
    }  
    void FixedUpdate()
    {
        Vector2 speed = new Vector2(1, 1);
        GetComponent<Rigidbody2D>().velocity = speed;   
    }
 } 