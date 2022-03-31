using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    public float scrollSpeed;
    public Transform player;
  
    public float topBarrier;
    public float botBarrier;
    public float leftBarrier;
    public float rightBarrier;


    void Update()
    {

        if (Input.mousePosition.y >= Screen.height * topBarrier)
        {
            transform.Translate(Vector3.forward * Time.deltaTime * scrollSpeed, Space.World);
        
        }

        if (Input.mousePosition.y <= Screen.height * botBarrier)
        {
            transform.Translate(Vector3.back * Time.deltaTime * scrollSpeed, Space.World);
        }

        if (Input.mousePosition.x >= Screen.width * rightBarrier)
        {
            transform.Translate(Vector3.right * Time.deltaTime * scrollSpeed, Space.World);
        }

        if (Input.mousePosition.x <= Screen.width * leftBarrier)
        {
            transform.Translate(Vector3.left * Time.deltaTime * scrollSpeed, Space.World);
        }
        if (Input.GetKey(KeyCode.Space))
        {
            gameObject.transform.position = new Vector3(player.transform.position.x, 5, player.transform.position.z - 1.5f);           
        }

    }
}




