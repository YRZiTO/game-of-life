using System;
using System.IO;
using System.Drawing;
using System.Windows.Forms;

namespace Life
{
    public partial class GameGUI : Form
    {
        private const int GRID_WIDTH = 450;
        private const int BUTTON_WIDTH = 25;
        private const int CELLS = GRID_WIDTH / BUTTON_WIDTH;
        private GameEngine engine = null;
        Color CELL_COLOUR = Color.Blue;

        public GameGUI()
        {
            InitializeComponent();
            engine = new GameEngine(CELLS, CELLS);
            pauseButton.Enabled = false;
        }

        private void GameGUI_Load(object sender, EventArgs e)
        {
            for (var j = 0; j + BUTTON_WIDTH <= GRID_WIDTH; j += BUTTON_WIDTH)
                for (var i = 0; i + BUTTON_WIDTH <= GRID_WIDTH; i += BUTTON_WIDTH)
                {
                    Button newButton = new Button();
                    newButton.Size = new Size(BUTTON_WIDTH, BUTTON_WIDTH);
                    newButton.Location = new Point(i, j);
                    newButton.Click += NewButton_Click;
                    mainGroupBox.Controls.Add(newButton);
                }

            UpdateColours();
        }

        private void UpdateColours()
        {
            for(var i = 0; i < mainGroupBox.Controls.Count; i++)
            {
                var y = i / engine.Height;
                var x = i % engine.Width;

                if (engine[y, x].A == 0)
                    mainGroupBox.Controls[i].BackColor = Color.LightGray;
                else
                    mainGroupBox.Controls[i].BackColor = engine[y, x];
            }
        }

        private void NewButton_Click(object sender, EventArgs e)
        {
            if (timer.Enabled == true)
                return;

            var i = mainGroupBox.Controls.IndexOf(sender as Button);
            var y = i / engine.Height;
            var x = i % engine.Width;

            if (engine[y, x].A == 0)
            {
                engine[y, x] = CELL_COLOUR;
                mainGroupBox.Controls[i].BackColor = CELL_COLOUR;
            }

            else
            {
                engine[y, x] = Color.FromArgb(0, 0, 0, 0);
                mainGroupBox.Controls[i].BackColor = Color.LightGray;
            }

        }

        private void timer_Tick(object sender, EventArgs e)
        {
            engine.Tick();
            genTextBox.Text = engine.Ticks.ToString();
            UpdateColours();
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            timer.Start();
            startButton.Enabled = false;
            saveButton.Enabled = false;
            pauseButton.Enabled = true;
            radioColorRed.Enabled = false;
            radioColorBlue.Enabled = false;
            radioColorGreen.Enabled = false;
        }

        private void pauseButton_Click(object sender, EventArgs e)
        {
            timer.Stop();
            saveButton.Enabled = true;
            startButton.Enabled = true;
            pauseButton.Enabled = false;
            radioColorRed.Enabled = true;
            radioColorBlue.Enabled = true;
            radioColorGreen.Enabled = true;
        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            timer.Stop();
            saveButton.Enabled = true;
            startButton.Enabled = true;
            pauseButton.Enabled = false;
            radioColorRed.Enabled = true;
            radioColorBlue.Enabled = true;
            radioColorGreen.Enabled = true;

            engine = new GameEngine(engine.Height, engine.Width);
            genTextBox.Text = engine.Ticks.ToString();

            UpdateColours();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            const int maxColor = 255;
            const int factor = 10;

            Stream streamFile;
            SaveFileDialog saveDialog = new SaveFileDialog();
            saveDialog.Filter = "PPM Image Format (*.ppm)|*.ppm";
            saveDialog.FilterIndex = 2;
            saveDialog.RestoreDirectory = false;

            if (saveDialog.ShowDialog(this) == DialogResult.OK)
            {
                try
                {
                    if ((streamFile = saveDialog.OpenFile()) != null)
                    {
                        StreamWriter writer = new StreamWriter(streamFile);
                        writer.WriteLine("P3");
                        writer.WriteLine($"# {saveDialog.FileName}");
                        writer.WriteLine($"{engine.Width * factor}  {engine.Height * factor}");
                        writer.WriteLine($"{maxColor}");
                        for (int y = 0; y < engine.Height * factor; y++)
                        {
                            for (int x = 0; x < engine.Width * factor; x++)
                            {
                                var yFactored = y / factor;
                                var xFactored = x / factor;

                                if (engine[yFactored, xFactored].A == 0)
                                    writer.Write($"{maxColor} {maxColor} {maxColor} ");
                                else
                                    writer.Write($"{engine[yFactored, xFactored].R} {engine[yFactored, xFactored].G} {engine[yFactored, xFactored].B} ");
                            }
                        }
                        writer.Close();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(this, ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void radioColorRed_CheckedChanged(object sender, EventArgs e)
        {
            CELL_COLOUR = Color.Red;
        }

        private void radioColorGreen_CheckedChanged(object sender, EventArgs e)
        {
            CELL_COLOUR = Color.Green;
        }

        private void radioColorBlue_CheckedChanged(object sender, EventArgs e)
        {
            CELL_COLOUR = Color.Blue;
        }
    }
}
