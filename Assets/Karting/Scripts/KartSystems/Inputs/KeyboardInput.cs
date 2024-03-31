using UnityEngine;
using UnityEngine.PlayerLoop;

namespace KartGame.KartSystems {

    public class KeyboardInput : BaseInput
    {
        [SerializeField] GameObject kart;

        public string TurnInputName = "Horizontal";
        public string AccelerateButtonName = "Accelerate";
        public string BrakeButtonName = "Brake";

        public override InputData GenerateInput() {
            return new InputData
            {
                Accelerate = Input.GetButton(AccelerateButtonName),
                Brake = Input.GetButton(BrakeButtonName),
                TurnInput = Input.GetAxis(TurnInputName),
            };
        }
    }
}
