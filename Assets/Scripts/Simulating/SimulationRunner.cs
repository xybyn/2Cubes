using UnityEngine;

public class SimulationRunner : MonoBehaviour
{
    public Simulating[] simulating;

    private float _timer = 0.0f;
    private bool _started = false;
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            foreach (var item in simulating)
            {
                item.StartSimulation();
                _started = true;
            }
        }

        if (_started)
        {
            _timer+=Time.deltaTime;

            foreach (var item in simulating)
            {
                item.UpdateSimulation(_timer);
            }
        }
    }

    public void OnGameOver(GameOverStates state)
    {
        foreach (var item in simulating)
        {
            item.EndSimulation();
        }
        _started = false;
    }
}
