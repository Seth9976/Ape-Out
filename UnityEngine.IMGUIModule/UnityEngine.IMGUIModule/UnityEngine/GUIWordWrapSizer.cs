using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;

namespace UnityEngine
{
	// Token: 0x02000018 RID: 24
	public sealed class GUIWordWrapSizer : GUILayoutEntry
	{
		// Token: 0x060004AB RID: 1195 RVA: 0x000134AC File Offset: 0x000116AC
		// Note: this type is marked as 'beforefieldinit'.
		static GUIWordWrapSizer()
		{
			Il2CppClassPointerStore<GUIWordWrapSizer>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.IMGUIModule.dll", "UnityEngine", "GUIWordWrapSizer");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GUIWordWrapSizer>.NativeClassPtr);
			GUIWordWrapSizer.NativeFieldInfoPtr_m_Content = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GUIWordWrapSizer>.NativeClassPtr, "m_Content");
			GUIWordWrapSizer.NativeFieldInfoPtr_m_ForcedMinHeight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GUIWordWrapSizer>.NativeClassPtr, "m_ForcedMinHeight");
			GUIWordWrapSizer.NativeFieldInfoPtr_m_ForcedMaxHeight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GUIWordWrapSizer>.NativeClassPtr, "m_ForcedMaxHeight");
			GUIWordWrapSizer.NativeMethodInfoPtr__ctor_Public_Void_GUIStyle_GUIContent_Il2CppReferenceArray_1_GUILayoutOption_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUIWordWrapSizer>.NativeClassPtr, 100663730);
			GUIWordWrapSizer.NativeMethodInfoPtr_CalcWidth_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUIWordWrapSizer>.NativeClassPtr, 100663731);
			GUIWordWrapSizer.NativeMethodInfoPtr_CalcHeight_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUIWordWrapSizer>.NativeClassPtr, 100663732);
		}

		// Token: 0x060004AC RID: 1196 RVA: 0x00013554 File Offset: 0x00011754
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 509948, XrefRangeEnd = 509956, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe GUIWordWrapSizer(GUIStyle style, GUIContent content, Il2CppReferenceArray<GUILayoutOption> options)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GUIWordWrapSizer>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(style);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(content);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(options);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUIWordWrapSizer.NativeMethodInfoPtr__ctor_Public_Void_GUIStyle_GUIContent_Il2CppReferenceArray_1_GUILayoutOption_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060004AD RID: 1197 RVA: 0x000135C4 File Offset: 0x000117C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 509956, XrefRangeEnd = 509960, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void CalcWidth()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUIWordWrapSizer.NativeMethodInfoPtr_CalcWidth_Public_Virtual_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060004AE RID: 1198 RVA: 0x000135F8 File Offset: 0x000117F8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 509960, XrefRangeEnd = 509961, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void CalcHeight()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUIWordWrapSizer.NativeMethodInfoPtr_CalcHeight_Public_Virtual_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060004AF RID: 1199 RVA: 0x00003CE1 File Offset: 0x00001EE1
		public GUIWordWrapSizer(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170000FB RID: 251
		// (get) Token: 0x060004B0 RID: 1200 RVA: 0x0001362C File Offset: 0x0001182C
		// (set) Token: 0x060004B1 RID: 1201 RVA: 0x00003CEA File Offset: 0x00001EEA
		public unsafe GUIContent m_Content
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GUIWordWrapSizer.NativeFieldInfoPtr_m_Content);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GUIContent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GUIWordWrapSizer.NativeFieldInfoPtr_m_Content), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000FC RID: 252
		// (get) Token: 0x060004B2 RID: 1202 RVA: 0x0001365C File Offset: 0x0001185C
		// (set) Token: 0x060004B3 RID: 1203 RVA: 0x00003D09 File Offset: 0x00001F09
		public unsafe float m_ForcedMinHeight
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GUIWordWrapSizer.NativeFieldInfoPtr_m_ForcedMinHeight);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GUIWordWrapSizer.NativeFieldInfoPtr_m_ForcedMinHeight)) = value;
			}
		}

		// Token: 0x170000FD RID: 253
		// (get) Token: 0x060004B4 RID: 1204 RVA: 0x00013684 File Offset: 0x00011884
		// (set) Token: 0x060004B5 RID: 1205 RVA: 0x00003D24 File Offset: 0x00001F24
		public unsafe float m_ForcedMaxHeight
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GUIWordWrapSizer.NativeFieldInfoPtr_m_ForcedMaxHeight);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GUIWordWrapSizer.NativeFieldInfoPtr_m_ForcedMaxHeight)) = value;
			}
		}

		// Token: 0x040002B0 RID: 688
		private static readonly IntPtr NativeFieldInfoPtr_m_Content;

		// Token: 0x040002B1 RID: 689
		private static readonly IntPtr NativeFieldInfoPtr_m_ForcedMinHeight;

		// Token: 0x040002B2 RID: 690
		private static readonly IntPtr NativeFieldInfoPtr_m_ForcedMaxHeight;

		// Token: 0x040002B3 RID: 691
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_GUIStyle_GUIContent_Il2CppReferenceArray_1_GUILayoutOption_0;

		// Token: 0x040002B4 RID: 692
		private static readonly IntPtr NativeMethodInfoPtr_CalcWidth_Public_Virtual_Void_0;

		// Token: 0x040002B5 RID: 693
		private static readonly IntPtr NativeMethodInfoPtr_CalcHeight_Public_Virtual_Void_0;
	}
}
