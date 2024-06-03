using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class MenuScreenController : MonoBehaviour {

    public void StartQuickMatch()
    {
        SceneManager.LoadScene("TeamSelection");
    }
    public void StartExhibition()
    {
        SceneManager.LoadScene("RandomTeamSelection");
    }
    public void StartCareer()
    {
        SceneManager.LoadScene("CareerTeamSelection");
    }
    
}