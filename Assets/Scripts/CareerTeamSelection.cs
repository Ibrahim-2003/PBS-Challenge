using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using TMPro;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class CareerTeamSelection : MonoBehaviour
{
    private int selectedTeamIndex;
    private Color desiredColor;

    [Header("List of Teams")]
    [SerializeField] private List<TeamSelectObject> teamList = new List<TeamSelectObject>();

    [Header("UI References")]
    [SerializeField] public TextMeshProUGUI teamName;
    [SerializeField] private Image teamLogo;
    [SerializeField] private Image backgroundColor;

    [Header("Sounds")]
    [SerializeField] private AudioClip buttonClick;
    [SerializeField] private AudioClip characterSelect;

    [Header("Tweaks")]
    [SerializeField] private float backgroundColorTransitionSpeed = 10.0f;

    [Header("Bracket")]
    [SerializeField] private GameObject bracketBackground;
    [SerializeField] private GameObject image;
    [SerializeField] private GameObject image1;
    [SerializeField] private GameObject image2;
    [SerializeField] private GameObject image3;
    [SerializeField] private GameObject image4;
    [SerializeField] private GameObject image5;
    [SerializeField] private GameObject image6;
    [SerializeField] private GameObject image7;
    [SerializeField] private GameObject image8;
    [SerializeField] private GameObject image9;
    [SerializeField] private GameObject image10;
    [SerializeField] private GameObject image11;
    [SerializeField] private GameObject image12;
    [SerializeField] private GameObject image13;
    [SerializeField] private GameObject image14;
    [SerializeField] private GameObject image15;
    [SerializeField] private GameObject image16;
    [SerializeField] private GameObject image17;
    [SerializeField] private GameObject image18;
    [SerializeField] private GameObject image19;
    [SerializeField] private GameObject image20;
    [SerializeField] private GameObject image21;
    [SerializeField] private GameObject image22;
    [SerializeField] private GameObject image23;
    
    private void Start()
    {
        deActivate();
        UpdateTeamSelectionUI();
        AudioManager.Instance.PlayMusic(characterSelect);
        
    }
    private void Update()
    {
        backgroundColor.color = Color.Lerp(backgroundColor.color, desiredColor, Time.deltaTime * backgroundColorTransitionSpeed);
    }

    private void deActivate()
    {
        bracketBackground.SetActive(false);
        image.SetActive(false);
        image1.SetActive(false);
        image2.SetActive(false);
        image3.SetActive(false);
        image4.SetActive(false);
        image5.SetActive(false);
        image6.SetActive(false);
        image7.SetActive(false);
        image8.SetActive(false);
        image9.SetActive(false);
        image10.SetActive(false);
        image11.SetActive(false);
        image12.SetActive(false);
        image13.SetActive(false);
        image14.SetActive(false);
        image15.SetActive(false);
        image16.SetActive(false);
        image17.SetActive(false);
        image18.SetActive(false);
        image19.SetActive(false);
        image20.SetActive(false);
        image21.SetActive(false);
        image22.SetActive(false);
        image23.SetActive(false);
    }

    private void Activate()
    {
        bracketBackground.SetActive(true);
        image.SetActive(true);
        image1.SetActive(true);
        image2.SetActive(true);
        image3.SetActive(true);
        image4.SetActive(true);
        image5.SetActive(true);
        image6.SetActive(true);
        image7.SetActive(true);
        image8.SetActive(true);
        image9.SetActive(true);
        image10.SetActive(true);
        image11.SetActive(true);
        image12.SetActive(true);
        image13.SetActive(true);
        image14.SetActive(true);
        image15.SetActive(true);
        image16.SetActive(true);
        image17.SetActive(true);
        image18.SetActive(true);
        image19.SetActive(true);
        image20.SetActive(true);
        image21.SetActive(true);
        image22.SetActive(true);
        image23.SetActive(true);
    }

    public void LeftArrow()
    {
        selectedTeamIndex--;
        if (selectedTeamIndex < 0)
        selectedTeamIndex = teamList.Count - 1;

        UpdateTeamSelectionUI();
        AudioManager.Instance.PlaySFX(buttonClick);
    }

    public void RightArrow()
    {
        selectedTeamIndex++;
        if (selectedTeamIndex == teamList.Count)
        selectedTeamIndex = 0;

        UpdateTeamSelectionUI();
        AudioManager.Instance.PlaySFX(buttonClick);
    }

    public void Confirm()
    {
        PlayerPrefs.SetString("CareerTeamName", teamList[selectedTeamIndex].teamName);
        PlayerPrefs.SetInt("CareerTeamSelected", selectedTeamIndex);
        SetL1Opponent();
        Activate();
        Invoke("Continue", 5.0f);
        AudioManager.Instance.StopMusic(characterSelect);
        
        Debug.Log(string.Format("Team {0}:{1} has been chosen", selectedTeamIndex, teamList[selectedTeamIndex].teamName));
    }

    private void Continue()
    {
        SceneManager.LoadScene("L1Showcase");
    }

    private void UpdateTeamSelectionUI()
    {
        // Logo, Name, Color
        teamLogo.sprite = teamList[selectedTeamIndex].teamLogo;
        teamName.text = teamList[selectedTeamIndex].teamName;
        desiredColor = teamList[selectedTeamIndex].teamColor;
        backgroundColor.color = teamList[selectedTeamIndex].teamColor;
    }

    [System.Serializable]
    public class TeamSelectObject
    {
        public Sprite teamLogo;
        public string teamName;
        public Color teamColor;
    }




    

    private void SetL1Opponent()
    {
        int playerTeamIndex = PlayerPrefs.GetInt("CareerTeamSelected");
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
