using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine
{
	// Token: 0x02000017 RID: 23
	public class GUILayoutEntry : Object
	{
		// Token: 0x06000482 RID: 1154 RVA: 0x00012B60 File Offset: 0x00010D60
		// Note: this type is marked as 'beforefieldinit'.
		static GUILayoutEntry()
		{
			Il2CppClassPointerStore<GUILayoutEntry>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.IMGUIModule.dll", "UnityEngine", "GUILayoutEntry");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GUILayoutEntry>.NativeClassPtr);
			GUILayoutEntry.NativeFieldInfoPtr_minWidth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GUILayoutEntry>.NativeClassPtr, "minWidth");
			GUILayoutEntry.NativeFieldInfoPtr_maxWidth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GUILayoutEntry>.NativeClassPtr, "maxWidth");
			GUILayoutEntry.NativeFieldInfoPtr_minHeight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GUILayoutEntry>.NativeClassPtr, "minHeight");
			GUILayoutEntry.NativeFieldInfoPtr_maxHeight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GUILayoutEntry>.NativeClassPtr, "maxHeight");
			GUILayoutEntry.NativeFieldInfoPtr_rect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GUILayoutEntry>.NativeClassPtr, "rect");
			GUILayoutEntry.NativeFieldInfoPtr_stretchWidth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GUILayoutEntry>.NativeClassPtr, "stretchWidth");
			GUILayoutEntry.NativeFieldInfoPtr_stretchHeight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GUILayoutEntry>.NativeClassPtr, "stretchHeight");
			GUILayoutEntry.NativeFieldInfoPtr_consideredForMargin = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GUILayoutEntry>.NativeClassPtr, "consideredForMargin");
			GUILayoutEntry.NativeFieldInfoPtr_m_Style = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GUILayoutEntry>.NativeClassPtr, "m_Style");
			GUILayoutEntry.NativeFieldInfoPtr_kDummyRect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GUILayoutEntry>.NativeClassPtr, "kDummyRect");
			GUILayoutEntry.NativeFieldInfoPtr_indent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GUILayoutEntry>.NativeClassPtr, "indent");
			GUILayoutEntry.NativeMethodInfoPtr_get_style_Public_get_GUIStyle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUILayoutEntry>.NativeClassPtr, 100663712);
			GUILayoutEntry.NativeMethodInfoPtr_set_style_Public_set_Void_GUIStyle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUILayoutEntry>.NativeClassPtr, 100663713);
			GUILayoutEntry.NativeMethodInfoPtr_get_marginLeft_Public_Virtual_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUILayoutEntry>.NativeClassPtr, 100663714);
			GUILayoutEntry.NativeMethodInfoPtr_get_marginRight_Public_Virtual_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUILayoutEntry>.NativeClassPtr, 100663715);
			GUILayoutEntry.NativeMethodInfoPtr_get_marginTop_Public_Virtual_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUILayoutEntry>.NativeClassPtr, 100663716);
			GUILayoutEntry.NativeMethodInfoPtr_get_marginBottom_Public_Virtual_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUILayoutEntry>.NativeClassPtr, 100663717);
			GUILayoutEntry.NativeMethodInfoPtr_get_marginHorizontal_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUILayoutEntry>.NativeClassPtr, 100663718);
			GUILayoutEntry.NativeMethodInfoPtr_get_marginVertical_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUILayoutEntry>.NativeClassPtr, 100663719);
			GUILayoutEntry.NativeMethodInfoPtr__ctor_Public_Void_Single_Single_Single_Single_GUIStyle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUILayoutEntry>.NativeClassPtr, 100663720);
			GUILayoutEntry.NativeMethodInfoPtr__ctor_Public_Void_Single_Single_Single_Single_GUIStyle_Il2CppReferenceArray_1_GUILayoutOption_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUILayoutEntry>.NativeClassPtr, 100663721);
			GUILayoutEntry.NativeMethodInfoPtr_CalcWidth_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUILayoutEntry>.NativeClassPtr, 100663722);
			GUILayoutEntry.NativeMethodInfoPtr_CalcHeight_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUILayoutEntry>.NativeClassPtr, 100663723);
			GUILayoutEntry.NativeMethodInfoPtr_SetHorizontal_Public_Virtual_New_Void_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUILayoutEntry>.NativeClassPtr, 100663724);
			GUILayoutEntry.NativeMethodInfoPtr_SetVertical_Public_Virtual_New_Void_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUILayoutEntry>.NativeClassPtr, 100663725);
			GUILayoutEntry.NativeMethodInfoPtr_ApplyStyleSettings_Protected_Virtual_New_Void_GUIStyle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUILayoutEntry>.NativeClassPtr, 100663726);
			GUILayoutEntry.NativeMethodInfoPtr_ApplyOptions_Public_Virtual_New_Void_Il2CppReferenceArray_1_GUILayoutOption_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUILayoutEntry>.NativeClassPtr, 100663727);
			GUILayoutEntry.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUILayoutEntry>.NativeClassPtr, 100663728);
		}

		// Token: 0x170000F4 RID: 244
		// (get) Token: 0x06000483 RID: 1155 RVA: 0x00012DC0 File Offset: 0x00010FC0
		// (set) Token: 0x06000484 RID: 1156 RVA: 0x00012E00 File Offset: 0x00011000
		public unsafe GUIStyle style
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUILayoutEntry.NativeMethodInfoPtr_get_style_Public_get_GUIStyle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<GUIStyle>(intPtr3) : null;
			}
			[CallerCount(5)]
			[CachedScanResults(RefRangeStart = 509701, RefRangeEnd = 509706, XrefRangeStart = 509701, XrefRangeEnd = 509701, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUILayoutEntry.NativeMethodInfoPtr_set_style_Public_set_Void_GUIStyle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170000F5 RID: 245
		// (get) Token: 0x06000485 RID: 1157 RVA: 0x00012E44 File Offset: 0x00011044
		public unsafe virtual int marginLeft
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 509706, XrefRangeEnd = 509712, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GUILayoutEntry.NativeMethodInfoPtr_get_marginLeft_Public_Virtual_New_get_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170000F6 RID: 246
		// (get) Token: 0x06000486 RID: 1158 RVA: 0x00012E8C File Offset: 0x0001108C
		public unsafe virtual int marginRight
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 509712, XrefRangeEnd = 509718, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GUILayoutEntry.NativeMethodInfoPtr_get_marginRight_Public_Virtual_New_get_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170000F7 RID: 247
		// (get) Token: 0x06000487 RID: 1159 RVA: 0x00012ED4 File Offset: 0x000110D4
		public unsafe virtual int marginTop
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 509718, XrefRangeEnd = 509724, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GUILayoutEntry.NativeMethodInfoPtr_get_marginTop_Public_Virtual_New_get_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170000F8 RID: 248
		// (get) Token: 0x06000488 RID: 1160 RVA: 0x00012F1C File Offset: 0x0001111C
		public unsafe virtual int marginBottom
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 509724, XrefRangeEnd = 509730, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GUILayoutEntry.NativeMethodInfoPtr_get_marginBottom_Public_Virtual_New_get_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170000F9 RID: 249
		// (get) Token: 0x06000489 RID: 1161 RVA: 0x00012F64 File Offset: 0x00011164
		public unsafe int marginHorizontal
		{
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 509730, RefRangeEnd = 509734, XrefRangeStart = 509730, XrefRangeEnd = 509730, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUILayoutEntry.NativeMethodInfoPtr_get_marginHorizontal_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170000FA RID: 250
		// (get) Token: 0x0600048A RID: 1162 RVA: 0x00012FA0 File Offset: 0x000111A0
		public unsafe int marginVertical
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 509734, RefRangeEnd = 509736, XrefRangeStart = 509734, XrefRangeEnd = 509734, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUILayoutEntry.NativeMethodInfoPtr_get_marginVertical_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600048B RID: 1163 RVA: 0x00012FDC File Offset: 0x000111DC
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 509744, RefRangeEnd = 509747, XrefRangeStart = 509736, XrefRangeEnd = 509744, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe GUILayoutEntry(float _minWidth, float _maxWidth, float _minHeight, float _maxHeight, GUIStyle _style)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GUILayoutEntry>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref _minWidth;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref _maxWidth;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref _minHeight;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref _maxHeight;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(_style);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUILayoutEntry.NativeMethodInfoPtr__ctor_Public_Void_Single_Single_Single_Single_GUIStyle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600048C RID: 1164 RVA: 0x00013060 File Offset: 0x00011260
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 509752, RefRangeEnd = 509754, XrefRangeStart = 509747, XrefRangeEnd = 509752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe GUILayoutEntry(float _minWidth, float _maxWidth, float _minHeight, float _maxHeight, GUIStyle _style, Il2CppReferenceArray<GUILayoutOption> options)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GUILayoutEntry>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref _minWidth;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref _maxWidth;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref _minHeight;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref _maxHeight;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(_style);
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(options);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUILayoutEntry.NativeMethodInfoPtr__ctor_Public_Void_Single_Single_Single_Single_GUIStyle_Il2CppReferenceArray_1_GUILayoutOption_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600048D RID: 1165 RVA: 0x000130F8 File Offset: 0x000112F8
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void CalcWidth()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GUILayoutEntry.NativeMethodInfoPtr_CalcWidth_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600048E RID: 1166 RVA: 0x00013134 File Offset: 0x00011334
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void CalcHeight()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GUILayoutEntry.NativeMethodInfoPtr_CalcHeight_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600048F RID: 1167 RVA: 0x00013170 File Offset: 0x00011370
		[CallerCount(0)]
		public unsafe virtual void SetHorizontal(float x, float width)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref x;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref width;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GUILayoutEntry.NativeMethodInfoPtr_SetHorizontal_Public_Virtual_New_Void_Single_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000490 RID: 1168 RVA: 0x000131C8 File Offset: 0x000113C8
		[CallerCount(0)]
		public unsafe virtual void SetVertical(float y, float height)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref y;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref height;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GUILayoutEntry.NativeMethodInfoPtr_SetVertical_Public_Virtual_New_Void_Single_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000491 RID: 1169 RVA: 0x00013220 File Offset: 0x00011420
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 509763, RefRangeEnd = 509764, XrefRangeStart = 509754, XrefRangeEnd = 509763, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void ApplyStyleSettings(GUIStyle style)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(style);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GUILayoutEntry.NativeMethodInfoPtr_ApplyStyleSettings_Protected_Virtual_New_Void_GUIStyle_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000492 RID: 1170 RVA: 0x00013270 File Offset: 0x00011470
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 509782, RefRangeEnd = 509783, XrefRangeStart = 509764, XrefRangeEnd = 509782, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void ApplyOptions(Il2CppReferenceArray<GUILayoutOption> options)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(options);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GUILayoutEntry.NativeMethodInfoPtr_ApplyOptions_Public_Virtual_New_Void_Il2CppReferenceArray_1_GUILayoutOption_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000493 RID: 1171 RVA: 0x000132C0 File Offset: 0x000114C0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 509947, RefRangeEnd = 509948, XrefRangeStart = 509783, XrefRangeEnd = 509947, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GUILayoutEntry.NativeMethodInfoPtr_ToString_Public_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000494 RID: 1172 RVA: 0x00003BC5 File Offset: 0x00001DC5
		public GUILayoutEntry(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170000E9 RID: 233
		// (get) Token: 0x06000495 RID: 1173 RVA: 0x00013304 File Offset: 0x00011504
		// (set) Token: 0x06000496 RID: 1174 RVA: 0x00003BCE File Offset: 0x00001DCE
		public unsafe float minWidth
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GUILayoutEntry.NativeFieldInfoPtr_minWidth);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GUILayoutEntry.NativeFieldInfoPtr_minWidth)) = value;
			}
		}

		// Token: 0x170000EA RID: 234
		// (get) Token: 0x06000497 RID: 1175 RVA: 0x0001332C File Offset: 0x0001152C
		// (set) Token: 0x06000498 RID: 1176 RVA: 0x00003BE9 File Offset: 0x00001DE9
		public unsafe float maxWidth
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GUILayoutEntry.NativeFieldInfoPtr_maxWidth);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GUILayoutEntry.NativeFieldInfoPtr_maxWidth)) = value;
			}
		}

		// Token: 0x170000EB RID: 235
		// (get) Token: 0x06000499 RID: 1177 RVA: 0x00013354 File Offset: 0x00011554
		// (set) Token: 0x0600049A RID: 1178 RVA: 0x00003C04 File Offset: 0x00001E04
		public unsafe float minHeight
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GUILayoutEntry.NativeFieldInfoPtr_minHeight);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GUILayoutEntry.NativeFieldInfoPtr_minHeight)) = value;
			}
		}

		// Token: 0x170000EC RID: 236
		// (get) Token: 0x0600049B RID: 1179 RVA: 0x0001337C File Offset: 0x0001157C
		// (set) Token: 0x0600049C RID: 1180 RVA: 0x00003C1F File Offset: 0x00001E1F
		public unsafe float maxHeight
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GUILayoutEntry.NativeFieldInfoPtr_maxHeight);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GUILayoutEntry.NativeFieldInfoPtr_maxHeight)) = value;
			}
		}

		// Token: 0x170000ED RID: 237
		// (get) Token: 0x0600049D RID: 1181 RVA: 0x000133A4 File Offset: 0x000115A4
		// (set) Token: 0x0600049E RID: 1182 RVA: 0x00003C3A File Offset: 0x00001E3A
		public unsafe Rect rect
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GUILayoutEntry.NativeFieldInfoPtr_rect);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GUILayoutEntry.NativeFieldInfoPtr_rect)) = value;
			}
		}

		// Token: 0x170000EE RID: 238
		// (get) Token: 0x0600049F RID: 1183 RVA: 0x000133CC File Offset: 0x000115CC
		// (set) Token: 0x060004A0 RID: 1184 RVA: 0x00003C55 File Offset: 0x00001E55
		public unsafe int stretchWidth
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GUILayoutEntry.NativeFieldInfoPtr_stretchWidth);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GUILayoutEntry.NativeFieldInfoPtr_stretchWidth)) = value;
			}
		}

		// Token: 0x170000EF RID: 239
		// (get) Token: 0x060004A1 RID: 1185 RVA: 0x000133F4 File Offset: 0x000115F4
		// (set) Token: 0x060004A2 RID: 1186 RVA: 0x00003C70 File Offset: 0x00001E70
		public unsafe int stretchHeight
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GUILayoutEntry.NativeFieldInfoPtr_stretchHeight);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GUILayoutEntry.NativeFieldInfoPtr_stretchHeight)) = value;
			}
		}

		// Token: 0x170000F0 RID: 240
		// (get) Token: 0x060004A3 RID: 1187 RVA: 0x0001341C File Offset: 0x0001161C
		// (set) Token: 0x060004A4 RID: 1188 RVA: 0x00003C8B File Offset: 0x00001E8B
		public unsafe bool consideredForMargin
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GUILayoutEntry.NativeFieldInfoPtr_consideredForMargin);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GUILayoutEntry.NativeFieldInfoPtr_consideredForMargin)) = value;
			}
		}

		// Token: 0x170000F1 RID: 241
		// (get) Token: 0x060004A5 RID: 1189 RVA: 0x00013444 File Offset: 0x00011644
		// (set) Token: 0x060004A6 RID: 1190 RVA: 0x00003CA6 File Offset: 0x00001EA6
		public unsafe GUIStyle m_Style
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GUILayoutEntry.NativeFieldInfoPtr_m_Style);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GUIStyle>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GUILayoutEntry.NativeFieldInfoPtr_m_Style), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000F2 RID: 242
		// (get) Token: 0x060004A7 RID: 1191 RVA: 0x00013474 File Offset: 0x00011674
		// (set) Token: 0x060004A8 RID: 1192 RVA: 0x00003CC5 File Offset: 0x00001EC5
		public unsafe static Rect kDummyRect
		{
			get
			{
				Rect rect;
				IL2CPP.il2cpp_field_static_get_value(GUILayoutEntry.NativeFieldInfoPtr_kDummyRect, (void*)(&rect));
				return rect;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(GUILayoutEntry.NativeFieldInfoPtr_kDummyRect, (void*)(&value));
			}
		}

		// Token: 0x170000F3 RID: 243
		// (get) Token: 0x060004A9 RID: 1193 RVA: 0x00013490 File Offset: 0x00011690
		// (set) Token: 0x060004AA RID: 1194 RVA: 0x00003CD3 File Offset: 0x00001ED3
		public unsafe static int indent
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(GUILayoutEntry.NativeFieldInfoPtr_indent, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(GUILayoutEntry.NativeFieldInfoPtr_indent, (void*)(&value));
			}
		}

		// Token: 0x04000294 RID: 660
		private static readonly IntPtr NativeFieldInfoPtr_minWidth;

		// Token: 0x04000295 RID: 661
		private static readonly IntPtr NativeFieldInfoPtr_maxWidth;

		// Token: 0x04000296 RID: 662
		private static readonly IntPtr NativeFieldInfoPtr_minHeight;

		// Token: 0x04000297 RID: 663
		private static readonly IntPtr NativeFieldInfoPtr_maxHeight;

		// Token: 0x04000298 RID: 664
		private static readonly IntPtr NativeFieldInfoPtr_rect;

		// Token: 0x04000299 RID: 665
		private static readonly IntPtr NativeFieldInfoPtr_stretchWidth;

		// Token: 0x0400029A RID: 666
		private static readonly IntPtr NativeFieldInfoPtr_stretchHeight;

		// Token: 0x0400029B RID: 667
		private static readonly IntPtr NativeFieldInfoPtr_consideredForMargin;

		// Token: 0x0400029C RID: 668
		private static readonly IntPtr NativeFieldInfoPtr_m_Style;

		// Token: 0x0400029D RID: 669
		private static readonly IntPtr NativeFieldInfoPtr_kDummyRect;

		// Token: 0x0400029E RID: 670
		private static readonly IntPtr NativeFieldInfoPtr_indent;

		// Token: 0x0400029F RID: 671
		private static readonly IntPtr NativeMethodInfoPtr_get_style_Public_get_GUIStyle_0;

		// Token: 0x040002A0 RID: 672
		private static readonly IntPtr NativeMethodInfoPtr_set_style_Public_set_Void_GUIStyle_0;

		// Token: 0x040002A1 RID: 673
		private static readonly IntPtr NativeMethodInfoPtr_get_marginLeft_Public_Virtual_New_get_Int32_0;

		// Token: 0x040002A2 RID: 674
		private static readonly IntPtr NativeMethodInfoPtr_get_marginRight_Public_Virtual_New_get_Int32_0;

		// Token: 0x040002A3 RID: 675
		private static readonly IntPtr NativeMethodInfoPtr_get_marginTop_Public_Virtual_New_get_Int32_0;

		// Token: 0x040002A4 RID: 676
		private static readonly IntPtr NativeMethodInfoPtr_get_marginBottom_Public_Virtual_New_get_Int32_0;

		// Token: 0x040002A5 RID: 677
		private static readonly IntPtr NativeMethodInfoPtr_get_marginHorizontal_Public_get_Int32_0;

		// Token: 0x040002A6 RID: 678
		private static readonly IntPtr NativeMethodInfoPtr_get_marginVertical_Public_get_Int32_0;

		// Token: 0x040002A7 RID: 679
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Single_Single_Single_Single_GUIStyle_0;

		// Token: 0x040002A8 RID: 680
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Single_Single_Single_Single_GUIStyle_Il2CppReferenceArray_1_GUILayoutOption_0;

		// Token: 0x040002A9 RID: 681
		private static readonly IntPtr NativeMethodInfoPtr_CalcWidth_Public_Virtual_New_Void_0;

		// Token: 0x040002AA RID: 682
		private static readonly IntPtr NativeMethodInfoPtr_CalcHeight_Public_Virtual_New_Void_0;

		// Token: 0x040002AB RID: 683
		private static readonly IntPtr NativeMethodInfoPtr_SetHorizontal_Public_Virtual_New_Void_Single_Single_0;

		// Token: 0x040002AC RID: 684
		private static readonly IntPtr NativeMethodInfoPtr_SetVertical_Public_Virtual_New_Void_Single_Single_0;

		// Token: 0x040002AD RID: 685
		private static readonly IntPtr NativeMethodInfoPtr_ApplyStyleSettings_Protected_Virtual_New_Void_GUIStyle_0;

		// Token: 0x040002AE RID: 686
		private static readonly IntPtr NativeMethodInfoPtr_ApplyOptions_Public_Virtual_New_Void_Il2CppReferenceArray_1_GUILayoutOption_0;

		// Token: 0x040002AF RID: 687
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;
	}
}
