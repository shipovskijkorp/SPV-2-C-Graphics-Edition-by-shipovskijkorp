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
        }

        public int a = 0;         // фигура/тело
        public double output = 0;

        // отдельные формулы (не мешают друг другу)
        public int bS = 0;        // формула площади (2D) / площади поверхности (3D)
        public int bP = 0;        // формула периметра (2D) / периметра основания (3D)
        public int bV = 0;        // формула объёма (3D)

        public int mode = 1;      // 1=SP (2D), 2=SPV (3D)

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
                return;
            }
            else
            {
                /*if (a == 1) FigImage.Image = SP_2_C__Graphics_Edition_by_shipovskijkorp.Properties.Resources.Qub;
                else if (a == 2) FigImage.Image = SP_2_C__Graphics_Edition_by_shipovskijkorp.Properties.Resources.Par;
                else if (a == 3) FigImage.Image = SP_2_C__Graphics_Edition_by_shipovskijkorp.Properties.Resources.Pir;
                else if (a == 4) FigImage.Image = SP_2_C__Graphics_Edition_by_shipovskijkorp.Properties.Resources.Kon;
                else if (a == 5) FigImage.Image = SP_2_C__Graphics_Edition_by_shipovskijkorp.Properties.Resources.Cil;
                else if (a == 6) FigImage.Image = SP_2_C__Graphics_Edition_by_shipovskijkorp.Properties.Resources.Sph;
                return;*/
            }
        }

        // ---------- UI helpers ----------
        private void HideInputs()
        {
            Text0.Visible = Text1.Visible = Text2.Visible = Text3.Visible = false;
            Input0.Visible = Input1.Visible = Input2.Visible = Input3.Visible = false;
            Output.Visible = ResT.Visible = false;
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
        }

        private void ResetUI()
        {
            HideInputs();
            HideFormulaButtons();

            output = 0;
            bS = bP = bV = 0;
            Output.Text = "";

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
                // В режиме SPV показываем всё: поверхность/периметр основания/объём
                Sqr.Visible = true;
                Per.Visible = true;
                Vol.Visible = true;
            }

            UpdateFigureImage();
        }

        // ---------- Dynamic button labels (2D) ----------
        private void ConfigureAreaFormulaButtons()
        {
            S1F.Text = "S1";
            S2F.Text = "S2";
            S3F.Text = "S3";

            if (a == 3) // трапеция
            {
                S1F.Text = "S = (a+b)·h / 2";
                S2F.Text = "S = m·h";
                S3F.Text = "S = d1·d2·sin(φ) / 2";
            }
            else if (a == 4) // треугольник
            {
                S1F.Text = "S = a·h / 2";
                S2F.Text = "Герон";
                S3F.Text = "S = a·b·sin(γ) / 2";
            }
            else if (a == 5) // окружность/круг
            {
                S1F.Text = "S = πr²";
                S2F.Text = "S = πd² / 4";
                S3F.Text = "S = L² / (4π)";
            }
            else if (a == 6) // ромб
            {
                S1F.Text = "S = a·h";
                S2F.Text = "S = d1·d2 / 2";
                S3F.Text = "S = a²·sin(α)";
            }
        }

        private void ConfigurePerimeterFormulaButtons()
        {
            P1F.Text = "P1";
            P2F.Text = "P2";
            P3F.Text = "P3";

            if (a == 3) // трапеция
            {
                P1F.Text = "P = a+b+c+d";
                P2F.Text = "P = a+b+2c";
                P3F.Text = "—";
            }
            else if (a == 4) // треугольник
            {
                P1F.Text = "P = a+b+c";
                P2F.Text = "P = 2S / r";
                P3F.Text = "—";
            }
            else if (a == 5) // окружность
            {
                P1F.Text = "L = 2πr";
                P2F.Text = "L = πd";
                P3F.Text = "L = √(4πS)";
            }
            else if (a == 6) // ромб
            {
                P1F.Text = "P = 4a";
                P2F.Text = "P = 2·√(d1²+d2²)";
                P3F.Text = "P = 4S / h";
            }
        }

        // ---------- Dynamic button labels (3D) ----------
        private void ConfigureSolidSurfaceButtons()
        {
            S1F.Text = "S1";
            S2F.Text = "S2";
            S3F.Text = "S3";

            if (a == 101) // Куб
            {
                S1F.Text = "S = 6a²";
                S2F.Text = "S = 2d²";
                S3F.Text = "S = 6·Sосн";
            }
            else if (a == 102) // Параллелепипед
            {
                S1F.Text = "S = 2(ab+ac+bc)";
                S2F.Text = "S = 2Sосн + Pосн·h";
                S3F.Text = "—";
            }
            else if (a == 103) // Цилиндр
            {
                S1F.Text = "S = 2πr(h+r)";
                S2F.Text = "S = 2πrh + 2πr²";
                S3F.Text = "S = 2Sосн + L·h";
            }
            else if (a == 104) // Сфера
            {
                S1F.Text = "S = 4πr²";
                S2F.Text = "S = πd²";
                S3F.Text = "—";
            }
            else if (a == 105) // Пирамида (квадратная)
            {
                S1F.Text = "S = Sосн + Sбок";
                S2F.Text = "S = a² + 2a·l";
                S3F.Text = "S = a² + (Pосн·l)/2";
            }
            else if (a == 106) // Конус
            {
                S1F.Text = "S = πr(r+l)";
                S2F.Text = "S = πr² + πrl";
                S3F.Text = "S = π(d²/4) + π(d/2)l";
            }
        }

        private void ConfigureSolidBasePerimeterButtons()
        {
            P1F.Text = "P1";
            P2F.Text = "P2";
            P3F.Text = "P3";

            if (a == 101) // Куб
            {
                P1F.Text = "Pосн = 4a";
                P2F.Text = "Pосн = 4·√(Sосн)";
                P3F.Text = "—";
            }
            else if (a == 102) // Параллелепипед
            {
                P1F.Text = "Pосн = 2(a+b)";
                P2F.Text = "—";
                P3F.Text = "—";
            }
            else if (a == 103) // Цилиндр
            {
                P1F.Text = "Lосн = 2πr";
                P2F.Text = "Lосн = πd";
                P3F.Text = "Lосн = √(4πSосн)";
            }
            else if (a == 104) // Сфера
            {
                P1F.Text = "—";
                P2F.Text = "—";
                P3F.Text = "—";
            }
            else if (a == 105) // Пирамида (квадратная)
            {
                P1F.Text = "Pосн = 4a";
                P2F.Text = "Pосн = 4·√(Sосн)";
                P3F.Text = "—";
            }
            else if (a == 106) // Конус
            {
                P1F.Text = "Lосн = 2πr";
                P2F.Text = "Lосн = πd";
                P3F.Text = "Lосн = √(4πSосн)";
            }
        }

        private void ConfigureVolumeFormulaButtons()
        {
            V1F.Text = "V1";
            V2F.Text = "V2";
            V3F.Text = "V3";

            if (a == 101) // Куб
            {
                V1F.Text = "V = a³";
                V2F.Text = "V = S·h";
                V3F.Text = "V = d³/(3√3)";
            }
            else if (a == 102) // Параллелепипед
            {
                V1F.Text = "V = a·b·c";
                V2F.Text = "V = Sосн·h";
                V3F.Text = "—";
            }
            else if (a == 103) // Цилиндр
            {
                V1F.Text = "V = πr²h";
                V2F.Text = "V = (πd²/4)·h";
                V3F.Text = "V = Sосн·h";
            }
            else if (a == 104) // Сфера
            {
                V1F.Text = "V = 4/3·πr³";
                V2F.Text = "V = πd³/6";
                V3F.Text = "—";
            }
            else if (a == 105) // Пирамида
            {
                V1F.Text = "V = Sосн·h/3";
                V2F.Text = "V = a²·h/3";
                V3F.Text = "—";
            }
            else if (a == 106) // Конус
            {
                V1F.Text = "V = 1/3·πr²h";
                V2F.Text = "V = 1/3·Sосн·h";
                V3F.Text = "V = πd²h/12";
            }
        }

        // ==========================================================
        // SELECTORS (ВАЖНО: НЕ ПРЯЧЕМ КНОПКИ ФОРМУЛ!)
        // ==========================================================

        // ---------- 2D selectors (S) ----------
        private void SelectTrapezoidAreaFormula(int formula) // bS = 1..3
        {
            a = 3; bS = formula;
            HideInputs();
            ShowResult();

            Text0.Visible = Input0.Visible = true;
            Text1.Visible = Input1.Visible = true;

            if (formula == 1)
            {
                Text0.Text = "Основание a:";
                Text1.Text = "Основание b:";
                Text2.Text = "Высота h:";
                Text2.Visible = Input2.Visible = true;
            }
            else if (formula == 2)
            {
                Text0.Text = "Средняя линия m:";
                Text1.Text = "Высота h:";
            }
            else if (formula == 3)
            {
                Text0.Text = "Диагональ d1:";
                Text1.Text = "Диагональ d2:";
                Text2.Text = "sin(φ):";
                Text2.Visible = Input2.Visible = true;
            }

            Output.Text = "Введи значения и нажми Sqr ";
        }

        private void SelectTriangleAreaFormula(int formula) // bS = 8..10
        {
            a = 4; bS = formula;
            HideInputs();
            ShowResult();

            if (formula == 8)
            {
                Text0.Visible = Input0.Visible = true;
                Text1.Visible = Input1.Visible = true;
                Text0.Text = "Основание a:";
                Text1.Text = "Высота h:";
            }
            else if (formula == 9)
            {
                Text0.Visible = Input0.Visible = true;
                Text1.Visible = Input1.Visible = true;
                Text2.Visible = Input2.Visible = true;
                Text0.Text = "Сторона a:";
                Text1.Text = "Сторона b:";
                Text2.Text = "Сторона c:";
            }
            else if (formula == 10)
            {
                Text0.Visible = Input0.Visible = true;
                Text1.Visible = Input1.Visible = true;
                Text2.Visible = Input2.Visible = true;
                Text0.Text = "Сторона a:";
                Text1.Text = "Сторона b:";
                Text2.Text = "sin(γ):";
            }

            Output.Text = "Введи значения и нажми Sqr ";
        }

        private void SelectCircleAreaFormula(int formula) // bS = 11..13
        {
            a = 5; bS = formula;
            HideInputs();
            ShowResult();

            Text0.Visible = Input0.Visible = true;
            if (formula == 11) Text0.Text = "Радиус r:";
            else if (formula == 12) Text0.Text = "Диаметр d:";
            else if (formula == 13) Text0.Text = "Длина L:";

            Output.Text = "Введи значение и нажми Sqr ";
        }

        private void SelectRhombusAreaFormula(int formula) // bS = 17..19
        {
            a = 6; bS = formula;
            HideInputs();
            ShowResult();

            if (formula == 17)
            {
                Text0.Visible = Input0.Visible = true;
                Text1.Visible = Input1.Visible = true;
                Text0.Text = "Сторона a:";
                Text1.Text = "Высота h:";
            }
            else if (formula == 18)
            {
                Text0.Visible = Input0.Visible = true;
                Text1.Visible = Input1.Visible = true;
                Text0.Text = "Диагональ d1:";
                Text1.Text = "Диагональ d2:";
            }
            else if (formula == 19)
            {
                Text0.Visible = Input0.Visible = true;
                Text1.Visible = Input1.Visible = true;
                Text0.Text = "Сторона a:";
                Text1.Text = "sin(α):";
            }

            Output.Text = "Введи значения и нажми Sqr ";
        }

        // ---------- 2D selectors (P) ----------
        private void SelectTrapezoidPerimeterFormula(int formula) // bP = 4..5
        {
            a = 3; bP = formula;
            HideInputs();
            ShowResult();

            Text0.Visible = Input0.Visible = true;
            Text1.Visible = Input1.Visible = true;

            if (formula == 4)
            {
                Text0.Text = "Основание a:";
                Text1.Text = "Основание b:";
                Text2.Text = "Боковая c:";
                Text3.Text = "Боковая d:";
                Text2.Visible = Input2.Visible = true;
                Text3.Visible = Input3.Visible = true;
            }
            else if (formula == 5)
            {
                Text0.Text = "Основание a:";
                Text1.Text = "Основание b:";
                Text2.Text = "Боковая c:";
                Text2.Visible = Input2.Visible = true;
            }

            Output.Text = "Введи значения и нажми Per ";
        }

        private void SelectTrianglePerimeterFormula(int formula) // bP = 6..7
        {
            a = 4; bP = formula;
            HideInputs();
            ShowResult();

            if (formula == 6)
            {
                Text0.Visible = Input0.Visible = true;
                Text1.Visible = Input1.Visible = true;
                Text2.Visible = Input2.Visible = true;
                Text0.Text = "Сторона a:";
                Text1.Text = "Сторона b:";
                Text2.Text = "Сторона c:";
            }
            else if (formula == 7)
            {
                Text0.Visible = Input0.Visible = true;
                Text1.Visible = Input1.Visible = true;
                Text0.Text = "Площадь S:";
                Text1.Text = "Радиус r:";
            }

            Output.Text = "Введи значения и нажми Per ";
        }

        private void SelectCirclePerimeterFormula(int formula) // bP = 14..16
        {
            a = 5; bP = formula;
            HideInputs();
            ShowResult();

            Text0.Visible = Input0.Visible = true;
            if (formula == 14) Text0.Text = "Радиус r:";
            else if (formula == 15) Text0.Text = "Диаметр d:";
            else if (formula == 16) Text0.Text = "Площадь S:";

            Output.Text = "Введи значение и нажми Per ";
        }

        private void SelectRhombusPerimeterFormula(int formula) // bP = 20..22
        {
            a = 6; bP = formula;
            HideInputs();
            ShowResult();

            if (formula == 20)
            {
                Text0.Visible = Input0.Visible = true;
                Text0.Text = "Сторона a:";
            }
            else if (formula == 21)
            {
                Text0.Visible = Input0.Visible = true;
                Text1.Visible = Input1.Visible = true;
                Text0.Text = "Диагональ d1:";
                Text1.Text = "Диагональ d2:";
            }
            else if (formula == 22)
            {
                Text0.Visible = Input0.Visible = true;
                Text1.Visible = Input1.Visible = true;
                Text0.Text = "Площадь S:";
                Text1.Text = "Высота h:";
            }

            Output.Text = "Введи значения и нажми Per ";
        }

        // ---------- 3D selectors ----------
        private void SelectSolidSurfaceFormula(int formula) // bS = 1..3 (3D)
        {
            bS = formula;
            HideInputs();
            ShowResult();

            if (a == 101)
            {
                if (formula == 1) { Text0.Visible = Input0.Visible = true; Text0.Text = "Ребро a:"; }
                else if (formula == 2) { Text0.Visible = Input0.Visible = true; Text0.Text = "Диагональ куба d:"; }
                else if (formula == 3) { Text0.Visible = Input0.Visible = true; Text0.Text = "Площадь основания Sосн:"; }
            }
            else if (a == 102)
            {
                if (formula == 1)
                {
                    Text0.Visible = Input0.Visible = true;
                    Text1.Visible = Input1.Visible = true;
                    Text2.Visible = Input2.Visible = true;
                    Text0.Text = "Сторона a:";
                    Text1.Text = "Сторона b:";
                    Text2.Text = "Высота c:";
                }
                else if (formula == 2)
                {
                    Text0.Visible = Input0.Visible = true;
                    Text1.Visible = Input1.Visible = true;
                    Text2.Visible = Input2.Visible = true;
                    Text0.Text = "Площадь основания Sосн:";
                    Text1.Text = "Периметр основания Pосн:";
                    Text2.Text = "Высота h:";
                }
                else
                {
                    Output.Text = "Для этого тела S3 нет ";
                    return;
                }
            }
            else if (a == 103)
            {
                if (formula == 1 || formula == 2)
                {
                    Text0.Visible = Input0.Visible = true;
                    Text1.Visible = Input1.Visible = true;
                    Text0.Text = "Радиус r:";
                    Text1.Text = "Высота h:";
                }
                else if (formula == 3)
                {
                    Text0.Visible = Input0.Visible = true;
                    Text1.Visible = Input1.Visible = true;
                    Text2.Visible = Input2.Visible = true;
                    Text0.Text = "Площадь основания Sосн:";
                    Text1.Text = "Длина основания L:";
                    Text2.Text = "Высота h:";
                }
            }
            else if (a == 104)
            {
                Text0.Visible = Input0.Visible = true;
                Text0.Text = (formula == 2) ? "Диаметр d:" : "Радиус r:";
                if (formula == 3) { Output.Text = "Для сферы S3 нет "; return; }
            }
            else if (a == 105)
            {
                if (formula == 1)
                {
                    Text0.Visible = Input0.Visible = true;
                    Text1.Visible = Input1.Visible = true;
                    Text0.Text = "Площадь основания Sосн:";
                    Text1.Text = "Площадь боковая Sбок:";
                }
                else
                {
                    Text0.Visible = Input0.Visible = true;
                    Text1.Visible = Input1.Visible = true;
                    Text0.Text = "Сторона основания a:";
                    Text1.Text = "Апофема l:";
                }
            }
            else if (a == 106)
            {
                if (formula == 3)
                {
                    Text0.Visible = Input0.Visible = true;
                    Text1.Visible = Input1.Visible = true;
                    Text0.Text = "Диаметр d:";
                    Text1.Text = "Образующая l:";
                }
                else
                {
                    Text0.Visible = Input0.Visible = true;
                    Text1.Visible = Input1.Visible = true;
                    Text0.Text = "Радиус r:";
                    Text1.Text = "Образующая l:";
                }
            }

            Output.Text = "Введи значения и нажми Sqr ";
        }

        private void SelectSolidBasePerimeterFormula(int formula) // bP = 1..3 (3D)
        {
            bP = formula;
            HideInputs();
            ShowResult();

            if (a == 104)
            {
                Output.Text = "У сферы нет основания и периметра ";
                return;
            }

            if (a == 101)
            {
                if (formula == 1) { Text0.Visible = Input0.Visible = true; Text0.Text = "Ребро a:"; }
                else if (formula == 2) { Text0.Visible = Input0.Visible = true; Text0.Text = "Площадь основания Sосн:"; }
                else { Output.Text = "Для куба P3 нет "; return; }
            }
            else if (a == 102)
            {
                if (formula != 1) { Output.Text = "Для параллелепипеда только P1 "; return; }

                Text0.Visible = Input0.Visible = true;
                Text1.Visible = Input1.Visible = true;
                Text0.Text = "Сторона a:";
                Text1.Text = "Сторона b:";
            }
            else if (a == 103 || a == 106)
            {
                Text0.Visible = Input0.Visible = true;
                if (formula == 1) Text0.Text = "Радиус r:";
                else if (formula == 2) Text0.Text = "Диаметр d:";
                else if (formula == 3) Text0.Text = "Площадь основания Sосн:";
            }
            else if (a == 105)
            {
                if (formula == 1) { Text0.Visible = Input0.Visible = true; Text0.Text = "Сторона основания a:"; }
                else if (formula == 2) { Text0.Visible = Input0.Visible = true; Text0.Text = "Площадь основания Sосн:"; }
                else { Output.Text = "Для пирамиды P3 нет "; return; }
            }

            Output.Text = "Введи значения и нажми Per ";
        }

        private void SelectVolumeFormula(int formula) // bV = 1..3
        {
            bV = formula;
            HideInputs();
            ShowResult();

            if (a == 101)
            {
                if (formula == 1) { Text0.Visible = Input0.Visible = true; Text0.Text = "Ребро a:"; }
                else if (formula == 2) { Text0.Visible = Input0.Visible = true; Text1.Visible = Input1.Visible = true; Text0.Text = "Площадь основания S:"; Text1.Text = "Высота h:"; }
                else if (formula == 3) { Text0.Visible = Input0.Visible = true; Text0.Text = "Диагональ куба d:"; }
            }
            else if (a == 102)
            {
                if (formula == 1)
                {
                    Text0.Visible = Input0.Visible = true;
                    Text1.Visible = Input1.Visible = true;
                    Text2.Visible = Input2.Visible = true;
                    Text0.Text = "Сторона a:";
                    Text1.Text = "Сторона b:";
                    Text2.Text = "Высота c:";
                }
                else if (formula == 2)
                {
                    Text0.Visible = Input0.Visible = true;
                    Text1.Visible = Input1.Visible = true;
                    Text0.Text = "Площадь основания S:";
                    Text1.Text = "Высота h:";
                }
                else { Output.Text = "Для параллелепипеда V3 нет "; return; }
            }
            else if (a == 103)
            {
                if (formula == 1 || formula == 2)
                {
                    Text0.Visible = Input0.Visible = true;
                    Text1.Visible = Input1.Visible = true;
                    Text0.Text = (formula == 2) ? "Диаметр d:" : "Радиус r:";
                    Text1.Text = "Высота h:";
                }
                else if (formula == 3)
                {
                    Text0.Visible = Input0.Visible = true;
                    Text1.Visible = Input1.Visible = true;
                    Text0.Text = "Площадь основания S:";
                    Text1.Text = "Высота h:";
                }
            }
            else if (a == 104)
            {
                if (formula == 3) { Output.Text = "Для сферы V3 нет "; return; }
                Text0.Visible = Input0.Visible = true;
                Text0.Text = (formula == 2) ? "Диаметр d:" : "Радиус r:";
            }
            else if (a == 105)
            {
                if (formula == 3) { Output.Text = "Для пирамиды V3 нет "; return; }
                Text0.Visible = Input0.Visible = true;
                Text1.Visible = Input1.Visible = true;
                Text0.Text = (formula == 2) ? "Сторона основания a:" : "Площадь основания S:";
                Text1.Text = "Высота h:";
            }
            else if (a == 106)
            {
                Text0.Visible = Input0.Visible = true;
                Text1.Visible = Input1.Visible = true;
                if (formula == 1) Text0.Text = "Радиус r:";
                else if (formula == 2) Text0.Text = "Площадь основания S:";
                else if (formula == 3) Text0.Text = "Диаметр d:";
                Text1.Text = "Высота h:";
            }

            Output.Text = "Введи значения и нажми Vol ";
        }

        // ---------- lifecycle ----------
        private void Form1_Load(object sender, EventArgs e)
        {
            ResetUI();
            SP_Click(sender, e);
        }

        // ---------- figure selection ----------
        private void Quad_Click(object sender, EventArgs e)
        {
            ResetUI();
            ShowBaseForFigure();

            if (mode == 1)
            {
                a = 1;

                HideInputs(); ShowResult();
                Text0.Visible = Input0.Visible = true;
                Text0.Text = "Сторона a:";
            }
            else
            {
                a = 101; // Куб
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

                HideInputs(); ShowResult();
                Text0.Visible = Input0.Visible = true;
                Text1.Visible = Input1.Visible = true;
                Text0.Text = "Сторона a:";
                Text1.Text = "Сторона b:";
            }
            else
            {
                a = 102; // Параллелепипед
            }

            UpdateFigureImage();
        }

        private void Okr_Click(object sender, EventArgs e)
        {
            ResetUI();
            ShowBaseForFigure();

            if (mode == 1) a = 5;
            else a = 103; // Цилиндр

            UpdateFigureImage();
        }

        private void Romb_Click(object sender, EventArgs e)
        {
            ResetUI();
            ShowBaseForFigure();

            if (mode == 1) a = 6;
            else a = 104; // Сфера

            UpdateFigureImage();
        }

        private void Trap_Click(object sender, EventArgs e)
        {
            ResetUI();
            ShowBaseForFigure();

            if (mode == 1) a = 3;
            else a = 105; // Пирамида

            UpdateFigureImage();
        }

        private void Trian_Click(object sender, EventArgs e)
        {
            ResetUI();
            ShowBaseForFigure();

            if (mode == 1) a = 4;
            else a = 106; // Конус

            UpdateFigureImage();
        }

        // ==========================================================
        // COMPUTE
        // ==========================================================

        private void Sqr_Click(object sender, EventArgs e)
        {
            HideFormulaButtons();

            if (mode == 2 && a >= 101 && a <= 106)
            {
                ConfigureSolidSurfaceButtons();
                S1F.Visible = S2F.Visible = S3F.Visible = true;

                if (bS == 0) { ShowResult(); Output.Text = "Выбери формулу (S1–S3)"; return; }

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
                    else { ShowResult(); Output.Text = "Для этого тела S3 нет "; return; }
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
                    else { ShowResult(); Output.Text = "Для сферы S3 нет "; return; }
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

            // 2D
            if (a == 3 || a == 4 || a == 5 || a == 6)
            {
                ConfigureAreaFormulaButtons();
                S1F.Visible = S2F.Visible = S3F.Visible = true;

                if (bS == 0) { ShowResult(); Output.Text = "Выбери формулу (S1–S3)"; return; }
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
                else { ShowResult(); Output.Text = "Выбери формулу (S1–S3)"; return; }
            }
            else if (a == 4)
            {
                if (bS == 8) output = 0.5 * x0_2 * x1_2;
                else if (bS == 9)
                {
                    double s = (x0_2 + x1_2 + x2_2) / 2.0;
                    double under = s * (s - x0_2) * (s - x1_2) * (s - x2_2);
                    if (under < 0) { ShowResult(); Output.Text = "Невозможный треугольник"; return; }
                    output = Math.Sqrt(under);
                }
                else if (bS == 10) output = 0.5 * x0_2 * x1_2 * x2_2;
                else { ShowResult(); Output.Text = "Выбери формулу (S1–S3)"; return; }
            }
            else if (a == 5)
            {
                if (bS == 11) output = Math.PI * x0_2 * x0_2;
                else if (bS == 12) output = Math.PI * x0_2 * x0_2 / 4.0;
                else if (bS == 13) output = (x0_2 * x0_2) / (4.0 * Math.PI);
                else { ShowResult(); Output.Text = "Выбери формулу (S1–S3)"; return; }
            }
            else if (a == 6)
            {
                if (bS == 17) output = x0_2 * x1_2;
                else if (bS == 18) output = 0.5 * x0_2 * x1_2;
                else if (bS == 19) output = x0_2 * x0_2 * x1_2;
                else { ShowResult(); Output.Text = "Выбери формулу (S1–S3)"; return; }
            }
            else { ShowResult(); Output.Text = "Фигура не реализована"; return; }

            ShowResult();
            Output.Text = output.ToString();
        }

        private void Per_Click(object sender, EventArgs e)
        {
            HideFormulaButtons();

            if (mode == 2 && a >= 101 && a <= 106)
            {
                if (a == 104) { ShowResult(); Output.Text = "У сферы нет основания и периметра "; return; }

                ConfigureSolidBasePerimeterButtons();

                if (a == 102) { P1F.Visible = true; }
                else if (a == 101 || a == 105) { P1F.Visible = P2F.Visible = true; }
                else { P1F.Visible = P2F.Visible = P3F.Visible = true; }

                if (bP == 0) { ShowResult(); Output.Text = "Выбери формулу (P1–P3)"; return; }

                double x0 = (double)Input0.Value;
                double x1 = (double)Input1.Value;

                if (a == 101)
                {
                    if (bP == 1) output = 4.0 * x0;
                    else if (bP == 2) output = 4.0 * Math.Sqrt(x0);
                    else { ShowResult(); Output.Text = "Выбери формулу (P1–P2)"; return; }
                }
                else if (a == 102)
                {
                    if (bP != 1) { ShowResult(); Output.Text = "Для параллелепипеда только P1 "; return; }
                    output = 2.0 * (x0 + x1);
                }
                else if (a == 103 || a == 106)
                {
                    if (bP == 1) output = 2.0 * Math.PI * x0;
                    else if (bP == 2) output = Math.PI * x0;
                    else if (bP == 3) output = Math.Sqrt(4.0 * Math.PI * x0);
                    else { ShowResult(); Output.Text = "Выбери формулу (P1–P3)"; return; }
                }
                else if (a == 105)
                {
                    if (bP == 1) output = 4.0 * x0;
                    else if (bP == 2) output = 4.0 * Math.Sqrt(x0);
                    else { ShowResult(); Output.Text = "Выбери формулу (P1–P2)"; return; }
                }

                ShowResult();
                Output.Text = output.ToString();
                return;
            }

            // 2D
            if (a == 3 || a == 4 || a == 5 || a == 6)
            {
                ConfigurePerimeterFormulaButtons();
                if (a == 5 || a == 6) P1F.Visible = P2F.Visible = P3F.Visible = true;
                else P1F.Visible = P2F.Visible = true;

                if (bP == 0) { ShowResult(); Output.Text = "Выбери формулу (P1–P3)"; return; }
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
                else { ShowResult(); Output.Text = "Выбери формулу (P1–P2)"; return; }
            }
            else if (a == 4)
            {
                if (bP == 6) output = x0_2 + x1_2 + x2_2;
                else if (bP == 7)
                {
                    if (x1_2 == 0) { ShowResult(); Output.Text = "r не может быть 0"; return; }
                    output = 2.0 * x0_2 / x1_2;
                }
                else { ShowResult(); Output.Text = "Выбери формулу (P1–P2)"; return; }
            }
            else if (a == 5)
            {
                if (bP == 14) output = 2.0 * Math.PI * x0_2;
                else if (bP == 15) output = Math.PI * x0_2;
                else if (bP == 16)
                {
                    if (x0_2 < 0) { ShowResult(); Output.Text = "S не может быть < 0"; return; }
                    output = Math.Sqrt(4.0 * Math.PI * x0_2);
                }
                else { ShowResult(); Output.Text = "Выбери формулу (P1–P3)"; return; }
            }
            else if (a == 6)
            {
                if (bP == 20) output = 4.0 * x0_2;
                else if (bP == 21) output = 2.0 * Math.Sqrt(x0_2 * x0_2 + x1_2 * x1_2);
                else if (bP == 22)
                {
                    if (x1_2 == 0) { ShowResult(); Output.Text = "h не может быть 0"; return; }
                    output = 4.0 * x0_2 / x1_2;
                }
                else { ShowResult(); Output.Text = "Выбери формулу (P1–P3)"; return; }
            }
            else { ShowResult(); Output.Text = "Фигура не реализована"; return; }

            ShowResult();
            Output.Text = output.ToString();
        }

        private void Vol_Click(object sender, EventArgs e)
        {
            if (mode != 2)
            {
                ShowResult();
                Output.Text = "Переключись в режим SPV";
                return;
            }

            HideFormulaButtons();

            ConfigureVolumeFormulaButtons();
            V1F.Visible = V2F.Visible = true;
            V3F.Visible = (a == 101 || a == 103 || a == 106);

            if (bV == 0)
            {
                ShowResult();
                Output.Text = "Выбери формулу (V1–V3)";
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
                else { Output.Text = "Выбери формулу (V1–V3)"; return; }
            }
            else if (a == 102)
            {
                if (bV == 1) output = x0 * x1 * x2;
                else if (bV == 2) output = x0 * x1;
                else { Output.Text = "Выбери формулу (V1–V2)"; return; }
            }
            else if (a == 103)
            {
                if (bV == 1) output = Math.PI * x0 * x0 * x1;
                else if (bV == 2) output = (Math.PI * x0 * x0 / 4.0) * x1;
                else if (bV == 3) output = x0 * x1;
                else { Output.Text = "Выбери формулу (V1–V3)"; return; }
            }
            else if (a == 104)
            {
                if (bV == 1) output = (4.0 / 3.0) * Math.PI * x0 * x0 * x0;
                else if (bV == 2) output = Math.PI * x0 * x0 * x0 / 6.0;
                else { Output.Text = "Выбери формулу (V1–V2)"; return; }
            }
            else if (a == 105)
            {
                if (bV == 1) output = x0 * x1 / 3.0;
                else if (bV == 2) output = (x0 * x0) * x1 / 3.0;
                else { Output.Text = "Выбери формулу (V1–V2)"; return; }
            }
            else if (a == 106)
            {
                if (bV == 1) output = (1.0 / 3.0) * Math.PI * x0 * x0 * x1;
                else if (bV == 2) output = (1.0 / 3.0) * x0 * x1;
                else if (bV == 3) output = (Math.PI * x0 * x0 * x1) / 12.0;
                else { Output.Text = "Выбери формулу (V1–V3)"; return; }
            }
            else { Output.Text = "Тело не реализовано"; return; }

            ShowResult();
            Output.Text = output.ToString();
        }

        // ---------- universal formula buttons ----------
        private void S1F_Click(object sender, EventArgs e)
        {
            if (mode == 2 && a >= 101 && a <= 106) SelectSolidSurfaceFormula(1);
            else if (a == 3) SelectTrapezoidAreaFormula(1);
            else if (a == 4) SelectTriangleAreaFormula(8);
            else if (a == 5) SelectCircleAreaFormula(11);
            else if (a == 6) SelectRhombusAreaFormula(17);
        }

        private void S2F_Click(object sender, EventArgs e)
        {
            if (mode == 2 && a >= 101 && a <= 106) SelectSolidSurfaceFormula(2);
            else if (a == 3) SelectTrapezoidAreaFormula(2);
            else if (a == 4) SelectTriangleAreaFormula(9);
            else if (a == 5) SelectCircleAreaFormula(12);
            else if (a == 6) SelectRhombusAreaFormula(18);
        }

        private void S3F_Click(object sender, EventArgs e)
        {
            if (mode == 2 && a >= 101 && a <= 106) SelectSolidSurfaceFormula(3);
            else if (a == 3) SelectTrapezoidAreaFormula(3);
            else if (a == 4) SelectTriangleAreaFormula(10);
            else if (a == 5) SelectCircleAreaFormula(13);
            else if (a == 6) SelectRhombusAreaFormula(19);
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

        // ---------- mode buttons ----------
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

            Quad.Text = "Квадрат";
            Rect.Text = "Прямоугольник";
            Trap.Text = "Трапеция";
            Trian.Text = "Треугольник";
            Okr.Text = "Окружность";
            Romb.Text = "Ромб";

            UpdateFigureImage();
        }

        private void SPV_Click(object sender, EventArgs e)
        {
            mode = 2;
            ResetUI();

            Quad.Visible = true;   // Куб
            Rect.Visible = true;   // Параллелепипед
            Okr.Visible = true;    // Цилиндр
            Romb.Visible = true;   // Сфера
            Trap.Visible = true;   // Пирамида
            Trian.Visible = true;  // Конус

            Quad.Text = "Куб";
            Rect.Text = "Параллелепипед";
            Okr.Text = "Цилиндр";
            Romb.Text = "Сфера";
            Trap.Text = "Пирамида";
            Trian.Text = "Конус";

            UpdateFigureImage();
        }
    }
}