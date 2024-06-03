using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class L1Intro : MonoBehaviour
{

    [Header("List of Teams")]
    [SerializeField] private List<TeamSelectObject> teamList = new List<TeamSelectObject>();

    [Header("UI References")]
    [SerializeField] public TextMeshProUGUI oppTeamName;
    [SerializeField] public TextMeshProUGUI playerTeamName;
    [SerializeField] private Image oppTeamLogo;
    [SerializeField] private Image playerTeamLogo;

    [Header("Sounds")]
    [SerializeField] private AudioClip introSound;
    [SerializeField] private AudioClip playerTeamSound;
    [SerializeField] private AudioClip oppTeamSound;

    [System.Serializable]
    public class TeamSelectObject
    {
        public Sprite TeamSprite;
        public string TeamName;
    }


    
    void Start()
    {
        AudioManager.Instance.PlayMusic(introSound);

        playerTeamLogo.sprite = teamList[PlayerPrefs.GetInt("CareerTeamSelected")].TeamSprite;
        playerTeamName.text = teamList[PlayerPrefs.GetInt("CareerTeamSelected")].TeamName;

        oppTeamLogo.sprite = teamList[PlayerPrefs.GetInt("OpponentL1Index")].TeamSprite;
        oppTeamName.text = teamList[PlayerPrefs.GetInt("OpponentL1Index")].TeamName;

        Invoke("Transition", 5.1f);
    }

    private void Transition()
    {
        AudioManager.Instance.StopMusic(introSound);
        //Add exceptions for the London and GP brackets to skip straight to Bracket L3
        SceneManager.LoadScene("BracketL1");
        
    }

}
