using UnityEngine;

public class ejercicio_12 : MonoBehaviour
{
  public float speed_esfera = 0.5f;
  public float speed_cubo = 0.5f;
  public float velocidadGiro = 100f;
  private GameObject esfera;
  private Transform transformEsfera;

  void Start()
  {
    esfera = GameObject.FindWithTag("esfera");
    transformEsfera = GameObject.FindWithTag("esfera").transform;
  }

  void Update()
  {
    float giro = Input.GetAxis("Horizontal");
    float profundidad_esfera = Input.GetAxis("Vertical_esfera");
    float horizontal_esfera = Input.GetAxis("Horizontal_esfera");
    float vertical_esfera = Input.GetAxis("Altitud_esfera");

    float movX_esfera = horizontal_esfera * speed_esfera * Time.deltaTime;
    float movY_esfera = vertical_esfera * speed_esfera * Time.deltaTime;
    float movZ_esfera = profundidad_esfera * speed_esfera * Time.deltaTime;


    esfera.transform.Translate(movX_esfera, movY_esfera, movZ_esfera);

    Vector3 direccion = esfera.transform.position - transform.position;

  // direccion.y = 0;

    Vector3 direccion_normalizada = direccion.normalized;

    transform.Rotate(0, giro * velocidadGiro * Time.deltaTime, 0);
    transform.position += transform.forward * speed_cubo * Time.deltaTime;

    Debug.DrawRay(transform.position, transform.forward * 5f, Color.red);
    transform.Translate(direccion_normalizada * speed_cubo * Time.deltaTime, Space.World);
    transform.LookAt(transformEsfera);
  }
}
