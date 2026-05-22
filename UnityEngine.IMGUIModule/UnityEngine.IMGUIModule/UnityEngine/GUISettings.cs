using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine
{
	// Token: 0x0200000E RID: 14
	[Serializable]
	public sealed class GUISettings : Object
	{
		// Token: 0x060002B3 RID: 691 RVA: 0x0000C458 File Offset: 0x0000A658
		// Note: this type is marked as 'beforefieldinit'.
		static GUISettings()
		{
			Il2CppClassPointerStore<GUISettings>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.IMGUIModule.dll", "UnityEngine", "GUISettings");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GUISettings>.NativeClassPtr);
			GUISettings.NativeFieldInfoPtr_m_DoubleClickSelectsWord = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GUISettings>.NativeClassPtr, "m_DoubleClickSelectsWord");
			GUISettings.NativeFieldInfoPtr_m_TripleClickSelectsLine = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GUISettings>.NativeClassPtr, "m_TripleClickSelectsLine");
			GUISettings.NativeFieldInfoPtr_m_CursorColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GUISettings>.NativeClassPtr, "m_CursorColor");
			GUISettings.NativeFieldInfoPtr_m_CursorFlashSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GUISettings>.NativeClassPtr, "m_CursorFlashSpeed");
			GUISettings.NativeFieldInfoPtr_m_SelectionColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GUISettings>.NativeClassPtr, "m_SelectionColor");
			GUISettings.NativeMethodInfoPtr_Internal_GetCursorFlashSpeed_Private_Static_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUISettings>.NativeClassPtr, 100663495);
			GUISettings.NativeMethodInfoPtr_get_doubleClickSelectsWord_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUISettings>.NativeClassPtr, 100663496);
			GUISettings.NativeMethodInfoPtr_get_tripleClickSelectsLine_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUISettings>.NativeClassPtr, 100663497);
			GUISettings.NativeMethodInfoPtr_get_cursorColor_Public_get_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUISettings>.NativeClassPtr, 100663498);
			GUISettings.NativeMethodInfoPtr_get_cursorFlashSpeed_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUISettings>.NativeClassPtr, 100663499);
			GUISettings.NativeMethodInfoPtr_get_selectionColor_Public_get_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUISettings>.NativeClassPtr, 100663500);
			GUISettings.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUISettings>.NativeClassPtr, 100663501);
		}

		// Token: 0x060002B4 RID: 692 RVA: 0x0000C578 File Offset: 0x0000A778
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 508249, XrefRangeEnd = 508253, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static float Internal_GetCursorFlashSpeed()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUISettings.NativeMethodInfoPtr_Internal_GetCursorFlashSpeed_Private_Static_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x1700005D RID: 93
		// (get) Token: 0x060002B5 RID: 693 RVA: 0x0000C5A8 File Offset: 0x0000A7A8
		// (set) Token: 0x060002C6 RID: 710 RVA: 0x000030F7 File Offset: 0x000012F7
		public unsafe bool doubleClickSelectsWord
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUISettings.NativeMethodInfoPtr_get_doubleClickSelectsWord_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			set
			{
				this.m_DoubleClickSelectsWord = value;
			}
		}

		// Token: 0x1700005E RID: 94
		// (get) Token: 0x060002B6 RID: 694 RVA: 0x0000C5E4 File Offset: 0x0000A7E4
		// (set) Token: 0x060002C7 RID: 711 RVA: 0x00003101 File Offset: 0x00001301
		public unsafe bool tripleClickSelectsLine
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUISettings.NativeMethodInfoPtr_get_tripleClickSelectsLine_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			set
			{
				this.m_TripleClickSelectsLine = value;
			}
		}

		// Token: 0x1700005F RID: 95
		// (get) Token: 0x060002B7 RID: 695 RVA: 0x0000C620 File Offset: 0x0000A820
		// (set) Token: 0x060002C8 RID: 712 RVA: 0x0000310B File Offset: 0x0000130B
		public unsafe Color cursorColor
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUISettings.NativeMethodInfoPtr_get_cursorColor_Public_get_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			set
			{
				this.m_CursorColor = value;
			}
		}

		// Token: 0x17000060 RID: 96
		// (get) Token: 0x060002B8 RID: 696 RVA: 0x0000C65C File Offset: 0x0000A85C
		// (set) Token: 0x060002C9 RID: 713 RVA: 0x00003115 File Offset: 0x00001315
		public unsafe float cursorFlashSpeed
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 508253, XrefRangeEnd = 508255, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUISettings.NativeMethodInfoPtr_get_cursorFlashSpeed_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			set
			{
				this.m_CursorFlashSpeed = value;
			}
		}

		// Token: 0x17000061 RID: 97
		// (get) Token: 0x060002B9 RID: 697 RVA: 0x0000C698 File Offset: 0x0000A898
		// (set) Token: 0x060002CA RID: 714 RVA: 0x0000311F File Offset: 0x0000131F
		public unsafe Color selectionColor
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUISettings.NativeMethodInfoPtr_get_selectionColor_Public_get_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			set
			{
				this.m_SelectionColor = value;
			}
		}

		// Token: 0x060002BA RID: 698 RVA: 0x0000C6D4 File Offset: 0x0000A8D4
		[CallerCount(0)]
		public unsafe GUISettings()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GUISettings>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUISettings.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060002BB RID: 699 RVA: 0x00003067 File Offset: 0x00001267
		public GUISettings(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000058 RID: 88
		// (get) Token: 0x060002BC RID: 700 RVA: 0x0000C710 File Offset: 0x0000A910
		// (set) Token: 0x060002BD RID: 701 RVA: 0x00003070 File Offset: 0x00001270
		public unsafe bool m_DoubleClickSelectsWord
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GUISettings.NativeFieldInfoPtr_m_DoubleClickSelectsWord);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GUISettings.NativeFieldInfoPtr_m_DoubleClickSelectsWord)) = value;
			}
		}

		// Token: 0x17000059 RID: 89
		// (get) Token: 0x060002BE RID: 702 RVA: 0x0000C738 File Offset: 0x0000A938
		// (set) Token: 0x060002BF RID: 703 RVA: 0x0000308B File Offset: 0x0000128B
		public unsafe bool m_TripleClickSelectsLine
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GUISettings.NativeFieldInfoPtr_m_TripleClickSelectsLine);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GUISettings.NativeFieldInfoPtr_m_TripleClickSelectsLine)) = value;
			}
		}

		// Token: 0x1700005A RID: 90
		// (get) Token: 0x060002C0 RID: 704 RVA: 0x0000C760 File Offset: 0x0000A960
		// (set) Token: 0x060002C1 RID: 705 RVA: 0x000030A6 File Offset: 0x000012A6
		public unsafe Color m_CursorColor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GUISettings.NativeFieldInfoPtr_m_CursorColor);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GUISettings.NativeFieldInfoPtr_m_CursorColor)) = value;
			}
		}

		// Token: 0x1700005B RID: 91
		// (get) Token: 0x060002C2 RID: 706 RVA: 0x0000C788 File Offset: 0x0000A988
		// (set) Token: 0x060002C3 RID: 707 RVA: 0x000030C1 File Offset: 0x000012C1
		public unsafe float m_CursorFlashSpeed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GUISettings.NativeFieldInfoPtr_m_CursorFlashSpeed);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GUISettings.NativeFieldInfoPtr_m_CursorFlashSpeed)) = value;
			}
		}

		// Token: 0x1700005C RID: 92
		// (get) Token: 0x060002C4 RID: 708 RVA: 0x0000C7B0 File Offset: 0x0000A9B0
		// (set) Token: 0x060002C5 RID: 709 RVA: 0x000030DC File Offset: 0x000012DC
		public unsafe Color m_SelectionColor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GUISettings.NativeFieldInfoPtr_m_SelectionColor);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GUISettings.NativeFieldInfoPtr_m_SelectionColor)) = value;
			}
		}

		// Token: 0x04000151 RID: 337
		private static readonly IntPtr NativeFieldInfoPtr_m_DoubleClickSelectsWord;

		// Token: 0x04000152 RID: 338
		private static readonly IntPtr NativeFieldInfoPtr_m_TripleClickSelectsLine;

		// Token: 0x04000153 RID: 339
		private static readonly IntPtr NativeFieldInfoPtr_m_CursorColor;

		// Token: 0x04000154 RID: 340
		private static readonly IntPtr NativeFieldInfoPtr_m_CursorFlashSpeed;

		// Token: 0x04000155 RID: 341
		private static readonly IntPtr NativeFieldInfoPtr_m_SelectionColor;

		// Token: 0x04000156 RID: 342
		private static readonly IntPtr NativeMethodInfoPtr_Internal_GetCursorFlashSpeed_Private_Static_Single_0;

		// Token: 0x04000157 RID: 343
		private static readonly IntPtr NativeMethodInfoPtr_get_doubleClickSelectsWord_Public_get_Boolean_0;

		// Token: 0x04000158 RID: 344
		private static readonly IntPtr NativeMethodInfoPtr_get_tripleClickSelectsLine_Public_get_Boolean_0;

		// Token: 0x04000159 RID: 345
		private static readonly IntPtr NativeMethodInfoPtr_get_cursorColor_Public_get_Color_0;

		// Token: 0x0400015A RID: 346
		private static readonly IntPtr NativeMethodInfoPtr_get_cursorFlashSpeed_Public_get_Single_0;

		// Token: 0x0400015B RID: 347
		private static readonly IntPtr NativeMethodInfoPtr_get_selectionColor_Public_get_Color_0;

		// Token: 0x0400015C RID: 348
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
