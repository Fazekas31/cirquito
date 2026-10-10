using UnityEngine;

public class Move : MonoBehaviour
{
  [SerializeField] float speed = 10f;
  // Start is called once before the first execution of Update after the MonoBehaviour is created
  void Start()
  {

  }

  // Update is called once per frame
  void Update()
  {

    float xValue = Input.GetAxis("Horizontal") * speed * Time.deltaTime;
    float yValue = 0f;
    float zValue = Input.GetAxis("Vertical") * speed * Time.deltaTime;
    transform.Translate(xValue, yValue, zValue);
  }
}
