namespace OpenCnC.Net.Math;

public record struct Degrees(float Value)
{
    public Radians ToRadians() => new(Value * Constants.Pi / 180F);
}
