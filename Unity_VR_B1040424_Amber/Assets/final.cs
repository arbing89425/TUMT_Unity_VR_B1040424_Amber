using UnityEngine;
using UnityEngine.UI;

public class final : MonoBehaviour
{
    public Text say;
    public void Update()
    {
        if (CountBall.GetBall >= 5)
        {
            say.text = "恭喜你完成測試，成為一名職業蒐集達人\n左下角可以離開遊戲喔";
        }
        else
        {
            say.text = "把紅色的球回收到籃裡";
        }
    }
}