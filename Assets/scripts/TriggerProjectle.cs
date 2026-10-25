using UnityEngine;

public class TriggerProjectle : MonoBehaviour
{
    [SerializeField] GameObject sphere;
    [SerializeField] GameObject Sphere1;
    [SerializeField] GameObject Sphere2;
    [SerializeField] GameObject Sphere3;
    [SerializeField] GameObject Sphere4;
    [SerializeField] GameObject Sphere5;

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            sphere.SetActive(true);
            Sphere1.SetActive(true);
            Sphere2.SetActive(true);
            Sphere3.SetActive(true);
            Sphere4.SetActive(true);
            Sphere5.SetActive(true);
        }
    }
}
