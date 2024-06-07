using Assets.project.Scripts.UIComponents;
using System.Collections.Generic;
using UnityEngine;

namespace Assets.project.Scripts.MVP.Views
{
    public class Safe : MonoBehaviour
    {
        [SerializeField] private List<Number> _numbers;

        private int _code = 3689;

        public void Open()
        {
            string userCode = "";

            foreach (var number in _numbers)
            {
                userCode += number.NumberValue.ToString();
            }

            if(int.Parse(userCode) == _code)
            {
                gameObject.SetActive(false);
            }
        }
    }
}
