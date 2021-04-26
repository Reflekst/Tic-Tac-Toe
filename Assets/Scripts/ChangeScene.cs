using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour
{
    public bool isBot = false;
    public int spriteIndex = -1;
    public GameObject Krzyzyk;
    public GameObject Kolo;
    public GameObject xText;
    public GameObject oText;
    public GameObject Refresh;
    public GameObject Sprite1;
    public GameObject Sprite2;
    public GameObject Sprite3;
    public GameObject Sprite4;
    public GameObject Sprite5;
    public GameObject Sprite6;
    public GameObject Sprite7;
    public GameObject Sprite8;
    public GameObject Sprite9;

    public void StartGameDefault()
    {
        SceneManager.LoadScene("MainScene");
    }
    public void StartGameBot()
    {
        SceneManager.LoadScene("MainScene");
        isBot = true;
    }
    private void OnMouseDown()
    {
        if (gameObject.name == "refresh")
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
        else if (gameObject.name == "exit")
        {
            SceneManager.LoadScene("Menu");
        }
        else if (gameObject.name == "Krzyzyk")
        {
            Kolo.SetActive(false);
        }
        else if (gameObject.name == "Kolo")
        {
            Krzyzyk.SetActive(false);
            spriteIndex = 0;
        }
    }
    
}
