using UnityEngine;

public class ejercicio_5 : MonoBehaviour
{
  public Vector3 desplazamiento;
  private Vector3 pos_inicial;
  void Start() 
  {
    pos_inicial = transform.position;
  }

  void Update() 
  {
    if (Input.GetAxis("Jump") >= 0.1f) 
    {
      transform.position = pos_inicial + desplazamiento;
    }
  }
}
