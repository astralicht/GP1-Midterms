using UnityEngine;

public class chick : MonoBehaviour
{
    public GameObject next;
    public GameObject nextAlternative;
    private GameObject forGrow;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Invoke("Grow", 10);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void Grow()
    {
        forGrow = next;

        if (GameObject.FindGameObjectsWithTag("Chick").Length > 1)
        {
            if (Random.Range(1, 3) == 1)
            {
                forGrow = nextAlternative;
            }
        }

        Destroy(this.gameObject);
        hud.incrementChickCount(-1);
        Instantiate(forGrow, transform.position, Random.rotation);

        if (forGrow == next)
        {
            hud.incrementHenCount(1);
        }
        else if (forGrow == nextAlternative)
        {
            hud.incrementRoosterCount(1);
        }
    }
}
