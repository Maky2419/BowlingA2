using UnityEngine;

public class BallController : MonoBehaviour
{
    public Rigidbody ballRB;
    private bool isBallLaunched;
    [SerializeField] private float force = 1f;
    [SerializeField] private InputManager inputManager;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        ballRB = GetComponent<Rigidbody>();
        inputManager.OnSpacePressed.AddListener(LaunchBall);
        
        
    }
    private void LaunchBall(){
        if (isBallLaunched) return;
        
        isBallLaunched = true;
        ballRB.AddForce(transform.forward * force, ForceMode.Impulse);
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
