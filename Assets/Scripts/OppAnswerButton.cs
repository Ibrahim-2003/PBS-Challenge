using UnityEngine;
using System.Collections;
using UnityEngine.UI;

//Rename class for each scene
public class OppAnswerButton : MonoBehaviour {

    public Text answerText;

    private AnswerData answerData;

    //Rename game controller
    private OppGameController gameController;

    // Use this for initialization
    void Start () 
    {
        //Rename Object to new game controller name
        gameController = FindObjectOfType<OppGameController> ();
    }

    public void Setup(AnswerData data)
    {
        answerData = data;
        answerText.text = answerData.answerText;
    }


    public void HandleClick()
    {
        gameController.AnswerButtonClicked (answerData.isCorrect);
    }
}