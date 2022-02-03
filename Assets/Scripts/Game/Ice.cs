using UnityEngine;

public class Ice : MonoBehaviour
{
    [SerializeField] private Sprite[] _IceStepSprites;
    [SerializeField] private int _health;

    private SpriteRenderer _sr;

    private int _indexSprite;

    public delegate void DestroyAction();
    public static DestroyAction DestroyEvent;

    public delegate void ParticleAction(Vector2 position);
    public static ParticleAction ParticleEvent;

    private void Start()
    {
        _sr = GetComponent<SpriteRenderer>();
    }

    private void OnMouseDown()
    {
        if (Time.timeScale == 0)
        {
            return;
        }

        _health--;
        NextSprite();

        if (_health == 0)
        {
            if (DestroyEvent != null)
            {
                DestroyEvent();
            }

            if (ParticleEvent != null)
            {
                ParticleEvent(transform.position);
            }
            

            Destroy(gameObject);
        }
    }

    private void NextSprite()
    {
        if (_indexSprite + 1 >= _IceStepSprites.Length)
        {
            return;
        }

        _indexSprite++;
        _sr.sprite = _IceStepSprites[_indexSprite];        
    }
}
