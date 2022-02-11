using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoneyScript : MonoBehaviour
{
    public GameObject UI;
    private void OnTriggerEnter(Collider collidedObject)
    {
        if (collidedObject.tag == "Player")
        {
            UI.GetComponent<MoneyController>().IncrementScore();
            Destroy(this.gameObject);
            
        }
    }
}
