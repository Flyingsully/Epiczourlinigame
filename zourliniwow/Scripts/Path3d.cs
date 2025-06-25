using Godot;

public partial class Path3d : PathFollow3D
{
    [Export]
    public float babaishowfast = 5.0f;
    public override void _Process(double delta)
    {
        Path3D path = GetParent<Path3D>();
        Curve3D pathCurve = path.Curve;

        // Ensure the curve is baked
        pathCurve.BakeInterval = 0.1f; // Optional: set bake precision if needed

        float pathLength = pathCurve.GetBakedLength();

        Progress += babaishowfast * (float)delta;

        if (Progress >= pathLength)
        {
            Progress = 0f;
        }
    }
}
