using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cekme : MonoBehaviour
{
    public float pullSpeed;
    private BoxCollider2D box;
    private Transform player;
    private player player1;

    private void Start()
    {
        player1 = GameObject.FindWithTag("Player").GetComponent<player>();
       pullSpeed = player1.cekimhızı;
       Debug.Log(player1.cekimhızı);
        player = GameObject.FindWithTag("Player").GetComponent<Transform>();
        box = gameObject.GetComponent<BoxCollider2D>();
        box.enabled = false;
        StartCoroutine(baslangıc());
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Cekbunu"))
        {
            other.GetComponent<Rigidbody2D>().velocity = (player.transform.position - transform.position ).normalized * pullSpeed;
            transform.SetParent(other.transform);
            GetComponent<Rigidbody2D>().isKinematic = true;
            
        }

        if (other.CompareTag("cekmebunu"))
        {
            other.GetComponent<Rigidbody2D>().velocity = (player.transform.position - transform.position ).normalized * pullSpeed;
            transform.SetParent(other.transform);
            GetComponent<Rigidbody2D>().isKinematic = true; 
        }
    }

    IEnumerator baslangıc()
    {
        yield return new WaitForSeconds(0.3f);
        box.enabled = true;
    }
}
