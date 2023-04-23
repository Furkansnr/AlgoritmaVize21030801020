using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : yönetici, IInterface
{
    public float rotationSpeed, arrowSpeed, pullSpeed;
    public GameObject arrowPrefab;
    public int Money;
    public Animator animator;
    public static player Instance; //kullanarakda bunu yapabilirdik (inherit)
    
    void Awake()
    {
        Instance = this;
        animator = GetComponent<Animator>();
    }

    public override void cekmehızı()
    {
        base.cekmehızı();
        rotationSpeed += 1;
        Debug.Log("override girildi");
    }

    void Update()
    {
      transform.Rotate(Vector3.forward * Time.deltaTime * rotationSpeed);  
      
      if (Input.GetKeyDown(KeyCode.Return))
      {
          // Okun yönü hesaplanır
          Vector3 arrowDirection = transform.right;
          float arrowAngle = Mathf.Atan2(arrowDirection.y, arrowDirection.x) * Mathf.Rad2Deg;
          Quaternion arrowRotation = Quaternion.AngleAxis(arrowAngle, Vector3.forward);

          // Ok GameObject'i oluşturulur
          GameObject arrow = Instantiate(arrowPrefab, transform.position, arrowRotation);

          // Ok'a hareket verilir
          Rigidbody2D arrowRb = arrow.GetComponent<Rigidbody2D>();
          arrowRb.AddForce(arrowDirection * arrowSpeed, ForceMode2D.Impulse);
      }

    }

    public void deneme()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.CompareTag("Cekbunu"))
        {
            Destroy(col.gameObject);
            Score = 1;
            cekmehızı();
            animator.SetTrigger("degıs");
        }
        
       else if (col.gameObject.CompareTag("cekme"))
        { 
            Destroy(col.gameObject);  
        }
        
        if (col.gameObject.CompareTag("cekmebunu"))
        {
            Destroy(col.gameObject);
            Score = -1;
            cekmehızı();
        }
        
    }
}
