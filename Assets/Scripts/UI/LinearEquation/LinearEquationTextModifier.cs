using TMPro;
using UnityEngine;

namespace UI.LinearEquation
{
    [RequireComponent(typeof(TMP_Text))]
    public class LinearEquationTextModifier : MonoBehaviour
    {
        private const string EquationFormat = "y = {0}x + {1}";
        
        [Header("Variables")]
        [SerializeField] private float startAVariable;
        [SerializeField] private float startBVariable;
        
        private TMP_Text _text;
        private float _aVariable;
        private float _bVariable;
        
        /// <summary>
        /// Change the A, aka slope or steepness, variable of the equation
        /// </summary>
        public float AVariable
        {
            get => _aVariable;
            set
            {
                _text.text = string.Format(EquationFormat, value, _bVariable);
                _aVariable = value;
            }
        }

        /// <summary>
        /// Change the B, aka y-intercept or height, variable of the equation
        /// </summary>
        public float BVariable
        {
            get => _bVariable;
            set
            {
                _text.text = string.Format(EquationFormat, _aVariable, value);
                _bVariable = value;
            }
        }

        private void Awake()
        {
            _text = GetComponent<TMP_Text>();
        }
        
        private void Start()
        {
            AVariable = startAVariable;
            BVariable = startBVariable;
        }
    }
}