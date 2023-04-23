using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class sahne2yegec : MonoBehaviour
{
    public static sahne2yegec Instance;
    void Start()
    {
        yönetici.Instance.oyunubitir += oyunudurdur;
        yönetici.Instance.oyunubitir += muzikdurdur;
        Instance = this;
    }

    
    void Update()
    {
        if (yönetici.Instance.kalanzaman <= 0)
        {
            Debug.Log("singleton çalıştı");
            //SceneManager.LoadScene(2);
            yönetici.Instance.oyunubitircagır();
        }  
    }
 
    public void oyunudurdur()
    {
        Time.timeScale = 0;
    }

    public void muzikdurdur()
    {
        singleton.instance.sesler.Stop();
    }
    
}
