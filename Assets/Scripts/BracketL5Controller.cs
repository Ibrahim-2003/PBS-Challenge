using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class BracketL5Controller : MonoBehaviour
{

    [Header("List of Teams")]
    [SerializeField] private List<TeamSelectObject> teamList = new List<TeamSelectObject>();

    [Header("UI References")]
    //12 Teams: 1 player & 11 opponents
    [SerializeField] private Image opp0Logo;
    [SerializeField] private Image opp1Logo;
    [SerializeField] private Image opp2Logo;
    [SerializeField] private Image opp3Logo;
    [SerializeField] private Image opp4Logo;
    [SerializeField] private Image opp5Logo;
    [SerializeField] private Image opp6Logo;
    [SerializeField] private Image opp7Logo;
    [SerializeField] private Image opp8Logo;
    [SerializeField] private Image opp9Logo;
    [SerializeField] private Image opp10Logo;
    [SerializeField] private Image opp11Logo;

    [SerializeField] private Image play1Logo;
    [SerializeField] private Image play2Logo;
    [SerializeField] private Image play5Logo;
    [SerializeField] private Image play6Logo;

    [SerializeField] private Image semi1Logo;
    [SerializeField] private Image semi2Logo;
    [SerializeField] private Image semi3Logo;
    [SerializeField] private Image semi4Logo;

    [SerializeField] private Image fin1Logo;
    [SerializeField] private Image fin2Logo;

    [System.Serializable]
    public class TeamSelectObject
    {
        public Sprite teamLogo;
    }

    // Start is called before the first frame update
    void Start()
    {
        SetPlayer();
        Invoke("Transition", 5.0f);

    }

    private void Transition()
    {
        SceneManager.LoadScene("L5Showcase");
        
    }

    private void SetPlayer()
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
            //For this, make an animation of an explosion effect behind the image and set the image to the correct team.
            //Make it work for every possible team selection.

            //Template
            //opp0Logo.sprite = teamList[veteransMemorial].teamLogo;
            //opp1Logo.sprite = teamList[ray].teamLogo;
            //opp2Logo.sprite = teamList[miller].teamLogo;
            //opp3Logo.sprite = teamList[tuloso].teamLogo;
            //opp4Logo.sprite = teamList[london].teamLogo;
            //opp5Logo.sprite = teamList[vicEast].teamLogo;
            //opp6Logo.sprite = teamList[collegiate].teamLogo;
            //opp7Logo.sprite = teamList[sinton].teamLogo;
            //opp8Logo.sprite = teamList[kaufer].teamLogo;
            //opp9Logo.sprite = teamList[calallen].teamLogo;
            //opp10Logo.sprite = teamList[portA].teamLogo;
            //opp11Logo.sprite = teamList[gp].teamLogo;
            case 0:
                opp0Logo.sprite = teamList[playerTeamIndex].teamLogo;
                opp1Logo.sprite = teamList[ray].teamLogo;
                opp2Logo.sprite = teamList[miller].teamLogo;
                opp3Logo.sprite = teamList[tuloso].teamLogo;
                opp4Logo.sprite = teamList[london].teamLogo;
                opp5Logo.sprite = teamList[vicEast].teamLogo;
                opp6Logo.sprite = teamList[collegiate].teamLogo;
                opp7Logo.sprite = teamList[sinton].teamLogo;
                opp8Logo.sprite = teamList[kaufer].teamLogo;
                opp9Logo.sprite = teamList[calallen].teamLogo;
                opp10Logo.sprite = teamList[portA].teamLogo;
                opp11Logo.sprite = teamList[gp].teamLogo;

                
                play1Logo.sprite = teamList[playerTeamIndex].teamLogo;
                play2Logo.sprite = teamList[tuloso].teamLogo;
                play5Logo.sprite = teamList[calallen].teamLogo;
                play6Logo.sprite = teamList[gp].teamLogo;

                
                semi1Logo.sprite = teamList[playerTeamIndex].teamLogo;
                semi2Logo.sprite = teamList[london].teamLogo;
                semi3Logo.sprite = teamList[gp].teamLogo;
                semi4Logo.sprite = teamList[sinton].teamLogo;


                
                fin1Logo.sprite = teamList[playerTeamIndex].teamLogo;
                fin2Logo.sprite = teamList[sinton].teamLogo;
                
                break;
            case 1:
                opp0Logo.sprite = teamList[veteransMemorial].teamLogo;
                opp1Logo.sprite = teamList[ray].teamLogo;
                opp2Logo.sprite = teamList[miller].teamLogo;
                opp3Logo.sprite = teamList[tuloso].teamLogo;
                opp4Logo.sprite = teamList[london].teamLogo;
                opp5Logo.sprite = teamList[vicEast].teamLogo;
                opp6Logo.sprite = teamList[collegiate].teamLogo;
                opp7Logo.sprite = teamList[playerTeamIndex].teamLogo;
                opp8Logo.sprite = teamList[kaufer].teamLogo;
                opp9Logo.sprite = teamList[calallen].teamLogo;
                opp10Logo.sprite = teamList[portA].teamLogo;
                opp11Logo.sprite = teamList[gp].teamLogo;

                
                play1Logo.sprite = teamList[veteransMemorial].teamLogo;
                play2Logo.sprite = teamList[tuloso].teamLogo;
                play5Logo.sprite = teamList[calallen].teamLogo;
                play6Logo.sprite = teamList[gp].teamLogo;

                
                semi1Logo.sprite = teamList[veteransMemorial].teamLogo;
                semi2Logo.sprite = teamList[london].teamLogo;
                semi3Logo.sprite = teamList[gp].teamLogo;
                semi4Logo.sprite = teamList[playerTeamIndex].teamLogo;

                
                fin1Logo.sprite = teamList[veteransMemorial].teamLogo;
                fin2Logo.sprite = teamList[playerTeamIndex].teamLogo;


                break;
            case 2:
                opp0Logo.sprite = teamList[veteransMemorial].teamLogo;
                opp1Logo.sprite = teamList[playerTeamIndex].teamLogo;
                opp2Logo.sprite = teamList[miller].teamLogo;
                opp3Logo.sprite = teamList[tuloso].teamLogo;
                opp4Logo.sprite = teamList[london].teamLogo;
                opp5Logo.sprite = teamList[vicEast].teamLogo;
                opp6Logo.sprite = teamList[collegiate].teamLogo;
                opp7Logo.sprite = teamList[sinton].teamLogo;
                opp8Logo.sprite = teamList[kaufer].teamLogo;
                opp9Logo.sprite = teamList[calallen].teamLogo;
                opp10Logo.sprite = teamList[portA].teamLogo;
                opp11Logo.sprite = teamList[gp].teamLogo;

                
                play1Logo.sprite = teamList[playerTeamIndex].teamLogo;
                play2Logo.sprite = teamList[tuloso].teamLogo;
                play5Logo.sprite = teamList[calallen].teamLogo;
                play6Logo.sprite = teamList[gp].teamLogo;

                
                semi1Logo.sprite = teamList[playerTeamIndex].teamLogo;
                semi2Logo.sprite = teamList[london].teamLogo;
                semi3Logo.sprite = teamList[gp].teamLogo;
                semi4Logo.sprite = teamList[sinton].teamLogo;


                
                fin1Logo.sprite = teamList[playerTeamIndex].teamLogo;
                fin2Logo.sprite = teamList[sinton].teamLogo;


                break;
            case 3:
                opp0Logo.sprite = teamList[playerTeamIndex].teamLogo;
                opp1Logo.sprite = teamList[ray].teamLogo;
                opp2Logo.sprite = teamList[miller].teamLogo;
                opp3Logo.sprite = teamList[tuloso].teamLogo;
                opp4Logo.sprite = teamList[london].teamLogo;
                opp5Logo.sprite = teamList[vicEast].teamLogo;
                opp6Logo.sprite = teamList[collegiate].teamLogo;
                opp7Logo.sprite = teamList[sinton].teamLogo;
                opp8Logo.sprite = teamList[kaufer].teamLogo;
                opp9Logo.sprite = teamList[calallen].teamLogo;
                opp10Logo.sprite = teamList[portA].teamLogo;
                opp11Logo.sprite = teamList[gp].teamLogo;

                
                play1Logo.sprite = teamList[playerTeamIndex].teamLogo;
                play2Logo.sprite = teamList[tuloso].teamLogo;
                play5Logo.sprite = teamList[calallen].teamLogo;
                play6Logo.sprite = teamList[gp].teamLogo;

                
                semi1Logo.sprite = teamList[playerTeamIndex].teamLogo;
                semi2Logo.sprite = teamList[london].teamLogo;
                semi3Logo.sprite = teamList[gp].teamLogo;
                semi4Logo.sprite = teamList[sinton].teamLogo;


                
                fin1Logo.sprite = teamList[playerTeamIndex].teamLogo;
                fin2Logo.sprite = teamList[sinton].teamLogo;


                break;
            case 4:
                opp0Logo.sprite = teamList[veteransMemorial].teamLogo;
                opp1Logo.sprite = teamList[ray].teamLogo;
                opp2Logo.sprite = teamList[miller].teamLogo;
                opp3Logo.sprite = teamList[tuloso].teamLogo;
                opp4Logo.sprite = teamList[playerTeamIndex].teamLogo;
                opp5Logo.sprite = teamList[vicEast].teamLogo;
                opp6Logo.sprite = teamList[collegiate].teamLogo;
                opp7Logo.sprite = teamList[sinton].teamLogo;
                opp8Logo.sprite = teamList[kaufer].teamLogo;
                opp9Logo.sprite = teamList[calallen].teamLogo;
                opp10Logo.sprite = teamList[portA].teamLogo;
                opp11Logo.sprite = teamList[gp].teamLogo;

                
                play1Logo.sprite = teamList[veteransMemorial].teamLogo;
                play2Logo.sprite = teamList[tuloso].teamLogo;
                play5Logo.sprite = teamList[calallen].teamLogo;
                play6Logo.sprite = teamList[gp].teamLogo;

                
                semi1Logo.sprite = teamList[veteransMemorial].teamLogo;
                semi2Logo.sprite = teamList[playerTeamIndex].teamLogo;
                semi3Logo.sprite = teamList[gp].teamLogo;
                semi4Logo.sprite = teamList[sinton].teamLogo;


                
                fin1Logo.sprite = teamList[playerTeamIndex].teamLogo;
                fin2Logo.sprite = teamList[sinton].teamLogo;


                break;
            case 5:
                opp0Logo.sprite = teamList[veteransMemorial].teamLogo;
                opp1Logo.sprite = teamList[ray].teamLogo;
                opp2Logo.sprite = teamList[miller].teamLogo;
                opp3Logo.sprite = teamList[tuloso].teamLogo;
                opp4Logo.sprite = teamList[london].teamLogo;
                opp5Logo.sprite = teamList[playerTeamIndex].teamLogo;
                opp6Logo.sprite = teamList[collegiate].teamLogo;
                opp7Logo.sprite = teamList[sinton].teamLogo;
                opp8Logo.sprite = teamList[kaufer].teamLogo;
                opp9Logo.sprite = teamList[calallen].teamLogo;
                opp10Logo.sprite = teamList[portA].teamLogo;
                opp11Logo.sprite = teamList[gp].teamLogo;

                
                play1Logo.sprite = teamList[veteransMemorial].teamLogo;
                play2Logo.sprite = teamList[tuloso].teamLogo;
                play5Logo.sprite = teamList[calallen].teamLogo;
                play6Logo.sprite = teamList[gp].teamLogo;

                
                semi1Logo.sprite = teamList[veteransMemorial].teamLogo;
                semi2Logo.sprite = teamList[playerTeamIndex].teamLogo;
                semi3Logo.sprite = teamList[gp].teamLogo;
                semi4Logo.sprite = teamList[sinton].teamLogo;


                
                fin1Logo.sprite = teamList[playerTeamIndex].teamLogo;
                fin2Logo.sprite = teamList[sinton].teamLogo;


                break;
            case 6:
                opp0Logo.sprite = teamList[veteransMemorial].teamLogo;
                opp1Logo.sprite = teamList[ray].teamLogo;
                opp2Logo.sprite = teamList[miller].teamLogo;
                opp3Logo.sprite = teamList[tuloso].teamLogo;
                opp4Logo.sprite = teamList[london].teamLogo;
                opp5Logo.sprite = teamList[vicEast].teamLogo;
                opp6Logo.sprite = teamList[collegiate].teamLogo;
                opp7Logo.sprite = teamList[sinton].teamLogo;
                opp8Logo.sprite = teamList[kaufer].teamLogo;
                opp9Logo.sprite = teamList[calallen].teamLogo;
                opp10Logo.sprite = teamList[portA].teamLogo;
                opp11Logo.sprite = teamList[playerTeamIndex].teamLogo;

                
                play1Logo.sprite = teamList[veteransMemorial].teamLogo;
                play2Logo.sprite = teamList[tuloso].teamLogo;
                play5Logo.sprite = teamList[calallen].teamLogo;
                play6Logo.sprite = teamList[playerTeamIndex].teamLogo;

                
                semi1Logo.sprite = teamList[veteransMemorial].teamLogo;
                semi2Logo.sprite = teamList[london].teamLogo;
                semi3Logo.sprite = teamList[playerTeamIndex].teamLogo;
                semi4Logo.sprite = teamList[sinton].teamLogo;


                
                fin1Logo.sprite = teamList[veteransMemorial].teamLogo;
                fin2Logo.sprite = teamList[playerTeamIndex].teamLogo;


                break;
            case 7:
                opp0Logo.sprite = teamList[veteransMemorial].teamLogo;
                opp1Logo.sprite = teamList[ray].teamLogo;
                opp2Logo.sprite = teamList[miller].teamLogo;
                opp3Logo.sprite = teamList[tuloso].teamLogo;
                opp4Logo.sprite = teamList[london].teamLogo;
                opp5Logo.sprite = teamList[vicEast].teamLogo;
                opp6Logo.sprite = teamList[collegiate].teamLogo;
                opp7Logo.sprite = teamList[sinton].teamLogo;
                opp8Logo.sprite = teamList[kaufer].teamLogo;
                opp9Logo.sprite = teamList[calallen].teamLogo;
                opp10Logo.sprite = teamList[portA].teamLogo;
                opp11Logo.sprite = teamList[playerTeamIndex].teamLogo;

                
                play1Logo.sprite = teamList[veteransMemorial].teamLogo;
                play2Logo.sprite = teamList[tuloso].teamLogo;
                play5Logo.sprite = teamList[calallen].teamLogo;
                play6Logo.sprite = teamList[playerTeamIndex].teamLogo;

                
                semi1Logo.sprite = teamList[veteransMemorial].teamLogo;
                semi2Logo.sprite = teamList[london].teamLogo;
                semi3Logo.sprite = teamList[playerTeamIndex].teamLogo;
                semi4Logo.sprite = teamList[sinton].teamLogo;

                
                fin1Logo.sprite = teamList[veteransMemorial].teamLogo;
                fin2Logo.sprite = teamList[playerTeamIndex].teamLogo;


                break;
            case 8:
                opp0Logo.sprite = teamList[veteransMemorial].teamLogo;
                opp1Logo.sprite = teamList[ray].teamLogo;
                opp2Logo.sprite = teamList[miller].teamLogo;
                opp3Logo.sprite = teamList[tuloso].teamLogo;
                opp4Logo.sprite = teamList[london].teamLogo;
                opp5Logo.sprite = teamList[vicEast].teamLogo;
                opp6Logo.sprite = teamList[collegiate].teamLogo;
                opp7Logo.sprite = teamList[sinton].teamLogo;
                opp8Logo.sprite = teamList[kaufer].teamLogo;
                opp9Logo.sprite = teamList[playerTeamIndex].teamLogo;
                opp10Logo.sprite = teamList[portA].teamLogo;
                opp11Logo.sprite = teamList[gp].teamLogo;

                
                play1Logo.sprite = teamList[veteransMemorial].teamLogo;
                play2Logo.sprite = teamList[tuloso].teamLogo;
                play5Logo.sprite = teamList[playerTeamIndex].teamLogo;
                play6Logo.sprite = teamList[gp].teamLogo;

                
                semi1Logo.sprite = teamList[veteransMemorial].teamLogo;
                semi2Logo.sprite = teamList[london].teamLogo;
                semi3Logo.sprite = teamList[gp].teamLogo;
                semi4Logo.sprite = teamList[playerTeamIndex].teamLogo;


                
                fin1Logo.sprite = teamList[veteransMemorial].teamLogo;
                fin2Logo.sprite = teamList[playerTeamIndex].teamLogo;


                break;
            case 9:
                opp0Logo.sprite = teamList[veteransMemorial].teamLogo;
                opp1Logo.sprite = teamList[ray].teamLogo;
                opp2Logo.sprite = teamList[miller].teamLogo;
                opp3Logo.sprite = teamList[playerTeamIndex].teamLogo;
                opp4Logo.sprite = teamList[london].teamLogo;
                opp5Logo.sprite = teamList[vicEast].teamLogo;
                opp6Logo.sprite = teamList[collegiate].teamLogo;
                opp7Logo.sprite = teamList[sinton].teamLogo;
                opp8Logo.sprite = teamList[kaufer].teamLogo;
                opp9Logo.sprite = teamList[calallen].teamLogo;
                opp10Logo.sprite = teamList[portA].teamLogo;
                opp11Logo.sprite = teamList[gp].teamLogo;

                
                play1Logo.sprite = teamList[veteransMemorial].teamLogo;
                play2Logo.sprite = teamList[playerTeamIndex].teamLogo;
                play5Logo.sprite = teamList[calallen].teamLogo;
                play6Logo.sprite = teamList[gp].teamLogo;

                
                semi1Logo.sprite = teamList[playerTeamIndex].teamLogo;
                semi2Logo.sprite = teamList[london].teamLogo;
                semi3Logo.sprite = teamList[gp].teamLogo;
                semi4Logo.sprite = teamList[sinton].teamLogo;


                
                fin1Logo.sprite = teamList[playerTeamIndex].teamLogo;
                fin2Logo.sprite = teamList[sinton].teamLogo;


                break;
            case 10:
                opp0Logo.sprite = teamList[veteransMemorial].teamLogo;
                opp1Logo.sprite = teamList[ray].teamLogo;
                opp2Logo.sprite = teamList[miller].teamLogo;
                opp3Logo.sprite = teamList[tuloso].teamLogo;
                opp4Logo.sprite = teamList[london].teamLogo;
                opp5Logo.sprite = teamList[vicEast].teamLogo;
                opp6Logo.sprite = teamList[playerTeamIndex].teamLogo;
                opp7Logo.sprite = teamList[sinton].teamLogo;
                opp8Logo.sprite = teamList[kaufer].teamLogo;
                opp9Logo.sprite = teamList[calallen].teamLogo;
                opp10Logo.sprite = teamList[portA].teamLogo;
                opp11Logo.sprite = teamList[gp].teamLogo;

                
                play1Logo.sprite = teamList[veteransMemorial].teamLogo;
                play2Logo.sprite = teamList[tuloso].teamLogo;
                play5Logo.sprite = teamList[calallen].teamLogo;
                play6Logo.sprite = teamList[gp].teamLogo;

                
                semi1Logo.sprite = teamList[veteransMemorial].teamLogo;
                semi2Logo.sprite = teamList[london].teamLogo;
                semi3Logo.sprite = teamList[gp].teamLogo;
                semi4Logo.sprite = teamList[playerTeamIndex].teamLogo;


                
                fin1Logo.sprite = teamList[veteransMemorial].teamLogo;
                fin2Logo.sprite = teamList[playerTeamIndex].teamLogo;


                break;
            case 11:
                opp0Logo.sprite = teamList[veteransMemorial].teamLogo;
                opp1Logo.sprite = teamList[ray].teamLogo;
                opp2Logo.sprite = teamList[playerTeamIndex].teamLogo;
                opp3Logo.sprite = teamList[tuloso].teamLogo;
                opp4Logo.sprite = teamList[london].teamLogo;
                opp5Logo.sprite = teamList[vicEast].teamLogo;
                opp6Logo.sprite = teamList[collegiate].teamLogo;
                opp7Logo.sprite = teamList[sinton].teamLogo;
                opp8Logo.sprite = teamList[kaufer].teamLogo;
                opp9Logo.sprite = teamList[calallen].teamLogo;
                opp10Logo.sprite = teamList[portA].teamLogo;
                opp11Logo.sprite = teamList[gp].teamLogo;

                
                play1Logo.sprite = teamList[veteransMemorial].teamLogo;
                play2Logo.sprite = teamList[playerTeamIndex].teamLogo;
                play5Logo.sprite = teamList[calallen].teamLogo;
                play6Logo.sprite = teamList[gp].teamLogo;

                
                semi1Logo.sprite = teamList[playerTeamIndex].teamLogo;
                semi2Logo.sprite = teamList[london].teamLogo;
                semi3Logo.sprite = teamList[gp].teamLogo;
                semi4Logo.sprite = teamList[sinton].teamLogo;


                
                fin1Logo.sprite = teamList[playerTeamIndex].teamLogo;
                fin2Logo.sprite = teamList[sinton].teamLogo;


                break;
            case 12:
                opp0Logo.sprite = teamList[veteransMemorial].teamLogo;
                opp1Logo.sprite = teamList[ray].teamLogo;
                opp2Logo.sprite = teamList[playerTeamIndex].teamLogo;
                opp3Logo.sprite = teamList[tuloso].teamLogo;
                opp4Logo.sprite = teamList[london].teamLogo;
                opp5Logo.sprite = teamList[vicEast].teamLogo;
                opp6Logo.sprite = teamList[collegiate].teamLogo;
                opp7Logo.sprite = teamList[sinton].teamLogo;
                opp8Logo.sprite = teamList[kaufer].teamLogo;
                opp9Logo.sprite = teamList[calallen].teamLogo;
                opp10Logo.sprite = teamList[portA].teamLogo;
                opp11Logo.sprite = teamList[gp].teamLogo;

                
                play1Logo.sprite = teamList[veteransMemorial].teamLogo;
                play2Logo.sprite = teamList[playerTeamIndex].teamLogo;
                play5Logo.sprite = teamList[calallen].teamLogo;
                play6Logo.sprite = teamList[gp].teamLogo;

                
                semi1Logo.sprite = teamList[playerTeamIndex].teamLogo;
                semi2Logo.sprite = teamList[london].teamLogo;
                semi3Logo.sprite = teamList[gp].teamLogo;
                semi4Logo.sprite = teamList[sinton].teamLogo;


                
                fin1Logo.sprite = teamList[playerTeamIndex].teamLogo;
                fin2Logo.sprite = teamList[sinton].teamLogo;


                break;
            case 13:
                opp0Logo.sprite = teamList[veteransMemorial].teamLogo;
                opp1Logo.sprite = teamList[ray].teamLogo;
                opp2Logo.sprite = teamList[miller].teamLogo;
                opp3Logo.sprite = teamList[tuloso].teamLogo;
                opp4Logo.sprite = teamList[london].teamLogo;
                opp5Logo.sprite = teamList[vicEast].teamLogo;
                opp6Logo.sprite = teamList[collegiate].teamLogo;
                opp7Logo.sprite = teamList[sinton].teamLogo;
                opp8Logo.sprite = teamList[kaufer].teamLogo;
                opp9Logo.sprite = teamList[calallen].teamLogo;
                opp10Logo.sprite = teamList[playerTeamIndex].teamLogo;
                opp11Logo.sprite = teamList[gp].teamLogo;

                
                play1Logo.sprite = teamList[veteransMemorial].teamLogo;
                play2Logo.sprite = teamList[tuloso].teamLogo;
                play5Logo.sprite = teamList[calallen].teamLogo;
                play6Logo.sprite = teamList[playerTeamIndex].teamLogo;

                
                semi1Logo.sprite = teamList[veteransMemorial].teamLogo;
                semi2Logo.sprite = teamList[london].teamLogo;
                semi3Logo.sprite = teamList[playerTeamIndex].teamLogo;
                semi4Logo.sprite = teamList[sinton].teamLogo;


                
                fin1Logo.sprite = teamList[veteransMemorial].teamLogo;
                fin2Logo.sprite = teamList[playerTeamIndex].teamLogo;


                break;
            case 14:
                opp0Logo.sprite = teamList[veteransMemorial].teamLogo;
                opp1Logo.sprite = teamList[ray].teamLogo;
                opp2Logo.sprite = teamList[miller].teamLogo;
                opp3Logo.sprite = teamList[playerTeamIndex].teamLogo;
                opp4Logo.sprite = teamList[london].teamLogo;
                opp5Logo.sprite = teamList[vicEast].teamLogo;
                opp6Logo.sprite = teamList[collegiate].teamLogo;
                opp7Logo.sprite = teamList[sinton].teamLogo;
                opp8Logo.sprite = teamList[kaufer].teamLogo;
                opp9Logo.sprite = teamList[calallen].teamLogo;
                opp10Logo.sprite = teamList[portA].teamLogo;
                opp11Logo.sprite = teamList[gp].teamLogo;

                
                play1Logo.sprite = teamList[veteransMemorial].teamLogo;
                play2Logo.sprite = teamList[playerTeamIndex].teamLogo;
                play5Logo.sprite = teamList[calallen].teamLogo;
                play6Logo.sprite = teamList[gp].teamLogo;

                
                semi1Logo.sprite = teamList[playerTeamIndex].teamLogo;
                semi2Logo.sprite = teamList[london].teamLogo;
                semi3Logo.sprite = teamList[gp].teamLogo;
                semi4Logo.sprite = teamList[sinton].teamLogo;


                
                fin1Logo.sprite = teamList[playerTeamIndex].teamLogo;
                fin2Logo.sprite = teamList[sinton].teamLogo;


                break;
            case 15:
                opp0Logo.sprite = teamList[veteransMemorial].teamLogo;
                opp1Logo.sprite = teamList[ray].teamLogo;
                opp2Logo.sprite = teamList[miller].teamLogo;
                opp3Logo.sprite = teamList[tuloso].teamLogo;
                opp4Logo.sprite = teamList[london].teamLogo;
                opp5Logo.sprite = teamList[vicEast].teamLogo;
                opp6Logo.sprite = teamList[collegiate].teamLogo;
                opp7Logo.sprite = teamList[sinton].teamLogo;
                opp8Logo.sprite = teamList[playerTeamIndex].teamLogo;
                opp9Logo.sprite = teamList[calallen].teamLogo;
                opp10Logo.sprite = teamList[portA].teamLogo;
                opp11Logo.sprite = teamList[gp].teamLogo;

                
                play1Logo.sprite = teamList[veteransMemorial].teamLogo;
                play2Logo.sprite = teamList[tuloso].teamLogo;
                play5Logo.sprite = teamList[playerTeamIndex].teamLogo;
                play6Logo.sprite = teamList[gp].teamLogo;

                
                semi1Logo.sprite = teamList[veteransMemorial].teamLogo;
                semi2Logo.sprite = teamList[london].teamLogo;
                semi3Logo.sprite = teamList[gp].teamLogo;
                semi4Logo.sprite = teamList[playerTeamIndex].teamLogo;

                
                fin1Logo.sprite = teamList[veteransMemorial].teamLogo;
                fin2Logo.sprite = teamList[playerTeamIndex].teamLogo;


                break;
            case 16:
                opp0Logo.sprite = teamList[veteransMemorial].teamLogo;
                opp1Logo.sprite = teamList[ray].teamLogo;
                opp2Logo.sprite = teamList[miller].teamLogo;
                opp3Logo.sprite = teamList[tuloso].teamLogo;
                opp4Logo.sprite = teamList[london].teamLogo;
                opp5Logo.sprite = teamList[playerTeamIndex].teamLogo;
                opp6Logo.sprite = teamList[collegiate].teamLogo;
                opp7Logo.sprite = teamList[sinton].teamLogo;
                opp8Logo.sprite = teamList[kaufer].teamLogo;
                opp9Logo.sprite = teamList[calallen].teamLogo;
                opp10Logo.sprite = teamList[portA].teamLogo;
                opp11Logo.sprite = teamList[gp].teamLogo;

                
                play1Logo.sprite = teamList[veteransMemorial].teamLogo;
                play2Logo.sprite = teamList[tuloso].teamLogo;
                play5Logo.sprite = teamList[calallen].teamLogo;
                play6Logo.sprite = teamList[gp].teamLogo;

                
                semi1Logo.sprite = teamList[veteransMemorial].teamLogo;
                semi2Logo.sprite = teamList[playerTeamIndex].teamLogo;
                semi3Logo.sprite = teamList[gp].teamLogo;
                semi4Logo.sprite = teamList[sinton].teamLogo;


                
                fin1Logo.sprite = teamList[playerTeamIndex].teamLogo;
                fin2Logo.sprite = teamList[sinton].teamLogo;


                break;
            case 17:
                opp0Logo.sprite = teamList[veteransMemorial].teamLogo;
                opp1Logo.sprite = teamList[playerTeamIndex].teamLogo;
                opp2Logo.sprite = teamList[miller].teamLogo;
                opp3Logo.sprite = teamList[tuloso].teamLogo;
                opp4Logo.sprite = teamList[london].teamLogo;
                opp5Logo.sprite = teamList[vicEast].teamLogo;
                opp6Logo.sprite = teamList[collegiate].teamLogo;
                opp7Logo.sprite = teamList[sinton].teamLogo;
                opp8Logo.sprite = teamList[kaufer].teamLogo;
                opp9Logo.sprite = teamList[calallen].teamLogo;
                opp10Logo.sprite = teamList[portA].teamLogo;
                opp11Logo.sprite = teamList[gp].teamLogo;

                
                play1Logo.sprite = teamList[playerTeamIndex].teamLogo;
                play2Logo.sprite = teamList[tuloso].teamLogo;
                play5Logo.sprite = teamList[calallen].teamLogo;
                play6Logo.sprite = teamList[gp].teamLogo;

                
                semi1Logo.sprite = teamList[playerTeamIndex].teamLogo;
                semi2Logo.sprite = teamList[london].teamLogo;
                semi3Logo.sprite = teamList[gp].teamLogo;
                semi4Logo.sprite = teamList[sinton].teamLogo;


                
                fin1Logo.sprite = teamList[playerTeamIndex].teamLogo;
                fin2Logo.sprite = teamList[sinton].teamLogo;


                break;
            case 18:
                opp0Logo.sprite = teamList[veteransMemorial].teamLogo;
                opp1Logo.sprite = teamList[ray].teamLogo;
                opp2Logo.sprite = teamList[miller].teamLogo;
                opp3Logo.sprite = teamList[tuloso].teamLogo;
                opp4Logo.sprite = teamList[london].teamLogo;
                opp5Logo.sprite = teamList[vicEast].teamLogo;
                opp6Logo.sprite = teamList[collegiate].teamLogo;
                opp7Logo.sprite = teamList[sinton].teamLogo;
                opp8Logo.sprite = teamList[kaufer].teamLogo;
                opp9Logo.sprite = teamList[playerTeamIndex].teamLogo;
                opp10Logo.sprite = teamList[portA].teamLogo;
                opp11Logo.sprite = teamList[gp].teamLogo;

                
                play1Logo.sprite = teamList[veteransMemorial].teamLogo;
                play2Logo.sprite = teamList[tuloso].teamLogo;
                play5Logo.sprite = teamList[playerTeamIndex].teamLogo;
                play6Logo.sprite = teamList[gp].teamLogo;

                
                semi1Logo.sprite = teamList[veteransMemorial].teamLogo;
                semi2Logo.sprite = teamList[london].teamLogo;
                semi3Logo.sprite = teamList[gp].teamLogo;
                semi4Logo.sprite = teamList[playerTeamIndex].teamLogo;


                
                fin1Logo.sprite = teamList[veteransMemorial].teamLogo;
                fin2Logo.sprite = teamList[playerTeamIndex].teamLogo;


                break;
            case 19:
                opp0Logo.sprite = teamList[veteransMemorial].teamLogo;
                opp1Logo.sprite = teamList[ray].teamLogo;
                opp2Logo.sprite = teamList[miller].teamLogo;
                opp3Logo.sprite = teamList[tuloso].teamLogo;
                opp4Logo.sprite = teamList[london].teamLogo;
                opp5Logo.sprite = teamList[vicEast].teamLogo;
                opp6Logo.sprite = teamList[playerTeamIndex].teamLogo;
                opp7Logo.sprite = teamList[sinton].teamLogo;
                opp8Logo.sprite = teamList[kaufer].teamLogo;
                opp9Logo.sprite = teamList[calallen].teamLogo;
                opp10Logo.sprite = teamList[portA].teamLogo;
                opp11Logo.sprite = teamList[gp].teamLogo;

                
                play1Logo.sprite = teamList[veteransMemorial].teamLogo;
                play2Logo.sprite = teamList[tuloso].teamLogo;
                play5Logo.sprite = teamList[calallen].teamLogo;
                play6Logo.sprite = teamList[gp].teamLogo;

                
                semi1Logo.sprite = teamList[veteransMemorial].teamLogo;
                semi2Logo.sprite = teamList[london].teamLogo;
                semi3Logo.sprite = teamList[gp].teamLogo;
                semi4Logo.sprite = teamList[playerTeamIndex].teamLogo;


                
                fin1Logo.sprite = teamList[veteransMemorial].teamLogo;
                fin2Logo.sprite = teamList[playerTeamIndex].teamLogo;


                break;
            case 20:
                opp0Logo.sprite = teamList[veteransMemorial].teamLogo;
                opp1Logo.sprite = teamList[ray].teamLogo;
                opp2Logo.sprite = teamList[miller].teamLogo;
                opp3Logo.sprite = teamList[tuloso].teamLogo;
                opp4Logo.sprite = teamList[london].teamLogo;
                opp5Logo.sprite = teamList[vicEast].teamLogo;
                opp6Logo.sprite = teamList[collegiate].teamLogo;
                opp7Logo.sprite = teamList[playerTeamIndex].teamLogo;
                opp8Logo.sprite = teamList[kaufer].teamLogo;
                opp9Logo.sprite = teamList[calallen].teamLogo;
                opp10Logo.sprite = teamList[portA].teamLogo;
                opp11Logo.sprite = teamList[gp].teamLogo;

                
                play1Logo.sprite = teamList[veteransMemorial].teamLogo;
                play2Logo.sprite = teamList[tuloso].teamLogo;
                play5Logo.sprite = teamList[calallen].teamLogo;
                play6Logo.sprite = teamList[gp].teamLogo;

                
                semi1Logo.sprite = teamList[veteransMemorial].teamLogo;
                semi2Logo.sprite = teamList[london].teamLogo;
                semi3Logo.sprite = teamList[gp].teamLogo;
                semi4Logo.sprite = teamList[playerTeamIndex].teamLogo;


                
                fin1Logo.sprite = teamList[veteransMemorial].teamLogo;
                fin2Logo.sprite = teamList[playerTeamIndex].teamLogo;


                break;
            case 21:
                opp0Logo.sprite = teamList[veteransMemorial].teamLogo;
                opp1Logo.sprite = teamList[ray].teamLogo;
                opp2Logo.sprite = teamList[miller].teamLogo;
                opp3Logo.sprite = teamList[tuloso].teamLogo;
                opp4Logo.sprite = teamList[london].teamLogo;
                opp5Logo.sprite = teamList[playerTeamIndex].teamLogo;
                opp6Logo.sprite = teamList[collegiate].teamLogo;
                opp7Logo.sprite = teamList[sinton].teamLogo;
                opp8Logo.sprite = teamList[kaufer].teamLogo;
                opp9Logo.sprite = teamList[calallen].teamLogo;
                opp10Logo.sprite = teamList[portA].teamLogo;
                opp11Logo.sprite = teamList[gp].teamLogo;

                
                play1Logo.sprite = teamList[veteransMemorial].teamLogo;
                play2Logo.sprite = teamList[tuloso].teamLogo;
                play5Logo.sprite = teamList[calallen].teamLogo;
                play6Logo.sprite = teamList[gp].teamLogo;

                
                semi1Logo.sprite = teamList[veteransMemorial].teamLogo;
                semi2Logo.sprite = teamList[playerTeamIndex].teamLogo;
                semi3Logo.sprite = teamList[gp].teamLogo;
                semi4Logo.sprite = teamList[sinton].teamLogo;


                
                fin1Logo.sprite = teamList[playerTeamIndex].teamLogo;
                fin2Logo.sprite = teamList[sinton].teamLogo;


                break;
            case 22:
                opp0Logo.sprite = teamList[veteransMemorial].teamLogo;
                opp1Logo.sprite = teamList[ray].teamLogo;
                opp2Logo.sprite = teamList[miller].teamLogo;
                opp3Logo.sprite = teamList[tuloso].teamLogo;
                opp4Logo.sprite = teamList[london].teamLogo;
                opp5Logo.sprite = teamList[vicEast].teamLogo;
                opp6Logo.sprite = teamList[collegiate].teamLogo;
                opp7Logo.sprite = teamList[sinton].teamLogo;
                opp8Logo.sprite = teamList[kaufer].teamLogo;
                opp9Logo.sprite = teamList[calallen].teamLogo;
                opp10Logo.sprite = teamList[playerTeamIndex].teamLogo;
                opp11Logo.sprite = teamList[gp].teamLogo;

                
                play1Logo.sprite = teamList[veteransMemorial].teamLogo;
                play2Logo.sprite = teamList[tuloso].teamLogo;
                play5Logo.sprite = teamList[calallen].teamLogo;
                play6Logo.sprite = teamList[playerTeamIndex].teamLogo;

                
                semi1Logo.sprite = teamList[veteransMemorial].teamLogo;
                semi2Logo.sprite = teamList[london].teamLogo;
                semi3Logo.sprite = teamList[playerTeamIndex].teamLogo;
                semi4Logo.sprite = teamList[sinton].teamLogo;


                
                fin1Logo.sprite = teamList[veteransMemorial].teamLogo;
                fin2Logo.sprite = teamList[playerTeamIndex].teamLogo;


                break;
            case 23:
                opp0Logo.sprite = teamList[veteransMemorial].teamLogo;
                opp1Logo.sprite = teamList[ray].teamLogo;
                opp2Logo.sprite = teamList[miller].teamLogo;
                opp3Logo.sprite = teamList[tuloso].teamLogo;
                opp4Logo.sprite = teamList[london].teamLogo;
                opp5Logo.sprite = teamList[vicEast].teamLogo;
                opp6Logo.sprite = teamList[collegiate].teamLogo;
                opp7Logo.sprite = teamList[sinton].teamLogo;
                opp8Logo.sprite = teamList[playerTeamIndex].teamLogo;
                opp9Logo.sprite = teamList[calallen].teamLogo;
                opp10Logo.sprite = teamList[portA].teamLogo;
                opp11Logo.sprite = teamList[gp].teamLogo;

                
                play1Logo.sprite = teamList[veteransMemorial].teamLogo;
                play2Logo.sprite = teamList[tuloso].teamLogo;
                play5Logo.sprite = teamList[playerTeamIndex].teamLogo;
                play6Logo.sprite = teamList[gp].teamLogo;

                
                semi1Logo.sprite = teamList[veteransMemorial].teamLogo;
                semi2Logo.sprite = teamList[london].teamLogo;
                semi3Logo.sprite = teamList[gp].teamLogo;
                semi4Logo.sprite = teamList[playerTeamIndex].teamLogo;


                
                fin1Logo.sprite = teamList[veteransMemorial].teamLogo;
                fin2Logo.sprite = teamList[playerTeamIndex].teamLogo;


                break;
            default:
                Debug.Log("Error. Cannot find a valid teamplayerindex.");
                break;
        }
    }
}
