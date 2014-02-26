namespace StopTheBunny
{
    using System;

    public interface IUserInterface
    {
        event EventHandler OnLeftPressed;

        event EventHandler OnRightPressed;

        event EventHandler OnUpPressed;

        event EventHandler OnDownPressed;

        event EventHandler OnBuildPressed;

        event EventHandler OnUpgradePressed;

        void ProcessInput();
    }
}
