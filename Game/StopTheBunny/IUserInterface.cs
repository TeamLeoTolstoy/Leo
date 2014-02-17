using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StopTheBunny
{
    public interface IUserInterface
    {

        event EventHandler OnLeftArrow;

        event EventHandler OnRightArrow;

        event EventHandler OnActionPressed;

        void ProcessInput();

    }
}
