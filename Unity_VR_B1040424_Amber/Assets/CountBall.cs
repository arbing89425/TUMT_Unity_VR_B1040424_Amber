using UnityEngine;
using UnityEngine.UI;

public class CountBall : MonoBehaviour
{
    public Text _text;
    public static int GetBall ;
    public void Update()
    {
        _text.text = "裡面的球目前有：" + GetBall + "顆";
    }
}