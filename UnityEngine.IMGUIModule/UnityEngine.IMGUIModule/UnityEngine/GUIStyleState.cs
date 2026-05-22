using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine
{
	// Token: 0x02000011 RID: 17
	[Serializable]
	public sealed class GUIStyleState : Object
	{
		// Token: 0x0600034D RID: 845 RVA: 0x0000E51C File Offset: 0x0000C71C
		// Note: this type is marked as 'beforefieldinit'.
		static GUIStyleState()
		{
			Il2CppClassPointerStore<GUIStyleState>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.IMGUIModule.dll", "UnityEngine", "GUIStyleState");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GUIStyleState>.NativeClassPtr);
			GUIStyleState.NativeFieldInfoPtr_m_Ptr = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GUIStyleState>.NativeClassPtr, "m_Ptr");
			GUIStyleState.NativeFieldInfoPtr_m_SourceStyle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GUIStyleState>.NativeClassPtr, "m_SourceStyle");
			GUIStyleState.NativeMethodInfoPtr_get_textColor_Public_get_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUIStyleState>.NativeClassPtr, 100663569);
			GUIStyleState.NativeMethodInfoPtr_set_textColor_Public_set_Void_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUIStyleState>.NativeClassPtr, 100663570);
			GUIStyleState.NativeMethodInfoPtr_Init_Private_Static_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUIStyleState>.NativeClassPtr, 100663571);
			GUIStyleState.NativeMethodInfoPtr_Cleanup_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUIStyleState>.NativeClassPtr, 100663572);
			GUIStyleState.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUIStyleState>.NativeClassPtr, 100663573);
			GUIStyleState.NativeMethodInfoPtr__ctor_Private_Void_GUIStyle_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUIStyleState>.NativeClassPtr, 100663574);
			GUIStyleState.NativeMethodInfoPtr_GetGUIStyleState_Internal_Static_GUIStyleState_GUIStyle_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUIStyleState>.NativeClassPtr, 100663575);
			GUIStyleState.NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUIStyleState>.NativeClassPtr, 100663576);
			GUIStyleState.NativeMethodInfoPtr_get_textColor_Injected_Private_Void_byref_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUIStyleState>.NativeClassPtr, 100663577);
			GUIStyleState.NativeMethodInfoPtr_set_textColor_Injected_Private_Void_byref_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUIStyleState>.NativeClassPtr, 100663578);
			GUIStyleState.get_backgroundDelegateField = IL2CPP.ResolveICall<GUIStyleState.get_backgroundDelegate>("UnityEngine.GUIStyleState::get_background");
			GUIStyleState.set_backgroundDelegateField = IL2CPP.ResolveICall<GUIStyleState.set_backgroundDelegate>("UnityEngine.GUIStyleState::set_background");
		}

		// Token: 0x1700009E RID: 158
		// (get) Token: 0x0600034E RID: 846 RVA: 0x0000E65C File Offset: 0x0000C85C
		// (set) Token: 0x0600034F RID: 847 RVA: 0x0000E698 File Offset: 0x0000C898
		public unsafe Color textColor
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 508681, XrefRangeEnd = 508683, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUIStyleState.NativeMethodInfoPtr_get_textColor_Public_get_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 508683, XrefRangeEnd = 508685, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUIStyleState.NativeMethodInfoPtr_set_textColor_Public_set_Void_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06000350 RID: 848 RVA: 0x0000E6D8 File Offset: 0x0000C8D8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 508685, XrefRangeEnd = 508689, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IntPtr Init()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUIStyleState.NativeMethodInfoPtr_Init_Private_Static_IntPtr_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000351 RID: 849 RVA: 0x0000E708 File Offset: 0x0000C908
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 508689, XrefRangeEnd = 508693, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Cleanup()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUIStyleState.NativeMethodInfoPtr_Cleanup_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000352 RID: 850 RVA: 0x0000E73C File Offset: 0x0000C93C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 508693, XrefRangeEnd = 508695, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe GUIStyleState()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GUIStyleState>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUIStyleState.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000353 RID: 851 RVA: 0x0000E778 File Offset: 0x0000C978
		[CallerCount(0)]
		public unsafe GUIStyleState(GUIStyle sourceStyle, IntPtr source)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GUIStyleState>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(sourceStyle);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref source;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUIStyleState.NativeMethodInfoPtr__ctor_Private_Void_GUIStyle_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000354 RID: 852 RVA: 0x0000E7D4 File Offset: 0x0000C9D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 508695, XrefRangeEnd = 508698, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static GUIStyleState GetGUIStyleState(GUIStyle sourceStyle, IntPtr source)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(sourceStyle);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref source;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUIStyleState.NativeMethodInfoPtr_GetGUIStyleState_Internal_Static_GUIStyleState_GUIStyle_IntPtr_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<GUIStyleState>(intPtr3) : null;
		}

		// Token: 0x06000355 RID: 853 RVA: 0x0000E828 File Offset: 0x0000CA28
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 508698, XrefRangeEnd = 508702, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public new unsafe void Finalize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUIStyleState.NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000356 RID: 854 RVA: 0x0000E85C File Offset: 0x0000CA5C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 508702, XrefRangeEnd = 508706, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void get_textColor_Injected(out Color ret)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &ret;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUIStyleState.NativeMethodInfoPtr_get_textColor_Injected_Private_Void_byref_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000357 RID: 855 RVA: 0x0000E89C File Offset: 0x0000CA9C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 508706, XrefRangeEnd = 508710, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void set_textColor_Injected(ref Color value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUIStyleState.NativeMethodInfoPtr_set_textColor_Injected_Private_Void_byref_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000358 RID: 856 RVA: 0x000034D6 File Offset: 0x000016D6
		public GUIStyleState(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700009C RID: 156
		// (get) Token: 0x06000359 RID: 857 RVA: 0x0000E8DC File Offset: 0x0000CADC
		// (set) Token: 0x0600035A RID: 858 RVA: 0x000034DF File Offset: 0x000016DF
		public unsafe IntPtr m_Ptr
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GUIStyleState.NativeFieldInfoPtr_m_Ptr);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GUIStyleState.NativeFieldInfoPtr_m_Ptr)) = value;
			}
		}

		// Token: 0x1700009D RID: 157
		// (get) Token: 0x0600035B RID: 859 RVA: 0x0000E904 File Offset: 0x0000CB04
		// (set) Token: 0x0600035C RID: 860 RVA: 0x000034FA File Offset: 0x000016FA
		public unsafe GUIStyle m_SourceStyle
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GUIStyleState.NativeFieldInfoPtr_m_SourceStyle);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GUIStyle>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GUIStyleState.NativeFieldInfoPtr_m_SourceStyle), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700009F RID: 159
		// (get) Token: 0x0600035D RID: 861 RVA: 0x0000E934 File Offset: 0x0000CB34
		// (set) Token: 0x0600035E RID: 862 RVA: 0x00003519 File Offset: 0x00001719
		public Texture2D background
		{
			get
			{
				IntPtr intPtr = GUIStyleState.get_backgroundDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Texture2D>(intPtr2) : null;
			}
			set
			{
				GUIStyleState.set_backgroundDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0600035F RID: 863 RVA: 0x0000E960 File Offset: 0x0000CB60
		public static GUIStyleState ProduceGUIStyleStateFromDeserialization(GUIStyle sourceStyle, IntPtr source)
		{
			return new GUIStyleState(sourceStyle, source);
		}

		// Token: 0x040001BA RID: 442
		private static readonly IntPtr NativeFieldInfoPtr_m_Ptr;

		// Token: 0x040001BB RID: 443
		private static readonly IntPtr NativeFieldInfoPtr_m_SourceStyle;

		// Token: 0x040001BC RID: 444
		private static readonly IntPtr NativeMethodInfoPtr_get_textColor_Public_get_Color_0;

		// Token: 0x040001BD RID: 445
		private static readonly IntPtr NativeMethodInfoPtr_set_textColor_Public_set_Void_Color_0;

		// Token: 0x040001BE RID: 446
		private static readonly IntPtr NativeMethodInfoPtr_Init_Private_Static_IntPtr_0;

		// Token: 0x040001BF RID: 447
		private static readonly IntPtr NativeMethodInfoPtr_Cleanup_Private_Void_0;

		// Token: 0x040001C0 RID: 448
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x040001C1 RID: 449
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Private_Void_GUIStyle_IntPtr_0;

		// Token: 0x040001C2 RID: 450
		private static readonly IntPtr NativeMethodInfoPtr_GetGUIStyleState_Internal_Static_GUIStyleState_GUIStyle_IntPtr_0;

		// Token: 0x040001C3 RID: 451
		private static readonly IntPtr NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0;

		// Token: 0x040001C4 RID: 452
		private static readonly IntPtr NativeMethodInfoPtr_get_textColor_Injected_Private_Void_byref_Color_0;

		// Token: 0x040001C5 RID: 453
		private static readonly IntPtr NativeMethodInfoPtr_set_textColor_Injected_Private_Void_byref_Color_0;

		// Token: 0x040001C6 RID: 454
		private static readonly GUIStyleState.get_backgroundDelegate get_backgroundDelegateField;

		// Token: 0x040001C7 RID: 455
		private static readonly GUIStyleState.set_backgroundDelegate set_backgroundDelegateField;

		// Token: 0x02000072 RID: 114
		// (Invoke) Token: 0x060006C6 RID: 1734
		private delegate IntPtr get_backgroundDelegate(IntPtr @this);

		// Token: 0x02000073 RID: 115
		// (Invoke) Token: 0x060006C8 RID: 1736
		private delegate void set_backgroundDelegate(IntPtr @this, IntPtr value);
	}
}
