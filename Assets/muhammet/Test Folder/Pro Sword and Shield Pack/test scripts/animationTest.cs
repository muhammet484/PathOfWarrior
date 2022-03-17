using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class animationTest : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
    }
    // Update is called once per frame
    void Update()
    {
        //transform.position += Vector3.right * Time.deltaTime;
        transform.eulerAngles -= Vector3.forward/2;
    }
}
