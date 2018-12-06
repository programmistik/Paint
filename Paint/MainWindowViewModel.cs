//using GalaSoft.MvvmLight.CommandWpf;
using Microsoft.Ink;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media;

namespace Paint
{
    public class MainWindowViewModel
    {
        #region Tools
        private RelayCommand pencilCommand;
        public RelayCommand PencilCommand
        {
            get => pencilCommand ?? (pencilCommand = new RelayCommand(
                param =>
                {
                    var win = param as MainWindow;
                    win.myInkCanvas.DefaultDrawingAttributes.Color = Colors.Black;
                    win.btnColor.Background = Brushes.Black;
                    win.myInkCanvas.DefaultDrawingAttributes.Width = 1d;
                    win.myInkCanvas.DefaultDrawingAttributes.Height = 1d;
                }
            ));
        }

        private RelayCommand eraserCommand;
        public RelayCommand EraserCommand
        {
            get => eraserCommand ?? (eraserCommand = new RelayCommand(
                param =>
                {
                    var win = param as MainWindow;
                    win.myInkCanvas.Strokes.Clear();
                }
            ));
        }
        #endregion

        #region Colors Commands  
        private RelayCommand blackCommand;
        public RelayCommand BlackCommand
        {
            get => blackCommand ?? (blackCommand = new RelayCommand(
                param =>
                {
                    var win = param as MainWindow;
                    win.myInkCanvas.DefaultDrawingAttributes.Color = Colors.Black;
                    win.btnColor.Background = Brushes.Black;
                }
            ));
        }

        private RelayCommand grayCommand;
        public RelayCommand GrayCommand
        {
            get => grayCommand ?? (grayCommand = new RelayCommand(
                param =>
                {
                    var win = param as MainWindow;
                    win.myInkCanvas.DefaultDrawingAttributes.Color = Colors.Gray;
                    win.btnColor.Background = Brushes.Gray;
                }
            ));
        }

        private RelayCommand darkredCommand;
        public RelayCommand DarkRedCommand
        {
            get => darkredCommand ?? (darkredCommand = new RelayCommand(
                param =>
                {
                    var win = param as MainWindow;
                    win.myInkCanvas.DefaultDrawingAttributes.Color = Colors.DarkRed;
                    win.btnColor.Background = Brushes.DarkRed;
                }
            ));
        }

        private RelayCommand redCommand;
        public RelayCommand RedCommand
        {
            get => redCommand ?? (redCommand = new RelayCommand(
                param =>
                {
                    var win = param as MainWindow;
                    win.myInkCanvas.DefaultDrawingAttributes.Color = Colors.Red;
                    win.btnColor.Background = Brushes.Red;
                }
            ));
        }

        private RelayCommand orangeCommand;
        public RelayCommand OrangeCommand
        {
            get => orangeCommand ?? (orangeCommand = new RelayCommand(
                param =>
                {
                    var win = param as MainWindow;
                    win.myInkCanvas.DefaultDrawingAttributes.Color = Colors.Orange;
                    win.btnColor.Background = Brushes.Orange;
                }
            ));
        }

        private RelayCommand yellowCommand;
        public RelayCommand YellowCommand
        {
            get => yellowCommand ?? (yellowCommand = new RelayCommand(
                param =>
                {
                    var win = param as MainWindow;
                    win.myInkCanvas.DefaultDrawingAttributes.Color = Colors.Yellow;
                    win.btnColor.Background = Brushes.Yellow;
                }
            ));
        }

        private RelayCommand greenCommand;
        public RelayCommand GreenCommand
        {
            get => greenCommand ?? (greenCommand = new RelayCommand(
                param =>
                {
                    var win = param as MainWindow;
                    win.myInkCanvas.DefaultDrawingAttributes.Color = Colors.Green;
                    win.btnColor.Background = Brushes.Green;
                }
            ));
        }

        private RelayCommand turquoiseCommand;
        public RelayCommand TurquoiseCommand
        {
            get => turquoiseCommand ?? (turquoiseCommand = new RelayCommand(
                param =>
                {
                    var win = param as MainWindow;
                    win.myInkCanvas.DefaultDrawingAttributes.Color = Colors.Turquoise;
                    win.btnColor.Background = Brushes.Turquoise;
                }
            ));
        }

        private RelayCommand indigoCommand;
        public RelayCommand IndigoCommand
        {
            get => indigoCommand ?? (indigoCommand = new RelayCommand(
                param =>
                {
                    var win = param as MainWindow;
                    win.myInkCanvas.DefaultDrawingAttributes.Color = Colors.Indigo;
                    win.btnColor.Background = Brushes.Indigo;
                }
            ));
        }

        private RelayCommand purpleCommand;
        public RelayCommand PurpleCommand
        {
            get => purpleCommand ?? (purpleCommand = new RelayCommand(
                param =>
                {
                    var win = param as MainWindow;
                    win.myInkCanvas.DefaultDrawingAttributes.Color = Colors.Purple;
                    win.btnColor.Background = Brushes.Purple;
                }
            ));
        }

        private RelayCommand whiteCommand;
        public RelayCommand WhiteCommand
        {
            get => whiteCommand ?? (whiteCommand = new RelayCommand(
                param =>
                {
                    var win = param as MainWindow;
                    win.myInkCanvas.DefaultDrawingAttributes.Color = Colors.White;
                    win.btnColor.Background = Brushes.White;
                }
            ));
        }

        private RelayCommand lightGrayCommand;
        public RelayCommand LightGrayCommand
        {
            get => lightGrayCommand ?? (lightGrayCommand = new RelayCommand(
                param =>
                {
                    var win = param as MainWindow;
                    win.myInkCanvas.DefaultDrawingAttributes.Color = Colors.LightGray;
                    win.btnColor.Background = Brushes.LightGray;
                }
            ));
        }

