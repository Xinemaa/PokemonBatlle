using UnityEngine;

public class BillBoard : MonoBehaviour
{
   private Camera camera;
   private void Awake()
    {
        camera = Camera.main;
    }
     private void LateUpdate()
    {
      transform.LookAt(transform.position + camera.transform.forward);  
    }
}
