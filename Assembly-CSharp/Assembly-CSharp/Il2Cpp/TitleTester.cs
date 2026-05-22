using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace Il2Cpp
{
	// Token: 0x020001C7 RID: 455
	public class TitleTester : MonoBehaviour
	{
		// Token: 0x0600322D RID: 12845 RVA: 0x000BE19C File Offset: 0x000BC39C
		// Note: this type is marked as 'beforefieldinit'.
		static TitleTester()
		{
			Il2CppClassPointerStore<TitleTester>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "TitleTester");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TitleTester>.NativeClassPtr);
			TitleTester.NativeFieldInfoPtr_myLevel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TitleTester>.NativeClassPtr, "myLevel");
			TitleTester.NativeFieldInfoPtr_TransitionInt = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TitleTester>.NativeClassPtr, "TransitionInt");
			TitleTester.NativeFieldInfoPtr_mtm = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TitleTester>.NativeClassPtr, "mtm");
			TitleTester.NativeFieldInfoPtr_go = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TitleTester>.NativeClassPtr, "go");
			TitleTester.NativeFieldInfoPtr_reset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TitleTester>.NativeClassPtr, "reset");
			TitleTester.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TitleTester>.NativeClassPtr, 100667190);
			TitleTester.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TitleTester>.NativeClassPtr, 100667191);
		}

		// Token: 0x0600322E RID: 12846 RVA: 0x000BE258 File Offset: 0x000BC458
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 85568, XrefRangeEnd = 85574, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TitleTester.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600322F RID: 12847 RVA: 0x000BE28C File Offset: 0x000BC48C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TitleTester()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TitleTester>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TitleTester.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003230 RID: 12848 RVA: 0x0002271C File Offset: 0x0002091C
		public TitleTester(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170011DE RID: 4574
		// (get) Token: 0x06003231 RID: 12849 RVA: 0x000BE2C8 File Offset: 0x000BC4C8
		// (set) Token: 0x06003232 RID: 12850 RVA: 0x00022725 File Offset: 0x00020925
		public unsafe LevelTitle myLevel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TitleTester.NativeFieldInfoPtr_myLevel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<LevelTitle>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TitleTester.NativeFieldInfoPtr_myLevel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170011DF RID: 4575
		// (get) Token: 0x06003233 RID: 12851 RVA: 0x000BE2F8 File Offset: 0x000BC4F8
		// (set) Token: 0x06003234 RID: 12852 RVA: 0x00022744 File Offset: 0x00020944
		public unsafe int TransitionInt
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TitleTester.NativeFieldInfoPtr_TransitionInt);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TitleTester.NativeFieldInfoPtr_TransitionInt)) = value;
			}
		}

		// Token: 0x170011E0 RID: 4576
		// (get) Token: 0x06003235 RID: 12853 RVA: 0x000BE320 File Offset: 0x000BC520
		// (set) Token: 0x06003236 RID: 12854 RVA: 0x0002275F File Offset: 0x0002095F
		public unsafe MusicTransitionManager mtm
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TitleTester.NativeFieldInfoPtr_mtm);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MusicTransitionManager>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TitleTester.NativeFieldInfoPtr_mtm), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170011E1 RID: 4577
		// (get) Token: 0x06003237 RID: 12855 RVA: 0x000BE350 File Offset: 0x000BC550
		// (set) Token: 0x06003238 RID: 12856 RVA: 0x0002277E File Offset: 0x0002097E
		public unsafe bool go
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TitleTester.NativeFieldInfoPtr_go);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TitleTester.NativeFieldInfoPtr_go)) = value;
			}
		}

		// Token: 0x170011E2 RID: 4578
		// (get) Token: 0x06003239 RID: 12857 RVA: 0x000BE378 File Offset: 0x000BC578
		// (set) Token: 0x0600323A RID: 12858 RVA: 0x00022799 File Offset: 0x00020999
		public unsafe bool reset
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TitleTester.NativeFieldInfoPtr_reset);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TitleTester.NativeFieldInfoPtr_reset)) = value;
			}
		}

		// Token: 0x04001D61 RID: 7521
		private static readonly IntPtr NativeFieldInfoPtr_myLevel;

		// Token: 0x04001D62 RID: 7522
		private static readonly IntPtr NativeFieldInfoPtr_TransitionInt;

		// Token: 0x04001D63 RID: 7523
		private static readonly IntPtr NativeFieldInfoPtr_mtm;

		// Token: 0x04001D64 RID: 7524
		private static readonly IntPtr NativeFieldInfoPtr_go;

		// Token: 0x04001D65 RID: 7525
		private static readonly IntPtr NativeFieldInfoPtr_reset;

		// Token: 0x04001D66 RID: 7526
		private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

		// Token: 0x04001D67 RID: 7527
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
