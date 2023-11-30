using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeMoving : MonoBehaviour
{

    Vector3 velocity, acceletarion;
    float rateOfRotation = 180f;
    // Start is called before the first frame update
    void Start()
    {

    }




    // Update is called once per frame
    void Update()
    {
        acceletarion = Vector3.zero;


        if (Input.GetKey(KeyCode.W))
        { acceletarion = transform.forward; };

        if (Input.GetKey(KeyCode.S))
        { acceletarion = -transform.forward; };

        if (Input.GetKey(KeyCode.D))
        { transform.Rotate(Vector3.up, rateOfRotation * Time.deltaTime); };

        if (Input.GetKey(KeyCode.A))
        { transform.Rotate(Vector3.down, rateOfRotation * Time.deltaTime); };

        if (Input.GetKey(KeyCode.DownArrow))
        { transform.Rotate(Vector3.right, rateOfRotation * Time.deltaTime); };

        if (Input.GetKey(KeyCode.UpArrow))
        { transform.Rotate(Vector3.left, rateOfRotation * Time.deltaTime); };

        velocity += acceletarion * Time.deltaTime;

        // s          =       u               *       t 
        transform.position += velocity * Time.deltaTime;
    }
}
