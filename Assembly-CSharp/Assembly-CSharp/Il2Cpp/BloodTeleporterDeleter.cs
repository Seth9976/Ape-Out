using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace Il2Cpp
{
	// Token: 0x02000083 RID: 131
	public class BloodTeleporterDeleter : MonoBehaviour
	{
		// Token: 0x06001088 RID: 4232 RVA: 0x00064348 File Offset: 0x00062548
		// Note: this type is marked as 'beforefieldinit'.
		static BloodTeleporterDeleter()
		{
			Il2CppClassPointerStore<BloodTeleporterDeleter>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "BloodTeleporterDeleter");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BloodTeleporterDeleter>.NativeClassPtr);
			BloodTeleporterDeleter.NativeFieldInfoPtr_stairs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BloodTeleporterDeleter>.NativeClassPtr, "stairs");
			BloodTeleporterDeleter.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BloodTeleporterDeleter>.NativeClassPtr, 100664682);
			BloodTeleporterDeleter.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BloodTeleporterDeleter>.NativeClassPtr, 100664683);
			BloodTeleporterDeleter.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BloodTeleporterDeleter>.NativeClassPtr, 100664684);
		}

		// Token: 0x06001089 RID: 4233 RVA: 0x000643C8 File Offset: 0x000625C8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 48226, XrefRangeEnd = 48229, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BloodTeleporterDeleter.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600108A RID: 4234 RVA: 0x000643FC File Offset: 0x000625FC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 48229, XrefRangeEnd = 48242, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BloodTeleporterDeleter.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600108B RID: 4235 RVA: 0x00064430 File Offset: 0x00062630
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe BloodTeleporterDeleter()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BloodTeleporterDeleter>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BloodTeleporterDeleter.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600108C RID: 4236 RVA: 0x0000C39B File Offset: 0x0000A59B
		public BloodTeleporterDeleter(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170005FC RID: 1532
		// (get) Token: 0x0600108D RID: 4237 RVA: 0x0006446C File Offset: 0x0006266C
		// (set) Token: 0x0600108E RID: 4238 RVA: 0x0000C3A4 File Offset: 0x0000A5A4
		public unsafe Stairs stairs
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BloodTeleporterDeleter.NativeFieldInfoPtr_stairs);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Stairs>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BloodTeleporterDeleter.NativeFieldInfoPtr_stairs), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000A09 RID: 2569
		private static readonly IntPtr NativeFieldInfoPtr_stairs;

		// Token: 0x04000A0A RID: 2570
		private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

		// Token: 0x04000A0B RID: 2571
		private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

		// Token: 0x04000A0C RID: 2572
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
