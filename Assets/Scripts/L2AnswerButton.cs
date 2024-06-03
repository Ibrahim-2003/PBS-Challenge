﻿using UnityEngine;
using System.Collections;
using UnityEngine.UI;

//Rename class for each scene
public class L2AnswerButton : MonoBehaviour {

    public Text answerText;

    private AnswerData answerData;

    //Rename game controller
    private GameBracketL2Controller gameController;

    // Use this for initialization
    void Start () 
    {
        //Rename Object to new game controller name
        gameController = FindObjectOfType<GameBracketL2Controller> ();
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