using TMPro;
using UnityEngine;

public class hud : MonoBehaviour
{
    public TextMeshProUGUI eggCount;
    public TextMeshProUGUI chickCount;
    public TextMeshProUGUI henCount;
    public TextMeshProUGUI roosterCount;

    public static int eggCounter;
    public static int chickCounter;
    public static int henCounter;
    public static int roosterCounter;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        eggCounter = 1;
        chickCounter = 0;
        henCounter = 0;
        roosterCounter = 0;
    }

    // Update is called once per frame
    void Update()
    {
        updateHUD();
    }

    private void updateHUD()
    {
        eggCount.text = eggCounter.ToString();
        chickCount.text = chickCounter.ToString();
        henCount.text = henCounter.ToString();
        roosterCount.text = roosterCounter.ToString();
    }

    public static void incrementEggCount(int increment)
    {
        eggCounter += increment;
    }

    public static void incrementChickCount(int increment)
    {
        chickCounter += increment;
    }

    public static void incrementHenCount(int increment)
    {
        henCounter += increment;
    }

    public static void incrementRoosterCount(int increment)
    {
        roosterCounter += increment;
    }
}
