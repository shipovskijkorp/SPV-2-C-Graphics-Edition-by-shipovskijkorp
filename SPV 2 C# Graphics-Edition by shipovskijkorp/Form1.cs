using System;
using System.Drawing;
using System.Windows.Forms;

namespace SPV_2_C__Graphics_Edition_by_shipovskijkorp
{
    public partial class Form1 : Form
    {
        private const int FixedFormWidth = 830;
        private const int FixedFormHeight = 570;

        private const int VolumeButtonX = 12;
        private const int VolumeButtonY2D = 442;

        private const int SettingsClosed = 0;
        private const int SettingsOpened = 1;

        private const int FormulaButtonFirst = 1;
        private const int FormulaButtonSecond = 2;
        private const int FormulaButtonThird = 3;

        private const int FigureSquare = 1;
        private const int FigureRectangle = 2;
        private const int FigureTrapezoid = 3;
        private const int FigureTriangle = 4;
        private const int FigureCircle = 5;
        private const int FigureRhombus = 6;
        private const int FigureParallelogram = 7;

        private const int SolidCube = 101;
        private const int SolidParallelepiped = 102;
        private const int SolidCylinder = 103;
        private const int SolidSphere = 104;
        private const int SolidPyramid = 105;
        private const int SolidCone = 106;

        private const int FirstSolidId = SolidCube;
        private const int LastSolidId = SolidCone;

        private const int Mode2D = 1;
        private const int Mode3D = 2;

        private const int ActionNone = 0;
        private const int ActionArea = 1;
        private const int ActionPerimeter = 2;
        private const int ActionVolume = 3;

        private const int TrapezoidAreaByBasesAndHeight = 1;
        private const int TrapezoidAreaByMidlineAndHeight = 2;
        private const int TrapezoidAreaByDiagonalsAndSin = 3;

        private const int TrapezoidPerimeterByFourSides = 4;
        private const int TrapezoidPerimeterByBasesAndSide = 5;

        private const int TrianglePerimeterBySides = 6;
        private const int TrianglePerimeterByAreaAndInradius = 7;

        private const int TriangleAreaByBaseAndHeight = 8;
        private const int TriangleAreaByHeron = 9;
        private const int TriangleAreaByTwoSidesAndSin = 10;

        private const int CircleAreaByRadius = 11;
        private const int CircleAreaByDiameter = 12;
        private const int CircleAreaByLength = 13;

        private const int CirclePerimeterByRadius = 14;
        private const int CirclePerimeterByDiameter = 15;
        private const int CirclePerimeterByArea = 16;

        private const int RhombusAreaBySideAndHeight = 17;
        private const int RhombusAreaByDiagonals = 18;
        private const int RhombusAreaBySideAndSin = 19;

        private const int RhombusPerimeterBySide = 20;
        private const int RhombusPerimeterByDiagonals = 21;
        private const int RhombusPerimeterByAreaAndHeight = 22;

        private const int ParallelogramAreaBySideAndHeight = 23;
        private const int ParallelogramAreaBySidesAndSin = 24;
        private const int ParallelogramAreaByDiagonalsAndSin = 25;

        private const double Half = 0.5;
        private const double Two = 2.0;
        private const double Three = 3.0;
        private const double Four = 4.0;
        private const double Six = 6.0;
        private const double OneThird = 1.0 / 3.0;
        private const double FourThirds = 4.0 / 3.0;

        public Form1()
        {
            InitializeComponent();

            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimumSize = new Size(FixedFormWidth, FixedFormHeight);
            this.MaximumSize = new Size(FixedFormWidth, FixedFormHeight);
            RUS();
        }

        private int currentAction = ActionNone;

        public int a = 0;
        public double output = 0;

        public int bS = 0;
        public int bP = 0;
        public int bV = 0;

        public int mode = Mode2D;

        string empty;

        string s1, s2, s3, p1, p2, p3, v1, v2, v3, dash;

        string s_trap_1, s_trap_2, s_trap_3, s_trian_1, heron, s_trian_3, s_circle_1, s_circle_2, s_circle_3, s_rhomb_1, s_rhomb_2, s_rhomb_3;

        string p_trap_1, p_trap_2, p_trian_1, p_trian_2, l_circle_1, l_circle_2, l_circle_3, p_rhomb_1, p_rhomb_2, p_rhomb_3;

        string s_cube_1, s_cube_2, s_cube_3, s_par_1, s_par_2, s_cyl_1, s_cyl_2, s_cyl_3, s_sph_1, s_sph_2, s_pyr_1, s_pyr_2, s_pyr_3, s_cone_1, s_cone_2, s_cone_3;

        string v_cube_1, v_cube_2, v_cube_3, v_par_1, v_par_2, v_cyl_1, v_cyl_2, v_cyl_3, v_sph_1, v_sph_2, v_pyr_1, v_pyr_2, v_cone_1, v_cone_2, v_cone_3;

        string base_a, base_b, height_h, midline_m, diagonal_d1, diagonal_d2, sin_phi, side_a, side_b, side_c, sin_gamma, radius_r, diameter_d, length_l, sin_alpha, side_c_trap, side_d_trap, area_s;
        string edge_a, cube_diag_d, base_area_sbase, base_perimeter_pbase, height_c, base_length_l, lateral_area_slateral, base_side_a, apothem_l, slant_l, base_area_s;

        string enter_values_press_sqr, enter_value_press_sqr, enter_values_press_per, enter_value_press_per, enter_values_press_vol;

        string choose_formula_s, choose_formula_p, choose_formula_p12, choose_formula_v, choose_formula_v12;

        string no_s3_for_this_solid, no_s3_for_sphere, no_v3_for_par, no_v3_for_sphere, no_v3_for_pyramid;

        string figure_not_implemented, solid_not_implemented, impossible_triangle, impossible_trapezoid, impossible_cone, invalid_sin_value, value_must_be_gt_0, diagonal_must_be_gt_0;
        string r_cannot_be_0, s_cannot_be_lt_0, h_cannot_be_0, switch_to_spv_mode;

        string square_2d, rectangle_2d, trapezoid_2d, triangle_2d, circle_2d, rhombus_2d;
        string cube_3d, parallelepiped_3d, cylinder_3d, sphere_3d, pyramid_3d, cone_3d;

        string per, squ, vol, res;

        string parallelogram_2d;

        string s_paral_1, s_paral_2, s_paral_3;
        string solvetext;

        string sin_beta;

        string choose_action_first;

        string press_solve;

        private bool Is2DMode() => mode == Mode2D;
        private bool Is3DMode() => mode == Mode3D;
        private bool IsSolidSelected() => a >= FirstSolidId && a <= LastSolidId;

        private void UpdateFigureImage()
        {
            if (!FigImage.Visible)
            {
                return;
            }

            if (mode == Mode2D)
            {
                switch (a)
                {
                    case FigureSquare:
                        FigImage.Image = SP_2_C__Graphics_Edition_by_shipovskijkorp.Properties.Resources.Quad;
                        break;
                    case FigureRectangle:
                        FigImage.Image = SP_2_C__Graphics_Edition_by_shipovskijkorp.Properties.Resources.Rect;
                        break;
                    case FigureTrapezoid:
                        FigImage.Image = SP_2_C__Graphics_Edition_by_shipovskijkorp.Properties.Resources.Trap;
                        break;
                    case FigureTriangle:
                        FigImage.Image = SP_2_C__Graphics_Edition_by_shipovskijkorp.Properties.Resources.Trian;
                        break;
                    case FigureCircle:
                        FigImage.Image = SP_2_C__Graphics_Edition_by_shipovskijkorp.Properties.Resources.Okr;
                        break;
                    case FigureRhombus:
                        FigImage.Image = SP_2_C__Graphics_Edition_by_shipovskijkorp.Properties.Resources.Romb;
                        break;
                    case FigureParallelogram:
                        FigImage.Image = SP_2_C__Graphics_Edition_by_shipovskijkorp.Properties.Resources.Paral;
                        break;
                }

                return;
            }

            if (mode == Mode3D)
            {
                switch (a)
                {
                    case SolidCube:
                        FigImage.Image = SP_2_C__Graphics_Edition_by_shipovskijkorp.Properties.Resources.Qub;
                        break;
                    case SolidParallelepiped:
                        FigImage.Image = SP_2_C__Graphics_Edition_by_shipovskijkorp.Properties.Resources.Par;
                        break;
                    case SolidCylinder:
                        FigImage.Image = SP_2_C__Graphics_Edition_by_shipovskijkorp.Properties.Resources.Cil;
                        break;
                    case SolidSphere:
                        FigImage.Image = SP_2_C__Graphics_Edition_by_shipovskijkorp.Properties.Resources.Sph;
                        break;
                    case SolidPyramid:
                        FigImage.Image = SP_2_C__Graphics_Edition_by_shipovskijkorp.Properties.Resources.Pir;
                        break;
                    case SolidCone:
                        FigImage.Image = SP_2_C__Graphics_Edition_by_shipovskijkorp.Properties.Resources.Kon;
                        break;
                }
            }
        }

        private void HideInputs()
        {
            Text0.Visible = Text1.Visible = Text2.Visible = Text3.Visible = false;
            Input0.Visible = Input1.Visible = Input2.Visible = Input3.Visible = false;
            Output.Visible = ResT.Visible = false;
            Swipe.Visible = false;
        }

