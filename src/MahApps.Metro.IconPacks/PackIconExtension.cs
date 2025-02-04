﻿using System;
#if (NETFX_CORE || WINDOWS_UWP)
using Windows.UI.Xaml;
using Windows.UI.Xaml.Markup;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Media.Animation;
#else
using System.Windows.Markup;
using System.Windows.Media.Animation;
#endif

namespace MahApps.Metro.IconPacks
{
    public interface IPackIconExtension
    {
        double? Width { get; set; }
        double? Height { get; set; }
        PackIconFlipOrientation? Flip { get; set; }
        double? RotationAngle { get; set; }
        bool? Spin { get; set; }
        bool? SpinAutoReverse { get; set; }
#if (NETFX_CORE || WINDOWS_UWP)
        EasingFunctionBase SpinEasingFunction { get; set; }
#else
        IEasingFunction SpinEasingFunction { get; set; }
#endif
        double? SpinDuration { get; set; }
    }

    public static class PackIconExtensionHelper
    {
        public static PackIconControl<TKind> GetPackIcon<TPack, TKind>(this IPackIconExtension packIconExtension, TKind kind) where TPack : PackIconControl<TKind>, new()
        {
            var packIcon = new TPack {Kind = kind};
            if (packIconExtension.Width != null)
                packIcon.Width = packIconExtension.Width.Value;
            if (packIconExtension.Height != null)
                packIcon.Height = packIconExtension.Height.Value;
            if (packIconExtension.Flip != null)
                packIcon.Flip = packIconExtension.Flip.Value;
            if (packIconExtension.RotationAngle != null)
                packIcon.RotationAngle = packIconExtension.RotationAngle.Value;
            if (packIconExtension.Spin != null)
                packIcon.Spin = packIconExtension.Spin.Value;
            if (packIconExtension.SpinAutoReverse != null)
                packIcon.SpinAutoReverse = packIconExtension.SpinAutoReverse.Value;
            if (packIconExtension.SpinEasingFunction != null)
                packIcon.SpinEasingFunction = packIconExtension.SpinEasingFunction;
            if (packIconExtension.SpinDuration != null)
                packIcon.SpinDuration = packIconExtension.SpinDuration.Value;
            return packIcon;
        }
    }

#if (NETFX_CORE || WINDOWS_UWP)
    [MarkupExtensionReturnType(ReturnType = typeof(PackIconBase))]
#else
    [MarkupExtensionReturnType(typeof(PackIconBase))]
#endif
    public class PackIconExtension : MarkupExtension, IPackIconExtension
    {
#if !(NETFX_CORE || WINDOWS_UWP)
        [ConstructorArgument("kind")]
#endif
        public Enum Kind { get; set; }

        public double? Width { get; set; }
        public double? Height { get; set; }
        public PackIconFlipOrientation? Flip { get; set; }
        public double? RotationAngle { get; set; }
        public bool? Spin { get; set; }
        public bool? SpinAutoReverse { get; set; }
#if (NETFX_CORE || WINDOWS_UWP)
        public EasingFunctionBase SpinEasingFunction { get; set; }
#else
        public IEasingFunction SpinEasingFunction { get; set; }
#endif
        public double? SpinDuration { get; set; }

        public PackIconExtension()
        {
        }

