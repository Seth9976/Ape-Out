using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace UnityEngine.UI
{
	// Token: 0x02000010 RID: 16
	public static class FontUpdateTracker : Object
	{
		// Token: 0x06000147 RID: 327 RVA: 0x0000B984 File Offset: 0x00009B84
		// Note: this type is marked as 'beforefieldinit'.
		static FontUpdateTracker()
		{
			Il2CppClassPointerStore<FontUpdateTracker>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UI.dll", "UnityEngine.UI", "FontUpdateTracker");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FontUpdateTracker>.NativeClassPtr);
			FontUpdateTracker.NativeFieldInfoPtr_m_Tracked = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FontUpdateTracker>.NativeClassPtr, "m_Tracked");
			FontUpdateTracker.NativeMethodInfoPtr_TrackText_Public_Static_Void_Text_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FontUpdateTracker>.NativeClassPtr, 100663517);
			FontUpdateTracker.NativeMethodInfoPtr_RebuildForFont_Private_Static_Void_Font_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FontUpdateTracker>.NativeClassPtr, 100663518);
			FontUpdateTracker.NativeMethodInfoPtr_UntrackText_Public_Static_Void_Text_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FontUpdateTracker>.NativeClassPtr, 100663519);
		}

		// Token: 0x06000148 RID: 328 RVA: 0x0000BA04 File Offset: 0x00009C04
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 518448, RefRangeEnd = 518450, XrefRangeStart = 518401, XrefRangeEnd = 518448, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void TrackText(Text t)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(t);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FontUpdateTracker.NativeMethodInfoPtr_TrackText_Public_Static_Void_Text_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000149 RID: 329 RVA: 0x0000BA3C File Offset: 0x00009C3C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 518450, XrefRangeEnd = 518478, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void RebuildForFont(Font f)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(f);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FontUpdateTracker.NativeMethodInfoPtr_RebuildForFont_Private_Static_Void_Font_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600014A RID: 330 RVA: 0x0000BA74 File Offset: 0x00009C74
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 518521, RefRangeEnd = 518523, XrefRangeStart = 518478, XrefRangeEnd = 518521, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void UntrackText(Text t)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(t);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FontUpdateTracker.NativeMethodInfoPtr_UntrackText_Public_Static_Void_Text_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600014B RID: 331 RVA: 0x0000274C File Offset: 0x0000094C
		public FontUpdateTracker(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000068 RID: 104
		// (get) Token: 0x0600014C RID: 332 RVA: 0x0000BAAC File Offset: 0x00009CAC
		// (set) Token: 0x0600014D RID: 333 RVA: 0x00002755 File Offset: 0x00000955
		public unsafe static Dictionary<Font, HashSet<Text>> m_Tracked
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(FontUpdateTracker.NativeFieldInfoPtr_m_Tracked, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<Font, HashSet<Text>>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(FontUpdateTracker.NativeFieldInfoPtr_m_Tracked, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000102 RID: 258
		private static readonly IntPtr NativeFieldInfoPtr_m_Tracked;

		// Token: 0x04000103 RID: 259
		private static readonly IntPtr NativeMethodInfoPtr_TrackText_Public_Static_Void_Text_0;

		// Token: 0x04000104 RID: 260
		private static readonly IntPtr NativeMethodInfoPtr_RebuildForFont_Private_Static_Void_Font_0;

		// Token: 0x04000105 RID: 261
		private static readonly IntPtr NativeMethodInfoPtr_UntrackText_Public_Static_Void_Text_0;
	}
}
