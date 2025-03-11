namespace OpenCnC.Net.Math;

public class Degrees(float value)
{
    // Keep between 0 and 360
    private readonly float _value = (value % 360 + 360) % 360;

    public static Degrees Zero => new(0F);

    public static Degrees PerRadian => new(180F / Constants.Pi);

    public Radians ToRadians() => _value * Radians.PerDegree;

    public override string ToString()
    {
        var degrees = (int)_value;
        var minutes = (int)((_value - degrees) * 60);
        var seconds = (_value - degrees - minutes / 60F) * 3600;
        return $"{degrees}.{minutes:00}'{seconds:F2}\"";
    }

    public static Degrees operator +(Degrees lhs, Degrees rhs) => new(lhs._value + rhs._value);

    public static Degrees operator -(Degrees lhs, Degrees rhs) => new(lhs._value - rhs._value);

    public static Degrees operator *(Degrees lhs, float rhs) => new(lhs._value * rhs);

    public static Degrees operator *(float lhs, Degrees rhs) => new(lhs * rhs._value);

    public static Degrees operator /(Degrees lhs, float rhs) => new(lhs._value / rhs);

    public static Degrees operator /(float lhs, Degrees rhs) => new(lhs / rhs._value);

    public static implicit operator Degrees(float value) => new(value);
}
