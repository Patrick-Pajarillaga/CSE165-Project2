using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementController : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject player;
    public GameObject camera;
    private Rigidbody prb;
    private Transform pT;
    private Transform cT;
    public float movementSpeed = 0.0001f;
    private bool mouseClicked = false;
    private Vector3 mousePos;

    void Start()
    {
        prb = player.GetComponent<Rigidbody>();
        pT = player.GetComponent<Transform>();
        cT = camera.GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
      if (Input.GetMouseButton(0) && mouseClicked == false) {
            mouseClicked = true;
            mousePos = Input.mousePosition;
            
        }
        else if (Input.GetMouseButton(0) && mouseClicked == true) {
            Vector3 diff = Input.mousePosition - mousePos;
            //pT.position += pT.forward * Time.deltaTime * diff.y;
            prb.velocity = (cT.forward * diff.y);
            //prb.AddForce( (cT.forward * diff.y) * 0.001f, ForceMode.VelocityChange);
            //prb.MovePosition(cT.position + (cT.forward * Time.deltaTime * diff.y));
            //Debug.Log("Mouse is Down");
            float rotation = Input.GetAxis("Horizontal") * 100.0f;
            //rotation *= Time.deltaTime;
            //transform.Rotate(0, rotation, 0);
            Vector3 angle = new Vector3(0, rotation, 0);
            prb.MoveRotation(prb.rotation * Quaternion.Euler(angle * Time.deltaTime));
        }
        else {
            //prb.velocity = new Vector3(0,0,0);
            //Debug.Log("Mouse is not Down");
            mouseClicked = false;
            prb.velocity = new Vector3(0,0,0);
        }


    }

    void FixedUpdate() {
        
    }
}
