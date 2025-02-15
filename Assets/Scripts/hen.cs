using UnityEngine;

public class hen : MonoBehaviour
{
    public GameObject egg;

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
        for (int i = 0; i < Random.Range(2, 11); i++)
        {
            newEgg = Instantiate(egg, transform.position, Random.rotation);
        }
    }

    private void Die()
    {
        Destroy(this.gameObject);
    }
}
