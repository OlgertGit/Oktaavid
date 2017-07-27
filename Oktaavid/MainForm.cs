using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Oktaavid
{
public partial class MainForm : Form
{
    Octaves _octaves = new Octaves();

    public MainForm()
    {
        InitializeComponent();
        tb_VarOne.TextChanged += Tb_VarOne_TextChanged;
        tb_VarTwo.TextChanged += Tb_VarTwo_TextChanged;
        tb_VarThree.TextChanged += Tb_VarThree_TextChanged;
        tb_VarFour.TextChanged += Tb_VarFour_TextChanged;
        tb_VarFive.TextChanged += Tb_VarFive_TextChanged;
        tb_VarSix.TextChanged += Tb_VarSix_TextChanged;
        tb_VarSeven.TextChanged += Tb_VarSeven_TextChanged;
        tb_VarEight.TextChanged += Tb_VarEight_TextChanged;
        tb_VarNine.TextChanged += Tb_VarNine_TextChanged;
        tb_VarTen.TextChanged += Tb_VarTen_TextChanged;
        tb_VarEleven.TextChanged += Tb_VarEleven_TextChanged;
        tb_VarTwelve.TextChanged += Tb_VarTwelve_TextChanged;
        tb_VarThirteen.TextChanged += Tb_VarThirteen_TextChanged;
        tb_VarFourteen.TextChanged += Tb_VarFourteen_TextChanged;
        tb_VarFifteen.TextChanged += Tb_VarFifteen_TextChanged;
        tb_VarSixteen.TextChanged += Tb_VarSixteen_TextChanged;
        tb_VarSeventeen.TextChanged += Tb_VarSeventeen_TextChanged;
        tb_VarEighteen.TextChanged += Tb_VarEighteen_TextChanged;
        tb_VarNineteen.TextChanged += Tb_VarNineteen_TextChanged;
        tb_VarTwenty.TextChanged += Tb_VarTwenty_TextChanged;
        btn_Clear.Click += Btn_Clear_Click;
        Load += MainForm_Load;
    }

    private void MainForm_Load(object sender, EventArgs e)
    {
        lbl_OneConst.Text = "x " + _octaves.OneConst.ToString() + " =";
        lbl_TwoConst.Text = "x " + _octaves.TwoConst.ToString() + " =";
        lbl_ThreeConst.Text = "x " + _octaves.ThreeConst.ToString() + " =";
        lbl_FourConst.Text = "x " + _octaves.FourConst.ToString() + " =";
        lbl_FiveConst.Text = "x " + _octaves.FiveConst.ToString() + " =";
        lbl_SixConst.Text = "x " + _octaves.SixConst.ToString() + " =";
        lbl_SevenConst.Text = "x " + _octaves.SevenConst.ToString() + " =";
        lbl_EightConst.Text = "x " + _octaves.EightConst.ToString() + " =";
        lbl_NineConst.Text = "x " + _octaves.NineConst.ToString() + " =";
        lbl_TenConst.Text = "x " + _octaves.TenConst.ToString() + " =";
        lbl_ElevenConst.Text = "x " + _octaves.ElevenConst.ToString() + " =";
        lbl_TwelveConst.Text = "x " + _octaves.TwelveConst.ToString() + " =";
        lbl_ThirteenConst.Text = "x " + _octaves.ThirteenConst.ToString() + " =";
        lbl_FourteenConst.Text = "x " + _octaves.FourteenConst.ToString() + " =";
        lbl_FifteenConst.Text = "x " + _octaves.FifteenConst.ToString() + " =";
        lbl_SixteenConst.Text = "x " + _octaves.SixteenConst.ToString() + " =";
        lbl_SeventeenConst.Text = "x " + _octaves.SeventeenConst.ToString() + " =";
        lbl_EighteenConst.Text = "x " + _octaves.EighteenConst.ToString() + " =";
        lbl_NineteenConst.Text = "x " + _octaves.NineteenConst.ToString() + " =";
        lbl_TwentyConst.Text = "x " + _octaves.TwentyConst.ToString() + " =";
    }

    private void Btn_Clear_Click(object sender, EventArgs e)
    {
        tb_VarOne.Text = string.Empty;
        tb_VarTwo.Text = string.Empty;
        tb_VarThree.Text = string.Empty;
        tb_VarFour.Text = string.Empty;
        tb_VarFive.Text = string.Empty;
        tb_VarSix.Text = string.Empty;
        tb_VarSeven.Text = string.Empty;
        tb_VarEight.Text = string.Empty;
        tb_VarNine.Text = string.Empty;
        tb_VarTen.Text = string.Empty;
        tb_VarEleven.Text = string.Empty;
        tb_VarTwelve.Text = string.Empty;
        tb_VarThirteen.Text = string.Empty;
        tb_VarFourteen.Text = string.Empty;
        tb_VarFifteen.Text = string.Empty;
        tb_VarSixteen.Text = string.Empty;
        tb_VarSeventeen.Text = string.Empty;
        tb_VarEighteen.Text = string.Empty;
        tb_VarNineteen.Text = string.Empty;
        tb_VarTwenty.Text = string.Empty;
    }

    private void Sum()
    {
        lbl_ResultSum.Text = _octaves.ResultSumM().ToString();
    }

    private void Tb_VarTwenty_TextChanged(object sender, EventArgs e)
    {
        try
        {
            double VarTwenty = double.Parse(tb_VarTwenty.Text);
            lbl_TwentyOctaveResult.Text = _octaves.OctaveTwentyM(VarTwenty).ToString();
            Sum();
        }
        catch (Exception)
        {
            lbl_TwentyOctaveResult.Text = _octaves.OctaveTwentyM(0).ToString();
            Sum();
        }
    }

    private void Tb_VarNineteen_TextChanged(object sender, EventArgs e)
    {
        try
        {
            double VarNineteen = double.Parse(tb_VarNineteen.Text);
            lbl_NineteenOctaveResult.Text = _octaves.OctaveNineteenM(VarNineteen).ToString();
            Sum();
        }
        catch (Exception)
        {
            lbl_NineteenOctaveResult.Text = _octaves.OctaveNineteenM(0).ToString();
            Sum();
        }
    }

    private void Tb_VarEighteen_TextChanged(object sender, EventArgs e)
    {
        try
        {
            double VarEighteen = double.Parse(tb_VarEighteen.Text);
            lbl_EighteenOctaveResult.Text = _octaves.OctaveEighteenM(VarEighteen).ToString();
            Sum();
        }
        catch (Exception)
        {
            lbl_EighteenOctaveResult.Text = _octaves.OctaveEighteenM(0).ToString();
            Sum();
        }
    }

    private void Tb_VarSeventeen_TextChanged(object sender, EventArgs e)
    {
        try
        {
            double VarSeventeen = double.Parse(tb_VarSeventeen.Text);
            lbl_SeventeenOctaveResult.Text = _octaves.OctaveSeventeenM(VarSeventeen).ToString();
            Sum();
        }
        catch (Exception)
        {
            lbl_SeventeenOctaveResult.Text = _octaves.OctaveSeventeenM(0).ToString();
            Sum();
        }
    }

    private void Tb_VarSixteen_TextChanged(object sender, EventArgs e)
    {
        try
        {
            double VarSixteen = double.Parse(tb_VarSixteen.Text);
            lbl_SixteenOctaveResult.Text = _octaves.OctaveSixteenM(VarSixteen).ToString();
            Sum();
        }
        catch (Exception)
        {
            lbl_SixteenOctaveResult.Text = _octaves.OctaveSixteenM(0).ToString();
            Sum();
        }
    }

    private void Tb_VarFifteen_TextChanged(object sender, EventArgs e)
    {
        try
        {
            double VarFifteen = double.Parse(tb_VarFifteen.Text);
            lbl_FifteenOctaveResult.Text = _octaves.OctaveFifteenM(VarFifteen).ToString();
            Sum();
        }
        catch (Exception)
        {
            lbl_FifteenOctaveResult.Text = _octaves.OctaveFifteenM(0).ToString();
            Sum();
        }
    }

    private void Tb_VarFourteen_TextChanged(object sender, EventArgs e)
    {
        try
        {
            double VarFourteen = double.Parse(tb_VarFourteen.Text);
            lbl_FourteenOctaveResult.Text = _octaves.OctaveFourteenM(VarFourteen).ToString();
            Sum();
        }
        catch (Exception)
        {
            lbl_FourteenOctaveResult.Text = _octaves.OctaveFourteenM(0).ToString();
            Sum();
        }
    }

    private void Tb_VarThirteen_TextChanged(object sender, EventArgs e)
    {
        try
        {
            double VarThirteen = double.Parse(tb_VarThirteen.Text);
            lbl_ThirteenOctaveResult.Text = _octaves.OctaveThirteenM(VarThirteen).ToString();
            Sum();
        }
        catch (Exception)
        {
            lbl_ThirteenOctaveResult.Text = _octaves.OctaveThirteenM(0).ToString();
            Sum();
        }
    }

    private void Tb_VarTwelve_TextChanged(object sender, EventArgs e)
    {
        try
        {
            double VarTwelve = double.Parse(tb_VarTwelve.Text);
            lbl_TwelveOctaveResult.Text = _octaves.OctaveTwelveM(VarTwelve).ToString();
            Sum();
        }
        catch (Exception)
        {
            lbl_TwelveOctaveResult.Text = _octaves.OctaveTwelveM(0).ToString();
            Sum();
        }
    }

    private void Tb_VarEleven_TextChanged(object sender, EventArgs e)
    {
        try
        {
            double VarEleven = double.Parse(tb_VarEleven.Text);
            lbl_ElevenOctaveResult.Text = _octaves.OctaveElevenM(VarEleven).ToString();
            Sum();
        }
        catch (Exception)
        {
            lbl_ElevenOctaveResult.Text = _octaves.OctaveElevenM(0).ToString();
            Sum();
        }
    }

    private void Tb_VarTen_TextChanged(object sender, EventArgs e)
    {
        try
        {
            double VarTen = double.Parse(tb_VarTen.Text);
            lbl_TenOctaveResult.Text = _octaves.OctaveTenM(VarTen).ToString();
            Sum();
        }
        catch (Exception)
        {
            lbl_TenOctaveResult.Text = _octaves.OctaveTenM(0).ToString();
            Sum();
        }
    }

    private void Tb_VarNine_TextChanged(object sender, EventArgs e)
    {
        try
        {
            double VarNine = double.Parse(tb_VarNine.Text);
            lbl_NineOctaveResult.Text = _octaves.OctaveNineM(VarNine).ToString();
            Sum();
        }
        catch (Exception)
        {
            lbl_NineOctaveResult.Text = _octaves.OctaveNineM(0).ToString();
            Sum();
        }
    }

    private void Tb_VarEight_TextChanged(object sender, EventArgs e)
    {
        try
        {
            double VarEight = double.Parse(tb_VarEight.Text);
            lbl_EightOctaveResult.Text = _octaves.OctaveEightM(VarEight).ToString();
            Sum();
        }
        catch (Exception)
        {
            lbl_EightOctaveResult.Text = _octaves.OctaveEightM(0).ToString();
            Sum();
        }
    }

    private void Tb_VarSeven_TextChanged(object sender, EventArgs e)
    {
        try
        {
            double VarSeven = double.Parse(tb_VarSeven.Text);
            lbl_SevenOctaveResult.Text = _octaves.OctaveSevenM(VarSeven).ToString();
            Sum();
        }
        catch (Exception)
        {
            lbl_SevenOctaveResult.Text = _octaves.OctaveSevenM(0).ToString();
            Sum();
        }
    }

    private void Tb_VarSix_TextChanged(object sender, EventArgs e)
    {
        try
        {
            double VarSix = double.Parse(tb_VarSix.Text);
            lbl_SixOctaveResult.Text = _octaves.OctaveSixM(VarSix).ToString();
            Sum();
        }
        catch (Exception)
        {
            lbl_SixOctaveResult.Text = _octaves.OctaveSixM(0).ToString();
            Sum();
        }
    }

    private void Tb_VarFive_TextChanged(object sender, EventArgs e)
    {
        try
        {
            double VarFive = double.Parse(tb_VarFive.Text);
            lbl_FiveOctaveResult.Text = _octaves.OctaveFiveM(VarFive).ToString();
            Sum();
        }
        catch (Exception)
        {
            lbl_FiveOctaveResult.Text = _octaves.OctaveFiveM(0).ToString();
            Sum();
        }
    }

    private void Tb_VarFour_TextChanged(object sender, EventArgs e)
    {
        try
        {
            double VarFour = double.Parse(tb_VarFour.Text);
            lbl_FourOctaveResult.Text = _octaves.OctaveFourM(VarFour).ToString();
            Sum();
        }
        catch (Exception)
        {
            lbl_FourOctaveResult.Text = _octaves.OctaveFourM(0).ToString();
            Sum();
        }
    }

    private void Tb_VarThree_TextChanged(object sender, EventArgs e)
    {
        try
        {
            double VarThree = double.Parse(tb_VarThree.Text);
            lbl_ThreeOctaveResult.Text = _octaves.OctaveThreeM(VarThree).ToString();
            Sum();
        }
        catch (Exception)
        {
            lbl_ThreeOctaveResult.Text = _octaves.OctaveThreeM(0).ToString();
            Sum();
        }
    }

    private void Tb_VarTwo_TextChanged(object sender, EventArgs e)
    {
        try
        {
            double VarTwo = double.Parse(tb_VarTwo.Text);
            lbl_TwoOctaveResult.Text = _octaves.OctaveTwoM(VarTwo).ToString();
            Sum();
        }
        catch (Exception)
        {
            lbl_TwoOctaveResult.Text = _octaves.OctaveTwoM(0).ToString();
            Sum();
        }
    }

    private void Tb_VarOne_TextChanged(object sender, EventArgs e)
    {
        try
        {
            double VarOne = double.Parse(tb_VarOne.Text);
            lbl_OneOctaveResult.Text = _octaves.OctaveOneM(VarOne).ToString();
            Sum();
        }
        catch (Exception)
        {
            lbl_OneOctaveResult.Text = _octaves.OctaveOneM(0).ToString();
            Sum();
        }
    }
}
}
