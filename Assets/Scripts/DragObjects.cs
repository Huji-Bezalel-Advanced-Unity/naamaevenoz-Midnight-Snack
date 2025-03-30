using System.Collections;
using UnityEngine;
public class DragObjects : MonoBehaviour
{
    [SerializeField] Transform target; 
    public float grabSpeed = 10f; 
    private bool isGrabbing = false;

    void Update()
    {
        if (!LightManager.isDark) 
        {
            if (!isGrabbing)
            {
                isGrabbing = true;
            }

            MoveHands();
        }
        else
        {
            isGrabbing = false;
        }
    }

    void MoveHands()
    {
        transform.position = Vector3.MoveTowards(transform.position, target.position, grabSpeed * Time.deltaTime);

        if (Vector3.Distance(transform.position, target.position) < 0.5f)
        {
            Debug.Log("You got caught!");
        }
    }
}
