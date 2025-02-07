using UnityEngine;

public class Mover : MonoBehaviour
{




    [SerializeField] float moveSpeed = 0.01f;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
        
    }

    // Update is called once per frame
    void Update()
    {
        
        float xValue = Input.GetAxis("Horizontal") * Time.deltaTime * moveSpeed; //-1 pushing left, 1 pushing right, 0 is nothing 
        float yValue = 0f;
        float zValue = Input.GetAxis("Vertical") * Time.deltaTime * moveSpeed;

        transform.Translate(xValue, yValue, zValue);
        
    }
}
