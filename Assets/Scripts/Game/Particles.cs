using UnityEngine;

public class Particles : MonoBehaviour
{
    [SerializeField] private Transform _parentTransform;
    [SerializeField] private ParticleSystem _particlePrefab;

    private void OnEnable()
    {
        Ice.ParticleEvent += CreateParticle;
    }

    private void OnDisable()
    {
        Ice.ParticleEvent -= CreateParticle;
    }

    private void CreateParticle(Vector2 position)
    {
        
         Instantiate(_particlePrefab, position, Quaternion.identity, _parentTransform);
          
    }
}
