using UnityEngine;


public class RollDice : MonoBehaviour
{
    private Rigidbody _rigidbody;
    private bool _isThrown;
    private bool _isLanded;
    private Transform _startPosition;


    private void Start()
    {
        _rigidbody = GetComponent<Rigidbody>();
        _rigidbody.useGravity = false;
        //_startPosition.position = transform.position;
    }

    private void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            Thrown();
        }
    }

    private void Thrown()
    {
        if(!_isThrown && !_isLanded)
        {
            //_rigidbody.useGravity = true;
            _isThrown = true;
            _rigidbody.AddTorque(Random.Range(0, 5000), Random.Range(0, 5000), Random.Range(0, 5000), ForceMode.Force);
            
        }
        
    }
}