        private void ShowInput(Label label, NumericUpDown input, string labelText)
        {
            label.Visible = true;
            input.Visible = true;
            label.Text = labelText;
        }

        private void ShowFirstInput(string labelText)
        {
            ShowInput(Text0, Input0, labelText);
        }

        private void ShowTwoInputs(string firstLabel, string secondLabel)
        {
            ShowInput(Text0, Input0, firstLabel);
            ShowInput(Text1, Input1, secondLabel);
        }

        private void PrepareSingleInputFigure(string labelText)
        {
            HideInputs();
            ShowResult();
            ShowFirstInput(labelText);
        }

        private void PrepareDoubleInputFigure(string firstLabel, string secondLabel)
        {
            HideInputs();
            ShowResult();
            ShowTwoInputs(firstLabel, secondLabel);
        }

        private double GetInputValue(NumericUpDown input) => (double)input.Value;

        private void ShowResult()
        {
            Output.Visible = true;
            ResT.Visible = true;
        }

        private void HideFormulaButtons()
        {
            S1F.Visible = S2F.Visible = S3F.Visible = false;
            P1F.Visible = P2F.Visible = P3F.Visible = false;
            V1F.Visible = V2F.Visible = V3F.Visible = false;
            Swipe.Visible = false;
        }

        private void ResetUI()
        {
            HideInputs();
            HideFormulaButtons();
            currentAction = ActionNone;

            output = 0;
            bS = bP = bV = 0;
            Output.Text = empty;

            Sqr.Visible = false;
            Per.Visible = false;
            Vol.Visible = false;

            FigImage.Visible = false;
        }

        private void ShowBaseForFigure()
        {
            FigImage.Visible = true;

            if (mode == Mode2D)
            {
                Sqr.Visible = true;
                Per.Visible = true;
                Vol.Visible = false;
            }
            else
            {
                Sqr.Visible = true;
                Per.Visible = false;
                Vol.Visible = true;
            }

            UpdateFigureImage();
        }

        private bool ShowValidationError(string message)
        {
            ShowResult();
            Output.Text = message;
            return false;
        }

        private bool ValidatePositive(params double[] values)
        {
            foreach (double value in values)
            {
                if (value <= 0)
                {
                    return ShowValidationError(value_must_be_gt_0);
                }
            }

            return true;
        }

        private bool ValidatePositiveDiagonal(double value)
        {
            if (value <= 0)
            {
                return ShowValidationError(diagonal_must_be_gt_0);
            }

            return true;
        }

        private bool ValidateSinValue(double value)
        {
            if (value <= 0 || value > 1)
            {
                return ShowValidationError(invalid_sin_value);
            }

            return true;
        }

        private bool ValidateTriangle(double x0, double x1, double x2)
        {
            if (!ValidatePositive(x0, x1, x2))
            {
                return false;
            }

            if (x0 + x1 <= x2 || x0 + x2 <= x1 || x1 + x2 <= x0)
            {
                return ShowValidationError(impossible_triangle);
            }

            return true;
        }

        private bool ValidateIsoscelesTrapezoid(double base1, double base2, double side)
        {
            if (!ValidatePositive(base1, base2, side))
            {
                return false;
            }

            if (Two * side <= Math.Abs(base1 - base2))
            {
                return ShowValidationError(impossible_trapezoid);
            }

            return true;
        }

        private bool ValidateTrapezoidByFourSides(double base1, double base2, double side1, double side2)
        {
            if (!ValidatePositive(base1, base2, side1, side2))
            {
                return false;
            }

            double diff = Math.Abs(base1 - base2);

            if (side1 + side2 <= diff || side1 + diff <= side2 || side2 + diff <= side1)
            {
                return ShowValidationError(impossible_trapezoid);
            }

            return true;
        }

        private bool ValidateConeByRadiusAndSlant(double radius, double slant)
        {
            if (!ValidatePositive(radius, slant))
            {
                return false;
            }

            if (slant <= radius)
            {
                return ShowValidationError(impossible_cone);
            }

            return true;
        }

        private bool ValidateConeByDiameterAndSlant(double diameter, double slant)
        {
            if (!ValidatePositive(diameter, slant))
            {
                return false;
            }

            if (slant <= diameter / Two)
            {
                return ShowValidationError(impossible_cone);
            }

            return true;
        }

        private void ConfigureAreaFormulaButtons()
        {
            S1F.Text = s1;
            S2F.Text = s2;
            S3F.Text = s3;

            if (a == FigureTrapezoid)
            {
                S1F.Text = s_trap_1;
                S2F.Text = s_trap_2;
                S3F.Text = s_trap_3;
            }
            else if (a == FigureTriangle)
            {
                S1F.Text = s_trian_1;
                S2F.Text = heron;
                S3F.Text = s_trian_3;
            }
            else if (a == FigureCircle)
            {
                S1F.Text = s_circle_1;
                S2F.Text = s_circle_2;
                S3F.Text = s_circle_3;
            }
            else if (a == FigureRhombus)
            {
                S1F.Text = s_rhomb_1;
                S2F.Text = s_rhomb_2;
                S3F.Text = s_rhomb_3;
            }
            else if (a == FigureParallelogram)
            {
                S1F.Text = s_paral_1;
                S2F.Text = s_paral_2;
                S3F.Text = s_paral_3;
            }
        }

        private void ConfigurePerimeterFormulaButtons()
        {
            P1F.Text = p1;
            P2F.Text = p2;
            P3F.Text = p3;

            if (a == FigureTrapezoid)
            {
                P1F.Text = p_trap_1;
                P2F.Text = p_trap_2;
                P3F.Text = dash;
            }
            else if (a == FigureTriangle)
            {
                P1F.Text = p_trian_1;
                P2F.Text = p_trian_2;
                P3F.Text = dash;
            }
            else if (a == FigureCircle)
            {
                P1F.Text = l_circle_1;
                P2F.Text = l_circle_2;
                P3F.Text = l_circle_3;
            }
            else if (a == FigureRhombus)
            {
                P1F.Text = p_rhomb_1;
                P2F.Text = p_rhomb_2;
                P3F.Text = p_rhomb_3;
            }
        }

        private void ConfigureSolidSurfaceButtons()
        {
            S1F.Text = s1;
            S2F.Text = s2;
            S3F.Text = s3;

            if (a == SolidCube)
            {
                S1F.Text = s_cube_1;
                S2F.Text = s_cube_2;
                S3F.Text = s_cube_3;
            }
            else if (a == SolidParallelepiped)
            {
                S1F.Text = s_par_1;
                S2F.Text = s_par_2;
                S3F.Text = dash;
            }
            else if (a == SolidCylinder)
            {
                S1F.Text = s_cyl_1;
                S2F.Text = s_cyl_2;
                S3F.Text = s_cyl_3;
            }
            else if (a == SolidSphere)
            {
                S1F.Text = s_sph_1;
                S2F.Text = s_sph_2;
                S3F.Text = dash;
            }
            else if (a == SolidPyramid)
            {
                S1F.Text = s_pyr_1;
                S2F.Text = s_pyr_2;
                S3F.Text = s_pyr_3;
            }
            else if (a == SolidCone)
            {
                S1F.Text = s_cone_1;
                S2F.Text = s_cone_2;
                S3F.Text = s_cone_3;
            }
        }

        private void ConfigureVolumeFormulaButtons()
        {
            V1F.Text = v1;
            V2F.Text = v2;
            V3F.Text = v3;

            if (a == SolidCube)
            {
                V1F.Text = v_cube_1;
                V2F.Text = v_cube_2;
                V3F.Text = v_cube_3;
            }
            else if (a == SolidParallelepiped)
            {
                V1F.Text = v_par_1;
                V2F.Text = v_par_2;
                V3F.Text = dash;
            }
            else if (a == SolidCylinder)
            {
                V1F.Text = v_cyl_1;
                V2F.Text = v_cyl_2;
                V3F.Text = v_cyl_3;
            }
            else if (a == SolidSphere)
            {
                V1F.Text = v_sph_1;
                V2F.Text = v_sph_2;
                V3F.Text = dash;
            }
            else if (a == SolidPyramid)
            {
                V1F.Text = v_pyr_1;
                V2F.Text = v_pyr_2;
                V3F.Text = dash;
            }
            else if (a == SolidCone)
            {
                V1F.Text = v_cone_1;
                V2F.Text = v_cone_2;
                V3F.Text = v_cone_3;
            }
        }

        private void SelectTrapezoidAreaFormula(int formula)
        {
            a = FigureTrapezoid;
            bS = formula;
            HideInputs();
            ShowResult();

            Text0.Visible = Input0.Visible = true;
            Text1.Visible = Input1.Visible = true;

            if (formula == TrapezoidAreaByBasesAndHeight)
            {
                Text0.Text = base_a;
                Text1.Text = base_b;
                Text2.Text = height_h;
                Text2.Visible = Input2.Visible = true;
            }
            else if (formula == TrapezoidAreaByMidlineAndHeight)
            {
                Text0.Text = midline_m;
                Text1.Text = height_h;
            }
            else if (formula == TrapezoidAreaByDiagonalsAndSin)
            {
                Text0.Text = diagonal_d1;
                Text1.Text = diagonal_d2;
                Text2.Text = sin_phi;
                Text2.Visible = Input2.Visible = true;
            }

            Output.Text = enter_values_press_sqr;
        }

