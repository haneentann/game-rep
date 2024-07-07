using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*https://www.youtube.com/watch?v=XtQMytORBmM&t=1718s*/

public class PipeMoveScript : MonoBehaviour
{
    public float moveSpeed = 5;
    public float deadZone = -30; //where the bird located at the beginning of the run
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position =    transform.position + (Vector3.left * moveSpeed) * Time.deltaTime;
        //pipes outside of screen are destroyed
        if (transform.position.x < deadZone)
        {
            Debug.Log("Pipe Deleted!");
            Destroy(gameObject);
        }
            
    }
}
