using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletLauch : MonoBehaviour
{
    public GameObject bulletPrefab;

    public Transform space;
    public Vector3 offset;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(bulletPrefab, space.position + offset, space.rotation);
        }
    }
}