using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Collections.Generic;
using UnityEngine.Audio;
using System.Linq;

public class GameBracketL4Controller : MonoBehaviour {

    
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

    [Header("Canvas")]
    [SerializeField] private GameObject bracketCanvas;

    [Header("UI References")]
    [SerializeField] private Image myEndLogo;
    [SerializeField] private Image oppEndLogo;

    [Header("List of Teams")]
    [SerializeField] private List<TeamSelectObject> teamList = new List<TeamSelectObject>();

    [System.Serializable]
    public class TeamSelectObject
    {
        public Sprite teamLogo;
    }

    [Header("Button Sounds")]
    [SerializeField] private AudioClip correctAnswer;
    [SerializeField] private AudioClip wrongAnswer;

    

    [Header("Match Result Sounds")]
    [SerializeField] private AudioClip winSound;
    [SerializeField] private AudioClip loseSound;
    [SerializeField] private AudioClip drawSound;

    [Header("End Trophy")]
    [SerializeField] private GameObject trophyWin;
    [SerializeField] private GameObject trophyLose;
    [SerializeField] private GameObject trophyDraw;

    public GameObject menuButtonLose;
    public GameObject menuButtonWin;
    public GameObject continueButton;

    public AudioSource audio1;
    public Text questionDisplayText;
    public Text scoreDisplayText;
    public Text oppScoreDisplayText;
    public Text opponentEndText;
    public Text playerEndText;
    public Text resultText;
    public AudioClip[] buttonSound;
    public SimpleObjectPool answerButtonObjectPool;
    public Transform answerButtonParent;
    public GameObject questionDisplay;
    public GameObject roundEndDisplay;
    public GameObject buzzerDisplay1;
    public GameObject buzzerDisplay2;
    public GameObject buzzerDisplay3;
    public GameObject buzzerDisplay4;
    public Text teamNamePlayer;
    public Text smallteamNamePlayer;
    public Text teamNameOpponent;
    public GameObject playerLogo1;
    public GameObject playerLogo2;
    public GameObject playerLogo3;
    public GameObject playerLogo4;
    public GameObject playerLogo5;
    public GameObject playerLogo6;
    public GameObject playerLogo7;
    public GameObject playerLogo8;
    public GameObject playerLogo9;
    public GameObject playerLogo10;
    public GameObject playerLogo11;
    public GameObject playerLogo12;
    public GameObject playerLogo13;
    public GameObject playerLogo14;
    public GameObject playerLogo15;
    public GameObject playerLogo16;
    public GameObject playerLogo17;
    public GameObject playerLogo18;
    public GameObject playerLogo19;
    public GameObject playerLogo20;
    public GameObject playerLogo21;
    public GameObject playerLogo22;
    public GameObject playerLogo23;
    public GameObject playerLogo24;
    public GameObject smallplayerLogo1;
    public GameObject smallplayerLogo2;
    public GameObject smallplayerLogo3;
    public GameObject smallplayerLogo4;
    public GameObject smallplayerLogo5;
    public GameObject smallplayerLogo6;
    public GameObject smallplayerLogo7;
    public GameObject smallplayerLogo8;
    public GameObject smallplayerLogo9;
    public GameObject smallplayerLogo10;
    public GameObject smallplayerLogo11;
    public GameObject smallplayerLogo12;
    public GameObject smallplayerLogo13;
    public GameObject smallplayerLogo14;
    public GameObject smallplayerLogo15;
    public GameObject smallplayerLogo16;
    public GameObject smallplayerLogo17;
    public GameObject smallplayerLogo18;
    public GameObject smallplayerLogo19;
    public GameObject smallplayerLogo20;
    public GameObject smallplayerLogo21;
    public GameObject smallplayerLogo22;
    public GameObject smallplayerLogo23;
    public GameObject smallplayerLogo24;
    public GameObject smallplayerSecondLogo1;
    public GameObject smallplayerSecondLogo2;
    public GameObject smallplayerSecondLogo3;
    public GameObject smallplayerSecondLogo4;
    public GameObject smallplayerSecondLogo5;
    public GameObject smallplayerSecondLogo6;
    public GameObject smallplayerSecondLogo7;
    public GameObject smallplayerSecondLogo8;
    public GameObject smallplayerSecondLogo9;
    public GameObject smallplayerSecondLogo10;
    public GameObject smallplayerSecondLogo11;
    public GameObject smallplayerSecondLogo12;
    public GameObject smallplayerSecondLogo13;
    public GameObject smallplayerSecondLogo14;
    public GameObject smallplayerSecondLogo15;
    public GameObject smallplayerSecondLogo16;
    public GameObject smallplayerSecondLogo17;
    public GameObject smallplayerSecondLogo18;
    public GameObject smallplayerSecondLogo19;
    public GameObject smallplayerSecondLogo20;
    public GameObject smallplayerSecondLogo21;
    public GameObject smallplayerSecondLogo22;
    public GameObject smallplayerSecondLogo23;
    public GameObject smallplayerSecondLogo24;
    public GameObject teamLogo1;
    public GameObject teamLogo2;
    public GameObject teamLogo3;
    public GameObject teamLogo4;
    public GameObject teamLogo5;
    public GameObject teamLogo6;
    public GameObject teamLogo7;
    public GameObject teamLogo8;
    public GameObject teamLogo9;
    public GameObject teamLogo10;
    public GameObject teamLogo11;
    public GameObject teamLogo12;
    public GameObject teamLogo13;
    public GameObject teamLogo14;
    public GameObject teamLogo15;
    public GameObject teamLogo16;
    public GameObject teamLogo17;
    public GameObject teamLogo18;
    public GameObject teamLogo19;
    public GameObject teamLogo20;
    public GameObject teamLogo21;
    public GameObject teamLogo22;
    public GameObject teamLogo23;
    public GameObject teamLogo24;
    public GameObject RedPlayer1;
    public GameObject RedPlayer2;
    public GameObject RedPlayer3;
    public GameObject RedPlayer4;
    public GameObject MaroonPlayer1;
    public GameObject MaroonPlayer2;
    public GameObject MaroonPlayer3;
    public GameObject MaroonPlayer4;
    public GameObject BlackPlayer1;
    public GameObject BlackPlayer2;
    public GameObject BlackPlayer3;
    public GameObject BlackPlayer4;
    public GameObject BrightGreenPlayer1;
    public GameObject BrightGreenPlayer2;
    public GameObject BrightGreenPlayer3;
    public GameObject BrightGreenPlayer4;
    public GameObject BrightBluePlayer1;
    public GameObject BrightBluePlayer2;
    public GameObject BrightBluePlayer3;
    public GameObject BrightBluePlayer4;
    public GameObject DarkGreenPlayer1;
    public GameObject DarkGreenPlayer2;
    public GameObject DarkGreenPlayer3;
    public GameObject DarkGreenPlayer4;
    public GameObject DarkBluePlayer1;
    public GameObject DarkBluePlayer2;
    public GameObject DarkBluePlayer3;
    public GameObject DarkBluePlayer4;
    public GameObject GreyPlayer1;
    public GameObject GreyPlayer2;
    public GameObject GreyPlayer3;
    public GameObject GreyPlayer4;
    public GameObject OrangePlayer1;
    public GameObject OrangePlayer2;
    public GameObject OrangePlayer3;
    public GameObject OrangePlayer4;
    public GameObject boydSprite;
    public GameObject boydTalkSprite;
    public GameObject boydCardSprite;
    
    
    

