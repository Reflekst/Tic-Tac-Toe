using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurnChange : GameMenager
{
    SpriteRenderer spriteRenderer;
    GameObject GameBoard;
    public Sprite[] images;
    bool unplay = true;    
    int index;

    private void OnMouseDown()
    {
        if(unplay)
        {
            index = GameBoard.GetComponent<GameMenager>().PlayerTurn();
            if (index == 1)
            {
                Krzyzyk.SetActive(true);
                Kolo.SetActive(false);
            }
            else
            {
                Krzyzyk.SetActive(false);
                Kolo.SetActive(true);
            }
            spriteRenderer.sprite = images[index];
            //Debug.Log(index);
            GameBoard.GetComponent<GameMenager>().SaveMove(gameObject.name, index);
            unplay = false;
        }
        if (isBot)
        {
            BotMove(index);
        }
    }
    private void Awake()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        GameBoard = GameObject.Find("GameBoard");
    }
    void Start()
    {
        spriteRenderer.sprite = null;
    }

    
  }
