
using UnityEngine;

using TMPro;

public class Score : MonoBehaviour
{
    public Transform player;
    public TextMeshProUGUI scoreText;
    public float transformDistance;
    public float zMultiplier;

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").transform;
        scoreText = GetComponent<TextMeshProUGUI>();
    }

    // Update is called once per frame
    void Update()
    {
        transformDistance = player.position.z * zMultiplier;
        scoreText.text = transformDistance.ToString("0");
    }
}