    private DataController dataController;
    private RoundData currentRoundData;
    private QuestionData[] questionPool;
    
    private Animator animator;
    private QuestionData tmpGo;
    private AudioClip tempGo;

    //New Randomizer
    private List<QuestionData> unansweredQuestions;
    private List<AudioClip> unspokenQuestions;
    private QuestionData currentQuestion; 
    private AudioClip currentSpeak;

    private bool isRoundActive;
    private float timeRemaining;
    private int questionIndex;
    private int playerScore;
    private int opponentScore;
    private int counter;
    private int buzzer;
    private int rnd;
    private int oppTeam;
    private int oppTeam2;
    private int oppTeam3;
    private int oppTeam4;
    private int oppTeam5;
    private int oppTeam6;
    private int oppTeam7;
    private int oppTeam8;
    private int oppTeam9;
    private int oppTeam10;
    private int oppTeam11;
    private int oppTeam12;
    private int oppTeam13;
    private int oppTeam14;
    private int oppTeam15;
    private int oppTeam16;
    private int oppTeam17;
    private int oppTeam18;
    private int oppTeam19;
    private int oppTeam20;
    private int oppTeam21;
    private int oppTeam22;
    private int oppTeam23;
    private List<GameObject> answerButtonGameObjects = new List<GameObject>();
    

    // Use this for initialization
    void Start () 
    {
        dataController = FindObjectOfType<DataController> ();
        currentRoundData = dataController.GetCurrentRoundData ();
        questionPool = currentRoundData.questions;
        currentRoundData.questionCount = Random.Range(5, 11);
        timeRemaining = currentRoundData.timeLimitInSeconds;

        playerScore = 0;
        opponentScore = 0;
        questionIndex = 0;
        counter = 0;
        buzzer = 0;

        
        
        ScoreBoardMenu ();
        
        ShowQuestion();

        SetL2Opponent();
        
        isRoundActive = true;
        
        
     }
     
     //DO NOT TOUCH, IT FINALLY WORKS
     private void Shuffle() {
         for (int i = 0; i < questionPool.Length; i++) {
             if(i <= questionPool.Length)
             {
                rnd = Random.Range(0, questionPool.Length);
                tmpGo = questionPool[rnd];
                tempGo = currentRoundData.boydQuest[rnd];
                questionPool[rnd] = questionPool[i];
                questionPool[i] = tmpGo;
                currentRoundData.boydQuest[rnd] = currentRoundData.boydQuest[i];
                currentRoundData.boydQuest[i] = tempGo;
             }else if(i > questionPool.Length)
             {
                i = 0;
             }
             
         }
         
        
         
    
    }

     void playButtonAudio(int clipNumber){
         audio1 = GetComponent<AudioSource>();
         audio1.clip = buttonSound[clipNumber];
         audio1.Play ();
 
     }
    

