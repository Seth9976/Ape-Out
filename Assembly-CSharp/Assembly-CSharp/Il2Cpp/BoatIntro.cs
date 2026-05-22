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
	// Token: 0x02000088 RID: 136
	public class BoatIntro : MonoBehaviour
	{
		// Token: 0x060010BD RID: 4285 RVA: 0x00064CB4 File Offset: 0x00062EB4
		// Note: this type is marked as 'beforefieldinit'.
		static BoatIntro()
		{
			Il2CppClassPointerStore<BoatIntro>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "BoatIntro");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BoatIntro>.NativeClassPtr);
			BoatIntro.NativeFieldInfoPtr_darkSpot = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BoatIntro>.NativeClassPtr, "darkSpot");
			BoatIntro.NativeFieldInfoPtr_letters = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BoatIntro>.NativeClassPtr, "letters");
			BoatIntro.NativeFieldInfoPtr_camCurve = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BoatIntro>.NativeClassPtr, "camCurve");
			BoatIntro.NativeFieldInfoPtr_camTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BoatIntro>.NativeClassPtr, "camTime");
			BoatIntro.NativeFieldInfoPtr_camTimer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BoatIntro>.NativeClassPtr, "camTimer");
			BoatIntro.NativeFieldInfoPtr_scaleCurve = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BoatIntro>.NativeClassPtr, "scaleCurve");
			BoatIntro.NativeFieldInfoPtr_scaleTimer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BoatIntro>.NativeClassPtr, "scaleTimer");
			BoatIntro.NativeFieldInfoPtr_scaleTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BoatIntro>.NativeClassPtr, "scaleTime");
			BoatIntro.NativeFieldInfoPtr_startPos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BoatIntro>.NativeClassPtr, "startPos");
			BoatIntro.NativeFieldInfoPtr_timer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BoatIntro>.NativeClassPtr, "timer");
			BoatIntro.NativeFieldInfoPtr_heartBeat = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BoatIntro>.NativeClassPtr, "heartBeat");
			BoatIntro.NativeFieldInfoPtr_anim = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BoatIntro>.NativeClassPtr, "anim");
			BoatIntro.NativeFieldInfoPtr_tranqPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BoatIntro>.NativeClassPtr, "tranqPrefab");
			BoatIntro.NativeFieldInfoPtr_bird = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BoatIntro>.NativeClassPtr, "bird");
			BoatIntro.NativeFieldInfoPtr_forest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BoatIntro>.NativeClassPtr, "forest");
			BoatIntro.NativeFieldInfoPtr_done = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BoatIntro>.NativeClassPtr, "done");
			BoatIntro.NativeFieldInfoPtr_overrode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BoatIntro>.NativeClassPtr, "overrode");
			BoatIntro.NativeFieldInfoPtr_jungleAmb = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BoatIntro>.NativeClassPtr, "jungleAmb");
			BoatIntro.NativeFieldInfoPtr_delaypt1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BoatIntro>.NativeClassPtr, "delaypt1");
			BoatIntro.NativeFieldInfoPtr_delay1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BoatIntro>.NativeClassPtr, "delay1");
			BoatIntro.NativeFieldInfoPtr_delaypt3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BoatIntro>.NativeClassPtr, "delaypt3");
			BoatIntro.NativeFieldInfoPtr_delay2pt2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BoatIntro>.NativeClassPtr, "delay2pt2");
			BoatIntro.NativeFieldInfoPtr_delay5 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BoatIntro>.NativeClassPtr, "delay5");
			BoatIntro.NativeFieldInfoPtr_delay7 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BoatIntro>.NativeClassPtr, "delay7");
			BoatIntro.NativeFieldInfoPtr_delayForFixedUpdate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BoatIntro>.NativeClassPtr, "delayForFixedUpdate");
			BoatIntro.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BoatIntro>.NativeClassPtr, 100664711);
			BoatIntro.NativeMethodInfoPtr_Letters_Private_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BoatIntro>.NativeClassPtr, 100664712);
			BoatIntro.NativeMethodInfoPtr_DoorSlammed_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BoatIntro>.NativeClassPtr, 100664713);
			BoatIntro.NativeMethodInfoPtr_DoIt_Private_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BoatIntro>.NativeClassPtr, 100664714);
			BoatIntro.NativeMethodInfoPtr_ZoomIn_Private_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BoatIntro>.NativeClassPtr, 100664715);
			BoatIntro.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BoatIntro>.NativeClassPtr, 100664716);
		}

		// Token: 0x060010BE RID: 4286 RVA: 0x00064F50 File Offset: 0x00063150
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 48554, XrefRangeEnd = 48589, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BoatIntro.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060010BF RID: 4287 RVA: 0x00064F84 File Offset: 0x00063184
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 48589, XrefRangeEnd = 48592, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator Letters()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BoatIntro.NativeMethodInfoPtr_Letters_Private_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x060010C0 RID: 4288 RVA: 0x00064FC4 File Offset: 0x000631C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 48592, XrefRangeEnd = 48601, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DoorSlammed()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BoatIntro.NativeMethodInfoPtr_DoorSlammed_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060010C1 RID: 4289 RVA: 0x00064FF8 File Offset: 0x000631F8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 48601, XrefRangeEnd = 48604, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator DoIt()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BoatIntro.NativeMethodInfoPtr_DoIt_Private_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x060010C2 RID: 4290 RVA: 0x00065038 File Offset: 0x00063238
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 48604, XrefRangeEnd = 48607, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator ZoomIn()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BoatIntro.NativeMethodInfoPtr_ZoomIn_Private_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x060010C3 RID: 4291 RVA: 0x00065078 File Offset: 0x00063278
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 48607, XrefRangeEnd = 48626, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe BoatIntro()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BoatIntro>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BoatIntro.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060010C4 RID: 4292 RVA: 0x0000C547 File Offset: 0x0000A747
		public BoatIntro(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000609 RID: 1545
		// (get) Token: 0x060010C5 RID: 4293 RVA: 0x000650B4 File Offset: 0x000632B4
		// (set) Token: 0x060010C6 RID: 4294 RVA: 0x0000C550 File Offset: 0x0000A750
		public unsafe Transform darkSpot
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BoatIntro.NativeFieldInfoPtr_darkSpot);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BoatIntro.NativeFieldInfoPtr_darkSpot), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700060A RID: 1546
		// (get) Token: 0x060010C7 RID: 4295 RVA: 0x000650E4 File Offset: 0x000632E4
		// (set) Token: 0x060010C8 RID: 4296 RVA: 0x0000C56F File Offset: 0x0000A76F
		public unsafe Il2CppReferenceArray<GameObject> letters
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BoatIntro.NativeFieldInfoPtr_letters);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<GameObject>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BoatIntro.NativeFieldInfoPtr_letters), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700060B RID: 1547
		// (get) Token: 0x060010C9 RID: 4297 RVA: 0x00065114 File Offset: 0x00063314
		// (set) Token: 0x060010CA RID: 4298 RVA: 0x0000C58E File Offset: 0x0000A78E
		public unsafe AnimationCurve camCurve
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BoatIntro.NativeFieldInfoPtr_camCurve);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AnimationCurve>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BoatIntro.NativeFieldInfoPtr_camCurve), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700060C RID: 1548
		// (get) Token: 0x060010CB RID: 4299 RVA: 0x00065144 File Offset: 0x00063344
		// (set) Token: 0x060010CC RID: 4300 RVA: 0x0000C5AD File Offset: 0x0000A7AD
		public unsafe float camTime
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BoatIntro.NativeFieldInfoPtr_camTime);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BoatIntro.NativeFieldInfoPtr_camTime)) = value;
			}
		}

		// Token: 0x1700060D RID: 1549
		// (get) Token: 0x060010CD RID: 4301 RVA: 0x0006516C File Offset: 0x0006336C
		// (set) Token: 0x060010CE RID: 4302 RVA: 0x0000C5C8 File Offset: 0x0000A7C8
		public unsafe float camTimer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BoatIntro.NativeFieldInfoPtr_camTimer);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BoatIntro.NativeFieldInfoPtr_camTimer)) = value;
			}
		}

		// Token: 0x1700060E RID: 1550
		// (get) Token: 0x060010CF RID: 4303 RVA: 0x00065194 File Offset: 0x00063394
		// (set) Token: 0x060010D0 RID: 4304 RVA: 0x0000C5E3 File Offset: 0x0000A7E3
		public unsafe AnimationCurve scaleCurve
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BoatIntro.NativeFieldInfoPtr_scaleCurve);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AnimationCurve>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BoatIntro.NativeFieldInfoPtr_scaleCurve), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700060F RID: 1551
		// (get) Token: 0x060010D1 RID: 4305 RVA: 0x000651C4 File Offset: 0x000633C4
		// (set) Token: 0x060010D2 RID: 4306 RVA: 0x0000C602 File Offset: 0x0000A802
		public unsafe float scaleTimer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BoatIntro.NativeFieldInfoPtr_scaleTimer);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BoatIntro.NativeFieldInfoPtr_scaleTimer)) = value;
			}
		}

		// Token: 0x17000610 RID: 1552
		// (get) Token: 0x060010D3 RID: 4307 RVA: 0x000651EC File Offset: 0x000633EC
		// (set) Token: 0x060010D4 RID: 4308 RVA: 0x0000C61D File Offset: 0x0000A81D
		public unsafe float scaleTime
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BoatIntro.NativeFieldInfoPtr_scaleTime);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BoatIntro.NativeFieldInfoPtr_scaleTime)) = value;
			}
		}

		// Token: 0x17000611 RID: 1553
		// (get) Token: 0x060010D5 RID: 4309 RVA: 0x00065214 File Offset: 0x00063414
		// (set) Token: 0x060010D6 RID: 4310 RVA: 0x0000C638 File Offset: 0x0000A838
		public unsafe Vector3 startPos
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BoatIntro.NativeFieldInfoPtr_startPos);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BoatIntro.NativeFieldInfoPtr_startPos)) = value;
			}
		}

		// Token: 0x17000612 RID: 1554
		// (get) Token: 0x060010D7 RID: 4311 RVA: 0x0006523C File Offset: 0x0006343C
		// (set) Token: 0x060010D8 RID: 4312 RVA: 0x0000C653 File Offset: 0x0000A853
		public unsafe float timer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BoatIntro.NativeFieldInfoPtr_timer);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BoatIntro.NativeFieldInfoPtr_timer)) = value;
			}
		}

		// Token: 0x17000613 RID: 1555
		// (get) Token: 0x060010D9 RID: 4313 RVA: 0x00065264 File Offset: 0x00063464
		// (set) Token: 0x060010DA RID: 4314 RVA: 0x0000C66E File Offset: 0x0000A86E
		public unsafe AudioSource heartBeat
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BoatIntro.NativeFieldInfoPtr_heartBeat);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioSource>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BoatIntro.NativeFieldInfoPtr_heartBeat), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000614 RID: 1556
		// (get) Token: 0x060010DB RID: 4315 RVA: 0x00065294 File Offset: 0x00063494
		// (set) Token: 0x060010DC RID: 4316 RVA: 0x0000C68D File Offset: 0x0000A88D
		public unsafe Animator anim
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BoatIntro.NativeFieldInfoPtr_anim);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Animator>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BoatIntro.NativeFieldInfoPtr_anim), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000615 RID: 1557
		// (get) Token: 0x060010DD RID: 4317 RVA: 0x000652C4 File Offset: 0x000634C4
		// (set) Token: 0x060010DE RID: 4318 RVA: 0x0000C6AC File Offset: 0x0000A8AC
		public unsafe GameObject tranqPrefab
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BoatIntro.NativeFieldInfoPtr_tranqPrefab);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BoatIntro.NativeFieldInfoPtr_tranqPrefab), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000616 RID: 1558
		// (get) Token: 0x060010DF RID: 4319 RVA: 0x000652F4 File Offset: 0x000634F4
		// (set) Token: 0x060010E0 RID: 4320 RVA: 0x0000C6CB File Offset: 0x0000A8CB
		public unsafe GameObject bird
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BoatIntro.NativeFieldInfoPtr_bird);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BoatIntro.NativeFieldInfoPtr_bird), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000617 RID: 1559
		// (get) Token: 0x060010E1 RID: 4321 RVA: 0x00065324 File Offset: 0x00063524
		// (set) Token: 0x060010E2 RID: 4322 RVA: 0x0000C6EA File Offset: 0x0000A8EA
		public unsafe AudioSource forest
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BoatIntro.NativeFieldInfoPtr_forest);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioSource>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BoatIntro.NativeFieldInfoPtr_forest), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000618 RID: 1560
		// (get) Token: 0x060010E3 RID: 4323 RVA: 0x00065354 File Offset: 0x00063554
		// (set) Token: 0x060010E4 RID: 4324 RVA: 0x0000C709 File Offset: 0x0000A909
		public unsafe bool done
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BoatIntro.NativeFieldInfoPtr_done);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BoatIntro.NativeFieldInfoPtr_done)) = value;
			}
		}

		// Token: 0x17000619 RID: 1561
		// (get) Token: 0x060010E5 RID: 4325 RVA: 0x0006537C File Offset: 0x0006357C
		// (set) Token: 0x060010E6 RID: 4326 RVA: 0x0000C724 File Offset: 0x0000A924
		public unsafe bool overrode
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BoatIntro.NativeFieldInfoPtr_overrode);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BoatIntro.NativeFieldInfoPtr_overrode)) = value;
			}
		}

		// Token: 0x1700061A RID: 1562
		// (get) Token: 0x060010E7 RID: 4327 RVA: 0x000653A4 File Offset: 0x000635A4
		// (set) Token: 0x060010E8 RID: 4328 RVA: 0x0000C73F File Offset: 0x0000A93F
		public unsafe AudioClip jungleAmb
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BoatIntro.NativeFieldInfoPtr_jungleAmb);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioClip>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BoatIntro.NativeFieldInfoPtr_jungleAmb), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700061B RID: 1563
		// (get) Token: 0x060010E9 RID: 4329 RVA: 0x000653D4 File Offset: 0x000635D4
		// (set) Token: 0x060010EA RID: 4330 RVA: 0x0000C75E File Offset: 0x0000A95E
		public unsafe WaitForSeconds delaypt1
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BoatIntro.NativeFieldInfoPtr_delaypt1);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<WaitForSeconds>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BoatIntro.NativeFieldInfoPtr_delaypt1), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700061C RID: 1564
		// (get) Token: 0x060010EB RID: 4331 RVA: 0x00065404 File Offset: 0x00063604
		// (set) Token: 0x060010EC RID: 4332 RVA: 0x0000C77D File Offset: 0x0000A97D
		public unsafe WaitForSeconds delay1
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BoatIntro.NativeFieldInfoPtr_delay1);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<WaitForSeconds>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BoatIntro.NativeFieldInfoPtr_delay1), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700061D RID: 1565
		// (get) Token: 0x060010ED RID: 4333 RVA: 0x00065434 File Offset: 0x00063634
		// (set) Token: 0x060010EE RID: 4334 RVA: 0x0000C79C File Offset: 0x0000A99C
		public unsafe WaitForSeconds delaypt3
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BoatIntro.NativeFieldInfoPtr_delaypt3);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<WaitForSeconds>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BoatIntro.NativeFieldInfoPtr_delaypt3), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700061E RID: 1566
		// (get) Token: 0x060010EF RID: 4335 RVA: 0x00065464 File Offset: 0x00063664
		// (set) Token: 0x060010F0 RID: 4336 RVA: 0x0000C7BB File Offset: 0x0000A9BB
		public unsafe WaitForSeconds delay2pt2
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BoatIntro.NativeFieldInfoPtr_delay2pt2);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<WaitForSeconds>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BoatIntro.NativeFieldInfoPtr_delay2pt2), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700061F RID: 1567
		// (get) Token: 0x060010F1 RID: 4337 RVA: 0x00065494 File Offset: 0x00063694
		// (set) Token: 0x060010F2 RID: 4338 RVA: 0x0000C7DA File Offset: 0x0000A9DA
		public unsafe WaitForSeconds delay5
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BoatIntro.NativeFieldInfoPtr_delay5);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<WaitForSeconds>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BoatIntro.NativeFieldInfoPtr_delay5), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000620 RID: 1568
		// (get) Token: 0x060010F3 RID: 4339 RVA: 0x000654C4 File Offset: 0x000636C4
		// (set) Token: 0x060010F4 RID: 4340 RVA: 0x0000C7F9 File Offset: 0x0000A9F9
		public unsafe WaitForSeconds delay7
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BoatIntro.NativeFieldInfoPtr_delay7);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<WaitForSeconds>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BoatIntro.NativeFieldInfoPtr_delay7), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000621 RID: 1569
		// (get) Token: 0x060010F5 RID: 4341 RVA: 0x000654F4 File Offset: 0x000636F4
		// (set) Token: 0x060010F6 RID: 4342 RVA: 0x0000C818 File Offset: 0x0000AA18
		public unsafe WaitForFixedUpdate delayForFixedUpdate
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BoatIntro.NativeFieldInfoPtr_delayForFixedUpdate);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<WaitForFixedUpdate>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BoatIntro.NativeFieldInfoPtr_delayForFixedUpdate), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000A27 RID: 2599
		private static readonly IntPtr NativeFieldInfoPtr_darkSpot;

		// Token: 0x04000A28 RID: 2600
		private static readonly IntPtr NativeFieldInfoPtr_letters;

		// Token: 0x04000A29 RID: 2601
		private static readonly IntPtr NativeFieldInfoPtr_camCurve;

		// Token: 0x04000A2A RID: 2602
		private static readonly IntPtr NativeFieldInfoPtr_camTime;

		// Token: 0x04000A2B RID: 2603
		private static readonly IntPtr NativeFieldInfoPtr_camTimer;

		// Token: 0x04000A2C RID: 2604
		private static readonly IntPtr NativeFieldInfoPtr_scaleCurve;

		// Token: 0x04000A2D RID: 2605
		private static readonly IntPtr NativeFieldInfoPtr_scaleTimer;

		// Token: 0x04000A2E RID: 2606
		private static readonly IntPtr NativeFieldInfoPtr_scaleTime;

		// Token: 0x04000A2F RID: 2607
		private static readonly IntPtr NativeFieldInfoPtr_startPos;

		// Token: 0x04000A30 RID: 2608
		private static readonly IntPtr NativeFieldInfoPtr_timer;

		// Token: 0x04000A31 RID: 2609
		private static readonly IntPtr NativeFieldInfoPtr_heartBeat;

		// Token: 0x04000A32 RID: 2610
		private static readonly IntPtr NativeFieldInfoPtr_anim;

		// Token: 0x04000A33 RID: 2611
		private static readonly IntPtr NativeFieldInfoPtr_tranqPrefab;

		// Token: 0x04000A34 RID: 2612
		private static readonly IntPtr NativeFieldInfoPtr_bird;

		// Token: 0x04000A35 RID: 2613
		private static readonly IntPtr NativeFieldInfoPtr_forest;

		// Token: 0x04000A36 RID: 2614
		private static readonly IntPtr NativeFieldInfoPtr_done;

		// Token: 0x04000A37 RID: 2615
		private static readonly IntPtr NativeFieldInfoPtr_overrode;

		// Token: 0x04000A38 RID: 2616
		private static readonly IntPtr NativeFieldInfoPtr_jungleAmb;

		// Token: 0x04000A39 RID: 2617
		private static readonly IntPtr NativeFieldInfoPtr_delaypt1;

		// Token: 0x04000A3A RID: 2618
		private static readonly IntPtr NativeFieldInfoPtr_delay1;

		// Token: 0x04000A3B RID: 2619
		private static readonly IntPtr NativeFieldInfoPtr_delaypt3;

		// Token: 0x04000A3C RID: 2620
		private static readonly IntPtr NativeFieldInfoPtr_delay2pt2;

		// Token: 0x04000A3D RID: 2621
		private static readonly IntPtr NativeFieldInfoPtr_delay5;

		// Token: 0x04000A3E RID: 2622
		private static readonly IntPtr NativeFieldInfoPtr_delay7;

		// Token: 0x04000A3F RID: 2623
		private static readonly IntPtr NativeFieldInfoPtr_delayForFixedUpdate;

		// Token: 0x04000A40 RID: 2624
		private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

		// Token: 0x04000A41 RID: 2625
		private static readonly IntPtr NativeMethodInfoPtr_Letters_Private_IEnumerator_0;

		// Token: 0x04000A42 RID: 2626
		private static readonly IntPtr NativeMethodInfoPtr_DoorSlammed_Public_Void_0;

		// Token: 0x04000A43 RID: 2627
		private static readonly IntPtr NativeMethodInfoPtr_DoIt_Private_IEnumerator_0;

		// Token: 0x04000A44 RID: 2628
		private static readonly IntPtr NativeMethodInfoPtr_ZoomIn_Private_IEnumerator_0;

		// Token: 0x04000A45 RID: 2629
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x020002D8 RID: 728
		[ObfuscatedName("BoatIntro+<Letters>d__26")]
		public sealed class _Letters_d__26 : global::Il2CppSystem.Object
		{
			// Token: 0x06004D2C RID: 19756 RVA: 0x0011B9B8 File Offset: 0x00119BB8
			// Note: this type is marked as 'beforefieldinit'.
			static _Letters_d__26()
			{
				Il2CppClassPointerStore<BoatIntro._Letters_d__26>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<BoatIntro>.NativeClassPtr, "<Letters>d__26");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BoatIntro._Letters_d__26>.NativeClassPtr);
				BoatIntro._Letters_d__26.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BoatIntro._Letters_d__26>.NativeClassPtr, "<>1__state");
				BoatIntro._Letters_d__26.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BoatIntro._Letters_d__26>.NativeClassPtr, "<>2__current");
				BoatIntro._Letters_d__26.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BoatIntro._Letters_d__26>.NativeClassPtr, "<>4__this");
				BoatIntro._Letters_d__26.NativeFieldInfoPtr__i_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BoatIntro._Letters_d__26>.NativeClassPtr, "<i>5__2");
				BoatIntro._Letters_d__26.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BoatIntro._Letters_d__26>.NativeClassPtr, 100664717);
				BoatIntro._Letters_d__26.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BoatIntro._Letters_d__26>.NativeClassPtr, 100664718);
				BoatIntro._Letters_d__26.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BoatIntro._Letters_d__26>.NativeClassPtr, 100664719);
				BoatIntro._Letters_d__26.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BoatIntro._Letters_d__26>.NativeClassPtr, 100664720);
				BoatIntro._Letters_d__26.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BoatIntro._Letters_d__26>.NativeClassPtr, 100664721);
				BoatIntro._Letters_d__26.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BoatIntro._Letters_d__26>.NativeClassPtr, 100664722);
			}

			// Token: 0x06004D2D RID: 19757 RVA: 0x0011BAAC File Offset: 0x00119CAC
			[CallerCount(0)]
			public unsafe _Letters_d__26(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BoatIntro._Letters_d__26>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BoatIntro._Letters_d__26.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06004D2E RID: 19758 RVA: 0x0011BAF4 File Offset: 0x00119CF4
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BoatIntro._Letters_d__26.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06004D2F RID: 19759 RVA: 0x0011BB28 File Offset: 0x00119D28
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 48455, XrefRangeEnd = 48495, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BoatIntro._Letters_d__26.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17001C20 RID: 7200
			// (get) Token: 0x06004D30 RID: 19760 RVA: 0x0011BB64 File Offset: 0x00119D64
			public unsafe global::Il2CppSystem.Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BoatIntro._Letters_d__26.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x06004D31 RID: 19761 RVA: 0x0011BBA4 File Offset: 0x00119DA4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 48495, XrefRangeEnd = 48500, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BoatIntro._Letters_d__26.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17001C21 RID: 7201
			// (get) Token: 0x06004D32 RID: 19762 RVA: 0x0011BBD8 File Offset: 0x00119DD8
			public unsafe global::Il2CppSystem.Object System.Collections.IEnumerator.Current
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BoatIntro._Letters_d__26.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x06004D33 RID: 19763 RVA: 0x0002D636 File Offset: 0x0002B836
			public _Letters_d__26(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001C1C RID: 7196
			// (get) Token: 0x06004D34 RID: 19764 RVA: 0x0011BC18 File Offset: 0x00119E18
			// (set) Token: 0x06004D35 RID: 19765 RVA: 0x0002D63F File Offset: 0x0002B83F
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BoatIntro._Letters_d__26.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BoatIntro._Letters_d__26.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17001C1D RID: 7197
			// (get) Token: 0x06004D36 RID: 19766 RVA: 0x0011BC40 File Offset: 0x00119E40
			// (set) Token: 0x06004D37 RID: 19767 RVA: 0x0002D65A File Offset: 0x0002B85A
			public unsafe global::Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BoatIntro._Letters_d__26.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BoatIntro._Letters_d__26.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001C1E RID: 7198
			// (get) Token: 0x06004D38 RID: 19768 RVA: 0x0011BC70 File Offset: 0x00119E70
			// (set) Token: 0x06004D39 RID: 19769 RVA: 0x0002D679 File Offset: 0x0002B879
			public unsafe BoatIntro __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BoatIntro._Letters_d__26.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<BoatIntro>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BoatIntro._Letters_d__26.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001C1F RID: 7199
			// (get) Token: 0x06004D3A RID: 19770 RVA: 0x0011BCA0 File Offset: 0x00119EA0
			// (set) Token: 0x06004D3B RID: 19771 RVA: 0x0002D698 File Offset: 0x0002B898
			public unsafe int _i_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BoatIntro._Letters_d__26.NativeFieldInfoPtr__i_5__2);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BoatIntro._Letters_d__26.NativeFieldInfoPtr__i_5__2)) = value;
				}
			}

			// Token: 0x04003288 RID: 12936
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04003289 RID: 12937
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x0400328A RID: 12938
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x0400328B RID: 12939
			private static readonly IntPtr NativeFieldInfoPtr__i_5__2;

			// Token: 0x0400328C RID: 12940
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x0400328D RID: 12941
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400328E RID: 12942
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x0400328F RID: 12943
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04003290 RID: 12944
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04003291 RID: 12945
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}

		// Token: 0x020002D9 RID: 729
		[ObfuscatedName("BoatIntro+<DoIt>d__28")]
		public sealed class _DoIt_d__28 : global::Il2CppSystem.Object
		{
			// Token: 0x06004D3C RID: 19772 RVA: 0x0011BCC8 File Offset: 0x00119EC8
			// Note: this type is marked as 'beforefieldinit'.
			static _DoIt_d__28()
			{
				Il2CppClassPointerStore<BoatIntro._DoIt_d__28>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<BoatIntro>.NativeClassPtr, "<DoIt>d__28");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BoatIntro._DoIt_d__28>.NativeClassPtr);
				BoatIntro._DoIt_d__28.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BoatIntro._DoIt_d__28>.NativeClassPtr, "<>1__state");
				BoatIntro._DoIt_d__28.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BoatIntro._DoIt_d__28>.NativeClassPtr, "<>2__current");
				BoatIntro._DoIt_d__28.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BoatIntro._DoIt_d__28>.NativeClassPtr, "<>4__this");
				BoatIntro._DoIt_d__28.NativeFieldInfoPtr__i_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BoatIntro._DoIt_d__28>.NativeClassPtr, "<i>5__2");
				BoatIntro._DoIt_d__28.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BoatIntro._DoIt_d__28>.NativeClassPtr, 100664723);
				BoatIntro._DoIt_d__28.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BoatIntro._DoIt_d__28>.NativeClassPtr, 100664724);
				BoatIntro._DoIt_d__28.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BoatIntro._DoIt_d__28>.NativeClassPtr, 100664725);
				BoatIntro._DoIt_d__28.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BoatIntro._DoIt_d__28>.NativeClassPtr, 100664726);
				BoatIntro._DoIt_d__28.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BoatIntro._DoIt_d__28>.NativeClassPtr, 100664727);
				BoatIntro._DoIt_d__28.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BoatIntro._DoIt_d__28>.NativeClassPtr, 100664728);
			}

			// Token: 0x06004D3D RID: 19773 RVA: 0x0011BDBC File Offset: 0x00119FBC
			[CallerCount(0)]
			public unsafe _DoIt_d__28(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BoatIntro._DoIt_d__28>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BoatIntro._DoIt_d__28.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06004D3E RID: 19774 RVA: 0x0011BE04 File Offset: 0x0011A004
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BoatIntro._DoIt_d__28.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06004D3F RID: 19775 RVA: 0x0011BE38 File Offset: 0x0011A038
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 48500, XrefRangeEnd = 48536, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BoatIntro._DoIt_d__28.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17001C26 RID: 7206
			// (get) Token: 0x06004D40 RID: 19776 RVA: 0x0011BE74 File Offset: 0x0011A074
			public unsafe global::Il2CppSystem.Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BoatIntro._DoIt_d__28.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x06004D41 RID: 19777 RVA: 0x0011BEB4 File Offset: 0x0011A0B4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 48536, XrefRangeEnd = 48541, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BoatIntro._DoIt_d__28.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17001C27 RID: 7207
			// (get) Token: 0x06004D42 RID: 19778 RVA: 0x0011BEE8 File Offset: 0x0011A0E8
			public unsafe global::Il2CppSystem.Object System.Collections.IEnumerator.Current
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BoatIntro._DoIt_d__28.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x06004D43 RID: 19779 RVA: 0x0002D6B3 File Offset: 0x0002B8B3
			public _DoIt_d__28(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001C22 RID: 7202
			// (get) Token: 0x06004D44 RID: 19780 RVA: 0x0011BF28 File Offset: 0x0011A128
			// (set) Token: 0x06004D45 RID: 19781 RVA: 0x0002D6BC File Offset: 0x0002B8BC
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BoatIntro._DoIt_d__28.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BoatIntro._DoIt_d__28.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17001C23 RID: 7203
			// (get) Token: 0x06004D46 RID: 19782 RVA: 0x0011BF50 File Offset: 0x0011A150
			// (set) Token: 0x06004D47 RID: 19783 RVA: 0x0002D6D7 File Offset: 0x0002B8D7
			public unsafe global::Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BoatIntro._DoIt_d__28.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BoatIntro._DoIt_d__28.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001C24 RID: 7204
			// (get) Token: 0x06004D48 RID: 19784 RVA: 0x0011BF80 File Offset: 0x0011A180
			// (set) Token: 0x06004D49 RID: 19785 RVA: 0x0002D6F6 File Offset: 0x0002B8F6
			public unsafe BoatIntro __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BoatIntro._DoIt_d__28.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<BoatIntro>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BoatIntro._DoIt_d__28.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001C25 RID: 7205
			// (get) Token: 0x06004D4A RID: 19786 RVA: 0x0011BFB0 File Offset: 0x0011A1B0
			// (set) Token: 0x06004D4B RID: 19787 RVA: 0x0002D715 File Offset: 0x0002B915
			public unsafe int _i_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BoatIntro._DoIt_d__28.NativeFieldInfoPtr__i_5__2);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BoatIntro._DoIt_d__28.NativeFieldInfoPtr__i_5__2)) = value;
				}
			}

			// Token: 0x04003292 RID: 12946
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04003293 RID: 12947
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04003294 RID: 12948
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04003295 RID: 12949
			private static readonly IntPtr NativeFieldInfoPtr__i_5__2;

			// Token: 0x04003296 RID: 12950
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04003297 RID: 12951
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04003298 RID: 12952
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04003299 RID: 12953
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x0400329A RID: 12954
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400329B RID: 12955
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}

		// Token: 0x020002DA RID: 730
		[ObfuscatedName("BoatIntro+<ZoomIn>d__29")]
		public sealed class _ZoomIn_d__29 : global::Il2CppSystem.Object
		{
			// Token: 0x06004D4C RID: 19788 RVA: 0x0011BFD8 File Offset: 0x0011A1D8
			// Note: this type is marked as 'beforefieldinit'.
			static _ZoomIn_d__29()
			{
				Il2CppClassPointerStore<BoatIntro._ZoomIn_d__29>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<BoatIntro>.NativeClassPtr, "<ZoomIn>d__29");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BoatIntro._ZoomIn_d__29>.NativeClassPtr);
				BoatIntro._ZoomIn_d__29.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BoatIntro._ZoomIn_d__29>.NativeClassPtr, "<>1__state");
				BoatIntro._ZoomIn_d__29.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BoatIntro._ZoomIn_d__29>.NativeClassPtr, "<>2__current");
				BoatIntro._ZoomIn_d__29.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BoatIntro._ZoomIn_d__29>.NativeClassPtr, "<>4__this");
				BoatIntro._ZoomIn_d__29.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BoatIntro._ZoomIn_d__29>.NativeClassPtr, 100664729);
				BoatIntro._ZoomIn_d__29.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BoatIntro._ZoomIn_d__29>.NativeClassPtr, 100664730);
				BoatIntro._ZoomIn_d__29.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BoatIntro._ZoomIn_d__29>.NativeClassPtr, 100664731);
				BoatIntro._ZoomIn_d__29.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BoatIntro._ZoomIn_d__29>.NativeClassPtr, 100664732);
				BoatIntro._ZoomIn_d__29.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BoatIntro._ZoomIn_d__29>.NativeClassPtr, 100664733);
				BoatIntro._ZoomIn_d__29.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BoatIntro._ZoomIn_d__29>.NativeClassPtr, 100664734);
			}

			// Token: 0x06004D4D RID: 19789 RVA: 0x0011C0B8 File Offset: 0x0011A2B8
			[CallerCount(0)]
			public unsafe _ZoomIn_d__29(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BoatIntro._ZoomIn_d__29>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BoatIntro._ZoomIn_d__29.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06004D4E RID: 19790 RVA: 0x0011C100 File Offset: 0x0011A300
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BoatIntro._ZoomIn_d__29.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06004D4F RID: 19791 RVA: 0x0011C134 File Offset: 0x0011A334
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 48541, XrefRangeEnd = 48549, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BoatIntro._ZoomIn_d__29.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17001C2B RID: 7211
			// (get) Token: 0x06004D50 RID: 19792 RVA: 0x0011C170 File Offset: 0x0011A370
			public unsafe global::Il2CppSystem.Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BoatIntro._ZoomIn_d__29.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x06004D51 RID: 19793 RVA: 0x0011C1B0 File Offset: 0x0011A3B0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 48549, XrefRangeEnd = 48554, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BoatIntro._ZoomIn_d__29.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17001C2C RID: 7212
			// (get) Token: 0x06004D52 RID: 19794 RVA: 0x0011C1E4 File Offset: 0x0011A3E4
			public unsafe global::Il2CppSystem.Object System.Collections.IEnumerator.Current
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BoatIntro._ZoomIn_d__29.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x06004D53 RID: 19795 RVA: 0x0002D730 File Offset: 0x0002B930
			public _ZoomIn_d__29(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001C28 RID: 7208
			// (get) Token: 0x06004D54 RID: 19796 RVA: 0x0011C224 File Offset: 0x0011A424
			// (set) Token: 0x06004D55 RID: 19797 RVA: 0x0002D739 File Offset: 0x0002B939
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BoatIntro._ZoomIn_d__29.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BoatIntro._ZoomIn_d__29.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17001C29 RID: 7209
			// (get) Token: 0x06004D56 RID: 19798 RVA: 0x0011C24C File Offset: 0x0011A44C
			// (set) Token: 0x06004D57 RID: 19799 RVA: 0x0002D754 File Offset: 0x0002B954
			public unsafe global::Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BoatIntro._ZoomIn_d__29.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BoatIntro._ZoomIn_d__29.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001C2A RID: 7210
			// (get) Token: 0x06004D58 RID: 19800 RVA: 0x0011C27C File Offset: 0x0011A47C
			// (set) Token: 0x06004D59 RID: 19801 RVA: 0x0002D773 File Offset: 0x0002B973
			public unsafe BoatIntro __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BoatIntro._ZoomIn_d__29.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<BoatIntro>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BoatIntro._ZoomIn_d__29.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400329C RID: 12956
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x0400329D RID: 12957
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x0400329E RID: 12958
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x0400329F RID: 12959
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x040032A0 RID: 12960
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x040032A1 RID: 12961
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x040032A2 RID: 12962
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x040032A3 RID: 12963
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x040032A4 RID: 12964
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
