using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class menuyonet : MonoBehaviour
{
    
    void Start()
    {
        menu.Instance.playbut.gameObject.GetComponent<Button>();
        menu.Instance.exitbut.gameObject.GetComponent<Button>();
        menu.Instance.playbut.onClick.AddListener(playbutton);
        menu.Instance.exitbut.onClick.AddListener(cıkısbutton);
    }

    public void playbutton()
    {
        SceneManager.LoadScene(1);
    }

    public void cıkısbutton()
    {
        Application.Quit();
    }
}
