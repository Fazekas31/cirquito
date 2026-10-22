using UnityEngine;

public class ObjectHit : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("Something hit me!");
        GetComponent<MeshRenderer>().material.color = Color.red;
    }
}
