using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickupScript : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("PickUp"))
        {
            other.gameObject.SetActive(false);

            StartCoroutine(respawnTime(10));
        }


        IEnumerator respawnTime(float waitTime)
        {
            yield return new WaitForSeconds(waitTime);
            other.gameObject.SetActive(true);
        }
    }

}

