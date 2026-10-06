using UnityEngine;

public class ejercicio_6 : MonoBehaviour
{
  public float velocidad;
  void Start()
  {
    float eje_horizontal = Input.GetAxis("Horizontal");
    float eje_vertical = Input.GetAxis("Vertical");


  }

  void Update()
    {
      float eje_horizontal = Input.GetAxis("Horizontal");
      float eje_vertical = Input.GetAxis("Vertical");

      float vel_eje_horizontal = velocidad * eje_horizontal;
      float vel_eje_vertical = velocidad * eje_vertical;


      if (Input.GetKey(KeyCode.UpArrow) || Input.GetKey(KeyCode.DownArrow))
      {
        string nombreTecla = Input.GetKey(KeyCode.UpArrow) ? "Arriba" : "Abajo";
        Debug.Log($"Tecla pulsada: {nombreTecla}, producto de la velocidad en el eje vertical: {vel_eje_vertical}");
      }
      else if (Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.LeftArrow))
      {
        string nombreTecla = Input.GetKey(KeyCode.RightArrow) ? "Derecha" : "Izquierda";
        Debug.Log($"Tecla pulsada: {nombreTecla}, producto de la velocidad en el eje horizontal: {vel_eje_horizontal}");
      }
      else if (Input.anyKeyDown) 
      {
        Debug.Log("Tecla Incorrecta");
      }
    }
}
