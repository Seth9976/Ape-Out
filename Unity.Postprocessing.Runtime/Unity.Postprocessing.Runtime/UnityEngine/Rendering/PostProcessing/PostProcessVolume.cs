using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;

namespace UnityEngine.Rendering.PostProcessing
{
	// Token: 0x02000059 RID: 89
	public sealed class PostProcessVolume : MonoBehaviour
	{
		// Token: 0x0600049B RID: 1179 RVA: 0x00014CBC File Offset: 0x00012EBC
		// Note: this type is marked as 'beforefieldinit'.
		static PostProcessVolume()
		{
			Il2CppClassPointerStore<PostProcessVolume>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.Postprocessing.Runtime.dll", "UnityEngine.Rendering.PostProcessing", "PostProcessVolume");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PostProcessVolume>.NativeClassPtr);
			PostProcessVolume.NativeFieldInfoPtr_sharedProfile = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PostProcessVolume>.NativeClassPtr, "sharedProfile");
			PostProcessVolume.NativeFieldInfoPtr_isGlobal = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PostProcessVolume>.NativeClassPtr, "isGlobal");
			PostProcessVolume.NativeFieldInfoPtr_blendDistance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PostProcessVolume>.NativeClassPtr, "blendDistance");
			PostProcessVolume.NativeFieldInfoPtr_weight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PostProcessVolume>.NativeClassPtr, "weight");
			PostProcessVolume.NativeFieldInfoPtr_priority = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PostProcessVolume>.NativeClassPtr, "priority");
			PostProcessVolume.NativeFieldInfoPtr_m_PreviousLayer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PostProcessVolume>.NativeClassPtr, "m_PreviousLayer");
			PostProcessVolume.NativeFieldInfoPtr_m_PreviousPriority = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PostProcessVolume>.NativeClassPtr, "m_PreviousPriority");
			PostProcessVolume.NativeFieldInfoPtr_m_TempColliders = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PostProcessVolume>.NativeClassPtr, "m_TempColliders");
			PostProcessVolume.NativeFieldInfoPtr_m_InternalProfile = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PostProcessVolume>.NativeClassPtr, "m_InternalProfile");
			PostProcessVolume.NativeMethodInfoPtr_get_profile_Public_get_PostProcessProfile_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PostProcessVolume>.NativeClassPtr, 100663734);
			PostProcessVolume.NativeMethodInfoPtr_set_profile_Public_set_Void_PostProcessProfile_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PostProcessVolume>.NativeClassPtr, 100663735);
			PostProcessVolume.NativeMethodInfoPtr_get_profileRef_Internal_get_PostProcessProfile_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PostProcessVolume>.NativeClassPtr, 100663736);
			PostProcessVolume.NativeMethodInfoPtr_HasInstantiatedProfile_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PostProcessVolume>.NativeClassPtr, 100663737);
			PostProcessVolume.NativeMethodInfoPtr_OnEnable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PostProcessVolume>.NativeClassPtr, 100663738);
			PostProcessVolume.NativeMethodInfoPtr_OnDisable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PostProcessVolume>.NativeClassPtr, 100663739);
			PostProcessVolume.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PostProcessVolume>.NativeClassPtr, 100663740);
			PostProcessVolume.NativeMethodInfoPtr_OnDrawGizmos_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PostProcessVolume>.NativeClassPtr, 100663741);
			PostProcessVolume.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PostProcessVolume>.NativeClassPtr, 100663742);
		}

		// Token: 0x17000165 RID: 357
		// (get) Token: 0x0600049C RID: 1180 RVA: 0x00014E54 File Offset: 0x00013054
		// (set) Token: 0x0600049D RID: 1181 RVA: 0x00014E94 File Offset: 0x00013094
		public unsafe PostProcessProfile profile
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 448236, RefRangeEnd = 448237, XrefRangeStart = 448194, XrefRangeEnd = 448236, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PostProcessVolume.NativeMethodInfoPtr_get_profile_Public_get_PostProcessProfile_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<PostProcessProfile>(intPtr3) : null;
			}
			[CallerCount(43)]
			[CachedScanResults(RefRangeStart = 13782, RefRangeEnd = 13825, XrefRangeStart = 13782, XrefRangeEnd = 13825, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PostProcessVolume.NativeMethodInfoPtr_set_profile_Public_set_Void_PostProcessProfile_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000166 RID: 358
		// (get) Token: 0x0600049E RID: 1182 RVA: 0x00014ED8 File Offset: 0x000130D8
		public unsafe PostProcessProfile profileRef
		{
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 448249, RefRangeEnd = 448253, XrefRangeStart = 448237, XrefRangeEnd = 448249, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PostProcessVolume.NativeMethodInfoPtr_get_profileRef_Internal_get_PostProcessProfile_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<PostProcessProfile>(intPtr3) : null;
			}
		}

		// Token: 0x0600049F RID: 1183 RVA: 0x00014F18 File Offset: 0x00013118
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 448253, XrefRangeEnd = 448265, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool HasInstantiatedProfile()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PostProcessVolume.NativeMethodInfoPtr_HasInstantiatedProfile_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060004A0 RID: 1184 RVA: 0x00014F54 File Offset: 0x00013154
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 448265, XrefRangeEnd = 448281, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnEnable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PostProcessVolume.NativeMethodInfoPtr_OnEnable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060004A1 RID: 1185 RVA: 0x00014F88 File Offset: 0x00013188
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 448281, XrefRangeEnd = 448292, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnDisable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PostProcessVolume.NativeMethodInfoPtr_OnDisable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060004A2 RID: 1186 RVA: 0x00014FBC File Offset: 0x000131BC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 448292, XrefRangeEnd = 448301, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PostProcessVolume.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060004A3 RID: 1187 RVA: 0x00014FF0 File Offset: 0x000131F0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 448301, XrefRangeEnd = 448396, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnDrawGizmos()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PostProcessVolume.NativeMethodInfoPtr_OnDrawGizmos_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060004A4 RID: 1188 RVA: 0x00015024 File Offset: 0x00013224
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 448396, XrefRangeEnd = 448399, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PostProcessVolume()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PostProcessVolume>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PostProcessVolume.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060004A5 RID: 1189 RVA: 0x0000481C File Offset: 0x00002A1C
		public PostProcessVolume(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700015C RID: 348
		// (get) Token: 0x060004A6 RID: 1190 RVA: 0x00015060 File Offset: 0x00013260
		// (set) Token: 0x060004A7 RID: 1191 RVA: 0x00004825 File Offset: 0x00002A25
		public unsafe PostProcessProfile sharedProfile
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PostProcessVolume.NativeFieldInfoPtr_sharedProfile);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<PostProcessProfile>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PostProcessVolume.NativeFieldInfoPtr_sharedProfile), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700015D RID: 349
		// (get) Token: 0x060004A8 RID: 1192 RVA: 0x00015090 File Offset: 0x00013290
		// (set) Token: 0x060004A9 RID: 1193 RVA: 0x00004844 File Offset: 0x00002A44
		public unsafe bool isGlobal
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PostProcessVolume.NativeFieldInfoPtr_isGlobal);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PostProcessVolume.NativeFieldInfoPtr_isGlobal)) = value;
			}
		}

		// Token: 0x1700015E RID: 350
		// (get) Token: 0x060004AA RID: 1194 RVA: 0x000150B8 File Offset: 0x000132B8
		// (set) Token: 0x060004AB RID: 1195 RVA: 0x0000485F File Offset: 0x00002A5F
		public unsafe float blendDistance
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PostProcessVolume.NativeFieldInfoPtr_blendDistance);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PostProcessVolume.NativeFieldInfoPtr_blendDistance)) = value;
			}
		}

		// Token: 0x1700015F RID: 351
		// (get) Token: 0x060004AC RID: 1196 RVA: 0x000150E0 File Offset: 0x000132E0
		// (set) Token: 0x060004AD RID: 1197 RVA: 0x0000487A File Offset: 0x00002A7A
		public unsafe float weight
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PostProcessVolume.NativeFieldInfoPtr_weight);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PostProcessVolume.NativeFieldInfoPtr_weight)) = value;
			}
		}

		// Token: 0x17000160 RID: 352
		// (get) Token: 0x060004AE RID: 1198 RVA: 0x00015108 File Offset: 0x00013308
		// (set) Token: 0x060004AF RID: 1199 RVA: 0x00004895 File Offset: 0x00002A95
		public unsafe float priority
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PostProcessVolume.NativeFieldInfoPtr_priority);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PostProcessVolume.NativeFieldInfoPtr_priority)) = value;
			}
		}

		// Token: 0x17000161 RID: 353
		// (get) Token: 0x060004B0 RID: 1200 RVA: 0x00015130 File Offset: 0x00013330
		// (set) Token: 0x060004B1 RID: 1201 RVA: 0x000048B0 File Offset: 0x00002AB0
		public unsafe int m_PreviousLayer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PostProcessVolume.NativeFieldInfoPtr_m_PreviousLayer);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PostProcessVolume.NativeFieldInfoPtr_m_PreviousLayer)) = value;
			}
		}

		// Token: 0x17000162 RID: 354
		// (get) Token: 0x060004B2 RID: 1202 RVA: 0x00015158 File Offset: 0x00013358
		// (set) Token: 0x060004B3 RID: 1203 RVA: 0x000048CB File Offset: 0x00002ACB
		public unsafe float m_PreviousPriority
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PostProcessVolume.NativeFieldInfoPtr_m_PreviousPriority);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PostProcessVolume.NativeFieldInfoPtr_m_PreviousPriority)) = value;
			}
		}

		// Token: 0x17000163 RID: 355
		// (get) Token: 0x060004B4 RID: 1204 RVA: 0x00015180 File Offset: 0x00013380
		// (set) Token: 0x060004B5 RID: 1205 RVA: 0x000048E6 File Offset: 0x00002AE6
		public unsafe List<Collider> m_TempColliders
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PostProcessVolume.NativeFieldInfoPtr_m_TempColliders);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Collider>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PostProcessVolume.NativeFieldInfoPtr_m_TempColliders), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000164 RID: 356
		// (get) Token: 0x060004B6 RID: 1206 RVA: 0x000151B0 File Offset: 0x000133B0
		// (set) Token: 0x060004B7 RID: 1207 RVA: 0x00004905 File Offset: 0x00002B05
		public unsafe PostProcessProfile m_InternalProfile
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PostProcessVolume.NativeFieldInfoPtr_m_InternalProfile);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<PostProcessProfile>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PostProcessVolume.NativeFieldInfoPtr_m_InternalProfile), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000319 RID: 793
		private static readonly IntPtr NativeFieldInfoPtr_sharedProfile;

		// Token: 0x0400031A RID: 794
		private static readonly IntPtr NativeFieldInfoPtr_isGlobal;

		// Token: 0x0400031B RID: 795
		private static readonly IntPtr NativeFieldInfoPtr_blendDistance;

		// Token: 0x0400031C RID: 796
		private static readonly IntPtr NativeFieldInfoPtr_weight;

		// Token: 0x0400031D RID: 797
		private static readonly IntPtr NativeFieldInfoPtr_priority;

		// Token: 0x0400031E RID: 798
		private static readonly IntPtr NativeFieldInfoPtr_m_PreviousLayer;

		// Token: 0x0400031F RID: 799
		private static readonly IntPtr NativeFieldInfoPtr_m_PreviousPriority;

		// Token: 0x04000320 RID: 800
		private static readonly IntPtr NativeFieldInfoPtr_m_TempColliders;

		// Token: 0x04000321 RID: 801
		private static readonly IntPtr NativeFieldInfoPtr_m_InternalProfile;

		// Token: 0x04000322 RID: 802
		private static readonly IntPtr NativeMethodInfoPtr_get_profile_Public_get_PostProcessProfile_0;

		// Token: 0x04000323 RID: 803
		private static readonly IntPtr NativeMethodInfoPtr_set_profile_Public_set_Void_PostProcessProfile_0;

		// Token: 0x04000324 RID: 804
		private static readonly IntPtr NativeMethodInfoPtr_get_profileRef_Internal_get_PostProcessProfile_0;

		// Token: 0x04000325 RID: 805
		private static readonly IntPtr NativeMethodInfoPtr_HasInstantiatedProfile_Public_Boolean_0;

		// Token: 0x04000326 RID: 806
		private static readonly IntPtr NativeMethodInfoPtr_OnEnable_Private_Void_0;

		// Token: 0x04000327 RID: 807
		private static readonly IntPtr NativeMethodInfoPtr_OnDisable_Private_Void_0;

		// Token: 0x04000328 RID: 808
		private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

		// Token: 0x04000329 RID: 809
		private static readonly IntPtr NativeMethodInfoPtr_OnDrawGizmos_Private_Void_0;

		// Token: 0x0400032A RID: 810
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