        private void SelectTriangleAreaFormula(int formula)
        {
            a = FigureTriangle;
            bS = formula;
            HideInputs();
            ShowResult();

            if (formula == TriangleAreaByBaseAndHeight)
            {
                Text0.Visible = Input0.Visible = true;
                Text1.Visible = Input1.Visible = true;
                Text0.Text = base_a;
                Text1.Text = height_h;
            }
            else if (formula == TriangleAreaByHeron)
            {
                Text0.Visible = Input0.Visible = true;
                Text1.Visible = Input1.Visible = true;
                Text2.Visible = Input2.Visible = true;
                Text0.Text = side_a;
                Text1.Text = side_b;
                Text2.Text = side_c;
            }
            else if (formula == TriangleAreaByTwoSidesAndSin)
            {
                Text0.Visible = Input0.Visible = true;
                Text1.Visible = Input1.Visible = true;
                Text2.Visible = Input2.Visible = true;
                Text0.Text = side_a;
                Text1.Text = side_b;
                Text2.Text = sin_gamma;
            }

            Output.Text = enter_values_press_sqr;
        }

        private void SelectCircleAreaFormula(int formula)
        {
            a = FigureCircle;
            bS = formula;
            HideInputs();
            ShowResult();

            Text0.Visible = Input0.Visible = true;
            if (formula == CircleAreaByRadius) Text0.Text = radius_r;
            else if (formula == CircleAreaByDiameter) Text0.Text = diameter_d;
            else if (formula == CircleAreaByLength) Text0.Text = length_l;

            Output.Text = enter_value_press_sqr;
        }

        private void SelectRhombusAreaFormula(int formula)
        {
            a = FigureRhombus;
            bS = formula;
            HideInputs();
            ShowResult();

            if (formula == RhombusAreaBySideAndHeight)
            {
                Text0.Visible = Input0.Visible = true;
                Text1.Visible = Input1.Visible = true;
                Text0.Text = side_a;
                Text1.Text = height_h;
            }
            else if (formula == RhombusAreaByDiagonals)
            {
                Text0.Visible = Input0.Visible = true;
                Text1.Visible = Input1.Visible = true;
                Text0.Text = diagonal_d1;
                Text1.Text = diagonal_d2;
            }
            else if (formula == RhombusAreaBySideAndSin)
            {
                Text0.Visible = Input0.Visible = true;
                Text1.Visible = Input1.Visible = true;
                Text0.Text = side_a;
                Text1.Text = sin_alpha;
            }

            Output.Text = enter_values_press_sqr;
        }

        private void SelectTrapezoidPerimeterFormula(int formula)
        {
            a = FigureTrapezoid;
            bP = formula;
            HideInputs();
            ShowResult();

            Text0.Visible = Input0.Visible = true;
            Text1.Visible = Input1.Visible = true;

            if (formula == TrapezoidPerimeterByFourSides)
            {
                Text0.Text = base_a;
                Text1.Text = base_b;
                Text2.Text = side_c_trap;
                Text3.Text = side_d_trap;
                Text2.Visible = Input2.Visible = true;
                Text3.Visible = Input3.Visible = true;
            }
            else if (formula == TrapezoidPerimeterByBasesAndSide)
            {
                Text0.Text = base_a;
                Text1.Text = base_b;
                Text2.Text = side_c_trap;
                Text2.Visible = Input2.Visible = true;
            }

            Output.Text = enter_values_press_per;
        }

        private void SelectTrianglePerimeterFormula(int formula)
        {
            a = FigureTriangle;
            bP = formula;
            HideInputs();
            ShowResult();

            if (formula == TrianglePerimeterBySides)
            {
                Text0.Visible = Input0.Visible = true;
                Text1.Visible = Input1.Visible = true;
                Text2.Visible = Input2.Visible = true;
                Text0.Text = side_a;
                Text1.Text = side_b;
                Text2.Text = side_c;
            }
            else if (formula == TrianglePerimeterByAreaAndInradius)
            {
                Text0.Visible = Input0.Visible = true;
                Text1.Visible = Input1.Visible = true;
                Text0.Text = area_s;
                Text1.Text = radius_r;
            }

            Output.Text = enter_values_press_per;
        }

        private void SelectCirclePerimeterFormula(int formula)
        {
            a = FigureCircle;
            bP = formula;
            HideInputs();
            ShowResult();

            Text0.Visible = Input0.Visible = true;
            if (formula == CirclePerimeterByRadius) Text0.Text = radius_r;
            else if (formula == CirclePerimeterByDiameter) Text0.Text = diameter_d;
            else if (formula == CirclePerimeterByArea) Text0.Text = area_s;

            Output.Text = enter_value_press_per;
        }

        private void SelectRhombusPerimeterFormula(int formula)
        {
            a = FigureRhombus;
            bP = formula;
            HideInputs();
            ShowResult();

            if (formula == RhombusPerimeterBySide)
            {
                Text0.Visible = Input0.Visible = true;
                Text0.Text = side_a;
            }
            else if (formula == RhombusPerimeterByDiagonals)
            {
                Text0.Visible = Input0.Visible = true;
                Text1.Visible = Input1.Visible = true;
                Text0.Text = diagonal_d1;
                Text1.Text = diagonal_d2;
            }
            else if (formula == RhombusPerimeterByAreaAndHeight)
            {
                Text0.Visible = Input0.Visible = true;
                Text1.Visible = Input1.Visible = true;
                Text0.Text = area_s;
                Text1.Text = height_h;
            }

            Output.Text = enter_values_press_per;
        }

        private void SelectParallelogramAreaFormula(int formula)
        {
            a = FigureParallelogram;
            bS = formula;
            HideInputs();
            ShowResult();

            if (formula == ParallelogramAreaBySideAndHeight)
            {
                Text0.Visible = Input0.Visible = true;
                Text1.Visible = Input1.Visible = true;
                Text0.Text = side_a;
                Text1.Text = height_h;
            }
            else if (formula == ParallelogramAreaBySidesAndSin)
            {
                Text0.Visible = Input0.Visible = true;
                Text1.Visible = Input1.Visible = true;
                Text2.Visible = Input2.Visible = true;
                Text0.Text = side_a;
                Text1.Text = side_b;
                Text2.Text = sin_beta;
            }
            else if (formula == ParallelogramAreaByDiagonalsAndSin)
            {
                Text0.Visible = Input0.Visible = true;
                Text1.Visible = Input1.Visible = true;
                Text2.Visible = Input2.Visible = true;
                Text0.Text = diagonal_d1;
                Text1.Text = diagonal_d2;
                Text2.Text = sin_phi;
            }

            Output.Text = enter_values_press_sqr;
        }

        private void SelectSolidSurfaceFormula(int formula)
        {
            bS = formula;
            HideInputs();
            ShowResult();

            if (a == SolidCube)
            {
                if (formula == FormulaButtonFirst) { Text0.Visible = Input0.Visible = true; Text0.Text = edge_a; }
                else if (formula == FormulaButtonSecond) { Text0.Visible = Input0.Visible = true; Text0.Text = cube_diag_d; }
                else if (formula == FormulaButtonThird) { Text0.Visible = Input0.Visible = true; Text0.Text = base_area_sbase; }
            }
            else if (a == SolidParallelepiped)
            {
                if (formula == FormulaButtonFirst)
                {
                    Text0.Visible = Input0.Visible = true;
                    Text1.Visible = Input1.Visible = true;
                    Text2.Visible = Input2.Visible = true;
                    Text0.Text = side_a;
                    Text1.Text = side_b;
                    Text2.Text = height_c;
                }
                else if (formula == FormulaButtonSecond)
                {
                    Text0.Visible = Input0.Visible = true;
                    Text1.Visible = Input1.Visible = true;
                    Text2.Visible = Input2.Visible = true;
                    Text0.Text = base_area_sbase;
                    Text1.Text = base_perimeter_pbase;
                    Text2.Text = height_h;
                }
                else
                {
                    Output.Text = no_s3_for_this_solid;
                    return;
                }
            }
            else if (a == SolidCylinder)
            {
                if (formula == FormulaButtonFirst || formula == FormulaButtonSecond)
                {
                    Text0.Visible = Input0.Visible = true;
                    Text1.Visible = Input1.Visible = true;
                    Text0.Text = radius_r;
                    Text1.Text = height_h;
                }
                else if (formula == FormulaButtonThird)
                {
                    Text0.Visible = Input0.Visible = true;
                    Text1.Visible = Input1.Visible = true;
                    Text2.Visible = Input2.Visible = true;
                    Text0.Text = base_area_sbase;
                    Text1.Text = base_length_l;
                    Text2.Text = height_h;
                }
            }
            else if (a == SolidSphere)
            {
                Text0.Visible = Input0.Visible = true;
                Text0.Text = (formula == FormulaButtonSecond) ? diameter_d : radius_r;
                if (formula == FormulaButtonThird) { Output.Text = no_s3_for_sphere; return; }
            }
            else if (a == SolidPyramid)
            {
                if (formula == FormulaButtonFirst)
                {
                    Text0.Visible = Input0.Visible = true;
                    Text1.Visible = Input1.Visible = true;
                    Text0.Text = base_area_sbase;
                    Text1.Text = lateral_area_slateral;
                }
                else
                {
                    Text0.Visible = Input0.Visible = true;
                    Text1.Visible = Input1.Visible = true;
                    Text0.Text = base_side_a;
                    Text1.Text = apothem_l;
                }
            }
            else if (a == SolidCone)
            {
                if (formula == FormulaButtonThird)
                {
                    Text0.Visible = Input0.Visible = true;
                    Text1.Visible = Input1.Visible = true;
                    Text0.Text = diameter_d;
                    Text1.Text = slant_l;
                }
                else
                {
                    Text0.Visible = Input0.Visible = true;
                    Text1.Visible = Input1.Visible = true;
                    Text0.Text = radius_r;
                    Text1.Text = slant_l;
                }
            }

            Output.Text = enter_values_press_sqr;
        }

