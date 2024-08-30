using UnityEngine;

public class Collectible : MonoBehaviour
{
    [SerializeField] public Sprite collectible_sprite;
    [SerializeField] public int collectible_value;
    [SerializeField] public string collectible_name;
    SpriteRenderer sr;
    public Vector2 position;

    // Start is called before the first frame update
    void Start()
    {
        sr = GetComponent<SpriteRenderer>();
        sr.sprite = collectible_sprite;
    }



    // Update is called once per frame
    void Update()
    {

    }
}
