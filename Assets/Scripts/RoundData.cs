using UnityEngine;
using System.Collections;

[System.Serializable]
public class RoundData 
{
    public string name;
    public int timeLimitInSeconds;
    public int pointsAddedForCorrectAnswer;
    public int questionCount;
    public QuestionData[] questions;

    [Header("Boyd Talking")]
    [SerializeField] public AudioClip[] boydQuest;
}