        private void SelectVolumeFormula(int formula)
        {
            bV = formula;
            HideInputs();
            ShowResult();

            if (a == SolidCube)
            {
                if (formula == FormulaButtonFirst) { Text0.Visible = Input0.Visible = true; Text0.Text = edge_a; }
                else if (formula == FormulaButtonSecond) { Text0.Visible = Input0.Visible = true; Text1.Visible = Input1.Visible = true; Text0.Text = base_area_s; Text1.Text = height_h; }
                else if (formula == FormulaButtonThird) { Text0.Visible = Input0.Visible = true; Text0.Text = cube_diag_d; }
            }
            else if (a == SolidParallelepiped)
            {
                if (formula == FormulaButtonFirst)
                {
                    Text0.Visible = Input0.Visible = true;
                    Text1.Visible = Input1.Visible = true;
                    Text2.Visible = Input2.Visible = true;
                    Text0.Text = side_a;
                    Text1.Text = side_b;
                    Text2.Text = height_c;
                }
                else if (formula == FormulaButtonSecond)
                {
                    Text0.Visible = Input0.Visible = true;
                    Text1.Visible = Input1.Visible = true;
                    Text0.Text = base_area_s;
                    Text1.Text = height_h;
                }
                else { Output.Text = no_v3_for_par; return; }
            }
            else if (a == SolidCylinder)
            {
                if (formula == FormulaButtonFirst || formula == FormulaButtonSecond)
                {
                    Text0.Visible = Input0.Visible = true;
                    Text1.Visible = Input1.Visible = true;
                    Text0.Text = (formula == FormulaButtonSecond) ? diameter_d : radius_r;
                    Text1.Text = height_h;
                }
                else if (formula == FormulaButtonThird)
                {
                    Text0.Visible = Input0.Visible = true;
                    Text1.Visible = Input1.Visible = true;
                    Text0.Text = base_area_s;
                    Text1.Text = height_h;
                }
            }
            else if (a == SolidSphere)
            {
                if (formula == FormulaButtonThird) { Output.Text = no_v3_for_sphere; return; }
                Text0.Visible = Input0.Visible = true;
                Text0.Text = (formula == FormulaButtonSecond) ? diameter_d : radius_r;
            }
            else if (a == SolidPyramid)
            {
                if (formula == FormulaButtonThird) { Output.Text = no_v3_for_pyramid; return; }
                Text0.Visible = Input0.Visible = true;
                Text1.Visible = Input1.Visible = true;
                Text0.Text = (formula == FormulaButtonSecond) ? base_side_a : base_area_s;
                Text1.Text = height_h;
            }
            else if (a == SolidCone)
            {
                Text0.Visible = Input0.Visible = true;
                Text1.Visible = Input1.Visible = true;
                if (formula == FormulaButtonFirst) Text0.Text = radius_r;
                else if (formula == FormulaButtonSecond) Text0.Text = base_area_s;
                else if (formula == FormulaButtonThird) Text0.Text = diameter_d;
                Text1.Text = height_h;
            }

            Output.Text = enter_values_press_vol;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ResetUI();
            SP_Click(sender, e);
            Per.Text = per;
            Sqr.Text = squ;
            Vol.Text = vol;
            ResT.Text = res;
        }

        private void Quad_Click(object sender, EventArgs e)
        {
            ResetUI();
            ShowBaseForFigure();

            if (mode == Mode2D)
            {
                a = FigureSquare;
                PrepareSingleInputFigure(side_a);
            }
            else
            {
                a = SolidCube;
            }

            UpdateFigureImage();
        }

        private void Rect_Click(object sender, EventArgs e)
        {
            ResetUI();
            ShowBaseForFigure();

            if (mode == Mode2D)
            {
                a = FigureRectangle;
                Rect.Text = rectangle_2d;
                PrepareDoubleInputFigure(side_a, side_b);
                Swipe.Visible = true;
            }
            else
            {
                a = SolidParallelepiped;
            }

            UpdateFigureImage();
        }

        private void Okr_Click(object sender, EventArgs e)
        {
            ResetUI();
            ShowBaseForFigure();

            if (mode == Mode2D) a = FigureCircle;
            else a = SolidCylinder;

            UpdateFigureImage();
        }

        private void Romb_Click(object sender, EventArgs e)
        {
            ResetUI();
            ShowBaseForFigure();

            if (mode == Mode2D) a = FigureRhombus;
            else a = SolidSphere;

            UpdateFigureImage();
        }

        private void Trap_Click(object sender, EventArgs e)
        {
            ResetUI();
            ShowBaseForFigure();

            if (mode == Mode2D) a = FigureTrapezoid;
            else a = SolidPyramid;

            UpdateFigureImage();
        }

        private void Trian_Click(object sender, EventArgs e)
        {
            ResetUI();
            ShowBaseForFigure();

            if (mode == Mode2D) a = FigureTriangle;
            else a = SolidCone;

            UpdateFigureImage();
        }

        private void Sqr_Click(object sender, EventArgs e)
        {
            HideFormulaButtons();
            currentAction = ActionArea;
            ShowResult();

            if (mode == Mode3D && IsSolidSelected())
            {
                HideFormulaButtons();
                ConfigureSolidSurfaceButtons();

                S1F.Visible = true;
                S2F.Visible = true;
                S3F.Visible = (a != SolidParallelepiped && a != SolidSphere);

                Output.Text = choose_formula_s;
                return;
            }

            if (a == FigureSquare || a == FigureRectangle)
            {
                Output.Text = press_solve;
                return;
            }

            if (a == FigureTrapezoid || a == FigureTriangle || a == FigureCircle || a == FigureRhombus || a == FigureParallelogram)
            {
                HideFormulaButtons();
                ConfigureAreaFormulaButtons();
                S1F.Visible = S2F.Visible = S3F.Visible = true;
                Output.Text = choose_formula_s;
                return;
            }

            Output.Text = press_solve;
        }

        private void Per_Click(object sender, EventArgs e)
        {
            HideFormulaButtons();
            currentAction = ActionPerimeter;
            ShowResult();

            if (a == FigureSquare || a == FigureRectangle || a == FigureParallelogram)
            {
                Output.Text = press_solve;
                return;
            }

            if (a == FigureTrapezoid || a == FigureTriangle || a == FigureCircle || a == FigureRhombus)
            {
                HideFormulaButtons();
                ConfigurePerimeterFormulaButtons();

                if (a == FigureCircle || a == FigureRhombus)
                    P1F.Visible = P2F.Visible = P3F.Visible = true;
                else
                    P1F.Visible = P2F.Visible = true;

                Output.Text = choose_formula_p;
                return;
            }

            Output.Text = press_solve;
        }

        private void Vol_Click(object sender, EventArgs e)
        {
            HideFormulaButtons();
            currentAction = ActionVolume;
            ShowResult();

            if (mode != Mode3D)
            {
                Output.Text = switch_to_spv_mode;
                return;
            }

            HideFormulaButtons();
            ConfigureVolumeFormulaButtons();
            V1F.Visible = V2F.Visible = true;
            V3F.Visible = (a == SolidCube || a == SolidCylinder || a == SolidCone);

            Output.Text = choose_formula_v;
        }

        private void S1F_Click(object sender, EventArgs e)
        {
            if (mode == Mode3D && IsSolidSelected()) SelectSolidSurfaceFormula(FormulaButtonFirst);
            else if (a == FigureTrapezoid) SelectTrapezoidAreaFormula(TrapezoidAreaByBasesAndHeight);
            else if (a == FigureTriangle) SelectTriangleAreaFormula(TriangleAreaByBaseAndHeight);
            else if (a == FigureCircle) SelectCircleAreaFormula(CircleAreaByRadius);
            else if (a == FigureRhombus) SelectRhombusAreaFormula(RhombusAreaBySideAndHeight);
            else if (a == FigureParallelogram) SelectParallelogramAreaFormula(ParallelogramAreaBySideAndHeight);
        }

        private void S2F_Click(object sender, EventArgs e)
        {
            if (mode == Mode3D && IsSolidSelected()) SelectSolidSurfaceFormula(FormulaButtonSecond);
            else if (a == FigureTrapezoid) SelectTrapezoidAreaFormula(TrapezoidAreaByMidlineAndHeight);
            else if (a == FigureTriangle) SelectTriangleAreaFormula(TriangleAreaByHeron);
            else if (a == FigureCircle) SelectCircleAreaFormula(CircleAreaByDiameter);
            else if (a == FigureRhombus) SelectRhombusAreaFormula(RhombusAreaByDiagonals);
            else if (a == FigureParallelogram) SelectParallelogramAreaFormula(ParallelogramAreaBySidesAndSin);
        }

