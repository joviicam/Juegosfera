using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KillZone : MonoBehaviour
{
    public AudioSource moneda;
    public GameObject spawn;
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            moneda.PlayOneShot(moneda.clip);
            collision.gameObject.transform.position = spawn.transform.position;
            collision.gameObject.GetComponent<Rigidbody>().velocity = Vector3.zero;

            Debug.Log("Entro al jugador, se reiniciara la posicion");
        }

    }
}