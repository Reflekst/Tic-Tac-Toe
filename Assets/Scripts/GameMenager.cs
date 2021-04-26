using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Net.Sockets;
using UnityEngine.SceneManagement;
using System.Text;
using System;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using Random = UnityEngine.Random;

public class GameMenager : ChangeScene
{

    
    int[] xFields = new int[5];
    int[] oFields = new int[5];
    int xiter = 0;
    int oiter = 0;
   

    public int PlayerTurn()
    {
        spriteIndex++;
        return spriteIndex % 2;
    }
    public void BotMove(int index)
    {
    }

    public void SaveMove(string FieldIndex, int turn)
    {
        if (turn == 0)
        {

            Debug.Log(xFields[xiter++] = int.Parse(FieldIndex));
            CheckForWin(xFields, turn);

        }
        else
        {
            oFields[oiter++] = int.Parse(FieldIndex);
            CheckForWin(oFields, turn);
        }
    }
    public void CheckForWin(int[] tab, int turn)
    {

        if (
               tab.Contains(1) && tab.Contains(2) && tab.Contains(3)
            || tab.Contains(1) && tab.Contains(5) && tab.Contains(9)
            || tab.Contains(1) && tab.Contains(4) && tab.Contains(7)
            || tab.Contains(2) && tab.Contains(5) && tab.Contains(8)
            || tab.Contains(3) && tab.Contains(6) && tab.Contains(9)
            || tab.Contains(3) && tab.Contains(5) && tab.Contains(7)
            || tab.Contains(4) && tab.Contains(5) && tab.Contains(6)
            || tab.Contains(7) && tab.Contains(8) && tab.Contains(9)
            )
        {
            if (turn == 0)
            {
                Refresh.SetActive(true);
                xText.SetActive(true);

            }
            else
            {
                Refresh.SetActive(true);
                oText.SetActive(true);

            }
        }       
    }
}
