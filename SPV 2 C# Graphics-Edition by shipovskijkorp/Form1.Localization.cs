using System;

namespace SPV_2_C__Graphics_Edition_by_shipovskijkorp
{
    public partial class Form1
    {
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

            LangUIRefresh();
            RefreshCurrentLocalizedUI();

            if (a == FigureTriangle && bS == TriangleAreaByHeron && S2F.Visible)
                S2F.Text = heron;
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
            base_length_l = "Lbase:";
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

            LangUIRefresh();
            RefreshCurrentLocalizedUI();

            if (a == FigureTriangle && bS == TriangleAreaByHeron && S2F.Visible)
                S2F.Text = heron;
        }
    }
}