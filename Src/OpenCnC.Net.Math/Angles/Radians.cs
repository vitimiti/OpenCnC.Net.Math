namespace OpenCnC.Net.Math.Angles;

public class Radians(float value)
{
    // Keep between 0 and 2 * Pi
    private readonly float _value = value % (2 * Constants.Pi);

    public static Radians Zero => new(0F);

    public static Radians PerDegree => new(Constants.Pi / 180F);

    public Degrees ToDegrees() => _value * Degrees.PerRadian;

    public override string ToString() => $"{_value:F2}rad";

    public static Radians operator +(Radians lhs, Radians rhs) => new(lhs._value + rhs._value);

    public static Radians operator -(Radians lhs, Radians rhs) => new(lhs._value - rhs._value);

    public static Radians operator *(Radians lhs, float rhs) => new(lhs._value * rhs);

    public static Radians operator *(float lhs, Radians rhs) => new(lhs * rhs._value);

    public static Radians operator /(Radians lhs, float rhs) => new(lhs._value / rhs);

    public static Radians operator /(float lhs, Radians rhs) => new(lhs / rhs._value);
}