        private void S3F_Click(object sender, EventArgs e)
        {
            if (mode == Mode3D && IsSolidSelected()) SelectSolidSurfaceFormula(FormulaButtonThird);
            else if (a == FigureTrapezoid) SelectTrapezoidAreaFormula(TrapezoidAreaByDiagonalsAndSin);
            else if (a == FigureTriangle) SelectTriangleAreaFormula(TriangleAreaByTwoSidesAndSin);
            else if (a == FigureCircle) SelectCircleAreaFormula(CircleAreaByLength);
            else if (a == FigureRhombus) SelectRhombusAreaFormula(RhombusAreaBySideAndSin);
            else if (a == FigureParallelogram) SelectParallelogramAreaFormula(ParallelogramAreaByDiagonalsAndSin);
        }

        private void P1F_Click(object sender, EventArgs e)
        {
            if (a == FigureTrapezoid) SelectTrapezoidPerimeterFormula(TrapezoidPerimeterByFourSides);
            else if (a == FigureTriangle) SelectTrianglePerimeterFormula(TrianglePerimeterBySides);
            else if (a == FigureCircle) SelectCirclePerimeterFormula(CirclePerimeterByRadius);
            else if (a == FigureRhombus) SelectRhombusPerimeterFormula(RhombusPerimeterBySide);
        }

        private void P2F_Click(object sender, EventArgs e)
        {
            if (a == FigureTrapezoid) SelectTrapezoidPerimeterFormula(TrapezoidPerimeterByBasesAndSide);
            else if (a == FigureTriangle) SelectTrianglePerimeterFormula(TrianglePerimeterByAreaAndInradius);
            else if (a == FigureCircle) SelectCirclePerimeterFormula(CirclePerimeterByDiameter);
            else if (a == FigureRhombus) SelectRhombusPerimeterFormula(RhombusPerimeterByDiagonals);
        }

        private void P3F_Click(object sender, EventArgs e)
        {
            if (a == FigureCircle) SelectCirclePerimeterFormula(CirclePerimeterByArea);
            else if (a == FigureRhombus) SelectRhombusPerimeterFormula(RhombusPerimeterByAreaAndHeight);
        }

        private void V1F_Click(object sender, EventArgs e) => SelectVolumeFormula(FormulaButtonFirst);
        private void V2F_Click(object sender, EventArgs e) => SelectVolumeFormula(FormulaButtonSecond);
        private void V3F_Click(object sender, EventArgs e) => SelectVolumeFormula(FormulaButtonThird);

        private void SP_Click(object sender, EventArgs e)
        {
            mode = Mode2D;
            ResetUI();

            Quad.Visible = true;
            Rect.Visible = true;
            Trap.Visible = true;
            Trian.Visible = true;
            Okr.Visible = true;
            Romb.Visible = true;

            Quad.Text = square_2d;
            Rect.Text = rectangle_2d;
            Trap.Text = trapezoid_2d;
            Trian.Text = triangle_2d;
            Okr.Text = circle_2d;
            Romb.Text = rhombus_2d;
            Vol.Location = new Point(VolumeButtonX, VolumeButtonY2D);
            UpdateFigureImage();
        }

        private void SPV_Click(object sender, EventArgs e)
        {
            mode = Mode3D;
            ResetUI();

            Quad.Visible = true;
            Rect.Visible = true;
            Okr.Visible = true;
            Romb.Visible = true;
            Trap.Visible = true;
            Trian.Visible = true;

            Quad.Text = cube_3d;
            Rect.Text = parallelepiped_3d;
            Okr.Text = cylinder_3d;
            Romb.Text = sphere_3d;
            Trap.Text = pyramid_3d;
            Trian.Text = cone_3d;
            Vol.Location = Per.Location;
            UpdateFigureImage();
        }

        void RUS()
        {
            empty = "";

            s1 = "S1";
            s2 = "S2";
            s3 = "S3";
            p1 = "P1";
            p2 = "P2";
            p3 = "P3";
            v1 = "V1";
            v2 = "V2";
            v3 = "V3";
            dash = "—";

            s_trap_1 = "S = (a+b)·h / 2";
            s_trap_2 = "S = m·h";
            s_trap_3 = "S = d1·d2·sin(φ) / 2";
            s_trian_1 = "S = a·h / 2";
            heron = "Формула Герона";
            s_trian_3 = "S = a·b·sin(γ) / 2";
            s_circle_1 = "S = πr²";
            s_circle_2 = "S = πd² / 4";
            s_circle_3 = "S = L² / (4π)";
            s_rhomb_1 = "S = a·h";
            s_rhomb_2 = "S = d1·d2 / 2";
            s_rhomb_3 = "S = a²·sin(α)";

            p_trap_1 = "P = a+b+c+d";
            p_trap_2 = "P = a+b+2c";
            p_trian_1 = "P = a+b+c";
            p_trian_2 = "P = 2S / r";
            l_circle_1 = "L = 2πr";
            l_circle_2 = "L = πd";
            l_circle_3 = "L = √(4πS)";
            p_rhomb_1 = "P = 4a";
            p_rhomb_2 = "P = 2·√(d1²+d2²)";
            p_rhomb_3 = "P = 4S / h";

            s_cube_1 = "S = 6a²";
            s_cube_2 = "S = 2d²";
            s_cube_3 = "S = 6·Sосн";
            s_par_1 = "S = 2(ab+ac+bc)";
            s_par_2 = "S = 2Sосн + Pосн·h";
            s_cyl_1 = "S = 2πr(h+r)";
            s_cyl_2 = "S = 2πrh + 2πr²";
            s_cyl_3 = "S = 2Sосн + L·h";
            s_sph_1 = "S = 4πr²";
            s_sph_2 = "S = πd²";
            s_pyr_1 = "S = Sосн + Sбок";
            s_pyr_2 = "S = a² + 2a·l";
            s_pyr_3 = "S = a² + (Pосн·l)/2";
            s_cone_1 = "S = πr(r+l)";
            s_cone_2 = "S = πr² + πrl";
            s_cone_3 = "S = π(d²/4) + π(d/2)l";

            v_cube_1 = "V = a³";
            v_cube_2 = "V = S·h";
            v_cube_3 = "V = d³/(3√3)";
            v_par_1 = "V = a·b·c";
            v_par_2 = "V = Sосн·h";
            v_cyl_1 = "V = πr²h";
            v_cyl_2 = "V = (πd²/4)·h";
            v_cyl_3 = "V = Sосн·h";
            v_sph_1 = "V = 4/3·πr³";
            v_sph_2 = "V = πd³/6";
            v_pyr_1 = "V = Sосн·h/3";
            v_pyr_2 = "V = a²·h/3";
            v_cone_1 = "V = 1/3·πr²h";
            v_cone_2 = "V = 1/3·Sосн·h";
            v_cone_3 = "V = πd²h/12";

            base_a = "Основание a:";
            base_b = "Основание b:";
            height_h = "Высота h:";
            midline_m = "Средняя линия m:";
            diagonal_d1 = "Диагональ d1:";
            diagonal_d2 = "Диагональ d2:";
            sin_phi = "sin(φ):";
            side_a = "Сторона a:";
            side_b = "Сторона b:";
            side_c = "Сторона c:";
            sin_gamma = "sin(γ):";
            radius_r = "Радиус r:";
            diameter_d = "Диаметр d:";
            length_l = "Длина L:";
            sin_alpha = "sin(α):";
            side_c_trap = "Бок сторона c:";
            side_d_trap = "Бок сторона d:";
            area_s = "Площадь S:";
            edge_a = "Ребро a:";
            cube_diag_d = "Диагональ куба d:";
            base_area_sbase = "Sосн:";
            base_perimeter_pbase = "Pосн:";
            height_c = "Высота c:";
            base_length_l = "Lосн:";
            lateral_area_slateral = "Sбок:";
            base_side_a = "Сторона a(осн):";
            apothem_l = "Апофема l:";
            slant_l = "Образующая l:";
            base_area_s = "Sосн:";

            enter_values_press_sqr = "Введи значения и нажми Вычислить ";
            enter_value_press_sqr = "Введи значение и нажми Вычислить ";
            enter_values_press_per = "Введи значения и нажми Вычислить ";
            enter_value_press_per = "Введи значение и нажми Вычислить ";
            enter_values_press_vol = "Введи значения и нажми Вычислить ";

            choose_formula_s = "Выбери формулу";
            choose_formula_p = "Выбери формулу";
            choose_formula_p12 = "Выбери формулу";
            choose_formula_v = "Выбери формулу";
            choose_formula_v12 = "Выбери формулу";

            no_s3_for_this_solid = "Для этого тела S3 нет ";
            no_s3_for_sphere = "Для сферы S3 нет ";
            no_v3_for_par = "Для параллелепипеда V3 нет ";
            no_v3_for_sphere = "Для сферы V3 нет ";
            no_v3_for_pyramid = "Для пирамиды V3 нет ";

            figure_not_implemented = "Фигура не реализована";
            solid_not_implemented = "Тело не реализовано";
            impossible_triangle = "Невозможный треугольник";
            impossible_trapezoid = "Невозможная трапеция";
            impossible_cone = "Невозможный конус";
            invalid_sin_value = "sin должен быть > 0 и ≤ 1";
            value_must_be_gt_0 = "Все значения должны быть > 0";
            diagonal_must_be_gt_0 = "Диагональ должна быть > 0";

            r_cannot_be_0 = "r не может быть 0";
            s_cannot_be_lt_0 = "S не может быть < 0";
            h_cannot_be_0 = "h не может быть 0";

            switch_to_spv_mode = "Переключитесь в режим SPV";

            square_2d = "Квадрат";
            rectangle_2d = "Прямоугольник";
            trapezoid_2d = "Трапеция";
            triangle_2d = "Треугольник";
            circle_2d = "Окружность";
            rhombus_2d = "Ромб";

            cube_3d = "Куб";
            parallelepiped_3d = "Параллелепипед";
            cylinder_3d = "Цилиндр";
            sphere_3d = "Сфера";
            pyramid_3d = "Пирамида";
            cone_3d = "Конус";

            per = "Периметр";
            squ = "Площадь";
            vol = "Объём";
            res = "Результат: ";

            parallelogram_2d = "Параллелограмм";

            s_paral_1 = "S = a·h";
            s_paral_2 = "S = a·b·sin(β)";
            s_paral_3 = "S = d1·d2·sin(φ) / 2";

            sin_beta = "sin(β):";

            solvetext = "Вычислить";
            choose_action_first = "Сначала выбери, что считать";
            press_solve = "Нажми Вычислить";

            if (mode == Mode2D) SP_Click(this, EventArgs.Empty);
            else SPV_Click(this, EventArgs.Empty);

            LangUIRefresh();
        }

