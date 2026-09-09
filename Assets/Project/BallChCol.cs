using UnityEngine;
using TMPro;

public class BallChCol : MonoBehaviour
{
    public Color triggerColor = Color.red;
    public float Numy;

    public TMP_Text triggerText;

    private static bool number1 = false;
    private static bool number2 = false;
    private static bool number3 = false;
    private static bool number4 = false;
    private static bool number5 = false;
    private static bool number6 = false;

    private static int triggersTouched = 0;
    private Renderer ballRenderer;

    public Color ballColor;

    void Start()
    {
        
        ballRenderer = GetComponent<Renderer>();

        ballRenderer.material.color = ballColor;
    }

    private void OnTriggerEnter(Collider other)
    {
        BallCoolor cube = other.GetComponent<BallCoolor>();

        if (cube != null)
        {
            cube.SetColor(triggerColor);

            PlayerMove player = other.GetComponent<PlayerMove>();

            if (player != null)
            {
                player.PlayerNumber = Numy;
            }

            bool newTrigger = false;

            if (Numy == 1 && !number1)
            {
                number1 = true;
                newTrigger = true;
            }
            else if (Numy == 2 && !number2)
            {
                number2 = true;
                newTrigger = true;
            }
            else if (Numy == 3 && !number3)
            {
                number3 = true;
                newTrigger = true;
            }
            else if (Numy == 4 && !number4)
            {
                number4 = true;
                newTrigger = true;
            }
            else if (Numy == 5 && !number5)
            {
                number5 = true;
                newTrigger = true;
            }
            else if (Numy == 6 && !number6)
            {
                number6 = true;
                newTrigger = true;
            }

            if (newTrigger)
            {
                triggersTouched++;

                if (triggersTouched <= 5)
                {
                    triggerText.text = "Colors: " + triggersTouched + "/5";
                }
                else if (triggersTouched == 6)
                {
                    triggerText.text = "You Win";
                }
            }
        }
    }
}