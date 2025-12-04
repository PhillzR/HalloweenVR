using Oculus.Haptics;
using UnityEngine;

public class HapticManager : MonoBehaviour
{
    HapticClipPlayer player;
    [SerializeField] HapticClip clip;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Awake()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void PlayHaptics(HapticClip clip)
    {
        player = new HapticClipPlayer(clip);
        player.Play(Controller.Right);
    }
}
