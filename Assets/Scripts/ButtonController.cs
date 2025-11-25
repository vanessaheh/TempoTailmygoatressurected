using UnityEngine;

public class NewEmptyCSharpScript
{
    private SpriteRenderer theSR;
    public Sprite defaultImage;
    public Sprite pressedImage;

    public KeyCode keytoPress;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        theSR = GetComponent<SpriteRenderer>();

        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(keytoPress))  
        {
            theSR.sprite = pressedImage;
        }
        
        if(Input.GetKeyUp(keytoPress))
        {
            theSR.sprite = defaultImage;
        }
    }
}
