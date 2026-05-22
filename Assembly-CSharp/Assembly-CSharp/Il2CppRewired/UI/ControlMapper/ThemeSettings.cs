using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine;
using UnityEngine.UI;

namespace Il2CppRewired.UI.ControlMapper
{
	// Token: 0x020001FD RID: 509
	[Serializable]
	public class ThemeSettings : ScriptableObject
	{
		// Token: 0x06003EAC RID: 16044 RVA: 0x000EAAC0 File Offset: 0x000E8CC0
		// Note: this type is marked as 'beforefieldinit'.
		static ThemeSettings()
		{
			Il2CppClassPointerStore<ThemeSettings>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Rewired.UI.ControlMapper", "ThemeSettings");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ThemeSettings>.NativeClassPtr);
			ThemeSettings.NativeFieldInfoPtr__mainWindowBackground = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ThemeSettings>.NativeClassPtr, "_mainWindowBackground");
			ThemeSettings.NativeFieldInfoPtr__popupWindowBackground = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ThemeSettings>.NativeClassPtr, "_popupWindowBackground");
			ThemeSettings.NativeFieldInfoPtr__areaBackground = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ThemeSettings>.NativeClassPtr, "_areaBackground");
			ThemeSettings.NativeFieldInfoPtr__selectableSettings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ThemeSettings>.NativeClassPtr, "_selectableSettings");
			ThemeSettings.NativeFieldInfoPtr__buttonSettings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ThemeSettings>.NativeClassPtr, "_buttonSettings");
			ThemeSettings.NativeFieldInfoPtr__inputGridFieldSettings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ThemeSettings>.NativeClassPtr, "_inputGridFieldSettings");
			ThemeSettings.NativeFieldInfoPtr__scrollbarSettings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ThemeSettings>.NativeClassPtr, "_scrollbarSettings");
			ThemeSettings.NativeFieldInfoPtr__sliderSettings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ThemeSettings>.NativeClassPtr, "_sliderSettings");
			ThemeSettings.NativeFieldInfoPtr__invertToggle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ThemeSettings>.NativeClassPtr, "_invertToggle");
			ThemeSettings.NativeFieldInfoPtr__invertToggleDisabledColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ThemeSettings>.NativeClassPtr, "_invertToggleDisabledColor");
			ThemeSettings.NativeFieldInfoPtr__calibrationBackground = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ThemeSettings>.NativeClassPtr, "_calibrationBackground");
			ThemeSettings.NativeFieldInfoPtr__calibrationValueMarker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ThemeSettings>.NativeClassPtr, "_calibrationValueMarker");
			ThemeSettings.NativeFieldInfoPtr__calibrationRawValueMarker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ThemeSettings>.NativeClassPtr, "_calibrationRawValueMarker");
			ThemeSettings.NativeFieldInfoPtr__calibrationZeroMarker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ThemeSettings>.NativeClassPtr, "_calibrationZeroMarker");
			ThemeSettings.NativeFieldInfoPtr__calibrationCalibratedZeroMarker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ThemeSettings>.NativeClassPtr, "_calibrationCalibratedZeroMarker");
			ThemeSettings.NativeFieldInfoPtr__calibrationDeadzone = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ThemeSettings>.NativeClassPtr, "_calibrationDeadzone");
			ThemeSettings.NativeFieldInfoPtr__textSettings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ThemeSettings>.NativeClassPtr, "_textSettings");
			ThemeSettings.NativeFieldInfoPtr__buttonTextSettings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ThemeSettings>.NativeClassPtr, "_buttonTextSettings");
			ThemeSettings.NativeFieldInfoPtr__inputGridFieldTextSettings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ThemeSettings>.NativeClassPtr, "_inputGridFieldTextSettings");
			ThemeSettings.NativeMethodInfoPtr_Apply_Public_Void_Il2CppReferenceArray_1_ElementInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ThemeSettings>.NativeClassPtr, 100669208);
			ThemeSettings.NativeMethodInfoPtr_Apply_Private_Void_String_Component_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ThemeSettings>.NativeClassPtr, 100669209);
			ThemeSettings.NativeMethodInfoPtr_Apply_Private_Void_String_Selectable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ThemeSettings>.NativeClassPtr, 100669210);
			ThemeSettings.NativeMethodInfoPtr_Apply_Private_Void_String_Image_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ThemeSettings>.NativeClassPtr, 100669211);
			ThemeSettings.NativeMethodInfoPtr_Apply_Private_Void_String_Text_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ThemeSettings>.NativeClassPtr, 100669212);
			ThemeSettings.NativeMethodInfoPtr_Apply_Private_Void_String_UIImageHelper_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ThemeSettings>.NativeClassPtr, 100669213);
			ThemeSettings.NativeMethodInfoPtr_GetFontStyle_Private_Static_FontStyle_FontStyleOverride_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ThemeSettings>.NativeClassPtr, 100669214);
			ThemeSettings.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ThemeSettings>.NativeClassPtr, 100669215);
		}

		// Token: 0x06003EAD RID: 16045 RVA: 0x000EAD0C File Offset: 0x000E8F0C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 99367, XrefRangeEnd = 99369, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Apply(Il2CppReferenceArray<ThemedElement.ElementInfo> elementInfo)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(elementInfo);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ThemeSettings.NativeMethodInfoPtr_Apply_Public_Void_Il2CppReferenceArray_1_ElementInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06003EAE RID: 16046 RVA: 0x000EAD50 File Offset: 0x000E8F50
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 99392, RefRangeEnd = 99394, XrefRangeStart = 99369, XrefRangeEnd = 99392, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Apply(string themeClass, Component component)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(themeClass);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(component);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ThemeSettings.NativeMethodInfoPtr_Apply_Private_Void_String_Component_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003EAF RID: 16047 RVA: 0x000EADA4 File Offset: 0x000E8FA4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 99474, RefRangeEnd = 99475, XrefRangeStart = 99394, XrefRangeEnd = 99474, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Apply(string themeClass, Selectable item)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(themeClass);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(item);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ThemeSettings.NativeMethodInfoPtr_Apply_Private_Void_String_Selectable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003EB0 RID: 16048 RVA: 0x000EADF8 File Offset: 0x000E8FF8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 99475, XrefRangeEnd = 99529, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Apply(string themeClass, Image item)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(themeClass);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(item);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ThemeSettings.NativeMethodInfoPtr_Apply_Private_Void_String_Image_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003EB1 RID: 16049 RVA: 0x000EAE4C File Offset: 0x000E904C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 99529, XrefRangeEnd = 99560, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Apply(string themeClass, Text item)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(themeClass);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(item);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ThemeSettings.NativeMethodInfoPtr_Apply_Private_Void_String_Text_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003EB2 RID: 16050 RVA: 0x000EAEA0 File Offset: 0x000E90A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 99560, XrefRangeEnd = 99591, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Apply(string themeClass, UIImageHelper item)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(themeClass);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(item);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ThemeSettings.NativeMethodInfoPtr_Apply_Private_Void_String_UIImageHelper_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003EB3 RID: 16051 RVA: 0x000EAEF4 File Offset: 0x000E90F4
		[CallerCount(0)]
		public unsafe static FontStyle GetFontStyle(ThemeSettings.FontStyleOverride style)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref style;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ThemeSettings.NativeMethodInfoPtr_GetFontStyle_Private_Static_FontStyle_FontStyleOverride_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06003EB4 RID: 16052 RVA: 0x000EAF34 File Offset: 0x000E9134
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ThemeSettings()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ThemeSettings>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ThemeSettings.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003EB5 RID: 16053 RVA: 0x00026962 File Offset: 0x00024B62
		public ThemeSettings(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170017DE RID: 6110
		// (get) Token: 0x06003EB6 RID: 16054 RVA: 0x000EAF70 File Offset: 0x000E9170
		// (set) Token: 0x06003EB7 RID: 16055 RVA: 0x0002696B File Offset: 0x00024B6B
		public unsafe ThemeSettings.ImageSettings _mainWindowBackground
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ThemeSettings.NativeFieldInfoPtr__mainWindowBackground);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ThemeSettings.ImageSettings>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ThemeSettings.NativeFieldInfoPtr__mainWindowBackground), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170017DF RID: 6111
		// (get) Token: 0x06003EB8 RID: 16056 RVA: 0x000EAFA0 File Offset: 0x000E91A0
		// (set) Token: 0x06003EB9 RID: 16057 RVA: 0x0002698A File Offset: 0x00024B8A
		public unsafe ThemeSettings.ImageSettings _popupWindowBackground
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ThemeSettings.NativeFieldInfoPtr__popupWindowBackground);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ThemeSettings.ImageSettings>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ThemeSettings.NativeFieldInfoPtr__popupWindowBackground), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170017E0 RID: 6112
		// (get) Token: 0x06003EBA RID: 16058 RVA: 0x000EAFD0 File Offset: 0x000E91D0
		// (set) Token: 0x06003EBB RID: 16059 RVA: 0x000269A9 File Offset: 0x00024BA9
		public unsafe ThemeSettings.ImageSettings _areaBackground
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ThemeSettings.NativeFieldInfoPtr__areaBackground);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ThemeSettings.ImageSettings>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ThemeSettings.NativeFieldInfoPtr__areaBackground), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170017E1 RID: 6113
		// (get) Token: 0x06003EBC RID: 16060 RVA: 0x000EB000 File Offset: 0x000E9200
		// (set) Token: 0x06003EBD RID: 16061 RVA: 0x000269C8 File Offset: 0x00024BC8
		public unsafe ThemeSettings.SelectableSettings _selectableSettings
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ThemeSettings.NativeFieldInfoPtr__selectableSettings);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ThemeSettings.SelectableSettings>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ThemeSettings.NativeFieldInfoPtr__selectableSettings), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170017E2 RID: 6114
		// (get) Token: 0x06003EBE RID: 16062 RVA: 0x000EB030 File Offset: 0x000E9230
		// (set) Token: 0x06003EBF RID: 16063 RVA: 0x000269E7 File Offset: 0x00024BE7
		public unsafe ThemeSettings.SelectableSettings _buttonSettings
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ThemeSettings.NativeFieldInfoPtr__buttonSettings);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ThemeSettings.SelectableSettings>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ThemeSettings.NativeFieldInfoPtr__buttonSettings), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170017E3 RID: 6115
		// (get) Token: 0x06003EC0 RID: 16064 RVA: 0x000EB060 File Offset: 0x000E9260
		// (set) Token: 0x06003EC1 RID: 16065 RVA: 0x00026A06 File Offset: 0x00024C06
		public unsafe ThemeSettings.SelectableSettings _inputGridFieldSettings
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ThemeSettings.NativeFieldInfoPtr__inputGridFieldSettings);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ThemeSettings.SelectableSettings>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ThemeSettings.NativeFieldInfoPtr__inputGridFieldSettings), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170017E4 RID: 6116
		// (get) Token: 0x06003EC2 RID: 16066 RVA: 0x000EB090 File Offset: 0x000E9290
		// (set) Token: 0x06003EC3 RID: 16067 RVA: 0x00026A25 File Offset: 0x00024C25
		public unsafe ThemeSettings.ScrollbarSettings _scrollbarSettings
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ThemeSettings.NativeFieldInfoPtr__scrollbarSettings);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ThemeSettings.ScrollbarSettings>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ThemeSettings.NativeFieldInfoPtr__scrollbarSettings), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170017E5 RID: 6117
		// (get) Token: 0x06003EC4 RID: 16068 RVA: 0x000EB0C0 File Offset: 0x000E92C0
		// (set) Token: 0x06003EC5 RID: 16069 RVA: 0x00026A44 File Offset: 0x00024C44
		public unsafe ThemeSettings.SliderSettings _sliderSettings
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ThemeSettings.NativeFieldInfoPtr__sliderSettings);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ThemeSettings.SliderSettings>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ThemeSettings.NativeFieldInfoPtr__sliderSettings), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170017E6 RID: 6118
		// (get) Token: 0x06003EC6 RID: 16070 RVA: 0x000EB0F0 File Offset: 0x000E92F0
		// (set) Token: 0x06003EC7 RID: 16071 RVA: 0x00026A63 File Offset: 0x00024C63
		public unsafe ThemeSettings.ImageSettings _invertToggle
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ThemeSettings.NativeFieldInfoPtr__invertToggle);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ThemeSettings.ImageSettings>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ThemeSettings.NativeFieldInfoPtr__invertToggle), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170017E7 RID: 6119
		// (get) Token: 0x06003EC8 RID: 16072 RVA: 0x000EB120 File Offset: 0x000E9320
		// (set) Token: 0x06003EC9 RID: 16073 RVA: 0x00026A82 File Offset: 0x00024C82
		public unsafe Color _invertToggleDisabledColor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ThemeSettings.NativeFieldInfoPtr__invertToggleDisabledColor);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ThemeSettings.NativeFieldInfoPtr__invertToggleDisabledColor)) = value;
			}
		}

		// Token: 0x170017E8 RID: 6120
		// (get) Token: 0x06003ECA RID: 16074 RVA: 0x000EB148 File Offset: 0x000E9348
		// (set) Token: 0x06003ECB RID: 16075 RVA: 0x00026A9D File Offset: 0x00024C9D
		public unsafe ThemeSettings.ImageSettings _calibrationBackground
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ThemeSettings.NativeFieldInfoPtr__calibrationBackground);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ThemeSettings.ImageSettings>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ThemeSettings.NativeFieldInfoPtr__calibrationBackground), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170017E9 RID: 6121
		// (get) Token: 0x06003ECC RID: 16076 RVA: 0x000EB178 File Offset: 0x000E9378
		// (set) Token: 0x06003ECD RID: 16077 RVA: 0x00026ABC File Offset: 0x00024CBC
		public unsafe ThemeSettings.ImageSettings _calibrationValueMarker
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ThemeSettings.NativeFieldInfoPtr__calibrationValueMarker);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ThemeSettings.ImageSettings>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ThemeSettings.NativeFieldInfoPtr__calibrationValueMarker), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170017EA RID: 6122
		// (get) Token: 0x06003ECE RID: 16078 RVA: 0x000EB1A8 File Offset: 0x000E93A8
		// (set) Token: 0x06003ECF RID: 16079 RVA: 0x00026ADB File Offset: 0x00024CDB
		public unsafe ThemeSettings.ImageSettings _calibrationRawValueMarker
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ThemeSettings.NativeFieldInfoPtr__calibrationRawValueMarker);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ThemeSettings.ImageSettings>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ThemeSettings.NativeFieldInfoPtr__calibrationRawValueMarker), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170017EB RID: 6123
		// (get) Token: 0x06003ED0 RID: 16080 RVA: 0x000EB1D8 File Offset: 0x000E93D8
		// (set) Token: 0x06003ED1 RID: 16081 RVA: 0x00026AFA File Offset: 0x00024CFA
		public unsafe ThemeSettings.ImageSettings _calibrationZeroMarker
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ThemeSettings.NativeFieldInfoPtr__calibrationZeroMarker);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ThemeSettings.ImageSettings>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ThemeSettings.NativeFieldInfoPtr__calibrationZeroMarker), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170017EC RID: 6124
		// (get) Token: 0x06003ED2 RID: 16082 RVA: 0x000EB208 File Offset: 0x000E9408
		// (set) Token: 0x06003ED3 RID: 16083 RVA: 0x00026B19 File Offset: 0x00024D19
		public unsafe ThemeSettings.ImageSettings _calibrationCalibratedZeroMarker
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ThemeSettings.NativeFieldInfoPtr__calibrationCalibratedZeroMarker);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ThemeSettings.ImageSettings>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ThemeSettings.NativeFieldInfoPtr__calibrationCalibratedZeroMarker), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170017ED RID: 6125
		// (get) Token: 0x06003ED4 RID: 16084 RVA: 0x000EB238 File Offset: 0x000E9438
		// (set) Token: 0x06003ED5 RID: 16085 RVA: 0x00026B38 File Offset: 0x00024D38
		public unsafe ThemeSettings.ImageSettings _calibrationDeadzone
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ThemeSettings.NativeFieldInfoPtr__calibrationDeadzone);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ThemeSettings.ImageSettings>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ThemeSettings.NativeFieldInfoPtr__calibrationDeadzone), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170017EE RID: 6126
		// (get) Token: 0x06003ED6 RID: 16086 RVA: 0x000EB268 File Offset: 0x000E9468
		// (set) Token: 0x06003ED7 RID: 16087 RVA: 0x00026B57 File Offset: 0x00024D57
		public unsafe ThemeSettings.TextSettings _textSettings
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ThemeSettings.NativeFieldInfoPtr__textSettings);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ThemeSettings.TextSettings>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ThemeSettings.NativeFieldInfoPtr__textSettings), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170017EF RID: 6127
		// (get) Token: 0x06003ED8 RID: 16088 RVA: 0x000EB298 File Offset: 0x000E9498
		// (set) Token: 0x06003ED9 RID: 16089 RVA: 0x00026B76 File Offset: 0x00024D76
		public unsafe ThemeSettings.TextSettings _buttonTextSettings
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ThemeSettings.NativeFieldInfoPtr__buttonTextSettings);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ThemeSettings.TextSettings>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ThemeSettings.NativeFieldInfoPtr__buttonTextSettings), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170017F0 RID: 6128
		// (get) Token: 0x06003EDA RID: 16090 RVA: 0x000EB2C8 File Offset: 0x000E94C8
		// (set) Token: 0x06003EDB RID: 16091 RVA: 0x00026B95 File Offset: 0x00024D95
		public unsafe ThemeSettings.TextSettings _inputGridFieldTextSettings
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ThemeSettings.NativeFieldInfoPtr__inputGridFieldTextSettings);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ThemeSettings.TextSettings>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ThemeSettings.NativeFieldInfoPtr__inputGridFieldTextSettings), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04002661 RID: 9825
		private static readonly IntPtr NativeFieldInfoPtr__mainWindowBackground;

		// Token: 0x04002662 RID: 9826
		private static readonly IntPtr NativeFieldInfoPtr__popupWindowBackground;

		// Token: 0x04002663 RID: 9827
		private static readonly IntPtr NativeFieldInfoPtr__areaBackground;

		// Token: 0x04002664 RID: 9828
		private static readonly IntPtr NativeFieldInfoPtr__selectableSettings;

		// Token: 0x04002665 RID: 9829
		private static readonly IntPtr NativeFieldInfoPtr__buttonSettings;

		// Token: 0x04002666 RID: 9830
		private static readonly IntPtr NativeFieldInfoPtr__inputGridFieldSettings;

		// Token: 0x04002667 RID: 9831
		private static readonly IntPtr NativeFieldInfoPtr__scrollbarSettings;

		// Token: 0x04002668 RID: 9832
		private static readonly IntPtr NativeFieldInfoPtr__sliderSettings;

		// Token: 0x04002669 RID: 9833
		private static readonly IntPtr NativeFieldInfoPtr__invertToggle;

		// Token: 0x0400266A RID: 9834
		private static readonly IntPtr NativeFieldInfoPtr__invertToggleDisabledColor;

		// Token: 0x0400266B RID: 9835
		private static readonly IntPtr NativeFieldInfoPtr__calibrationBackground;

		// Token: 0x0400266C RID: 9836
		private static readonly IntPtr NativeFieldInfoPtr__calibrationValueMarker;

		// Token: 0x0400266D RID: 9837
		private static readonly IntPtr NativeFieldInfoPtr__calibrationRawValueMarker;

		// Token: 0x0400266E RID: 9838
		private static readonly IntPtr NativeFieldInfoPtr__calibrationZeroMarker;

		// Token: 0x0400266F RID: 9839
		private static readonly IntPtr NativeFieldInfoPtr__calibrationCalibratedZeroMarker;

		// Token: 0x04002670 RID: 9840
		private static readonly IntPtr NativeFieldInfoPtr__calibrationDeadzone;

		// Token: 0x04002671 RID: 9841
		private static readonly IntPtr NativeFieldInfoPtr__textSettings;

		// Token: 0x04002672 RID: 9842
		private static readonly IntPtr NativeFieldInfoPtr__buttonTextSettings;

		// Token: 0x04002673 RID: 9843
		private static readonly IntPtr NativeFieldInfoPtr__inputGridFieldTextSettings;

		// Token: 0x04002674 RID: 9844
		private static readonly IntPtr NativeMethodInfoPtr_Apply_Public_Void_Il2CppReferenceArray_1_ElementInfo_0;

		// Token: 0x04002675 RID: 9845
		private static readonly IntPtr NativeMethodInfoPtr_Apply_Private_Void_String_Component_0;

		// Token: 0x04002676 RID: 9846
		private static readonly IntPtr NativeMethodInfoPtr_Apply_Private_Void_String_Selectable_0;

		// Token: 0x04002677 RID: 9847
		private static readonly IntPtr NativeMethodInfoPtr_Apply_Private_Void_String_Image_0;

		// Token: 0x04002678 RID: 9848
		private static readonly IntPtr NativeMethodInfoPtr_Apply_Private_Void_String_Text_0;

		// Token: 0x04002679 RID: 9849
		private static readonly IntPtr NativeMethodInfoPtr_Apply_Private_Void_String_UIImageHelper_0;

		// Token: 0x0400267A RID: 9850
		private static readonly IntPtr NativeMethodInfoPtr_GetFontStyle_Private_Static_FontStyle_FontStyleOverride_0;

		// Token: 0x0400267B RID: 9851
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000389 RID: 905
		[Serializable]
		public class SelectableSettings_Base : global::Il2CppSystem.Object
		{
			// Token: 0x06005769 RID: 22377 RVA: 0x0013D2EC File Offset: 0x0013B4EC
			// Note: this type is marked as 'beforefieldinit'.
			static SelectableSettings_Base()
			{
				Il2CppClassPointerStore<ThemeSettings.SelectableSettings_Base>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ThemeSettings>.NativeClassPtr, "SelectableSettings_Base");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ThemeSettings.SelectableSettings_Base>.NativeClassPtr);
				ThemeSettings.SelectableSettings_Base.NativeFieldInfoPtr__transition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ThemeSettings.SelectableSettings_Base>.NativeClassPtr, "_transition");
				ThemeSettings.SelectableSettings_Base.NativeFieldInfoPtr__colors = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ThemeSettings.SelectableSettings_Base>.NativeClassPtr, "_colors");
				ThemeSettings.SelectableSettings_Base.NativeFieldInfoPtr__spriteState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ThemeSettings.SelectableSettings_Base>.NativeClassPtr, "_spriteState");
				ThemeSettings.SelectableSettings_Base.NativeFieldInfoPtr__animationTriggers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ThemeSettings.SelectableSettings_Base>.NativeClassPtr, "_animationTriggers");
				ThemeSettings.SelectableSettings_Base.NativeMethodInfoPtr_get_transition_Public_get_Transition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ThemeSettings.SelectableSettings_Base>.NativeClassPtr, 100669216);
				ThemeSettings.SelectableSettings_Base.NativeMethodInfoPtr_get_selectableColors_Public_get_CustomColorBlock_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ThemeSettings.SelectableSettings_Base>.NativeClassPtr, 100669217);
				ThemeSettings.SelectableSettings_Base.NativeMethodInfoPtr_get_spriteState_Public_get_CustomSpriteState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ThemeSettings.SelectableSettings_Base>.NativeClassPtr, 100669218);
				ThemeSettings.SelectableSettings_Base.NativeMethodInfoPtr_get_animationTriggers_Public_get_CustomAnimationTriggers_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ThemeSettings.SelectableSettings_Base>.NativeClassPtr, 100669219);
				ThemeSettings.SelectableSettings_Base.NativeMethodInfoPtr_Apply_Public_Virtual_New_Void_Selectable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ThemeSettings.SelectableSettings_Base>.NativeClassPtr, 100669220);
				ThemeSettings.SelectableSettings_Base.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ThemeSettings.SelectableSettings_Base>.NativeClassPtr, 100669221);
			}

			// Token: 0x17001FEB RID: 8171
			// (get) Token: 0x0600576A RID: 22378 RVA: 0x0013D3E0 File Offset: 0x0013B5E0
			public unsafe Selectable.Transition transition
			{
				[CallerCount(1)]
				[CachedScanResults(RefRangeStart = 896, RefRangeEnd = 897, XrefRangeStart = 896, XrefRangeEnd = 897, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ThemeSettings.SelectableSettings_Base.NativeMethodInfoPtr_get_transition_Public_get_Transition_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x17001FEC RID: 8172
			// (get) Token: 0x0600576B RID: 22379 RVA: 0x0013D41C File Offset: 0x0013B61C
			public unsafe ThemeSettings.CustomColorBlock selectableColors
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ThemeSettings.SelectableSettings_Base.NativeMethodInfoPtr_get_selectableColors_Public_get_CustomColorBlock_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x17001FED RID: 8173
			// (get) Token: 0x0600576C RID: 22380 RVA: 0x0013D458 File Offset: 0x0013B658
			public unsafe ThemeSettings.CustomSpriteState spriteState
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ThemeSettings.SelectableSettings_Base.NativeMethodInfoPtr_get_spriteState_Public_get_CustomSpriteState_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return new ThemeSettings.CustomSpriteState(intPtr);
				}
			}

			// Token: 0x17001FEE RID: 8174
			// (get) Token: 0x0600576D RID: 22381 RVA: 0x0013D490 File Offset: 0x0013B690
			public unsafe ThemeSettings.CustomAnimationTriggers animationTriggers
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ThemeSettings.SelectableSettings_Base.NativeMethodInfoPtr_get_animationTriggers_Public_get_CustomAnimationTriggers_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<ThemeSettings.CustomAnimationTriggers>(intPtr3) : null;
				}
			}

			// Token: 0x0600576E RID: 22382 RVA: 0x0013D4D0 File Offset: 0x0013B6D0
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 99199, RefRangeEnd = 99202, XrefRangeStart = 99174, XrefRangeEnd = 99199, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe virtual void Apply(Selectable item)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(item);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ThemeSettings.SelectableSettings_Base.NativeMethodInfoPtr_Apply_Public_Virtual_New_Void_Selectable_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x0600576F RID: 22383 RVA: 0x0013D520 File Offset: 0x0013B720
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe SelectableSettings_Base()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ThemeSettings.SelectableSettings_Base>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ThemeSettings.SelectableSettings_Base.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06005770 RID: 22384 RVA: 0x000324C6 File Offset: 0x000306C6
			public SelectableSettings_Base(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001FE7 RID: 8167
			// (get) Token: 0x06005771 RID: 22385 RVA: 0x0013D55C File Offset: 0x0013B75C
			// (set) Token: 0x06005772 RID: 22386 RVA: 0x000324CF File Offset: 0x000306CF
			public unsafe Selectable.Transition _transition
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ThemeSettings.SelectableSettings_Base.NativeFieldInfoPtr__transition);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ThemeSettings.SelectableSettings_Base.NativeFieldInfoPtr__transition)) = value;
				}
			}

			// Token: 0x17001FE8 RID: 8168
			// (get) Token: 0x06005773 RID: 22387 RVA: 0x0013D584 File Offset: 0x0013B784
			// (set) Token: 0x06005774 RID: 22388 RVA: 0x000324EA File Offset: 0x000306EA
			public unsafe ThemeSettings.CustomColorBlock _colors
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ThemeSettings.SelectableSettings_Base.NativeFieldInfoPtr__colors);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ThemeSettings.SelectableSettings_Base.NativeFieldInfoPtr__colors)) = value;
				}
			}

			// Token: 0x17001FE9 RID: 8169
			// (get) Token: 0x06005775 RID: 22389 RVA: 0x0013D5AC File Offset: 0x0013B7AC
			// (set) Token: 0x06005776 RID: 22390 RVA: 0x00032505 File Offset: 0x00030705
			public ThemeSettings.CustomSpriteState _spriteState
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ThemeSettings.SelectableSettings_Base.NativeFieldInfoPtr__spriteState);
					return new ThemeSettings.CustomSpriteState(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ThemeSettings.CustomSpriteState>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ThemeSettings.SelectableSettings_Base.NativeFieldInfoPtr__spriteState), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ThemeSettings.CustomSpriteState>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17001FEA RID: 8170
			// (get) Token: 0x06005777 RID: 22391 RVA: 0x0013D5DC File Offset: 0x0013B7DC
			// (set) Token: 0x06005778 RID: 22392 RVA: 0x00032533 File Offset: 0x00030733
			public unsafe ThemeSettings.CustomAnimationTriggers _animationTriggers
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ThemeSettings.SelectableSettings_Base.NativeFieldInfoPtr__animationTriggers);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ThemeSettings.CustomAnimationTriggers>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ThemeSettings.SelectableSettings_Base.NativeFieldInfoPtr__animationTriggers), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040039F4 RID: 14836
			private static readonly IntPtr NativeFieldInfoPtr__transition;

			// Token: 0x040039F5 RID: 14837
			private static readonly IntPtr NativeFieldInfoPtr__colors;

			// Token: 0x040039F6 RID: 14838
			private static readonly IntPtr NativeFieldInfoPtr__spriteState;

			// Token: 0x040039F7 RID: 14839
			private static readonly IntPtr NativeFieldInfoPtr__animationTriggers;

			// Token: 0x040039F8 RID: 14840
			private static readonly IntPtr NativeMethodInfoPtr_get_transition_Public_get_Transition_0;

			// Token: 0x040039F9 RID: 14841
			private static readonly IntPtr NativeMethodInfoPtr_get_selectableColors_Public_get_CustomColorBlock_0;

			// Token: 0x040039FA RID: 14842
			private static readonly IntPtr NativeMethodInfoPtr_get_spriteState_Public_get_CustomSpriteState_0;

			// Token: 0x040039FB RID: 14843
			private static readonly IntPtr NativeMethodInfoPtr_get_animationTriggers_Public_get_CustomAnimationTriggers_0;

			// Token: 0x040039FC RID: 14844
			private static readonly IntPtr NativeMethodInfoPtr_Apply_Public_Virtual_New_Void_Selectable_0;

			// Token: 0x040039FD RID: 14845
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;
		}

		// Token: 0x0200038A RID: 906
		[Serializable]
		public class SelectableSettings : ThemeSettings.SelectableSettings_Base
		{
			// Token: 0x06005779 RID: 22393 RVA: 0x0013D60C File Offset: 0x0013B80C
			// Note: this type is marked as 'beforefieldinit'.
			static SelectableSettings()
			{
				Il2CppClassPointerStore<ThemeSettings.SelectableSettings>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ThemeSettings>.NativeClassPtr, "SelectableSettings");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ThemeSettings.SelectableSettings>.NativeClassPtr);
				ThemeSettings.SelectableSettings.NativeFieldInfoPtr__imageSettings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ThemeSettings.SelectableSettings>.NativeClassPtr, "_imageSettings");
				ThemeSettings.SelectableSettings.NativeMethodInfoPtr_get_imageSettings_Public_get_ImageSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ThemeSettings.SelectableSettings>.NativeClassPtr, 100669222);
				ThemeSettings.SelectableSettings.NativeMethodInfoPtr_Apply_Public_Virtual_Void_Selectable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ThemeSettings.SelectableSettings>.NativeClassPtr, 100669223);
				ThemeSettings.SelectableSettings.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ThemeSettings.SelectableSettings>.NativeClassPtr, 100669224);
			}

			// Token: 0x17001FF0 RID: 8176
			// (get) Token: 0x0600577A RID: 22394 RVA: 0x0013D688 File Offset: 0x0013B888
			public unsafe ThemeSettings.ImageSettings imageSettings
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ThemeSettings.SelectableSettings.NativeMethodInfoPtr_get_imageSettings_Public_get_ImageSettings_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<ThemeSettings.ImageSettings>(intPtr3) : null;
				}
			}

			// Token: 0x0600577B RID: 22395 RVA: 0x0013D6C8 File Offset: 0x0013B8C8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 99202, XrefRangeEnd = 99219, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override void Apply(Selectable item)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(item);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ThemeSettings.SelectableSettings.NativeMethodInfoPtr_Apply_Public_Virtual_Void_Selectable_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x0600577C RID: 22396 RVA: 0x0013D718 File Offset: 0x0013B918
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe SelectableSettings()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ThemeSettings.SelectableSettings>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ThemeSettings.SelectableSettings.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600577D RID: 22397 RVA: 0x00032552 File Offset: 0x00030752
			public SelectableSettings(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001FEF RID: 8175
			// (get) Token: 0x0600577E RID: 22398 RVA: 0x0013D754 File Offset: 0x0013B954
			// (set) Token: 0x0600577F RID: 22399 RVA: 0x0003255B File Offset: 0x0003075B
			public unsafe ThemeSettings.ImageSettings _imageSettings
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ThemeSettings.SelectableSettings.NativeFieldInfoPtr__imageSettings);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ThemeSettings.ImageSettings>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ThemeSettings.SelectableSettings.NativeFieldInfoPtr__imageSettings), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040039FE RID: 14846
			private static readonly IntPtr NativeFieldInfoPtr__imageSettings;

			// Token: 0x040039FF RID: 14847
			private static readonly IntPtr NativeMethodInfoPtr_get_imageSettings_Public_get_ImageSettings_0;

			// Token: 0x04003A00 RID: 14848
			private static readonly IntPtr NativeMethodInfoPtr_Apply_Public_Virtual_Void_Selectable_0;

			// Token: 0x04003A01 RID: 14849
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x0200038B RID: 907
		[Serializable]
		public class SliderSettings : ThemeSettings.SelectableSettings_Base
		{
			// Token: 0x06005780 RID: 22400 RVA: 0x0013D784 File Offset: 0x0013B984
			// Note: this type is marked as 'beforefieldinit'.
			static SliderSettings()
			{
				Il2CppClassPointerStore<ThemeSettings.SliderSettings>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ThemeSettings>.NativeClassPtr, "SliderSettings");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ThemeSettings.SliderSettings>.NativeClassPtr);
				ThemeSettings.SliderSettings.NativeFieldInfoPtr__handleImageSettings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ThemeSettings.SliderSettings>.NativeClassPtr, "_handleImageSettings");
				ThemeSettings.SliderSettings.NativeFieldInfoPtr__fillImageSettings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ThemeSettings.SliderSettings>.NativeClassPtr, "_fillImageSettings");
				ThemeSettings.SliderSettings.NativeFieldInfoPtr__backgroundImageSettings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ThemeSettings.SliderSettings>.NativeClassPtr, "_backgroundImageSettings");
				ThemeSettings.SliderSettings.NativeMethodInfoPtr_get_handleImageSettings_Public_get_ImageSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ThemeSettings.SliderSettings>.NativeClassPtr, 100669225);
				ThemeSettings.SliderSettings.NativeMethodInfoPtr_get_fillImageSettings_Public_get_ImageSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ThemeSettings.SliderSettings>.NativeClassPtr, 100669226);
				ThemeSettings.SliderSettings.NativeMethodInfoPtr_get_backgroundImageSettings_Public_get_ImageSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ThemeSettings.SliderSettings>.NativeClassPtr, 100669227);
				ThemeSettings.SliderSettings.NativeMethodInfoPtr_Apply_Private_Void_Slider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ThemeSettings.SliderSettings>.NativeClassPtr, 100669228);
				ThemeSettings.SliderSettings.NativeMethodInfoPtr_Apply_Public_Virtual_Void_Selectable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ThemeSettings.SliderSettings>.NativeClassPtr, 100669229);
				ThemeSettings.SliderSettings.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ThemeSettings.SliderSettings>.NativeClassPtr, 100669230);
			}

			// Token: 0x17001FF4 RID: 8180
			// (get) Token: 0x06005781 RID: 22401 RVA: 0x0013D864 File Offset: 0x0013BA64
			public unsafe ThemeSettings.ImageSettings handleImageSettings
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ThemeSettings.SliderSettings.NativeMethodInfoPtr_get_handleImageSettings_Public_get_ImageSettings_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<ThemeSettings.ImageSettings>(intPtr3) : null;
				}
			}

			// Token: 0x17001FF5 RID: 8181
			// (get) Token: 0x06005782 RID: 22402 RVA: 0x0013D8A4 File Offset: 0x0013BAA4
			public unsafe ThemeSettings.ImageSettings fillImageSettings
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ThemeSettings.SliderSettings.NativeMethodInfoPtr_get_fillImageSettings_Public_get_ImageSettings_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<ThemeSettings.ImageSettings>(intPtr3) : null;
				}
			}

			// Token: 0x17001FF6 RID: 8182
			// (get) Token: 0x06005783 RID: 22403 RVA: 0x0013D8E4 File Offset: 0x0013BAE4
			public unsafe ThemeSettings.ImageSettings backgroundImageSettings
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ThemeSettings.SliderSettings.NativeMethodInfoPtr_get_backgroundImageSettings_Public_get_ImageSettings_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<ThemeSettings.ImageSettings>(intPtr3) : null;
				}
			}

			// Token: 0x06005784 RID: 22404 RVA: 0x0013D924 File Offset: 0x0013BB24
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 99270, RefRangeEnd = 99271, XrefRangeStart = 99219, XrefRangeEnd = 99270, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Apply(Slider item)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(item);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ThemeSettings.SliderSettings.NativeMethodInfoPtr_Apply_Private_Void_Slider_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06005785 RID: 22405 RVA: 0x0013D968 File Offset: 0x0013BB68
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 99271, XrefRangeEnd = 99277, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override void Apply(Selectable item)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(item);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ThemeSettings.SliderSettings.NativeMethodInfoPtr_Apply_Public_Virtual_Void_Selectable_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06005786 RID: 22406 RVA: 0x0013D9B8 File Offset: 0x0013BBB8
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe SliderSettings()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ThemeSettings.SliderSettings>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ThemeSettings.SliderSettings.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06005787 RID: 22407 RVA: 0x0003257A File Offset: 0x0003077A
			public SliderSettings(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001FF1 RID: 8177
			// (get) Token: 0x06005788 RID: 22408 RVA: 0x0013D9F4 File Offset: 0x0013BBF4
			// (set) Token: 0x06005789 RID: 22409 RVA: 0x00032583 File Offset: 0x00030783
			public unsafe ThemeSettings.ImageSettings _handleImageSettings
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ThemeSettings.SliderSettings.NativeFieldInfoPtr__handleImageSettings);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ThemeSettings.ImageSettings>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ThemeSettings.SliderSettings.NativeFieldInfoPtr__handleImageSettings), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001FF2 RID: 8178
			// (get) Token: 0x0600578A RID: 22410 RVA: 0x0013DA24 File Offset: 0x0013BC24
			// (set) Token: 0x0600578B RID: 22411 RVA: 0x000325A2 File Offset: 0x000307A2
			public unsafe ThemeSettings.ImageSettings _fillImageSettings
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ThemeSettings.SliderSettings.NativeFieldInfoPtr__fillImageSettings);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ThemeSettings.ImageSettings>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ThemeSettings.SliderSettings.NativeFieldInfoPtr__fillImageSettings), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001FF3 RID: 8179
			// (get) Token: 0x0600578C RID: 22412 RVA: 0x0013DA54 File Offset: 0x0013BC54
			// (set) Token: 0x0600578D RID: 22413 RVA: 0x000325C1 File Offset: 0x000307C1
			public unsafe ThemeSettings.ImageSettings _backgroundImageSettings
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ThemeSettings.SliderSettings.NativeFieldInfoPtr__backgroundImageSettings);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ThemeSettings.ImageSettings>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ThemeSettings.SliderSettings.NativeFieldInfoPtr__backgroundImageSettings), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04003A02 RID: 14850
			private static readonly IntPtr NativeFieldInfoPtr__handleImageSettings;

			// Token: 0x04003A03 RID: 14851
			private static readonly IntPtr NativeFieldInfoPtr__fillImageSettings;

			// Token: 0x04003A04 RID: 14852
			private static readonly IntPtr NativeFieldInfoPtr__backgroundImageSettings;

			// Token: 0x04003A05 RID: 14853
			private static readonly IntPtr NativeMethodInfoPtr_get_handleImageSettings_Public_get_ImageSettings_0;

			// Token: 0x04003A06 RID: 14854
			private static readonly IntPtr NativeMethodInfoPtr_get_fillImageSettings_Public_get_ImageSettings_0;

			// Token: 0x04003A07 RID: 14855
			private static readonly IntPtr NativeMethodInfoPtr_get_backgroundImageSettings_Public_get_ImageSettings_0;

			// Token: 0x04003A08 RID: 14856
			private static readonly IntPtr NativeMethodInfoPtr_Apply_Private_Void_Slider_0;

			// Token: 0x04003A09 RID: 14857
			private static readonly IntPtr NativeMethodInfoPtr_Apply_Public_Virtual_Void_Selectable_0;

			// Token: 0x04003A0A RID: 14858
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x0200038C RID: 908
		[Serializable]
		public class ScrollbarSettings : ThemeSettings.SelectableSettings_Base
		{
			// Token: 0x0600578E RID: 22414 RVA: 0x0013DA84 File Offset: 0x0013BC84
			// Note: this type is marked as 'beforefieldinit'.
			static ScrollbarSettings()
			{
				Il2CppClassPointerStore<ThemeSettings.ScrollbarSettings>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ThemeSettings>.NativeClassPtr, "ScrollbarSettings");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ThemeSettings.ScrollbarSettings>.NativeClassPtr);
				ThemeSettings.ScrollbarSettings.NativeFieldInfoPtr__handleImageSettings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ThemeSettings.ScrollbarSettings>.NativeClassPtr, "_handleImageSettings");
				ThemeSettings.ScrollbarSettings.NativeFieldInfoPtr__backgroundImageSettings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ThemeSettings.ScrollbarSettings>.NativeClassPtr, "_backgroundImageSettings");
				ThemeSettings.ScrollbarSettings.NativeMethodInfoPtr_get_handle_Public_get_ImageSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ThemeSettings.ScrollbarSettings>.NativeClassPtr, 100669231);
				ThemeSettings.ScrollbarSettings.NativeMethodInfoPtr_get_background_Public_get_ImageSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ThemeSettings.ScrollbarSettings>.NativeClassPtr, 100669232);
				ThemeSettings.ScrollbarSettings.NativeMethodInfoPtr_Apply_Private_Void_Scrollbar_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ThemeSettings.ScrollbarSettings>.NativeClassPtr, 100669233);
				ThemeSettings.ScrollbarSettings.NativeMethodInfoPtr_Apply_Public_Virtual_Void_Selectable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ThemeSettings.ScrollbarSettings>.NativeClassPtr, 100669234);
				ThemeSettings.ScrollbarSettings.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ThemeSettings.ScrollbarSettings>.NativeClassPtr, 100669235);
			}

			// Token: 0x17001FF9 RID: 8185
			// (get) Token: 0x0600578F RID: 22415 RVA: 0x0013DB3C File Offset: 0x0013BD3C
			public unsafe ThemeSettings.ImageSettings handle
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ThemeSettings.ScrollbarSettings.NativeMethodInfoPtr_get_handle_Public_get_ImageSettings_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<ThemeSettings.ImageSettings>(intPtr3) : null;
				}
			}

			// Token: 0x17001FFA RID: 8186
			// (get) Token: 0x06005790 RID: 22416 RVA: 0x0013DB7C File Offset: 0x0013BD7C
			public unsafe ThemeSettings.ImageSettings background
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ThemeSettings.ScrollbarSettings.NativeMethodInfoPtr_get_background_Public_get_ImageSettings_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<ThemeSettings.ImageSettings>(intPtr3) : null;
				}
			}

			// Token: 0x06005791 RID: 22417 RVA: 0x0013DBBC File Offset: 0x0013BDBC
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 99296, RefRangeEnd = 99297, XrefRangeStart = 99277, XrefRangeEnd = 99296, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Apply(Scrollbar item)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(item);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ThemeSettings.ScrollbarSettings.NativeMethodInfoPtr_Apply_Private_Void_Scrollbar_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06005792 RID: 22418 RVA: 0x0013DC00 File Offset: 0x0013BE00
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 99297, XrefRangeEnd = 99303, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override void Apply(Selectable item)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(item);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ThemeSettings.ScrollbarSettings.NativeMethodInfoPtr_Apply_Public_Virtual_Void_Selectable_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06005793 RID: 22419 RVA: 0x0013DC50 File Offset: 0x0013BE50
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ScrollbarSettings()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ThemeSettings.ScrollbarSettings>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ThemeSettings.ScrollbarSettings.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06005794 RID: 22420 RVA: 0x000325E0 File Offset: 0x000307E0
			public ScrollbarSettings(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001FF7 RID: 8183
			// (get) Token: 0x06005795 RID: 22421 RVA: 0x0013DC8C File Offset: 0x0013BE8C
			// (set) Token: 0x06005796 RID: 22422 RVA: 0x000325E9 File Offset: 0x000307E9
			public unsafe ThemeSettings.ImageSettings _handleImageSettings
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ThemeSettings.ScrollbarSettings.NativeFieldInfoPtr__handleImageSettings);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ThemeSettings.ImageSettings>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ThemeSettings.ScrollbarSettings.NativeFieldInfoPtr__handleImageSettings), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001FF8 RID: 8184
			// (get) Token: 0x06005797 RID: 22423 RVA: 0x0013DCBC File Offset: 0x0013BEBC
			// (set) Token: 0x06005798 RID: 22424 RVA: 0x00032608 File Offset: 0x00030808
			public unsafe ThemeSettings.ImageSettings _backgroundImageSettings
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ThemeSettings.ScrollbarSettings.NativeFieldInfoPtr__backgroundImageSettings);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ThemeSettings.ImageSettings>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ThemeSettings.ScrollbarSettings.NativeFieldInfoPtr__backgroundImageSettings), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04003A0B RID: 14859
			private static readonly IntPtr NativeFieldInfoPtr__handleImageSettings;

			// Token: 0x04003A0C RID: 14860
			private static readonly IntPtr NativeFieldInfoPtr__backgroundImageSettings;

			// Token: 0x04003A0D RID: 14861
			private static readonly IntPtr NativeMethodInfoPtr_get_handle_Public_get_ImageSettings_0;

			// Token: 0x04003A0E RID: 14862
			private static readonly IntPtr NativeMethodInfoPtr_get_background_Public_get_ImageSettings_0;

			// Token: 0x04003A0F RID: 14863
			private static readonly IntPtr NativeMethodInfoPtr_Apply_Private_Void_Scrollbar_0;

			// Token: 0x04003A10 RID: 14864
			private static readonly IntPtr NativeMethodInfoPtr_Apply_Public_Virtual_Void_Selectable_0;

			// Token: 0x04003A11 RID: 14865
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x0200038D RID: 909
		[Serializable]
		public class ImageSettings : global::Il2CppSystem.Object
		{
			// Token: 0x06005799 RID: 22425 RVA: 0x0013DCEC File Offset: 0x0013BEEC
			// Note: this type is marked as 'beforefieldinit'.
			static ImageSettings()
			{
				Il2CppClassPointerStore<ThemeSettings.ImageSettings>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ThemeSettings>.NativeClassPtr, "ImageSettings");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ThemeSettings.ImageSettings>.NativeClassPtr);
				ThemeSettings.ImageSettings.NativeFieldInfoPtr__color = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ThemeSettings.ImageSettings>.NativeClassPtr, "_color");
				ThemeSettings.ImageSettings.NativeFieldInfoPtr__sprite = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ThemeSettings.ImageSettings>.NativeClassPtr, "_sprite");
				ThemeSettings.ImageSettings.NativeFieldInfoPtr__materal = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ThemeSettings.ImageSettings>.NativeClassPtr, "_materal");
				ThemeSettings.ImageSettings.NativeFieldInfoPtr__type = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ThemeSettings.ImageSettings>.NativeClassPtr, "_type");
				ThemeSettings.ImageSettings.NativeFieldInfoPtr__preserveAspect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ThemeSettings.ImageSettings>.NativeClassPtr, "_preserveAspect");
				ThemeSettings.ImageSettings.NativeFieldInfoPtr__fillCenter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ThemeSettings.ImageSettings>.NativeClassPtr, "_fillCenter");
				ThemeSettings.ImageSettings.NativeFieldInfoPtr__fillMethod = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ThemeSettings.ImageSettings>.NativeClassPtr, "_fillMethod");
				ThemeSettings.ImageSettings.NativeFieldInfoPtr__fillAmout = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ThemeSettings.ImageSettings>.NativeClassPtr, "_fillAmout");
				ThemeSettings.ImageSettings.NativeFieldInfoPtr__fillClockwise = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ThemeSettings.ImageSettings>.NativeClassPtr, "_fillClockwise");
				ThemeSettings.ImageSettings.NativeFieldInfoPtr__fillOrigin = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ThemeSettings.ImageSettings>.NativeClassPtr, "_fillOrigin");
				ThemeSettings.ImageSettings.NativeMethodInfoPtr_get_color_Public_get_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ThemeSettings.ImageSettings>.NativeClassPtr, 100669236);
				ThemeSettings.ImageSettings.NativeMethodInfoPtr_get_sprite_Public_get_Sprite_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ThemeSettings.ImageSettings>.NativeClassPtr, 100669237);
				ThemeSettings.ImageSettings.NativeMethodInfoPtr_get_materal_Public_get_Material_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ThemeSettings.ImageSettings>.NativeClassPtr, 100669238);
				ThemeSettings.ImageSettings.NativeMethodInfoPtr_get_type_Public_get_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ThemeSettings.ImageSettings>.NativeClassPtr, 100669239);
				ThemeSettings.ImageSettings.NativeMethodInfoPtr_get_preserveAspect_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ThemeSettings.ImageSettings>.NativeClassPtr, 100669240);
				ThemeSettings.ImageSettings.NativeMethodInfoPtr_get_fillCenter_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ThemeSettings.ImageSettings>.NativeClassPtr, 100669241);
				ThemeSettings.ImageSettings.NativeMethodInfoPtr_get_fillMethod_Public_get_FillMethod_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ThemeSettings.ImageSettings>.NativeClassPtr, 100669242);
				ThemeSettings.ImageSettings.NativeMethodInfoPtr_get_fillAmout_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ThemeSettings.ImageSettings>.NativeClassPtr, 100669243);
				ThemeSettings.ImageSettings.NativeMethodInfoPtr_get_fillClockwise_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ThemeSettings.ImageSettings>.NativeClassPtr, 100669244);
				ThemeSettings.ImageSettings.NativeMethodInfoPtr_get_fillOrigin_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ThemeSettings.ImageSettings>.NativeClassPtr, 100669245);
				ThemeSettings.ImageSettings.NativeMethodInfoPtr_CopyTo_Public_Virtual_New_Void_Image_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ThemeSettings.ImageSettings>.NativeClassPtr, 100669246);
				ThemeSettings.ImageSettings.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ThemeSettings.ImageSettings>.NativeClassPtr, 100669247);
			}

			// Token: 0x17002005 RID: 8197
			// (get) Token: 0x0600579A RID: 22426 RVA: 0x0013DED0 File Offset: 0x0013C0D0
			public unsafe Color color
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ThemeSettings.ImageSettings.NativeMethodInfoPtr_get_color_Public_get_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x17002006 RID: 8198
			// (get) Token: 0x0600579B RID: 22427 RVA: 0x0013DF0C File Offset: 0x0013C10C
			public unsafe Sprite sprite
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ThemeSettings.ImageSettings.NativeMethodInfoPtr_get_sprite_Public_get_Sprite_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Sprite>(intPtr3) : null;
				}
			}

			// Token: 0x17002007 RID: 8199
			// (get) Token: 0x0600579C RID: 22428 RVA: 0x0013DF4C File Offset: 0x0013C14C
			public unsafe Material materal
			{
				[CallerCount(3)]
				[CachedScanResults(RefRangeStart = 13519, RefRangeEnd = 13522, XrefRangeStart = 13519, XrefRangeEnd = 13522, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ThemeSettings.ImageSettings.NativeMethodInfoPtr_get_materal_Public_get_Material_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Material>(intPtr3) : null;
				}
			}

			// Token: 0x17002008 RID: 8200
			// (get) Token: 0x0600579D RID: 22429 RVA: 0x0013DF8C File Offset: 0x0013C18C
			public unsafe Image.Type type
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ThemeSettings.ImageSettings.NativeMethodInfoPtr_get_type_Public_get_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x17002009 RID: 8201
			// (get) Token: 0x0600579E RID: 22430 RVA: 0x0013DFC8 File Offset: 0x0013C1C8
			public unsafe bool preserveAspect
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ThemeSettings.ImageSettings.NativeMethodInfoPtr_get_preserveAspect_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x1700200A RID: 8202
			// (get) Token: 0x0600579F RID: 22431 RVA: 0x0013E004 File Offset: 0x0013C204
			public unsafe bool fillCenter
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ThemeSettings.ImageSettings.NativeMethodInfoPtr_get_fillCenter_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x1700200B RID: 8203
			// (get) Token: 0x060057A0 RID: 22432 RVA: 0x0013E040 File Offset: 0x0013C240
			public unsafe Image.FillMethod fillMethod
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ThemeSettings.ImageSettings.NativeMethodInfoPtr_get_fillMethod_Public_get_FillMethod_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x1700200C RID: 8204
			// (get) Token: 0x060057A1 RID: 22433 RVA: 0x0013E07C File Offset: 0x0013C27C
			public unsafe float fillAmout
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ThemeSettings.ImageSettings.NativeMethodInfoPtr_get_fillAmout_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x1700200D RID: 8205
			// (get) Token: 0x060057A2 RID: 22434 RVA: 0x0013E0B8 File Offset: 0x0013C2B8
			public unsafe bool fillClockwise
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ThemeSettings.ImageSettings.NativeMethodInfoPtr_get_fillClockwise_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x1700200E RID: 8206
			// (get) Token: 0x060057A3 RID: 22435 RVA: 0x0013E0F4 File Offset: 0x0013C2F4
			public unsafe int fillOrigin
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ThemeSettings.ImageSettings.NativeMethodInfoPtr_get_fillOrigin_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x060057A4 RID: 22436 RVA: 0x0013E130 File Offset: 0x0013C330
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 99303, XrefRangeEnd = 99329, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe virtual void CopyTo(Image image)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(image);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ThemeSettings.ImageSettings.NativeMethodInfoPtr_CopyTo_Public_Virtual_New_Void_Image_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060057A5 RID: 22437 RVA: 0x0013E180 File Offset: 0x0013C380
			[CallerCount(0)]
			public unsafe ImageSettings()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ThemeSettings.ImageSettings>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ThemeSettings.ImageSettings.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060057A6 RID: 22438 RVA: 0x00032627 File Offset: 0x00030827
			public ImageSettings(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001FFB RID: 8187
			// (get) Token: 0x060057A7 RID: 22439 RVA: 0x0013E1BC File Offset: 0x0013C3BC
			// (set) Token: 0x060057A8 RID: 22440 RVA: 0x00032630 File Offset: 0x00030830
			public unsafe Color _color
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ThemeSettings.ImageSettings.NativeFieldInfoPtr__color);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ThemeSettings.ImageSettings.NativeFieldInfoPtr__color)) = value;
				}
			}

			// Token: 0x17001FFC RID: 8188
			// (get) Token: 0x060057A9 RID: 22441 RVA: 0x0013E1E4 File Offset: 0x0013C3E4
			// (set) Token: 0x060057AA RID: 22442 RVA: 0x0003264B File Offset: 0x0003084B
			public unsafe Sprite _sprite
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ThemeSettings.ImageSettings.NativeFieldInfoPtr__sprite);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Sprite>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ThemeSettings.ImageSettings.NativeFieldInfoPtr__sprite), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001FFD RID: 8189
			// (get) Token: 0x060057AB RID: 22443 RVA: 0x0013E214 File Offset: 0x0013C414
			// (set) Token: 0x060057AC RID: 22444 RVA: 0x0003266A File Offset: 0x0003086A
			public unsafe Material _materal
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ThemeSettings.ImageSettings.NativeFieldInfoPtr__materal);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Material>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ThemeSettings.ImageSettings.NativeFieldInfoPtr__materal), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001FFE RID: 8190
			// (get) Token: 0x060057AD RID: 22445 RVA: 0x0013E244 File Offset: 0x0013C444
			// (set) Token: 0x060057AE RID: 22446 RVA: 0x00032689 File Offset: 0x00030889
			public unsafe Image.Type _type
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ThemeSettings.ImageSettings.NativeFieldInfoPtr__type);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ThemeSettings.ImageSettings.NativeFieldInfoPtr__type)) = value;
				}
			}

			// Token: 0x17001FFF RID: 8191
			// (get) Token: 0x060057AF RID: 22447 RVA: 0x0013E26C File Offset: 0x0013C46C
			// (set) Token: 0x060057B0 RID: 22448 RVA: 0x000326A4 File Offset: 0x000308A4
			public unsafe bool _preserveAspect
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ThemeSettings.ImageSettings.NativeFieldInfoPtr__preserveAspect);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ThemeSettings.ImageSettings.NativeFieldInfoPtr__preserveAspect)) = value;
				}
			}

			// Token: 0x17002000 RID: 8192
			// (get) Token: 0x060057B1 RID: 22449 RVA: 0x0013E294 File Offset: 0x0013C494
			// (set) Token: 0x060057B2 RID: 22450 RVA: 0x000326BF File Offset: 0x000308BF
			public unsafe bool _fillCenter
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ThemeSettings.ImageSettings.NativeFieldInfoPtr__fillCenter);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ThemeSettings.ImageSettings.NativeFieldInfoPtr__fillCenter)) = value;
				}
			}

			// Token: 0x17002001 RID: 8193
			// (get) Token: 0x060057B3 RID: 22451 RVA: 0x0013E2BC File Offset: 0x0013C4BC
			// (set) Token: 0x060057B4 RID: 22452 RVA: 0x000326DA File Offset: 0x000308DA
			public unsafe Image.FillMethod _fillMethod
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ThemeSettings.ImageSettings.NativeFieldInfoPtr__fillMethod);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ThemeSettings.ImageSettings.NativeFieldInfoPtr__fillMethod)) = value;
				}
			}

			// Token: 0x17002002 RID: 8194
			// (get) Token: 0x060057B5 RID: 22453 RVA: 0x0013E2E4 File Offset: 0x0013C4E4
			// (set) Token: 0x060057B6 RID: 22454 RVA: 0x000326F5 File Offset: 0x000308F5
			public unsafe float _fillAmout
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ThemeSettings.ImageSettings.NativeFieldInfoPtr__fillAmout);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ThemeSettings.ImageSettings.NativeFieldInfoPtr__fillAmout)) = value;
				}
			}

			// Token: 0x17002003 RID: 8195
			// (get) Token: 0x060057B7 RID: 22455 RVA: 0x0013E30C File Offset: 0x0013C50C
			// (set) Token: 0x060057B8 RID: 22456 RVA: 0x00032710 File Offset: 0x00030910
			public unsafe bool _fillClockwise
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ThemeSettings.ImageSettings.NativeFieldInfoPtr__fillClockwise);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ThemeSettings.ImageSettings.NativeFieldInfoPtr__fillClockwise)) = value;
				}
			}

			// Token: 0x17002004 RID: 8196
			// (get) Token: 0x060057B9 RID: 22457 RVA: 0x0013E334 File Offset: 0x0013C534
			// (set) Token: 0x060057BA RID: 22458 RVA: 0x0003272B File Offset: 0x0003092B
			public unsafe int _fillOrigin
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ThemeSettings.ImageSettings.NativeFieldInfoPtr__fillOrigin);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ThemeSettings.ImageSettings.NativeFieldInfoPtr__fillOrigin)) = value;
				}
			}

			// Token: 0x04003A12 RID: 14866
			private static readonly IntPtr NativeFieldInfoPtr__color;

			// Token: 0x04003A13 RID: 14867
			private static readonly IntPtr NativeFieldInfoPtr__sprite;

			// Token: 0x04003A14 RID: 14868
			private static readonly IntPtr NativeFieldInfoPtr__materal;

			// Token: 0x04003A15 RID: 14869
			private static readonly IntPtr NativeFieldInfoPtr__type;

			// Token: 0x04003A16 RID: 14870
			private static readonly IntPtr NativeFieldInfoPtr__preserveAspect;

			// Token: 0x04003A17 RID: 14871
			private static readonly IntPtr NativeFieldInfoPtr__fillCenter;

			// Token: 0x04003A18 RID: 14872
			private static readonly IntPtr NativeFieldInfoPtr__fillMethod;

			// Token: 0x04003A19 RID: 14873
			private static readonly IntPtr NativeFieldInfoPtr__fillAmout;

			// Token: 0x04003A1A RID: 14874
			private static readonly IntPtr NativeFieldInfoPtr__fillClockwise;

			// Token: 0x04003A1B RID: 14875
			private static readonly IntPtr NativeFieldInfoPtr__fillOrigin;

			// Token: 0x04003A1C RID: 14876
			private static readonly IntPtr NativeMethodInfoPtr_get_color_Public_get_Color_0;

			// Token: 0x04003A1D RID: 14877
			private static readonly IntPtr NativeMethodInfoPtr_get_sprite_Public_get_Sprite_0;

			// Token: 0x04003A1E RID: 14878
			private static readonly IntPtr NativeMethodInfoPtr_get_materal_Public_get_Material_0;

			// Token: 0x04003A1F RID: 14879
			private static readonly IntPtr NativeMethodInfoPtr_get_type_Public_get_Type_0;

			// Token: 0x04003A20 RID: 14880
			private static readonly IntPtr NativeMethodInfoPtr_get_preserveAspect_Public_get_Boolean_0;

			// Token: 0x04003A21 RID: 14881
			private static readonly IntPtr NativeMethodInfoPtr_get_fillCenter_Public_get_Boolean_0;

			// Token: 0x04003A22 RID: 14882
			private static readonly IntPtr NativeMethodInfoPtr_get_fillMethod_Public_get_FillMethod_0;

			// Token: 0x04003A23 RID: 14883
			private static readonly IntPtr NativeMethodInfoPtr_get_fillAmout_Public_get_Single_0;

			// Token: 0x04003A24 RID: 14884
			private static readonly IntPtr NativeMethodInfoPtr_get_fillClockwise_Public_get_Boolean_0;

			// Token: 0x04003A25 RID: 14885
			private static readonly IntPtr NativeMethodInfoPtr_get_fillOrigin_Public_get_Int32_0;

			// Token: 0x04003A26 RID: 14886
			private static readonly IntPtr NativeMethodInfoPtr_CopyTo_Public_Virtual_New_Void_Image_0;

			// Token: 0x04003A27 RID: 14887
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x0200038E RID: 910
		[Serializable]
		[StructLayout(2)]
		public struct CustomColorBlock
		{
			// Token: 0x060057BB RID: 22459 RVA: 0x0013E35C File Offset: 0x0013C55C
			// Note: this type is marked as 'beforefieldinit'.
			static CustomColorBlock()
			{
				Il2CppClassPointerStore<ThemeSettings.CustomColorBlock>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ThemeSettings>.NativeClassPtr, "CustomColorBlock");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ThemeSettings.CustomColorBlock>.NativeClassPtr);
				ThemeSettings.CustomColorBlock.NativeFieldInfoPtr_m_ColorMultiplier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ThemeSettings.CustomColorBlock>.NativeClassPtr, "m_ColorMultiplier");
				ThemeSettings.CustomColorBlock.NativeFieldInfoPtr_m_DisabledColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ThemeSettings.CustomColorBlock>.NativeClassPtr, "m_DisabledColor");
				ThemeSettings.CustomColorBlock.NativeFieldInfoPtr_m_FadeDuration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ThemeSettings.CustomColorBlock>.NativeClassPtr, "m_FadeDuration");
				ThemeSettings.CustomColorBlock.NativeFieldInfoPtr_m_HighlightedColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ThemeSettings.CustomColorBlock>.NativeClassPtr, "m_HighlightedColor");
				ThemeSettings.CustomColorBlock.NativeFieldInfoPtr_m_NormalColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ThemeSettings.CustomColorBlock>.NativeClassPtr, "m_NormalColor");
				ThemeSettings.CustomColorBlock.NativeFieldInfoPtr_m_PressedColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ThemeSettings.CustomColorBlock>.NativeClassPtr, "m_PressedColor");
				ThemeSettings.CustomColorBlock.NativeFieldInfoPtr_m_SelectedColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ThemeSettings.CustomColorBlock>.NativeClassPtr, "m_SelectedColor");
				ThemeSettings.CustomColorBlock.NativeFieldInfoPtr_m_DisabledHighlightedColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ThemeSettings.CustomColorBlock>.NativeClassPtr, "m_DisabledHighlightedColor");
				ThemeSettings.CustomColorBlock.NativeMethodInfoPtr_get_colorMultiplier_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ThemeSettings.CustomColorBlock>.NativeClassPtr, 100669248);
				ThemeSettings.CustomColorBlock.NativeMethodInfoPtr_set_colorMultiplier_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ThemeSettings.CustomColorBlock>.NativeClassPtr, 100669249);
				ThemeSettings.CustomColorBlock.NativeMethodInfoPtr_get_disabledColor_Public_get_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ThemeSettings.CustomColorBlock>.NativeClassPtr, 100669250);
				ThemeSettings.CustomColorBlock.NativeMethodInfoPtr_set_disabledColor_Public_set_Void_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ThemeSettings.CustomColorBlock>.NativeClassPtr, 100669251);
				ThemeSettings.CustomColorBlock.NativeMethodInfoPtr_get_fadeDuration_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ThemeSettings.CustomColorBlock>.NativeClassPtr, 100669252);
				ThemeSettings.CustomColorBlock.NativeMethodInfoPtr_set_fadeDuration_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ThemeSettings.CustomColorBlock>.NativeClassPtr, 100669253);
				ThemeSettings.CustomColorBlock.NativeMethodInfoPtr_get_highlightedColor_Public_get_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ThemeSettings.CustomColorBlock>.NativeClassPtr, 100669254);
				ThemeSettings.CustomColorBlock.NativeMethodInfoPtr_set_highlightedColor_Public_set_Void_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ThemeSettings.CustomColorBlock>.NativeClassPtr, 100669255);
				ThemeSettings.CustomColorBlock.NativeMethodInfoPtr_get_normalColor_Public_get_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ThemeSettings.CustomColorBlock>.NativeClassPtr, 100669256);
				ThemeSettings.CustomColorBlock.NativeMethodInfoPtr_set_normalColor_Public_set_Void_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ThemeSettings.CustomColorBlock>.NativeClassPtr, 100669257);
				ThemeSettings.CustomColorBlock.NativeMethodInfoPtr_get_pressedColor_Public_get_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ThemeSettings.CustomColorBlock>.NativeClassPtr, 100669258);
				ThemeSettings.CustomColorBlock.NativeMethodInfoPtr_set_pressedColor_Public_set_Void_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ThemeSettings.CustomColorBlock>.NativeClassPtr, 100669259);
				ThemeSettings.CustomColorBlock.NativeMethodInfoPtr_get_selectedColor_Public_get_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ThemeSettings.CustomColorBlock>.NativeClassPtr, 100669260);
				ThemeSettings.CustomColorBlock.NativeMethodInfoPtr_set_selectedColor_Public_set_Void_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ThemeSettings.CustomColorBlock>.NativeClassPtr, 100669261);
				ThemeSettings.CustomColorBlock.NativeMethodInfoPtr_get_disabledHighlightedColor_Public_get_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ThemeSettings.CustomColorBlock>.NativeClassPtr, 100669262);
				ThemeSettings.CustomColorBlock.NativeMethodInfoPtr_set_disabledHighlightedColor_Public_set_Void_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ThemeSettings.CustomColorBlock>.NativeClassPtr, 100669263);
				ThemeSettings.CustomColorBlock.NativeMethodInfoPtr_op_Implicit_Public_Static_ColorBlock_CustomColorBlock_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ThemeSettings.CustomColorBlock>.NativeClassPtr, 100669264);
			}

			// Token: 0x1700200F RID: 8207
			// (get) Token: 0x060057BC RID: 22460 RVA: 0x0013E57C File Offset: 0x0013C77C
			// (set) Token: 0x060057BD RID: 22461 RVA: 0x0013E5AC File Offset: 0x0013C7AC
			public unsafe float colorMultiplier
			{
				[CallerCount(0)]
				get
				{
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ThemeSettings.CustomColorBlock.NativeMethodInfoPtr_get_colorMultiplier_Public_get_Single_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
				[CallerCount(0)]
				set
				{
					checked
					{
						IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
						*ptr = ref value;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ThemeSettings.CustomColorBlock.NativeMethodInfoPtr_set_colorMultiplier_Public_set_Void_Single_0, ref this, (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}
			}

			// Token: 0x17002010 RID: 8208
			// (get) Token: 0x060057BE RID: 22462 RVA: 0x0013E5E0 File Offset: 0x0013C7E0
			// (set) Token: 0x060057BF RID: 22463 RVA: 0x0013E610 File Offset: 0x0013C810
			public unsafe Color disabledColor
			{
				[CallerCount(0)]
				get
				{
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ThemeSettings.CustomColorBlock.NativeMethodInfoPtr_get_disabledColor_Public_get_Color_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
				[CallerCount(0)]
				set
				{
					checked
					{
						IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
						*ptr = ref value;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ThemeSettings.CustomColorBlock.NativeMethodInfoPtr_set_disabledColor_Public_set_Void_Color_0, ref this, (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}
			}

			// Token: 0x17002011 RID: 8209
			// (get) Token: 0x060057C0 RID: 22464 RVA: 0x0013E644 File Offset: 0x0013C844
			// (set) Token: 0x060057C1 RID: 22465 RVA: 0x0013E674 File Offset: 0x0013C874
			public unsafe float fadeDuration
			{
				[CallerCount(0)]
				get
				{
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ThemeSettings.CustomColorBlock.NativeMethodInfoPtr_get_fadeDuration_Public_get_Single_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
				[CallerCount(0)]
				set
				{
					checked
					{
						IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
						*ptr = ref value;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ThemeSettings.CustomColorBlock.NativeMethodInfoPtr_set_fadeDuration_Public_set_Void_Single_0, ref this, (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}
			}

			// Token: 0x17002012 RID: 8210
			// (get) Token: 0x060057C2 RID: 22466 RVA: 0x0013E6A8 File Offset: 0x0013C8A8
			// (set) Token: 0x060057C3 RID: 22467 RVA: 0x0013E6D8 File Offset: 0x0013C8D8
			public unsafe Color highlightedColor
			{
				[CallerCount(0)]
				get
				{
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ThemeSettings.CustomColorBlock.NativeMethodInfoPtr_get_highlightedColor_Public_get_Color_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
				[CallerCount(0)]
				set
				{
					checked
					{
						IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
						*ptr = ref value;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ThemeSettings.CustomColorBlock.NativeMethodInfoPtr_set_highlightedColor_Public_set_Void_Color_0, ref this, (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}
			}

			// Token: 0x17002013 RID: 8211
			// (get) Token: 0x060057C4 RID: 22468 RVA: 0x0013E70C File Offset: 0x0013C90C
			// (set) Token: 0x060057C5 RID: 22469 RVA: 0x0013E73C File Offset: 0x0013C93C
			public unsafe Color normalColor
			{
				[CallerCount(0)]
				get
				{
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ThemeSettings.CustomColorBlock.NativeMethodInfoPtr_get_normalColor_Public_get_Color_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
				[CallerCount(0)]
				set
				{
					checked
					{
						IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
						*ptr = ref value;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ThemeSettings.CustomColorBlock.NativeMethodInfoPtr_set_normalColor_Public_set_Void_Color_0, ref this, (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}
			}

			// Token: 0x17002014 RID: 8212
			// (get) Token: 0x060057C6 RID: 22470 RVA: 0x0013E770 File Offset: 0x0013C970
			// (set) Token: 0x060057C7 RID: 22471 RVA: 0x0013E7A0 File Offset: 0x0013C9A0
			public unsafe Color pressedColor
			{
				[CallerCount(0)]
				get
				{
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ThemeSettings.CustomColorBlock.NativeMethodInfoPtr_get_pressedColor_Public_get_Color_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
				[CallerCount(0)]
				set
				{
					checked
					{
						IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
						*ptr = ref value;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ThemeSettings.CustomColorBlock.NativeMethodInfoPtr_set_pressedColor_Public_set_Void_Color_0, ref this, (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}
			}

			// Token: 0x17002015 RID: 8213
			// (get) Token: 0x060057C8 RID: 22472 RVA: 0x0013E7D4 File Offset: 0x0013C9D4
			// (set) Token: 0x060057C9 RID: 22473 RVA: 0x0013E804 File Offset: 0x0013CA04
			public unsafe Color selectedColor
			{
				[CallerCount(0)]
				get
				{
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ThemeSettings.CustomColorBlock.NativeMethodInfoPtr_get_selectedColor_Public_get_Color_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
				[CallerCount(0)]
				set
				{
					checked
					{
						IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
						*ptr = ref value;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ThemeSettings.CustomColorBlock.NativeMethodInfoPtr_set_selectedColor_Public_set_Void_Color_0, ref this, (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}
			}

			// Token: 0x17002016 RID: 8214
			// (get) Token: 0x060057CA RID: 22474 RVA: 0x0013E838 File Offset: 0x0013CA38
			// (set) Token: 0x060057CB RID: 22475 RVA: 0x0013E868 File Offset: 0x0013CA68
			public unsafe Color disabledHighlightedColor
			{
				[CallerCount(0)]
				get
				{
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ThemeSettings.CustomColorBlock.NativeMethodInfoPtr_get_disabledHighlightedColor_Public_get_Color_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
				[CallerCount(0)]
				set
				{
					checked
					{
						IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
						*ptr = ref value;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ThemeSettings.CustomColorBlock.NativeMethodInfoPtr_set_disabledHighlightedColor_Public_set_Void_Color_0, ref this, (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}
			}

			// Token: 0x060057CC RID: 22476 RVA: 0x0013E89C File Offset: 0x0013CA9C
			[CallerCount(0)]
			public unsafe static implicit operator ColorBlock(ThemeSettings.CustomColorBlock item)
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref item;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ThemeSettings.CustomColorBlock.NativeMethodInfoPtr_op_Implicit_Public_Static_ColorBlock_CustomColorBlock_0, 0, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x060057CD RID: 22477 RVA: 0x00032746 File Offset: 0x00030946
			public global::Il2CppSystem.Object BoxIl2CppObject()
			{
				return new global::Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ThemeSettings.CustomColorBlock>.NativeClassPtr, ref this));
			}

			// Token: 0x04003A28 RID: 14888
			private static readonly IntPtr NativeFieldInfoPtr_m_ColorMultiplier;

			// Token: 0x04003A29 RID: 14889
			private static readonly IntPtr NativeFieldInfoPtr_m_DisabledColor;

			// Token: 0x04003A2A RID: 14890
			private static readonly IntPtr NativeFieldInfoPtr_m_FadeDuration;

			// Token: 0x04003A2B RID: 14891
			private static readonly IntPtr NativeFieldInfoPtr_m_HighlightedColor;

			// Token: 0x04003A2C RID: 14892
			private static readonly IntPtr NativeFieldInfoPtr_m_NormalColor;

			// Token: 0x04003A2D RID: 14893
			private static readonly IntPtr NativeFieldInfoPtr_m_PressedColor;

			// Token: 0x04003A2E RID: 14894
			private static readonly IntPtr NativeFieldInfoPtr_m_SelectedColor;

			// Token: 0x04003A2F RID: 14895
			private static readonly IntPtr NativeFieldInfoPtr_m_DisabledHighlightedColor;

			// Token: 0x04003A30 RID: 14896
			private static readonly IntPtr NativeMethodInfoPtr_get_colorMultiplier_Public_get_Single_0;

			// Token: 0x04003A31 RID: 14897
			private static readonly IntPtr NativeMethodInfoPtr_set_colorMultiplier_Public_set_Void_Single_0;

			// Token: 0x04003A32 RID: 14898
			private static readonly IntPtr NativeMethodInfoPtr_get_disabledColor_Public_get_Color_0;

			// Token: 0x04003A33 RID: 14899
			private static readonly IntPtr NativeMethodInfoPtr_set_disabledColor_Public_set_Void_Color_0;

			// Token: 0x04003A34 RID: 14900
			private static readonly IntPtr NativeMethodInfoPtr_get_fadeDuration_Public_get_Single_0;

			// Token: 0x04003A35 RID: 14901
			private static readonly IntPtr NativeMethodInfoPtr_set_fadeDuration_Public_set_Void_Single_0;

			// Token: 0x04003A36 RID: 14902
			private static readonly IntPtr NativeMethodInfoPtr_get_highlightedColor_Public_get_Color_0;

			// Token: 0x04003A37 RID: 14903
			private static readonly IntPtr NativeMethodInfoPtr_set_highlightedColor_Public_set_Void_Color_0;

			// Token: 0x04003A38 RID: 14904
			private static readonly IntPtr NativeMethodInfoPtr_get_normalColor_Public_get_Color_0;

			// Token: 0x04003A39 RID: 14905
			private static readonly IntPtr NativeMethodInfoPtr_set_normalColor_Public_set_Void_Color_0;

			// Token: 0x04003A3A RID: 14906
			private static readonly IntPtr NativeMethodInfoPtr_get_pressedColor_Public_get_Color_0;

			// Token: 0x04003A3B RID: 14907
			private static readonly IntPtr NativeMethodInfoPtr_set_pressedColor_Public_set_Void_Color_0;

			// Token: 0x04003A3C RID: 14908
			private static readonly IntPtr NativeMethodInfoPtr_get_selectedColor_Public_get_Color_0;

			// Token: 0x04003A3D RID: 14909
			private static readonly IntPtr NativeMethodInfoPtr_set_selectedColor_Public_set_Void_Color_0;

			// Token: 0x04003A3E RID: 14910
			private static readonly IntPtr NativeMethodInfoPtr_get_disabledHighlightedColor_Public_get_Color_0;

			// Token: 0x04003A3F RID: 14911
			private static readonly IntPtr NativeMethodInfoPtr_set_disabledHighlightedColor_Public_set_Void_Color_0;

			// Token: 0x04003A40 RID: 14912
			private static readonly IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_ColorBlock_CustomColorBlock_0;

			// Token: 0x04003A41 RID: 14913
			[FieldOffset(0)]
			public float m_ColorMultiplier;

			// Token: 0x04003A42 RID: 14914
			[FieldOffset(4)]
			public Color m_DisabledColor;

			// Token: 0x04003A43 RID: 14915
			[FieldOffset(20)]
			public float m_FadeDuration;

			// Token: 0x04003A44 RID: 14916
			[FieldOffset(24)]
			public Color m_HighlightedColor;

			// Token: 0x04003A45 RID: 14917
			[FieldOffset(40)]
			public Color m_NormalColor;

			// Token: 0x04003A46 RID: 14918
			[FieldOffset(56)]
			public Color m_PressedColor;

			// Token: 0x04003A47 RID: 14919
			[FieldOffset(72)]
			public Color m_SelectedColor;

			// Token: 0x04003A48 RID: 14920
			[FieldOffset(88)]
			public Color m_DisabledHighlightedColor;
		}

		// Token: 0x0200038F RID: 911
		[Serializable]
		public sealed class CustomSpriteState : ValueType
		{
			// Token: 0x060057CE RID: 22478 RVA: 0x0013E8DC File Offset: 0x0013CADC
			// Note: this type is marked as 'beforefieldinit'.
			static CustomSpriteState()
			{
				Il2CppClassPointerStore<ThemeSettings.CustomSpriteState>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ThemeSettings>.NativeClassPtr, "CustomSpriteState");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ThemeSettings.CustomSpriteState>.NativeClassPtr);
				ThemeSettings.CustomSpriteState.NativeFieldInfoPtr_m_DisabledSprite = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ThemeSettings.CustomSpriteState>.NativeClassPtr, "m_DisabledSprite");
				ThemeSettings.CustomSpriteState.NativeFieldInfoPtr_m_HighlightedSprite = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ThemeSettings.CustomSpriteState>.NativeClassPtr, "m_HighlightedSprite");
				ThemeSettings.CustomSpriteState.NativeFieldInfoPtr_m_PressedSprite = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ThemeSettings.CustomSpriteState>.NativeClassPtr, "m_PressedSprite");
				ThemeSettings.CustomSpriteState.NativeFieldInfoPtr_m_SelectedSprite = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ThemeSettings.CustomSpriteState>.NativeClassPtr, "m_SelectedSprite");
				ThemeSettings.CustomSpriteState.NativeFieldInfoPtr_m_DisabledHighlightedSprite = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ThemeSettings.CustomSpriteState>.NativeClassPtr, "m_DisabledHighlightedSprite");
				ThemeSettings.CustomSpriteState.NativeMethodInfoPtr_get_disabledSprite_Public_get_Sprite_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ThemeSettings.CustomSpriteState>.NativeClassPtr, 100669265);
				ThemeSettings.CustomSpriteState.NativeMethodInfoPtr_set_disabledSprite_Public_set_Void_Sprite_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ThemeSettings.CustomSpriteState>.NativeClassPtr, 100669266);
				ThemeSettings.CustomSpriteState.NativeMethodInfoPtr_get_highlightedSprite_Public_get_Sprite_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ThemeSettings.CustomSpriteState>.NativeClassPtr, 100669267);
				ThemeSettings.CustomSpriteState.NativeMethodInfoPtr_set_highlightedSprite_Public_set_Void_Sprite_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ThemeSettings.CustomSpriteState>.NativeClassPtr, 100669268);
				ThemeSettings.CustomSpriteState.NativeMethodInfoPtr_get_pressedSprite_Public_get_Sprite_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ThemeSettings.CustomSpriteState>.NativeClassPtr, 100669269);
				ThemeSettings.CustomSpriteState.NativeMethodInfoPtr_set_pressedSprite_Public_set_Void_Sprite_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ThemeSettings.CustomSpriteState>.NativeClassPtr, 100669270);
				ThemeSettings.CustomSpriteState.NativeMethodInfoPtr_get_selectedSprite_Public_get_Sprite_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ThemeSettings.CustomSpriteState>.NativeClassPtr, 100669271);
				ThemeSettings.CustomSpriteState.NativeMethodInfoPtr_set_selectedSprite_Public_set_Void_Sprite_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ThemeSettings.CustomSpriteState>.NativeClassPtr, 100669272);
				ThemeSettings.CustomSpriteState.NativeMethodInfoPtr_get_disabledHighlightedSprite_Public_get_Sprite_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ThemeSettings.CustomSpriteState>.NativeClassPtr, 100669273);
				ThemeSettings.CustomSpriteState.NativeMethodInfoPtr_set_disabledHighlightedSprite_Public_set_Void_Sprite_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ThemeSettings.CustomSpriteState>.NativeClassPtr, 100669274);
				ThemeSettings.CustomSpriteState.NativeMethodInfoPtr_op_Implicit_Public_Static_SpriteState_CustomSpriteState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ThemeSettings.CustomSpriteState>.NativeClassPtr, 100669275);
			}

			// Token: 0x1700201C RID: 8220
			// (get) Token: 0x060057CF RID: 22479 RVA: 0x0013EA48 File Offset: 0x0013CC48
			// (set) Token: 0x060057D0 RID: 22480 RVA: 0x0013EA8C File Offset: 0x0013CC8C
			public unsafe Sprite disabledSprite
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ThemeSettings.CustomSpriteState.NativeMethodInfoPtr_get_disabledSprite_Public_get_Sprite_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Sprite>(intPtr3) : null;
				}
				[CallerCount(2)]
				[CachedScanResults(RefRangeStart = 99329, RefRangeEnd = 99331, XrefRangeStart = 99329, XrefRangeEnd = 99329, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				set
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					checked
					{
						IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
						*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ThemeSettings.CustomSpriteState.NativeMethodInfoPtr_set_disabledSprite_Public_set_Void_Sprite_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}
			}

			// Token: 0x1700201D RID: 8221
			// (get) Token: 0x060057D1 RID: 22481 RVA: 0x0013EAD4 File Offset: 0x0013CCD4
			// (set) Token: 0x060057D2 RID: 22482 RVA: 0x0013EB18 File Offset: 0x0013CD18
			public unsafe Sprite highlightedSprite
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ThemeSettings.CustomSpriteState.NativeMethodInfoPtr_get_highlightedSprite_Public_get_Sprite_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Sprite>(intPtr3) : null;
				}
				[CallerCount(2)]
				[CachedScanResults(RefRangeStart = 99331, RefRangeEnd = 99333, XrefRangeStart = 99331, XrefRangeEnd = 99331, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				set
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					checked
					{
						IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
						*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ThemeSettings.CustomSpriteState.NativeMethodInfoPtr_set_highlightedSprite_Public_set_Void_Sprite_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}
			}

			// Token: 0x1700201E RID: 8222
			// (get) Token: 0x060057D3 RID: 22483 RVA: 0x0013EB60 File Offset: 0x0013CD60
			// (set) Token: 0x060057D4 RID: 22484 RVA: 0x0013EBA4 File Offset: 0x0013CDA4
			public unsafe Sprite pressedSprite
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ThemeSettings.CustomSpriteState.NativeMethodInfoPtr_get_pressedSprite_Public_get_Sprite_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Sprite>(intPtr3) : null;
				}
				[CallerCount(79)]
				[CachedScanResults(RefRangeStart = 14237, RefRangeEnd = 14316, XrefRangeStart = 14237, XrefRangeEnd = 14316, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				set
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					checked
					{
						IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
						*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ThemeSettings.CustomSpriteState.NativeMethodInfoPtr_set_pressedSprite_Public_set_Void_Sprite_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}
			}

			// Token: 0x1700201F RID: 8223
			// (get) Token: 0x060057D5 RID: 22485 RVA: 0x0013EBEC File Offset: 0x0013CDEC
			// (set) Token: 0x060057D6 RID: 22486 RVA: 0x0013EC30 File Offset: 0x0013CE30
			public unsafe Sprite selectedSprite
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ThemeSettings.CustomSpriteState.NativeMethodInfoPtr_get_selectedSprite_Public_get_Sprite_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Sprite>(intPtr3) : null;
				}
				[CallerCount(58)]
				[CachedScanResults(RefRangeStart = 18562, RefRangeEnd = 18620, XrefRangeStart = 18562, XrefRangeEnd = 18620, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				set
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					checked
					{
						IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
						*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ThemeSettings.CustomSpriteState.NativeMethodInfoPtr_set_selectedSprite_Public_set_Void_Sprite_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}
			}

			// Token: 0x17002020 RID: 8224
			// (get) Token: 0x060057D7 RID: 22487 RVA: 0x0013EC78 File Offset: 0x0013CE78
			// (set) Token: 0x060057D8 RID: 22488 RVA: 0x0013ECBC File Offset: 0x0013CEBC
			public unsafe Sprite disabledHighlightedSprite
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ThemeSettings.CustomSpriteState.NativeMethodInfoPtr_get_disabledHighlightedSprite_Public_get_Sprite_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Sprite>(intPtr3) : null;
				}
				[CallerCount(33)]
				[CachedScanResults(RefRangeStart = 18620, RefRangeEnd = 18653, XrefRangeStart = 18620, XrefRangeEnd = 18653, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				set
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					checked
					{
						IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
						*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ThemeSettings.CustomSpriteState.NativeMethodInfoPtr_set_disabledHighlightedSprite_Public_set_Void_Sprite_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}
			}

			// Token: 0x060057D9 RID: 22489 RVA: 0x0013ED04 File Offset: 0x0013CF04
			[CallerCount(0)]
			public unsafe static implicit operator SpriteState(ThemeSettings.CustomSpriteState item)
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(item));
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ThemeSettings.CustomSpriteState.NativeMethodInfoPtr_op_Implicit_Public_Static_SpriteState_CustomSpriteState_0, 0, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return new SpriteState(intPtr);
				}
			}

			// Token: 0x060057DA RID: 22490 RVA: 0x00032758 File Offset: 0x00030958
			public CustomSpriteState(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x060057DB RID: 22491 RVA: 0x00032761 File Offset: 0x00030961
			public CustomSpriteState()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ThemeSettings.CustomSpriteState>.NativeClassPtr))
			{
			}

			// Token: 0x17002017 RID: 8215
			// (get) Token: 0x060057DC RID: 22492 RVA: 0x0013ED48 File Offset: 0x0013CF48
			// (set) Token: 0x060057DD RID: 22493 RVA: 0x00032773 File Offset: 0x00030973
			public unsafe Sprite m_DisabledSprite
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ThemeSettings.CustomSpriteState.NativeFieldInfoPtr_m_DisabledSprite);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Sprite>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ThemeSettings.CustomSpriteState.NativeFieldInfoPtr_m_DisabledSprite), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002018 RID: 8216
			// (get) Token: 0x060057DE RID: 22494 RVA: 0x0013ED78 File Offset: 0x0013CF78
			// (set) Token: 0x060057DF RID: 22495 RVA: 0x00032792 File Offset: 0x00030992
			public unsafe Sprite m_HighlightedSprite
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ThemeSettings.CustomSpriteState.NativeFieldInfoPtr_m_HighlightedSprite);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Sprite>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ThemeSettings.CustomSpriteState.NativeFieldInfoPtr_m_HighlightedSprite), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002019 RID: 8217
			// (get) Token: 0x060057E0 RID: 22496 RVA: 0x0013EDA8 File Offset: 0x0013CFA8
			// (set) Token: 0x060057E1 RID: 22497 RVA: 0x000327B1 File Offset: 0x000309B1
			public unsafe Sprite m_PressedSprite
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ThemeSettings.CustomSpriteState.NativeFieldInfoPtr_m_PressedSprite);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Sprite>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ThemeSettings.CustomSpriteState.NativeFieldInfoPtr_m_PressedSprite), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700201A RID: 8218
			// (get) Token: 0x060057E2 RID: 22498 RVA: 0x0013EDD8 File Offset: 0x0013CFD8
			// (set) Token: 0x060057E3 RID: 22499 RVA: 0x000327D0 File Offset: 0x000309D0
			public unsafe Sprite m_SelectedSprite
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ThemeSettings.CustomSpriteState.NativeFieldInfoPtr_m_SelectedSprite);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Sprite>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ThemeSettings.CustomSpriteState.NativeFieldInfoPtr_m_SelectedSprite), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700201B RID: 8219
			// (get) Token: 0x060057E4 RID: 22500 RVA: 0x0013EE08 File Offset: 0x0013D008
			// (set) Token: 0x060057E5 RID: 22501 RVA: 0x000327EF File Offset: 0x000309EF
			public unsafe Sprite m_DisabledHighlightedSprite
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ThemeSettings.CustomSpriteState.NativeFieldInfoPtr_m_DisabledHighlightedSprite);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Sprite>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ThemeSettings.CustomSpriteState.NativeFieldInfoPtr_m_DisabledHighlightedSprite), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04003A49 RID: 14921
			private static readonly IntPtr NativeFieldInfoPtr_m_DisabledSprite;

			// Token: 0x04003A4A RID: 14922
			private static readonly IntPtr NativeFieldInfoPtr_m_HighlightedSprite;

			// Token: 0x04003A4B RID: 14923
			private static readonly IntPtr NativeFieldInfoPtr_m_PressedSprite;

			// Token: 0x04003A4C RID: 14924
			private static readonly IntPtr NativeFieldInfoPtr_m_SelectedSprite;

			// Token: 0x04003A4D RID: 14925
			private static readonly IntPtr NativeFieldInfoPtr_m_DisabledHighlightedSprite;

			// Token: 0x04003A4E RID: 14926
			private static readonly IntPtr NativeMethodInfoPtr_get_disabledSprite_Public_get_Sprite_0;

			// Token: 0x04003A4F RID: 14927
			private static readonly IntPtr NativeMethodInfoPtr_set_disabledSprite_Public_set_Void_Sprite_0;

			// Token: 0x04003A50 RID: 14928
			private static readonly IntPtr NativeMethodInfoPtr_get_highlightedSprite_Public_get_Sprite_0;

			// Token: 0x04003A51 RID: 14929
			private static readonly IntPtr NativeMethodInfoPtr_set_highlightedSprite_Public_set_Void_Sprite_0;

			// Token: 0x04003A52 RID: 14930
			private static readonly IntPtr NativeMethodInfoPtr_get_pressedSprite_Public_get_Sprite_0;

			// Token: 0x04003A53 RID: 14931
			private static readonly IntPtr NativeMethodInfoPtr_set_pressedSprite_Public_set_Void_Sprite_0;

			// Token: 0x04003A54 RID: 14932
			private static readonly IntPtr NativeMethodInfoPtr_get_selectedSprite_Public_get_Sprite_0;

			// Token: 0x04003A55 RID: 14933
			private static readonly IntPtr NativeMethodInfoPtr_set_selectedSprite_Public_set_Void_Sprite_0;

			// Token: 0x04003A56 RID: 14934
			private static readonly IntPtr NativeMethodInfoPtr_get_disabledHighlightedSprite_Public_get_Sprite_0;

			// Token: 0x04003A57 RID: 14935
			private static readonly IntPtr NativeMethodInfoPtr_set_disabledHighlightedSprite_Public_set_Void_Sprite_0;

			// Token: 0x04003A58 RID: 14936
			private static readonly IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_SpriteState_CustomSpriteState_0;
		}

		// Token: 0x02000390 RID: 912
		[Serializable]
		public class CustomAnimationTriggers : global::Il2CppSystem.Object
		{
			// Token: 0x060057E6 RID: 22502 RVA: 0x0013EE38 File Offset: 0x0013D038
			// Note: this type is marked as 'beforefieldinit'.
			static CustomAnimationTriggers()
			{
				Il2CppClassPointerStore<ThemeSettings.CustomAnimationTriggers>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ThemeSettings>.NativeClassPtr, "CustomAnimationTriggers");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ThemeSettings.CustomAnimationTriggers>.NativeClassPtr);
				ThemeSettings.CustomAnimationTriggers.NativeFieldInfoPtr_m_DisabledTrigger = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ThemeSettings.CustomAnimationTriggers>.NativeClassPtr, "m_DisabledTrigger");
				ThemeSettings.CustomAnimationTriggers.NativeFieldInfoPtr_m_HighlightedTrigger = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ThemeSettings.CustomAnimationTriggers>.NativeClassPtr, "m_HighlightedTrigger");
				ThemeSettings.CustomAnimationTriggers.NativeFieldInfoPtr_m_NormalTrigger = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ThemeSettings.CustomAnimationTriggers>.NativeClassPtr, "m_NormalTrigger");
				ThemeSettings.CustomAnimationTriggers.NativeFieldInfoPtr_m_PressedTrigger = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ThemeSettings.CustomAnimationTriggers>.NativeClassPtr, "m_PressedTrigger");
				ThemeSettings.CustomAnimationTriggers.NativeFieldInfoPtr_m_SelectedTrigger = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ThemeSettings.CustomAnimationTriggers>.NativeClassPtr, "m_SelectedTrigger");
				ThemeSettings.CustomAnimationTriggers.NativeFieldInfoPtr_m_DisabledHighlightedTrigger = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ThemeSettings.CustomAnimationTriggers>.NativeClassPtr, "m_DisabledHighlightedTrigger");
				ThemeSettings.CustomAnimationTriggers.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ThemeSettings.CustomAnimationTriggers>.NativeClassPtr, 100669276);
				ThemeSettings.CustomAnimationTriggers.NativeMethodInfoPtr_get_disabledTrigger_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ThemeSettings.CustomAnimationTriggers>.NativeClassPtr, 100669277);
				ThemeSettings.CustomAnimationTriggers.NativeMethodInfoPtr_set_disabledTrigger_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ThemeSettings.CustomAnimationTriggers>.NativeClassPtr, 100669278);
				ThemeSettings.CustomAnimationTriggers.NativeMethodInfoPtr_get_highlightedTrigger_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ThemeSettings.CustomAnimationTriggers>.NativeClassPtr, 100669279);
				ThemeSettings.CustomAnimationTriggers.NativeMethodInfoPtr_set_highlightedTrigger_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ThemeSettings.CustomAnimationTriggers>.NativeClassPtr, 100669280);
				ThemeSettings.CustomAnimationTriggers.NativeMethodInfoPtr_get_normalTrigger_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ThemeSettings.CustomAnimationTriggers>.NativeClassPtr, 100669281);
				ThemeSettings.CustomAnimationTriggers.NativeMethodInfoPtr_set_normalTrigger_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ThemeSettings.CustomAnimationTriggers>.NativeClassPtr, 100669282);
				ThemeSettings.CustomAnimationTriggers.NativeMethodInfoPtr_get_pressedTrigger_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ThemeSettings.CustomAnimationTriggers>.NativeClassPtr, 100669283);
				ThemeSettings.CustomAnimationTriggers.NativeMethodInfoPtr_set_pressedTrigger_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ThemeSettings.CustomAnimationTriggers>.NativeClassPtr, 100669284);
				ThemeSettings.CustomAnimationTriggers.NativeMethodInfoPtr_get_selectedTrigger_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ThemeSettings.CustomAnimationTriggers>.NativeClassPtr, 100669285);
				ThemeSettings.CustomAnimationTriggers.NativeMethodInfoPtr_set_selectedTrigger_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ThemeSettings.CustomAnimationTriggers>.NativeClassPtr, 100669286);
				ThemeSettings.CustomAnimationTriggers.NativeMethodInfoPtr_get_disabledHighlightedTrigger_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ThemeSettings.CustomAnimationTriggers>.NativeClassPtr, 100669287);
				ThemeSettings.CustomAnimationTriggers.NativeMethodInfoPtr_set_disabledHighlightedTrigger_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ThemeSettings.CustomAnimationTriggers>.NativeClassPtr, 100669288);
				ThemeSettings.CustomAnimationTriggers.NativeMethodInfoPtr_op_Implicit_Public_Static_AnimationTriggers_CustomAnimationTriggers_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ThemeSettings.CustomAnimationTriggers>.NativeClassPtr, 100669289);
			}

			// Token: 0x060057E7 RID: 22503 RVA: 0x0013EFF4 File Offset: 0x0013D1F4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 99333, XrefRangeEnd = 99340, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe CustomAnimationTriggers()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ThemeSettings.CustomAnimationTriggers>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ThemeSettings.CustomAnimationTriggers.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17002027 RID: 8231
			// (get) Token: 0x060057E8 RID: 22504 RVA: 0x0013F030 File Offset: 0x0013D230
			// (set) Token: 0x060057E9 RID: 22505 RVA: 0x0013F068 File Offset: 0x0013D268
			public unsafe string disabledTrigger
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ThemeSettings.CustomAnimationTriggers.NativeMethodInfoPtr_get_disabledTrigger_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
				[CallerCount(79)]
				[CachedScanResults(RefRangeStart = 14237, RefRangeEnd = 14316, XrefRangeStart = 14237, XrefRangeEnd = 14316, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				set
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					checked
					{
						IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
						*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ThemeSettings.CustomAnimationTriggers.NativeMethodInfoPtr_set_disabledTrigger_Public_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}
			}

			// Token: 0x17002028 RID: 8232
			// (get) Token: 0x060057EA RID: 22506 RVA: 0x0013F0AC File Offset: 0x0013D2AC
			// (set) Token: 0x060057EB RID: 22507 RVA: 0x0013F0E4 File Offset: 0x0013D2E4
			public unsafe string highlightedTrigger
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ThemeSettings.CustomAnimationTriggers.NativeMethodInfoPtr_get_highlightedTrigger_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
				[CallerCount(58)]
				[CachedScanResults(RefRangeStart = 18562, RefRangeEnd = 18620, XrefRangeStart = 18562, XrefRangeEnd = 18620, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				set
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					checked
					{
						IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
						*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ThemeSettings.CustomAnimationTriggers.NativeMethodInfoPtr_set_highlightedTrigger_Public_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}
			}

			// Token: 0x17002029 RID: 8233
			// (get) Token: 0x060057EC RID: 22508 RVA: 0x0013F128 File Offset: 0x0013D328
			// (set) Token: 0x060057ED RID: 22509 RVA: 0x0013F160 File Offset: 0x0013D360
			public unsafe string normalTrigger
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ThemeSettings.CustomAnimationTriggers.NativeMethodInfoPtr_get_normalTrigger_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
				[CallerCount(33)]
				[CachedScanResults(RefRangeStart = 18620, RefRangeEnd = 18653, XrefRangeStart = 18620, XrefRangeEnd = 18653, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				set
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					checked
					{
						IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
						*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ThemeSettings.CustomAnimationTriggers.NativeMethodInfoPtr_set_normalTrigger_Public_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}
			}

			// Token: 0x1700202A RID: 8234
			// (get) Token: 0x060057EE RID: 22510 RVA: 0x0013F1A4 File Offset: 0x0013D3A4
			// (set) Token: 0x060057EF RID: 22511 RVA: 0x0013F1DC File Offset: 0x0013D3DC
			public unsafe string pressedTrigger
			{
				[CallerCount(3)]
				[CachedScanResults(RefRangeStart = 13519, RefRangeEnd = 13522, XrefRangeStart = 13519, XrefRangeEnd = 13522, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ThemeSettings.CustomAnimationTriggers.NativeMethodInfoPtr_get_pressedTrigger_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
				[CallerCount(38)]
				[CachedScanResults(RefRangeStart = 17089, RefRangeEnd = 17127, XrefRangeStart = 17089, XrefRangeEnd = 17127, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				set
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					checked
					{
						IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
						*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ThemeSettings.CustomAnimationTriggers.NativeMethodInfoPtr_set_pressedTrigger_Public_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}
			}

			// Token: 0x1700202B RID: 8235
			// (get) Token: 0x060057F0 RID: 22512 RVA: 0x0013F220 File Offset: 0x0013D420
			// (set) Token: 0x060057F1 RID: 22513 RVA: 0x0013F258 File Offset: 0x0013D458
			public unsafe string selectedTrigger
			{
				[CallerCount(1)]
				[CachedScanResults(RefRangeStart = 14016, RefRangeEnd = 14017, XrefRangeStart = 14016, XrefRangeEnd = 14017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ThemeSettings.CustomAnimationTriggers.NativeMethodInfoPtr_get_selectedTrigger_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
				[CallerCount(38)]
				[CachedScanResults(RefRangeStart = 14017, RefRangeEnd = 14055, XrefRangeStart = 14017, XrefRangeEnd = 14055, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				set
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					checked
					{
						IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
						*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ThemeSettings.CustomAnimationTriggers.NativeMethodInfoPtr_set_selectedTrigger_Public_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}
			}

			// Token: 0x1700202C RID: 8236
			// (get) Token: 0x060057F2 RID: 22514 RVA: 0x0013F29C File Offset: 0x0013D49C
			// (set) Token: 0x060057F3 RID: 22515 RVA: 0x0013F2D4 File Offset: 0x0013D4D4
			public unsafe string disabledHighlightedTrigger
			{
				[CallerCount(5)]
				[CachedScanResults(RefRangeStart = 621, RefRangeEnd = 626, XrefRangeStart = 621, XrefRangeEnd = 626, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ThemeSettings.CustomAnimationTriggers.NativeMethodInfoPtr_get_disabledHighlightedTrigger_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
				[CallerCount(23)]
				[CachedScanResults(RefRangeStart = 99340, RefRangeEnd = 99363, XrefRangeStart = 99340, XrefRangeEnd = 99340, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				set
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					checked
					{
						IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
						*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ThemeSettings.CustomAnimationTriggers.NativeMethodInfoPtr_set_disabledHighlightedTrigger_Public_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}
			}

			// Token: 0x060057F4 RID: 22516 RVA: 0x0013F318 File Offset: 0x0013D518
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 99363, XrefRangeEnd = 99367, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe static implicit operator AnimationTriggers(ThemeSettings.CustomAnimationTriggers item)
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(item);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ThemeSettings.CustomAnimationTriggers.NativeMethodInfoPtr_op_Implicit_Public_Static_AnimationTriggers_CustomAnimationTriggers_0, 0, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<AnimationTriggers>(intPtr3) : null;
				}
			}

			// Token: 0x060057F5 RID: 22517 RVA: 0x0003280E File Offset: 0x00030A0E
			public CustomAnimationTriggers(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17002021 RID: 8225
			// (get) Token: 0x060057F6 RID: 22518 RVA: 0x0013F35C File Offset: 0x0013D55C
			// (set) Token: 0x060057F7 RID: 22519 RVA: 0x00032817 File Offset: 0x00030A17
			public unsafe string m_DisabledTrigger
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ThemeSettings.CustomAnimationTriggers.NativeFieldInfoPtr_m_DisabledTrigger);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ThemeSettings.CustomAnimationTriggers.NativeFieldInfoPtr_m_DisabledTrigger), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x17002022 RID: 8226
			// (get) Token: 0x060057F8 RID: 22520 RVA: 0x0013F384 File Offset: 0x0013D584
			// (set) Token: 0x060057F9 RID: 22521 RVA: 0x00032836 File Offset: 0x00030A36
			public unsafe string m_HighlightedTrigger
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ThemeSettings.CustomAnimationTriggers.NativeFieldInfoPtr_m_HighlightedTrigger);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ThemeSettings.CustomAnimationTriggers.NativeFieldInfoPtr_m_HighlightedTrigger), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x17002023 RID: 8227
			// (get) Token: 0x060057FA RID: 22522 RVA: 0x0013F3AC File Offset: 0x0013D5AC
			// (set) Token: 0x060057FB RID: 22523 RVA: 0x00032855 File Offset: 0x00030A55
			public unsafe string m_NormalTrigger
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ThemeSettings.CustomAnimationTriggers.NativeFieldInfoPtr_m_NormalTrigger);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ThemeSettings.CustomAnimationTriggers.NativeFieldInfoPtr_m_NormalTrigger), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x17002024 RID: 8228
			// (get) Token: 0x060057FC RID: 22524 RVA: 0x0013F3D4 File Offset: 0x0013D5D4
			// (set) Token: 0x060057FD RID: 22525 RVA: 0x00032874 File Offset: 0x00030A74
			public unsafe string m_PressedTrigger
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ThemeSettings.CustomAnimationTriggers.NativeFieldInfoPtr_m_PressedTrigger);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ThemeSettings.CustomAnimationTriggers.NativeFieldInfoPtr_m_PressedTrigger), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x17002025 RID: 8229
			// (get) Token: 0x060057FE RID: 22526 RVA: 0x0013F3FC File Offset: 0x0013D5FC
			// (set) Token: 0x060057FF RID: 22527 RVA: 0x00032893 File Offset: 0x00030A93
			public unsafe string m_SelectedTrigger
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ThemeSettings.CustomAnimationTriggers.NativeFieldInfoPtr_m_SelectedTrigger);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ThemeSettings.CustomAnimationTriggers.NativeFieldInfoPtr_m_SelectedTrigger), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x17002026 RID: 8230
			// (get) Token: 0x06005800 RID: 22528 RVA: 0x0013F424 File Offset: 0x0013D624
			// (set) Token: 0x06005801 RID: 22529 RVA: 0x000328B2 File Offset: 0x00030AB2
			public unsafe string m_DisabledHighlightedTrigger
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ThemeSettings.CustomAnimationTriggers.NativeFieldInfoPtr_m_DisabledHighlightedTrigger);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ThemeSettings.CustomAnimationTriggers.NativeFieldInfoPtr_m_DisabledHighlightedTrigger), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x04003A59 RID: 14937
			private static readonly IntPtr NativeFieldInfoPtr_m_DisabledTrigger;

			// Token: 0x04003A5A RID: 14938
			private static readonly IntPtr NativeFieldInfoPtr_m_HighlightedTrigger;

			// Token: 0x04003A5B RID: 14939
			private static readonly IntPtr NativeFieldInfoPtr_m_NormalTrigger;

			// Token: 0x04003A5C RID: 14940
			private static readonly IntPtr NativeFieldInfoPtr_m_PressedTrigger;

			// Token: 0x04003A5D RID: 14941
			private static readonly IntPtr NativeFieldInfoPtr_m_SelectedTrigger;

			// Token: 0x04003A5E RID: 14942
			private static readonly IntPtr NativeFieldInfoPtr_m_DisabledHighlightedTrigger;

			// Token: 0x04003A5F RID: 14943
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04003A60 RID: 14944
			private static readonly IntPtr NativeMethodInfoPtr_get_disabledTrigger_Public_get_String_0;

			// Token: 0x04003A61 RID: 14945
			private static readonly IntPtr NativeMethodInfoPtr_set_disabledTrigger_Public_set_Void_String_0;

			// Token: 0x04003A62 RID: 14946
			private static readonly IntPtr NativeMethodInfoPtr_get_highlightedTrigger_Public_get_String_0;

			// Token: 0x04003A63 RID: 14947
			private static readonly IntPtr NativeMethodInfoPtr_set_highlightedTrigger_Public_set_Void_String_0;

			// Token: 0x04003A64 RID: 14948
			private static readonly IntPtr NativeMethodInfoPtr_get_normalTrigger_Public_get_String_0;

			// Token: 0x04003A65 RID: 14949
			private static readonly IntPtr NativeMethodInfoPtr_set_normalTrigger_Public_set_Void_String_0;

			// Token: 0x04003A66 RID: 14950
			private static readonly IntPtr NativeMethodInfoPtr_get_pressedTrigger_Public_get_String_0;

			// Token: 0x04003A67 RID: 14951
			private static readonly IntPtr NativeMethodInfoPtr_set_pressedTrigger_Public_set_Void_String_0;

			// Token: 0x04003A68 RID: 14952
			private static readonly IntPtr NativeMethodInfoPtr_get_selectedTrigger_Public_get_String_0;

			// Token: 0x04003A69 RID: 14953
			private static readonly IntPtr NativeMethodInfoPtr_set_selectedTrigger_Public_set_Void_String_0;

			// Token: 0x04003A6A RID: 14954
			private static readonly IntPtr NativeMethodInfoPtr_get_disabledHighlightedTrigger_Public_get_String_0;

			// Token: 0x04003A6B RID: 14955
			private static readonly IntPtr NativeMethodInfoPtr_set_disabledHighlightedTrigger_Public_set_Void_String_0;

			// Token: 0x04003A6C RID: 14956
			private static readonly IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_AnimationTriggers_CustomAnimationTriggers_0;
		}

		// Token: 0x02000391 RID: 913
		[Serializable]
		public class TextSettings : global::Il2CppSystem.Object
		{
			// Token: 0x06005802 RID: 22530 RVA: 0x0013F44C File Offset: 0x0013D64C
			// Note: this type is marked as 'beforefieldinit'.
			static TextSettings()
			{
				Il2CppClassPointerStore<ThemeSettings.TextSettings>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ThemeSettings>.NativeClassPtr, "TextSettings");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ThemeSettings.TextSettings>.NativeClassPtr);
				ThemeSettings.TextSettings.NativeFieldInfoPtr__color = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ThemeSettings.TextSettings>.NativeClassPtr, "_color");
				ThemeSettings.TextSettings.NativeFieldInfoPtr__font = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ThemeSettings.TextSettings>.NativeClassPtr, "_font");
				ThemeSettings.TextSettings.NativeFieldInfoPtr__style = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ThemeSettings.TextSettings>.NativeClassPtr, "_style");
				ThemeSettings.TextSettings.NativeFieldInfoPtr__sizeMultiplier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ThemeSettings.TextSettings>.NativeClassPtr, "_sizeMultiplier");
				ThemeSettings.TextSettings.NativeFieldInfoPtr__lineSpacing = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ThemeSettings.TextSettings>.NativeClassPtr, "_lineSpacing");
				ThemeSettings.TextSettings.NativeMethodInfoPtr_get_color_Public_get_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ThemeSettings.TextSettings>.NativeClassPtr, 100669290);
				ThemeSettings.TextSettings.NativeMethodInfoPtr_get_font_Public_get_Font_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ThemeSettings.TextSettings>.NativeClassPtr, 100669291);
				ThemeSettings.TextSettings.NativeMethodInfoPtr_get_style_Public_get_FontStyleOverride_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ThemeSettings.TextSettings>.NativeClassPtr, 100669292);
				ThemeSettings.TextSettings.NativeMethodInfoPtr_get_sizeMultiplier_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ThemeSettings.TextSettings>.NativeClassPtr, 100669293);
				ThemeSettings.TextSettings.NativeMethodInfoPtr_get_lineSpacing_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ThemeSettings.TextSettings>.NativeClassPtr, 100669294);
				ThemeSettings.TextSettings.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ThemeSettings.TextSettings>.NativeClassPtr, 100669295);
			}

			// Token: 0x17002032 RID: 8242
			// (get) Token: 0x06005803 RID: 22531 RVA: 0x0013F554 File Offset: 0x0013D754
			public unsafe Color color
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ThemeSettings.TextSettings.NativeMethodInfoPtr_get_color_Public_get_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x17002033 RID: 8243
			// (get) Token: 0x06005804 RID: 22532 RVA: 0x0013F590 File Offset: 0x0013D790
			public unsafe Font font
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ThemeSettings.TextSettings.NativeMethodInfoPtr_get_font_Public_get_Font_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Font>(intPtr3) : null;
				}
			}

			// Token: 0x17002034 RID: 8244
			// (get) Token: 0x06005805 RID: 22533 RVA: 0x0013F5D0 File Offset: 0x0013D7D0
			public unsafe ThemeSettings.FontStyleOverride style
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ThemeSettings.TextSettings.NativeMethodInfoPtr_get_style_Public_get_FontStyleOverride_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x17002035 RID: 8245
			// (get) Token: 0x06005806 RID: 22534 RVA: 0x0013F60C File Offset: 0x0013D80C
			public unsafe float sizeMultiplier
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ThemeSettings.TextSettings.NativeMethodInfoPtr_get_sizeMultiplier_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x17002036 RID: 8246
			// (get) Token: 0x06005807 RID: 22535 RVA: 0x0013F648 File Offset: 0x0013D848
			public unsafe float lineSpacing
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ThemeSettings.TextSettings.NativeMethodInfoPtr_get_lineSpacing_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06005808 RID: 22536 RVA: 0x0013F684 File Offset: 0x0013D884
			[CallerCount(0)]
			public unsafe TextSettings()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ThemeSettings.TextSettings>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ThemeSettings.TextSettings.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06005809 RID: 22537 RVA: 0x000328D1 File Offset: 0x00030AD1
			public TextSettings(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700202D RID: 8237
			// (get) Token: 0x0600580A RID: 22538 RVA: 0x0013F6C0 File Offset: 0x0013D8C0
			// (set) Token: 0x0600580B RID: 22539 RVA: 0x000328DA File Offset: 0x00030ADA
			public unsafe Color _color
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ThemeSettings.TextSettings.NativeFieldInfoPtr__color);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ThemeSettings.TextSettings.NativeFieldInfoPtr__color)) = value;
				}
			}

			// Token: 0x1700202E RID: 8238
			// (get) Token: 0x0600580C RID: 22540 RVA: 0x0013F6E8 File Offset: 0x0013D8E8
			// (set) Token: 0x0600580D RID: 22541 RVA: 0x000328F5 File Offset: 0x00030AF5
			public unsafe Font _font
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ThemeSettings.TextSettings.NativeFieldInfoPtr__font);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Font>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ThemeSettings.TextSettings.NativeFieldInfoPtr__font), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700202F RID: 8239
			// (get) Token: 0x0600580E RID: 22542 RVA: 0x0013F718 File Offset: 0x0013D918
			// (set) Token: 0x0600580F RID: 22543 RVA: 0x00032914 File Offset: 0x00030B14
			public unsafe ThemeSettings.FontStyleOverride _style
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ThemeSettings.TextSettings.NativeFieldInfoPtr__style);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ThemeSettings.TextSettings.NativeFieldInfoPtr__style)) = value;
				}
			}

			// Token: 0x17002030 RID: 8240
			// (get) Token: 0x06005810 RID: 22544 RVA: 0x0013F740 File Offset: 0x0013D940
			// (set) Token: 0x06005811 RID: 22545 RVA: 0x0003292F File Offset: 0x00030B2F
			public unsafe float _sizeMultiplier
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ThemeSettings.TextSettings.NativeFieldInfoPtr__sizeMultiplier);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ThemeSettings.TextSettings.NativeFieldInfoPtr__sizeMultiplier)) = value;
				}
			}

			// Token: 0x17002031 RID: 8241
			// (get) Token: 0x06005812 RID: 22546 RVA: 0x0013F768 File Offset: 0x0013D968
			// (set) Token: 0x06005813 RID: 22547 RVA: 0x0003294A File Offset: 0x00030B4A
			public unsafe float _lineSpacing
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ThemeSettings.TextSettings.NativeFieldInfoPtr__lineSpacing);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ThemeSettings.TextSettings.NativeFieldInfoPtr__lineSpacing)) = value;
				}
			}

			// Token: 0x04003A6D RID: 14957
			private static readonly IntPtr NativeFieldInfoPtr__color;

			// Token: 0x04003A6E RID: 14958
			private static readonly IntPtr NativeFieldInfoPtr__font;

			// Token: 0x04003A6F RID: 14959
			private static readonly IntPtr NativeFieldInfoPtr__style;

			// Token: 0x04003A70 RID: 14960
			private static readonly IntPtr NativeFieldInfoPtr__sizeMultiplier;

			// Token: 0x04003A71 RID: 14961
			private static readonly IntPtr NativeFieldInfoPtr__lineSpacing;

			// Token: 0x04003A72 RID: 14962
			private static readonly IntPtr NativeMethodInfoPtr_get_color_Public_get_Color_0;

			// Token: 0x04003A73 RID: 14963
			private static readonly IntPtr NativeMethodInfoPtr_get_font_Public_get_Font_0;

			// Token: 0x04003A74 RID: 14964
			private static readonly IntPtr NativeMethodInfoPtr_get_style_Public_get_FontStyleOverride_0;

			// Token: 0x04003A75 RID: 14965
			private static readonly IntPtr NativeMethodInfoPtr_get_sizeMultiplier_Public_get_Single_0;

			// Token: 0x04003A76 RID: 14966
			private static readonly IntPtr NativeMethodInfoPtr_get_lineSpacing_Public_get_Single_0;

			// Token: 0x04003A77 RID: 14967
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x02000392 RID: 914
		[OriginalName("Assembly-CSharp.dll", "", "FontStyleOverride")]
		public enum FontStyleOverride
		{
			// Token: 0x04003A79 RID: 14969
			Default,
			// Token: 0x04003A7A RID: 14970
			Normal,
			// Token: 0x04003A7B RID: 14971
			Bold,
			// Token: 0x04003A7C RID: 14972
			Italic,
			// Token: 0x04003A7D RID: 14973
			BoldAndItalic
		}
	}
}
