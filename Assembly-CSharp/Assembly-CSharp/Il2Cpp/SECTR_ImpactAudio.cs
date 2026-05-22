using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace Il2Cpp
{
	// Token: 0x02000041 RID: 65
	public class SECTR_ImpactAudio : MonoBehaviour
	{
		// Token: 0x06000A5B RID: 2651 RVA: 0x00052B30 File Offset: 0x00050D30
		// Note: this type is marked as 'beforefieldinit'.
		static SECTR_ImpactAudio()
		{
			Il2CppClassPointerStore<SECTR_ImpactAudio>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "SECTR_ImpactAudio");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SECTR_ImpactAudio>.NativeClassPtr);
			SECTR_ImpactAudio.NativeFieldInfoPtr_nextImpactTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SECTR_ImpactAudio>.NativeClassPtr, "nextImpactTime");
			SECTR_ImpactAudio.NativeFieldInfoPtr_surfaceTable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SECTR_ImpactAudio>.NativeClassPtr, "surfaceTable");
			SECTR_ImpactAudio.NativeFieldInfoPtr_DefaultSound = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SECTR_ImpactAudio>.NativeClassPtr, "DefaultSound");
			SECTR_ImpactAudio.NativeFieldInfoPtr_SurfaceImpacts = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SECTR_ImpactAudio>.NativeClassPtr, "SurfaceImpacts");
			SECTR_ImpactAudio.NativeFieldInfoPtr_MinImpactSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SECTR_ImpactAudio>.NativeClassPtr, "MinImpactSpeed");
			SECTR_ImpactAudio.NativeFieldInfoPtr_MinImpactInterval = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SECTR_ImpactAudio>.NativeClassPtr, "MinImpactInterval");
			SECTR_ImpactAudio.NativeMethodInfoPtr_OnEnable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SECTR_ImpactAudio>.NativeClassPtr, 100664149);
			SECTR_ImpactAudio.NativeMethodInfoPtr_OnDisable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SECTR_ImpactAudio>.NativeClassPtr, 100664150);
			SECTR_ImpactAudio.NativeMethodInfoPtr_OnCollisionStay_Private_Void_Collision_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SECTR_ImpactAudio>.NativeClassPtr, 100664151);
			SECTR_ImpactAudio.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SECTR_ImpactAudio>.NativeClassPtr, 100664152);
		}

		// Token: 0x06000A5C RID: 2652 RVA: 0x00052C28 File Offset: 0x00050E28
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 39922, XrefRangeEnd = 39947, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnEnable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SECTR_ImpactAudio.NativeMethodInfoPtr_OnEnable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000A5D RID: 2653 RVA: 0x00052C5C File Offset: 0x00050E5C
		[CallerCount(0)]
		public unsafe void OnDisable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SECTR_ImpactAudio.NativeMethodInfoPtr_OnDisable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000A5E RID: 2654 RVA: 0x00052C90 File Offset: 0x00050E90
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 39947, XrefRangeEnd = 39985, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnCollisionStay(Collision collision)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(collision);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SECTR_ImpactAudio.NativeMethodInfoPtr_OnCollisionStay_Private_Void_Collision_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000A5F RID: 2655 RVA: 0x00052CD4 File Offset: 0x00050ED4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 39985, XrefRangeEnd = 39994, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SECTR_ImpactAudio()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SECTR_ImpactAudio>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SECTR_ImpactAudio.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000A60 RID: 2656 RVA: 0x000088AA File Offset: 0x00006AAA
		public SECTR_ImpactAudio(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170003D0 RID: 976
		// (get) Token: 0x06000A61 RID: 2657 RVA: 0x00052D10 File Offset: 0x00050F10
		// (set) Token: 0x06000A62 RID: 2658 RVA: 0x000088B3 File Offset: 0x00006AB3
		public unsafe float nextImpactTime
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SECTR_ImpactAudio.NativeFieldInfoPtr_nextImpactTime);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SECTR_ImpactAudio.NativeFieldInfoPtr_nextImpactTime)) = value;
			}
		}

		// Token: 0x170003D1 RID: 977
		// (get) Token: 0x06000A63 RID: 2659 RVA: 0x00052D38 File Offset: 0x00050F38
		// (set) Token: 0x06000A64 RID: 2660 RVA: 0x000088CE File Offset: 0x00006ACE
		public unsafe Dictionary<PhysicMaterial, SECTR_ImpactAudio.ImpactSound> surfaceTable
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SECTR_ImpactAudio.NativeFieldInfoPtr_surfaceTable);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<PhysicMaterial, SECTR_ImpactAudio.ImpactSound>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SECTR_ImpactAudio.NativeFieldInfoPtr_surfaceTable), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170003D2 RID: 978
		// (get) Token: 0x06000A65 RID: 2661 RVA: 0x00052D68 File Offset: 0x00050F68
		// (set) Token: 0x06000A66 RID: 2662 RVA: 0x000088ED File Offset: 0x00006AED
		public unsafe SECTR_ImpactAudio.ImpactSound DefaultSound
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SECTR_ImpactAudio.NativeFieldInfoPtr_DefaultSound);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SECTR_ImpactAudio.ImpactSound>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SECTR_ImpactAudio.NativeFieldInfoPtr_DefaultSound), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170003D3 RID: 979
		// (get) Token: 0x06000A67 RID: 2663 RVA: 0x00052D98 File Offset: 0x00050F98
		// (set) Token: 0x06000A68 RID: 2664 RVA: 0x0000890C File Offset: 0x00006B0C
		public unsafe List<SECTR_ImpactAudio.ImpactSound> SurfaceImpacts
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SECTR_ImpactAudio.NativeFieldInfoPtr_SurfaceImpacts);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<SECTR_ImpactAudio.ImpactSound>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SECTR_ImpactAudio.NativeFieldInfoPtr_SurfaceImpacts), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170003D4 RID: 980
		// (get) Token: 0x06000A69 RID: 2665 RVA: 0x00052DC8 File Offset: 0x00050FC8
		// (set) Token: 0x06000A6A RID: 2666 RVA: 0x0000892B File Offset: 0x00006B2B
		public unsafe float MinImpactSpeed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SECTR_ImpactAudio.NativeFieldInfoPtr_MinImpactSpeed);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SECTR_ImpactAudio.NativeFieldInfoPtr_MinImpactSpeed)) = value;
			}
		}

		// Token: 0x170003D5 RID: 981
		// (get) Token: 0x06000A6B RID: 2667 RVA: 0x00052DF0 File Offset: 0x00050FF0
		// (set) Token: 0x06000A6C RID: 2668 RVA: 0x00008946 File Offset: 0x00006B46
		public unsafe float MinImpactInterval
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SECTR_ImpactAudio.NativeFieldInfoPtr_MinImpactInterval);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SECTR_ImpactAudio.NativeFieldInfoPtr_MinImpactInterval)) = value;
			}
		}

		// Token: 0x04000647 RID: 1607
		private static readonly IntPtr NativeFieldInfoPtr_nextImpactTime;

		// Token: 0x04000648 RID: 1608
		private static readonly IntPtr NativeFieldInfoPtr_surfaceTable;

		// Token: 0x04000649 RID: 1609
		private static readonly IntPtr NativeFieldInfoPtr_DefaultSound;

		// Token: 0x0400064A RID: 1610
		private static readonly IntPtr NativeFieldInfoPtr_SurfaceImpacts;

		// Token: 0x0400064B RID: 1611
		private static readonly IntPtr NativeFieldInfoPtr_MinImpactSpeed;

		// Token: 0x0400064C RID: 1612
		private static readonly IntPtr NativeFieldInfoPtr_MinImpactInterval;

		// Token: 0x0400064D RID: 1613
		private static readonly IntPtr NativeMethodInfoPtr_OnEnable_Private_Void_0;

		// Token: 0x0400064E RID: 1614
		private static readonly IntPtr NativeMethodInfoPtr_OnDisable_Private_Void_0;

		// Token: 0x0400064F RID: 1615
		private static readonly IntPtr NativeMethodInfoPtr_OnCollisionStay_Private_Void_Collision_0;

		// Token: 0x04000650 RID: 1616
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x020002BB RID: 699
		[Serializable]
		public class ImpactSound : global::Il2CppSystem.Object
		{
			// Token: 0x06004B8F RID: 19343 RVA: 0x00117538 File Offset: 0x00115738
			// Note: this type is marked as 'beforefieldinit'.
			static ImpactSound()
			{
				Il2CppClassPointerStore<SECTR_ImpactAudio.ImpactSound>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SECTR_ImpactAudio>.NativeClassPtr, "ImpactSound");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SECTR_ImpactAudio.ImpactSound>.NativeClassPtr);
				SECTR_ImpactAudio.ImpactSound.NativeFieldInfoPtr_SurfaceMaterial = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SECTR_ImpactAudio.ImpactSound>.NativeClassPtr, "SurfaceMaterial");
				SECTR_ImpactAudio.ImpactSound.NativeFieldInfoPtr_ImpactCue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SECTR_ImpactAudio.ImpactSound>.NativeClassPtr, "ImpactCue");
				SECTR_ImpactAudio.ImpactSound.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SECTR_ImpactAudio.ImpactSound>.NativeClassPtr, 100664153);
			}

			// Token: 0x06004B90 RID: 19344 RVA: 0x001175A0 File Offset: 0x001157A0
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ImpactSound()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SECTR_ImpactAudio.ImpactSound>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SECTR_ImpactAudio.ImpactSound.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06004B91 RID: 19345 RVA: 0x0002C66D File Offset: 0x0002A86D
			public ImpactSound(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001B82 RID: 7042
			// (get) Token: 0x06004B92 RID: 19346 RVA: 0x001175DC File Offset: 0x001157DC
			// (set) Token: 0x06004B93 RID: 19347 RVA: 0x0002C676 File Offset: 0x0002A876
			public unsafe PhysicMaterial SurfaceMaterial
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SECTR_ImpactAudio.ImpactSound.NativeFieldInfoPtr_SurfaceMaterial);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<PhysicMaterial>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SECTR_ImpactAudio.ImpactSound.NativeFieldInfoPtr_SurfaceMaterial), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001B83 RID: 7043
			// (get) Token: 0x06004B94 RID: 19348 RVA: 0x0011760C File Offset: 0x0011580C
			// (set) Token: 0x06004B95 RID: 19349 RVA: 0x0002C695 File Offset: 0x0002A895
			public unsafe SECTR_AudioCue ImpactCue
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SECTR_ImpactAudio.ImpactSound.NativeFieldInfoPtr_ImpactCue);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<SECTR_AudioCue>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SECTR_ImpactAudio.ImpactSound.NativeFieldInfoPtr_ImpactCue), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400318E RID: 12686
			private static readonly IntPtr NativeFieldInfoPtr_SurfaceMaterial;

			// Token: 0x0400318F RID: 12687
			private static readonly IntPtr NativeFieldInfoPtr_ImpactCue;

			// Token: 0x04003190 RID: 12688
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}
	}
}
