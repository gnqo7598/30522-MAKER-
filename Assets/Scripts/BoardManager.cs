using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BoardManager : MonoBehaviour
{
    public Text QuizText;
    public Text ResultText;
    public GameObject[] AnswerButtons;

    void BoardSetup(int Index)
    {
        if (Index == 1)
        {

            QuizText.text = "성보고등학교 교가는 성보중학교 교가와 같다.";
            /*AnswerButtons[0] = Button ButtonO;
            AnswerButtons[1] = Button ButtonX;
            AnswerButtons[0].GetComponent<QuizController>(ClickO);
            AnswerButtons[1].GetComponent<QuizController>(ClickX);*/


        }
        else if (Index == 2)
        {


        }
        else if (Index == 3)
        {


        }
        else if (Index == 4)
        {


        }
        else if (Index == 5)
        {


        }
        else
        {
            ResultText.text = "모든 문제를 풀으셨습니다. 수고하셨습니다.";


        }
    }

    public void SetupScene(int Index)
    {
        BoardSetup(Index);
    }
}