    private void ShowQuestion()
    {
        
        RemoveAnswerButtons ();

        QuestionRandomizer();
        Invoke("BoydIdle", currentSpeak.length);
        Invoke("QuestionWords", currentSpeak.length);
        Invoke("AnswerChoices", currentSpeak.length);
        Invoke("BoydTalking", 0.9f);

        
    }

    //New Randomizer Component 1 of 3
    private void QuestionRandomizer()
    {
        if(unansweredQuestions == null || unansweredQuestions.Count == 0)
        {
            unansweredQuestions = questionPool.ToList<QuestionData>();
        }
        if(unspokenQuestions == null || unspokenQuestions.Count == 0)
        {
            unspokenQuestions = currentRoundData.boydQuest.ToList<AudioClip>();
        }

        GetRandomQuestion();
    }

    //New Randomizer Component 2 of 3
    void GetRandomQuestion()
    {
        int randomQuestionIndex = Random.Range(0, unansweredQuestions.Count);
        currentQuestion = unansweredQuestions[randomQuestionIndex];
        currentSpeak = unspokenQuestions[randomQuestionIndex];

        
        
        AudioManager.Instance.PlaySFX2(currentSpeak);

        unansweredQuestions.RemoveAt(randomQuestionIndex);
        unspokenQuestions.RemoveAt(randomQuestionIndex);
    }

    //New Randomizer Component 3 of 3
    private void QuestionWords()
    {
        questionDisplayText.text = currentQuestion.questionText;
    }

    private void BoydIdle()
    {
        boydCardSprite.SetActive(false);
        boydSprite.SetActive(true);
        boydTalkSprite.SetActive(false);
    }

    private void BoydTalking()
    {

        if(!boydCardSprite.activeSelf)
        {
            boydCardSprite.SetActive(false);
            boydSprite.SetActive(false);
            boydTalkSprite.SetActive(true);
        }
        
        
        
    }

    private void CardChanging()
    {
        boydSprite.SetActive(false);
        boydTalkSprite.SetActive(false);
        boydCardSprite.SetActive(true);
        Invoke("tempAnim", 0.9f);

    }

    private void tempAnim()
    {
        
        boydCardSprite.SetActive(false);
        boydSprite.SetActive(true);
        boydTalkSprite.SetActive(false);
    }

    private void AnswerChoices()
    {
        for (int i = 0; i < currentQuestion.answers.Length; i++) 
        {
            GameObject answerButtonGameObject = answerButtonObjectPool.GetObject();
            answerButtonGameObjects.Add(answerButtonGameObject);
            answerButtonGameObject.transform.SetParent(answerButtonParent);

            //Change Name to new answerbutton class
            L4AnswerButton answerButton = answerButtonGameObject.GetComponent<L4AnswerButton>();
            answerButton.Setup(currentQuestion.answers[i]);
        }
    }


    

    private void QuestionReset()
    {
        questionDisplayText.text = "Challenge";
    }

    


    private void RemoveAnswerButtons()
    {
        while (answerButtonGameObjects.Count > 0) 
        {
            answerButtonObjectPool.ReturnObject(answerButtonGameObjects[0]);
            answerButtonGameObjects.RemoveAt(0);
        }
    }

    public void AnswerButtonClicked(bool isCorrect)
    {
             

        if (isCorrect) 
        {
            
            Invoke("BoydIdle", currentSpeak.length);
            CardChanging();
            QuestionReset();
            AudioManager.Instance.PlaySFX(correctAnswer);
            
            
            playerScore += currentRoundData.pointsAddedForCorrectAnswer;
            scoreDisplayText.text = playerScore.ToString();
            playerEndText.text = scoreDisplayText.text;
            counter++;
            buzzer = Random.Range(1,4);
            switch (buzzer){
                case 1:
                    buzzerDisplay1.SetActive (true);
                    buzzerDisplay2.SetActive (false);
                    buzzerDisplay3.SetActive (false);
                    buzzerDisplay4.SetActive (false);
                    break;
                case 2:
                    buzzerDisplay2.SetActive (true);
                    buzzerDisplay1.SetActive (false);
                    buzzerDisplay3.SetActive (false);
                    buzzerDisplay4.SetActive (false);
                    break;
                case 3:
                    buzzerDisplay3.SetActive (true);
                    buzzerDisplay2.SetActive (false);
                    buzzerDisplay1.SetActive (false);
                    buzzerDisplay4.SetActive (false);
                    break;
                case 4:
                    buzzerDisplay4.SetActive (true);
                    buzzerDisplay2.SetActive (false);
                    buzzerDisplay3.SetActive (false);
                    buzzerDisplay1.SetActive (false);
                    break;                
                default:
                    buzzerDisplay1.SetActive (false);
                    buzzerDisplay2.SetActive (false);
                    buzzerDisplay3.SetActive (false);
                    buzzerDisplay4.SetActive (false);
                    break;
            } Invoke ("DestroyBuzzers", 1f);
        }else{
        CardChanging();
        
        Invoke("BoydIdle", currentSpeak.length);
        QuestionReset();
        AudioManager.Instance.PlaySFX(wrongAnswer);
        opponentScore += currentRoundData.pointsAddedForCorrectAnswer;
        oppScoreDisplayText.text = opponentScore.ToString();
        opponentEndText.text = oppScoreDisplayText.text;
        counter++;
        buzzer = Random.Range(1,4);
            switch (buzzer){
                case 1:
                    buzzerDisplay1.SetActive (true);
                    buzzerDisplay2.SetActive (false);
                    buzzerDisplay3.SetActive (false);
                    buzzerDisplay4.SetActive (false);
                    break;
                case 2:
                    buzzerDisplay1.SetActive (false);
                    buzzerDisplay2.SetActive (true);
                    buzzerDisplay3.SetActive (false);
                    buzzerDisplay4.SetActive (false);
                    break;
                case 3:
                    buzzerDisplay1.SetActive (false);
                    buzzerDisplay2.SetActive (false);
                    buzzerDisplay3.SetActive (true);
                    buzzerDisplay4.SetActive (false);
                    break;
                case 4:
                    buzzerDisplay1.SetActive (false);
                    buzzerDisplay2.SetActive (false);
                    buzzerDisplay3.SetActive (false);
                    buzzerDisplay4.SetActive (true);
                    break;                
                default:
                    buzzerDisplay1.SetActive (false);
                    buzzerDisplay2.SetActive (false);
                    buzzerDisplay3.SetActive (false);
                    buzzerDisplay4.SetActive (false);
                    break;
            }
            Invoke ("DestroyBuzzers", 1f);
        }

        if(playerScore > opponentScore)
        {
            resultText.text = "You  Win";
        }else if(opponentScore > playerScore){
            resultText.text = "You  Lose";
        }else if(playerScore == opponentScore){
            resultText.text = "You  Draw";
        }

        if (currentRoundData.questionCount > counter + 1) {
            
            

            
             
            ShowQuestion ();
        } else 
        {
            
            EndRound();
            
        }

    }

