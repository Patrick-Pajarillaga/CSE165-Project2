using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotationToPoint : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject arrow;
    public GameObject pcw;
    public GameObject player;
    private Transform arrowT;
    private Transform pcwT;
    private Transform playerT;

    void Start()
    {
        arrowT = arrow.GetComponent<Transform>();
        pcwT = pcw.GetComponent<Transform>();
        playerT = player.GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        arrowT.rotation = playerT.rotation;
        arrowT.LookAt(pcwT);
        arrowT.Rotate(new Vector3(90f, 0, 0));
        //arrowT.position = playerT.position + new Vector3(1.081f, 1.1f, 0);
    }
}
