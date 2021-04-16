using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class ButtonAnswerHandler : MonoBehaviour
{
    public void OnClickRight()
    {
        Debug.Log("정답");
    }

    public void OnClickWrong()
    {
        Debug.Log("오답");
    }
}
