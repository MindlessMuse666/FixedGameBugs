using UnityEngine;
public class Wall : MonoBehaviour
{
    [SerializeField]
    private Detector _detector;
    [SerializeField] 
    private Vector3 _targetPosition = new(0, 0, 0f);

    private void Start()
    {
        _detector = FindObjectOfType<Detector>();
        _detector.CoinDetected += ChangePosition;
    }

    private void ChangePosition()
    {
        transform.position = _targetPosition;
    }
}