    public void DestroyBuzzers(){
        buzzerDisplay1.SetActive (false);
        buzzerDisplay2.SetActive (false);
        buzzerDisplay3.SetActive (false);
        buzzerDisplay4.SetActive (false);
    }

    IEnumerator TimeWait(float sec){
        yield return new WaitForSeconds(sec);
    }

    public void EndRound()
    {
        
        isRoundActive = false;

        boydSprite.SetActive(false);
        boydTalkSprite.SetActive(false);
        boydCardSprite.SetActive(false);
        buzzerDisplay1.SetActive (false);
        buzzerDisplay2.SetActive (false);
        buzzerDisplay3.SetActive (false);
        buzzerDisplay4.SetActive (false);
        questionDisplay.SetActive (false);
        roundEndDisplay.SetActive (true);
        playerLogo1.SetActive(false);
        playerLogo2.SetActive(false);
        playerLogo3.SetActive(false);
        playerLogo4.SetActive(false);
        playerLogo5.SetActive(false);
        playerLogo6.SetActive(false);
        playerLogo7.SetActive(false);
        playerLogo8.SetActive(false);
        playerLogo9.SetActive(false);
        playerLogo10.SetActive(false);
        playerLogo11.SetActive(false);
        playerLogo12.SetActive(false);
        playerLogo13.SetActive(false);
        playerLogo14.SetActive(false);
        playerLogo15.SetActive(false);
        playerLogo16.SetActive(false);
        playerLogo17.SetActive(false);
        playerLogo18.SetActive(false);
        playerLogo19.SetActive(false);
        playerLogo20.SetActive(false);
        playerLogo21.SetActive(false);
        playerLogo22.SetActive(false);
        playerLogo23.SetActive(false);
        playerLogo24.SetActive(false);
        smallplayerLogo1.SetActive(false);
        smallplayerLogo2.SetActive(false);
        smallplayerLogo3.SetActive(false);
        smallplayerLogo4.SetActive(false);
        smallplayerLogo5.SetActive(false);
        smallplayerLogo6.SetActive(false);
        smallplayerLogo7.SetActive(false);
        smallplayerLogo8.SetActive(false);
        smallplayerLogo9.SetActive(false);
        smallplayerLogo10.SetActive(false);
        smallplayerLogo11.SetActive(false);
        smallplayerLogo12.SetActive(false);
        smallplayerLogo13.SetActive(false);
        smallplayerLogo14.SetActive(false);
        smallplayerLogo15.SetActive(false);
        smallplayerLogo16.SetActive(false);
        smallplayerLogo17.SetActive(false);
        smallplayerLogo18.SetActive(false);
        smallplayerLogo19.SetActive(false);
        smallplayerLogo20.SetActive(false);
        smallplayerLogo21.SetActive(false);
        smallplayerLogo22.SetActive(false);
        smallplayerLogo23.SetActive(false);
        smallplayerLogo24.SetActive(false);
        smallplayerSecondLogo1.SetActive(false);
        smallplayerSecondLogo2.SetActive(false);
        smallplayerSecondLogo3.SetActive(false);
        smallplayerSecondLogo4.SetActive(false);
        smallplayerSecondLogo5.SetActive(false);
        smallplayerSecondLogo6.SetActive(false);
        smallplayerSecondLogo7.SetActive(false);
        smallplayerSecondLogo8.SetActive(false);
        smallplayerSecondLogo9.SetActive(false);
        smallplayerSecondLogo10.SetActive(false);
        smallplayerSecondLogo11.SetActive(false);
        smallplayerSecondLogo12.SetActive(false);
        smallplayerSecondLogo13.SetActive(false);
        smallplayerSecondLogo14.SetActive(false);
        smallplayerSecondLogo15.SetActive(false);
        smallplayerSecondLogo16.SetActive(false);
        smallplayerSecondLogo17.SetActive(false);
        smallplayerSecondLogo18.SetActive(false);
        smallplayerSecondLogo19.SetActive(false);
        smallplayerSecondLogo20.SetActive(false);
        smallplayerSecondLogo21.SetActive(false);
        smallplayerSecondLogo22.SetActive(false);
        smallplayerSecondLogo23.SetActive(false);
        smallplayerSecondLogo24.SetActive(false);
        teamLogo1.SetActive(false);
        teamLogo2.SetActive(false);
        teamLogo3.SetActive(false);
        teamLogo4.SetActive(false);
        teamLogo5.SetActive(false);
        teamLogo6.SetActive(false);
        teamLogo7.SetActive(false);
        teamLogo8.SetActive(false);
        teamLogo9.SetActive(false);
        teamLogo10.SetActive(false);
        teamLogo11.SetActive(false);
        teamLogo12.SetActive(false);
        teamLogo13.SetActive(false);
        teamLogo14.SetActive(false);
        teamLogo15.SetActive(false);
        teamLogo16.SetActive(false);
        teamLogo17.SetActive(false);
        teamLogo18.SetActive(false);
        teamLogo19.SetActive(false);
        teamLogo20.SetActive(false);
        teamLogo21.SetActive(false);
        teamLogo22.SetActive(false);
        teamLogo23.SetActive(false);
        teamLogo24.SetActive(false);
        RedPlayer1.SetActive(false);
        RedPlayer2.SetActive(false);
        RedPlayer3.SetActive(false);
        RedPlayer4.SetActive(false);
        MaroonPlayer1.SetActive(false);
        MaroonPlayer2.SetActive(false);
        MaroonPlayer3.SetActive(false);
        MaroonPlayer4.SetActive(false);
        BlackPlayer1.SetActive(false);
        BlackPlayer2.SetActive(false);
        BlackPlayer3.SetActive(false);
        BlackPlayer4.SetActive(false);
        BrightGreenPlayer1.SetActive(false);
        BrightGreenPlayer2.SetActive(false);
        BrightGreenPlayer3.SetActive(false);
        BrightGreenPlayer4.SetActive(false);
        BrightBluePlayer1.SetActive(false);
        BrightBluePlayer2.SetActive(false);
        BrightBluePlayer3.SetActive(false);
        BrightBluePlayer4.SetActive(false);
        DarkGreenPlayer1.SetActive(false);
        DarkGreenPlayer2.SetActive(false);
        DarkGreenPlayer3.SetActive(false);
        DarkGreenPlayer4.SetActive(false);
        DarkBluePlayer1.SetActive(false);
        DarkBluePlayer2.SetActive(false);
        DarkBluePlayer3.SetActive(false);
        DarkBluePlayer4.SetActive(false);
        GreyPlayer1.SetActive(false);
        GreyPlayer2.SetActive(false);
        GreyPlayer3.SetActive(false);
        GreyPlayer4.SetActive(false);
        OrangePlayer1.SetActive(false);
        OrangePlayer2.SetActive(false);
        OrangePlayer3.SetActive(false);
        OrangePlayer4.SetActive(false);

        myEndLogo.sprite = teamList[PlayerPrefs.GetInt("CareerTeamSelected")].teamLogo;
        //Change the Logo to the LX index
        oppEndLogo.sprite = teamList[PlayerPrefs.GetInt("OpponentL4Index")].teamLogo;
        

        if(opponentScore > playerScore)
                {
                    menuButtonLose.SetActive(true);
                    menuButtonWin.SetActive(false);
                    continueButton.SetActive(false);
                    trophyLose.SetActive(true);
                    trophyWin.SetActive(false);
                    trophyDraw.SetActive(false);
                    Invoke("PlayLose", wrongAnswer.length);
                    
                }else if(opponentScore < playerScore)
                {   


                    


                    
                    menuButtonLose.SetActive(false);
                    menuButtonWin.SetActive(true);
                    continueButton.SetActive(true);
                    trophyLose.SetActive(false);
                    trophyWin.SetActive(true);
                    trophyDraw.SetActive(false);
                    Invoke("PlayWin", wrongAnswer.length);                 
                }else if(playerScore == opponentScore)
                {
                    trophyDraw.SetActive(true);
                    trophyWin.SetActive(false);
                    trophyLose.SetActive(false);
                    Invoke("PlayDraw", wrongAnswer.length);
                }

        
    }

