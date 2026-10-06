using UnityEngine;

public class ejercicio_8 : MonoBehaviour
{
  public Vector3 moveDirection =  new Vector3(0,0,0);
  public float speed = 2f;

  void Update() 
  {
    float despx = moveDirection.x * speed * Time.deltaTime;
    float despy = moveDirection.y * speed * Time.deltaTime;
    float despz = moveDirection.z * speed * Time.deltaTime;

    transform.Translate(despx, despy, despz);
  }
}
