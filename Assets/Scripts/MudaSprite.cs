using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; // Namespace para utilizar a biblioteca UI da Unity

public class MudaSprite : MonoBehaviour
{
    public Sprite Sprite1;
    public Sprite Sprite2;
    public Sprite Sprite3;
    private SpriteRenderer renderSprite; //Varipavel privada do tipo SpriteRenderer, que o objeto 2D possui.
    public string Race;

    void Start ()
    {
        renderSprite = GetComponent<SpriteRenderer>(); //Atribui a variável renderSprite o componente de SpriteRenderer presente no objeto 2D, na inicialização da cena.
        SelectSprite();
    }
 
    public void SelectSprite()
    {
        if(Race == "Terraqueo") {
            renderSprite.sprite = Sprite1;
        } else if (Race == "Marciano") {
            renderSprite.sprite = Sprite2;
        } else {
            renderSprite.sprite = Sprite3;
        }
    }
}
