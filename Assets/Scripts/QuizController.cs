using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class QuizController : MonoBehaviour
{
    public int level;
    public Text ResultText;
    public Button ButtonO;
    public Button ButtonX;
    public Button ButtonNext;

    private BoardManager boardScript;

    // Start is called before the first frame update
    void Start()
     {
        ResultText.text = "";
     }

    public void ClickO()
    {
        ResultText.text = "맞았습니다!";
        ButtonO.interactable = false;
        ButtonX.interactable = false;
    }

    public void ClickX()
    {
        ResultText.text = "틀렸습니다!";
        ButtonO.interactable = false;
        ButtonX.interactable = false;
    }

    public void ClickNext()
    {
        level = level+1;
        boardScript.SetupScene(level);
    }
}