using UnityEngine;

public class Scorer : MonoBehaviour
{
    int score = 0;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag != "HIt")
        {
            score++;
            Debug.Log("Score: " + score);
        }
    }
}
