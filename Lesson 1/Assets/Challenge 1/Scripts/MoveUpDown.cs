using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveUpDown : MonoBehaviour
{
    private float max;
    private float min;
    private float speed = 12.0f;
    bool up;
    // Start is called before the first frame update
    void Start()
    {
        min = transform.position.y;
        max = transform.position.y + 10.0f;
        up = true;
    }

    // Update is called once per frame
    void Update()
    {
        if(up)
        {
            transform.Translate(Vector3.up * speed * Time.deltaTime);
            if (transform.position.y > max)
                up = false;
        } 
        else
        {
            transform.Translate(Vector3.down * speed * Time.deltaTime);
            if (transform.position.y < min)
                up = true;
        }
            
    }
}
