using UnityEngine;
using UnityEngine.InputSystem;

public class NewMonoBehaviourScript : MonoBehaviour
{
    public InputActionProperty grabAction;
    public InputActionProperty triggerAction;

    public Animator animator;

    // Update is called once per frame
    void Update()
    {
        float grabValue = grabAction.action.ReadValue<float>();
        animator.SetFloat("grab", grabValue);


        float triggerValue = triggerAction.action.ReadValue<float>();
        animator.SetFloat("trigger", triggerValue);
    }
}
