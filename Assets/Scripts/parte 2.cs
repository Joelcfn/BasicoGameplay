    using UnityEngine;

    public class parte2 : MonoBehaviour
    {
    private float topBound = 30;
    private float lowerBound = -10;
        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {
            
        }

        // Update is called once per frame
        void Update()
    
    {
            if (transform.position.z > topBound)
            {
            Destroy(gameObject);

            } else if (transform.position.z < lowerBound) 
            
            {
        
            Debug.Log("Game Over!");
            Destroy(gameObject);
            }
    }

          void OnTriggerEnter(Collider other)
    {
        Destroy(gameObject);
        Destroy(other.gameObject);
    }
    
    }
