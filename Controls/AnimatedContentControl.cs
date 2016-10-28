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
    ///     <MyNamespace:AnimatedContentControl/>
    ///
    /// </summary>
    [TemplatePart(Name = "PART_PaintArea", Type = typeof(Shape)),
    TemplatePart(Name = "PART_MainContent", Type = typeof(ContentPresenter))]
    public class AnimatedContentControl : ContentControl
    {
        static AnimatedContentControl()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(AnimatedContentControl), new FrameworkPropertyMetadata(typeof(AnimatedContentControl)));
        }

        Shape paintArea;
        ContentPresenter mainContent;
        Border borderSeparator;
        Grid mainGrid;
        

        public override void OnApplyTemplate()
        {
            paintArea = Template.FindName("PART_PaintArea", this) as Shape;
            mainContent = Template.FindName("PART_MainContent", this) as ContentPresenter;
            mainGrid = Template.FindName("PART_MainGrid", this) as Grid;
            borderSeparator = Template.FindName("borderSeparator", this) as Border;
            
            base.OnApplyTemplate();

            
        }

        protected override void OnContentChanged(object oldContent, object newContent)
        {
            if (paintArea != null && mainContent != null)
            {

                borderSeparator.BeginAnimation(OpacityProperty, CreateSeparatorAnimation(0.0, 1.0, Separator_Displayed));
                
                BeginAnimateContentReplacement();                               
                                
            }

            base.OnContentChanged(oldContent, newContent);
        }

        private void BeginAnimateContentReplacement()
        {
            var newContentTransform = new TranslateTransform();
            var oldContentTransform = new TranslateTransform();
            paintArea.RenderTransform = oldContentTransform;
            mainContent.RenderTransform = newContentTransform;
            paintArea.Visibility = Visibility.Visible;

            
            newContentTransform.BeginAnimation(TranslateTransform.XProperty, CreateAnimation(this.ActualWidth, 0, null));
            oldContentTransform.BeginAnimation(TranslateTransform.XProperty, CreateAnimation(0, -this.ActualWidth, (s, e) => paintArea.Visibility = Visibility.Hidden));
            
        }

        private AnimationTimeline CreateAnimation(double from, double to, EventHandler whenDone = null)
        {
            IEasingFunction ease = new BackEase { Amplitude = 0.5, EasingMode = EasingMode.EaseOut };
            var duration = new Duration(TimeSpan.FromSeconds(0.5));
            var anim = new DoubleAnimation(from, to, duration); //{ EasingFunction = ease };
            
            if (whenDone != null)
            {
                anim.Completed += whenDone;
            }
            anim.Freeze();
            return anim;
        }

        private AnimationTimeline CreateSeparatorAnimation(double from, double to, EventHandler whenDone = null)
        {
            var duration = new Duration(TimeSpan.FromSeconds(2.0));
            var anim = new DoubleAnimation(from, to, duration);
            
            if (whenDone != null)
            {
                anim.Completed += whenDone;
            }

            anim.Freeze();
            return anim;
        }

        private Brush CreateBrushFromVisual(Visual v)
        {
            if (v == null)
            {
                throw new ArgumentNullException("v");
            }
            var target = new RenderTargetBitmap((int)this.ActualWidth, (int)this.ActualHeight, 96, 96, PixelFormats.Pbgra32);
            target.Render(v);
            var brush = new ImageBrush(target);
            brush.Freeze();
            return brush;
        }
        
        private void Separator_Displayed(object sender, EventArgs e)
        {
            paintArea.Fill = CreateBrushFromVisual(mainGrid);            
        }
    }
}
