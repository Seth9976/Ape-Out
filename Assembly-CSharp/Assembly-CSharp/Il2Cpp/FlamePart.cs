using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace Il2Cpp
{
	// Token: 0x020000DA RID: 218
	public class FlamePart : MonoBehaviour
	{
		// Token: 0x06001934 RID: 6452 RVA: 0x0007B178 File Offset: 0x00079378
		// Note: this type is marked as 'beforefieldinit'.
		static FlamePart()
		{
			Il2CppClassPointerStore<FlamePart>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "FlamePart");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FlamePart>.NativeClassPtr);
			FlamePart.NativeFieldInfoPtr_part = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlamePart>.NativeClassPtr, "part");
			FlamePart.NativeFieldInfoPtr_startVect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlamePart>.NativeClassPtr, "startVect");
			FlamePart.NativeFieldInfoPtr_rb = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlamePart>.NativeClassPtr, "rb");
			FlamePart.NativeMethodInfoPtr_OnCollisionEnter2D_Public_Void_Collision2D_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlamePart>.NativeClassPtr, 100665363);
			FlamePart.NativeMethodInfoPtr_OnEnable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlamePart>.NativeClassPtr, 100665364);
			FlamePart.NativeMethodInfoPtr_OnDisable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlamePart>.NativeClassPtr, 100665365);
			FlamePart.NativeMethodInfoPtr_MyFixedUpdate_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlamePart>.NativeClassPtr, 100665366);
			FlamePart.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlamePart>.NativeClassPtr, 100665367);
		}

		// Token: 0x06001935 RID: 6453 RVA: 0x0007B248 File Offset: 0x00079448
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 58718, XrefRangeEnd = 58727, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnCollisionEnter2D(Collision2D collision)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(collision);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FlamePart.NativeMethodInfoPtr_OnCollisionEnter2D_Public_Void_Collision2D_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001936 RID: 6454 RVA: 0x0007B28C File Offset: 0x0007948C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 58727, XrefRangeEnd = 58744, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnEnable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FlamePart.NativeMethodInfoPtr_OnEnable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001937 RID: 6455 RVA: 0x0007B2C0 File Offset: 0x000794C0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 58744, XrefRangeEnd = 58755, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnDisable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FlamePart.NativeMethodInfoPtr_OnDisable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001938 RID: 6456 RVA: 0x0007B2F4 File Offset: 0x000794F4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 58755, XrefRangeEnd = 58786, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void MyFixedUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FlamePart.NativeMethodInfoPtr_MyFixedUpdate_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001939 RID: 6457 RVA: 0x0007B328 File Offset: 0x00079528
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe FlamePart()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FlamePart>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FlamePart.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600193A RID: 6458 RVA: 0x00012025 File Offset: 0x00010225
		public FlamePart(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700090D RID: 2317
		// (get) Token: 0x0600193B RID: 6459 RVA: 0x0007B364 File Offset: 0x00079564
		// (set) Token: 0x0600193C RID: 6460 RVA: 0x0001202E File Offset: 0x0001022E
		public unsafe ParticleSystem part
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlamePart.NativeFieldInfoPtr_part);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ParticleSystem>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlamePart.NativeFieldInfoPtr_part), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700090E RID: 2318
		// (get) Token: 0x0600193D RID: 6461 RVA: 0x0007B394 File Offset: 0x00079594
		// (set) Token: 0x0600193E RID: 6462 RVA: 0x0001204D File Offset: 0x0001024D
		public unsafe Vector2 startVect
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlamePart.NativeFieldInfoPtr_startVect);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlamePart.NativeFieldInfoPtr_startVect)) = value;
			}
		}

		// Token: 0x1700090F RID: 2319
		// (get) Token: 0x0600193F RID: 6463 RVA: 0x0007B3BC File Offset: 0x000795BC
		// (set) Token: 0x06001940 RID: 6464 RVA: 0x00012068 File Offset: 0x00010268
		public unsafe Rigidbody2D rb
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlamePart.NativeFieldInfoPtr_rb);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Rigidbody2D>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlamePart.NativeFieldInfoPtr_rb), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000EFE RID: 3838
		private static readonly IntPtr NativeFieldInfoPtr_part;

		// Token: 0x04000EFF RID: 3839
		private static readonly IntPtr NativeFieldInfoPtr_startVect;

		// Token: 0x04000F00 RID: 3840
		private static readonly IntPtr NativeFieldInfoPtr_rb;

		// Token: 0x04000F01 RID: 3841
		private static readonly IntPtr NativeMethodInfoPtr_OnCollisionEnter2D_Public_Void_Collision2D_0;

		// Token: 0x04000F02 RID: 3842
		private static readonly IntPtr NativeMethodInfoPtr_OnEnable_Private_Void_0;

		// Token: 0x04000F03 RID: 3843
		private static readonly IntPtr NativeMethodInfoPtr_OnDisable_Private_Void_0;

		// Token: 0x04000F04 RID: 3844
		private static readonly IntPtr NativeMethodInfoPtr_MyFixedUpdate_Public_Void_0;

		// Token: 0x04000F05 RID: 3845
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
