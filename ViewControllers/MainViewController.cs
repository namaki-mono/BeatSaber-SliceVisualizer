using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using BeatSaberMarkupLanguage.Attributes;
using BeatSaberMarkupLanguage.ViewControllers;
using SliceVisualizer.Configuration;
using SliceVisualizer.Models;

namespace SliceVisualizer.ViewControllers
{
    internal class MainViewController : BSMLResourceViewController
    {
        public void Activated()
        {
            NotifyPropertyChanged("EnabledValue");
            NotifyPropertyChanged("SliceWidthValue");
            NotifyPropertyChanged("ScoreScalingValue");
            NotifyPropertyChanged("ScoreScaleMinValue");
            NotifyPropertyChanged("ScoreScaleMaxValue");
            NotifyPropertyChanged("ScoreScaleValue");
            NotifyPropertyChanged("MissedAreaColorValue");
            NotifyPropertyChanged("SliceColorValue");
            NotifyPropertyChanged("ArrowColorValue");
            NotifyPropertyChanged("BadDirectionColorValue");
            NotifyPropertyChanged("CenterColorValue");
            NotifyPropertyChanged("UseCustomColorsValue");
            NotifyPropertyChanged("LeftColorValue");
            NotifyPropertyChanged("RightColorValue");
            NotifyPropertyChanged("CubeLifetimeValue");
            NotifyPropertyChanged("PopEndValue");
            NotifyPropertyChanged("FadeStartValue");
            NotifyPropertyChanged("PopDistanceValue");
            NotifyPropertyChanged("PositionFromCubeTransformValue");
            NotifyPropertyChanged("RotationFromCubeTransformValue");
            NotifyPropertyChanged("CubeScaleValue");
            NotifyPropertyChanged("CenterScaleValue");
            NotifyPropertyChanged("ArrowScaleValue");
            NotifyPropertyChanged("UIOpacityValue");
            NotifyPropertyChanged("CanvasOffsetValue");
            NotifyPropertyChanged("CanvasRotationValue");
            NotifyPropertyChanged("CanvasScaleValue");
        }
        [UIValue("Enabled-value")]
        public bool EnabledValue
        {
            get => PluginConfig.Instance.Enabled;
            set
            {
                PluginConfig.Instance.Enabled = value;
            }
        }
        [UIValue("SliceWidth-value")]
        public float SliceWidthValue
        {
            get => PluginConfig.Instance.SliceWidth;
            set
            {
                PluginConfig.Instance.SliceWidth = value;
            }
        }
        [UIValue("ScoreScaling-value")]
        public ScoreScalingMode ScoreScalingValue
        {
            get => PluginConfig.Instance.ScoreScaling;
            set
            {
                PluginConfig.Instance.ScoreScaling = value;
            }
        }
        [UIValue("ScoreScaling-values")]
        private List<object> options = Enum.GetValues(typeof(ScoreScalingMode)).Cast<object>().ToList();
        [UIValue("ScoreScaleMin-value")]
        public float ScoreScaleMinValue
        {
            get => PluginConfig.Instance.ScoreScaleMin;
            set
            {
                PluginConfig.Instance.ScoreScaleMin = value;
            }
        }
        [UIValue("ScoreScaleMax-value")]
        public float ScoreScaleMaxValue
        {
            get => PluginConfig.Instance.ScoreScaleMax;
            set
            {
                PluginConfig.Instance.ScoreScaleMax = value;
            }
        }
        [UIValue("ScoreScale-value")]
        public float ScoreScaleValue
        {
            get => PluginConfig.Instance.ScoreScale;
            set
            {
                PluginConfig.Instance.ScoreScale = value;
            }
        }
        [UIValue("MissedAreaColor-value")]
        public Color MissedAreaColorValue
        {
            get => PluginConfig.Instance.MissedAreaColor;
            set
            {
                PluginConfig.Instance.MissedAreaColor = value;
            }
        }
        [UIValue("SliceColor-value")]
        public Color SliceColorValue
        {
            get => PluginConfig.Instance.SliceColor;
            set
            {
                PluginConfig.Instance.SliceColor = value;
            }
        }
        [UIValue("ArrowColor-value")]
        public Color ArrowColorValue
        {
            get => PluginConfig.Instance.ArrowColor;
            set
            {
                PluginConfig.Instance.ArrowColor = value;
            }
        }
        [UIValue("BadDirectionColor-value")]
        public Color BadDirectionColorValue
        {
            get => PluginConfig.Instance.BadDirectionColor;
            set
            {
                PluginConfig.Instance.BadDirectionColor = value;
            }
        }
        [UIValue("CenterColor-value")]
        public Color CenterColorValue
        {
            get => PluginConfig.Instance.CenterColor;
            set
            {
                PluginConfig.Instance.CenterColor = value;
            }
        }
        [UIValue("UseCustomColors-value")]
        public bool UseCustomColorsValue
        {
            get => PluginConfig.Instance.UseCustomColors;
            set
            {
                PluginConfig.Instance.UseCustomColors = value;
            }
        }
        [UIValue("LeftColor-value")]
        public Color LeftColorValue
        {
            get => PluginConfig.Instance.LeftColor;
            set
            {
                PluginConfig.Instance.LeftColor = value;
            }
        }
        [UIValue("RightColor-value")]
        public Color RightColorValue
        {
            get => PluginConfig.Instance.RightColor;
            set
            {
                PluginConfig.Instance.RightColor = value;
            }
        }
        [UIValue("CubeLifetime-value")]
        public float CubeLifetimeValue
        {
            get => PluginConfig.Instance.CubeLifetime;
            set
            {
                PluginConfig.Instance.CubeLifetime = value;
            }
        }
        [UIValue("PopEnd-value")]
        public float PopEndValue
        {
            get => PluginConfig.Instance.PopEnd;
            set
            {
                PluginConfig.Instance.PopEnd = value;
            }
        }
        [UIValue("FadeStart-value")]
        public float FadeStartValue
        {
            get => PluginConfig.Instance.FadeStart;
            set
            {
                PluginConfig.Instance.FadeStart = value;
            }
        }
        [UIValue("PopDistance-value")]
        public float PopDistanceValue
        {
            get => PluginConfig.Instance.PopDistance;
            set
            {
                PluginConfig.Instance.PopDistance = value;
            }
        }
        [UIValue("PositionFromCubeTransform-value")]
        public bool PositionFromCubeTransformValue
        {
            get => PluginConfig.Instance.PositionFromCubeTransform;
            set
            {
                PluginConfig.Instance.PositionFromCubeTransform = value;
            }
        }
        [UIValue("RotationFromCubeTransform-value")]
        public bool RotationFromCubeTransformValue
        {
            get => PluginConfig.Instance.RotationFromCubeTransform;
            set
            {
                PluginConfig.Instance.RotationFromCubeTransform = value;
            }
        }
        [UIValue("CubeScale-value")]
        public float CubeScaleValue
        {
            get => PluginConfig.Instance.CubeScale;
            set
            {
                PluginConfig.Instance.CubeScale = value;
            }
        }
        [UIValue("CenterScale-value")]
        public float CenterScaleValue
        {
            get => PluginConfig.Instance.CenterScale;
            set
            {
                PluginConfig.Instance.CenterScale = value;
            }
        }
        [UIValue("ArrowScale-value")]
        public float ArrowScaleValue
        {
            get => PluginConfig.Instance.ArrowScale;
            set
            {
                PluginConfig.Instance.ArrowScale = value;
            }
        }
        [UIValue("UIOpacity-value")]
        public float UIOpacityValue
        {
            get => PluginConfig.Instance.UIOpacity;
            set
            {
                PluginConfig.Instance.UIOpacity = value;
            }
        }
        [UIValue("CanvasOffset-value")]
        public Vector3 CanvasOffsetValue
        {
            get => PluginConfig.Instance.CanvasOffset;
            set
            {
                PluginConfig.Instance.CanvasOffset = value;
            }
        }
        [UIValue("CanvasOffsetX-value")]
        public float CanvasOffsetXValue
        {
            get => PluginConfig.Instance.CanvasOffset.x;
            set
            {
                PluginConfig.Instance.CanvasOffset = new Vector3(value, PluginConfig.Instance.CanvasOffset.y, PluginConfig.Instance.CanvasOffset.z);
                NotifyPropertyChanged("CanvasOffsetValue");
            }
        }
        [UIValue("CanvasOffsetY-value")]
        public float CanvasOffsetYValue
        {
            get => PluginConfig.Instance.CanvasOffset.y;
            set
            {
                PluginConfig.Instance.CanvasOffset = new Vector3(PluginConfig.Instance.CanvasOffset.x, value, PluginConfig.Instance.CanvasOffset.z);
                NotifyPropertyChanged("CanvasOffsetValue");
            }
        }
        [UIValue("CanvasOffsetZ-value")]
        public float CanvasOffsetZValue
        {
            get => PluginConfig.Instance.CanvasOffset.z;
            set
            {
                PluginConfig.Instance.CanvasOffset = new Vector3(PluginConfig.Instance.CanvasOffset.x, PluginConfig.Instance.CanvasOffset.y, value);
                NotifyPropertyChanged("CanvasOffsetValue");
            }
        }
        [UIValue("CanvasRotation-value")]
        public Vector3 CanvasRotationValue
        {
            get => PluginConfig.Instance.CanvasRotation;
            set
            {
                PluginConfig.Instance.CanvasRotation = value;
            }
        }
        [UIValue("CanvasRotationX-value")]
        public float CanvasRotationXValue
        {
            get => PluginConfig.Instance.CanvasRotation.x;
            set
            {
                PluginConfig.Instance.CanvasRotation = new Vector3(value, PluginConfig.Instance.CanvasRotation.y, PluginConfig.Instance.CanvasRotation.z);
                NotifyPropertyChanged("CanvasRotationValue");
            }
        }
        [UIValue("CanvasRotationY-value")]
        public float CanvasRotationYValue
        {
            get => PluginConfig.Instance.CanvasRotation.y;
            set
            {
                PluginConfig.Instance.CanvasRotation = new Vector3(PluginConfig.Instance.CanvasRotation.x, value, PluginConfig.Instance.CanvasRotation.z);
                NotifyPropertyChanged("CanvasRotationValue");
            }
        }
        [UIValue("CanvasRotationZ-value")]
        public float CanvasRotationZValue
        {
            get => PluginConfig.Instance.CanvasRotation.z;
            set
            {
                PluginConfig.Instance.CanvasRotation = new Vector3(PluginConfig.Instance.CanvasRotation.x, PluginConfig.Instance.CanvasRotation.y, value);
                NotifyPropertyChanged("CanvasRotationValue");
            }
        }
        [UIValue("CanvasScale-value")]
        public float CanvasScaleValue
        {
            get => PluginConfig.Instance.CanvasScale;
            set
            {
                PluginConfig.Instance.CanvasScale = value;
            }
        }

        public override string ResourceName => "SliceVisualizer.Views.Main.bsml";
    }
}