        void ENG()
        {
            empty = "";
            solvetext = "Solve";
            choose_action_first = "Choose what to calculate first";
            press_solve = "Press Solve";

            s1 = "S1";
            s2 = "S2";
            s3 = "S3";
            p1 = "P1";
            p2 = "P2";
            p3 = "P3";
            v1 = "V1";
            v2 = "V2";
            v3 = "V3";
            dash = "—";

            s_trap_1 = "S = (a+b)·h / 2";
            s_trap_2 = "S = m·h";
            s_trap_3 = "S = d1·d2·sin(φ) / 2";
            s_trian_1 = "S = a·h / 2";
            heron = "Heron's formula";
            s_trian_3 = "S = a·b·sin(γ) / 2";
            s_circle_1 = "S = πr²";
            s_circle_2 = "S = πd² / 4";
            s_circle_3 = "S = L² / (4π)";
            s_rhomb_1 = "S = a·h";
            s_rhomb_2 = "S = d1·d2 / 2";
            s_rhomb_3 = "S = a²·sin(α)";

            p_trap_1 = "P = a+b+c+d";
            p_trap_2 = "P = a+b+2c";
            p_trian_1 = "P = a+b+c";
            p_trian_2 = "P = 2S / r";
            l_circle_1 = "L = 2πr";
            l_circle_2 = "L = πd";
            l_circle_3 = "L = √(4πS)";
            p_rhomb_1 = "P = 4a";
            p_rhomb_2 = "P = 2·√(d1²+d2²)";
            p_rhomb_3 = "P = 4S / h";

            s_cube_1 = "S = 6a²";
            s_cube_2 = "S = 2d²";
            s_cube_3 = "S = 6·Sbase";
            s_par_1 = "S = 2(ab+ac+bc)";
            s_par_2 = "S = 2Sbase + Pbase·h";
            s_cyl_1 = "S = 2πr(h+r)";
            s_cyl_2 = "S = 2πrh + 2πr²";
            s_cyl_3 = "S = 2Sbase + L·h";
            s_sph_1 = "S = 4πr²";
            s_sph_2 = "S = πd²";
            s_pyr_1 = "S = Sbase + Slateral";
            s_pyr_2 = "S = a² + 2a·l";
            s_pyr_3 = "S = a² + (Pbase·l)/2";
            s_cone_1 = "S = πr(r+l)";
            s_cone_2 = "S = πr² + πrl";
            s_cone_3 = "S = π(d²/4) + π(d/2)l";

            v_cube_1 = "V = a³";
            v_cube_2 = "V = S·h";
            v_cube_3 = "V = d³/(3√3)";
            v_par_1 = "V = a·b·c";
            v_par_2 = "V = Sbase·h";
            v_cyl_1 = "V = πr²h";
            v_cyl_2 = "V = (πd²/4)·h";
            v_cyl_3 = "V = Sbase·h";
            v_sph_1 = "V = 4/3·πr³";
            v_sph_2 = "V = πd³/6";
            v_pyr_1 = "V = Sbase·h/3";
            v_pyr_2 = "V = a²·h/3";
            v_cone_1 = "V = 1/3·πr²h";
            v_cone_2 = "V = 1/3·Sbase·h";
            v_cone_3 = "V = πd²h/12";

            base_a = "Base a:";
            base_b = "Base b:";
            height_h = "Height h:";
            midline_m = "Midline m:";
            diagonal_d1 = "Diagonal d1:";
            diagonal_d2 = "Diagonal d2:";
            sin_phi = "sin(φ):";
            side_a = "Side a:";
            side_b = "Side b:";
            side_c = "Side c:";
            sin_gamma = "sin(γ):";
            radius_r = "Radius r:";
            diameter_d = "Diameter d:";
            length_l = "Length L:";
            sin_alpha = "sin(α):";
            side_c_trap = "Leg c:";
            side_d_trap = "Leg d:";
            area_s = "Area S:";
            edge_a = "Edge a:";
            cube_diag_d = "Cube diagonal d:";
            base_area_sbase = "Sbase:";
            base_perimeter_pbase = "Pbase:";
            height_c = "Height c:";
            base_length_l = "Base circumference L:";
            lateral_area_slateral = "Slateral:";
            base_side_a = "Base side a:";
            apothem_l = "Apothem l:";
            slant_l = "Slant height l:";
            base_area_s = "Sbase:";

            enter_values_press_sqr = "Enter values and press Solve ";
            enter_value_press_sqr = "Enter value and press Solve ";
            enter_values_press_per = "Enter values and press Solve ";
            enter_value_press_per = "Enter value and press Solve ";
            enter_values_press_vol = "Enter values and press Solve ";

            choose_formula_s = "Choose a formula";
            choose_formula_p = "Choose a formula";
            choose_formula_p12 = "Choose a formula";
            choose_formula_v = "Choose a formula";
            choose_formula_v12 = "Choose a formula";

            no_s3_for_this_solid = "S3 is not available for this solid ";
            no_s3_for_sphere = "S3 is not available for a sphere ";
            no_v3_for_par = "V3 is not available for a parallelepiped ";
            no_v3_for_sphere = "V3 is not available for a sphere ";
            no_v3_for_pyramid = "V3 is not available for a pyramid ";

            figure_not_implemented = "Figure is not implemented";
            solid_not_implemented = "Solid is not implemented";
            impossible_triangle = "Impossible triangle";
            impossible_trapezoid = "Impossible trapezoid";
            impossible_cone = "Impossible cone";
            invalid_sin_value = "sin must be > 0 and ≤ 1";
            value_must_be_gt_0 = "All values must be > 0";
            diagonal_must_be_gt_0 = "Diagonal must be > 0";

            r_cannot_be_0 = "r cannot be 0";
            s_cannot_be_lt_0 = "S cannot be < 0";
            h_cannot_be_0 = "h cannot be 0";

            switch_to_spv_mode = "Switch to SPV mode";

            square_2d = "Square";
            rectangle_2d = "Rectangle";
            trapezoid_2d = "Trapezoid";
            triangle_2d = "Triangle";
            circle_2d = "Circle";
            rhombus_2d = "Rhombus";

            cube_3d = "Cube";
            parallelepiped_3d = "Parallelepiped";
            cylinder_3d = "Cylinder";
            sphere_3d = "Sphere";
            pyramid_3d = "Pyramid";
            cone_3d = "Cone";

            per = "Perimeter";
            squ = "Area";
            vol = "Volume";
            res = "Result: ";

            parallelogram_2d = "Parallelogram";

            s_paral_1 = "S = a·h";
            s_paral_2 = "S = a·b·sin(β)";
            s_paral_3 = "S = d1·d2·sin(φ) / 2";

            sin_beta = "sin(β):";

            if (mode == Mode2D) SP_Click(this, EventArgs.Empty);
            else SPV_Click(this, EventArgs.Empty);

            LangUIRefresh();
        }

        private void rusT_Click(object sender, EventArgs e)
        {
            RUS();
        }

        private void engT_Click(object sender, EventArgs e)
        {
            ENG();
        }

        private void LangUIRefresh()
        {
            Per.Text = per;
            Sqr.Text = squ;
            Vol.Text = vol;
            ResT.Text = res;
            solve.Text = solvetext;
        }

        public int SettingsOn = SettingsClosed;

        private void Settings_Click(object sender, EventArgs e)
        {
            if (SettingsOn == SettingsClosed)
            {
                SettingsOn = SettingsOpened;
                rusT.Visible = engT.Visible = true;
            }
            else
            {
                SettingsOn = SettingsClosed;
                rusT.Visible = engT.Visible = false;
            }
        }

        private void Swipe_Click(object sender, EventArgs e)
        {
            if (mode != Mode2D) return;

            ResetUI();
            ShowBaseForFigure();

            if (a == FigureRectangle)
            {
                a = FigureParallelogram;
                Rect.Text = parallelogram_2d;
            }
            else
            {
                a = FigureRectangle;
                Rect.Text = rectangle_2d;
            }

            PrepareDoubleInputFigure(side_a, side_b);
            Swipe.Visible = true;
            UpdateFigureImage();
        }

