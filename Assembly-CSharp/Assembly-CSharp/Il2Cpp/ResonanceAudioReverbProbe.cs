using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace Il2Cpp
{
	// Token: 0x02000019 RID: 25
	public class ResonanceAudioReverbProbe : MonoBehaviour
	{
		// Token: 0x06000377 RID: 887 RVA: 0x0003DAE0 File Offset: 0x0003BCE0
		// Note: this type is marked as 'beforefieldinit'.
		static ResonanceAudioReverbProbe()
		{
			Il2CppClassPointerStore<ResonanceAudioReverbProbe>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "ResonanceAudioReverbProbe");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ResonanceAudioReverbProbe>.NativeClassPtr);
			ResonanceAudioReverbProbe.NativeFieldInfoPtr_rt60s = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResonanceAudioReverbProbe>.NativeClassPtr, "rt60s");
			ResonanceAudioReverbProbe.NativeFieldInfoPtr_reverbGainDb = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResonanceAudioReverbProbe>.NativeClassPtr, "reverbGainDb");
			ResonanceAudioReverbProbe.NativeFieldInfoPtr_reverbBrightness = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResonanceAudioReverbProbe>.NativeClassPtr, "reverbBrightness");
			ResonanceAudioReverbProbe.NativeFieldInfoPtr_reverbTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResonanceAudioReverbProbe>.NativeClassPtr, "reverbTime");
			ResonanceAudioReverbProbe.NativeFieldInfoPtr_regionShape = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResonanceAudioReverbProbe>.NativeClassPtr, "regionShape");
			ResonanceAudioReverbProbe.NativeFieldInfoPtr_boxRegionSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResonanceAudioReverbProbe>.NativeClassPtr, "boxRegionSize");
			ResonanceAudioReverbProbe.NativeFieldInfoPtr_sphereRegionRadius = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResonanceAudioReverbProbe>.NativeClassPtr, "sphereRegionRadius");
			ResonanceAudioReverbProbe.NativeFieldInfoPtr_onlyApplyWhenVisible = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResonanceAudioReverbProbe>.NativeClassPtr, "onlyApplyWhenVisible");
			ResonanceAudioReverbProbe.NativeFieldInfoPtr_proxyRoomPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResonanceAudioReverbProbe>.NativeClassPtr, "proxyRoomPosition");
			ResonanceAudioReverbProbe.NativeFieldInfoPtr_proxyRoomRotation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResonanceAudioReverbProbe>.NativeClassPtr, "proxyRoomRotation");
			ResonanceAudioReverbProbe.NativeFieldInfoPtr_proxyRoomSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResonanceAudioReverbProbe>.NativeClassPtr, "proxyRoomSize");
			ResonanceAudioReverbProbe.NativeFieldInfoPtr_proxyRoomLeftWall = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResonanceAudioReverbProbe>.NativeClassPtr, "proxyRoomLeftWall");
			ResonanceAudioReverbProbe.NativeFieldInfoPtr_proxyRoomRightWall = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResonanceAudioReverbProbe>.NativeClassPtr, "proxyRoomRightWall");
			ResonanceAudioReverbProbe.NativeFieldInfoPtr_proxyRoomFloor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResonanceAudioReverbProbe>.NativeClassPtr, "proxyRoomFloor");
			ResonanceAudioReverbProbe.NativeFieldInfoPtr_proxyRoomCeiling = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResonanceAudioReverbProbe>.NativeClassPtr, "proxyRoomCeiling");
			ResonanceAudioReverbProbe.NativeFieldInfoPtr_proxyRoomBackWall = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResonanceAudioReverbProbe>.NativeClassPtr, "proxyRoomBackWall");
			ResonanceAudioReverbProbe.NativeFieldInfoPtr_proxyRoomFrontWall = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResonanceAudioReverbProbe>.NativeClassPtr, "proxyRoomFrontWall");
			ResonanceAudioReverbProbe.NativeMethodInfoPtr_OnEnable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResonanceAudioReverbProbe>.NativeClassPtr, 100663523);
			ResonanceAudioReverbProbe.NativeMethodInfoPtr_OnDisable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResonanceAudioReverbProbe>.NativeClassPtr, 100663524);
			ResonanceAudioReverbProbe.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResonanceAudioReverbProbe>.NativeClassPtr, 100663525);
			ResonanceAudioReverbProbe.NativeMethodInfoPtr_GetScaledSphericalRegionRadius_Public_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResonanceAudioReverbProbe>.NativeClassPtr, 100663526);
			ResonanceAudioReverbProbe.NativeMethodInfoPtr_GetScaledBoxRegionSize_Public_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResonanceAudioReverbProbe>.NativeClassPtr, 100663527);
			ResonanceAudioReverbProbe.NativeMethodInfoPtr_OnDrawGizmosSelected_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResonanceAudioReverbProbe>.NativeClassPtr, 100663528);
			ResonanceAudioReverbProbe.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResonanceAudioReverbProbe>.NativeClassPtr, 100663529);
		}

		// Token: 0x06000378 RID: 888 RVA: 0x0003DCF0 File Offset: 0x0003BEF0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 33864, XrefRangeEnd = 33868, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnEnable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResonanceAudioReverbProbe.NativeMethodInfoPtr_OnEnable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000379 RID: 889 RVA: 0x0003DD24 File Offset: 0x0003BF24
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 33868, XrefRangeEnd = 33877, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnDisable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResonanceAudioReverbProbe.NativeMethodInfoPtr_OnDisable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600037A RID: 890 RVA: 0x0003DD58 File Offset: 0x0003BF58
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 33877, XrefRangeEnd = 33881, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResonanceAudioReverbProbe.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600037B RID: 891 RVA: 0x0003DD8C File Offset: 0x0003BF8C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 33885, RefRangeEnd = 33887, XrefRangeStart = 33881, XrefRangeEnd = 33885, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe float GetScaledSphericalRegionRadius()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResonanceAudioReverbProbe.NativeMethodInfoPtr_GetScaledSphericalRegionRadius_Public_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600037C RID: 892 RVA: 0x0003DDC8 File Offset: 0x0003BFC8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 33891, RefRangeEnd = 33893, XrefRangeStart = 33887, XrefRangeEnd = 33891, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Vector3 GetScaledBoxRegionSize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResonanceAudioReverbProbe.NativeMethodInfoPtr_GetScaledBoxRegionSize_Public_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600037D RID: 893 RVA: 0x0003DE04 File Offset: 0x0003C004
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 33893, XrefRangeEnd = 33902, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnDrawGizmosSelected()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResonanceAudioReverbProbe.NativeMethodInfoPtr_OnDrawGizmosSelected_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600037E RID: 894 RVA: 0x0003DE38 File Offset: 0x0003C038
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 33902, XrefRangeEnd = 33916, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ResonanceAudioReverbProbe()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ResonanceAudioReverbProbe>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResonanceAudioReverbProbe.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600037F RID: 895 RVA: 0x00004573 File Offset: 0x00002773
		public ResonanceAudioReverbProbe(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000154 RID: 340
		// (get) Token: 0x06000380 RID: 896 RVA: 0x0003DE74 File Offset: 0x0003C074
		// (set) Token: 0x06000381 RID: 897 RVA: 0x0000457C File Offset: 0x0000277C
		public unsafe Il2CppStructArray<float> rt60s
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResonanceAudioReverbProbe.NativeFieldInfoPtr_rt60s);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<float>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResonanceAudioReverbProbe.NativeFieldInfoPtr_rt60s), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000155 RID: 341
		// (get) Token: 0x06000382 RID: 898 RVA: 0x0003DEA4 File Offset: 0x0003C0A4
		// (set) Token: 0x06000383 RID: 899 RVA: 0x0000459B File Offset: 0x0000279B
		public unsafe float reverbGainDb
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResonanceAudioReverbProbe.NativeFieldInfoPtr_reverbGainDb);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResonanceAudioReverbProbe.NativeFieldInfoPtr_reverbGainDb)) = value;
			}
		}

		// Token: 0x17000156 RID: 342
		// (get) Token: 0x06000384 RID: 900 RVA: 0x0003DECC File Offset: 0x0003C0CC
		// (set) Token: 0x06000385 RID: 901 RVA: 0x000045B6 File Offset: 0x000027B6
		public unsafe float reverbBrightness
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResonanceAudioReverbProbe.NativeFieldInfoPtr_reverbBrightness);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResonanceAudioReverbProbe.NativeFieldInfoPtr_reverbBrightness)) = value;
			}
		}

		// Token: 0x17000157 RID: 343
		// (get) Token: 0x06000386 RID: 902 RVA: 0x0003DEF4 File Offset: 0x0003C0F4
		// (set) Token: 0x06000387 RID: 903 RVA: 0x000045D1 File Offset: 0x000027D1
		public unsafe float reverbTime
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResonanceAudioReverbProbe.NativeFieldInfoPtr_reverbTime);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResonanceAudioReverbProbe.NativeFieldInfoPtr_reverbTime)) = value;
			}
		}

		// Token: 0x17000158 RID: 344
		// (get) Token: 0x06000388 RID: 904 RVA: 0x0003DF1C File Offset: 0x0003C11C
		// (set) Token: 0x06000389 RID: 905 RVA: 0x000045EC File Offset: 0x000027EC
		public unsafe ResonanceAudioReverbProbe.RegionShape regionShape
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResonanceAudioReverbProbe.NativeFieldInfoPtr_regionShape);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResonanceAudioReverbProbe.NativeFieldInfoPtr_regionShape)) = value;
			}
		}

		// Token: 0x17000159 RID: 345
		// (get) Token: 0x0600038A RID: 906 RVA: 0x0003DF44 File Offset: 0x0003C144
		// (set) Token: 0x0600038B RID: 907 RVA: 0x00004607 File Offset: 0x00002807
		public unsafe Vector3 boxRegionSize
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResonanceAudioReverbProbe.NativeFieldInfoPtr_boxRegionSize);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResonanceAudioReverbProbe.NativeFieldInfoPtr_boxRegionSize)) = value;
			}
		}

		// Token: 0x1700015A RID: 346
		// (get) Token: 0x0600038C RID: 908 RVA: 0x0003DF6C File Offset: 0x0003C16C
		// (set) Token: 0x0600038D RID: 909 RVA: 0x00004622 File Offset: 0x00002822
		public unsafe float sphereRegionRadius
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResonanceAudioReverbProbe.NativeFieldInfoPtr_sphereRegionRadius);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResonanceAudioReverbProbe.NativeFieldInfoPtr_sphereRegionRadius)) = value;
			}
		}

		// Token: 0x1700015B RID: 347
		// (get) Token: 0x0600038E RID: 910 RVA: 0x0003DF94 File Offset: 0x0003C194
		// (set) Token: 0x0600038F RID: 911 RVA: 0x0000463D File Offset: 0x0000283D
		public unsafe bool onlyApplyWhenVisible
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResonanceAudioReverbProbe.NativeFieldInfoPtr_onlyApplyWhenVisible);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResonanceAudioReverbProbe.NativeFieldInfoPtr_onlyApplyWhenVisible)) = value;
			}
		}

		// Token: 0x1700015C RID: 348
		// (get) Token: 0x06000390 RID: 912 RVA: 0x0003DFBC File Offset: 0x0003C1BC
		// (set) Token: 0x06000391 RID: 913 RVA: 0x00004658 File Offset: 0x00002858
		public unsafe Vector3 proxyRoomPosition
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResonanceAudioReverbProbe.NativeFieldInfoPtr_proxyRoomPosition);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResonanceAudioReverbProbe.NativeFieldInfoPtr_proxyRoomPosition)) = value;
			}
		}

		// Token: 0x1700015D RID: 349
		// (get) Token: 0x06000392 RID: 914 RVA: 0x0003DFE4 File Offset: 0x0003C1E4
		// (set) Token: 0x06000393 RID: 915 RVA: 0x00004673 File Offset: 0x00002873
		public unsafe Quaternion proxyRoomRotation
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResonanceAudioReverbProbe.NativeFieldInfoPtr_proxyRoomRotation);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResonanceAudioReverbProbe.NativeFieldInfoPtr_proxyRoomRotation)) = value;
			}
		}

		// Token: 0x1700015E RID: 350
		// (get) Token: 0x06000394 RID: 916 RVA: 0x0003E00C File Offset: 0x0003C20C
		// (set) Token: 0x06000395 RID: 917 RVA: 0x0000468E File Offset: 0x0000288E
		public unsafe Vector3 proxyRoomSize
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResonanceAudioReverbProbe.NativeFieldInfoPtr_proxyRoomSize);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResonanceAudioReverbProbe.NativeFieldInfoPtr_proxyRoomSize)) = value;
			}
		}

		// Token: 0x1700015F RID: 351
		// (get) Token: 0x06000396 RID: 918 RVA: 0x0003E034 File Offset: 0x0003C234
		// (set) Token: 0x06000397 RID: 919 RVA: 0x000046A9 File Offset: 0x000028A9
		public unsafe ResonanceAudioRoomManager.SurfaceMaterial proxyRoomLeftWall
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResonanceAudioReverbProbe.NativeFieldInfoPtr_proxyRoomLeftWall);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResonanceAudioReverbProbe.NativeFieldInfoPtr_proxyRoomLeftWall)) = value;
			}
		}

		// Token: 0x17000160 RID: 352
		// (get) Token: 0x06000398 RID: 920 RVA: 0x0003E05C File Offset: 0x0003C25C
		// (set) Token: 0x06000399 RID: 921 RVA: 0x000046C4 File Offset: 0x000028C4
		public unsafe ResonanceAudioRoomManager.SurfaceMaterial proxyRoomRightWall
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResonanceAudioReverbProbe.NativeFieldInfoPtr_proxyRoomRightWall);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResonanceAudioReverbProbe.NativeFieldInfoPtr_proxyRoomRightWall)) = value;
			}
		}

		// Token: 0x17000161 RID: 353
		// (get) Token: 0x0600039A RID: 922 RVA: 0x0003E084 File Offset: 0x0003C284
		// (set) Token: 0x0600039B RID: 923 RVA: 0x000046DF File Offset: 0x000028DF
		public unsafe ResonanceAudioRoomManager.SurfaceMaterial proxyRoomFloor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResonanceAudioReverbProbe.NativeFieldInfoPtr_proxyRoomFloor);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResonanceAudioReverbProbe.NativeFieldInfoPtr_proxyRoomFloor)) = value;
			}
		}

		// Token: 0x17000162 RID: 354
		// (get) Token: 0x0600039C RID: 924 RVA: 0x0003E0AC File Offset: 0x0003C2AC
		// (set) Token: 0x0600039D RID: 925 RVA: 0x000046FA File Offset: 0x000028FA
		public unsafe ResonanceAudioRoomManager.SurfaceMaterial proxyRoomCeiling
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResonanceAudioReverbProbe.NativeFieldInfoPtr_proxyRoomCeiling);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResonanceAudioReverbProbe.NativeFieldInfoPtr_proxyRoomCeiling)) = value;
			}
		}

		// Token: 0x17000163 RID: 355
		// (get) Token: 0x0600039E RID: 926 RVA: 0x0003E0D4 File Offset: 0x0003C2D4
		// (set) Token: 0x0600039F RID: 927 RVA: 0x00004715 File Offset: 0x00002915
		public unsafe ResonanceAudioRoomManager.SurfaceMaterial proxyRoomBackWall
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResonanceAudioReverbProbe.NativeFieldInfoPtr_proxyRoomBackWall);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResonanceAudioReverbProbe.NativeFieldInfoPtr_proxyRoomBackWall)) = value;
			}
		}

		// Token: 0x17000164 RID: 356
		// (get) Token: 0x060003A0 RID: 928 RVA: 0x0003E0FC File Offset: 0x0003C2FC
		// (set) Token: 0x060003A1 RID: 929 RVA: 0x00004730 File Offset: 0x00002930
		public unsafe ResonanceAudioRoomManager.SurfaceMaterial proxyRoomFrontWall
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResonanceAudioReverbProbe.NativeFieldInfoPtr_proxyRoomFrontWall);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResonanceAudioReverbProbe.NativeFieldInfoPtr_proxyRoomFrontWall)) = value;
			}
		}

		// Token: 0x040001FD RID: 509
		private static readonly IntPtr NativeFieldInfoPtr_rt60s;

		// Token: 0x040001FE RID: 510
		private static readonly IntPtr NativeFieldInfoPtr_reverbGainDb;

		// Token: 0x040001FF RID: 511
		private static readonly IntPtr NativeFieldInfoPtr_reverbBrightness;

		// Token: 0x04000200 RID: 512
		private static readonly IntPtr NativeFieldInfoPtr_reverbTime;

		// Token: 0x04000201 RID: 513
		private static readonly IntPtr NativeFieldInfoPtr_regionShape;

		// Token: 0x04000202 RID: 514
		private static readonly IntPtr NativeFieldInfoPtr_boxRegionSize;

		// Token: 0x04000203 RID: 515
		private static readonly IntPtr NativeFieldInfoPtr_sphereRegionRadius;

		// Token: 0x04000204 RID: 516
		private static readonly IntPtr NativeFieldInfoPtr_onlyApplyWhenVisible;

		// Token: 0x04000205 RID: 517
		private static readonly IntPtr NativeFieldInfoPtr_proxyRoomPosition;

		// Token: 0x04000206 RID: 518
		private static readonly IntPtr NativeFieldInfoPtr_proxyRoomRotation;

		// Token: 0x04000207 RID: 519
		private static readonly IntPtr NativeFieldInfoPtr_proxyRoomSize;

		// Token: 0x04000208 RID: 520
		private static readonly IntPtr NativeFieldInfoPtr_proxyRoomLeftWall;

		// Token: 0x04000209 RID: 521
		private static readonly IntPtr NativeFieldInfoPtr_proxyRoomRightWall;

		// Token: 0x0400020A RID: 522
		private static readonly IntPtr NativeFieldInfoPtr_proxyRoomFloor;

		// Token: 0x0400020B RID: 523
		private static readonly IntPtr NativeFieldInfoPtr_proxyRoomCeiling;

		// Token: 0x0400020C RID: 524
		private static readonly IntPtr NativeFieldInfoPtr_proxyRoomBackWall;

		// Token: 0x0400020D RID: 525
		private static readonly IntPtr NativeFieldInfoPtr_proxyRoomFrontWall;

		// Token: 0x0400020E RID: 526
		private static readonly IntPtr NativeMethodInfoPtr_OnEnable_Private_Void_0;

		// Token: 0x0400020F RID: 527
		private static readonly IntPtr NativeMethodInfoPtr_OnDisable_Private_Void_0;

		// Token: 0x04000210 RID: 528
		private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

		// Token: 0x04000211 RID: 529
		private static readonly IntPtr NativeMethodInfoPtr_GetScaledSphericalRegionRadius_Public_Single_0;

		// Token: 0x04000212 RID: 530
		private static readonly IntPtr NativeMethodInfoPtr_GetScaledBoxRegionSize_Public_Vector3_0;

		// Token: 0x04000213 RID: 531
		private static readonly IntPtr NativeMethodInfoPtr_OnDrawGizmosSelected_Private_Void_0;

		// Token: 0x04000214 RID: 532
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x020002A0 RID: 672
		[OriginalName("Assembly-CSharp.dll", "", "RegionShape")]
		public enum RegionShape
		{
			// Token: 0x04003072 RID: 12402
			Sphere,
			// Token: 0x04003073 RID: 12403
			Box
		}
	}
}
