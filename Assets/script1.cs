using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class script0 : MonoBehaviour
{
    public Rigidbody2D myRigidbody;
    public float fartStrength;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {if(Input.GetKeyDown(KeyCode.Space)==true)
        myRigidbody.velocity = Vector2.up * fartStrength;
        if (Input.GetKeyDown(KeyCode.LeftArrow) == true)
            myRigidbody.velocity = Vector2.left * 3;
        if (Input.GetKeyDown(KeyCode.RightArrow) == true)
            myRigidbody.velocity = Vector2.right * 3;
        if (Input.GetKeyDown(KeyCode.DownArrow) == true)
            myRigidbody.velocity = Vector2.down * 3;







    }
    
}