    private void SetL2Opponent()
    {
        //Change these to correct values

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
            //Change this to the "OpponentLX+1Index", where X is the current L
            case 0:
                PlayerPrefs.SetInt("OpponentL5Index", sinton);
                break;
            case 1:
                PlayerPrefs.SetInt("OpponentL5Index", veteransMemorial);
                break;
            case 2:
                PlayerPrefs.SetInt("OpponentL5Index", sinton);
                break;
            case 3:
                PlayerPrefs.SetInt("OpponentL5Index", sinton);
                break;
            case 4:
                PlayerPrefs.SetInt("OpponentL5Index", sinton);
                break;
            case 5:
                PlayerPrefs.SetInt("OpponentL5Index", sinton);
                break;
            case 6:
                PlayerPrefs.SetInt("OpponentL5Index", veteransMemorial);
                break;
            case 7:
                PlayerPrefs.SetInt("OpponentL5Index", veteransMemorial);
                break;
            case 8:
                PlayerPrefs.SetInt("OpponentL5Index", veteransMemorial);
                break;
            case 9:
                PlayerPrefs.SetInt("OpponentL5Index", sinton);
                break;
            case 10:
                PlayerPrefs.SetInt("OpponentL5Index", veteransMemorial);
                break;
            case 11:
                PlayerPrefs.SetInt("OpponentL5Index", sinton);
                break;
            case 12:
                PlayerPrefs.SetInt("OpponentL5Index", sinton);
                break;
            case 13:
                PlayerPrefs.SetInt("OpponentL5Index", veteransMemorial);
                break;
            case 14:
                PlayerPrefs.SetInt("OpponentL5Index", sinton);
                break;
            case 15:
                PlayerPrefs.SetInt("OpponentL5Index", veteransMemorial);
                break;
            case 16:
                PlayerPrefs.SetInt("OpponentL5Index", sinton);
                break;
            case 17:
                PlayerPrefs.SetInt("OpponentL5Index", sinton);
                break;
            case 18:
                PlayerPrefs.SetInt("OpponentL5Index", veteransMemorial);
                break;
            case 19:
                PlayerPrefs.SetInt("OpponentL5Index", veteransMemorial);
                break;
            case 20:
                PlayerPrefs.SetInt("OpponentL5Index", veteransMemorial);
                break;
            case 21:
                PlayerPrefs.SetInt("OpponentL5Index", sinton);
                break;
            case 22:
                PlayerPrefs.SetInt("OpponentL5Index", veteransMemorial);
                break;
            case 23:
                PlayerPrefs.SetInt("OpponentL5Index", veteransMemorial);
                break;
            default:
                Debug.Log("Error during setting opponent L5 Index.");
                break;
        }

    
    }

    private void PlayWin()
    {
        AudioManager.Instance.PlaySFX3(winSound);
        
    }

    private void PlayLose()
    {
        AudioManager.Instance.PlaySFX3(loseSound);
        
    }

    private void PlayDraw()
    {
        Invoke("TieBreaker", drawSound.length);
        AudioManager.Instance.PlaySFX3(drawSound);
        
    }

    private void TieBreaker()
    {
        //Change to current scene
        SceneManager.LoadScene("BracketL4");
    }

    public void ScoreBoardMenu()
    {
        string teamName = PlayerPrefs.GetString("CareerTeamName");
        teamNamePlayer.text = teamName;
        smallteamNamePlayer.text = teamName;
        int myTeamIndex = PlayerPrefs.GetInt("CareerTeamSelected");

        switch (myTeamIndex)
        {   case 0:
                playerLogo1.SetActive(true);
                smallplayerLogo1.SetActive(true);
                smallplayerSecondLogo1.SetActive(true);
                RedPlayer1.SetActive(true);
                RedPlayer2.SetActive(true);
                RedPlayer3.SetActive(true);
                RedPlayer4.SetActive(true);
                break;

            case 1:
                playerLogo2.SetActive(true);
                smallplayerLogo2.SetActive(true);
                smallplayerSecondLogo2.SetActive(true);
                MaroonPlayer1.SetActive(true);
                MaroonPlayer2.SetActive(true);
                MaroonPlayer3.SetActive(true);
                MaroonPlayer4.SetActive(true);
                break;

            case 2:
                playerLogo3.SetActive(true);
                smallplayerLogo3.SetActive(true);
                smallplayerSecondLogo3.SetActive(true);
                RedPlayer1.SetActive(true);
                RedPlayer2.SetActive(true);
                RedPlayer3.SetActive(true);
                RedPlayer4.SetActive(true);
                break;

            case 3:
                playerLogo4.SetActive(true);
                smallplayerLogo4.SetActive(true);
                smallplayerSecondLogo4.SetActive(true);
                BlackPlayer1.SetActive(true);
                BlackPlayer2.SetActive(true);
                BlackPlayer3.SetActive(true);
                BlackPlayer4.SetActive(true);
                break;

            case 4:
                playerLogo5.SetActive(true);
                smallplayerLogo5.SetActive(true);
                smallplayerSecondLogo5.SetActive(true);
                MaroonPlayer1.SetActive(true);
                MaroonPlayer2.SetActive(true);
                MaroonPlayer3.SetActive(true);
                MaroonPlayer4.SetActive(true);
                break;

            case 5:
                playerLogo6.SetActive(true);
                smallplayerLogo6.SetActive(true);
                smallplayerSecondLogo6.SetActive(true);
                BlackPlayer1.SetActive(true);
                BlackPlayer2.SetActive(true);
                BlackPlayer3.SetActive(true);
                BlackPlayer4.SetActive(true);
                break;

            case 6:
                playerLogo7.SetActive(true);
                smallplayerLogo7.SetActive(true);
                smallplayerSecondLogo7.SetActive(true);
                MaroonPlayer1.SetActive(true);
                MaroonPlayer2.SetActive(true);
                MaroonPlayer3.SetActive(true);
                MaroonPlayer4.SetActive(true);
                break;

            case 7:
                playerLogo8.SetActive(true);
                smallplayerLogo8.SetActive(true);
                smallplayerSecondLogo8.SetActive(true);
                DarkBluePlayer1.SetActive(true);
                DarkBluePlayer2.SetActive(true);
                DarkBluePlayer3.SetActive(true);
                DarkBluePlayer4.SetActive(true);
                break;

            case 8:
                playerLogo9.SetActive(true);
                smallplayerLogo9.SetActive(true);
                smallplayerSecondLogo9.SetActive(true);
                OrangePlayer1.SetActive(true);
                OrangePlayer2.SetActive(true);
                OrangePlayer3.SetActive(true);
                OrangePlayer4.SetActive(true);
                break;

            case 9:
                playerLogo10.SetActive(true);
                smallplayerLogo10.SetActive(true);
                smallplayerSecondLogo10.SetActive(true);
                DarkGreenPlayer1.SetActive(true);
                DarkGreenPlayer2.SetActive(true);
                DarkGreenPlayer3.SetActive(true);
                DarkGreenPlayer4.SetActive(true);
                break;

            case 10:
                playerLogo11.SetActive(true);
                smallplayerLogo11.SetActive(true);
                smallplayerSecondLogo11.SetActive(true);
                BlackPlayer1.SetActive(true);
                BlackPlayer2.SetActive(true);
                BlackPlayer3.SetActive(true);
                BlackPlayer4.SetActive(true);
                break;

            case 11:
                playerLogo12.SetActive(true);
                smallplayerLogo12.SetActive(true);
                smallplayerSecondLogo12.SetActive(true);
                BlackPlayer1.SetActive(true);
                BlackPlayer2.SetActive(true);
                BlackPlayer3.SetActive(true);
                BlackPlayer4.SetActive(true);
                break;

            case 12:
                playerLogo13.SetActive(true);
                smallplayerLogo13.SetActive(true);
                smallplayerSecondLogo13.SetActive(true);
                DarkBluePlayer1.SetActive(true);
                DarkBluePlayer2.SetActive(true);
                DarkBluePlayer3.SetActive(true);
                DarkBluePlayer4.SetActive(true);
                break;

            case 13:
                playerLogo14.SetActive(true);
                smallplayerLogo14.SetActive(true);
                smallplayerSecondLogo14.SetActive(true);
                BrightBluePlayer1.SetActive(true);
                BrightBluePlayer2.SetActive(true);
                BrightBluePlayer3.SetActive(true);
                BrightBluePlayer4.SetActive(true);
                break;

            case 14:
                playerLogo15.SetActive(true);
                smallplayerLogo15.SetActive(true);
                smallplayerSecondLogo15.SetActive(true);
                MaroonPlayer1.SetActive(true);
                MaroonPlayer2.SetActive(true);
                MaroonPlayer3.SetActive(true);
                MaroonPlayer4.SetActive(true);
                break;

            case 15:
                playerLogo16.SetActive(true);
                smallplayerLogo16.SetActive(true);
                smallplayerSecondLogo16.SetActive(true);
                BrightGreenPlayer1.SetActive(true);
                BrightGreenPlayer2.SetActive(true);
                BrightGreenPlayer3.SetActive(true);
                BrightGreenPlayer4.SetActive(true);
                break;

            case 16:
                playerLogo17.SetActive(true);
                smallplayerLogo17.SetActive(true);
                smallplayerSecondLogo17.SetActive(true);
                RedPlayer1.SetActive(true);
                RedPlayer2.SetActive(true);
                RedPlayer3.SetActive(true);
                RedPlayer4.SetActive(true);
                break;

            case 17:
                playerLogo18.SetActive(true);
                smallplayerLogo18.SetActive(true);
                smallplayerSecondLogo18.SetActive(true);
                BlackPlayer1.SetActive(true);
                BlackPlayer2.SetActive(true);
                BlackPlayer3.SetActive(true);
                BlackPlayer4.SetActive(true);
                break;

            case 18:
                playerLogo19.SetActive(true);
                smallplayerLogo19.SetActive(true);
                smallplayerSecondLogo19.SetActive(true);
                MaroonPlayer1.SetActive(true);
                MaroonPlayer2.SetActive(true);
                MaroonPlayer3.SetActive(true);
                MaroonPlayer4.SetActive(true);
                break;

            case 19:
                playerLogo20.SetActive(true);
                smallplayerLogo20.SetActive(true);
                smallplayerSecondLogo20.SetActive(true);
                DarkBluePlayer1.SetActive(true);
                DarkBluePlayer2.SetActive(true);
                DarkBluePlayer3.SetActive(true);
                DarkBluePlayer4.SetActive(true);
                break;

            case 20:
                playerLogo21.SetActive(true);
                smallplayerLogo21.SetActive(true);
                smallplayerSecondLogo21.SetActive(true);
                DarkBluePlayer1.SetActive(true);
                DarkBluePlayer2.SetActive(true);
                DarkBluePlayer3.SetActive(true);
                DarkBluePlayer4.SetActive(true);
                break;

            case 21:
                playerLogo22.SetActive(true);
                smallplayerLogo22.SetActive(true);
                smallplayerSecondLogo22.SetActive(true);
                GreyPlayer1.SetActive(true);
                GreyPlayer2.SetActive(true);
                GreyPlayer3.SetActive(true);
                GreyPlayer4.SetActive(true);
                break;

            case 22:
                playerLogo23.SetActive(true);
                smallplayerLogo23.SetActive(true);
                smallplayerSecondLogo23.SetActive(true);
                DarkGreenPlayer1.SetActive(true);
                DarkGreenPlayer2.SetActive(true);
                DarkGreenPlayer3.SetActive(true);
                DarkGreenPlayer4.SetActive(true);
                break;

            case 23:
                playerLogo24.SetActive(true);
                smallplayerLogo24.SetActive(true);
                smallplayerSecondLogo24.SetActive(true);
                BrightBluePlayer1.SetActive(true);
                BrightBluePlayer2.SetActive(true);
                BrightBluePlayer3.SetActive(true);
                BrightBluePlayer4.SetActive(true);
                break;
            
            default:
                playerLogo1.SetActive(true);
                smallplayerLogo1.SetActive(true);
                smallplayerSecondLogo1.SetActive(true);
                RedPlayer1.SetActive(true);
                RedPlayer2.SetActive(true);
                RedPlayer3.SetActive(true);
                RedPlayer4.SetActive(true);
                break;
        }

        //Change this to OpponentLXIndex
        oppTeam = PlayerPrefs.GetInt("OpponentL4Index");
        switch (oppTeam)
        {  
            case 0:
                teamNameOpponent.text = "Veterans Memorial";
                teamLogo1.SetActive(true);
                break;
            case 1:
                teamNameOpponent.text = "Sinton";
                teamLogo2.SetActive(true);
                break;
            case 2:
                teamNameOpponent.text = "Ray";
                teamLogo3.SetActive(true);
                break;
            case 3:
                teamNameOpponent.text = "St. John Paul II";
                teamLogo4.SetActive(true);
                break;
            case 4:
                teamNameOpponent.text = "London";
                teamLogo5.SetActive(true);
                break;
            case 5:
                teamNameOpponent.text = "Carroll";
                teamLogo6.SetActive(true);
                break;
            case 6:
                teamNameOpponent.text = "Flour Bluff";
                teamLogo7.SetActive(true);
                break;
            case 7:
                teamNameOpponent.text = "Gregory Portland";
                teamLogo8.SetActive(true);
                break;
            case 8:
                teamNameOpponent.text = "AC Jones";
                teamLogo9.SetActive(true);
                break;
            case 9:
                teamNameOpponent.text = "King";
                teamLogo10.SetActive(true);
                break;
            case 10:
                teamNameOpponent.text = "HM King";
                teamLogo11.SetActive(true);
                break;
            case 11:
                teamNameOpponent.text = "Miller";
                teamLogo12.SetActive(true);
                break;
            case 12:
                teamNameOpponent.text = "Moody";
                teamLogo13.SetActive(true);
                break;
            case 13:
                teamNameOpponent.text = "Port Aransas";
                teamLogo14.SetActive(true);
                break;
            case 14:
                teamNameOpponent.text = "Tuloso Midway";
                teamLogo15.SetActive(true);
                break;
            case 15:
                teamNameOpponent.text = "Kaufer";
                teamLogo16.SetActive(true);
                break;
            case 16:
                teamNameOpponent.text = "Victoria East";
                teamLogo17.SetActive(true);
                break;
            case 17:
                teamNameOpponent.text = "Victoria West";
                teamLogo18.SetActive(true);
                break;
            case 18:
                teamNameOpponent.text = "Calallen";
                teamLogo19.SetActive(true);
                break;
            case 19:
                teamNameOpponent.text = "Collegiate";
                teamLogo20.SetActive(true);
                break;
            case 20:
                teamNameOpponent.text = "Academy";
                teamLogo21.SetActive(true);
                break;
            case 21:
                teamNameOpponent.text = "Banquete";
                teamLogo22.SetActive(true);
                break;
            case 22:
                teamNameOpponent.text = "Rockport Fulton";
                teamLogo23.SetActive(true);
                break;
            case 23:
                teamNameOpponent.text = "Ingleside";
                teamLogo24.SetActive(true);
                break;
            default:
                teamNameOpponent.text = "NoTeam";
                teamLogo1.SetActive(true);
                break;
        }




    }


    public void ReturnToMenu()
    {
        SceneManager.LoadScene ("MenuScreen");
    }

    public void Continue()
    {
        SetPlayer();
        Activate();
        Invoke("Transition", 5.0f);
    }

    private void Transition()
    {
        SceneManager.LoadScene("L5Showcase");
    }

    private void Activate()
    {
        bracketCanvas.SetActive(true);
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