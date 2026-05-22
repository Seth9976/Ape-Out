using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace Il2Cpp
{
	// Token: 0x0200001B RID: 27
	public static class ResonanceAudioRoomManager : global::Il2CppSystem.Object
	{
		// Token: 0x060003BF RID: 959 RVA: 0x0003E558 File Offset: 0x0003C758
		// Note: this type is marked as 'beforefieldinit'.
		static ResonanceAudioRoomManager()
		{
			Il2CppClassPointerStore<ResonanceAudioRoomManager>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "ResonanceAudioRoomManager");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ResonanceAudioRoomManager>.NativeClassPtr);
			ResonanceAudioRoomManager.NativeFieldInfoPtr_roomEffectsRegions = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResonanceAudioRoomManager>.NativeClassPtr, "roomEffectsRegions");
			ResonanceAudioRoomManager.NativeFieldInfoPtr_bounds = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResonanceAudioRoomManager>.NativeClassPtr, "bounds");
			ResonanceAudioRoomManager.NativeMethodInfoPtr_ComputeRoomEffectsGain_Public_Static_Single_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResonanceAudioRoomManager>.NativeClassPtr, 100663535);
			ResonanceAudioRoomManager.NativeMethodInfoPtr_UpdateRoom_Public_Static_Void_ResonanceAudioRoom_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResonanceAudioRoomManager>.NativeClassPtr, 100663536);
			ResonanceAudioRoomManager.NativeMethodInfoPtr_RemoveRoom_Public_Static_Void_ResonanceAudioRoom_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResonanceAudioRoomManager>.NativeClassPtr, 100663537);
			ResonanceAudioRoomManager.NativeMethodInfoPtr_UpdateReverbProbe_Public_Static_Void_ResonanceAudioReverbProbe_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResonanceAudioRoomManager>.NativeClassPtr, 100663538);
			ResonanceAudioRoomManager.NativeMethodInfoPtr_RemoveReverbProbe_Public_Static_Void_ResonanceAudioReverbProbe_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResonanceAudioRoomManager>.NativeClassPtr, 100663539);
			ResonanceAudioRoomManager.NativeMethodInfoPtr_UpdateRoomEffectsRegions_Private_Static_Void_ResonanceAudioRoom_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResonanceAudioRoomManager>.NativeClassPtr, 100663540);
			ResonanceAudioRoomManager.NativeMethodInfoPtr_UpdateRoomEffectsRegions_Private_Static_Void_ResonanceAudioReverbProbe_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResonanceAudioRoomManager>.NativeClassPtr, 100663541);
			ResonanceAudioRoomManager.NativeMethodInfoPtr_UpdateRoomEffects_Private_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResonanceAudioRoomManager>.NativeClassPtr, 100663542);
			ResonanceAudioRoomManager.NativeMethodInfoPtr_ComputeRoomEffectsAttenuation_Private_Static_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResonanceAudioRoomManager>.NativeClassPtr, 100663543);
			ResonanceAudioRoomManager.NativeMethodInfoPtr_IsListenerInsideRoom_Private_Static_Boolean_ResonanceAudioRoom_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResonanceAudioRoomManager>.NativeClassPtr, 100663544);
			ResonanceAudioRoomManager.NativeMethodInfoPtr_IsListenerInsideVisibleReverbProbe_Private_Static_Boolean_ResonanceAudioReverbProbe_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResonanceAudioRoomManager>.NativeClassPtr, 100663545);
		}

		// Token: 0x060003C0 RID: 960 RVA: 0x0003E68C File Offset: 0x0003C88C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 34065, RefRangeEnd = 34066, XrefRangeStart = 33994, XrefRangeEnd = 34065, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static float ComputeRoomEffectsGain(Vector3 sourcePosition)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref sourcePosition;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResonanceAudioRoomManager.NativeMethodInfoPtr_ComputeRoomEffectsGain_Public_Static_Single_Vector3_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060003C1 RID: 961 RVA: 0x0003E6CC File Offset: 0x0003C8CC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 34072, RefRangeEnd = 34074, XrefRangeStart = 34066, XrefRangeEnd = 34072, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void UpdateRoom(ResonanceAudioRoom room)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(room);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResonanceAudioRoomManager.NativeMethodInfoPtr_UpdateRoom_Public_Static_Void_ResonanceAudioRoom_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060003C2 RID: 962 RVA: 0x0003E704 File Offset: 0x0003C904
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 34074, XrefRangeEnd = 34079, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void RemoveRoom(ResonanceAudioRoom room)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(room);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResonanceAudioRoomManager.NativeMethodInfoPtr_RemoveRoom_Public_Static_Void_ResonanceAudioRoom_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060003C3 RID: 963 RVA: 0x0003E73C File Offset: 0x0003C93C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 34085, RefRangeEnd = 34087, XrefRangeStart = 34079, XrefRangeEnd = 34085, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void UpdateReverbProbe(ResonanceAudioReverbProbe reverbProbe)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(reverbProbe);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResonanceAudioRoomManager.NativeMethodInfoPtr_UpdateReverbProbe_Public_Static_Void_ResonanceAudioReverbProbe_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060003C4 RID: 964 RVA: 0x0003E774 File Offset: 0x0003C974
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 34087, XrefRangeEnd = 34092, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void RemoveReverbProbe(ResonanceAudioReverbProbe reverbProbe)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(reverbProbe);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResonanceAudioRoomManager.NativeMethodInfoPtr_RemoveReverbProbe_Public_Static_Void_ResonanceAudioReverbProbe_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060003C5 RID: 965 RVA: 0x0003E7AC File Offset: 0x0003C9AC
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 34137, RefRangeEnd = 34140, XrefRangeStart = 34092, XrefRangeEnd = 34137, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void UpdateRoomEffectsRegions(ResonanceAudioRoom room, bool isEnabled)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(room);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isEnabled;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResonanceAudioRoomManager.NativeMethodInfoPtr_UpdateRoomEffectsRegions_Private_Static_Void_ResonanceAudioRoom_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060003C6 RID: 966 RVA: 0x0003E7F0 File Offset: 0x0003C9F0
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 34185, RefRangeEnd = 34188, XrefRangeStart = 34140, XrefRangeEnd = 34185, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void UpdateRoomEffectsRegions(ResonanceAudioReverbProbe reverbProbe, bool isEnabled)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(reverbProbe);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isEnabled;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResonanceAudioRoomManager.NativeMethodInfoPtr_UpdateRoomEffectsRegions_Private_Static_Void_ResonanceAudioReverbProbe_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060003C7 RID: 967 RVA: 0x0003E834 File Offset: 0x0003CA34
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 34212, RefRangeEnd = 34218, XrefRangeStart = 34188, XrefRangeEnd = 34212, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void UpdateRoomEffects()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResonanceAudioRoomManager.NativeMethodInfoPtr_UpdateRoomEffects_Private_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060003C8 RID: 968 RVA: 0x0003E85C File Offset: 0x0003CA5C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 34218, XrefRangeEnd = 34219, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static float ComputeRoomEffectsAttenuation(float distanceToRoom)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref distanceToRoom;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResonanceAudioRoomManager.NativeMethodInfoPtr_ComputeRoomEffectsAttenuation_Private_Static_Single_Single_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060003C9 RID: 969 RVA: 0x0003E89C File Offset: 0x0003CA9C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 34259, RefRangeEnd = 34260, XrefRangeStart = 34219, XrefRangeEnd = 34259, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsListenerInsideRoom(ResonanceAudioRoom room)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(room);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResonanceAudioRoomManager.NativeMethodInfoPtr_IsListenerInsideRoom_Private_Static_Boolean_ResonanceAudioRoom_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060003CA RID: 970 RVA: 0x0003E8E0 File Offset: 0x0003CAE0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 34298, RefRangeEnd = 34299, XrefRangeStart = 34260, XrefRangeEnd = 34298, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsListenerInsideVisibleReverbProbe(ResonanceAudioReverbProbe reverbProbe)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(reverbProbe);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResonanceAudioRoomManager.NativeMethodInfoPtr_IsListenerInsideVisibleReverbProbe_Private_Static_Boolean_ResonanceAudioReverbProbe_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060003CB RID: 971 RVA: 0x0000487D File Offset: 0x00002A7D
		public ResonanceAudioRoomManager(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000170 RID: 368
		// (get) Token: 0x060003CC RID: 972 RVA: 0x0003E924 File Offset: 0x0003CB24
		// (set) Token: 0x060003CD RID: 973 RVA: 0x00004886 File Offset: 0x00002A86
		public unsafe static List<ResonanceAudioRoomManager.RoomEffectsRegion> roomEffectsRegions
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ResonanceAudioRoomManager.NativeFieldInfoPtr_roomEffectsRegions, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<ResonanceAudioRoomManager.RoomEffectsRegion>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ResonanceAudioRoomManager.NativeFieldInfoPtr_roomEffectsRegions, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000171 RID: 369
		// (get) Token: 0x060003CE RID: 974 RVA: 0x0003E94C File Offset: 0x0003CB4C
		// (set) Token: 0x060003CF RID: 975 RVA: 0x00004898 File Offset: 0x00002A98
		public unsafe static Bounds bounds
		{
			get
			{
				Bounds bounds;
				IL2CPP.il2cpp_field_static_get_value(ResonanceAudioRoomManager.NativeFieldInfoPtr_bounds, (void*)(&bounds));
				return bounds;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ResonanceAudioRoomManager.NativeFieldInfoPtr_bounds, (void*)(&value));
			}
		}

		// Token: 0x04000225 RID: 549
		private static readonly IntPtr NativeFieldInfoPtr_roomEffectsRegions;

		// Token: 0x04000226 RID: 550
		private static readonly IntPtr NativeFieldInfoPtr_bounds;

		// Token: 0x04000227 RID: 551
		private static readonly IntPtr NativeMethodInfoPtr_ComputeRoomEffectsGain_Public_Static_Single_Vector3_0;

		// Token: 0x04000228 RID: 552
		private static readonly IntPtr NativeMethodInfoPtr_UpdateRoom_Public_Static_Void_ResonanceAudioRoom_0;

		// Token: 0x04000229 RID: 553
		private static readonly IntPtr NativeMethodInfoPtr_RemoveRoom_Public_Static_Void_ResonanceAudioRoom_0;

		// Token: 0x0400022A RID: 554
		private static readonly IntPtr NativeMethodInfoPtr_UpdateReverbProbe_Public_Static_Void_ResonanceAudioReverbProbe_0;

		// Token: 0x0400022B RID: 555
		private static readonly IntPtr NativeMethodInfoPtr_RemoveReverbProbe_Public_Static_Void_ResonanceAudioReverbProbe_0;

		// Token: 0x0400022C RID: 556
		private static readonly IntPtr NativeMethodInfoPtr_UpdateRoomEffectsRegions_Private_Static_Void_ResonanceAudioRoom_Boolean_0;

		// Token: 0x0400022D RID: 557
		private static readonly IntPtr NativeMethodInfoPtr_UpdateRoomEffectsRegions_Private_Static_Void_ResonanceAudioReverbProbe_Boolean_0;

		// Token: 0x0400022E RID: 558
		private static readonly IntPtr NativeMethodInfoPtr_UpdateRoomEffects_Private_Static_Void_0;

		// Token: 0x0400022F RID: 559
		private static readonly IntPtr NativeMethodInfoPtr_ComputeRoomEffectsAttenuation_Private_Static_Single_Single_0;

		// Token: 0x04000230 RID: 560
		private static readonly IntPtr NativeMethodInfoPtr_IsListenerInsideRoom_Private_Static_Boolean_ResonanceAudioRoom_0;

		// Token: 0x04000231 RID: 561
		private static readonly IntPtr NativeMethodInfoPtr_IsListenerInsideVisibleReverbProbe_Private_Static_Boolean_ResonanceAudioReverbProbe_0;

		// Token: 0x020002A1 RID: 673
		[OriginalName("Assembly-CSharp.dll", "", "SurfaceMaterial")]
		public enum SurfaceMaterial
		{
			// Token: 0x04003075 RID: 12405
			Transparent,
			// Token: 0x04003076 RID: 12406
			AcousticCeilingTiles,
			// Token: 0x04003077 RID: 12407
			BrickBare,
			// Token: 0x04003078 RID: 12408
			BrickPainted,
			// Token: 0x04003079 RID: 12409
			ConcreteBlockCoarse,
			// Token: 0x0400307A RID: 12410
			ConcreteBlockPainted,
			// Token: 0x0400307B RID: 12411
			CurtainHeavy,
			// Token: 0x0400307C RID: 12412
			FiberglassInsulation,
			// Token: 0x0400307D RID: 12413
			GlassThin,
			// Token: 0x0400307E RID: 12414
			GlassThick,
			// Token: 0x0400307F RID: 12415
			Grass,
			// Token: 0x04003080 RID: 12416
			LinoleumOnConcrete,
			// Token: 0x04003081 RID: 12417
			Marble,
			// Token: 0x04003082 RID: 12418
			Metal,
			// Token: 0x04003083 RID: 12419
			ParquetOnConcrete,
			// Token: 0x04003084 RID: 12420
			PlasterRough,
			// Token: 0x04003085 RID: 12421
			PlasterSmooth,
			// Token: 0x04003086 RID: 12422
			PlywoodPanel,
			// Token: 0x04003087 RID: 12423
			PolishedConcreteOrTile,
			// Token: 0x04003088 RID: 12424
			Sheetrock,
			// Token: 0x04003089 RID: 12425
			WaterOrIceSurface,
			// Token: 0x0400308A RID: 12426
			WoodCeiling,
			// Token: 0x0400308B RID: 12427
			WoodPanel
		}

		// Token: 0x020002A2 RID: 674
		[Serializable]
		public class SurfaceMaterialDictionary : Dictionary<string, ResonanceAudioRoomManager.SurfaceMaterial>
		{
			// Token: 0x06004A74 RID: 19060 RVA: 0x00113CA8 File Offset: 0x00111EA8
			// Note: this type is marked as 'beforefieldinit'.
			static SurfaceMaterialDictionary()
			{
				Il2CppClassPointerStore<ResonanceAudioRoomManager.SurfaceMaterialDictionary>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ResonanceAudioRoomManager>.NativeClassPtr, "SurfaceMaterialDictionary");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ResonanceAudioRoomManager.SurfaceMaterialDictionary>.NativeClassPtr);
				ResonanceAudioRoomManager.SurfaceMaterialDictionary.NativeFieldInfoPtr_guids = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResonanceAudioRoomManager.SurfaceMaterialDictionary>.NativeClassPtr, "guids");
				ResonanceAudioRoomManager.SurfaceMaterialDictionary.NativeFieldInfoPtr_surfaceMaterials = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResonanceAudioRoomManager.SurfaceMaterialDictionary>.NativeClassPtr, "surfaceMaterials");
				ResonanceAudioRoomManager.SurfaceMaterialDictionary.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResonanceAudioRoomManager.SurfaceMaterialDictionary>.NativeClassPtr, 100663547);
				ResonanceAudioRoomManager.SurfaceMaterialDictionary.NativeMethodInfoPtr_OnBeforeSerialize_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResonanceAudioRoomManager.SurfaceMaterialDictionary>.NativeClassPtr, 100663548);
				ResonanceAudioRoomManager.SurfaceMaterialDictionary.NativeMethodInfoPtr_OnAfterDeserialize_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResonanceAudioRoomManager.SurfaceMaterialDictionary>.NativeClassPtr, 100663549);
			}

			// Token: 0x06004A75 RID: 19061 RVA: 0x00113D38 File Offset: 0x00111F38
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 33950, XrefRangeEnd = 33964, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe SurfaceMaterialDictionary()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ResonanceAudioRoomManager.SurfaceMaterialDictionary>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResonanceAudioRoomManager.SurfaceMaterialDictionary.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06004A76 RID: 19062 RVA: 0x00113D74 File Offset: 0x00111F74
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 33964, XrefRangeEnd = 33985, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe virtual void OnBeforeSerialize()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResonanceAudioRoomManager.SurfaceMaterialDictionary.NativeMethodInfoPtr_OnBeforeSerialize_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06004A77 RID: 19063 RVA: 0x00113DA8 File Offset: 0x00111FA8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 33985, XrefRangeEnd = 33994, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe virtual void OnAfterDeserialize()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResonanceAudioRoomManager.SurfaceMaterialDictionary.NativeMethodInfoPtr_OnAfterDeserialize_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06004A78 RID: 19064 RVA: 0x0002BDD0 File Offset: 0x00029FD0
			public SurfaceMaterialDictionary(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001B15 RID: 6933
			// (get) Token: 0x06004A79 RID: 19065 RVA: 0x00113DDC File Offset: 0x00111FDC
			// (set) Token: 0x06004A7A RID: 19066 RVA: 0x0002BDD9 File Offset: 0x00029FD9
			public unsafe List<string> guids
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResonanceAudioRoomManager.SurfaceMaterialDictionary.NativeFieldInfoPtr_guids);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<string>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResonanceAudioRoomManager.SurfaceMaterialDictionary.NativeFieldInfoPtr_guids), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001B16 RID: 6934
			// (get) Token: 0x06004A7B RID: 19067 RVA: 0x00113E0C File Offset: 0x0011200C
			// (set) Token: 0x06004A7C RID: 19068 RVA: 0x0002BDF8 File Offset: 0x00029FF8
			public unsafe List<ResonanceAudioRoomManager.SurfaceMaterial> surfaceMaterials
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResonanceAudioRoomManager.SurfaceMaterialDictionary.NativeFieldInfoPtr_surfaceMaterials);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<ResonanceAudioRoomManager.SurfaceMaterial>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResonanceAudioRoomManager.SurfaceMaterialDictionary.NativeFieldInfoPtr_surfaceMaterials), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400308C RID: 12428
			private static readonly IntPtr NativeFieldInfoPtr_guids;

			// Token: 0x0400308D RID: 12429
			private static readonly IntPtr NativeFieldInfoPtr_surfaceMaterials;

			// Token: 0x0400308E RID: 12430
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400308F RID: 12431
			private static readonly IntPtr NativeMethodInfoPtr_OnBeforeSerialize_Public_Virtual_Final_New_Void_0;

			// Token: 0x04003090 RID: 12432
			private static readonly IntPtr NativeMethodInfoPtr_OnAfterDeserialize_Public_Virtual_Final_New_Void_0;
		}

		// Token: 0x020002A3 RID: 675
		public sealed class RoomEffectsRegion : ValueType
		{
			// Token: 0x06004A7D RID: 19069 RVA: 0x00113E3C File Offset: 0x0011203C
			// Note: this type is marked as 'beforefieldinit'.
			static RoomEffectsRegion()
			{
				Il2CppClassPointerStore<ResonanceAudioRoomManager.RoomEffectsRegion>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ResonanceAudioRoomManager>.NativeClassPtr, "RoomEffectsRegion");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ResonanceAudioRoomManager.RoomEffectsRegion>.NativeClassPtr);
				ResonanceAudioRoomManager.RoomEffectsRegion.NativeFieldInfoPtr_room = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResonanceAudioRoomManager.RoomEffectsRegion>.NativeClassPtr, "room");
				ResonanceAudioRoomManager.RoomEffectsRegion.NativeFieldInfoPtr_reverbProbe = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResonanceAudioRoomManager.RoomEffectsRegion>.NativeClassPtr, "reverbProbe");
				ResonanceAudioRoomManager.RoomEffectsRegion.NativeMethodInfoPtr__ctor_Public_Void_ResonanceAudioRoom_ResonanceAudioReverbProbe_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResonanceAudioRoomManager.RoomEffectsRegion>.NativeClassPtr, 100663550);
			}

			// Token: 0x06004A7E RID: 19070 RVA: 0x00113EA4 File Offset: 0x001120A4
			[CallerCount(33)]
			[CachedScanResults(RefRangeStart = 5426, RefRangeEnd = 5459, XrefRangeStart = 5426, XrefRangeEnd = 5459, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe RoomEffectsRegion(ResonanceAudioRoom room, ResonanceAudioReverbProbe reverbProbe)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ResonanceAudioRoomManager.RoomEffectsRegion>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(room);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(reverbProbe);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResonanceAudioRoomManager.RoomEffectsRegion.NativeMethodInfoPtr__ctor_Public_Void_ResonanceAudioRoom_ResonanceAudioReverbProbe_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06004A7F RID: 19071 RVA: 0x0002BE17 File Offset: 0x0002A017
			public RoomEffectsRegion(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x06004A80 RID: 19072 RVA: 0x0002BE20 File Offset: 0x0002A020
			public RoomEffectsRegion()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ResonanceAudioRoomManager.RoomEffectsRegion>.NativeClassPtr))
			{
			}

			// Token: 0x17001B17 RID: 6935
			// (get) Token: 0x06004A81 RID: 19073 RVA: 0x00113F08 File Offset: 0x00112108
			// (set) Token: 0x06004A82 RID: 19074 RVA: 0x0002BE32 File Offset: 0x0002A032
			public unsafe ResonanceAudioRoom room
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResonanceAudioRoomManager.RoomEffectsRegion.NativeFieldInfoPtr_room);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ResonanceAudioRoom>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResonanceAudioRoomManager.RoomEffectsRegion.NativeFieldInfoPtr_room), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001B18 RID: 6936
			// (get) Token: 0x06004A83 RID: 19075 RVA: 0x00113F38 File Offset: 0x00112138
			// (set) Token: 0x06004A84 RID: 19076 RVA: 0x0002BE51 File Offset: 0x0002A051
			public unsafe ResonanceAudioReverbProbe reverbProbe
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResonanceAudioRoomManager.RoomEffectsRegion.NativeFieldInfoPtr_reverbProbe);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ResonanceAudioReverbProbe>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResonanceAudioRoomManager.RoomEffectsRegion.NativeFieldInfoPtr_reverbProbe), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04003091 RID: 12433
			private static readonly IntPtr NativeFieldInfoPtr_room;

			// Token: 0x04003092 RID: 12434
			private static readonly IntPtr NativeFieldInfoPtr_reverbProbe;

			// Token: 0x04003093 RID: 12435
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_ResonanceAudioRoom_ResonanceAudioReverbProbe_0;
		}
	}
}
