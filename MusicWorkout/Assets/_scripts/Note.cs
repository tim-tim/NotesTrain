using UnityEngine;
using UnityEngine.UI;
using System.Collections;


public class Note : MonoBehaviour
{
    [SerializeField]
    Pitch myNote;

    [SerializeField]
    Vector3 notePosition = Vector3.zero;

    int offsetPos = 360;
    int octaveOffset = 140;
    int staffStepSize = 20;

    public Transform alterObj;

    public Transform noteObj;

    void Awake()
    {
        //myNote = new Pitch();        
    }

    void Update ()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Debug.Log(myNote.ToString(true));            
        }      
    }   
}
