using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace Il2Cpp
{
	// Token: 0x0200003D RID: 61
	public class SECTR_CharacterAudio : MonoBehaviour
	{
		// Token: 0x06000A10 RID: 2576 RVA: 0x00051D94 File Offset: 0x0004FF94
		// Note: this type is marked as 'beforefieldinit'.
		static SECTR_CharacterAudio()
		{
			Il2CppClassPointerStore<SECTR_CharacterAudio>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "SECTR_CharacterAudio");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SECTR_CharacterAudio>.NativeClassPtr);
			SECTR_CharacterAudio.NativeFieldInfoPtr_surfaceTable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SECTR_CharacterAudio>.NativeClassPtr, "surfaceTable");
			SECTR_CharacterAudio.NativeFieldInfoPtr_DefaultSounds = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SECTR_CharacterAudio>.NativeClassPtr, "DefaultSounds");
			SECTR_CharacterAudio.NativeFieldInfoPtr_SurfaceSounds = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SECTR_CharacterAudio>.NativeClassPtr, "SurfaceSounds");
			SECTR_CharacterAudio.NativeMethodInfoPtr_OnEnable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SECTR_CharacterAudio>.NativeClassPtr, 100664121);
			SECTR_CharacterAudio.NativeMethodInfoPtr_OnDisable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SECTR_CharacterAudio>.NativeClassPtr, 100664122);
			SECTR_CharacterAudio.NativeMethodInfoPtr_OnFootstep_Private_Void_PhysicMaterial_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SECTR_CharacterAudio>.NativeClassPtr, 100664123);
			SECTR_CharacterAudio.NativeMethodInfoPtr_OnJump_Private_Void_PhysicMaterial_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SECTR_CharacterAudio>.NativeClassPtr, 100664124);
			SECTR_CharacterAudio.NativeMethodInfoPtr_OnLand_Private_Void_PhysicMaterial_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SECTR_CharacterAudio>.NativeClassPtr, 100664125);
			SECTR_CharacterAudio.NativeMethodInfoPtr__GetCurrentSurface_Private_SurfaceSound_PhysicMaterial_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SECTR_CharacterAudio>.NativeClassPtr, 100664126);
			SECTR_CharacterAudio.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SECTR_CharacterAudio>.NativeClassPtr, 100664127);
		}

		// Token: 0x06000A11 RID: 2577 RVA: 0x00051E8C File Offset: 0x0005008C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 39573, XrefRangeEnd = 39598, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnEnable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SECTR_CharacterAudio.NativeMethodInfoPtr_OnEnable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000A12 RID: 2578 RVA: 0x00051EC0 File Offset: 0x000500C0
		[CallerCount(0)]
		public unsafe void OnDisable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SECTR_CharacterAudio.NativeMethodInfoPtr_OnDisable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000A13 RID: 2579 RVA: 0x00051EF4 File Offset: 0x000500F4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 39598, XrefRangeEnd = 39611, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnFootstep(PhysicMaterial currentMaterial)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(currentMaterial);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SECTR_CharacterAudio.NativeMethodInfoPtr_OnFootstep_Private_Void_PhysicMaterial_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000A14 RID: 2580 RVA: 0x00051F38 File Offset: 0x00050138
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 39611, XrefRangeEnd = 39624, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnJump(PhysicMaterial currentMaterial)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(currentMaterial);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SECTR_CharacterAudio.NativeMethodInfoPtr_OnJump_Private_Void_PhysicMaterial_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000A15 RID: 2581 RVA: 0x00051F7C File Offset: 0x0005017C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 39624, XrefRangeEnd = 39637, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnLand(PhysicMaterial currentMaterial)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(currentMaterial);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SECTR_CharacterAudio.NativeMethodInfoPtr_OnLand_Private_Void_PhysicMaterial_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000A16 RID: 2582 RVA: 0x00051FC0 File Offset: 0x000501C0
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 39651, RefRangeEnd = 39654, XrefRangeStart = 39637, XrefRangeEnd = 39651, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SECTR_CharacterAudio.SurfaceSound _GetCurrentSurface(PhysicMaterial currentMaterial)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(currentMaterial);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SECTR_CharacterAudio.NativeMethodInfoPtr__GetCurrentSurface_Private_SurfaceSound_PhysicMaterial_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<SECTR_CharacterAudio.SurfaceSound>(intPtr3) : null;
			}
		}

		// Token: 0x06000A17 RID: 2583 RVA: 0x00052010 File Offset: 0x00050210
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 39654, XrefRangeEnd = 39666, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SECTR_CharacterAudio()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SECTR_CharacterAudio>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SECTR_CharacterAudio.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000A18 RID: 2584 RVA: 0x000085E1 File Offset: 0x000067E1
		public SECTR_CharacterAudio(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170003B9 RID: 953
		// (get) Token: 0x06000A19 RID: 2585 RVA: 0x0005204C File Offset: 0x0005024C
		// (set) Token: 0x06000A1A RID: 2586 RVA: 0x000085EA File Offset: 0x000067EA
		public unsafe Dictionary<PhysicMaterial, SECTR_CharacterAudio.SurfaceSound> surfaceTable
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SECTR_CharacterAudio.NativeFieldInfoPtr_surfaceTable);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<PhysicMaterial, SECTR_CharacterAudio.SurfaceSound>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SECTR_CharacterAudio.NativeFieldInfoPtr_surfaceTable), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170003BA RID: 954
		// (get) Token: 0x06000A1B RID: 2587 RVA: 0x0005207C File Offset: 0x0005027C
		// (set) Token: 0x06000A1C RID: 2588 RVA: 0x00008609 File Offset: 0x00006809
		public unsafe SECTR_CharacterAudio.SurfaceSound DefaultSounds
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SECTR_CharacterAudio.NativeFieldInfoPtr_DefaultSounds);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SECTR_CharacterAudio.SurfaceSound>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SECTR_CharacterAudio.NativeFieldInfoPtr_DefaultSounds), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170003BB RID: 955
		// (get) Token: 0x06000A1D RID: 2589 RVA: 0x000520AC File Offset: 0x000502AC
		// (set) Token: 0x06000A1E RID: 2590 RVA: 0x00008628 File Offset: 0x00006828
		public unsafe List<SECTR_CharacterAudio.SurfaceSound> SurfaceSounds
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SECTR_CharacterAudio.NativeFieldInfoPtr_SurfaceSounds);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<SECTR_CharacterAudio.SurfaceSound>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SECTR_CharacterAudio.NativeFieldInfoPtr_SurfaceSounds), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400061A RID: 1562
		private static readonly IntPtr NativeFieldInfoPtr_surfaceTable;

		// Token: 0x0400061B RID: 1563
		private static readonly IntPtr NativeFieldInfoPtr_DefaultSounds;

		// Token: 0x0400061C RID: 1564
		private static readonly IntPtr NativeFieldInfoPtr_SurfaceSounds;

		// Token: 0x0400061D RID: 1565
		private static readonly IntPtr NativeMethodInfoPtr_OnEnable_Private_Void_0;

		// Token: 0x0400061E RID: 1566
		private static readonly IntPtr NativeMethodInfoPtr_OnDisable_Private_Void_0;

		// Token: 0x0400061F RID: 1567
		private static readonly IntPtr NativeMethodInfoPtr_OnFootstep_Private_Void_PhysicMaterial_0;

		// Token: 0x04000620 RID: 1568
		private static readonly IntPtr NativeMethodInfoPtr_OnJump_Private_Void_PhysicMaterial_0;

		// Token: 0x04000621 RID: 1569
		private static readonly IntPtr NativeMethodInfoPtr_OnLand_Private_Void_PhysicMaterial_0;

		// Token: 0x04000622 RID: 1570
		private static readonly IntPtr NativeMethodInfoPtr__GetCurrentSurface_Private_SurfaceSound_PhysicMaterial_0;

		// Token: 0x04000623 RID: 1571
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x020002B7 RID: 695
		[Serializable]
		public class SurfaceSound : global::Il2CppSystem.Object
		{
			// Token: 0x06004B6F RID: 19311 RVA: 0x00117060 File Offset: 0x00115260
			// Note: this type is marked as 'beforefieldinit'.
			static SurfaceSound()
			{
				Il2CppClassPointerStore<SECTR_CharacterAudio.SurfaceSound>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SECTR_CharacterAudio>.NativeClassPtr, "SurfaceSound");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SECTR_CharacterAudio.SurfaceSound>.NativeClassPtr);
				SECTR_CharacterAudio.SurfaceSound.NativeFieldInfoPtr_SurfaceMaterial = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SECTR_CharacterAudio.SurfaceSound>.NativeClassPtr, "SurfaceMaterial");
				SECTR_CharacterAudio.SurfaceSound.NativeFieldInfoPtr_FootstepCue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SECTR_CharacterAudio.SurfaceSound>.NativeClassPtr, "FootstepCue");
				SECTR_CharacterAudio.SurfaceSound.NativeFieldInfoPtr_JumpCue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SECTR_CharacterAudio.SurfaceSound>.NativeClassPtr, "JumpCue");
				SECTR_CharacterAudio.SurfaceSound.NativeFieldInfoPtr_LandCue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SECTR_CharacterAudio.SurfaceSound>.NativeClassPtr, "LandCue");
				SECTR_CharacterAudio.SurfaceSound.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SECTR_CharacterAudio.SurfaceSound>.NativeClassPtr, 100664128);
			}

			// Token: 0x06004B70 RID: 19312 RVA: 0x001170F0 File Offset: 0x001152F0
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe SurfaceSound()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SECTR_CharacterAudio.SurfaceSound>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SECTR_CharacterAudio.SurfaceSound.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06004B71 RID: 19313 RVA: 0x0002C50E File Offset: 0x0002A70E
			public SurfaceSound(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001B77 RID: 7031
			// (get) Token: 0x06004B72 RID: 19314 RVA: 0x0011712C File Offset: 0x0011532C
			// (set) Token: 0x06004B73 RID: 19315 RVA: 0x0002C517 File Offset: 0x0002A717
			public unsafe PhysicMaterial SurfaceMaterial
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SECTR_CharacterAudio.SurfaceSound.NativeFieldInfoPtr_SurfaceMaterial);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<PhysicMaterial>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SECTR_CharacterAudio.SurfaceSound.NativeFieldInfoPtr_SurfaceMaterial), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001B78 RID: 7032
			// (get) Token: 0x06004B74 RID: 19316 RVA: 0x0011715C File Offset: 0x0011535C
			// (set) Token: 0x06004B75 RID: 19317 RVA: 0x0002C536 File Offset: 0x0002A736
			public unsafe SECTR_AudioCue FootstepCue
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SECTR_CharacterAudio.SurfaceSound.NativeFieldInfoPtr_FootstepCue);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<SECTR_AudioCue>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SECTR_CharacterAudio.SurfaceSound.NativeFieldInfoPtr_FootstepCue), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001B79 RID: 7033
			// (get) Token: 0x06004B76 RID: 19318 RVA: 0x0011718C File Offset: 0x0011538C
			// (set) Token: 0x06004B77 RID: 19319 RVA: 0x0002C555 File Offset: 0x0002A755
			public unsafe SECTR_AudioCue JumpCue
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SECTR_CharacterAudio.SurfaceSound.NativeFieldInfoPtr_JumpCue);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<SECTR_AudioCue>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SECTR_CharacterAudio.SurfaceSound.NativeFieldInfoPtr_JumpCue), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001B7A RID: 7034
			// (get) Token: 0x06004B78 RID: 19320 RVA: 0x001171BC File Offset: 0x001153BC
			// (set) Token: 0x06004B79 RID: 19321 RVA: 0x0002C574 File Offset: 0x0002A774
			public unsafe SECTR_AudioCue LandCue
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SECTR_CharacterAudio.SurfaceSound.NativeFieldInfoPtr_LandCue);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<SECTR_AudioCue>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SECTR_CharacterAudio.SurfaceSound.NativeFieldInfoPtr_LandCue), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400317B RID: 12667
			private static readonly IntPtr NativeFieldInfoPtr_SurfaceMaterial;

			// Token: 0x0400317C RID: 12668
			private static readonly IntPtr NativeFieldInfoPtr_FootstepCue;

			// Token: 0x0400317D RID: 12669
			private static readonly IntPtr NativeFieldInfoPtr_JumpCue;

			// Token: 0x0400317E RID: 12670
			private static readonly IntPtr NativeFieldInfoPtr_LandCue;

			// Token: 0x0400317F RID: 12671
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}
	}
}
