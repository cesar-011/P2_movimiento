using UnityEngine;

public class ejercicio_11 : MonoBehaviour
{
  public float speed_esfera = 0.5f;
  public float speed_cubo = 0.5f;
  private GameObject esfera;

  void Start()
  {
    esfera = GameObject.FindWithTag("esfera");
  }

  void Update()
  {
    float horizontal_esfera = Input.GetAxis("Horizontal_esfera");
    float vertical_esfera = Input.GetAxis("Vertical_esfera");

    float movX_esfera = horizontal_esfera * speed_esfera * Time.deltaTime;
    float movY_esfera = vertical_esfera * speed_esfera * Time.deltaTime;

    esfera.transform.Translate(movX_esfera, movY_esfera, 0);

    Vector3 direccion = esfera.transform.position - transform.position;

    direccion.y = 0;

    Vector3 direccion_normalizada = direccion.normalized;

    transform.Translate(direccion_normalizada * speed_cubo * Time.deltaTime, Space.World);
  }
}
