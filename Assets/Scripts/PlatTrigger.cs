using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatTrigger : MonoBehaviour
{

    [SerializeField]
    GameObject platform;

    private void OnTriggerEnter(Collider other)
    {
        platform.transform.position += new Vector3(4, 0, 0);
    }


}