using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oktaavid
{
public class Octaves
{

    private const double _oneConst = 0.50;
    private const double _twoConst = 0.56;
    private const double _threeConst = 0.63;
    private const double _fourConst = 0.71;
    private const double _fiveConst = 0.80;
    private const double _sixConst = 0.90;
    private const double _sevenConst = 1.00;
    private const double _eightConst = 1.00;
    private const double _nineConst = 1.00;
    private const double _tenConst = 1.00;
    private const double _elevenConst = 0.80;
    private const double _twelveConst = 0.63;
    private const double _thirteenConst = 0.50;
    private const double _fourteenConst = 0.40;
    private const double _fifteenConst = 0.315;
    private const double _sixteenConst = 0.25;
    private const double _seventeenConst = 0.20;
    private const double _eighteenConst = 0.16;
    private const double _nineteenConst = 0.125;
    private const double _twentyConst = 0.10;

    public double OneConst
    {
        get
        {
            return _oneConst;
        }
    }
    public double TwoConst
    {
        get
        {
            return _twoConst;
        }
    }
    public double ThreeConst
    {
        get
        {
            return _threeConst;
        }
    }
    public double FourConst
    {
        get
        {
            return _fourConst;
        }
    }
    public double FiveConst
    {
        get
        {
            return _fiveConst;
        }
    }
    public double SixConst
    {
        get
        {
            return _sixConst;
        }
    }
    public double SevenConst
    {
        get
        {
            return _sevenConst;
        }
    }
    public double EightConst
    {
        get
        {
            return _eightConst;
        }
    }
    public double NineConst
    {
        get
        {
            return _nineConst;
        }
    }
    public double TenConst
    {
        get
        {
            return _tenConst;
        }
    }
    public double ElevenConst
    {
        get
        {
            return _elevenConst;
        }
    }
    public double TwelveConst
    {
        get
        {
            return _twelveConst;
        }
    }
    public double ThirteenConst
    {
        get
        {
            return _thirteenConst;
        }
    }
    public double FourteenConst
    {
        get
        {
            return _fourteenConst;
        }
    }
    public double FifteenConst
    {
        get
        {
            return _fifteenConst;
        }
    }
    public double SixteenConst
    {
        get
        {
            return _sixteenConst;
        }
    }
    public double SeventeenConst
    {
        get
        {
            return _seventeenConst;
        }
    }
    public double EighteenConst
    {
        get
        {
            return _eighteenConst;
        }
    }
    public double NineteenConst
    {
        get
        {
            return _nineteenConst;
        }
    }
    public double TwentyConst
    {
        get
        {
            return _twentyConst;
        }
    }

    private double _oneOctaveResult;
    private double _twoOctaveResult;
    private double _threeOctaveResult;
    private double _fourOctaveResult;
    private double _fiveOctaveResult;
    private double _sixOctaveResult;
    private double _sevenOctaveResult;
    private double _eightOctaveResult;
    private double _nineOctaveResult;
    private double _tenOctaveResult;
    private double _elevenOctaveResult;
    private double _twelveOctaveResult;
    private double _thirteenOctaveResult;
    private double _fourteenOctaveResult;
    private double _fifteenOctaveResult;
    private double _sixteenOctaveResult;
    private double _seventeenOctaveResult;
    private double _eighteenOctaveResult;
    private double _nineteenOctaveResult;
    private double _twentyOctaveResult;


    public double OctaveOneM(double VarOne)
    {
        _oneOctaveResult = Math.Pow(VarOne * _oneConst, 2);
        return _oneOctaveResult;
    }
    public double OctaveTwoM(double VarTwo)
    {
        _twoOctaveResult = Math.Pow(VarTwo * _twoConst, 2);
        return _twoOctaveResult;
    }
    public double OctaveThreeM(double VarThree)
    {
        _threeOctaveResult = Math.Pow(VarThree * _threeConst, 2);
        return _threeOctaveResult;
    }
    public double OctaveFourM(double VarFour)
    {
        _fourOctaveResult = Math.Pow(VarFour * _fourConst, 2);
        return _fourOctaveResult;
    }
    public double OctaveFiveM(double VarFive)
    {
        _fiveOctaveResult = Math.Pow(VarFive * _fiveConst, 2);
        return _fiveOctaveResult;
    }
    public double OctaveSixM(double VarSix)
    {
        _sixOctaveResult = Math.Pow(VarSix * _sixConst, 2);
        return _sixOctaveResult;
    }
    public double OctaveSevenM(double VarSeven)
    {
        _sevenOctaveResult = Math.Pow(VarSeven * _sevenConst, 2);
        return _sevenOctaveResult;
    }
    public double OctaveEightM(double VarEight)
    {
        _eightOctaveResult = Math.Pow(VarEight * _eightConst, 2);
        return _eightOctaveResult;
    }
    public double OctaveNineM(double VarNine)
    {
        _nineOctaveResult = Math.Pow(VarNine * _nineConst, 2);
        return _nineOctaveResult;
    }
    public double OctaveTenM(double VarTen)
    {
        _tenOctaveResult = Math.Pow(VarTen * _tenConst, 2);
        return _tenOctaveResult;
    }
    public double OctaveElevenM(double VarEleven)
    {
        _elevenOctaveResult = Math.Pow(VarEleven * _elevenConst, 2);
        return _elevenOctaveResult;
    }
    public double OctaveTwelveM(double VarTwelve)
    {
        _twelveOctaveResult = Math.Pow(VarTwelve * _twelveConst, 2);
        return _twelveOctaveResult;
    }
    public double OctaveThirteenM(double VarThirteen)
    {
        _thirteenOctaveResult = Math.Pow(VarThirteen * _thirteenConst, 2);
        return _thirteenOctaveResult;
    }
    public double OctaveFourteenM(double VarFourteen)
    {
        _fourteenOctaveResult = Math.Pow(VarFourteen * _fourteenConst, 2);
        return _fourteenOctaveResult;
    }
    public double OctaveFifteenM(double VarFifteen)
    {
        _fifteenOctaveResult = Math.Pow(VarFifteen * _fifteenConst, 2);
        return _fifteenOctaveResult;
    }
    public double OctaveSixteenM(double VarSixteen)
    {
        _sixteenOctaveResult = Math.Pow(VarSixteen * _sixteenConst, 2);
        return _sixteenOctaveResult;
    }
    public double OctaveSeventeenM(double VarSeventeen)
    {
        _seventeenOctaveResult = Math.Pow(VarSeventeen * _seventeenConst, 2);
        return _seventeenOctaveResult;
    }
    public double OctaveEighteenM(double VarEighteen)
    {
        _eighteenOctaveResult = Math.Pow(VarEighteen * _eighteenConst, 2);
        return _eighteenOctaveResult;
    }
    public double OctaveNineteenM(double VarNineteen)
    {
        _nineteenOctaveResult = Math.Pow(VarNineteen * _nineteenConst, 2);
        return _nineteenOctaveResult;
    }
    public double OctaveTwentyM(double VarTwenty)
    {
        _twentyOctaveResult = Math.Pow(VarTwenty * _twentyConst, 2);
        return _twentyOctaveResult;
    }

    public double ResultSumM()
    {
        double resultSum;
        resultSum =
            _oneOctaveResult +
            _twoOctaveResult +
            _threeOctaveResult +
            _fourOctaveResult +
            _fiveOctaveResult +
            _sixOctaveResult +
            _sevenOctaveResult +
            _eightOctaveResult +
            _nineOctaveResult +
            _tenOctaveResult +
            _elevenOctaveResult +
            _twelveOctaveResult +
            _thirteenOctaveResult +
            _fourteenOctaveResult +
            _fifteenOctaveResult +
            _sixteenOctaveResult +
            _seventeenOctaveResult +
            _eighteenOctaveResult +
            _nineteenOctaveResult +
            _twentyOctaveResult;

        return Math.Round(Math.Sqrt(resultSum), 1);
    }
}
}