        private void solve_Click(object sender, EventArgs e)
        {
            RunSelectedAction();
        }

        private void RunSelectedAction()
        {
            if (currentAction == ActionArea)
            {
                CalculateArea();
            }
            else if (currentAction == ActionPerimeter)
            {
                CalculatePerimeter();
            }
            else if (currentAction == ActionVolume)
            {
                CalculateVolume();
            }
            else
            {
                ShowResult();
                Output.Text = choose_action_first;
            }
        }

        private void CalculateArea()
        {
            HideFormulaButtons();

            if (mode == Mode3D && IsSolidSelected())
            {
                ConfigureSolidSurfaceButtons();

                S1F.Visible = true;
                S2F.Visible = true;
                S3F.Visible = (a != SolidParallelepiped && a != SolidSphere);

                if (bS == ActionNone) { ShowResult(); Output.Text = choose_formula_s; return; }

                double x0 = GetInputValue(Input0);
                double x1 = GetInputValue(Input1);
                double x2 = GetInputValue(Input2);

                if (a == SolidCube)
                {
                    if (bS == FormulaButtonFirst)
                    {
                        if (!ValidatePositive(x0)) return;
                        output = Six * x0 * x0;
                    }
                    else if (bS == FormulaButtonSecond)
                    {
                        if (!ValidatePositiveDiagonal(x0)) return;
                        output = Two * x0 * x0;
                    }
                    else if (bS == FormulaButtonThird)
                    {
                        if (!ValidatePositive(x0)) return;
                        output = Six * x0;
                    }
                }
                else if (a == SolidParallelepiped)
                {
                    if (bS == FormulaButtonFirst)
                    {
                        if (!ValidatePositive(x0, x1, x2)) return;
                        output = Two * (x0 * x1 + x0 * x2 + x1 * x2);
                    }
                    else if (bS == FormulaButtonSecond)
                    {
                        if (!ValidatePositive(x0, x1, x2)) return;
                        output = Two * x0 + x1 * x2;
                    }
                    else { ShowResult(); Output.Text = no_s3_for_this_solid; return; }
                }
                else if (a == SolidCylinder)
                {
                    if (bS == FormulaButtonFirst)
                    {
                        if (!ValidatePositive(x0, x1)) return;
                        output = Two * Math.PI * x0 * (x1 + x0);
                    }
                    else if (bS == FormulaButtonSecond)
                    {
                        if (!ValidatePositive(x0, x1)) return;
                        output = Two * Math.PI * x0 * x1 + Two * Math.PI * x0 * x0;
                    }
                    else if (bS == FormulaButtonThird)
                    {
                        if (!ValidatePositive(x0, x1, x2)) return;
                        output = Two * x0 + x1 * x2;
                    }
                }
                else if (a == SolidSphere)
                {
                    if (bS == FormulaButtonFirst)
                    {
                        if (!ValidatePositive(x0)) return;
                        output = Four * Math.PI * x0 * x0;
                    }
                    else if (bS == FormulaButtonSecond)
                    {
                        if (!ValidatePositive(x0)) return;
                        output = Math.PI * x0 * x0;
                    }
                    else { ShowResult(); Output.Text = no_s3_for_sphere; return; }
                }
                else if (a == SolidPyramid)
                {
                    if (bS == FormulaButtonFirst)
                    {
                        if (!ValidatePositive(x0, x1)) return;
                        output = x0 + x1;
                    }
                    else if (bS == FormulaButtonSecond)
                    {
                        if (!ValidatePositive(x0, x1)) return;
                        output = x0 * x0 + Two * x0 * x1;
                    }
                    else if (bS == FormulaButtonThird)
                    {
                        if (!ValidatePositive(x0, x1)) return;
                        output = x0 * x0 + (Four * x0 * x1) / Two;
                    }
                }
                else if (a == SolidCone)
                {
                    if (bS == FormulaButtonFirst)
                    {
                        if (!ValidateConeByRadiusAndSlant(x0, x1)) return;
                        output = Math.PI * x0 * (x0 + x1);
                    }
                    else if (bS == FormulaButtonSecond)
                    {
                        if (!ValidateConeByRadiusAndSlant(x0, x1)) return;
                        output = Math.PI * x0 * x0 + Math.PI * x0 * x1;
                    }
                    else if (bS == FormulaButtonThird)
                    {
                        if (!ValidateConeByDiameterAndSlant(x0, x1)) return;
                        double r = x0 / Two;
                        output = Math.PI * r * r + Math.PI * r * x1;
                    }
                }

                ShowResult();
                Output.Text = output.ToString();
                return;
            }

            if (a == FigureTrapezoid || a == FigureTriangle || a == FigureCircle || a == FigureRhombus || a == FigureParallelogram)
            {
                ConfigureAreaFormulaButtons();
                S1F.Visible = S2F.Visible = S3F.Visible = true;

                if (bS == ActionNone) { ShowResult(); Output.Text = choose_formula_s; return; }
            }

            double x0_2 = GetInputValue(Input0);
            double x1_2 = GetInputValue(Input1);
            double x2_2 = GetInputValue(Input2);

            if (a == FigureSquare)
            {
                if (!ValidatePositive(x0_2)) return;
                output = x0_2 * x0_2;
            }
            else if (a == FigureRectangle)
            {
                if (!ValidatePositive(x0_2, x1_2)) return;
                output = x0_2 * x1_2;
            }
            else if (a == FigureTrapezoid)
            {
                if (bS == TrapezoidAreaByBasesAndHeight)
                {
                    if (!ValidatePositive(x0_2, x1_2, x2_2)) return;
                    output = Half * (x0_2 + x1_2) * x2_2;
                }
                else if (bS == TrapezoidAreaByMidlineAndHeight)
                {
                    if (!ValidatePositive(x0_2, x1_2)) return;
                    output = x0_2 * x1_2;
                }
                else if (bS == TrapezoidAreaByDiagonalsAndSin)
                {
                    if (!ValidatePositiveDiagonal(x0_2) || !ValidatePositiveDiagonal(x1_2)) return;
                    if (!ValidateSinValue(x2_2)) return;
                    output = Half * (x0_2 * x1_2) * x2_2;
                }
                else { ShowResult(); Output.Text = choose_formula_s; return; }
            }
            else if (a == FigureTriangle)
            {
                if (bS == TriangleAreaByBaseAndHeight)
                {
                    if (!ValidatePositive(x0_2, x1_2)) return;
                    output = Half * x0_2 * x1_2;
                }
                else if (bS == TriangleAreaByHeron)
                {
                    if (!ValidateTriangle(x0_2, x1_2, x2_2)) return;

                    double s = (x0_2 + x1_2 + x2_2) / Two;
                    double under = s * (s - x0_2) * (s - x1_2) * (s - x2_2);

                    if (under <= 0)
                    {
                        ShowResult();
                        Output.Text = impossible_triangle;
                        return;
                    }

                    output = Math.Sqrt(under);
                }
                else if (bS == TriangleAreaByTwoSidesAndSin)
                {
                    if (!ValidatePositive(x0_2, x1_2)) return;
                    if (!ValidateSinValue(x2_2)) return;
                    output = Half * x0_2 * x1_2 * x2_2;
                }
                else { ShowResult(); Output.Text = choose_formula_s; return; }
            }
            else if (a == FigureCircle)
            {
                if (bS == CircleAreaByRadius)
                {
                    if (!ValidatePositive(x0_2)) return;
                    output = Math.PI * x0_2 * x0_2;
                }
                else if (bS == CircleAreaByDiameter)
                {
                    if (!ValidatePositive(x0_2)) return;
                    output = Math.PI * x0_2 * x0_2 / Four;
                }
                else if (bS == CircleAreaByLength)
                {
                    if (!ValidatePositive(x0_2)) return;
                    output = (x0_2 * x0_2) / (Four * Math.PI);
                }
                else { ShowResult(); Output.Text = choose_formula_s; return; }
            }
            else if (a == FigureRhombus)
            {
                if (bS == RhombusAreaBySideAndHeight)
                {
                    if (!ValidatePositive(x0_2, x1_2)) return;
                    output = x0_2 * x1_2;
                }
                else if (bS == RhombusAreaByDiagonals)
                {
                    if (!ValidatePositiveDiagonal(x0_2) || !ValidatePositiveDiagonal(x1_2)) return;
                    output = Half * x0_2 * x1_2;
                }
                else if (bS == RhombusAreaBySideAndSin)
                {
                    if (!ValidatePositive(x0_2)) return;
                    if (!ValidateSinValue(x1_2)) return;
                    output = x0_2 * x0_2 * x1_2;
                }
                else { ShowResult(); Output.Text = choose_formula_s; return; }
            }
            else if (a == FigureParallelogram)
            {
                if (bS == ParallelogramAreaBySideAndHeight)
                {
                    if (!ValidatePositive(x0_2, x1_2)) return;
                    output = x0_2 * x1_2;
                }
                else if (bS == ParallelogramAreaBySidesAndSin)
                {
                    if (!ValidatePositive(x0_2, x1_2)) return;
                    if (!ValidateSinValue(x2_2)) return;
                    output = x0_2 * x1_2 * x2_2;
                }
                else if (bS == ParallelogramAreaByDiagonalsAndSin)
                {
                    if (!ValidatePositiveDiagonal(x0_2) || !ValidatePositiveDiagonal(x1_2)) return;
                    if (!ValidateSinValue(x2_2)) return;
                    output = x0_2 * x1_2 * x2_2 / Two;
                }
                else { ShowResult(); Output.Text = choose_formula_s; return; }
            }
            else { ShowResult(); Output.Text = figure_not_implemented; return; }

            ShowResult();
            Output.Text = output.ToString();
        }

