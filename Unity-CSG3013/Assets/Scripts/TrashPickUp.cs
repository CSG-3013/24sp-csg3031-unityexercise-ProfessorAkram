using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrashPickUp : MonoBehaviour
{

    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("TrashBag"))
        {
            Debug.Log("hit trash");
            Destroy(other.gameObject);
        }
    }
}
