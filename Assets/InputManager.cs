using UnityEngine;
using UnityEngine.Events; // Add this namespace for the Public UnityEvent OnSpacePressed=new UnityEvent();

public class InputManager : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    public UnityEvent OnSpacePressed = new UnityEvent();

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            OnSpacePressed?.Invoke();
        }
    }
}