using UnityEngine;

public class ejercicio_10 : MonoBehaviour
{
  public float cube_speed = 2;
  public float sphere_speed = 2;
  private GameObject esfera;
  private GameObject cubo;

  void Start()
  {
    esfera = GameObject.FindWithTag("esfera");
    cubo = GameObject.FindWithTag("cubo");
  }

  void Update()
    {
        // Leemos los ejes
        float horizontal_cubo = Input.GetAxis("Horizontal");
        float vertical_cubo = Input.GetAxis("Vertical");
        float horizontal_esfera = Input.GetAxis("Horizontal_esfera");
        float vertical_esfera = Input.GetAxis("Vertical_esfera");

        // Calculamos los movimientos
        float movX_cubo = horizontal_cubo * cube_speed * Time.deltaTime;
        float movY_cubo = vertical_cubo * cube_speed * Time.deltaTime;

        float movX_esfera = horizontal_esfera * sphere_speed * Time.deltaTime;
        float movY_esfera = vertical_esfera * sphere_speed * Time.deltaTime;

        // Aplicamos el desplazamiento con Translate (pasando los valores x, y, z)
        if (cubo != null)
        {
            cubo.transform.Translate(movX_cubo, movY_cubo, 0);
        }

        if (esfera != null)
        {
            esfera.transform.Translate(movX_esfera, movY_esfera, 0);
        }
    }
}
