using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using UnityEngine;

namespace Il2Cpp
{
	// Token: 0x02000140 RID: 320
	public class OfficeIntro : MonoBehaviour
	{
		// Token: 0x060026BC RID: 9916 RVA: 0x0009FEBC File Offset: 0x0009E0BC
		// Note: this type is marked as 'beforefieldinit'.
		static OfficeIntro()
		{
			Il2CppClassPointerStore<OfficeIntro>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "OfficeIntro");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<OfficeIntro>.NativeClassPtr);
			OfficeIntro.NativeFieldInfoPtr_me = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OfficeIntro>.NativeClassPtr, "me");
			OfficeIntro.NativeFieldInfoPtr_blackQuad = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OfficeIntro>.NativeClassPtr, "blackQuad");
			OfficeIntro.NativeFieldInfoPtr_anim = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OfficeIntro>.NativeClassPtr, "anim");
			OfficeIntro.NativeFieldInfoPtr_elevatorUp = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OfficeIntro>.NativeClassPtr, "elevatorUp");
			OfficeIntro.NativeFieldInfoPtr_elevatorDing = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OfficeIntro>.NativeClassPtr, "elevatorDing");
			OfficeIntro.NativeFieldInfoPtr_high = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OfficeIntro>.NativeClassPtr, "high");
			OfficeIntro.NativeFieldInfoPtr_rise = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OfficeIntro>.NativeClassPtr, "rise");
			OfficeIntro.NativeFieldInfoPtr_buildings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OfficeIntro>.NativeClassPtr, "buildings");
			OfficeIntro.NativeFieldInfoPtr_unWindowMat = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OfficeIntro>.NativeClassPtr, "unWindowMat");
			OfficeIntro.NativeFieldInfoPtr_brokeWindow = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OfficeIntro>.NativeClassPtr, "brokeWindow");
			OfficeIntro.NativeFieldInfoPtr_fallCurve = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OfficeIntro>.NativeClassPtr, "fallCurve");
			OfficeIntro.NativeFieldInfoPtr_startFlag = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OfficeIntro>.NativeClassPtr, "startFlag");
			OfficeIntro.NativeFieldInfoPtr_allTheStuff = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OfficeIntro>.NativeClassPtr, "allTheStuff");
			OfficeIntro.NativeFieldInfoPtr_brokenWindow = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OfficeIntro>.NativeClassPtr, "brokenWindow");
			OfficeIntro.NativeFieldInfoPtr_shadowCamfollower = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OfficeIntro>.NativeClassPtr, "shadowCamfollower");
			OfficeIntro.NativeFieldInfoPtr_oldSounds = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OfficeIntro>.NativeClassPtr, "oldSounds");
			OfficeIntro.NativeFieldInfoPtr_blackLeft = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OfficeIntro>.NativeClassPtr, "blackLeft");
			OfficeIntro.NativeFieldInfoPtr_blackRight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OfficeIntro>.NativeClassPtr, "blackRight");
			OfficeIntro.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OfficeIntro>.NativeClassPtr, 100666395);
			OfficeIntro.NativeMethodInfoPtr_OnDestroy_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OfficeIntro>.NativeClassPtr, 100666396);
			OfficeIntro.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OfficeIntro>.NativeClassPtr, 100666397);
			OfficeIntro.NativeMethodInfoPtr_IntroTeleported_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OfficeIntro>.NativeClassPtr, 100666398);
			OfficeIntro.NativeMethodInfoPtr_DoIt_Private_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OfficeIntro>.NativeClassPtr, 100666399);
			OfficeIntro.NativeMethodInfoPtr_ShitShit_Private_IEnumerator_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OfficeIntro>.NativeClassPtr, 100666400);
			OfficeIntro.NativeMethodInfoPtr_BreakWindow_Public_Void_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OfficeIntro>.NativeClassPtr, 100666401);
			OfficeIntro.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OfficeIntro>.NativeClassPtr, 100666402);
		}

		// Token: 0x060026BD RID: 9917 RVA: 0x000A00F4 File Offset: 0x0009E2F4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 75000, XrefRangeEnd = 75006, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OfficeIntro.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060026BE RID: 9918 RVA: 0x000A0128 File Offset: 0x0009E328
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 75006, XrefRangeEnd = 75024, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnDestroy()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OfficeIntro.NativeMethodInfoPtr_OnDestroy_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060026BF RID: 9919 RVA: 0x000A015C File Offset: 0x0009E35C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 75024, XrefRangeEnd = 75063, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OfficeIntro.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060026C0 RID: 9920 RVA: 0x000A0190 File Offset: 0x0009E390
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 75127, RefRangeEnd = 75128, XrefRangeStart = 75063, XrefRangeEnd = 75127, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void IntroTeleported()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OfficeIntro.NativeMethodInfoPtr_IntroTeleported_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060026C1 RID: 9921 RVA: 0x000A01C4 File Offset: 0x0009E3C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 75128, XrefRangeEnd = 75131, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator DoIt()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OfficeIntro.NativeMethodInfoPtr_DoIt_Private_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x060026C2 RID: 9922 RVA: 0x000A0204 File Offset: 0x0009E404
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 75131, XrefRangeEnd = 75134, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator ShitShit(GameObject obj)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OfficeIntro.NativeMethodInfoPtr_ShitShit_Private_IEnumerator_GameObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}
		}

		// Token: 0x060026C3 RID: 9923 RVA: 0x000A0254 File Offset: 0x0009E454
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 75167, RefRangeEnd = 75168, XrefRangeStart = 75134, XrefRangeEnd = 75167, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void BreakWindow(GameObject obj)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OfficeIntro.NativeMethodInfoPtr_BreakWindow_Public_Void_GameObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060026C4 RID: 9924 RVA: 0x000A0298 File Offset: 0x0009E498
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe OfficeIntro()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<OfficeIntro>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OfficeIntro.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060026C5 RID: 9925 RVA: 0x0001AF90 File Offset: 0x00019190
		public OfficeIntro(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000DEB RID: 3563
		// (get) Token: 0x060026C6 RID: 9926 RVA: 0x000A02D4 File Offset: 0x0009E4D4
		// (set) Token: 0x060026C7 RID: 9927 RVA: 0x0001AF99 File Offset: 0x00019199
		public unsafe static OfficeIntro me
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(OfficeIntro.NativeFieldInfoPtr_me, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<OfficeIntro>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(OfficeIntro.NativeFieldInfoPtr_me, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000DEC RID: 3564
		// (get) Token: 0x060026C8 RID: 9928 RVA: 0x000A02FC File Offset: 0x0009E4FC
		// (set) Token: 0x060026C9 RID: 9929 RVA: 0x0001AFAB File Offset: 0x000191AB
		public unsafe GameObject blackQuad
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OfficeIntro.NativeFieldInfoPtr_blackQuad);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(OfficeIntro.NativeFieldInfoPtr_blackQuad), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000DED RID: 3565
		// (get) Token: 0x060026CA RID: 9930 RVA: 0x000A032C File Offset: 0x0009E52C
		// (set) Token: 0x060026CB RID: 9931 RVA: 0x0001AFCA File Offset: 0x000191CA
		public unsafe Animator anim
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OfficeIntro.NativeFieldInfoPtr_anim);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Animator>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(OfficeIntro.NativeFieldInfoPtr_anim), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000DEE RID: 3566
		// (get) Token: 0x060026CC RID: 9932 RVA: 0x000A035C File Offset: 0x0009E55C
		// (set) Token: 0x060026CD RID: 9933 RVA: 0x0001AFE9 File Offset: 0x000191E9
		public unsafe AudioClip elevatorUp
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OfficeIntro.NativeFieldInfoPtr_elevatorUp);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioClip>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(OfficeIntro.NativeFieldInfoPtr_elevatorUp), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000DEF RID: 3567
		// (get) Token: 0x060026CE RID: 9934 RVA: 0x000A038C File Offset: 0x0009E58C
		// (set) Token: 0x060026CF RID: 9935 RVA: 0x0001B008 File Offset: 0x00019208
		public unsafe AudioClip elevatorDing
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OfficeIntro.NativeFieldInfoPtr_elevatorDing);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioClip>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(OfficeIntro.NativeFieldInfoPtr_elevatorDing), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000DF0 RID: 3568
		// (get) Token: 0x060026D0 RID: 9936 RVA: 0x000A03BC File Offset: 0x0009E5BC
		// (set) Token: 0x060026D1 RID: 9937 RVA: 0x0001B027 File Offset: 0x00019227
		public unsafe GameObject high
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OfficeIntro.NativeFieldInfoPtr_high);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(OfficeIntro.NativeFieldInfoPtr_high), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000DF1 RID: 3569
		// (get) Token: 0x060026D2 RID: 9938 RVA: 0x000A03EC File Offset: 0x0009E5EC
		// (set) Token: 0x060026D3 RID: 9939 RVA: 0x0001B046 File Offset: 0x00019246
		public unsafe GameObject rise
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OfficeIntro.NativeFieldInfoPtr_rise);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(OfficeIntro.NativeFieldInfoPtr_rise), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000DF2 RID: 3570
		// (get) Token: 0x060026D4 RID: 9940 RVA: 0x000A041C File Offset: 0x0009E61C
		// (set) Token: 0x060026D5 RID: 9941 RVA: 0x0001B065 File Offset: 0x00019265
		public unsafe Il2CppReferenceArray<GameObject> buildings
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OfficeIntro.NativeFieldInfoPtr_buildings);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<GameObject>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(OfficeIntro.NativeFieldInfoPtr_buildings), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000DF3 RID: 3571
		// (get) Token: 0x060026D6 RID: 9942 RVA: 0x000A044C File Offset: 0x0009E64C
		// (set) Token: 0x060026D7 RID: 9943 RVA: 0x0001B084 File Offset: 0x00019284
		public unsafe Material unWindowMat
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OfficeIntro.NativeFieldInfoPtr_unWindowMat);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Material>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(OfficeIntro.NativeFieldInfoPtr_unWindowMat), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000DF4 RID: 3572
		// (get) Token: 0x060026D8 RID: 9944 RVA: 0x000A047C File Offset: 0x0009E67C
		// (set) Token: 0x060026D9 RID: 9945 RVA: 0x0001B0A3 File Offset: 0x000192A3
		public unsafe bool brokeWindow
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OfficeIntro.NativeFieldInfoPtr_brokeWindow);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OfficeIntro.NativeFieldInfoPtr_brokeWindow)) = value;
			}
		}

		// Token: 0x17000DF5 RID: 3573
		// (get) Token: 0x060026DA RID: 9946 RVA: 0x000A04A4 File Offset: 0x0009E6A4
		// (set) Token: 0x060026DB RID: 9947 RVA: 0x0001B0BE File Offset: 0x000192BE
		public unsafe AnimationCurve fallCurve
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OfficeIntro.NativeFieldInfoPtr_fallCurve);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AnimationCurve>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(OfficeIntro.NativeFieldInfoPtr_fallCurve), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000DF6 RID: 3574
		// (get) Token: 0x060026DC RID: 9948 RVA: 0x000A04D4 File Offset: 0x0009E6D4
		// (set) Token: 0x060026DD RID: 9949 RVA: 0x0001B0DD File Offset: 0x000192DD
		public unsafe bool startFlag
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OfficeIntro.NativeFieldInfoPtr_startFlag);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OfficeIntro.NativeFieldInfoPtr_startFlag)) = value;
			}
		}

		// Token: 0x17000DF7 RID: 3575
		// (get) Token: 0x060026DE RID: 9950 RVA: 0x000A04FC File Offset: 0x0009E6FC
		// (set) Token: 0x060026DF RID: 9951 RVA: 0x0001B0F8 File Offset: 0x000192F8
		public unsafe GameObject allTheStuff
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OfficeIntro.NativeFieldInfoPtr_allTheStuff);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(OfficeIntro.NativeFieldInfoPtr_allTheStuff), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000DF8 RID: 3576
		// (get) Token: 0x060026E0 RID: 9952 RVA: 0x000A052C File Offset: 0x0009E72C
		// (set) Token: 0x060026E1 RID: 9953 RVA: 0x0001B117 File Offset: 0x00019317
		public unsafe GameObject brokenWindow
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OfficeIntro.NativeFieldInfoPtr_brokenWindow);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(OfficeIntro.NativeFieldInfoPtr_brokenWindow), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000DF9 RID: 3577
		// (get) Token: 0x060026E2 RID: 9954 RVA: 0x000A055C File Offset: 0x0009E75C
		// (set) Token: 0x060026E3 RID: 9955 RVA: 0x0001B136 File Offset: 0x00019336
		public unsafe CamFollower shadowCamfollower
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OfficeIntro.NativeFieldInfoPtr_shadowCamfollower);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CamFollower>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(OfficeIntro.NativeFieldInfoPtr_shadowCamfollower), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000DFA RID: 3578
		// (get) Token: 0x060026E4 RID: 9956 RVA: 0x000A058C File Offset: 0x0009E78C
		// (set) Token: 0x060026E5 RID: 9957 RVA: 0x0001B155 File Offset: 0x00019355
		public unsafe Il2CppReferenceArray<AudioSource> oldSounds
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OfficeIntro.NativeFieldInfoPtr_oldSounds);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<AudioSource>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(OfficeIntro.NativeFieldInfoPtr_oldSounds), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000DFB RID: 3579
		// (get) Token: 0x060026E6 RID: 9958 RVA: 0x000A05BC File Offset: 0x0009E7BC
		// (set) Token: 0x060026E7 RID: 9959 RVA: 0x0001B174 File Offset: 0x00019374
		public unsafe GameObject blackLeft
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OfficeIntro.NativeFieldInfoPtr_blackLeft);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(OfficeIntro.NativeFieldInfoPtr_blackLeft), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000DFC RID: 3580
		// (get) Token: 0x060026E8 RID: 9960 RVA: 0x000A05EC File Offset: 0x0009E7EC
		// (set) Token: 0x060026E9 RID: 9961 RVA: 0x0001B193 File Offset: 0x00019393
		public unsafe GameObject blackRight
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OfficeIntro.NativeFieldInfoPtr_blackRight);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(OfficeIntro.NativeFieldInfoPtr_blackRight), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040016DC RID: 5852
		private static readonly IntPtr NativeFieldInfoPtr_me;

		// Token: 0x040016DD RID: 5853
		private static readonly IntPtr NativeFieldInfoPtr_blackQuad;

		// Token: 0x040016DE RID: 5854
		private static readonly IntPtr NativeFieldInfoPtr_anim;

		// Token: 0x040016DF RID: 5855
		private static readonly IntPtr NativeFieldInfoPtr_elevatorUp;

		// Token: 0x040016E0 RID: 5856
		private static readonly IntPtr NativeFieldInfoPtr_elevatorDing;

		// Token: 0x040016E1 RID: 5857
		private static readonly IntPtr NativeFieldInfoPtr_high;

		// Token: 0x040016E2 RID: 5858
		private static readonly IntPtr NativeFieldInfoPtr_rise;

		// Token: 0x040016E3 RID: 5859
		private static readonly IntPtr NativeFieldInfoPtr_buildings;

		// Token: 0x040016E4 RID: 5860
		private static readonly IntPtr NativeFieldInfoPtr_unWindowMat;

		// Token: 0x040016E5 RID: 5861
		private static readonly IntPtr NativeFieldInfoPtr_brokeWindow;

		// Token: 0x040016E6 RID: 5862
		private static readonly IntPtr NativeFieldInfoPtr_fallCurve;

		// Token: 0x040016E7 RID: 5863
		private static readonly IntPtr NativeFieldInfoPtr_startFlag;

		// Token: 0x040016E8 RID: 5864
		private static readonly IntPtr NativeFieldInfoPtr_allTheStuff;

		// Token: 0x040016E9 RID: 5865
		private static readonly IntPtr NativeFieldInfoPtr_brokenWindow;

		// Token: 0x040016EA RID: 5866
		private static readonly IntPtr NativeFieldInfoPtr_shadowCamfollower;

		// Token: 0x040016EB RID: 5867
		private static readonly IntPtr NativeFieldInfoPtr_oldSounds;

		// Token: 0x040016EC RID: 5868
		private static readonly IntPtr NativeFieldInfoPtr_blackLeft;

		// Token: 0x040016ED RID: 5869
		private static readonly IntPtr NativeFieldInfoPtr_blackRight;

		// Token: 0x040016EE RID: 5870
		private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

		// Token: 0x040016EF RID: 5871
		private static readonly IntPtr NativeMethodInfoPtr_OnDestroy_Private_Void_0;

		// Token: 0x040016F0 RID: 5872
		private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

		// Token: 0x040016F1 RID: 5873
		private static readonly IntPtr NativeMethodInfoPtr_IntroTeleported_Public_Void_0;

		// Token: 0x040016F2 RID: 5874
		private static readonly IntPtr NativeMethodInfoPtr_DoIt_Private_IEnumerator_0;

		// Token: 0x040016F3 RID: 5875
		private static readonly IntPtr NativeMethodInfoPtr_ShitShit_Private_IEnumerator_GameObject_0;

		// Token: 0x040016F4 RID: 5876
		private static readonly IntPtr NativeMethodInfoPtr_BreakWindow_Public_Void_GameObject_0;

		// Token: 0x040016F5 RID: 5877
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000338 RID: 824
		[ObfuscatedName("OfficeIntro+<DoIt>d__22")]
		public sealed class _DoIt_d__22 : global::Il2CppSystem.Object
		{
			// Token: 0x060051F7 RID: 20983 RVA: 0x0012A2CC File Offset: 0x001284CC
			// Note: this type is marked as 'beforefieldinit'.
			static _DoIt_d__22()
			{
				Il2CppClassPointerStore<OfficeIntro._DoIt_d__22>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<OfficeIntro>.NativeClassPtr, "<DoIt>d__22");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<OfficeIntro._DoIt_d__22>.NativeClassPtr);
				OfficeIntro._DoIt_d__22.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OfficeIntro._DoIt_d__22>.NativeClassPtr, "<>1__state");
				OfficeIntro._DoIt_d__22.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OfficeIntro._DoIt_d__22>.NativeClassPtr, "<>2__current");
				OfficeIntro._DoIt_d__22.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OfficeIntro._DoIt_d__22>.NativeClassPtr, "<>4__this");
				OfficeIntro._DoIt_d__22.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OfficeIntro._DoIt_d__22>.NativeClassPtr, 100666403);
				OfficeIntro._DoIt_d__22.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OfficeIntro._DoIt_d__22>.NativeClassPtr, 100666404);
				OfficeIntro._DoIt_d__22.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OfficeIntro._DoIt_d__22>.NativeClassPtr, 100666405);
				OfficeIntro._DoIt_d__22.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OfficeIntro._DoIt_d__22>.NativeClassPtr, 100666406);
				OfficeIntro._DoIt_d__22.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OfficeIntro._DoIt_d__22>.NativeClassPtr, 100666407);
				OfficeIntro._DoIt_d__22.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OfficeIntro._DoIt_d__22>.NativeClassPtr, 100666408);
			}

			// Token: 0x060051F8 RID: 20984 RVA: 0x0012A3AC File Offset: 0x001285AC
			[CallerCount(0)]
			public unsafe _DoIt_d__22(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<OfficeIntro._DoIt_d__22>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OfficeIntro._DoIt_d__22.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060051F9 RID: 20985 RVA: 0x0012A3F4 File Offset: 0x001285F4
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OfficeIntro._DoIt_d__22.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060051FA RID: 20986 RVA: 0x0012A428 File Offset: 0x00128628
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 74905, XrefRangeEnd = 74915, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OfficeIntro._DoIt_d__22.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17001DE4 RID: 7652
			// (get) Token: 0x060051FB RID: 20987 RVA: 0x0012A464 File Offset: 0x00128664
			public unsafe global::Il2CppSystem.Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OfficeIntro._DoIt_d__22.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x060051FC RID: 20988 RVA: 0x0012A4A4 File Offset: 0x001286A4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 74915, XrefRangeEnd = 74920, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OfficeIntro._DoIt_d__22.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17001DE5 RID: 7653
			// (get) Token: 0x060051FD RID: 20989 RVA: 0x0012A4D8 File Offset: 0x001286D8
			public unsafe global::Il2CppSystem.Object System.Collections.IEnumerator.Current
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OfficeIntro._DoIt_d__22.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x060051FE RID: 20990 RVA: 0x0002FC8D File Offset: 0x0002DE8D
			public _DoIt_d__22(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001DE1 RID: 7649
			// (get) Token: 0x060051FF RID: 20991 RVA: 0x0012A518 File Offset: 0x00128718
			// (set) Token: 0x06005200 RID: 20992 RVA: 0x0002FC96 File Offset: 0x0002DE96
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OfficeIntro._DoIt_d__22.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OfficeIntro._DoIt_d__22.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17001DE2 RID: 7650
			// (get) Token: 0x06005201 RID: 20993 RVA: 0x0012A540 File Offset: 0x00128740
			// (set) Token: 0x06005202 RID: 20994 RVA: 0x0002FCB1 File Offset: 0x0002DEB1
			public unsafe global::Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OfficeIntro._DoIt_d__22.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(OfficeIntro._DoIt_d__22.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001DE3 RID: 7651
			// (get) Token: 0x06005203 RID: 20995 RVA: 0x0012A570 File Offset: 0x00128770
			// (set) Token: 0x06005204 RID: 20996 RVA: 0x0002FCD0 File Offset: 0x0002DED0
			public unsafe OfficeIntro __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OfficeIntro._DoIt_d__22.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<OfficeIntro>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(OfficeIntro._DoIt_d__22.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04003630 RID: 13872
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04003631 RID: 13873
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04003632 RID: 13874
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04003633 RID: 13875
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04003634 RID: 13876
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04003635 RID: 13877
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04003636 RID: 13878
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04003637 RID: 13879
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04003638 RID: 13880
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}

		// Token: 0x02000339 RID: 825
		[ObfuscatedName("OfficeIntro+<ShitShit>d__23")]
		public sealed class _ShitShit_d__23 : global::Il2CppSystem.Object
		{
			// Token: 0x06005205 RID: 20997 RVA: 0x0012A5A0 File Offset: 0x001287A0
			// Note: this type is marked as 'beforefieldinit'.
			static _ShitShit_d__23()
			{
				Il2CppClassPointerStore<OfficeIntro._ShitShit_d__23>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<OfficeIntro>.NativeClassPtr, "<ShitShit>d__23");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<OfficeIntro._ShitShit_d__23>.NativeClassPtr);
				OfficeIntro._ShitShit_d__23.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OfficeIntro._ShitShit_d__23>.NativeClassPtr, "<>1__state");
				OfficeIntro._ShitShit_d__23.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OfficeIntro._ShitShit_d__23>.NativeClassPtr, "<>2__current");
				OfficeIntro._ShitShit_d__23.NativeFieldInfoPtr_obj = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OfficeIntro._ShitShit_d__23>.NativeClassPtr, "obj");
				OfficeIntro._ShitShit_d__23.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OfficeIntro._ShitShit_d__23>.NativeClassPtr, "<>4__this");
				OfficeIntro._ShitShit_d__23.NativeFieldInfoPtr__tim_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OfficeIntro._ShitShit_d__23>.NativeClassPtr, "<tim>5__2");
				OfficeIntro._ShitShit_d__23.NativeFieldInfoPtr__state_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OfficeIntro._ShitShit_d__23>.NativeClassPtr, "<state>5__3");
				OfficeIntro._ShitShit_d__23.NativeFieldInfoPtr__biped_5__4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OfficeIntro._ShitShit_d__23>.NativeClassPtr, "<biped>5__4");
				OfficeIntro._ShitShit_d__23.NativeFieldInfoPtr__dead_5__5 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OfficeIntro._ShitShit_d__23>.NativeClassPtr, "<dead>5__5");
				OfficeIntro._ShitShit_d__23.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OfficeIntro._ShitShit_d__23>.NativeClassPtr, 100666409);
				OfficeIntro._ShitShit_d__23.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OfficeIntro._ShitShit_d__23>.NativeClassPtr, 100666410);
				OfficeIntro._ShitShit_d__23.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OfficeIntro._ShitShit_d__23>.NativeClassPtr, 100666411);
				OfficeIntro._ShitShit_d__23.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OfficeIntro._ShitShit_d__23>.NativeClassPtr, 100666412);
				OfficeIntro._ShitShit_d__23.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OfficeIntro._ShitShit_d__23>.NativeClassPtr, 100666413);
				OfficeIntro._ShitShit_d__23.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OfficeIntro._ShitShit_d__23>.NativeClassPtr, 100666414);
			}

			// Token: 0x06005206 RID: 20998 RVA: 0x0012A6E4 File Offset: 0x001288E4
			[CallerCount(0)]
			public unsafe _ShitShit_d__23(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<OfficeIntro._ShitShit_d__23>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OfficeIntro._ShitShit_d__23.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06005207 RID: 20999 RVA: 0x0012A72C File Offset: 0x0012892C
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OfficeIntro._ShitShit_d__23.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06005208 RID: 21000 RVA: 0x0012A760 File Offset: 0x00128960
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 74920, XrefRangeEnd = 74995, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OfficeIntro._ShitShit_d__23.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17001DEE RID: 7662
			// (get) Token: 0x06005209 RID: 21001 RVA: 0x0012A79C File Offset: 0x0012899C
			public unsafe global::Il2CppSystem.Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OfficeIntro._ShitShit_d__23.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600520A RID: 21002 RVA: 0x0012A7DC File Offset: 0x001289DC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 74995, XrefRangeEnd = 75000, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OfficeIntro._ShitShit_d__23.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17001DEF RID: 7663
			// (get) Token: 0x0600520B RID: 21003 RVA: 0x0012A810 File Offset: 0x00128A10
			public unsafe global::Il2CppSystem.Object System.Collections.IEnumerator.Current
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OfficeIntro._ShitShit_d__23.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600520C RID: 21004 RVA: 0x0002FCEF File Offset: 0x0002DEEF
			public _ShitShit_d__23(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001DE6 RID: 7654
			// (get) Token: 0x0600520D RID: 21005 RVA: 0x0012A850 File Offset: 0x00128A50
			// (set) Token: 0x0600520E RID: 21006 RVA: 0x0002FCF8 File Offset: 0x0002DEF8
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OfficeIntro._ShitShit_d__23.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OfficeIntro._ShitShit_d__23.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17001DE7 RID: 7655
			// (get) Token: 0x0600520F RID: 21007 RVA: 0x0012A878 File Offset: 0x00128A78
			// (set) Token: 0x06005210 RID: 21008 RVA: 0x0002FD13 File Offset: 0x0002DF13
			public unsafe global::Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OfficeIntro._ShitShit_d__23.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(OfficeIntro._ShitShit_d__23.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001DE8 RID: 7656
			// (get) Token: 0x06005211 RID: 21009 RVA: 0x0012A8A8 File Offset: 0x00128AA8
			// (set) Token: 0x06005212 RID: 21010 RVA: 0x0002FD32 File Offset: 0x0002DF32
			public unsafe GameObject obj
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OfficeIntro._ShitShit_d__23.NativeFieldInfoPtr_obj);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(OfficeIntro._ShitShit_d__23.NativeFieldInfoPtr_obj), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001DE9 RID: 7657
			// (get) Token: 0x06005213 RID: 21011 RVA: 0x0012A8D8 File Offset: 0x00128AD8
			// (set) Token: 0x06005214 RID: 21012 RVA: 0x0002FD51 File Offset: 0x0002DF51
			public unsafe OfficeIntro __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OfficeIntro._ShitShit_d__23.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<OfficeIntro>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(OfficeIntro._ShitShit_d__23.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001DEA RID: 7658
			// (get) Token: 0x06005215 RID: 21013 RVA: 0x0012A908 File Offset: 0x00128B08
			// (set) Token: 0x06005216 RID: 21014 RVA: 0x0002FD70 File Offset: 0x0002DF70
			public unsafe float _tim_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OfficeIntro._ShitShit_d__23.NativeFieldInfoPtr__tim_5__2);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OfficeIntro._ShitShit_d__23.NativeFieldInfoPtr__tim_5__2)) = value;
				}
			}

			// Token: 0x17001DEB RID: 7659
			// (get) Token: 0x06005217 RID: 21015 RVA: 0x0012A930 File Offset: 0x00128B30
			// (set) Token: 0x06005218 RID: 21016 RVA: 0x0002FD8B File Offset: 0x0002DF8B
			public unsafe GuardState _state_5__3
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OfficeIntro._ShitShit_d__23.NativeFieldInfoPtr__state_5__3);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<GuardState>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(OfficeIntro._ShitShit_d__23.NativeFieldInfoPtr__state_5__3), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001DEC RID: 7660
			// (get) Token: 0x06005219 RID: 21017 RVA: 0x0012A960 File Offset: 0x00128B60
			// (set) Token: 0x0600521A RID: 21018 RVA: 0x0002FDAA File Offset: 0x0002DFAA
			public unsafe Biped _biped_5__4
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OfficeIntro._ShitShit_d__23.NativeFieldInfoPtr__biped_5__4);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Biped>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(OfficeIntro._ShitShit_d__23.NativeFieldInfoPtr__biped_5__4), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001DED RID: 7661
			// (get) Token: 0x0600521B RID: 21019 RVA: 0x0012A990 File Offset: 0x00128B90
			// (set) Token: 0x0600521C RID: 21020 RVA: 0x0002FDC9 File Offset: 0x0002DFC9
			public unsafe bool _dead_5__5
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OfficeIntro._ShitShit_d__23.NativeFieldInfoPtr__dead_5__5);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OfficeIntro._ShitShit_d__23.NativeFieldInfoPtr__dead_5__5)) = value;
				}
			}

			// Token: 0x04003639 RID: 13881
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x0400363A RID: 13882
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x0400363B RID: 13883
			private static readonly IntPtr NativeFieldInfoPtr_obj;

			// Token: 0x0400363C RID: 13884
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x0400363D RID: 13885
			private static readonly IntPtr NativeFieldInfoPtr__tim_5__2;

			// Token: 0x0400363E RID: 13886
			private static readonly IntPtr NativeFieldInfoPtr__state_5__3;

			// Token: 0x0400363F RID: 13887
			private static readonly IntPtr NativeFieldInfoPtr__biped_5__4;

			// Token: 0x04003640 RID: 13888
			private static readonly IntPtr NativeFieldInfoPtr__dead_5__5;

			// Token: 0x04003641 RID: 13889
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04003642 RID: 13890
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04003643 RID: 13891
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04003644 RID: 13892
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04003645 RID: 13893
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04003646 RID: 13894
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