        public PackIconExtension(Enum kind)
        {
            this.Kind = kind;
        }

#if (NETFX_CORE || WINDOWS_UWP)
        protected override object ProvideValue()
#else
        public override object ProvideValue(IServiceProvider serviceProvider)
#endif
        {
#if ALL || ENTYPO
            if (this.Kind is PackIconEntypoKind)
            {
                return this.GetPackIcon<PackIconEntypo, PackIconEntypoKind>((PackIconEntypoKind) this.Kind);
            }
#endif
#if ALL || FONTAWESOME
            if (this.Kind is PackIconFontAwesomeKind)
            {
                return this.GetPackIcon<PackIconFontAwesome, PackIconFontAwesomeKind>((PackIconFontAwesomeKind) this.Kind);
            }
#endif
#if ALL || MATERIAL
            if (this.Kind is PackIconMaterialKind)
            {
                return this.GetPackIcon<PackIconMaterial, PackIconMaterialKind>((PackIconMaterialKind) this.Kind);
            }
#endif
#if ALL || MATERIALLIGHT
            if (this.Kind is PackIconMaterialLightKind)
            {
                return this.GetPackIcon<PackIconMaterialLight, PackIconMaterialLightKind>((PackIconMaterialLightKind) this.Kind);
            }
#endif
#if ALL || MODERN
            if (this.Kind is PackIconModernKind)
            {
                return this.GetPackIcon<PackIconModern, PackIconModernKind>((PackIconModernKind) this.Kind);
            }
#endif
#if ALL || OCTICONS
            if (this.Kind is PackIconOcticonsKind)
            {
                return this.GetPackIcon<PackIconOcticons, PackIconOcticonsKind>((PackIconOcticonsKind) this.Kind);
            }
#endif
#if ALL || SIMPLEICONS
            if (this.Kind is PackIconSimpleIconsKind)
            {
                return this.GetPackIcon<PackIconSimpleIcons, PackIconSimpleIconsKind>((PackIconSimpleIconsKind) this.Kind);
            }
#endif
#if ALL || WEATHERICONS
            if (this.Kind is PackIconWeatherIconsKind)
            {
                return this.GetPackIcon<PackIconWeatherIcons, PackIconWeatherIconsKind>((PackIconWeatherIconsKind) this.Kind);
            }
#endif
#if ALL || TYPICONS
            if (this.Kind is PackIconTypiconsKind)
            {
                return this.GetPackIcon<PackIconTypicons, PackIconTypiconsKind>((PackIconTypiconsKind) this.Kind);
            }
#endif
#if ALL || FEATHERICONS
            if (this.Kind is PackIconFeatherIconsKind)
            {
                return this.GetPackIcon<PackIconFeatherIcons, PackIconFeatherIconsKind>((PackIconFeatherIconsKind) this.Kind);
            }
#endif
#if ALL || MATERIALDESIGN
            if (this.Kind is PackIconMaterialDesignKind)
            {
                return this.GetPackIcon<PackIconMaterialDesign, PackIconMaterialDesignKind>((PackIconMaterialDesignKind) this.Kind);
            }
#endif
#if ALL || IONICONS
            if (this.Kind is PackIconIoniconsKind)
            {
                return this.GetPackIcon<PackIconIonicons, PackIconIoniconsKind>((PackIconIoniconsKind) this.Kind);
            }
#endif
#if ALL || JAMICONS
            if (this.Kind is PackIconJamIconsKind)
            {
                return this.GetPackIcon<PackIconJamIcons, PackIconJamIconsKind>((PackIconJamIconsKind) this.Kind);
            }
#endif
#if ALL || UNICONS
            if (this.Kind is PackIconUniconsKind)
            {
                return this.GetPackIcon<PackIconUnicons, PackIconUniconsKind>((PackIconUniconsKind) this.Kind);
            }
#endif
#if ALL || ZONDICONS
            if (this.Kind is PackIconZondiconsKind)
            {
                return this.GetPackIcon<PackIconZondicons, PackIconZondiconsKind>((PackIconZondiconsKind) this.Kind);
            }
#endif
            return null;
        }
    }

#if (NETFX_CORE || WINDOWS_UWP)
    [MarkupExtensionReturnType(ReturnType = typeof(PackIconBase))]
#else
    [MarkupExtensionReturnType(typeof(PackIconBase))]
#endif
    public class PackIconExtension<TPack, TKind> : MarkupExtension, IPackIconExtension where TPack : PackIconControl<TKind>, new()
    {
#if !(NETFX_CORE || WINDOWS_UWP)
        [ConstructorArgument("kind")]
#endif
        public TKind Kind { get; set; }

        public double? Width { get; set; }
        public double? Height { get; set; }
        public PackIconFlipOrientation? Flip { get; set; }
        public double? RotationAngle { get; set; }
        public bool? Spin { get; set; }
        public bool? SpinAutoReverse { get; set; }
#if (NETFX_CORE || WINDOWS_UWP)
        public EasingFunctionBase SpinEasingFunction { get; set; }
#else
        public IEasingFunction SpinEasingFunction { get; set; }
#endif
        public double? SpinDuration { get; set; }

        public PackIconExtension()
        {
        }

        public PackIconExtension(TKind kind)
        {
            this.Kind = kind;
        }

#if (NETFX_CORE || WINDOWS_UWP)
        protected override object ProvideValue()
#else
        public override object ProvideValue(IServiceProvider serviceProvider)
#endif
        {
            return this.GetPackIcon<TPack, TKind>(this.Kind);
        }
    }
}