[UnityEngine.CreateAssetMenu(fileName = "Maths", menuName = "ScriptableObjects/Maths", order = 2)]

public class Maths : UnityEngine.ScriptableObject
{
    public double CalcR500(int fl, float cf)
    {
        double result;
        return result = System.Math.Round(500 / (fl * cf), 3);
    }

    public double CalcR300(int fl, float cf)
    {
        double result;
        return result = System.Math.Round(300 / (fl * cf), 3);
    }

    public double CalcNPFs(int fl, float ap, float pp)
    {
        double result;
        return result = System.Math.Round((35 * ap + 30 * pp) / fl, 3);
    }

    public double CalcNPF(int fl, float ap, float cf, float pp, double dec, int p)
    {
        dec = dec * (System.Math.PI / 180);
        double result;
        return result = System.Math.Round(p * ((16.856 * ap + 0.0997 * fl + 13.713 * pp) / ((fl * (System.Math.Cos(dec))))), 3);
    }

    public double CalcFovWidth(double sensorWidth, int fl)
    {
        double result;
        return result = System.Math.Round((2 * System.Math.Atan(sensorWidth / (2 * fl))) * (180 / System.Math.PI), 3);
    }

    public double CalcFovHeight(double sensorHeight, int fl)
    {
        double result;
        return result = System.Math.Round((2 * System.Math.Atan(sensorHeight / (2 * fl))) * (180 / System.Math.PI), 3);
    }

    public double CalcFovDiagonal(double sensorWidth, double sensorHeight, int fl)
    {
        double diagonal = System.Math.Sqrt(System.Math.Pow(sensorWidth, 2) + System.Math.Pow(sensorHeight, 2));
        double result;
        return result = System.Math.Round((2 * System.Math.Atan(diagonal / (2 * fl))) * (180 / System.Math.PI), 3);
    }
}