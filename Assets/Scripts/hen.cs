using TMPro;
using UnityEngine;

public class hen : MonoBehaviour
{
    public GameObject egg;
    private int rand;
    private int i;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Invoke("Lay", 30);
        Invoke("Die", 40);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void Lay()
    {
        GameObject newEgg;
        rand = Random.Range(2, 11);
        for (i = 0; i < rand; i++)
        {
            newEgg = Instantiate(egg, transform.position, Random.rotation);
        }
        hud.incrementEggCount(rand);
    }

    private void Die()
    {
        Destroy(this.gameObject);
        hud.incrementHenCount(-1);
    }
}
