using UnityEngine;

public class egg : MonoBehaviour
{
    public GameObject next;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Invoke("Hatch", 10);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void Hatch()
    {
        Destroy(this.gameObject);
        hud.incrementEggCount(-1);
        Instantiate(next, transform.position, Random.rotation);
        hud.incrementChickCount(1);
    }
}
