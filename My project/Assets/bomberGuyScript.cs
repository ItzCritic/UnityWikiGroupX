using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class bomberGuyScript : MonoBehaviour


{ 
    public GameObject bombCloneTemplate;
    private float rotSpeed = 360;
    private float currentSpeed = 3;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {         
        
        if (Input.GetKeyDown(KeyCode.A))
            transform.Rotate(Vector3.up, rotSpeed * Time.deltaTime);
        if (Input.GetKeyDown(KeyCode.D))
            transform.Rotate(Vector3.up, -rotSpeed * Time.deltaTime);
        if (Input.GetKeyDown(KeyCode.W))
            transform.position += currentSpeed * transform.forward * Time.deltaTime;
        if (Input.GetKeyDown(KeyCode.B))
            Instantiate(bombCloneTemplate, transform.position, transform.rotation);
    }
}
