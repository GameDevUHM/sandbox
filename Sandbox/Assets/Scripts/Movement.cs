using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public Vector2 speed = new Vector2(10, 10);
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        /*get input of x and y*/
        float x = Input.GetAxis("Horizontal");
        float y = Input.GetAxis("Vertical");

        /* set movement values*/
        Vector3 movement = new Vector3(speed.x * x, speed.y * y);

        /*update movement and move attached object*/
        movement *= Time.deltaTime;
        transform.Translate(movement);
    }
}
