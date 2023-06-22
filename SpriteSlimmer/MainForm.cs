using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace SpriteSlimmer
{
    public enum ColorOptions
    {
        [Description("透明")]
        Transparent,

        [Description("黒")]
        Black,

        [Description("白")]
        White,

        [Description("左上のピクセル")]
        TopLeftPixel
    }

    public partial class MainForm : Form
    {
        const int MAX_DIVISOR = 100;

        private int cellsMax = 0;

        // ファイル名を保持するリスト
        string selectedFilePath;

        public MainForm()
        {
            InitializeComponent();
        }

        private void buttonAddItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Filter = "Image Files(*.PNG;*.JPEG;*.JPG)|*.PNG;*.JPEG;*.JPG)"
            };

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                selectedFilePath = openFileDialog.FileName;
                UpdateTextboxFilePath();
            }
        }

        private void UpdateTextboxFilePath()
        {
            if(File.Exists(selectedFilePath) == true)
            {
                textBoxTargetPath.Text = selectedFilePath;

                comboBoxColumn.Enabled = true;
                comboBoxRow.Enabled = true;

                comboBoxColumn.Items.Clear();
                comboBoxRow.Items.Clear();
                // 最初の画像を読み込む
                try
                {
                    using (Bitmap firstImage = new Bitmap(selectedFilePath))
                    {
                        // 画像の幅と高さの約数を求める
                        List<int> widthDivisors = GetDivisors(firstImage.Width);
                        List<int> heightDivisors = GetDivisors(firstImage.Height);

                        // MAX_DIVISORより大きい約数を除く
                        widthDivisors = widthDivisors.Where(x => x <= MAX_DIVISOR).ToList();
                        heightDivisors = heightDivisors.Where(x => x <= MAX_DIVISOR).ToList();

                        // 約数をそれぞれのコンボボックスに追加する
                        foreach (int divisor in widthDivisors)
                        {
                            comboBoxColumn.Items.Add(divisor);
                        }

                        foreach (int divisor in heightDivisors)
                        {
                            comboBoxRow.Items.Add(divisor);
                        }

                        comboBoxColumn.SelectedIndex = 0;
                        comboBoxRow.SelectedIndex = 0;
                    }
                }
                catch (ArgumentException)
                {
                    // 無効なファイルの場合にメッセージボックスを表示
                    MessageBox.Show("無効なファイルです。", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
            else
            {
                comboBoxColumn.Enabled = false;
                comboBoxRow.Enabled = false;
            }

            // プレビューを更新
            listBoxImages_SelectedIndexChanged(selectedFilePath, EventArgs.Empty);
        }

        // 約数を求める関数
        private List<int> GetDivisors(int number)
        {
            var divisors = new List<int>();

            for (int i = 1; i <= number; i++)
            {
                if (number % i == 0)
                {
                    divisors.Add(i);
                }
            }

            return divisors;
        }


        private void listBoxImages_DragEnter(object sender, DragEventArgs e)
        {
            // ドラッグされたデータがファイルであれば、ドロップを許可
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
                e.Effect = DragDropEffects.Copy;
        }

        private void listBoxImages_DragDrop(object sender, DragEventArgs e)
        {
            // ドロップされたファイルのパスを取得
            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);


            // ファイルがPNGならば追加
            if (Path.GetExtension(files.First()).ToLower() == ".png" || Path.GetExtension(files.First()).ToLower() == ".jpeg" || Path.GetExtension(files.First()).ToLower() == ".jpg")
            {
                selectedFilePath = files[0];
            }

            // ListBoxの内容を更新
            UpdateTextboxFilePath();
        }
        private void listBoxImages_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (File.Exists(selectedFilePath) == true)
            {
                updatePictureBoxView();
            }
            else
            {
                pictureBoxPreview.Image = null;
            }

        }

        private void buttonOutput_Click(object sender, EventArgs e)
        {
            ThinOutAndSaveImages();
        }

        private void ThinOutAndSaveImages()
        {
            if(!File.Exists(selectedFilePath))
            {
                MessageBox.Show("ファイルを指定してください。", "エラー",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return;
            }
            // オリジナルの画像を取得
            Bitmap originalImage = new Bitmap(selectedFilePath);

            // 分割数、間引き数、出力する行・列の数を取得
            int rowDivisions = int.Parse(comboBoxRow.SelectedItem.ToString());
            int columnDivisions = int.Parse(comboBoxColumn.SelectedItem.ToString());
            int thinning = comboBoxThinning.SelectedIndex;
            int outputRows = Convert.ToInt32(numericUpDownOutputRow.Value);
            int outputColumns = Convert.ToInt32(numericUpDownOutputColumn.Value);

            if(thinning != 0)
            {
                thinning++;
            }
            // 画像を連結
            Bitmap result = ThinAndReorderAnimation(originalImage, rowDivisions, columnDivisions, thinning, outputRows, outputColumns);

            // ファイル保存ダイアログを表示し、ユーザーに保存場所とファイル名を指定させる
            SaveFileDialog saveFileDialog = new SaveFileDialog
            {
                Filter = "PNG files (*.png)|*.png", // PNGファイルのみ保存できるようにフィルタを設定
                DefaultExt = "png", // デフォルトの拡張子を指定
                AddExtension = true // 拡張子がない場合に自動的に追加
            };

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                // 結果を保存する
                result.Save(saveFileDialog.FileName, ImageFormat.Png);
            }
            // 使用したBitmapをDisposeする
            result.Dispose();
        }

        private Color GetTopLeftPixelColor(Bitmap image)
        {
            // 左上のピクセルの色を取得する
            Color topLeftPixelColor = image.GetPixel(0, 0);

            return topLeftPixelColor;
        }

        private Bitmap ThinAndReorderAnimation(Bitmap originalImage, int rowDivisions, int columnDivisions, int thinning, int outputRows, int outputColumns)
        {
            // 新しいBitmapを作成する（outputColumns × originalImage.Width / columnDivisions, outputRows × originalImage.Height / rowDivisions）
            Bitmap newImage = new Bitmap(outputColumns * originalImage.Width / columnDivisions, outputRows * originalImage.Height / rowDivisions, PixelFormat.Format32bppArgb);

            ColorOptions selectedColor = (ColorOptions)comboBoxBackground.SelectedIndex;

            switch (selectedColor)
            {
                default:
                case ColorOptions.Transparent:
                    // 透明色で塗りつぶす
                    using (Graphics g = Graphics.FromImage(newImage))
                    {
                        g.Clear(Color.Transparent);
                    }
                    break;

                case ColorOptions.Black:
                    // 黒色で塗りつぶす
                    using (Graphics g = Graphics.FromImage(newImage))
                    {
                        g.Clear(Color.Black);
                    }
                    break;

                case ColorOptions.White:
                    // 白色で塗りつぶす
                    using (Graphics g = Graphics.FromImage(newImage))
                    {
                        g.Clear(Color.White);
                    }
                    break;

                case ColorOptions.TopLeftPixel:
                    // 左上のピクセルの色で塗りつぶす
                    Color topLeftPixelColor = GetTopLeftPixelColor(newImage);
                    using (Graphics g = Graphics.FromImage(newImage))
                    {
                        g.Clear(topLeftPixelColor);
                    }
                    break;

            }

            int newRowIndex = 0;
            int newColumnIndex = 0;

            // オリジナルの画像をnewImageにコピー（間引き処理を含む）
            for (int rowIndex = 0; rowIndex < rowDivisions; rowIndex++)
            {
                for (int columnIndex = 0; columnIndex < columnDivisions; columnIndex++)
                {
                    // thinningが0でないときのみスキップ処理を行う
                    if (thinning != 0 && (rowIndex * columnDivisions + columnIndex) % thinning != 0)
                    {
                        continue;
                    }

                    // ピースの大きさ
                    int pieceWidth = originalImage.Width / columnDivisions;
                    int pieceHeight = originalImage.Height / rowDivisions;

                    // 描画先の位置を計算
                    int destX = newColumnIndex * pieceWidth;
                    int destY = newRowIndex * pieceHeight;

                    // 描画先がnewImageの範囲外になったら処理を終了
                    if (destX >= newImage.Width || destY >= newImage.Height)
                    {
                        return newImage;
                    }

                    // コピーするピースを取得
                    for (int y = 0; y < pieceHeight; y++)
                    {
                        for (int x = 0; x < pieceWidth; x++)
                        {
                            if (columnIndex * pieceWidth + x < originalImage.Width && rowIndex * pieceHeight + y < originalImage.Height)
                            {
                                // コピーするピースの色を取得
                                Color color = originalImage.GetPixel(columnIndex * pieceWidth + x, rowIndex * pieceHeight + y);

                                // 描画先の色を設定
                                newImage.SetPixel(destX + x, destY + y, color);
                            }
                        }
                    }

                    // 描画先の列を更新
                    newColumnIndex++;
                    if (newColumnIndex >= outputColumns)
                    {
                        // 描画先の列が範囲外になったら行を進める
                        newColumnIndex = 0;
                        newRowIndex++;
                    }
                }
            }

            return newImage;
        }


        private void radioButtonPrevColor1_CheckedChanged(object sender, EventArgs e)
        {
            ChangePreviewBackgroundColor();
        }

        private void radioButtonPrevColor2_CheckedChanged(object sender, EventArgs e)
        {
            ChangePreviewBackgroundColor();
        }

        private void ChangePreviewBackgroundColor()
        {
            if (radioButtonPrevColor1.Checked)
            {
                panelImagePreview.BackColor = Color.Black;
            }
            else
            {
                panelImagePreview.BackColor = SystemColors.Control;
            }
        }

        private void buttonPreviewOutput_Click(object sender, EventArgs e)
        {
            // Check if the selected file exists
            if (File.Exists(selectedFilePath) == false)
            {
                return;
            }

            // オリジナルの画像を取得
            Bitmap originalImage = new Bitmap(selectedFilePath);

            // 分割数、間引き数、出力する行・列の数を取得
            int rowDivisions = int.Parse(comboBoxRow.SelectedItem.ToString());
            int columnDivisions = int.Parse(comboBoxColumn.SelectedItem.ToString());
            int thinning = comboBoxThinning.SelectedIndex;
            if (thinning != 0)
            {
                thinning++;
            }
            int outputRows = Convert.ToInt32(numericUpDownOutputRow.Value);
            int outputColumns = Convert.ToInt32(numericUpDownOutputColumn.Value);

            Bitmap result = ThinAndReorderAnimation(originalImage, rowDivisions, columnDivisions, thinning, outputRows, outputColumns);

            pictureBoxPreview.Image =  PrepareImageWithGridLines(result,outputRows,outputColumns);

            // 使用したBitmapをDisposeする
            result.Dispose();
        }


        private void updatePictureBoxView()
        {
            // Check if the selected file exists
            if (File.Exists(selectedFilePath) == false)
            {
                return;
            }

            if (comboBoxColumn.SelectedItem == null || comboBoxRow.SelectedItem == null)
            {
                return;
            }

            // Get the number of row and column divisions from the combo boxes
            int rowDivisions = int.Parse(comboBoxRow.SelectedItem.ToString());
            int columnDivisions = int.Parse(comboBoxColumn.SelectedItem.ToString());

            // Load the original image
            using (Bitmap originalImage = new Bitmap(selectedFilePath))
            {
                // Prepare the image with grid lines and set it as the picture box's image
                pictureBoxPreview.Image = PrepareImageWithGridLines(originalImage, rowDivisions, columnDivisions);
            }
        }

        private Bitmap PrepareImageWithGridLines(Bitmap originalImage, int rowDivisions, int columnDivisions)
        {
            // 新しいBitmapを作成する（オリジナルの画像と同じサイズ）
            using (Bitmap newImage = new Bitmap(originalImage.Width, originalImage.Height))
            {
                // オリジナルの画像を新しいBitmapにコピー
                using (Graphics g = Graphics.FromImage(newImage))
                {
                    g.DrawImage(originalImage, 0, 0, originalImage.Width, originalImage.Height);

                    // グリッドラインを描画
                    DrawGridLinesOnImage(newImage, rowDivisions, columnDivisions);
                }

                // リサイズ
                Bitmap resizedImage = ResizeImage(newImage);

                // 新しい画像を返す
                return (Bitmap)resizedImage.Clone();
            }
        }

        private void DrawGridLinesOnImage(Bitmap image, int rowDivisions, int columnDivisions)
        {
            using (Graphics g = Graphics.FromImage(image))
            {
                // 赤いペンを作成（1px）
                using (Pen redPen = new Pen(Color.Red, 1))
                {
                    // ヨコに赤線を描画
                    double rowInterval = (double)image.Height / rowDivisions;
                    for (int i = 0; i <= rowDivisions; i++)
                    {
                        int yPosition = (int)Math.Ceiling(i * rowInterval);
                        yPosition = Math.Min(yPosition, image.Height - 1); // 端数があったら切り上げて描画
                        g.DrawLine(redPen, 0, yPosition, image.Width, yPosition);
                    }

                    // タテに赤線を描画
                    double columnInterval = (double)image.Width / columnDivisions;
                    for (int i = 0; i <= columnDivisions; i++)
                    {
                        int xPosition = (int)Math.Ceiling(i * columnInterval);
                        xPosition = Math.Min(xPosition, image.Width - 1); // 端数があったら切り上げて描画
                        g.DrawLine(redPen, xPosition, 0, xPosition, image.Height);
                    }
                }
            }
        }

        private Bitmap ResizeImage(Bitmap image)
        {
            Bitmap resizedImage;
            // radioButtonRateHalfにチェックが入っている場合
            if (radioButtonRateHalf.Checked)
            {
                int newWidth = image.Width / 2;
                int newHeight = image.Height / 2;
                resizedImage = new Bitmap(image.GetThumbnailImage(newWidth, newHeight, null, IntPtr.Zero));
            }
            // radioButtonRateQuartにチェックが入っている場合
            else if (radioButtonRateQuart.Checked)
            {
                int newWidth = image.Width / 4;
                int newHeight = image.Height / 4;
                resizedImage = new Bitmap(image.GetThumbnailImage(newWidth, newHeight, null, IntPtr.Zero));
            }
            else
            {
                resizedImage = image;
            }

            return resizedImage;
        }

        private void UpdateOutputDevides()
        {
            if (comboBoxColumn.SelectedItem == null || comboBoxRow.SelectedItem == null)
            {
                return;
            }

            int numberColumn, numberRow;

            if (int.TryParse(comboBoxColumn.SelectedItem.ToString(), out numberColumn)
                && int.TryParse(comboBoxRow.SelectedItem.ToString(), out numberRow))
            {
                numericUpDownOutputColumn.Value = numberColumn;
                numericUpDownOutputRow.Value = numberRow;
            }
            else
            {
            }
        }

        private void ComboBoxColumn_SelectedIndexChanged(object sender, EventArgs e)
        {
            updatePictureBoxView();
            UpdateOutputDevides();
            UpdateCellsSum();
            CheckOver();

        }

        private void ComboBoxRow_SelectedIndexChanged(object sender, EventArgs e)
        {
            updatePictureBoxView();
            UpdateOutputDevides();
            UpdateCellsSum();
            CheckOver();
        }

        private void CheckBoxGridLine_CheckedChanged(object sender, EventArgs e)
        {
            updatePictureBoxView();
            UpdateOutputDevides();
            UpdateCellsSum();
            CheckOver();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            // ColorOptionsの各値をcomboBoxBackgroundに追加します。
            foreach (ColorOptions option in Enum.GetValues(typeof(ColorOptions)))
            {
                comboBoxBackground.Items.Add(Program.GetEnumDescription(option));
            }

            // 背景色の設定を反映
            comboBoxBackground.SelectedIndex = (int)Program.settings.BackgroundColor;

            // ファイルが存在する場合のみ、ファイルパスを設定
            if (File.Exists(Program.settings.SelectedFilePath))
            {
                selectedFilePath = Program.settings.SelectedFilePath;
            }
            else
            {
                comboBoxColumn.Enabled = false;
                comboBoxRow.Enabled = false;
            }

            // ラジオボタンの状態を反映
            if(Program.settings.IsRadioButtonPrevColor1Checked)
            {
                radioButtonPrevColor1.Checked = true;
            }
            else
            {
                radioButtonPrevColor2.Checked = true;
            }

            comboBoxThinning.SelectedIndex = 1;

            UpdateTextboxFilePath();
            UpdateCellsSum();
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(File.Exists(selectedFilePath))
            {
                Program.settings.SelectedFilePath = selectedFilePath;
            }
            Program.settings.BackgroundColor = (ColorOptions)comboBoxBackground.SelectedIndex;
            Program.settings.IsRadioButtonPrevColor1Checked = radioButtonPrevColor1.Checked;
            Program.settings.Save();
        }

        private void UpdateCellsSum()
        {
            if (comboBoxColumn.SelectedItem == null
                || comboBoxRow.SelectedItem == null
                || comboBoxThinning.SelectedItem == null)
            {
                labelTotal.Text = "合計コマ数 -";
                return;
            }

            // 選択されたアイテムを数値に変換
            int numberColumn = int.Parse(comboBoxColumn.SelectedItem.ToString());
            int numberRow = int.Parse(comboBoxRow.SelectedItem.ToString());
            int numberThinning = comboBoxThinning.SelectedIndex;
            if(numberThinning != 0)
            {
                numberThinning++;
            }
            // コマ数を計算
            int totalCells = numberColumn * numberRow;
            int totalThinnedCells;

            if (numberThinning != 0)
            {
                totalThinnedCells = totalCells / numberThinning;

                if (totalCells % numberThinning != 0)
                {
                    totalThinnedCells++;
                }
            }
            else
            {
                totalThinnedCells = totalCells;
            }

            labelTotal.Text = "合計コマ数 " + totalThinnedCells.ToString();
            cellsMax = totalThinnedCells;
        }

        private void ComboBoxThinning_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateCellsSum();
            CheckOver();
        }

        private void NumericUpDownOutputRow_ValueChanged(object sender, EventArgs e)
        {
            CheckOver();
        }
        private void NumericUpDownOutputColumn_ValueChanged(object sender, EventArgs e)
        {
            CheckOver();
        }

        private void CheckOver()
        {
            int totalCells = (int)numericUpDownOutputColumn.Value * (int)numericUpDownOutputRow.Value;

            if (totalCells < cellsMax)
            {
                labelError.Text = "超過注意！";
            }
            else
            {
                labelError.Text = "";
            }
        }

        private void RadioButtonRateHalf_CheckedChanged(object sender, EventArgs e)
        {
            updatePictureBoxView();
        }

        private void RadioButtonRateQuart_CheckedChanged(object sender, EventArgs e)
        {
            updatePictureBoxView();
        }

        private void RadioButtonRate1_CheckedChanged(object sender, EventArgs e)
        {
            updatePictureBoxView();
        }

        private void ButtonOriginalPrev_Click(object sender, EventArgs e)
        {
            updatePictureBoxView();
        }

        private void textBoxTargetPath_TextChanged(object sender, EventArgs e)
        {
            selectedFilePath = textBoxTargetPath.Text;
            UpdateTextboxFilePath();
        }
    }


}
