using Oculus.Haptics;
using UnityEngine;

public class BullseyePoints : MonoBehaviour
{
    [SerializeField] int points = 5;
    [SerializeField] int score = 0;
    [SerializeField] AudioClip hitSFX;
    [SerializeField] AudioSource hitSFXSource;
    [SerializeField] HapticClip clip;
    HapticManager hapticManager;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Breakable")
        {
            score += points;
            hitSFXSource.PlayOneShot(hitSFX);
            hapticManager.PlayHaptics(clip);
        }
    }


    public int GetScore()
    {
        return score;
    }
}
