using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject whiteBoard;
    public  GameObject blackBoard;
    void Start()
    {
        
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0) && whiteBoard != null)
        {
            Rotation(whiteBoard);
        }

        if (Input.GetKeyDown(KeyCode.Mouse1) && blackBoard != null)
        {
            Rotation(blackBoard);
        }
    }

    void Rotation(GameObject board)
    {
        float targetRotation = -30f;
        if (Mathf.Approximately(board.transform.rotation.eulerAngles.x, 30f))
        {
            targetRotation = -30f;
        }else targetRotation = 30f;
        board.transform.rotation = Quaternion.Euler(targetRotation, 90f, 0f);
    }
}
