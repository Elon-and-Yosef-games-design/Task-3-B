using System;
using UnityEngine;

public class collector : MonoBehaviour
{
    [SerializeField] private int collectible_count = 0;
    public static event Action<int> OnCollect;

    public int Get_collectible_count()
    {
        return collectible_count;
    }
    public void Set_collectible_count(int value)
    {
        collectible_count = value;
    }
    void Add_collectible()
    {
        collectible_count++;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("Collision detected");

        if (collision.gameObject.tag == "Collectible")
        {
            Collectible collectible = collision.gameObject.GetComponent<Collectible>();
            Debug.Log("Collectible detected");

            //add counter to player collectibles

            Add_collectible();
            OnCollect?.Invoke(Get_collectible_count());
            //play sound

            Destroy(collision.gameObject);
        }
    }


}
