using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BracketL1Controller : MonoBehaviour
{

    private int playerTeamIndex;
    private int oppTeamIndex;


    // Start is called before the first frame update
    void Start()
    {
        SetL1Opponent();

        Invoke("Transition", 5.0f);

    }

    private void Transition()
    {
        SceneManager.LoadScene("L1Showcase");
    }

    private void SetL1Opponent()
    {
        playerTeamIndex = PlayerPrefs.GetInt("CareerTeamSelected");
        int veteransMemorial = 0;
        int sinton = 1;
        int ray = 2;
        int johnPaul = 3;
        int london = 4;
        int carroll = 5;
        int flourBluff = 6;
        int gp = 7;
        int acJones = 8;
        int king = 9;
        int hmKing = 10;
        int miller = 11;
        int moody = 12;
        int portA = 13;
        int tuloso = 14;
        int kaufer = 15;
        int vicEast = 16;
        int vicWest = 17;
        int calallen = 18;
        int collegiate = 19;
        int academy = 20;
        int bank = 21;
        int rockport = 22;
        int ingleside = 23;
        switch(playerTeamIndex)
        {
            case 0:
                PlayerPrefs.SetInt("OpponentL1Index", johnPaul);
                break;
            case 1:
                PlayerPrefs.SetInt("OpponentL1Index", academy);
                break;
            case 2:
                PlayerPrefs.SetInt("OpponentL1Index", vicWest);
                break;
            case 3:
                PlayerPrefs.SetInt("OpponentL1Index", veteransMemorial);
                break;
            case 4:
                PlayerPrefs.SetInt("OpponentL1Index", bank);
                break;
            case 5:
                PlayerPrefs.SetInt("OpponentL1Index", vicEast);
                break;
            case 6:
                PlayerPrefs.SetInt("OpponentL1Index", gp);
                break;
            case 7:
                PlayerPrefs.SetInt("OpponentL1Index", flourBluff);
                break;
            case 8:
                PlayerPrefs.SetInt("OpponentL1Index", calallen);
                break;
            case 9:
                PlayerPrefs.SetInt("OpponentL1Index", tuloso);
                break;
            case 10:
                PlayerPrefs.SetInt("OpponentL1Index", collegiate);
                break;
            case 11:
                PlayerPrefs.SetInt("OpponentL1Index", moody);
                break;
            case 12:
                PlayerPrefs.SetInt("OpponentL1Index", miller);
                break;
            case 13:
                PlayerPrefs.SetInt("OpponentL1Index", rockport);
                break;
            case 14:
                PlayerPrefs.SetInt("OpponentL1Index", king);
                break;
            case 15:
                PlayerPrefs.SetInt("OpponentL1Index", ingleside);
                break;
            case 16:
                PlayerPrefs.SetInt("OpponentL1Index", carroll);
                break;
            case 17:
                PlayerPrefs.SetInt("OpponentL1Index", ray);
                break;
            case 18:
                PlayerPrefs.SetInt("OpponentL1Index", acJones);
                break;
            case 19:
                PlayerPrefs.SetInt("OpponentL1Index", hmKing);
                break;
            case 20:
                PlayerPrefs.SetInt("OpponentL1Index", sinton);
                break;
            case 21:
                PlayerPrefs.SetInt("OpponentL1Index", london);
                break;
            case 22:
                PlayerPrefs.SetInt("OpponentL1Index", portA);
                break;
            case 23:
                PlayerPrefs.SetInt("OpponentL1Index", kaufer);
                break;
            default:
                Debug.Log("Error during setting opponent L1 Index.");
                break;
        }
    }

}
