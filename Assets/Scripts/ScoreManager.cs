using UnityEngine;
using TMPro;

public class ScoreManager : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI text;
    [SerializeField] BullseyePoints bullseyePoints;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Awake()
    {
        text = FindFirstObjectByType<TextMeshProUGUI>();
        bullseyePoints = FindFirstObjectByType<BullseyePoints>();
    }

    // Update is called once per frame
    void Update()
    {
        UpdateScore();
    }

    void UpdateScore()
    {
        text.text = "Score: " + bullseyePoints.GetScore().ToString();
    }
}
