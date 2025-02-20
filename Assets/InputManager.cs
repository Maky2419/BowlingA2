using UnityEngine;
using UnityEngine.Events; // Add this namespace for the Public UnityEvent OnSpacePressed=new UnityEvent();

public class InputManager : MonoBehaviour
{
    public UnityEvent<Vector2> OnMove = new UnityEvent<Vector2>();
    public UnityEvent OnResetPressed = new UnityEvent();
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    public UnityEvent OnSpacePressed = new UnityEvent();

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space)){
            OnSpacePressed?.Invoke();
        }
        Vector2 input = Vector2.zero;
        if (Input.GetKey(KeyCode.A)) {
            input += Vector2.left;
        }
        if (Input.GetKey(KeyCode.D)){
            input += Vector2.right;
        }
        if (Input.GetKeyDown(KeyCode.R)) {
            OnResetPressed?.Invoke();
            }
        OnMove?.Invoke(input);

        
    }
}