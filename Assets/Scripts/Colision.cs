using UnityEngine;

public class Colision : MonoBehaviour
{
   private void OnCollisionEnter(Collision other)
   {
      switch (other.gameObject.tag)
      {
         case "Frendly":
            Debug.Log("Frend"); 
            break;
         case "Finish":
            Debug.Log("Yeee FINISH!!!!"); 
            break;
         case "Buster":
            Debug.Log("Energy is full"); 
            break;
         default:
            Debug.Log("Boom");
            break;
      }
   }
}
