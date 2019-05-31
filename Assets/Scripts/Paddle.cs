using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paddle : MonoBehaviour
{
    [SerializeField] private float screenWidthInUnits = 16f;
    [SerializeField] private float leftScreenSide = 0f;
    private float rightScreenSide;
    
    private float mousePosition;
    // Start is called before the first frame update
    void Start()
    {
        rightScreenSide = screenWidthInUnits-1;
    }

    // Update is called once per frame
    void Update()
    {
        mousePosition = Input.mousePosition.x / Screen.width * screenWidthInUnits;
        Vector2 paddlePos = new Vector2(transform.position.x, transform.position.y);
        paddlePos.x = Mathf.Clamp(mousePosition, leftScreenSide, rightScreenSide);
        transform.position = paddlePos;
    }
}
