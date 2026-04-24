using UnityEngine;

public class PlayerAnimation_1 : MonoBehaviour
{

   public CharacterController controller;
    // Animator animator; // Uncomment this when you're ready!

    void Start()
    {
    
    }

    void LateUpdate()
    {
        if (controller != null)
        {
            float thisVelocity = controller.velocity.magnitude;
            
            // This will now show even if the player is standing still
            Debug.Log("The player's velocity is: " + thisVelocity);
            
            /* // When you're ready for the Animator:
            animator.SetFloat("Speed", thisVelocity); 
            */
        }
    }
}
