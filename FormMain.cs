namespace MathGenerator
{
    public partial class FormMain : Form
    {
        private String answers = "";

        public FormMain()
        {
            InitializeComponent();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {

        }

        private void BtnGenerate_Click(object sender, EventArgs e)
        {
            answers = "";
            LBoxTotal.Items.Clear();
            LBoxTotal.Items.Add("    ÈÕÆÚ£º");
            Generate(90);
        }

        private void Generate(int total)
        {
            Random random = new();
            Equation equation;
            String line = "";
            for (int i = 0; i < total; i++)
            {
                int group = i % 3;
                equation = new Equation(random, CkBMultiply.Checked, CkBDivide.Checked);
                if (group == 0)
                {
                    line += "    " + equation + "    \t";
                }
                else if (group == 1)
                {
                    line += "    " + equation + "    \t";
                }
                else
                {
                    LBoxTotal.Items.Add(line + "    " + equation);
                    line = "";
                }

                answers += equation.answer + (i == total - 1 ? "" : ", ");
            }
        }

        private void BtnCopyAnswer_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(answers);
        }
    }
}