using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;

public class RANdRot : MonoBehaviour
{
    // Start is called before the first frame update
    public float R = 0f;
    public Vector3 anglesToRotate;
    void Start()
    {
        R = Random.Range(1, 20);
        this.transform.Rotate(anglesToRotate * R);
    }

    // Update is called once per frame
    void Update()
    {

    }
}
