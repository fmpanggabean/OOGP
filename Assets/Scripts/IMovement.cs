internal interface IMovement
{
    void SetDirection(float direction);
    void UpdatePosition();
    void RotationUpdate(float direction);
}