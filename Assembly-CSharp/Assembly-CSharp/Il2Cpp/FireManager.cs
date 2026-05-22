using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace Il2Cpp
{
	// Token: 0x020000D5 RID: 213
	public class FireManager : MonoBehaviour
	{
		// Token: 0x060018DC RID: 6364 RVA: 0x0007A258 File Offset: 0x00078458
		// Note: this type is marked as 'beforefieldinit'.
		static FireManager()
		{
			Il2CppClassPointerStore<FireManager>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "FireManager");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FireManager>.NativeClassPtr);
			FireManager.NativeFieldInfoPtr_triggers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FireManager>.NativeClassPtr, "triggers");
			FireManager.NativeFieldInfoPtr_partSys = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FireManager>.NativeClassPtr, "partSys");
			FireManager.NativeFieldInfoPtr_destroyAllThisShit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FireManager>.NativeClassPtr, "destroyAllThisShit");
			FireManager.NativeFieldInfoPtr_lifeTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FireManager>.NativeClassPtr, "lifeTime");
			FireManager.NativeFieldInfoPtr_lifeTimeSpread = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FireManager>.NativeClassPtr, "lifeTimeSpread");
			FireManager.NativeFieldInfoPtr_dumbTimer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FireManager>.NativeClassPtr, "dumbTimer");
			FireManager.NativeFieldInfoPtr_timer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FireManager>.NativeClassPtr, "timer");
			FireManager.NativeFieldInfoPtr_manageSomeFuckingAudio = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FireManager>.NativeClassPtr, "manageSomeFuckingAudio");
			FireManager.NativeFieldInfoPtr_fuck = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FireManager>.NativeClassPtr, "fuck");
			FireManager.NativeFieldInfoPtr_rb = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FireManager>.NativeClassPtr, "rb");
			FireManager.NativeFieldInfoPtr_partTrans = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FireManager>.NativeClassPtr, "partTrans");
			FireManager.NativeFieldInfoPtr_scorched = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FireManager>.NativeClassPtr, "scorched");
			FireManager.NativeFieldInfoPtr_fireCueInstance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FireManager>.NativeClassPtr, "fireCueInstance");
			FireManager.NativeFieldInfoPtr_hasTriggers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FireManager>.NativeClassPtr, "hasTriggers");
			FireManager.NativeFieldInfoPtr_hasRB = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FireManager>.NativeClassPtr, "hasRB");
			FireManager.NativeFieldInfoPtr_weWentKinematic = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FireManager>.NativeClassPtr, "weWentKinematic");
			FireManager.NativeFieldInfoPtr_dontTrigger = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FireManager>.NativeClassPtr, "dontTrigger");
			FireManager.NativeFieldInfoPtr_defCurve = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FireManager>.NativeClassPtr, "defCurve");
			FireManager.NativeFieldInfoPtr_startFlag = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FireManager>.NativeClassPtr, "startFlag");
			FireManager.NativeMethodInfoPtr_MyStart_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FireManager>.NativeClassPtr, 100665341);
			FireManager.NativeMethodInfoPtr_OnEnable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FireManager>.NativeClassPtr, 100665342);
			FireManager.NativeMethodInfoPtr_Update_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FireManager>.NativeClassPtr, 100665343);
			FireManager.NativeMethodInfoPtr_StopNow_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FireManager>.NativeClassPtr, 100665344);
			FireManager.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FireManager>.NativeClassPtr, 100665345);
		}

		// Token: 0x060018DD RID: 6365 RVA: 0x0007A468 File Offset: 0x00078668
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 58337, RefRangeEnd = 58338, XrefRangeStart = 58327, XrefRangeEnd = 58337, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void MyStart()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FireManager.NativeMethodInfoPtr_MyStart_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060018DE RID: 6366 RVA: 0x0007A49C File Offset: 0x0007869C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 58338, XrefRangeEnd = 58378, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnEnable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FireManager.NativeMethodInfoPtr_OnEnable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060018DF RID: 6367 RVA: 0x0007A4D0 File Offset: 0x000786D0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 58378, XrefRangeEnd = 58469, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FireManager.NativeMethodInfoPtr_Update_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060018E0 RID: 6368 RVA: 0x0007A504 File Offset: 0x00078704
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 58489, RefRangeEnd = 58490, XrefRangeStart = 58469, XrefRangeEnd = 58489, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void StopNow()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FireManager.NativeMethodInfoPtr_StopNow_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060018E1 RID: 6369 RVA: 0x0007A538 File Offset: 0x00078738
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe FireManager()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FireManager>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FireManager.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060018E2 RID: 6370 RVA: 0x00011C98 File Offset: 0x0000FE98
		public FireManager(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170008F1 RID: 2289
		// (get) Token: 0x060018E3 RID: 6371 RVA: 0x0007A574 File Offset: 0x00078774
		// (set) Token: 0x060018E4 RID: 6372 RVA: 0x00011CA1 File Offset: 0x0000FEA1
		public unsafe Il2CppReferenceArray<GameObject> triggers
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FireManager.NativeFieldInfoPtr_triggers);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<GameObject>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FireManager.NativeFieldInfoPtr_triggers), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170008F2 RID: 2290
		// (get) Token: 0x060018E5 RID: 6373 RVA: 0x0007A5A4 File Offset: 0x000787A4
		// (set) Token: 0x060018E6 RID: 6374 RVA: 0x00011CC0 File Offset: 0x0000FEC0
		public unsafe ParticleSystem partSys
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FireManager.NativeFieldInfoPtr_partSys);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ParticleSystem>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FireManager.NativeFieldInfoPtr_partSys), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170008F3 RID: 2291
		// (get) Token: 0x060018E7 RID: 6375 RVA: 0x0007A5D4 File Offset: 0x000787D4
		// (set) Token: 0x060018E8 RID: 6376 RVA: 0x00011CDF File Offset: 0x0000FEDF
		public unsafe bool destroyAllThisShit
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FireManager.NativeFieldInfoPtr_destroyAllThisShit);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FireManager.NativeFieldInfoPtr_destroyAllThisShit)) = value;
			}
		}

		// Token: 0x170008F4 RID: 2292
		// (get) Token: 0x060018E9 RID: 6377 RVA: 0x0007A5FC File Offset: 0x000787FC
		// (set) Token: 0x060018EA RID: 6378 RVA: 0x00011CFA File Offset: 0x0000FEFA
		public unsafe int lifeTime
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FireManager.NativeFieldInfoPtr_lifeTime);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FireManager.NativeFieldInfoPtr_lifeTime)) = value;
			}
		}

		// Token: 0x170008F5 RID: 2293
		// (get) Token: 0x060018EB RID: 6379 RVA: 0x0007A624 File Offset: 0x00078824
		// (set) Token: 0x060018EC RID: 6380 RVA: 0x00011D15 File Offset: 0x0000FF15
		public unsafe int lifeTimeSpread
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FireManager.NativeFieldInfoPtr_lifeTimeSpread);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FireManager.NativeFieldInfoPtr_lifeTimeSpread)) = value;
			}
		}

		// Token: 0x170008F6 RID: 2294
		// (get) Token: 0x060018ED RID: 6381 RVA: 0x0007A64C File Offset: 0x0007884C
		// (set) Token: 0x060018EE RID: 6382 RVA: 0x00011D30 File Offset: 0x0000FF30
		public unsafe float dumbTimer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FireManager.NativeFieldInfoPtr_dumbTimer);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FireManager.NativeFieldInfoPtr_dumbTimer)) = value;
			}
		}

		// Token: 0x170008F7 RID: 2295
		// (get) Token: 0x060018EF RID: 6383 RVA: 0x0007A674 File Offset: 0x00078874
		// (set) Token: 0x060018F0 RID: 6384 RVA: 0x00011D4B File Offset: 0x0000FF4B
		public unsafe float timer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FireManager.NativeFieldInfoPtr_timer);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FireManager.NativeFieldInfoPtr_timer)) = value;
			}
		}

		// Token: 0x170008F8 RID: 2296
		// (get) Token: 0x060018F1 RID: 6385 RVA: 0x0007A69C File Offset: 0x0007889C
		// (set) Token: 0x060018F2 RID: 6386 RVA: 0x00011D66 File Offset: 0x0000FF66
		public unsafe bool manageSomeFuckingAudio
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FireManager.NativeFieldInfoPtr_manageSomeFuckingAudio);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FireManager.NativeFieldInfoPtr_manageSomeFuckingAudio)) = value;
			}
		}

		// Token: 0x170008F9 RID: 2297
		// (get) Token: 0x060018F3 RID: 6387 RVA: 0x0007A6C4 File Offset: 0x000788C4
		// (set) Token: 0x060018F4 RID: 6388 RVA: 0x00011D81 File Offset: 0x0000FF81
		public ParticleSystem.MinMaxCurve fuck
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FireManager.NativeFieldInfoPtr_fuck);
				return new ParticleSystem.MinMaxCurve(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ParticleSystem.MinMaxCurve>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FireManager.NativeFieldInfoPtr_fuck), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ParticleSystem.MinMaxCurve>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x170008FA RID: 2298
		// (get) Token: 0x060018F5 RID: 6389 RVA: 0x0007A6F4 File Offset: 0x000788F4
		// (set) Token: 0x060018F6 RID: 6390 RVA: 0x00011DAF File Offset: 0x0000FFAF
		public unsafe Rigidbody2D rb
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FireManager.NativeFieldInfoPtr_rb);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Rigidbody2D>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FireManager.NativeFieldInfoPtr_rb), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170008FB RID: 2299
		// (get) Token: 0x060018F7 RID: 6391 RVA: 0x0007A724 File Offset: 0x00078924
		// (set) Token: 0x060018F8 RID: 6392 RVA: 0x00011DCE File Offset: 0x0000FFCE
		public unsafe Transform partTrans
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FireManager.NativeFieldInfoPtr_partTrans);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FireManager.NativeFieldInfoPtr_partTrans), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170008FC RID: 2300
		// (get) Token: 0x060018F9 RID: 6393 RVA: 0x0007A754 File Offset: 0x00078954
		// (set) Token: 0x060018FA RID: 6394 RVA: 0x00011DED File Offset: 0x0000FFED
		public unsafe bool scorched
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FireManager.NativeFieldInfoPtr_scorched);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FireManager.NativeFieldInfoPtr_scorched)) = value;
			}
		}

		// Token: 0x170008FD RID: 2301
		// (get) Token: 0x060018FB RID: 6395 RVA: 0x0007A77C File Offset: 0x0007897C
		// (set) Token: 0x060018FC RID: 6396 RVA: 0x00011E08 File Offset: 0x00010008
		public SECTR_AudioCueInstance fireCueInstance
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FireManager.NativeFieldInfoPtr_fireCueInstance);
				return new SECTR_AudioCueInstance(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<SECTR_AudioCueInstance>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FireManager.NativeFieldInfoPtr_fireCueInstance), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<SECTR_AudioCueInstance>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x170008FE RID: 2302
		// (get) Token: 0x060018FD RID: 6397 RVA: 0x0007A7AC File Offset: 0x000789AC
		// (set) Token: 0x060018FE RID: 6398 RVA: 0x00011E36 File Offset: 0x00010036
		public unsafe bool hasTriggers
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FireManager.NativeFieldInfoPtr_hasTriggers);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FireManager.NativeFieldInfoPtr_hasTriggers)) = value;
			}
		}

		// Token: 0x170008FF RID: 2303
		// (get) Token: 0x060018FF RID: 6399 RVA: 0x0007A7D4 File Offset: 0x000789D4
		// (set) Token: 0x06001900 RID: 6400 RVA: 0x00011E51 File Offset: 0x00010051
		public unsafe bool hasRB
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FireManager.NativeFieldInfoPtr_hasRB);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FireManager.NativeFieldInfoPtr_hasRB)) = value;
			}
		}

		// Token: 0x17000900 RID: 2304
		// (get) Token: 0x06001901 RID: 6401 RVA: 0x0007A7FC File Offset: 0x000789FC
		// (set) Token: 0x06001902 RID: 6402 RVA: 0x00011E6C File Offset: 0x0001006C
		public unsafe bool weWentKinematic
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FireManager.NativeFieldInfoPtr_weWentKinematic);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FireManager.NativeFieldInfoPtr_weWentKinematic)) = value;
			}
		}

		// Token: 0x17000901 RID: 2305
		// (get) Token: 0x06001903 RID: 6403 RVA: 0x0007A824 File Offset: 0x00078A24
		// (set) Token: 0x06001904 RID: 6404 RVA: 0x00011E87 File Offset: 0x00010087
		public unsafe bool dontTrigger
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FireManager.NativeFieldInfoPtr_dontTrigger);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FireManager.NativeFieldInfoPtr_dontTrigger)) = value;
			}
		}

		// Token: 0x17000902 RID: 2306
		// (get) Token: 0x06001905 RID: 6405 RVA: 0x0007A84C File Offset: 0x00078A4C
		// (set) Token: 0x06001906 RID: 6406 RVA: 0x00011EA2 File Offset: 0x000100A2
		public ParticleSystem.MinMaxCurve defCurve
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FireManager.NativeFieldInfoPtr_defCurve);
				return new ParticleSystem.MinMaxCurve(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ParticleSystem.MinMaxCurve>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FireManager.NativeFieldInfoPtr_defCurve), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ParticleSystem.MinMaxCurve>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x17000903 RID: 2307
		// (get) Token: 0x06001907 RID: 6407 RVA: 0x0007A87C File Offset: 0x00078A7C
		// (set) Token: 0x06001908 RID: 6408 RVA: 0x00011ED0 File Offset: 0x000100D0
		public unsafe bool startFlag
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FireManager.NativeFieldInfoPtr_startFlag);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FireManager.NativeFieldInfoPtr_startFlag)) = value;
			}
		}

		// Token: 0x04000ECC RID: 3788
		private static readonly IntPtr NativeFieldInfoPtr_triggers;

		// Token: 0x04000ECD RID: 3789
		private static readonly IntPtr NativeFieldInfoPtr_partSys;

		// Token: 0x04000ECE RID: 3790
		private static readonly IntPtr NativeFieldInfoPtr_destroyAllThisShit;

		// Token: 0x04000ECF RID: 3791
		private static readonly IntPtr NativeFieldInfoPtr_lifeTime;

		// Token: 0x04000ED0 RID: 3792
		private static readonly IntPtr NativeFieldInfoPtr_lifeTimeSpread;

		// Token: 0x04000ED1 RID: 3793
		private static readonly IntPtr NativeFieldInfoPtr_dumbTimer;

		// Token: 0x04000ED2 RID: 3794
		private static readonly IntPtr NativeFieldInfoPtr_timer;

		// Token: 0x04000ED3 RID: 3795
		private static readonly IntPtr NativeFieldInfoPtr_manageSomeFuckingAudio;

		// Token: 0x04000ED4 RID: 3796
		private static readonly IntPtr NativeFieldInfoPtr_fuck;

		// Token: 0x04000ED5 RID: 3797
		private static readonly IntPtr NativeFieldInfoPtr_rb;

		// Token: 0x04000ED6 RID: 3798
		private static readonly IntPtr NativeFieldInfoPtr_partTrans;

		// Token: 0x04000ED7 RID: 3799
		private static readonly IntPtr NativeFieldInfoPtr_scorched;

		// Token: 0x04000ED8 RID: 3800
		private static readonly IntPtr NativeFieldInfoPtr_fireCueInstance;

		// Token: 0x04000ED9 RID: 3801
		private static readonly IntPtr NativeFieldInfoPtr_hasTriggers;

		// Token: 0x04000EDA RID: 3802
		private static readonly IntPtr NativeFieldInfoPtr_hasRB;

		// Token: 0x04000EDB RID: 3803
		private static readonly IntPtr NativeFieldInfoPtr_weWentKinematic;

		// Token: 0x04000EDC RID: 3804
		private static readonly IntPtr NativeFieldInfoPtr_dontTrigger;

		// Token: 0x04000EDD RID: 3805
		private static readonly IntPtr NativeFieldInfoPtr_defCurve;

		// Token: 0x04000EDE RID: 3806
		private static readonly IntPtr NativeFieldInfoPtr_startFlag;

		// Token: 0x04000EDF RID: 3807
		private static readonly IntPtr NativeMethodInfoPtr_MyStart_Public_Void_0;

		// Token: 0x04000EE0 RID: 3808
		private static readonly IntPtr NativeMethodInfoPtr_OnEnable_Private_Void_0;

		// Token: 0x04000EE1 RID: 3809
		private static readonly IntPtr NativeMethodInfoPtr_Update_Public_Void_0;

		// Token: 0x04000EE2 RID: 3810
		private static readonly IntPtr NativeMethodInfoPtr_StopNow_Public_Void_0;

		// Token: 0x04000EE3 RID: 3811
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