        private RelayCommand brownCommand;
        public RelayCommand BrownCommand
        {
            get => brownCommand ?? (brownCommand = new RelayCommand(
                param =>
                {
                    var win = param as MainWindow;
                    win.myInkCanvas.DefaultDrawingAttributes.Color = Colors.Brown;
                    win.btnColor.Background = Brushes.Brown;
                }
            ));
        }

        private RelayCommand pinkCommand;
        public RelayCommand PinkCommand
        {
            get => pinkCommand ?? (pinkCommand = new RelayCommand(
                param =>
                {
                    var win = param as MainWindow;
                    win.myInkCanvas.DefaultDrawingAttributes.Color = Colors.Pink;
                    win.btnColor.Background = Brushes.Pink;
                }
            ));
        }

        private RelayCommand goldCommand;
        public RelayCommand GoldCommand
        {
            get => goldCommand ?? (goldCommand = new RelayCommand(
                param =>
                {
                    var win = param as MainWindow;
                    win.myInkCanvas.DefaultDrawingAttributes.Color = Colors.Gold;
                    win.btnColor.Background = Brushes.Gold;
                }
            ));
        }

        private RelayCommand lightYellowCommand;
        public RelayCommand LightYellowCommand
        {
            get => lightYellowCommand ?? (lightYellowCommand = new RelayCommand(
                param =>
                {
                    var win = param as MainWindow;
                    win.myInkCanvas.DefaultDrawingAttributes.Color = Colors.LightYellow;
                    win.btnColor.Background = Brushes.LightYellow;
                }
            ));
        }

        private RelayCommand limeCommand;
        public RelayCommand LimeCommand
        {
            get => limeCommand ?? (limeCommand = new RelayCommand(
                param =>
                {
                    var win = param as MainWindow;
                    win.myInkCanvas.DefaultDrawingAttributes.Color = Colors.Lime;
                    win.btnColor.Background = Brushes.Lime;
                }
            ));
        }

        private RelayCommand lightBlueCommand;
        public RelayCommand LightBlueCommand
        {
            get => lightBlueCommand ?? (lightBlueCommand = new RelayCommand(
                param =>
                {
                    var win = param as MainWindow;
                    win.myInkCanvas.DefaultDrawingAttributes.Color = Colors.LightBlue;
                    win.btnColor.Background = Brushes.LightBlue;
                }
            ));
        }

        private RelayCommand steelBlueCommand;
        public RelayCommand SteelBlueCommand
        {
            get => steelBlueCommand ?? (steelBlueCommand = new RelayCommand(
                param =>
                {
                    var win = param as MainWindow;
                    win.myInkCanvas.DefaultDrawingAttributes.Color = Colors.SteelBlue;
                    win.btnColor.Background = Brushes.SteelBlue;
                }
            ));
        }

        private RelayCommand lavenderCommand;
        public RelayCommand LavenderCommand
        {
            get => lavenderCommand ?? (lavenderCommand = new RelayCommand(
                param =>
                {
                    var win = param as MainWindow;
                    win.myInkCanvas.DefaultDrawingAttributes.Color = Colors.Lavender;
                    win.btnColor.Background = Brushes.Lavender;
                }
            ));
        }

       
        #endregion

        #region Recognize
        private RelayCommand recognizeCommand;
        public RelayCommand RecognizeCommand
        {
            get => recognizeCommand ?? (recognizeCommand = new RelayCommand(
                param =>
                {
                    var win = param as MainWindow;

                    using (MemoryStream ms = new MemoryStream())
                    {
                        win.myInkCanvas.Strokes.Save(ms);
                        var myInkCollector = new InkCollector();
                        var ink = new Ink();
                        ink.Load(ms.ToArray());

                        using (RecognizerContext context = new RecognizerContext())
                        {
                            if (ink.Strokes.Count > 0)
                            {
                                context.Strokes = ink.Strokes;
                                RecognitionStatus status;

                                var result = context.Recognize(out status);

                                if (status == RecognitionStatus.NoError)
                                    win.TextResult.Text = result.TopString;
                                else
                                    MessageBox.Show("Recognition failed");

                            }
                            else
                                MessageBox.Show("No stroke detected");
                        }
                    }
                }
            ));
        }
#endregion

        #region Brush size
        private RelayCommand brushSize1Command;
        public RelayCommand BrushSize1Command
        {
            get => brushSize1Command ?? (brushSize1Command = new RelayCommand(
                param =>
                {
                    var win = param as MainWindow;
                    win.myInkCanvas.DefaultDrawingAttributes.Width = 1d;
                    win.myInkCanvas.DefaultDrawingAttributes.Height = 1d;
                }
            ));
        }

        private RelayCommand brushSize3Command;
        public RelayCommand BrushSize3Command
        {
            get => brushSize3Command ?? (brushSize3Command = new RelayCommand(
                param =>
                {
                    var win = param as MainWindow;
                    win.myInkCanvas.DefaultDrawingAttributes.Width = 3d;
                    win.myInkCanvas.DefaultDrawingAttributes.Height = 3d;
                }
            ));
        }

        private RelayCommand brushSize5Command;
        public RelayCommand BrushSize5Command
        {
            get => brushSize5Command ?? (brushSize5Command = new RelayCommand(
                param =>
                {
                    var win = param as MainWindow;
                    win.myInkCanvas.DefaultDrawingAttributes.Width = 5d;
                    win.myInkCanvas.DefaultDrawingAttributes.Height = 5d;
                }
            ));
        }
        #endregion 
    }
}
