using System;
using System.Drawing;
using System.Windows.Forms;

namespace SPV_2_C__Graphics_Edition_by_shipovskijkorp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimumSize = new Size(830, 570);
            this.MaximumSize = new Size(830, 570);
            RUS();
        }

        public int a = 0;
        public double output = 0;

        public int bS = 0;
        public int bP = 0;
        public int bV = 0;

        public int mode = 1;

        public int TMode = 1;

        string empty;

        string s1, s2, s3, p1, p2, p3, v1, v2, v3, dash;

        string s_trap_1, s_trap_2, s_trap_3, s_trian_1, heron, s_trian_3, s_circle_1, s_circle_2, s_circle_3, s_rhomb_1, s_rhomb_2, s_rhomb_3;

        string p_trap_1, p_trap_2, p_trian_1, p_trian_2, l_circle_1, l_circle_2, l_circle_3, p_rhomb_1, p_rhomb_2, p_rhomb_3;

        string s_cube_1, s_cube_2, s_cube_3, s_par_1, s_par_2, s_cyl_1, s_cyl_2, s_cyl_3, s_sph_1, s_sph_2, s_pyr_1, s_pyr_2, s_pyr_3, s_cone_1, s_cone_2, s_cone_3;

        string pbase_cube_1, pbase_cube_2, pbase_par_1, lbase_cyl_1, lbase_cyl_2, lbase_cyl_3, pbase_pyr_1, pbase_pyr_2, lbase_cone_1, lbase_cone_2, lbase_cone_3;

        string v_cube_1, v_cube_2, v_cube_3, v_par_1, v_par_2, v_cyl_1, v_cyl_2, v_cyl_3, v_sph_1, v_sph_2, v_pyr_1, v_pyr_2, v_cone_1, v_cone_2, v_cone_3;

        string base_a, base_b, height_h, midline_m, diagonal_d1, diagonal_d2, sin_phi, side_a, side_b, side_c, sin_gamma, radius_r, diameter_d, length_l, sin_alpha, side_c_trap, side_d_trap, area_s;
        string edge_a, cube_diag_d, base_area_sbase, base_perimeter_pbase, height_c, base_length_l, lateral_area_slateral, base_side_a, apothem_l, slant_l, base_area_s;

        string enter_values_press_sqr, enter_value_press_sqr, enter_values_press_per, enter_value_press_per, enter_values_press_vol;

        string choose_formula_s, choose_formula_p, choose_formula_p12, choose_formula_v, choose_formula_v12;

        string no_s3_for_this_solid, no_s3_for_sphere, sphere_has_no_base_perimeter, no_p3_for_cube, only_p1_for_par, no_p3_for_pyramid, no_v3_for_par, no_v3_for_sphere, no_v3_for_pyramid;

        string figure_not_implemented, solid_not_implemented, impossible_triangle, r_cannot_be_0, s_cannot_be_lt_0, h_cannot_be_0, switch_to_spv_mode;

        string square_2d, rectangle_2d, trapezoid_2d, triangle_2d, circle_2d, rhombus_2d;
        string cube_3d, parallelepiped_3d, cylinder_3d, sphere_3d, pyramid_3d, cone_3d;

        string per, squ, vol, res;

        string parallelogram_2d;

        string s_paral_1, s_paral_2, s_paral_3;
        string p_paral_1, p_paral_2, p_paral_3;

        string sin_beta;

        private void UpdateFigureImage()
        {
            if (!FigImage.Visible) return;

            if (mode == 1)
            {
                if (a == 1) FigImage.Image = SP_2_C__Graphics_Edition_by_shipovskijkorp.Properties.Resources.Quad;
                else if (a == 2) FigImage.Image = SP_2_C__Graphics_Edition_by_shipovskijkorp.Properties.Resources.Rect;
                else if (a == 3) FigImage.Image = SP_2_C__Graphics_Edition_by_shipovskijkorp.Properties.Resources.Trap;
                else if (a == 4) FigImage.Image = SP_2_C__Graphics_Edition_by_shipovskijkorp.Properties.Resources.Trian;
                else if (a == 5) FigImage.Image = SP_2_C__Graphics_Edition_by_shipovskijkorp.Properties.Resources.Okr;
                else if (a == 6) FigImage.Image = SP_2_C__Graphics_Edition_by_shipovskijkorp.Properties.Resources.Romb;
                else if (a == 7) FigImage.Image = SP_2_C__Graphics_Edition_by_shipovskijkorp.Properties.Resources.Paral;
                return;
            }
            if (mode == 2)
            {
                if (a == 101) FigImage.Image = SP_2_C__Graphics_Edition_by_shipovskijkorp.Properties.Resources.Qub;
                else if (a == 102) FigImage.Image = SP_2_C__Graphics_Edition_by_shipovskijkorp.Properties.Resources.Par;
                else if (a == 103) FigImage.Image = SP_2_C__Graphics_Edition_by_shipovskijkorp.Properties.Resources.Cil;
                else if (a == 104) FigImage.Image = SP_2_C__Graphics_Edition_by_shipovskijkorp.Properties.Resources.Sph;
                else if (a == 105) FigImage.Image = SP_2_C__Graphics_Edition_by_shipovskijkorp.Properties.Resources.Pir;
                else if (a == 106) FigImage.Image = SP_2_C__Graphics_Edition_by_shipovskijkorp.Properties.Resources.Kon;
            }
        }

        private void HideInputs()
        {
            Text0.Visible = Text1.Visible = Text2.Visible = Text3.Visible = false;
            Input0.Visible = Input1.Visible = Input2.Visible = Input3.Visible = false;
            Output.Visible = ResT.Visible = false;
            Swipe.Visible = false;
        }

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

            if (mode == 1)
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

        private void ConfigureAreaFormulaButtons()
        {
            S1F.Text = s1;
            S2F.Text = s2;
            S3F.Text = s3;

            if (a == 3)
            {
                S1F.Text = s_trap_1;
                S2F.Text = s_trap_2;
                S3F.Text = s_trap_3;
            }
            else if (a == 4)
            {
                S1F.Text = s_trian_1;
                S2F.Text = heron;
                S3F.Text = s_trian_3;
            }
            else if (a == 5)
            {
                S1F.Text = s_circle_1;
                S2F.Text = s_circle_2;
                S3F.Text = s_circle_3;
            }
            else if (a == 6)
            {
                S1F.Text = s_rhomb_1;
                S2F.Text = s_rhomb_2;
                S3F.Text = s_rhomb_3;
            }
            else if (a == 7)
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

            if (a == 3)
            {
                P1F.Text = p_trap_1;
                P2F.Text = p_trap_2;
                P3F.Text = dash;
            }
            else if (a == 4)
            {
                P1F.Text = p_trian_1;
                P2F.Text = p_trian_2;
                P3F.Text = dash;
            }
            else if (a == 5)
            {
                P1F.Text = l_circle_1;
                P2F.Text = l_circle_2;
                P3F.Text = l_circle_3;
            }
            else if (a == 6)
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

            if (a == 101)
            {
                S1F.Text = s_cube_1;
                S2F.Text = s_cube_2;
                S3F.Text = s_cube_3;
            }
            else if (a == 102)
            {
                S1F.Text = s_par_1;
                S2F.Text = s_par_2;
                S3F.Text = dash;
            }
            else if (a == 103)
            {
                S1F.Text = s_cyl_1;
                S2F.Text = s_cyl_2;
                S3F.Text = s_cyl_3;
            }
            else if (a == 104)
            {
                S1F.Text = s_sph_1;
                S2F.Text = s_sph_2;
                S3F.Text = dash;
            }
            else if (a == 105)
            {
                S1F.Text = s_pyr_1;
                S2F.Text = s_pyr_2;
                S3F.Text = s_pyr_3;
            }
            else if (a == 106)
            {
                S1F.Text = s_cone_1;
                S2F.Text = s_cone_2;
                S3F.Text = s_cone_3;
            }
        }

        private void ConfigureSolidBasePerimeterButtons()
        {
            P1F.Text = p1;
            P2F.Text = p2;
            P3F.Text = p3;

            if (a == 101)
            {
                P1F.Text = pbase_cube_1;
                P2F.Text = pbase_cube_2;
                P3F.Text = dash;
            }
            else if (a == 102)
            {
                P1F.Text = pbase_par_1;
                P2F.Text = dash;
                P3F.Text = dash;
            }
            else if (a == 103)
            {
                P1F.Text = lbase_cyl_1;
                P2F.Text = lbase_cyl_2;
                P3F.Text = lbase_cyl_3;
            }
            else if (a == 104)
            {
                P1F.Text = dash;
                P2F.Text = dash;
                P3F.Text = dash;
            }
            else if (a == 105)
            {
                P1F.Text = pbase_pyr_1;
                P2F.Text = pbase_pyr_2;
                P3F.Text = dash;
            }
            else if (a == 106)
            {
                P1F.Text = lbase_cone_1;
                P2F.Text = lbase_cone_2;
                P3F.Text = lbase_cone_3;
            }
        }

        private void ConfigureVolumeFormulaButtons()
        {
            V1F.Text = v1;
            V2F.Text = v2;
            V3F.Text = v3;

            if (a == 101)
            {
                V1F.Text = v_cube_1;
                V2F.Text = v_cube_2;
                V3F.Text = v_cube_3;
            }
            else if (a == 102)
            {
                V1F.Text = v_par_1;
                V2F.Text = v_par_2;
                V3F.Text = dash;
            }
            else if (a == 103)
            {
                V1F.Text = v_cyl_1;
                V2F.Text = v_cyl_2;
                V3F.Text = v_cyl_3;
            }
            else if (a == 104)
            {
                V1F.Text = v_sph_1;
                V2F.Text = v_sph_2;
                V3F.Text = dash;
            }
            else if (a == 105)
            {
                V1F.Text = v_pyr_1;
                V2F.Text = v_pyr_2;
                V3F.Text = dash;
            }
            else if (a == 106)
            {
                V1F.Text = v_cone_1;
                V2F.Text = v_cone_2;
                V3F.Text = v_cone_3;
            }
        }

        private void SelectTrapezoidAreaFormula(int formula)
        {
            a = 3; bS = formula;
            HideInputs();
            ShowResult();

            Text0.Visible = Input0.Visible = true;
            Text1.Visible = Input1.Visible = true;

            if (formula == 1)
            {
                Text0.Text = base_a;
                Text1.Text = base_b;
                Text2.Text = height_h;
                Text2.Visible = Input2.Visible = true;
            }
            else if (formula == 2)
            {
                Text0.Text = midline_m;
                Text1.Text = height_h;
            }
            else if (formula == 3)
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
            a = 4; bS = formula;
            HideInputs();
            ShowResult();

            if (formula == 8)
            {
                Text0.Visible = Input0.Visible = true;
                Text1.Visible = Input1.Visible = true;
                Text0.Text = base_a;
                Text1.Text = height_h;
            }
            else if (formula == 9)
            {
                Text0.Visible = Input0.Visible = true;
                Text1.Visible = Input1.Visible = true;
                Text2.Visible = Input2.Visible = true;
                Text0.Text = side_a;
                Text1.Text = side_b;
                Text2.Text = side_c;
            }
            else if (formula == 10)
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
            a = 5; bS = formula;
            HideInputs();
            ShowResult();

            Text0.Visible = Input0.Visible = true;
            if (formula == 11) Text0.Text = radius_r;
            else if (formula == 12) Text0.Text = diameter_d;
            else if (formula == 13) Text0.Text = length_l;

            Output.Text = enter_value_press_sqr;
        }

        private void SelectRhombusAreaFormula(int formula)
        {
            a = 6; bS = formula;
            HideInputs();
            ShowResult();

            if (formula == 17)
            {
                Text0.Visible = Input0.Visible = true;
                Text1.Visible = Input1.Visible = true;
                Text0.Text = side_a;
                Text1.Text = height_h;
            }
            else if (formula == 18)
            {
                Text0.Visible = Input0.Visible = true;
                Text1.Visible = Input1.Visible = true;
                Text0.Text = diagonal_d1;
                Text1.Text = diagonal_d2;
            }
            else if (formula == 19)
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
            a = 3; bP = formula;
            HideInputs();
            ShowResult();

            Text0.Visible = Input0.Visible = true;
            Text1.Visible = Input1.Visible = true;

            if (formula == 4)
            {
                Text0.Text = base_a;
                Text1.Text = base_b;
                Text2.Text = side_c_trap;
                Text3.Text = side_d_trap;
                Text2.Visible = Input2.Visible = true;
                Text3.Visible = Input3.Visible = true;
            }
            else if (formula == 5)
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
            a = 4; bP = formula;
            HideInputs();
            ShowResult();

            if (formula == 6)
            {
                Text0.Visible = Input0.Visible = true;
                Text1.Visible = Input1.Visible = true;
                Text2.Visible = Input2.Visible = true;
                Text0.Text = side_a;
                Text1.Text = side_b;
                Text2.Text = side_c;
            }
            else if (formula == 7)
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
            a = 5; bP = formula;
            HideInputs();
            ShowResult();

            Text0.Visible = Input0.Visible = true;
            if (formula == 14) Text0.Text = radius_r;
            else if (formula == 15) Text0.Text = diameter_d;
            else if (formula == 16) Text0.Text = area_s;

            Output.Text = enter_value_press_per;
        }

        private void SelectRhombusPerimeterFormula(int formula)
        {
            a = 6; bP = formula;
            HideInputs();
            ShowResult();

            if (formula == 20)
            {
                Text0.Visible = Input0.Visible = true;
                Text0.Text = side_a;
            }
            else if (formula == 21)
            {
                Text0.Visible = Input0.Visible = true;
                Text1.Visible = Input1.Visible = true;
                Text0.Text = diagonal_d1;
                Text1.Text = diagonal_d2;
            }
            else if (formula == 22)
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
            a = 7;
            bS = formula;
            HideInputs();
            ShowResult();

            if (formula == 23)
            {
                Text0.Visible = Input0.Visible = true;
                Text1.Visible = Input1.Visible = true;
                Text0.Text = side_a;
                Text1.Text = height_h;
            }
            else if (formula == 24)
            {
                Text0.Visible = Input0.Visible = true;
                Text1.Visible = Input1.Visible = true;
                Text2.Visible = Input2.Visible = true;
                Text0.Text = side_a;
                Text1.Text = side_b;
                Text2.Text = sin_beta;
            }
            else if (formula == 25)
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

            if (a == 101)
            {
                if (formula == 1) { Text0.Visible = Input0.Visible = true; Text0.Text = edge_a; }
                else if (formula == 2) { Text0.Visible = Input0.Visible = true; Text0.Text = cube_diag_d; }
                else if (formula == 3) { Text0.Visible = Input0.Visible = true; Text0.Text = base_area_sbase; }
            }
            else if (a == 102)
            {
                if (formula == 1)
                {
                    Text0.Visible = Input0.Visible = true;
                    Text1.Visible = Input1.Visible = true;
                    Text2.Visible = Input2.Visible = true;
                    Text0.Text = side_a;
                    Text1.Text = side_b;
                    Text2.Text = height_c;
                }
                else if (formula == 2)
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
            else if (a == 103)
            {
                if (formula == 1 || formula == 2)
                {
                    Text0.Visible = Input0.Visible = true;
                    Text1.Visible = Input1.Visible = true;
                    Text0.Text = radius_r;
                    Text1.Text = height_h;
                }
                else if (formula == 3)
                {
                    Text0.Visible = Input0.Visible = true;
                    Text1.Visible = Input1.Visible = true;
                    Text2.Visible = Input2.Visible = true;
                    Text0.Text = base_area_sbase;
                    Text1.Text = base_length_l;
                    Text2.Text = height_h;
                }
            }
            else if (a == 104)
            {
                Text0.Visible = Input0.Visible = true;
                Text0.Text = (formula == 2) ? diameter_d : radius_r;
                if (formula == 3) { Output.Text = no_s3_for_sphere; return; }
            }
            else if (a == 105)
            {
                if (formula == 1)
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
            else if (a == 106)
            {
                if (formula == 3)
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

        private void SelectSolidBasePerimeterFormula(int formula)
        {
            bP = formula;
            HideInputs();
            ShowResult();

            if (a == 104)
            {
                Output.Text = sphere_has_no_base_perimeter;
                return;
            }

            if (a == 101)
            {
                if (formula == 1) { Text0.Visible = Input0.Visible = true; Text0.Text = edge_a; }
                else if (formula == 2) { Text0.Visible = Input0.Visible = true; Text0.Text = base_area_sbase; }
                else { Output.Text = no_p3_for_cube; return; }
            }
            else if (a == 102)
            {
                if (formula != 1) { Output.Text = only_p1_for_par; return; }

                Text0.Visible = Input0.Visible = true;
                Text1.Visible = Input1.Visible = true;
                Text0.Text = side_a;
                Text1.Text = side_b;
            }
            else if (a == 103 || a == 106)
            {
                Text0.Visible = Input0.Visible = true;
                if (formula == 1) Text0.Text = radius_r;
                else if (formula == 2) Text0.Text = diameter_d;
                else if (formula == 3) Text0.Text = base_area_sbase;
            }
            else if (a == 105)
            {
                if (formula == 1) { Text0.Visible = Input0.Visible = true; Text0.Text = base_side_a; }
                else if (formula == 2) { Text0.Visible = Input0.Visible = true; Text0.Text = base_area_sbase; }
                else { Output.Text = no_p3_for_pyramid; return; }
            }

            Output.Text = enter_values_press_per;
        }

        private void SelectVolumeFormula(int formula)
        {
            bV = formula;
            HideInputs();
            ShowResult();

            if (a == 101)
            {
                if (formula == 1) { Text0.Visible = Input0.Visible = true; Text0.Text = edge_a; }
                else if (formula == 2) { Text0.Visible = Input0.Visible = true; Text1.Visible = Input1.Visible = true; Text0.Text = base_area_s; Text1.Text = height_h; }
                else if (formula == 3) { Text0.Visible = Input0.Visible = true; Text0.Text = cube_diag_d; }
            }
            else if (a == 102)
            {
                if (formula == 1)
                {
                    Text0.Visible = Input0.Visible = true;
                    Text1.Visible = Input1.Visible = true;
                    Text2.Visible = Input2.Visible = true;
                    Text0.Text = side_a;
                    Text1.Text = side_b;
                    Text2.Text = height_c;
                }
                else if (formula == 2)
                {
                    Text0.Visible = Input0.Visible = true;
                    Text1.Visible = Input1.Visible = true;
                    Text0.Text = base_area_s;
                    Text1.Text = height_h;
                }
                else { Output.Text = no_v3_for_par; return; }
            }
            else if (a == 103)
            {
                if (formula == 1 || formula == 2)
                {
                    Text0.Visible = Input0.Visible = true;
                    Text1.Visible = Input1.Visible = true;
                    Text0.Text = (formula == 2) ? diameter_d : radius_r;
                    Text1.Text = height_h;
                }
                else if (formula == 3)
                {
                    Text0.Visible = Input0.Visible = true;
                    Text1.Visible = Input1.Visible = true;
                    Text0.Text = base_area_s;
                    Text1.Text = height_h;
                }
            }
            else if (a == 104)
            {
                if (formula == 3) { Output.Text = no_v3_for_sphere; return; }
                Text0.Visible = Input0.Visible = true;
                Text0.Text = (formula == 2) ? diameter_d : radius_r;
            }
            else if (a == 105)
            {
                if (formula == 3) { Output.Text = no_v3_for_pyramid; return; }
                Text0.Visible = Input0.Visible = true;
                Text1.Visible = Input1.Visible = true;
                Text0.Text = (formula == 2) ? base_side_a : base_area_s;
                Text1.Text = height_h;
            }
            else if (a == 106)
            {
                Text0.Visible = Input0.Visible = true;
                Text1.Visible = Input1.Visible = true;
                if (formula == 1) Text0.Text = radius_r;
                else if (formula == 2) Text0.Text = base_area_s;
                else if (formula == 3) Text0.Text = diameter_d;
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

            if (mode == 1)
            {
                a = 1;

                HideInputs(); ShowResult();
                Text0.Visible = Input0.Visible = true;
                Text0.Text = side_a;
            }
            else
            {
                a = 101;
            }

            UpdateFigureImage();
        }

        private void Rect_Click(object sender, EventArgs e)
        {
            ResetUI();
            ShowBaseForFigure();

            if (mode == 1)
            {
                a = 2;
                Rect.Text = rectangle_2d;

                HideInputs(); ShowResult();
                Text0.Visible = Input0.Visible = true;
                Text1.Visible = Input1.Visible = true;
                Text0.Text = side_a;
                Text1.Text = side_b;
                Swipe.Visible = true;
            }
            else
            {
                a = 102;
            }

            UpdateFigureImage();
        }

        private void Okr_Click(object sender, EventArgs e)
        {
            ResetUI();
            ShowBaseForFigure();

            if (mode == 1) a = 5;
            else a = 103;

            UpdateFigureImage();
        }

        private void Romb_Click(object sender, EventArgs e)
        {
            ResetUI();
            ShowBaseForFigure();

            if (mode == 1) a = 6;
            else a = 104;

            UpdateFigureImage();
        }

        private void Trap_Click(object sender, EventArgs e)
        {
            ResetUI();
            ShowBaseForFigure();

            if (mode == 1) a = 3;
            else a = 105;

            UpdateFigureImage();
        }

        private void Trian_Click(object sender, EventArgs e)
        {
            ResetUI();
            ShowBaseForFigure();

            if (mode == 1) a = 4;
            else a = 106;

            UpdateFigureImage();
        }

        private void Sqr_Click(object sender, EventArgs e)
        {
            HideFormulaButtons();

            if (mode == 2 && a >= 101 && a <= 106)
            {
                ConfigureSolidSurfaceButtons();
                S1F.Visible = S2F.Visible = S3F.Visible = true;

                if (bS == 0) { ShowResult(); Output.Text = choose_formula_s; return; }

                double x0 = (double)Input0.Value;
                double x1 = (double)Input1.Value;
                double x2 = (double)Input2.Value;

                if (a == 101)
                {
                    if (bS == 1) output = 6.0 * x0 * x0;
                    else if (bS == 2) output = 2.0 * x0 * x0;
                    else if (bS == 3) output = 6.0 * x0;
                }
                else if (a == 102)
                {
                    if (bS == 1) output = 2.0 * (x0 * x1 + x0 * x2 + x1 * x2);
                    else if (bS == 2) output = 2.0 * x0 + x1 * x2;
                    else { ShowResult(); Output.Text = no_s3_for_this_solid; return; }
                }
                else if (a == 103)
                {
                    if (bS == 1) output = 2.0 * Math.PI * x0 * (x1 + x0);
                    else if (bS == 2) output = 2.0 * Math.PI * x0 * x1 + 2.0 * Math.PI * x0 * x0;
                    else if (bS == 3) output = 2.0 * x0 + x1 * x2;
                }
                else if (a == 104)
                {
                    if (bS == 1) output = 4.0 * Math.PI * x0 * x0;
                    else if (bS == 2) output = Math.PI * x0 * x0;
                    else { ShowResult(); Output.Text = no_s3_for_sphere; return; }
                }
                else if (a == 105)
                {
                    if (bS == 1) output = x0 + x1;
                    else if (bS == 2) output = x0 * x0 + 2.0 * x0 * x1;
                    else if (bS == 3) output = x0 * x0 + (4.0 * x0 * x1) / 2.0;
                }
                else if (a == 106)
                {
                    if (bS == 1) output = Math.PI * x0 * (x0 + x1);
                    else if (bS == 2) output = Math.PI * x0 * x0 + Math.PI * x0 * x1;
                    else if (bS == 3)
                    {
                        double r = x0 / 2.0;
                        output = Math.PI * r * r + Math.PI * r * x1;
                    }
                }

                ShowResult();
                Output.Text = output.ToString();
                return;
            }

            if (a == 3 || a == 4 || a == 5 || a == 6 || a == 7)
            {
                ConfigureAreaFormulaButtons();
                S1F.Visible = S2F.Visible = S3F.Visible = true;

                if (bS == 0) { ShowResult(); Output.Text = choose_formula_s; return; }
            }

            double x0_2 = (double)Input0.Value;
            double x1_2 = (double)Input1.Value;
            double x2_2 = (double)Input2.Value;

            if (a == 1) output = x0_2 * x0_2;
            else if (a == 2) output = x0_2 * x1_2;
            else if (a == 3)
            {
                if (bS == 1) output = 0.5 * (x0_2 + x1_2) * x2_2;
                else if (bS == 2) output = x0_2 * x1_2;
                else if (bS == 3) output = 0.5 * (x0_2 * x1_2) * x2_2;
                else { ShowResult(); Output.Text = choose_formula_s; return; }
            }
            else if (a == 4)
            {
                if (bS == 8) output = 0.5 * x0_2 * x1_2;
                else if (bS == 9)
                {
                    double s = (x0_2 + x1_2 + x2_2) / 2.0;
                    double under = s * (s - x0_2) * (s - x1_2) * (s - x2_2);
                    if (under < 0) { ShowResult(); Output.Text = impossible_triangle; return; }
                    output = Math.Sqrt(under);
                }
                else if (bS == 10) output = 0.5 * x0_2 * x1_2 * x2_2;
                else { ShowResult(); Output.Text = choose_formula_s; return; }
            }
            else if (a == 5)
            {
                if (bS == 11) output = Math.PI * x0_2 * x0_2;
                else if (bS == 12) output = Math.PI * x0_2 * x0_2 / 4.0;
                else if (bS == 13) output = (x0_2 * x0_2) / (4.0 * Math.PI);
                else { ShowResult(); Output.Text = choose_formula_s; return; }
            }
            else if (a == 6)
            {
                if (bS == 17) output = x0_2 * x1_2;
                else if (bS == 18) output = 0.5 * x0_2 * x1_2;
                else if (bS == 19) output = x0_2 * x0_2 * x1_2;
                else { ShowResult(); Output.Text = choose_formula_s; return; }
            }
            else if (a == 7)
            {
                if (bS == 23) output = x0_2 * x1_2;
                else if (bS == 24) output = x0_2 * x1_2 * x2_2;
                else if (bS == 25) output = x0_2 * x1_2 * x2_2 / 2.0;
                else { ShowResult(); Output.Text = choose_formula_s; return; }
            }
            else { ShowResult(); Output.Text = figure_not_implemented; return; }

            ShowResult();
            Output.Text = output.ToString();
        }

        private void Per_Click(object sender, EventArgs e)
        {
            HideFormulaButtons();

            if (mode == 2 && a >= 101 && a <= 106)
            {
                if (a == 104) { ShowResult(); Output.Text = sphere_has_no_base_perimeter; return; }

                ConfigureSolidBasePerimeterButtons();

                if (a == 102) { P1F.Visible = true; }
                else if (a == 101 || a == 105) { P1F.Visible = P2F.Visible = true; }
                else { P1F.Visible = P2F.Visible = P3F.Visible = true; }

                if (bP == 0) { ShowResult(); Output.Text = choose_formula_p; return; }

                double x0 = (double)Input0.Value;
                double x1 = (double)Input1.Value;

                if (a == 101)
                {
                    if (bP == 1) output = 4.0 * x0;
                    else if (bP == 2) output = 4.0 * Math.Sqrt(x0);
                    else { ShowResult(); Output.Text = choose_formula_p12; return; }
                }
                else if (a == 102)
                {
                    if (bP != 1) { ShowResult(); Output.Text = only_p1_for_par; return; }
                    output = 2.0 * (x0 + x1);
                }
                else if (a == 103 || a == 106)
                {
                    if (bP == 1) output = 2.0 * Math.PI * x0;
                    else if (bP == 2) output = Math.PI * x0;
                    else if (bP == 3) output = Math.Sqrt(4.0 * Math.PI * x0);
                    else { ShowResult(); Output.Text = choose_formula_p; return; }
                }
                else if (a == 105)
                {
                    if (bP == 1) output = 4.0 * x0;
                    else if (bP == 2) output = 4.0 * Math.Sqrt(x0);
                    else { ShowResult(); Output.Text = choose_formula_p12; return; }
                }

                ShowResult();
                Output.Text = output.ToString();
                return;
            }

            if (a == 3 || a == 4 || a == 5 || a == 6)
            {
                ConfigurePerimeterFormulaButtons();
                if (a == 5 || a == 6) P1F.Visible = P2F.Visible = P3F.Visible = true;
                else P1F.Visible = P2F.Visible = true;

                if (bP == 0) { ShowResult(); Output.Text = choose_formula_p; return; }
            }

            double x0_2 = (double)Input0.Value;
            double x1_2 = (double)Input1.Value;
            double x2_2 = (double)Input2.Value;
            double x3_2 = (double)Input3.Value;

            if (a == 1) output = x0_2 * 4;
            else if (a == 2) output = x0_2 * 2 + x1_2 * 2;
            else if (a == 3)
            {
                if (bP == 4) output = x0_2 + x1_2 + x2_2 + x3_2;
                else if (bP == 5) output = x0_2 + x1_2 + x2_2 * 2;
                else { ShowResult(); Output.Text = choose_formula_p12; return; }
            }
            else if (a == 4)
            {
                if (bP == 6) output = x0_2 + x1_2 + x2_2;
                else if (bP == 7)
                {
                    if (x1_2 == 0) { ShowResult(); Output.Text = r_cannot_be_0; return; }
                    output = 2.0 * x0_2 / x1_2;
                }
                else { ShowResult(); Output.Text = choose_formula_p12; return; }
            }
            else if (a == 5)
            {
                if (bP == 14) output = 2.0 * Math.PI * x0_2;
                else if (bP == 15) output = Math.PI * x0_2;
                else if (bP == 16)
                {
                    if (x0_2 < 0) { ShowResult(); Output.Text = s_cannot_be_lt_0; return; }
                    output = Math.Sqrt(4.0 * Math.PI * x0_2);
                }
                else { ShowResult(); Output.Text = choose_formula_p; return; }
            }
            else if (a == 6)
            {
                if (bP == 20) output = 4.0 * x0_2;
                else if (bP == 21) output = 2.0 * Math.Sqrt(x0_2 * x0_2 + x1_2 * x1_2);
                else if (bP == 22)
                {
                    if (x1_2 == 0) { ShowResult(); Output.Text = h_cannot_be_0; return; }
                    output = 4.0 * x0_2 / x1_2;
                }
                else { ShowResult(); Output.Text = choose_formula_p; return; }
            }
            else if (a == 7)
            {
                output = x0_2 * 2 + x1_2 * 2;
            }
            else { ShowResult(); Output.Text = figure_not_implemented; return; }

            ShowResult();
            Output.Text = output.ToString();
        }

        private void Vol_Click(object sender, EventArgs e)
        {
            if (mode != 2)
            {
                ShowResult();
                Output.Text = switch_to_spv_mode;
                return;
            }

            HideFormulaButtons();

            ConfigureVolumeFormulaButtons();
            V1F.Visible = V2F.Visible = true;
            V3F.Visible = (a == 101 || a == 103 || a == 106);

            if (bV == 0)
            {
                ShowResult();
                Output.Text = choose_formula_v;
                return;
            }

            double x0 = (double)Input0.Value;
            double x1 = (double)Input1.Value;
            double x2 = (double)Input2.Value;

            if (a == 101)
            {
                if (bV == 1) output = x0 * x0 * x0;
                else if (bV == 2) output = x0 * x1;
                else if (bV == 3) output = (x0 * x0 * x0) / (3.0 * Math.Sqrt(3.0));
                else { Output.Text = choose_formula_v; return; }
            }
            else if (a == 102)
            {
                if (bV == 1) output = x0 * x1 * x2;
                else if (bV == 2) output = x0 * x1;
                else { Output.Text = choose_formula_v12; return; }
            }
            else if (a == 103)
            {
                if (bV == 1) output = Math.PI * x0 * x0 * x1;
                else if (bV == 2) output = (Math.PI * x0 * x0 / 4.0) * x1;
                else if (bV == 3) output = x0 * x1;
                else { Output.Text = choose_formula_v; return; }
            }
            else if (a == 104)
            {
                if (bV == 1) output = (4.0 / 3.0) * Math.PI * x0 * x0 * x0;
                else if (bV == 2) output = Math.PI * x0 * x0 * x0 / 6.0;
                else { Output.Text = choose_formula_v12; return; }
            }
            else if (a == 105)
            {
                if (bV == 1) output = x0 * x1 / 3.0;
                else if (bV == 2) output = (x0 * x0) * x1 / 3.0;
                else { Output.Text = choose_formula_v12; return; }
            }
            else if (a == 106)
            {
                if (bV == 1) output = (1.0 / 3.0) * Math.PI * x0 * x0 * x1;
                else if (bV == 2) output = (1.0 / 3.0) * x0 * x1;
                else if (bV == 3) output = (Math.PI * x0 * x0 * x1) / 12.0;
                else { Output.Text = choose_formula_v; return; }
            }
            else { Output.Text = solid_not_implemented; return; }

            ShowResult();
            Output.Text = output.ToString();
        }

        private void S1F_Click(object sender, EventArgs e)
        {
            if (mode == 2 && a >= 101 && a <= 106) SelectSolidSurfaceFormula(1);
            else if (a == 3) SelectTrapezoidAreaFormula(1);
            else if (a == 4) SelectTriangleAreaFormula(8);
            else if (a == 5) SelectCircleAreaFormula(11);
            else if (a == 6) SelectRhombusAreaFormula(17);
            else if (a == 7) SelectParallelogramAreaFormula(23);
        }

        private void S2F_Click(object sender, EventArgs e)
        {
            if (mode == 2 && a >= 101 && a <= 106) SelectSolidSurfaceFormula(2);
            else if (a == 3) SelectTrapezoidAreaFormula(2);
            else if (a == 4) SelectTriangleAreaFormula(9);
            else if (a == 5) SelectCircleAreaFormula(12);
            else if (a == 6) SelectRhombusAreaFormula(18);
            else if (a == 7) SelectParallelogramAreaFormula(24);
        }

        private void S3F_Click(object sender, EventArgs e)
        {
            if (mode == 2 && a >= 101 && a <= 106) SelectSolidSurfaceFormula(3);
            else if (a == 3) SelectTrapezoidAreaFormula(3);
            else if (a == 4) SelectTriangleAreaFormula(10);
            else if (a == 5) SelectCircleAreaFormula(13);
            else if (a == 6) SelectRhombusAreaFormula(19);
            else if (a == 7) SelectParallelogramAreaFormula(25);
        }

        private void P1F_Click(object sender, EventArgs e)
        {
            if (mode == 2 && a >= 101 && a <= 106) SelectSolidBasePerimeterFormula(1);
            else if (a == 3) SelectTrapezoidPerimeterFormula(4);
            else if (a == 4) SelectTrianglePerimeterFormula(6);
            else if (a == 5) SelectCirclePerimeterFormula(14);
            else if (a == 6) SelectRhombusPerimeterFormula(20);
        }

        private void P2F_Click(object sender, EventArgs e)
        {
            if (mode == 2 && a >= 101 && a <= 106) SelectSolidBasePerimeterFormula(2);
            else if (a == 3) SelectTrapezoidPerimeterFormula(5);
            else if (a == 4) SelectTrianglePerimeterFormula(7);
            else if (a == 5) SelectCirclePerimeterFormula(15);
            else if (a == 6) SelectRhombusPerimeterFormula(21);
        }

        private void P3F_Click(object sender, EventArgs e)
        {
            if (mode == 2 && a >= 101 && a <= 106) SelectSolidBasePerimeterFormula(3);
            else if (a == 5) SelectCirclePerimeterFormula(16);
            else if (a == 6) SelectRhombusPerimeterFormula(22);
        }

        private void V1F_Click(object sender, EventArgs e) => SelectVolumeFormula(1);
        private void V2F_Click(object sender, EventArgs e) => SelectVolumeFormula(2);
        private void V3F_Click(object sender, EventArgs e) => SelectVolumeFormula(3);

        private void SP_Click(object sender, EventArgs e)
        {
            mode = 1;
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

            UpdateFigureImage();
        }

        private void SPV_Click(object sender, EventArgs e)
        {
            mode = 2;
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
            heron = "Герон";
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

            pbase_cube_1 = "Pосн = 4a";
            pbase_cube_2 = "Pосн = 4·√(Sосн)";
            pbase_par_1 = "Pосн = 2(a+b)";
            lbase_cyl_1 = "Lосн = 2πr";
            lbase_cyl_2 = "Lосн = πd";
            lbase_cyl_3 = "Lосн = √(4πSосн)";
            pbase_pyr_1 = "Pосн = 4a";
            pbase_pyr_2 = "Pосн = 4·√(Sосн)";
            lbase_cone_1 = "Lосн = 2πr";
            lbase_cone_2 = "Lосн = πd";
            lbase_cone_3 = "Lосн = √(4πSосн)";

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
            side_c_trap = "Боковая c:";
            side_d_trap = "Боковая d:";
            area_s = "Площадь S:";
            edge_a = "Ребро a:";
            cube_diag_d = "Диагональ куба d:";
            base_area_sbase = "Sосн:";
            base_perimeter_pbase = "Pосн:";
            height_c = "Высота c:";
            base_length_l = "Lосн:";
            lateral_area_slateral = "Sбок:";
            base_side_a = "Сторона основания a:";
            apothem_l = "Апофема l:";
            slant_l = "Образующая l:";
            base_area_s = "Sосн:";

            enter_values_press_sqr = "Введи значения и нажми Sqr ";
            enter_value_press_sqr = "Введи значение и нажми Sqr ";
            enter_values_press_per = "Введи значения и нажми Per ";
            enter_value_press_per = "Введи значение и нажми Per ";
            enter_values_press_vol = "Введи значения и нажми Vol ";

            choose_formula_s = "Выбери формулу";
            choose_formula_p = "Выбери формулу";
            choose_formula_p12 = "Выбери формулу";
            choose_formula_v = "Выбери формулу";
            choose_formula_v12 = "Выбери формулу";

            no_s3_for_this_solid = "Для этого тела S3 нет ";
            no_s3_for_sphere = "Для сферы S3 нет ";
            sphere_has_no_base_perimeter = "У сферы нет основания и периметра ";
            no_p3_for_cube = "Для куба P3 нет ";
            only_p1_for_par = "Для параллелепипеда только P1 ";
            no_p3_for_pyramid = "Для пирамиды P3 нет ";
            no_v3_for_par = "Для параллелепипеда V3 нет ";
            no_v3_for_sphere = "Для сферы V3 нет ";
            no_v3_for_pyramid = "Для пирамиды V3 нет ";

            figure_not_implemented = "Фигура не реализована";
            solid_not_implemented = "Тело не реализовано";
            impossible_triangle = "Невозможный треугольник";

            r_cannot_be_0 = "r не может быть 0";
            s_cannot_be_lt_0 = "S не может быть < 0";
            h_cannot_be_0 = "h не может быть 0";

            switch_to_spv_mode = "Переключись в режим SPV";

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

            per = "Периметр\r\n(клик для вычисления)";
            squ = "Площадь\r\n(клик для вычисления)";
            vol = "Обьем\r\n(клик для вычисления)";
            res = "Результат: ";

            parallelogram_2d = "Параллелограмм";

            s_paral_1 = "S = a·h";
            s_paral_2 = "S = a·b·sin(β)";
            s_paral_3 = "S = d1·d2·sin(φ) / 2";

            p_paral_1 = "P = 2(a+b)";
            p_paral_2 = "P = 2a+2b";
            p_paral_3 = "—";

            sin_beta = "sin(β):";

            if (mode == 1) SP_Click(this, EventArgs.Empty);
            else SPV_Click(this, EventArgs.Empty);

            LangUIRefresh();
        }

        void ENG()
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
            heron = "Heron";
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
            s_pyr_1 = "S = Sbase + Ssight";
            s_pyr_2 = "S = a² + 2a·l";
            s_pyr_3 = "S = a² + (Pbase·l)/2";
            s_cone_1 = "S = πr(r+l)";
            s_cone_2 = "S = πr² + πrl";
            s_cone_3 = "S = π(d²/4) + π(d/2)l";

            pbase_cube_1 = "Pbase = 4a";
            pbase_cube_2 = "Pbase = 4·√(Sbase)";
            pbase_par_1 = "Pbase = 2(a+b)";
            lbase_cyl_1 = "Lbase = 2πr";
            lbase_cyl_2 = "Lbase = πd";
            lbase_cyl_3 = "Lbase = √(4πSbase)";
            pbase_pyr_1 = "Pbase = 4a";
            pbase_pyr_2 = "Pbase = 4·√(Sbase)";
            lbase_cone_1 = "Lbase = 2πr";
            lbase_cone_2 = "Lbase = πd";
            lbase_cone_3 = "Lbase = √(4πSbase)";

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
            sin_phi = "sin(a):";
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
            lateral_area_slateral = "Ssight:";
            base_side_a = "Base side a:";
            apothem_l = "Apothem l:";
            slant_l = "Slant height l:";
            base_area_s = "Sbase:";

            enter_values_press_sqr = "Enter values and press Sqr ";
            enter_value_press_sqr = "Enter value and press Sqr ";
            enter_values_press_per = "Enter values and press Per ";
            enter_value_press_per = "Enter value and press Per ";
            enter_values_press_vol = "Enter values and press Vol ";

            choose_formula_s = "Choose a formula";
            choose_formula_p = "Choose a formula";
            choose_formula_p12 = "Choose a formula";
            choose_formula_v = "Choose a formula";
            choose_formula_v12 = "Choose a formula";

            no_s3_for_this_solid = "S3 is not available for this solid ";
            no_s3_for_sphere = "S3 is not available for a sphere ";
            sphere_has_no_base_perimeter = "A sphere has no base and no base perimeter ";
            no_p3_for_cube = "P3 is not available for a cube ";
            only_p1_for_par = "Only P1 is available for a parallelepiped ";
            no_p3_for_pyramid = "P3 is not available for a pyramid ";
            no_v3_for_par = "V3 is not available for a parallelepiped ";
            no_v3_for_sphere = "V3 is not available for a sphere ";
            no_v3_for_pyramid = "V3 is not available for a pyramid ";

            figure_not_implemented = "Figure is not implemented";
            solid_not_implemented = "Solid is not implemented";
            impossible_triangle = "Impossible triangle";

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

            per = "Perimeter\r\n(click to calculate)";
            squ = "Area\r\n(click to calculate)";
            vol = "Volume\r\n(click to calculate)";
            res = "Result: ";

            parallelogram_2d = "Parallelogram";

            s_paral_1 = "S = a·h";
            s_paral_2 = "S = a·b·sin(β)";
            s_paral_3 = "S = d1·d2·sin(φ) / 2";

            p_paral_1 = "P = 2(a+b)";
            p_paral_2 = "P = 2a+2b";
            p_paral_3 = "—";

            sin_beta = "sin(β):";

            if (mode == 1) SP_Click(this, EventArgs.Empty);
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
        }

        public int SettingsOn = 0;
        private void Settings_Click(object sender, EventArgs e)
        {
            if (SettingsOn == 0)
            {
                SettingsOn = 1;
                rusT.Visible = engT.Visible = true;
            }
            else
            {
                SettingsOn = 0;
                rusT.Visible = engT.Visible = false;
            }
        }

        private void Swipe_Click(object sender, EventArgs e)
        {
            if (mode != 1) return;

            ResetUI();
            ShowBaseForFigure();

            if (a == 2)
            {
                a = 7;

                HideInputs();
                ShowResult();
                Text0.Visible = Input0.Visible = true;
                Text1.Visible = Input1.Visible = true;
                Text0.Text = side_a;
                Text1.Text = side_b;
                Swipe.Visible = true;
                Rect.Text = parallelogram_2d;
            }
            else
            {
                a = 2;

                HideInputs();
                ShowResult();
                Text0.Visible = Input0.Visible = true;
                Text1.Visible = Input1.Visible = true;
                Text0.Text = side_a;
                Text1.Text = side_b;
                Swipe.Visible = true;
                Rect.Text = rectangle_2d;
            }

            UpdateFigureImage();
        }
    }
}