using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraLock : MonoBehaviour
{
    public GameObject Player;
    public float smoothVal;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        follow();
    }

    void follow()
    {
        Vector3 offset = new Vector3(this.Player.transform.position.x, this.Player.transform.position.y, -5);
        Vector3 smooth = Vector3.Lerp(transform.position, offset, smoothVal * Time.fixedDeltaTime);
        transform.position = smooth;
    }
}
