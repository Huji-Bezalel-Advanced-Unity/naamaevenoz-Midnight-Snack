using System.Collections;
using UnityEngine;

public class LightManager : MonoBehaviour
{
        [SerializeField] Light fridgeLight;  
        public float minTime = 3f; 
        public float maxTime = 6f; 
        public static bool isDark = true; 

        void Start()
        {
            StartCoroutine(ToggleLight());
        }

        IEnumerator ToggleLight()
        {
            while (true)
            {
                yield return new WaitForSeconds(Random.Range(minTime, maxTime));
                isDark = !isDark;
                fridgeLight.enabled = !isDark; 

            }
        }
}
