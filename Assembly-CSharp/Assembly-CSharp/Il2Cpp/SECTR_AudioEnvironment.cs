using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace Il2Cpp
{
	// Token: 0x02000038 RID: 56
	public class SECTR_AudioEnvironment : MonoBehaviour
	{
		// Token: 0x06000948 RID: 2376 RVA: 0x0004F89C File Offset: 0x0004DA9C
		// Note: this type is marked as 'beforefieldinit'.
		static SECTR_AudioEnvironment()
		{
			Il2CppClassPointerStore<SECTR_AudioEnvironment>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "SECTR_AudioEnvironment");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SECTR_AudioEnvironment>.NativeClassPtr);
			SECTR_AudioEnvironment.NativeFieldInfoPtr_ambienceActive = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SECTR_AudioEnvironment>.NativeClassPtr, "ambienceActive");
			SECTR_AudioEnvironment.NativeFieldInfoPtr__ambience = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SECTR_AudioEnvironment>.NativeClassPtr, "_ambience");
			SECTR_AudioEnvironment.NativeMethodInfoPtr_get_Ambience_Public_get_SECTR_AudioAmbience_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SECTR_AudioEnvironment>.NativeClassPtr, 100664004);
			SECTR_AudioEnvironment.NativeMethodInfoPtr_set_Ambience_Public_set_Void_SECTR_AudioAmbience_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SECTR_AudioEnvironment>.NativeClassPtr, 100664005);
			SECTR_AudioEnvironment.NativeMethodInfoPtr_get_Active_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SECTR_AudioEnvironment>.NativeClassPtr, 100664006);
			SECTR_AudioEnvironment.NativeMethodInfoPtr_OnDisable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SECTR_AudioEnvironment>.NativeClassPtr, 100664007);
			SECTR_AudioEnvironment.NativeMethodInfoPtr_Activate_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SECTR_AudioEnvironment>.NativeClassPtr, 100664008);
			SECTR_AudioEnvironment.NativeMethodInfoPtr_Deactivate_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SECTR_AudioEnvironment>.NativeClassPtr, 100664009);
			SECTR_AudioEnvironment.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SECTR_AudioEnvironment>.NativeClassPtr, 100664010);
		}

		// Token: 0x17000373 RID: 883
		// (get) Token: 0x06000949 RID: 2377 RVA: 0x0004F980 File Offset: 0x0004DB80
		// (set) Token: 0x0600094A RID: 2378 RVA: 0x0004F9C0 File Offset: 0x0004DBC0
		public unsafe SECTR_AudioAmbience Ambience
		{
			[CallerCount(11)]
			[CachedScanResults(RefRangeStart = 37465, RefRangeEnd = 37476, XrefRangeStart = 37461, XrefRangeEnd = 37465, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SECTR_AudioEnvironment.NativeMethodInfoPtr_get_Ambience_Public_get_SECTR_AudioAmbience_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<SECTR_AudioAmbience>(intPtr3) : null;
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 37506, RefRangeEnd = 37507, XrefRangeStart = 37476, XrefRangeEnd = 37506, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SECTR_AudioEnvironment.NativeMethodInfoPtr_set_Ambience_Public_set_Void_SECTR_AudioAmbience_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000374 RID: 884
		// (get) Token: 0x0600094B RID: 2379 RVA: 0x0004FA04 File Offset: 0x0004DC04
		public unsafe bool Active
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SECTR_AudioEnvironment.NativeMethodInfoPtr_get_Active_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600094C RID: 2380 RVA: 0x0004FA40 File Offset: 0x0004DC40
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnDisable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SECTR_AudioEnvironment.NativeMethodInfoPtr_OnDisable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600094D RID: 2381 RVA: 0x0004FA74 File Offset: 0x0004DC74
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 37525, RefRangeEnd = 37530, XrefRangeStart = 37507, XrefRangeEnd = 37525, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Activate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SECTR_AudioEnvironment.NativeMethodInfoPtr_Activate_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600094E RID: 2382 RVA: 0x0004FAA8 File Offset: 0x0004DCA8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 37530, XrefRangeEnd = 37543, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Deactivate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SECTR_AudioEnvironment.NativeMethodInfoPtr_Deactivate_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600094F RID: 2383 RVA: 0x0004FADC File Offset: 0x0004DCDC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 37550, RefRangeEnd = 37552, XrefRangeStart = 37543, XrefRangeEnd = 37550, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SECTR_AudioEnvironment()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SECTR_AudioEnvironment>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SECTR_AudioEnvironment.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000950 RID: 2384 RVA: 0x00007FDA File Offset: 0x000061DA
		public SECTR_AudioEnvironment(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000371 RID: 881
		// (get) Token: 0x06000951 RID: 2385 RVA: 0x0004FB18 File Offset: 0x0004DD18
		// (set) Token: 0x06000952 RID: 2386 RVA: 0x00007FE3 File Offset: 0x000061E3
		public unsafe bool ambienceActive
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SECTR_AudioEnvironment.NativeFieldInfoPtr_ambienceActive);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SECTR_AudioEnvironment.NativeFieldInfoPtr_ambienceActive)) = value;
			}
		}

		// Token: 0x17000372 RID: 882
		// (get) Token: 0x06000953 RID: 2387 RVA: 0x0004FB40 File Offset: 0x0004DD40
		// (set) Token: 0x06000954 RID: 2388 RVA: 0x00007FFE File Offset: 0x000061FE
		public unsafe SECTR_AudioAmbience _ambience
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SECTR_AudioEnvironment.NativeFieldInfoPtr__ambience);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SECTR_AudioAmbience>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SECTR_AudioEnvironment.NativeFieldInfoPtr__ambience), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400059B RID: 1435
		private static readonly IntPtr NativeFieldInfoPtr_ambienceActive;

		// Token: 0x0400059C RID: 1436
		private static readonly IntPtr NativeFieldInfoPtr__ambience;

		// Token: 0x0400059D RID: 1437
		private static readonly IntPtr NativeMethodInfoPtr_get_Ambience_Public_get_SECTR_AudioAmbience_0;

		// Token: 0x0400059E RID: 1438
		private static readonly IntPtr NativeMethodInfoPtr_set_Ambience_Public_set_Void_SECTR_AudioAmbience_0;

		// Token: 0x0400059F RID: 1439
		private static readonly IntPtr NativeMethodInfoPtr_get_Active_Public_get_Boolean_0;

		// Token: 0x040005A0 RID: 1440
		private static readonly IntPtr NativeMethodInfoPtr_OnDisable_Private_Void_0;

		// Token: 0x040005A1 RID: 1441
		private static readonly IntPtr NativeMethodInfoPtr_Activate_Protected_Void_0;

		// Token: 0x040005A2 RID: 1442
		private static readonly IntPtr NativeMethodInfoPtr_Deactivate_Protected_Void_0;

		// Token: 0x040005A3 RID: 1443
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;
	}
}
