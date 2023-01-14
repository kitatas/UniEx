using UnityEngine;

namespace UniEx.Sample
{
    public sealed class Sample : MonoBehaviour
    {
        [SerializeField] private Transform[] transforms;
        private float _time;
        private int _frame;
        private int _index;

        private void Start()
        {
            // InitDelay();
        }

        private void InitDelay()
        {
            this.Delay(1.0f, () =>
            {
                // Debug.Log("delay!!");
            });

            this.DelayFrame(60, () =>
            {
                // Debug.Log("delay frame!!");
            });
        }

        private void Update()
        {
            // CheckDelay();
            Tick();
        }

        private void CheckDelay()
        {
            Debug.Log($"time: {_time}");
            Debug.Log($"frame: {_frame}");

            _time += Time.deltaTime;
            _frame++;
        }

        private void Tick()
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                _index.RepeatIncrement(0, transforms.GetLastIndex());
            }

            var h = Input.GetAxisRaw("Horizontal");
            transforms[_index]
                .TranslateX(h * Time.deltaTime)
                .ClampPositionX(-2.5f, 2.5f);
        }
    }
}