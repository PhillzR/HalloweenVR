using Oculus.Haptics;
using UnityEngine;

public class HapticManager : MonoBehaviour
{
    HapticClipPlayer player;
    [SerializeField] HapticClip clip;

    public void PlayHaptics(HapticClip clip)
    {
        player = new HapticClipPlayer(clip);
        player.Play(Controller.Right);
    }
}
