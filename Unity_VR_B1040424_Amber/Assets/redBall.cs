using UnityEngine;
using UnityEngine.UI;

public class redBall : MonoBehaviour
{
    public void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Key")
        {
            Destroy(gameObject);
            CountBall.GetBall += 1;
        }
    }
}