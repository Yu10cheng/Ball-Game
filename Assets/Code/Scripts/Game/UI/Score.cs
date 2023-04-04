
using UnityEngine;

using TMPro;

public class Score : MonoBehaviour
{
    public Transform player;
    public TextMeshProUGUI scoreText;

    public float zMultiplier;
    [SerializeField] private FloatSO scoreSO;

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").transform;

        scoreText = GetComponent<TextMeshProUGUI>();
    }

    // Update is called once per frame
    void Update()
    {
        scoreSO.Value = player.position.z * zMultiplier;
        scoreText.text = scoreSO.Value.ToString("0");
    }
}
