using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Media.Animation;

namespace Controls
{
    /// <summary>
    /// Follow steps 1a or 1b and then 2 to use this custom control in a XAML file.
    ///
    /// Step 1a) Using this custom control in a XAML file that exists in the current project.
    /// Add this XmlNamespace attribute to the root element of the markup file where it is 
    /// to be used:
    ///
    ///     xmlns:MyNamespace="clr-namespace:Controls"
    ///
    ///
    /// Step 1b) Using this custom control in a XAML file that exists in a different project.
    /// Add this XmlNamespace attribute to the root element of the markup file where it is 
    /// to be used:
    ///
    ///     xmlns:MyNamespace="clr-namespace:Controls;assembly=Controls"
    ///
    /// You will also need to add a project reference from the project where the XAML file lives
    /// to this project and Rebuild to avoid compilation errors:
    ///
    ///     Right click on the target project in the Solution Explorer and
    ///     "Add Reference"->"Projects"->[Browse to and select this project]
    ///
    ///
    /// Step 2)
    /// Go ahead and use your control in the XAML file.
    ///
    ///     <MyNamespace:NewsTicker/>
    ///
    /// </summary>
    public class NewsTicker : ContentControl
    {
        public enum TickerDirection
        {
            East,
            West
        }

        Storyboard newsTickerStoryboard = null;
        Canvas contentControl = null;
        ContentPresenter content = null;
        
        static NewsTicker()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(NewsTicker), new FrameworkPropertyMetadata(typeof(NewsTicker)));
        }

        public NewsTicker()
        {
            this.Loaded += new RoutedEventHandler(NewsTicker_Loaded);
        }

        public void Start()
        {
            if (newsTickerStoryboard != null && !IsStarted)
            {
                {
                    UpdateAnimationDetails(contentControl.ActualWidth, content.ActualWidth);

                    newsTickerStoryboard.Begin(contentControl, true);
                    IsStarted = true;
                }
            }
        }
               
        public void Stop()
        {
            if (newsTickerStoryboard != null &&
                IsStarted)
            {
                newsTickerStoryboard.Stop(contentControl);
                IsStarted = false;
            }
        }

        public bool IsStarted { get; private set; }

        public double Rate
        {
            get { return (double)GetValue(RateProperty); }
            set { SetValue(RateProperty, value); }
        }

        public static readonly DependencyProperty RateProperty = DependencyProperty.Register("Rate", typeof(double), typeof(NewsTicker), 
            new UIPropertyMetadata(140.0));

        public TickerDirection Direction
        {
            get { return (TickerDirection)GetValue(DirectionProperty); }
            set { SetValue(DirectionProperty, value); }
        }

        public static readonly DependencyProperty DirectionProperty = DependencyProperty.Register("Direction", typeof(TickerDirection), 
            typeof(NewsTicker), new UIPropertyMetadata(TickerDirection.West));

        void NewsTicker_Loaded(object sender, RoutedEventArgs e)
        {
            contentControl = GetTemplateChild("PART_ContentControl") as Canvas;

            if (contentControl != null)
            {
                contentControl.SizeChanged += new SizeChangedEventHandler(_ContentControl_SizeChanged);                
            }

            content = GetTemplateChild("PART_Content") as ContentPresenter;

            if (content != null)
            {
                content.SizeChanged += new SizeChangedEventHandler(_Content_SizeChanged);
            }

            newsTickerStoryboard = GetTemplateChild("NewsTickerStoryboard") as Storyboard;

            if (contentControl.ActualWidth == 0 && double.IsNaN(contentControl.Width))
            {
                contentControl.Width = contentControl.ActualWidth;
            }

            if (contentControl.ActualHeight == 0 && double.IsNaN(contentControl.Height))
            {
                contentControl.Height = contentControl.ActualHeight;
            }

            VerticallyAlignContent(contentControl.ActualHeight);

            Start();
        }

        void _Content_SizeChanged(object sender, SizeChangedEventArgs e)
        {
            UpdateAnimationDetails(contentControl.ActualWidth, e.NewSize.Width);
        }

        void _ContentControl_SizeChanged(object sender, SizeChangedEventArgs e)
        {
            VerticallyAlignContent(e.NewSize.Height);
            UpdateAnimationDetails(e.NewSize.Width, content.ActualWidth);
        }

        void VerticallyAlignContent(double height)
        {
            double contentHeight = content.ActualHeight;
            switch (content.VerticalAlignment)
            {
                case System.Windows.VerticalAlignment.Top:
                    Canvas.SetTop(content, 0);
                    break;
                case System.Windows.VerticalAlignment.Bottom:
                    if (height > contentHeight)
                        Canvas.SetTop(content, height - contentHeight);
                    break;
                case System.Windows.VerticalAlignment.Center:
                case System.Windows.VerticalAlignment.Stretch:
                    if (height > contentHeight)
                        Canvas.SetTop(content, (height - contentHeight) / 2);
                    break;
            }
        }


        void UpdateAnimationDetails(double holderLength, double contentLength)
        {
            DoubleAnimation animation =
                newsTickerStoryboard.Children.First() as DoubleAnimation;
            if (animation != null)
            {
                bool start = false;
                if (IsStarted)
                {
                    Stop();
                    start = true;
                }

                double from = 0, to = 0, time = 0;
                switch (Direction)
                {
                    case TickerDirection.West:
                        from = holderLength;
                        to = -1 * contentLength;
                        time = from / Rate;
                        break;
                    case TickerDirection.East:
                        from = -1 * contentLength;
                        to = holderLength;
                        time = to / Rate;
                        break;
                }

                animation.From = from;
                animation.To = to;
                TimeSpan newDuration = TimeSpan.FromSeconds(time);
                animation.Duration = new Duration(newDuration);

                //if (start)
                //{
                //    TimeSpan? oldDuration = null;
                //    if (animation.Duration.HasTimeSpan)
                //        oldDuration = animation.Duration.TimeSpan;
                //    TimeSpan? currentTime = newsTickerStoryboard.GetCurrentTime(contentControl);
                //    int? iteration = newsTickerStoryboard.GetCurrentIteration(contentControl);
                //    TimeSpan? offset =
                //        TimeSpan.FromSeconds(
                //        currentTime.HasValue ?
                //        currentTime.Value.TotalSeconds % (oldDuration.HasValue ? oldDuration.Value.TotalSeconds : 1.0) :
                //        0.0);

                //    Start();

                //    if (offset.HasValue &&
                //        offset.Value != TimeSpan.Zero &&
                //        offset.Value < newDuration)
                //        newsTickerStoryboard.SeekAlignedToLastTick(contentControl, offset.Value, TimeSeekOrigin.BeginTime);
                //}
            }
        }
    }
}
