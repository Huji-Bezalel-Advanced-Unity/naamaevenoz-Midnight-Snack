using System.Collections;
using UnityEngine;  
public class ChocolateDetector : MonoBehaviour
{
    public Transform target; 
    public float grabSpeed = 2f; 
    private bool isGrabbing = false;

    void Update()
    {
        if (!LightManager.isDark) 
        {
            if (!isGrabbing)
            {
                isGrabbing = true;
                MoveHands();
            }
        }
        else
        {
            isGrabbing = false;
        }
    }

    void MoveHands()
    {
        Vector3 grabPosition = new Vector3(target.position.x, target.position.y, target.position.z);
        transform.position = Vector3.Lerp(transform.position, grabPosition, grabSpeed * Time.deltaTime);

        if (Vector3.Distance(transform.position, target.position) < 0.5f)
        {
            Debug.Log("You got caught!");
        }
    }
}
