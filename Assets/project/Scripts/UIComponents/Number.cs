using Assets.project.Scripts.Common;
using UnityEngine;
using UnityEngine.UI;

namespace Assets.project.Scripts.UIComponents
{
    public class Number : MonoBehaviour
    {
        [SerializeField] private Image _imageNumber;

        private int _number = 0;

        public int NumberValue { get => _number; }

        public void Up()
        {
            _number += 1;
            if (_number > 9)
                _number = 0;

            ImageLoader.LoadUIImage(_number.ToString());
        }

        public void Down() 
        {
            _number -= 1;
            if (_number < 0)
                _number = 9;

            ImageLoader.LoadUIImage(_number.ToString());
        }
    }
}
