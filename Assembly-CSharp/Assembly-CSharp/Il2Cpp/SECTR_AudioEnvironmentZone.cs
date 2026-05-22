using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace Il2Cpp
{
	// Token: 0x0200003A RID: 58
	public class SECTR_AudioEnvironmentZone : SECTR_AudioEnvironment
	{
		// Token: 0x0600095D RID: 2397 RVA: 0x0004FD2C File Offset: 0x0004DF2C
		// Note: this type is marked as 'beforefieldinit'.
		static SECTR_AudioEnvironmentZone()
		{
			Il2CppClassPointerStore<SECTR_AudioEnvironmentZone>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "SECTR_AudioEnvironmentZone");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SECTR_AudioEnvironmentZone>.NativeClassPtr);
			SECTR_AudioEnvironmentZone.NativeFieldInfoPtr_cachedZone = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SECTR_AudioEnvironmentZone>.NativeClassPtr, "cachedZone");
			SECTR_AudioEnvironmentZone.NativeMethodInfoPtr_OnEnable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SECTR_AudioEnvironmentZone>.NativeClassPtr, 100664015);
			SECTR_AudioEnvironmentZone.NativeMethodInfoPtr_OnDisable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SECTR_AudioEnvironmentZone>.NativeClassPtr, 100664016);
			SECTR_AudioEnvironmentZone.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SECTR_AudioEnvironmentZone>.NativeClassPtr, 100664017);
			SECTR_AudioEnvironmentZone.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SECTR_AudioEnvironmentZone>.NativeClassPtr, 100664018);
		}

		// Token: 0x0600095E RID: 2398 RVA: 0x0004FDC0 File Offset: 0x0004DFC0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 37588, XrefRangeEnd = 37591, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnEnable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SECTR_AudioEnvironmentZone.NativeMethodInfoPtr_OnEnable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600095F RID: 2399 RVA: 0x0004FDF4 File Offset: 0x0004DFF4
		[CallerCount(0)]
		public new unsafe void OnDisable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SECTR_AudioEnvironmentZone.NativeMethodInfoPtr_OnDisable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000960 RID: 2400 RVA: 0x0004FE28 File Offset: 0x0004E028
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 37591, XrefRangeEnd = 37596, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SECTR_AudioEnvironmentZone.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000961 RID: 2401 RVA: 0x0004FE5C File Offset: 0x0004E05C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SECTR_AudioEnvironmentZone()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SECTR_AudioEnvironmentZone>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SECTR_AudioEnvironmentZone.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000962 RID: 2402 RVA: 0x00008045 File Offset: 0x00006245
		public SECTR_AudioEnvironmentZone(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000376 RID: 886
		// (get) Token: 0x06000963 RID: 2403 RVA: 0x0004FE98 File Offset: 0x0004E098
		// (set) Token: 0x06000964 RID: 2404 RVA: 0x0000804E File Offset: 0x0000624E
		public unsafe AudioReverbZone cachedZone
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SECTR_AudioEnvironmentZone.NativeFieldInfoPtr_cachedZone);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioReverbZone>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SECTR_AudioEnvironmentZone.NativeFieldInfoPtr_cachedZone), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040005A9 RID: 1449
		private static readonly IntPtr NativeFieldInfoPtr_cachedZone;

		// Token: 0x040005AA RID: 1450
		private static readonly IntPtr NativeMethodInfoPtr_OnEnable_Private_Void_0;

		// Token: 0x040005AB RID: 1451
		private static readonly IntPtr NativeMethodInfoPtr_OnDisable_Private_Void_0;

		// Token: 0x040005AC RID: 1452
		private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

		// Token: 0x040005AD RID: 1453
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
