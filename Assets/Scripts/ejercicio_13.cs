using UnityEngine;

public class ejercicio_13 : MonoBehaviour
{
    public float velocidadAvance = 5f;
    public float velocidadGiro = 100f;

    void Update()
    {
        // Leemos el eje horizontal y rotamos el objeto
        float giro = Input.GetAxis("Horizontal");
        
        // Aplicamos la rotación en el eje Y multiplicada por deltaTime para fluidez
        transform.Rotate(0, giro * velocidadGiro * Time.deltaTime, 0); 

        //El objeto se mueve automáticamente hacia su propio frente
        transform.position += transform.forward * velocidadAvance * Time.deltaTime;

        //Dibuja una línea roja de 5 metros para ver el frente del objeto en la vista Scene
        Debug.DrawRay(transform.position, transform.forward * 5f, Color.red);
    }
}