using UnityEngine;
using UnityEngine.SceneManagement;

public class Ventana_secundaria : MonoBehaviour
{
   public void Cargarescena(string escena)
   {
    SceneManager.LoadScene(escena);
   }
}
