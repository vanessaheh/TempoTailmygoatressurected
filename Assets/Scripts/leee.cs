using UnityEngine;
using UnityEngine.InputSystem; // new Input System namespace

public class BeatScroller : MonoBehaviour
{
    [SerializeField] private float beatTempo;   // beats per minute
    private float scrollSpeed;                  // calculated units per second
    private bool hasStarted;

    [SerializeField] private InputAction startAction; // assign in Inspector

    private void OnEnable()
    {
        startAction.Enable();
        startAction.started += OnStartPressed;
    }

    private void OnDisable()
    {
        startAction.started -= OnStartPressed;
        startAction.Disable();
    }

    private void Start()
    {
        // Convert BPM to units per second
        scrollSpeed = beatTempo / 60f;
    }

    private void Update()
    {
        if (hasStarted)
        {
            transform.position -= new Vector3(0f, scrollSpeed * Time.deltaTime, 0f);
        }
    }

    private void OnStartPressed(InputAction.CallbackContext context)
    {
        hasStarted = true;
    }
}
