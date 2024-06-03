using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using TMPro;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class OppTeamSelection : MonoBehaviour
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
    
    private void Start()
    {
        UpdateTeamSelectionUI();
        AudioManager.Instance.PlayMusic(characterSelect);
        
    }
    private void Update()
    {
        backgroundColor.color = Color.Lerp(backgroundColor.color, desiredColor, Time.deltaTime * backgroundColorTransitionSpeed);
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
        PlayerPrefs.SetString("OppTeamName", teamList[selectedTeamIndex].teamName);
        PlayerPrefs.SetInt("OppTeamSelected", selectedTeamIndex);
        AudioManager.Instance.StopMusic(characterSelect);
        SceneManager.LoadScene("ExhibitionShowcase");
        Debug.Log(string.Format("Team {0}:{1} has been chosen", selectedTeamIndex, teamList[selectedTeamIndex].teamName));
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
}
