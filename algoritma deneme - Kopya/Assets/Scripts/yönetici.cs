using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class yönetici : MonoBehaviour
{
    public TextMeshProUGUI scoretext, moneytext, kalanzamantext;
    public int score, money;
    public float cekimhızı;
    public float kalanzaman = 10f;
    public static yönetici Instance;
    public delegate void OyunBittiDel();

    public event OyunBittiDel oyunubitir;

    private void Awake()
    {
        
        Instance = this;
        
        cekimhızı = 5;
    }

    public virtual void cekmehızı()
    {
        cekimhızı+= 1;
        
    }

    public void oyunubitircagır()
    {
        oyunubitir();
    }
    public int Score
    {
        get
        {
            return score;
        }
        set
        {
            score += value;
            Money = value;
            scoretext.text = score.ToString();
            if (score <= 0)
            {
                
                //Time.timeScale = 0f;
            }
        }
    }

    public int Money
    {
        get
        {
            return money;
        }
        set
        {
            money += value;
            moneytext.text = money.ToString();
        }
        
    }
    
    private void Update()
    {
        kalanzaman -= Time.deltaTime;
        kalanzamantext.text = kalanzaman.ToString();
        //scoretext.text = score.ToString();
        // moneytext.text = money.ToString();
        //int a = Int32.Parse(scoretext.text);
    }
}

interface IInterface
{
    public void deneme();
}

