using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovementController : MonoBehaviour
{
    public float horizontalmodifier = 1.0f;
    public float verticalmodifier = 1.0f;
    public bool isInAir = false; 

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        MoveHorizontal();
    }


    void MoveHorizontal() {
        Vector3 horizontal = new Vector3((horizontalmodifier * Input.GetAxis("Horizontal")), 0.0f, 0.0f);
        transform.position = transform.position + horizontal * Time.deltaTime;
    }

    void MoveVertical() {
       

            
    }
}
