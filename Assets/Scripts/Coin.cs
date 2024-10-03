using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    public AudioSource moneda;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            Debug.Log("Ganaste una coin");
            moneda.PlayOneShot(moneda.clip);
            Destroy(this.gameObject);
        }
    }
}
