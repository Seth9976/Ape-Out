using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace Il2Cpp
{
	// Token: 0x0200015D RID: 349
	public class PebbleBlower : MonoBehaviour
	{
		// Token: 0x0600298C RID: 10636 RVA: 0x000A73F0 File Offset: 0x000A55F0
		// Note: this type is marked as 'beforefieldinit'.
		static PebbleBlower()
		{
			Il2CppClassPointerStore<PebbleBlower>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "PebbleBlower");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PebbleBlower>.NativeClassPtr);
			PebbleBlower.NativeFieldInfoPtr_pSys = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PebbleBlower>.NativeClassPtr, "pSys");
			PebbleBlower.NativeFieldInfoPtr_parts = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PebbleBlower>.NativeClassPtr, "parts");
			PebbleBlower.NativeMethodInfoPtr_Start_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PebbleBlower>.NativeClassPtr, 100666586);
			PebbleBlower.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PebbleBlower>.NativeClassPtr, 100666587);
		}

		// Token: 0x0600298D RID: 10637 RVA: 0x000A7470 File Offset: 0x000A5670
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 77076, XrefRangeEnd = 77138, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PebbleBlower.NativeMethodInfoPtr_Start_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600298E RID: 10638 RVA: 0x000A74A4 File Offset: 0x000A56A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PebbleBlower()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PebbleBlower>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PebbleBlower.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600298F RID: 10639 RVA: 0x0001CE61 File Offset: 0x0001B061
		public PebbleBlower(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000EF0 RID: 3824
		// (get) Token: 0x06002990 RID: 10640 RVA: 0x000A74E0 File Offset: 0x000A56E0
		// (set) Token: 0x06002991 RID: 10641 RVA: 0x0001CE6A File Offset: 0x0001B06A
		public unsafe ParticleSystem pSys
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PebbleBlower.NativeFieldInfoPtr_pSys);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ParticleSystem>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PebbleBlower.NativeFieldInfoPtr_pSys), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000EF1 RID: 3825
		// (get) Token: 0x06002992 RID: 10642 RVA: 0x000A7510 File Offset: 0x000A5710
		// (set) Token: 0x06002993 RID: 10643 RVA: 0x0001CE89 File Offset: 0x0001B089
		public unsafe Il2CppStructArray<ParticleSystem.Particle> parts
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PebbleBlower.NativeFieldInfoPtr_parts);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<ParticleSystem.Particle>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PebbleBlower.NativeFieldInfoPtr_parts), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400187D RID: 6269
		private static readonly IntPtr NativeFieldInfoPtr_pSys;

		// Token: 0x0400187E RID: 6270
		private static readonly IntPtr NativeFieldInfoPtr_parts;

		// Token: 0x0400187F RID: 6271
		private static readonly IntPtr NativeMethodInfoPtr_Start_Public_Void_0;

		// Token: 0x04001880 RID: 6272
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
