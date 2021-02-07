using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Follow : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject x;
    public GameObject y;
    private Transform z;
    private Transform i;


    void Start()
    {
        z = x.GetComponent<Transform>();
        i = y.GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        z.position = i.position;
    }
}
