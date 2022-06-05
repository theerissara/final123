
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;



public class ScoreManager : MonoBehaviour
{
    [SerializeField] private Text TextPlayer;
    [SerializeField] private Text AiPadText;
    private int playerScore = 0;
    private int AipadScore = 0;
    public void UpdatePlayerScore()
    { playerScore++;
       TextPlayer.text = playerScore.ToString();
    }
    public void UpdateAiPadScore()
    {
        AipadScore++;
        AiPadText.text = AipadScore.ToString();

    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