        private void CalculatePerimeter()
        {
            HideFormulaButtons();

            if (a == FigureTrapezoid || a == FigureTriangle || a == FigureCircle || a == FigureRhombus)
            {
                ConfigurePerimeterFormulaButtons();

                if (a == FigureCircle || a == FigureRhombus) P1F.Visible = P2F.Visible = P3F.Visible = true;
                else P1F.Visible = P2F.Visible = true;

                if (bP == ActionNone)
                {
                    ShowResult();
                    Output.Text = choose_formula_p;
                    return;
                }
            }

            double x0_2 = GetInputValue(Input0);
            double x1_2 = GetInputValue(Input1);
            double x2_2 = GetInputValue(Input2);
            double x3_2 = GetInputValue(Input3);

            if (a == FigureSquare)
            {
                if (!ValidatePositive(x0_2)) return;
                output = x0_2 * Four;
            }
            else if (a == FigureRectangle)
            {
                if (!ValidatePositive(x0_2, x1_2)) return;
                output = x0_2 * Two + x1_2 * Two;
            }
            else if (a == FigureTrapezoid)
            {
                if (bP == TrapezoidPerimeterByFourSides)
                {
                    if (!ValidateTrapezoidByFourSides(x0_2, x1_2, x2_2, x3_2)) return;
                    output = x0_2 + x1_2 + x2_2 + x3_2;
                }
                else if (bP == TrapezoidPerimeterByBasesAndSide)
                {
                    if (!ValidateIsoscelesTrapezoid(x0_2, x1_2, x2_2)) return;
                    output = x0_2 + x1_2 + x2_2 * Two;
                }
                else
                {
                    ShowResult();
                    Output.Text = choose_formula_p12;
                    return;
                }
            }
            else if (a == FigureTriangle)
            {
                if (bP == TrianglePerimeterBySides)
                {
                    if (!ValidateTriangle(x0_2, x1_2, x2_2)) return;
                    output = x0_2 + x1_2 + x2_2;
                }
                else if (bP == TrianglePerimeterByAreaAndInradius)
                {
                    if (x0_2 <= 0)
                    {
                        ShowResult();
                        Output.Text = s_cannot_be_lt_0;
                        return;
                    }

                    if (x1_2 == 0)
                    {
                        ShowResult();
                        Output.Text = r_cannot_be_0;
                        return;
                    }

                    if (x1_2 < 0)
                    {
                        ShowResult();
                        Output.Text = value_must_be_gt_0;
                        return;
                    }

                    output = Two * x0_2 / x1_2;
                }
                else
                {
                    ShowResult();
                    Output.Text = choose_formula_p12;
                    return;
                }
            }
            else if (a == FigureCircle)
            {
                if (bP == CirclePerimeterByRadius)
                {
                    if (!ValidatePositive(x0_2)) return;
                    output = Two * Math.PI * x0_2;
                }
                else if (bP == CirclePerimeterByDiameter)
                {
                    if (!ValidatePositive(x0_2)) return;
                    output = Math.PI * x0_2;
                }
                else if (bP == CirclePerimeterByArea)
                {
                    if (x0_2 < 0)
                    {
                        ShowResult();
                        Output.Text = s_cannot_be_lt_0;
                        return;
                    }

                    if (x0_2 == 0)
                    {
                        ShowResult();
                        Output.Text = value_must_be_gt_0;
                        return;
                    }

                    output = Math.Sqrt(Four * Math.PI * x0_2);
                }
                else
                {
                    ShowResult();
                    Output.Text = choose_formula_p;
                    return;
                }
            }
            else if (a == FigureRhombus)
            {
                if (bP == RhombusPerimeterBySide)
                {
                    if (!ValidatePositive(x0_2)) return;
                    output = Four * x0_2;
                }
                else if (bP == RhombusPerimeterByDiagonals)
                {
                    if (!ValidatePositiveDiagonal(x0_2) || !ValidatePositiveDiagonal(x1_2)) return;
                    output = Two * Math.Sqrt(x0_2 * x0_2 + x1_2 * x1_2);
                }
                else if (bP == RhombusPerimeterByAreaAndHeight)
                {
                    if (x0_2 <= 0)
                    {
                        ShowResult();
                        Output.Text = s_cannot_be_lt_0;
                        return;
                    }

                    if (x1_2 == 0)
                    {
                        ShowResult();
                        Output.Text = h_cannot_be_0;
                        return;
                    }

                    if (x1_2 < 0)
                    {
                        ShowResult();
                        Output.Text = value_must_be_gt_0;
                        return;
                    }

                    output = Four * x0_2 / x1_2;
                }
                else
                {
                    ShowResult();
                    Output.Text = choose_formula_p;
                    return;
                }
            }
            else if (a == FigureParallelogram)
            {
                if (!ValidatePositive(x0_2, x1_2)) return;
                output = x0_2 * Two + x1_2 * Two;
            }
            else
            {
                ShowResult();
                Output.Text = figure_not_implemented;
                return;
            }

            ShowResult();
            Output.Text = output.ToString();
        }

        private void CalculateVolume()
        {
            if (mode != Mode3D)
            {
                ShowResult();
                Output.Text = switch_to_spv_mode;
                return;
            }

            HideFormulaButtons();

            ConfigureVolumeFormulaButtons();
            V1F.Visible = V2F.Visible = true;
            V3F.Visible = (a == SolidCube || a == SolidCylinder || a == SolidCone);

            if (bV == ActionNone)
            {
                ShowResult();
                Output.Text = choose_formula_v;
                return;
            }

            double x0 = GetInputValue(Input0);
            double x1 = GetInputValue(Input1);
            double x2 = GetInputValue(Input2);

            if (a == SolidCube)
            {
                if (bV == FormulaButtonFirst)
                {
                    if (!ValidatePositive(x0)) return;
                    output = x0 * x0 * x0;
                }
                else if (bV == FormulaButtonSecond)
                {
                    if (!ValidatePositive(x0, x1)) return;
                    output = x0 * x1;
                }
                else if (bV == FormulaButtonThird)
                {
                    if (!ValidatePositiveDiagonal(x0)) return;
                    output = (x0 * x0 * x0) / (Three * Math.Sqrt(Three));
                }
                else
                {
                    Output.Text = choose_formula_v;
                    return;
                }
            }
            else if (a == SolidParallelepiped)
            {
                if (bV == FormulaButtonFirst)
                {
                    if (!ValidatePositive(x0, x1, x2)) return;
                    output = x0 * x1 * x2;
                }
                else if (bV == FormulaButtonSecond)
                {
                    if (!ValidatePositive(x0, x1)) return;
                    output = x0 * x1;
                }
                else
                {
                    Output.Text = choose_formula_v12;
                    return;
                }
            }
            else if (a == SolidCylinder)
            {
                if (bV == FormulaButtonFirst)
                {
                    if (!ValidatePositive(x0, x1)) return;
                    output = Math.PI * x0 * x0 * x1;
                }
                else if (bV == FormulaButtonSecond)
                {
                    if (!ValidatePositive(x0, x1)) return;
                    output = (Math.PI * x0 * x0 / Four) * x1;
                }
                else if (bV == FormulaButtonThird)
                {
                    if (!ValidatePositive(x0, x1)) return;
                    output = x0 * x1;
                }
                else
                {
                    Output.Text = choose_formula_v;
                    return;
                }
            }
            else if (a == SolidSphere)
            {
                if (bV == FormulaButtonFirst)
                {
                    if (!ValidatePositive(x0)) return;
                    output = FourThirds * Math.PI * x0 * x0 * x0;
                }
                else if (bV == FormulaButtonSecond)
                {
                    if (!ValidatePositive(x0)) return;
                    output = Math.PI * x0 * x0 * x0 / Six;
                }
                else
                {
                    Output.Text = choose_formula_v12;
                    return;
                }
            }
            else if (a == SolidPyramid)
            {
                if (bV == FormulaButtonFirst)
                {
                    if (!ValidatePositive(x0, x1)) return;
                    output = x0 * x1 / Three;
                }
                else if (bV == FormulaButtonSecond)
                {
                    if (!ValidatePositive(x0, x1)) return;
                    output = (x0 * x0) * x1 / Three;
                }
                else
                {
                    Output.Text = choose_formula_v12;
                    return;
                }
            }
            else if (a == SolidCone)
            {
                if (bV == FormulaButtonFirst)
                {
                    if (!ValidatePositive(x0, x1)) return;
                    output = OneThird * Math.PI * x0 * x0 * x1;
                }
                else if (bV == FormulaButtonSecond)
                {
                    if (!ValidatePositive(x0, x1)) return;
                    output = OneThird * x0 * x1;
                }
                else if (bV == FormulaButtonThird)
                {
                    if (!ValidatePositive(x0, x1)) return;
                    output = (Math.PI * x0 * x0 * x1) / 12.0;
                }
                else
                {
                    Output.Text = choose_formula_v;
                    return;
                }
            }
            else
            {
                Output.Text = solid_not_implemented;
                return;
            }

            ShowResult();
            Output.Text = output.ToString();
        }
    }
}