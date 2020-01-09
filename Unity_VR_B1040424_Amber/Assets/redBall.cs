using UnityEngine;
using UnityEngine.UI;

public class redBall : MonoBehaviour
{
    public void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "Key")
        {
            Destroy(gameObject);
            CountBall.GetBall += 1;
        }
        
    }
    
}