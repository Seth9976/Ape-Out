using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using UnityEngine;

namespace Il2Cpp
{
	// Token: 0x020000CE RID: 206
	public class FarOffSniper : GuardGun
	{
		// Token: 0x0600187A RID: 6266 RVA: 0x00079154 File Offset: 0x00077354
		// Note: this type is marked as 'beforefieldinit'.
		static FarOffSniper()
		{
			Il2CppClassPointerStore<FarOffSniper>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "FarOffSniper");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FarOffSniper>.NativeClassPtr);
			FarOffSniper.NativeFieldInfoPtr_spd = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FarOffSniper>.NativeClassPtr, "spd");
			FarOffSniper.NativeFieldInfoPtr_pos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FarOffSniper>.NativeClassPtr, "pos");
			FarOffSniper.NativeFieldInfoPtr_desAng = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FarOffSniper>.NativeClassPtr, "desAng");
			FarOffSniper.NativeFieldInfoPtr_curAng = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FarOffSniper>.NativeClassPtr, "curAng");
			FarOffSniper.NativeFieldInfoPtr_line = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FarOffSniper>.NativeClassPtr, "line");
			FarOffSniper.NativeFieldInfoPtr_mask = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FarOffSniper>.NativeClassPtr, "mask");
			FarOffSniper.NativeFieldInfoPtr_ray = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FarOffSniper>.NativeClassPtr, "ray");
			FarOffSniper.NativeFieldInfoPtr_shotReady = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FarOffSniper>.NativeClassPtr, "shotReady");
			FarOffSniper.NativeFieldInfoPtr_shotTimer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FarOffSniper>.NativeClassPtr, "shotTimer");
			FarOffSniper.NativeFieldInfoPtr_hasTarget = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FarOffSniper>.NativeClassPtr, "hasTarget");
			FarOffSniper.NativeFieldInfoPtr_turnOffHalfwayDown = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FarOffSniper>.NativeClassPtr, "turnOffHalfwayDown");
			FarOffSniper.NativeFieldInfoPtr_defAng = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FarOffSniper>.NativeClassPtr, "defAng");
			FarOffSniper.NativeFieldInfoPtr_TargetedAudioSource = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FarOffSniper>.NativeClassPtr, "TargetedAudioSource");
			FarOffSniper.NativeFieldInfoPtr_targetedIsPlaying = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FarOffSniper>.NativeClassPtr, "targetedIsPlaying");
			FarOffSniper.NativeFieldInfoPtr_CockSoundPos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FarOffSniper>.NativeClassPtr, "CockSoundPos");
			FarOffSniper.NativeFieldInfoPtr_audioSourceMovmentSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FarOffSniper>.NativeClassPtr, "audioSourceMovmentSpeed");
			FarOffSniper.NativeFieldInfoPtr_delaypt09 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FarOffSniper>.NativeClassPtr, "delaypt09");
			FarOffSniper.NativeFieldInfoPtr_delaypt1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FarOffSniper>.NativeClassPtr, "delaypt1");
			FarOffSniper.NativeMethodInfoPtr_Start_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FarOffSniper>.NativeClassPtr, 100665303);
			FarOffSniper.NativeMethodInfoPtr_Update_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FarOffSniper>.NativeClassPtr, 100665304);
			FarOffSniper.NativeMethodInfoPtr_MyFixedUpdate_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FarOffSniper>.NativeClassPtr, 100665305);
			FarOffSniper.NativeMethodInfoPtr_MakeBulletGo_Public_Virtual_Void_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FarOffSniper>.NativeClassPtr, 100665306);
			FarOffSniper.NativeMethodInfoPtr_InputLag_Private_IEnumerator_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FarOffSniper>.NativeClassPtr, 100665307);
			FarOffSniper.NativeMethodInfoPtr_ShootDelayed_Private_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FarOffSniper>.NativeClassPtr, 100665308);
			FarOffSniper.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FarOffSniper>.NativeClassPtr, 100665309);
		}

		// Token: 0x0600187B RID: 6267 RVA: 0x00079378 File Offset: 0x00077578
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 57740, XrefRangeEnd = 57790, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FarOffSniper.NativeMethodInfoPtr_Start_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600187C RID: 6268 RVA: 0x000793B4 File Offset: 0x000775B4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 57790, XrefRangeEnd = 57890, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FarOffSniper.NativeMethodInfoPtr_Update_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600187D RID: 6269 RVA: 0x000793F0 File Offset: 0x000775F0
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void MyFixedUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FarOffSniper.NativeMethodInfoPtr_MyFixedUpdate_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600187E RID: 6270 RVA: 0x0007942C File Offset: 0x0007762C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 57890, XrefRangeEnd = 58047, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void MakeBulletGo(Vector2 shotVect)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref shotVect;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FarOffSniper.NativeMethodInfoPtr_MakeBulletGo_Public_Virtual_Void_Vector2_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600187F RID: 6271 RVA: 0x00079478 File Offset: 0x00077678
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 58047, XrefRangeEnd = 58050, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator InputLag(float a)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref a;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FarOffSniper.NativeMethodInfoPtr_InputLag_Private_IEnumerator_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}
		}

		// Token: 0x06001880 RID: 6272 RVA: 0x000794C4 File Offset: 0x000776C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 58050, XrefRangeEnd = 58053, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator ShootDelayed()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FarOffSniper.NativeMethodInfoPtr_ShootDelayed_Private_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06001881 RID: 6273 RVA: 0x00079504 File Offset: 0x00077704
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 58053, XrefRangeEnd = 58059, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe FarOffSniper()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FarOffSniper>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FarOffSniper.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001882 RID: 6274 RVA: 0x00011923 File Offset: 0x0000FB23
		public FarOffSniper(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170008D4 RID: 2260
		// (get) Token: 0x06001883 RID: 6275 RVA: 0x00079540 File Offset: 0x00077740
		// (set) Token: 0x06001884 RID: 6276 RVA: 0x0001192C File Offset: 0x0000FB2C
		public unsafe float spd
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FarOffSniper.NativeFieldInfoPtr_spd);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FarOffSniper.NativeFieldInfoPtr_spd)) = value;
			}
		}

		// Token: 0x170008D5 RID: 2261
		// (get) Token: 0x06001885 RID: 6277 RVA: 0x00079568 File Offset: 0x00077768
		// (set) Token: 0x06001886 RID: 6278 RVA: 0x00011947 File Offset: 0x0000FB47
		public unsafe Vector2 pos
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FarOffSniper.NativeFieldInfoPtr_pos);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FarOffSniper.NativeFieldInfoPtr_pos)) = value;
			}
		}

		// Token: 0x170008D6 RID: 2262
		// (get) Token: 0x06001887 RID: 6279 RVA: 0x00079590 File Offset: 0x00077790
		// (set) Token: 0x06001888 RID: 6280 RVA: 0x00011962 File Offset: 0x0000FB62
		public unsafe float desAng
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FarOffSniper.NativeFieldInfoPtr_desAng);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FarOffSniper.NativeFieldInfoPtr_desAng)) = value;
			}
		}

		// Token: 0x170008D7 RID: 2263
		// (get) Token: 0x06001889 RID: 6281 RVA: 0x000795B8 File Offset: 0x000777B8
		// (set) Token: 0x0600188A RID: 6282 RVA: 0x0001197D File Offset: 0x0000FB7D
		public unsafe float curAng
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FarOffSniper.NativeFieldInfoPtr_curAng);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FarOffSniper.NativeFieldInfoPtr_curAng)) = value;
			}
		}

		// Token: 0x170008D8 RID: 2264
		// (get) Token: 0x0600188B RID: 6283 RVA: 0x000795E0 File Offset: 0x000777E0
		// (set) Token: 0x0600188C RID: 6284 RVA: 0x00011998 File Offset: 0x0000FB98
		public unsafe LineRenderer line
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FarOffSniper.NativeFieldInfoPtr_line);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<LineRenderer>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FarOffSniper.NativeFieldInfoPtr_line), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170008D9 RID: 2265
		// (get) Token: 0x0600188D RID: 6285 RVA: 0x00079610 File Offset: 0x00077810
		// (set) Token: 0x0600188E RID: 6286 RVA: 0x000119B7 File Offset: 0x0000FBB7
		public unsafe int mask
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FarOffSniper.NativeFieldInfoPtr_mask);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FarOffSniper.NativeFieldInfoPtr_mask)) = value;
			}
		}

		// Token: 0x170008DA RID: 2266
		// (get) Token: 0x0600188F RID: 6287 RVA: 0x00079638 File Offset: 0x00077838
		// (set) Token: 0x06001890 RID: 6288 RVA: 0x000119D2 File Offset: 0x0000FBD2
		public unsafe RaycastHit2D ray
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FarOffSniper.NativeFieldInfoPtr_ray);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FarOffSniper.NativeFieldInfoPtr_ray)) = value;
			}
		}

		// Token: 0x170008DB RID: 2267
		// (get) Token: 0x06001891 RID: 6289 RVA: 0x00079660 File Offset: 0x00077860
		// (set) Token: 0x06001892 RID: 6290 RVA: 0x000119ED File Offset: 0x0000FBED
		public unsafe bool shotReady
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FarOffSniper.NativeFieldInfoPtr_shotReady);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FarOffSniper.NativeFieldInfoPtr_shotReady)) = value;
			}
		}

		// Token: 0x170008DC RID: 2268
		// (get) Token: 0x06001893 RID: 6291 RVA: 0x00079688 File Offset: 0x00077888
		// (set) Token: 0x06001894 RID: 6292 RVA: 0x00011A08 File Offset: 0x0000FC08
		public unsafe float shotTimer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FarOffSniper.NativeFieldInfoPtr_shotTimer);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FarOffSniper.NativeFieldInfoPtr_shotTimer)) = value;
			}
		}

		// Token: 0x170008DD RID: 2269
		// (get) Token: 0x06001895 RID: 6293 RVA: 0x000796B0 File Offset: 0x000778B0
		// (set) Token: 0x06001896 RID: 6294 RVA: 0x00011A23 File Offset: 0x0000FC23
		public unsafe bool hasTarget
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FarOffSniper.NativeFieldInfoPtr_hasTarget);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FarOffSniper.NativeFieldInfoPtr_hasTarget)) = value;
			}
		}

		// Token: 0x170008DE RID: 2270
		// (get) Token: 0x06001897 RID: 6295 RVA: 0x000796D8 File Offset: 0x000778D8
		// (set) Token: 0x06001898 RID: 6296 RVA: 0x00011A3E File Offset: 0x0000FC3E
		public unsafe bool turnOffHalfwayDown
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FarOffSniper.NativeFieldInfoPtr_turnOffHalfwayDown);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FarOffSniper.NativeFieldInfoPtr_turnOffHalfwayDown)) = value;
			}
		}

		// Token: 0x170008DF RID: 2271
		// (get) Token: 0x06001899 RID: 6297 RVA: 0x00079700 File Offset: 0x00077900
		// (set) Token: 0x0600189A RID: 6298 RVA: 0x00011A59 File Offset: 0x0000FC59
		public unsafe float defAng
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FarOffSniper.NativeFieldInfoPtr_defAng);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FarOffSniper.NativeFieldInfoPtr_defAng)) = value;
			}
		}

		// Token: 0x170008E0 RID: 2272
		// (get) Token: 0x0600189B RID: 6299 RVA: 0x00079728 File Offset: 0x00077928
		// (set) Token: 0x0600189C RID: 6300 RVA: 0x00011A74 File Offset: 0x0000FC74
		public unsafe SECTR_PointSource TargetedAudioSource
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FarOffSniper.NativeFieldInfoPtr_TargetedAudioSource);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SECTR_PointSource>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FarOffSniper.NativeFieldInfoPtr_TargetedAudioSource), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170008E1 RID: 2273
		// (get) Token: 0x0600189D RID: 6301 RVA: 0x00079758 File Offset: 0x00077958
		// (set) Token: 0x0600189E RID: 6302 RVA: 0x00011A93 File Offset: 0x0000FC93
		public unsafe bool targetedIsPlaying
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FarOffSniper.NativeFieldInfoPtr_targetedIsPlaying);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FarOffSniper.NativeFieldInfoPtr_targetedIsPlaying)) = value;
			}
		}

		// Token: 0x170008E2 RID: 2274
		// (get) Token: 0x0600189F RID: 6303 RVA: 0x00079780 File Offset: 0x00077980
		// (set) Token: 0x060018A0 RID: 6304 RVA: 0x00011AAE File Offset: 0x0000FCAE
		public unsafe Transform CockSoundPos
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FarOffSniper.NativeFieldInfoPtr_CockSoundPos);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FarOffSniper.NativeFieldInfoPtr_CockSoundPos), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170008E3 RID: 2275
		// (get) Token: 0x060018A1 RID: 6305 RVA: 0x000797B0 File Offset: 0x000779B0
		// (set) Token: 0x060018A2 RID: 6306 RVA: 0x00011ACD File Offset: 0x0000FCCD
		public unsafe float audioSourceMovmentSpeed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FarOffSniper.NativeFieldInfoPtr_audioSourceMovmentSpeed);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FarOffSniper.NativeFieldInfoPtr_audioSourceMovmentSpeed)) = value;
			}
		}

		// Token: 0x170008E4 RID: 2276
		// (get) Token: 0x060018A3 RID: 6307 RVA: 0x000797D8 File Offset: 0x000779D8
		// (set) Token: 0x060018A4 RID: 6308 RVA: 0x00011AE8 File Offset: 0x0000FCE8
		public unsafe WaitForSeconds delaypt09
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FarOffSniper.NativeFieldInfoPtr_delaypt09);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<WaitForSeconds>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FarOffSniper.NativeFieldInfoPtr_delaypt09), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170008E5 RID: 2277
		// (get) Token: 0x060018A5 RID: 6309 RVA: 0x00079808 File Offset: 0x00077A08
		// (set) Token: 0x060018A6 RID: 6310 RVA: 0x00011B07 File Offset: 0x0000FD07
		public unsafe WaitForSeconds delaypt1
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FarOffSniper.NativeFieldInfoPtr_delaypt1);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<WaitForSeconds>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FarOffSniper.NativeFieldInfoPtr_delaypt1), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000E95 RID: 3733
		private static readonly IntPtr NativeFieldInfoPtr_spd;

		// Token: 0x04000E96 RID: 3734
		private static readonly IntPtr NativeFieldInfoPtr_pos;

		// Token: 0x04000E97 RID: 3735
		private static readonly IntPtr NativeFieldInfoPtr_desAng;

		// Token: 0x04000E98 RID: 3736
		private static readonly IntPtr NativeFieldInfoPtr_curAng;

		// Token: 0x04000E99 RID: 3737
		private static readonly IntPtr NativeFieldInfoPtr_line;

		// Token: 0x04000E9A RID: 3738
		private static readonly IntPtr NativeFieldInfoPtr_mask;

		// Token: 0x04000E9B RID: 3739
		private static readonly IntPtr NativeFieldInfoPtr_ray;

		// Token: 0x04000E9C RID: 3740
		private static readonly IntPtr NativeFieldInfoPtr_shotReady;

		// Token: 0x04000E9D RID: 3741
		private static readonly IntPtr NativeFieldInfoPtr_shotTimer;

		// Token: 0x04000E9E RID: 3742
		private static readonly IntPtr NativeFieldInfoPtr_hasTarget;

		// Token: 0x04000E9F RID: 3743
		private static readonly IntPtr NativeFieldInfoPtr_turnOffHalfwayDown;

		// Token: 0x04000EA0 RID: 3744
		private static readonly IntPtr NativeFieldInfoPtr_defAng;

		// Token: 0x04000EA1 RID: 3745
		private static readonly IntPtr NativeFieldInfoPtr_TargetedAudioSource;

		// Token: 0x04000EA2 RID: 3746
		private static readonly IntPtr NativeFieldInfoPtr_targetedIsPlaying;

		// Token: 0x04000EA3 RID: 3747
		private static readonly IntPtr NativeFieldInfoPtr_CockSoundPos;

		// Token: 0x04000EA4 RID: 3748
		private static readonly IntPtr NativeFieldInfoPtr_audioSourceMovmentSpeed;

		// Token: 0x04000EA5 RID: 3749
		private static readonly IntPtr NativeFieldInfoPtr_delaypt09;

		// Token: 0x04000EA6 RID: 3750
		private static readonly IntPtr NativeFieldInfoPtr_delaypt1;

		// Token: 0x04000EA7 RID: 3751
		private static readonly IntPtr NativeMethodInfoPtr_Start_Public_Virtual_Void_0;

		// Token: 0x04000EA8 RID: 3752
		private static readonly IntPtr NativeMethodInfoPtr_Update_Public_Virtual_Void_0;

		// Token: 0x04000EA9 RID: 3753
		private static readonly IntPtr NativeMethodInfoPtr_MyFixedUpdate_Public_Virtual_Void_0;

		// Token: 0x04000EAA RID: 3754
		private static readonly IntPtr NativeMethodInfoPtr_MakeBulletGo_Public_Virtual_Void_Vector2_0;

		// Token: 0x04000EAB RID: 3755
		private static readonly IntPtr NativeMethodInfoPtr_InputLag_Private_IEnumerator_Single_0;

		// Token: 0x04000EAC RID: 3756
		private static readonly IntPtr NativeMethodInfoPtr_ShootDelayed_Private_IEnumerator_0;

		// Token: 0x04000EAD RID: 3757
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x020002FA RID: 762
		[ObfuscatedName("FarOffSniper+<InputLag>d__22")]
		public sealed class _InputLag_d__22 : global::Il2CppSystem.Object
		{
			// Token: 0x06004F00 RID: 20224 RVA: 0x00121428 File Offset: 0x0011F628
			// Note: this type is marked as 'beforefieldinit'.
			static _InputLag_d__22()
			{
				Il2CppClassPointerStore<FarOffSniper._InputLag_d__22>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<FarOffSniper>.NativeClassPtr, "<InputLag>d__22");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FarOffSniper._InputLag_d__22>.NativeClassPtr);
				FarOffSniper._InputLag_d__22.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FarOffSniper._InputLag_d__22>.NativeClassPtr, "<>1__state");
				FarOffSniper._InputLag_d__22.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FarOffSniper._InputLag_d__22>.NativeClassPtr, "<>2__current");
				FarOffSniper._InputLag_d__22.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FarOffSniper._InputLag_d__22>.NativeClassPtr, "<>4__this");
				FarOffSniper._InputLag_d__22.NativeFieldInfoPtr_a = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FarOffSniper._InputLag_d__22>.NativeClassPtr, "a");
				FarOffSniper._InputLag_d__22.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FarOffSniper._InputLag_d__22>.NativeClassPtr, 100665310);
				FarOffSniper._InputLag_d__22.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FarOffSniper._InputLag_d__22>.NativeClassPtr, 100665311);
				FarOffSniper._InputLag_d__22.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FarOffSniper._InputLag_d__22>.NativeClassPtr, 100665312);
				FarOffSniper._InputLag_d__22.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FarOffSniper._InputLag_d__22>.NativeClassPtr, 100665313);
				FarOffSniper._InputLag_d__22.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FarOffSniper._InputLag_d__22>.NativeClassPtr, 100665314);
				FarOffSniper._InputLag_d__22.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FarOffSniper._InputLag_d__22>.NativeClassPtr, 100665315);
			}

			// Token: 0x06004F01 RID: 20225 RVA: 0x0012151C File Offset: 0x0011F71C
			[CallerCount(0)]
			public unsafe _InputLag_d__22(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FarOffSniper._InputLag_d__22>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FarOffSniper._InputLag_d__22.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06004F02 RID: 20226 RVA: 0x00121564 File Offset: 0x0011F764
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FarOffSniper._InputLag_d__22.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06004F03 RID: 20227 RVA: 0x00121598 File Offset: 0x0011F798
			[CallerCount(0)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FarOffSniper._InputLag_d__22.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17001CCE RID: 7374
			// (get) Token: 0x06004F04 RID: 20228 RVA: 0x001215D4 File Offset: 0x0011F7D4
			public unsafe global::Il2CppSystem.Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FarOffSniper._InputLag_d__22.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x06004F05 RID: 20229 RVA: 0x00121614 File Offset: 0x0011F814
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 57699, XrefRangeEnd = 57704, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FarOffSniper._InputLag_d__22.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17001CCF RID: 7375
			// (get) Token: 0x06004F06 RID: 20230 RVA: 0x00121648 File Offset: 0x0011F848
			public unsafe global::Il2CppSystem.Object System.Collections.IEnumerator.Current
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FarOffSniper._InputLag_d__22.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x06004F07 RID: 20231 RVA: 0x0002E436 File Offset: 0x0002C636
			public _InputLag_d__22(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001CCA RID: 7370
			// (get) Token: 0x06004F08 RID: 20232 RVA: 0x00121688 File Offset: 0x0011F888
			// (set) Token: 0x06004F09 RID: 20233 RVA: 0x0002E43F File Offset: 0x0002C63F
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FarOffSniper._InputLag_d__22.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FarOffSniper._InputLag_d__22.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17001CCB RID: 7371
			// (get) Token: 0x06004F0A RID: 20234 RVA: 0x001216B0 File Offset: 0x0011F8B0
			// (set) Token: 0x06004F0B RID: 20235 RVA: 0x0002E45A File Offset: 0x0002C65A
			public unsafe global::Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FarOffSniper._InputLag_d__22.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FarOffSniper._InputLag_d__22.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001CCC RID: 7372
			// (get) Token: 0x06004F0C RID: 20236 RVA: 0x001216E0 File Offset: 0x0011F8E0
			// (set) Token: 0x06004F0D RID: 20237 RVA: 0x0002E479 File Offset: 0x0002C679
			public unsafe FarOffSniper __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FarOffSniper._InputLag_d__22.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<FarOffSniper>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FarOffSniper._InputLag_d__22.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001CCD RID: 7373
			// (get) Token: 0x06004F0E RID: 20238 RVA: 0x00121710 File Offset: 0x0011F910
			// (set) Token: 0x06004F0F RID: 20239 RVA: 0x0002E498 File Offset: 0x0002C698
			public unsafe float a
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FarOffSniper._InputLag_d__22.NativeFieldInfoPtr_a);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FarOffSniper._InputLag_d__22.NativeFieldInfoPtr_a)) = value;
				}
			}

			// Token: 0x040033C8 RID: 13256
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x040033C9 RID: 13257
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x040033CA RID: 13258
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x040033CB RID: 13259
			private static readonly IntPtr NativeFieldInfoPtr_a;

			// Token: 0x040033CC RID: 13260
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x040033CD RID: 13261
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x040033CE RID: 13262
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x040033CF RID: 13263
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x040033D0 RID: 13264
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x040033D1 RID: 13265
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}

		// Token: 0x020002FB RID: 763
		[ObfuscatedName("FarOffSniper+<ShootDelayed>d__23")]
		public sealed class _ShootDelayed_d__23 : global::Il2CppSystem.Object
		{
			// Token: 0x06004F10 RID: 20240 RVA: 0x00121738 File Offset: 0x0011F938
			// Note: this type is marked as 'beforefieldinit'.
			static _ShootDelayed_d__23()
			{
				Il2CppClassPointerStore<FarOffSniper._ShootDelayed_d__23>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<FarOffSniper>.NativeClassPtr, "<ShootDelayed>d__23");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FarOffSniper._ShootDelayed_d__23>.NativeClassPtr);
				FarOffSniper._ShootDelayed_d__23.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FarOffSniper._ShootDelayed_d__23>.NativeClassPtr, "<>1__state");
				FarOffSniper._ShootDelayed_d__23.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FarOffSniper._ShootDelayed_d__23>.NativeClassPtr, "<>2__current");
				FarOffSniper._ShootDelayed_d__23.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FarOffSniper._ShootDelayed_d__23>.NativeClassPtr, "<>4__this");
				FarOffSniper._ShootDelayed_d__23.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FarOffSniper._ShootDelayed_d__23>.NativeClassPtr, 100665316);
				FarOffSniper._ShootDelayed_d__23.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FarOffSniper._ShootDelayed_d__23>.NativeClassPtr, 100665317);
				FarOffSniper._ShootDelayed_d__23.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FarOffSniper._ShootDelayed_d__23>.NativeClassPtr, 100665318);
				FarOffSniper._ShootDelayed_d__23.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FarOffSniper._ShootDelayed_d__23>.NativeClassPtr, 100665319);
				FarOffSniper._ShootDelayed_d__23.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FarOffSniper._ShootDelayed_d__23>.NativeClassPtr, 100665320);
				FarOffSniper._ShootDelayed_d__23.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FarOffSniper._ShootDelayed_d__23>.NativeClassPtr, 100665321);
			}

			// Token: 0x06004F11 RID: 20241 RVA: 0x00121818 File Offset: 0x0011FA18
			[CallerCount(0)]
			public unsafe _ShootDelayed_d__23(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FarOffSniper._ShootDelayed_d__23>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FarOffSniper._ShootDelayed_d__23.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06004F12 RID: 20242 RVA: 0x00121860 File Offset: 0x0011FA60
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FarOffSniper._ShootDelayed_d__23.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06004F13 RID: 20243 RVA: 0x00121894 File Offset: 0x0011FA94
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 57704, XrefRangeEnd = 57735, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FarOffSniper._ShootDelayed_d__23.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17001CD3 RID: 7379
			// (get) Token: 0x06004F14 RID: 20244 RVA: 0x001218D0 File Offset: 0x0011FAD0
			public unsafe global::Il2CppSystem.Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FarOffSniper._ShootDelayed_d__23.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x06004F15 RID: 20245 RVA: 0x00121910 File Offset: 0x0011FB10
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 57735, XrefRangeEnd = 57740, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FarOffSniper._ShootDelayed_d__23.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17001CD4 RID: 7380
			// (get) Token: 0x06004F16 RID: 20246 RVA: 0x00121944 File Offset: 0x0011FB44
			public unsafe global::Il2CppSystem.Object System.Collections.IEnumerator.Current
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FarOffSniper._ShootDelayed_d__23.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x06004F17 RID: 20247 RVA: 0x0002E4B3 File Offset: 0x0002C6B3
			public _ShootDelayed_d__23(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001CD0 RID: 7376
			// (get) Token: 0x06004F18 RID: 20248 RVA: 0x00121984 File Offset: 0x0011FB84
			// (set) Token: 0x06004F19 RID: 20249 RVA: 0x0002E4BC File Offset: 0x0002C6BC
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FarOffSniper._ShootDelayed_d__23.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FarOffSniper._ShootDelayed_d__23.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17001CD1 RID: 7377
			// (get) Token: 0x06004F1A RID: 20250 RVA: 0x001219AC File Offset: 0x0011FBAC
			// (set) Token: 0x06004F1B RID: 20251 RVA: 0x0002E4D7 File Offset: 0x0002C6D7
			public unsafe global::Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FarOffSniper._ShootDelayed_d__23.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FarOffSniper._ShootDelayed_d__23.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001CD2 RID: 7378
			// (get) Token: 0x06004F1C RID: 20252 RVA: 0x001219DC File Offset: 0x0011FBDC
			// (set) Token: 0x06004F1D RID: 20253 RVA: 0x0002E4F6 File Offset: 0x0002C6F6
			public unsafe FarOffSniper __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FarOffSniper._ShootDelayed_d__23.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<FarOffSniper>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FarOffSniper._ShootDelayed_d__23.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040033D2 RID: 13266
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x040033D3 RID: 13267
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x040033D4 RID: 13268
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x040033D5 RID: 13269
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x040033D6 RID: 13270
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x040033D7 RID: 13271
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x040033D8 RID: 13272
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x040033D9 RID: 13273
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x040033DA RID: 13274
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
