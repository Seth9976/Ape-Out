using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace Il2Cpp
{
	// Token: 0x0200011A RID: 282
	public class Paw : Object
	{
		// Token: 0x060021BA RID: 8634 RVA: 0x00092504 File Offset: 0x00090704
		// Note: this type is marked as 'beforefieldinit'.
		static Paw()
		{
			Il2CppClassPointerStore<Paw>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "Paw");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Paw>.NativeClassPtr);
			Paw.NativeFieldInfoPtr_liftTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Paw>.NativeClassPtr, "liftTime");
			Paw.NativeFieldInfoPtr_placeTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Paw>.NativeClassPtr, "placeTime");
			Paw.NativeFieldInfoPtr_walkLiftTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Paw>.NativeClassPtr, "walkLiftTime");
			Paw.NativeFieldInfoPtr_walkPlaceTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Paw>.NativeClassPtr, "walkPlaceTime");
			Paw.NativeFieldInfoPtr_runLiftTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Paw>.NativeClassPtr, "runLiftTime");
			Paw.NativeFieldInfoPtr_runPlaceTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Paw>.NativeClassPtr, "runPlaceTime");
			Paw.NativeFieldInfoPtr_pos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Paw>.NativeClassPtr, "pos");
			Paw.NativeFieldInfoPtr_paw = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Paw>.NativeClassPtr, "paw");
			Paw.NativeFieldInfoPtr_liftDur = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Paw>.NativeClassPtr, "liftDur");
			Paw.NativeFieldInfoPtr_rb = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Paw>.NativeClassPtr, "rb");
			Paw.NativeFieldInfoPtr_timeLeft = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Paw>.NativeClassPtr, "timeLeft");
			Paw.NativeFieldInfoPtr_lifted = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Paw>.NativeClassPtr, "lifted");
			Paw.NativeFieldInfoPtr_liftDist = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Paw>.NativeClassPtr, "liftDist");
			Paw.NativeFieldInfoPtr_liftOverride = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Paw>.NativeClassPtr, "liftOverride");
			Paw.NativeFieldInfoPtr_overrideTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Paw>.NativeClassPtr, "overrideTime");
			Paw.NativeFieldInfoPtr_tim = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Paw>.NativeClassPtr, "tim");
			Paw.NativeFieldInfoPtr_maxDist = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Paw>.NativeClassPtr, "maxDist");
			Paw.NativeFieldInfoPtr_lerpPlus = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Paw>.NativeClassPtr, "lerpPlus");
			Paw.NativeFieldInfoPtr_curSpd = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Paw>.NativeClassPtr, "curSpd");
			Paw.NativeFieldInfoPtr_curDest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Paw>.NativeClassPtr, "curDest");
			Paw.NativeFieldInfoPtr_desPlaceTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Paw>.NativeClassPtr, "desPlaceTime");
			Paw.NativeFieldInfoPtr_desLiftTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Paw>.NativeClassPtr, "desLiftTime");
			Paw.NativeFieldInfoPtr_legs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Paw>.NativeClassPtr, "legs");
			Paw.NativeFieldInfoPtr_apeDuster = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Paw>.NativeClassPtr, "apeDuster");
			Paw.NativeFieldInfoPtr_dust = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Paw>.NativeClassPtr, "dust");
			Paw.NativeFieldInfoPtr_dustMain = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Paw>.NativeClassPtr, "dustMain");
			Paw.NativeFieldInfoPtr_prince = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Paw>.NativeClassPtr, "prince");
			Paw.NativeFieldInfoPtr_running = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Paw>.NativeClassPtr, "running");
			Paw.NativeFieldInfoPtr_bloodiness = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Paw>.NativeClassPtr, "bloodiness");
			Paw.NativeFieldInfoPtr_guardType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Paw>.NativeClassPtr, "guardType");
			Paw.NativeFieldInfoPtr_WeaponType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Paw>.NativeClassPtr, "WeaponType");
			Paw.NativeMethodInfoPtr__ctor_Public_Void_GameObject_Single_Single_Single_Single_Legs_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Paw>.NativeClassPtr, 100665951);
			Paw.NativeMethodInfoPtr_Place_Public_Void_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Paw>.NativeClassPtr, 100665952);
			Paw.NativeMethodInfoPtr_Update_Public_Void_Single_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Paw>.NativeClassPtr, 100665953);
			Paw.NativeMethodInfoPtr_Lerp_Public_Single_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Paw>.NativeClassPtr, 100665954);
			Paw.NativeMethodInfoPtr_Oned_Public_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Paw>.NativeClassPtr, 100665955);
			Paw.NativeMethodInfoPtr_LiftOverride_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Paw>.NativeClassPtr, 100665956);
			Paw.NativeMethodInfoPtr_Lifted_Public_Boolean_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Paw>.NativeClassPtr, 100665957);
			Paw.NativeMethodInfoPtr_ShortestDistPlus_Public_Boolean_Single_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Paw>.NativeClassPtr, 100665958);
			Paw.NativeMethodInfoPtr_GetDelt_Public_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Paw>.NativeClassPtr, 100665959);
			Paw.NativeMethodInfoPtr_GetDur_Public_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Paw>.NativeClassPtr, 100665960);
			Paw.NativeMethodInfoPtr_IsBetween_Public_Boolean_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Paw>.NativeClassPtr, 100665961);
			Paw.NativeMethodInfoPtr_RemainingStridePercent_Public_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Paw>.NativeClassPtr, 100665962);
		}

		// Token: 0x060021BB RID: 8635 RVA: 0x00092890 File Offset: 0x00090A90
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 69054, RefRangeEnd = 69056, XrefRangeStart = 68954, XrefRangeEnd = 69054, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Paw(GameObject obj, float _liftTime, float _placeTime, float rlTime, float rpTime, Legs lgs, bool apeDust)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Paw>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref _liftTime;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref _placeTime;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rlTime;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rpTime;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(lgs);
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref apeDust;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Paw.NativeMethodInfoPtr__ctor_Public_Void_GameObject_Single_Single_Single_Single_Legs_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060021BC RID: 8636 RVA: 0x00092934 File Offset: 0x00090B34
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 69072, RefRangeEnd = 69076, XrefRangeStart = 69056, XrefRangeEnd = 69072, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Place(Vector2 jPos)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref jPos;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Paw.NativeMethodInfoPtr_Place_Public_Void_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060021BD RID: 8637 RVA: 0x00092974 File Offset: 0x00090B74
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 69088, RefRangeEnd = 69091, XrefRangeStart = 69076, XrefRangeEnd = 69088, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update(float time, bool isRunning)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref time;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isRunning;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Paw.NativeMethodInfoPtr_Update_Public_Void_Single_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060021BE RID: 8638 RVA: 0x000929C0 File Offset: 0x00090BC0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 69092, RefRangeEnd = 69094, XrefRangeStart = 69091, XrefRangeEnd = 69092, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe float Lerp(float a, float b, float rate)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref a;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref b;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rate;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Paw.NativeMethodInfoPtr_Lerp_Public_Single_Single_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060021BF RID: 8639 RVA: 0x00092A28 File Offset: 0x00090C28
		[CallerCount(0)]
		public unsafe float Oned(float a)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref a;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Paw.NativeMethodInfoPtr_Oned_Public_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060021C0 RID: 8640 RVA: 0x00092A74 File Offset: 0x00090C74
		[CallerCount(0)]
		public unsafe void LiftOverride()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Paw.NativeMethodInfoPtr_LiftOverride_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060021C1 RID: 8641 RVA: 0x00092AA8 File Offset: 0x00090CA8
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 69145, RefRangeEnd = 69148, XrefRangeStart = 69094, XrefRangeEnd = 69145, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool Lifted(float spd)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref spd;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Paw.NativeMethodInfoPtr_Lifted_Public_Boolean_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060021C2 RID: 8642 RVA: 0x00092AF4 File Offset: 0x00090CF4
		[CallerCount(0)]
		public unsafe bool ShortestDistPlus(float a, float b, float c, float d)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref a;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref b;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref c;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref d;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Paw.NativeMethodInfoPtr_ShortestDistPlus_Public_Boolean_Single_Single_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060021C3 RID: 8643 RVA: 0x00092B68 File Offset: 0x00090D68
		[CallerCount(0)]
		public unsafe float GetDelt(float a, float b)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref a;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref b;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Paw.NativeMethodInfoPtr_GetDelt_Public_Single_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060021C4 RID: 8644 RVA: 0x00092BC0 File Offset: 0x00090DC0
		[CallerCount(0)]
		public unsafe float GetDur(float lTime, float pTime)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lTime;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref pTime;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Paw.NativeMethodInfoPtr_GetDur_Public_Single_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060021C5 RID: 8645 RVA: 0x00092C18 File Offset: 0x00090E18
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 69148, RefRangeEnd = 69152, XrefRangeStart = 69148, XrefRangeEnd = 69148, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsBetween(float a, float b, float c)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref a;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref b;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref c;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Paw.NativeMethodInfoPtr_IsBetween_Public_Boolean_Single_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060021C6 RID: 8646 RVA: 0x00092C80 File Offset: 0x00090E80
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 69152, XrefRangeEnd = 69153, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe float RemainingStridePercent()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Paw.NativeMethodInfoPtr_RemainingStridePercent_Public_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060021C7 RID: 8647 RVA: 0x000179CF File Offset: 0x00015BCF
		public Paw(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000C1E RID: 3102
		// (get) Token: 0x060021C8 RID: 8648 RVA: 0x00092CBC File Offset: 0x00090EBC
		// (set) Token: 0x060021C9 RID: 8649 RVA: 0x000179D8 File Offset: 0x00015BD8
		public unsafe float liftTime
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Paw.NativeFieldInfoPtr_liftTime);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Paw.NativeFieldInfoPtr_liftTime)) = value;
			}
		}

		// Token: 0x17000C1F RID: 3103
		// (get) Token: 0x060021CA RID: 8650 RVA: 0x00092CE4 File Offset: 0x00090EE4
		// (set) Token: 0x060021CB RID: 8651 RVA: 0x000179F3 File Offset: 0x00015BF3
		public unsafe float placeTime
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Paw.NativeFieldInfoPtr_placeTime);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Paw.NativeFieldInfoPtr_placeTime)) = value;
			}
		}

		// Token: 0x17000C20 RID: 3104
		// (get) Token: 0x060021CC RID: 8652 RVA: 0x00092D0C File Offset: 0x00090F0C
		// (set) Token: 0x060021CD RID: 8653 RVA: 0x00017A0E File Offset: 0x00015C0E
		public unsafe float walkLiftTime
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Paw.NativeFieldInfoPtr_walkLiftTime);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Paw.NativeFieldInfoPtr_walkLiftTime)) = value;
			}
		}

		// Token: 0x17000C21 RID: 3105
		// (get) Token: 0x060021CE RID: 8654 RVA: 0x00092D34 File Offset: 0x00090F34
		// (set) Token: 0x060021CF RID: 8655 RVA: 0x00017A29 File Offset: 0x00015C29
		public unsafe float walkPlaceTime
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Paw.NativeFieldInfoPtr_walkPlaceTime);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Paw.NativeFieldInfoPtr_walkPlaceTime)) = value;
			}
		}

		// Token: 0x17000C22 RID: 3106
		// (get) Token: 0x060021D0 RID: 8656 RVA: 0x00092D5C File Offset: 0x00090F5C
		// (set) Token: 0x060021D1 RID: 8657 RVA: 0x00017A44 File Offset: 0x00015C44
		public unsafe float runLiftTime
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Paw.NativeFieldInfoPtr_runLiftTime);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Paw.NativeFieldInfoPtr_runLiftTime)) = value;
			}
		}

		// Token: 0x17000C23 RID: 3107
		// (get) Token: 0x060021D2 RID: 8658 RVA: 0x00092D84 File Offset: 0x00090F84
		// (set) Token: 0x060021D3 RID: 8659 RVA: 0x00017A5F File Offset: 0x00015C5F
		public unsafe float runPlaceTime
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Paw.NativeFieldInfoPtr_runPlaceTime);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Paw.NativeFieldInfoPtr_runPlaceTime)) = value;
			}
		}

		// Token: 0x17000C24 RID: 3108
		// (get) Token: 0x060021D4 RID: 8660 RVA: 0x00092DAC File Offset: 0x00090FAC
		// (set) Token: 0x060021D5 RID: 8661 RVA: 0x00017A7A File Offset: 0x00015C7A
		public unsafe Vector2 pos
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Paw.NativeFieldInfoPtr_pos);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Paw.NativeFieldInfoPtr_pos)) = value;
			}
		}

		// Token: 0x17000C25 RID: 3109
		// (get) Token: 0x060021D6 RID: 8662 RVA: 0x00092DD4 File Offset: 0x00090FD4
		// (set) Token: 0x060021D7 RID: 8663 RVA: 0x00017A95 File Offset: 0x00015C95
		public unsafe GameObject paw
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Paw.NativeFieldInfoPtr_paw);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Paw.NativeFieldInfoPtr_paw), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000C26 RID: 3110
		// (get) Token: 0x060021D8 RID: 8664 RVA: 0x00092E04 File Offset: 0x00091004
		// (set) Token: 0x060021D9 RID: 8665 RVA: 0x00017AB4 File Offset: 0x00015CB4
		public unsafe float liftDur
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Paw.NativeFieldInfoPtr_liftDur);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Paw.NativeFieldInfoPtr_liftDur)) = value;
			}
		}

		// Token: 0x17000C27 RID: 3111
		// (get) Token: 0x060021DA RID: 8666 RVA: 0x00092E2C File Offset: 0x0009102C
		// (set) Token: 0x060021DB RID: 8667 RVA: 0x00017ACF File Offset: 0x00015CCF
		public unsafe Rigidbody2D rb
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Paw.NativeFieldInfoPtr_rb);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Rigidbody2D>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Paw.NativeFieldInfoPtr_rb), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000C28 RID: 3112
		// (get) Token: 0x060021DC RID: 8668 RVA: 0x00092E5C File Offset: 0x0009105C
		// (set) Token: 0x060021DD RID: 8669 RVA: 0x00017AEE File Offset: 0x00015CEE
		public unsafe float timeLeft
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Paw.NativeFieldInfoPtr_timeLeft);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Paw.NativeFieldInfoPtr_timeLeft)) = value;
			}
		}

		// Token: 0x17000C29 RID: 3113
		// (get) Token: 0x060021DE RID: 8670 RVA: 0x00092E84 File Offset: 0x00091084
		// (set) Token: 0x060021DF RID: 8671 RVA: 0x00017B09 File Offset: 0x00015D09
		public unsafe bool lifted
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Paw.NativeFieldInfoPtr_lifted);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Paw.NativeFieldInfoPtr_lifted)) = value;
			}
		}

		// Token: 0x17000C2A RID: 3114
		// (get) Token: 0x060021E0 RID: 8672 RVA: 0x00092EAC File Offset: 0x000910AC
		// (set) Token: 0x060021E1 RID: 8673 RVA: 0x00017B24 File Offset: 0x00015D24
		public unsafe float liftDist
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Paw.NativeFieldInfoPtr_liftDist);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Paw.NativeFieldInfoPtr_liftDist)) = value;
			}
		}

		// Token: 0x17000C2B RID: 3115
		// (get) Token: 0x060021E2 RID: 8674 RVA: 0x00092ED4 File Offset: 0x000910D4
		// (set) Token: 0x060021E3 RID: 8675 RVA: 0x00017B3F File Offset: 0x00015D3F
		public unsafe bool liftOverride
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Paw.NativeFieldInfoPtr_liftOverride);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Paw.NativeFieldInfoPtr_liftOverride)) = value;
			}
		}

		// Token: 0x17000C2C RID: 3116
		// (get) Token: 0x060021E4 RID: 8676 RVA: 0x00092EFC File Offset: 0x000910FC
		// (set) Token: 0x060021E5 RID: 8677 RVA: 0x00017B5A File Offset: 0x00015D5A
		public unsafe float overrideTime
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Paw.NativeFieldInfoPtr_overrideTime);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Paw.NativeFieldInfoPtr_overrideTime)) = value;
			}
		}

		// Token: 0x17000C2D RID: 3117
		// (get) Token: 0x060021E6 RID: 8678 RVA: 0x00092F24 File Offset: 0x00091124
		// (set) Token: 0x060021E7 RID: 8679 RVA: 0x00017B75 File Offset: 0x00015D75
		public unsafe float tim
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Paw.NativeFieldInfoPtr_tim);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Paw.NativeFieldInfoPtr_tim)) = value;
			}
		}

		// Token: 0x17000C2E RID: 3118
		// (get) Token: 0x060021E8 RID: 8680 RVA: 0x00092F4C File Offset: 0x0009114C
		// (set) Token: 0x060021E9 RID: 8681 RVA: 0x00017B90 File Offset: 0x00015D90
		public unsafe float maxDist
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Paw.NativeFieldInfoPtr_maxDist);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Paw.NativeFieldInfoPtr_maxDist)) = value;
			}
		}

		// Token: 0x17000C2F RID: 3119
		// (get) Token: 0x060021EA RID: 8682 RVA: 0x00092F74 File Offset: 0x00091174
		// (set) Token: 0x060021EB RID: 8683 RVA: 0x00017BAB File Offset: 0x00015DAB
		public unsafe bool lerpPlus
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Paw.NativeFieldInfoPtr_lerpPlus);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Paw.NativeFieldInfoPtr_lerpPlus)) = value;
			}
		}

		// Token: 0x17000C30 RID: 3120
		// (get) Token: 0x060021EC RID: 8684 RVA: 0x00092F9C File Offset: 0x0009119C
		// (set) Token: 0x060021ED RID: 8685 RVA: 0x00017BC6 File Offset: 0x00015DC6
		public unsafe float curSpd
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Paw.NativeFieldInfoPtr_curSpd);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Paw.NativeFieldInfoPtr_curSpd)) = value;
			}
		}

		// Token: 0x17000C31 RID: 3121
		// (get) Token: 0x060021EE RID: 8686 RVA: 0x00092FC4 File Offset: 0x000911C4
		// (set) Token: 0x060021EF RID: 8687 RVA: 0x00017BE1 File Offset: 0x00015DE1
		public unsafe Vector2 curDest
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Paw.NativeFieldInfoPtr_curDest);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Paw.NativeFieldInfoPtr_curDest)) = value;
			}
		}

		// Token: 0x17000C32 RID: 3122
		// (get) Token: 0x060021F0 RID: 8688 RVA: 0x00092FEC File Offset: 0x000911EC
		// (set) Token: 0x060021F1 RID: 8689 RVA: 0x00017BFC File Offset: 0x00015DFC
		public unsafe float desPlaceTime
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Paw.NativeFieldInfoPtr_desPlaceTime);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Paw.NativeFieldInfoPtr_desPlaceTime)) = value;
			}
		}

		// Token: 0x17000C33 RID: 3123
		// (get) Token: 0x060021F2 RID: 8690 RVA: 0x00093014 File Offset: 0x00091214
		// (set) Token: 0x060021F3 RID: 8691 RVA: 0x00017C17 File Offset: 0x00015E17
		public unsafe float desLiftTime
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Paw.NativeFieldInfoPtr_desLiftTime);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Paw.NativeFieldInfoPtr_desLiftTime)) = value;
			}
		}

		// Token: 0x17000C34 RID: 3124
		// (get) Token: 0x060021F4 RID: 8692 RVA: 0x0009303C File Offset: 0x0009123C
		// (set) Token: 0x060021F5 RID: 8693 RVA: 0x00017C32 File Offset: 0x00015E32
		public unsafe Legs legs
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Paw.NativeFieldInfoPtr_legs);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Legs>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Paw.NativeFieldInfoPtr_legs), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000C35 RID: 3125
		// (get) Token: 0x060021F6 RID: 8694 RVA: 0x0009306C File Offset: 0x0009126C
		// (set) Token: 0x060021F7 RID: 8695 RVA: 0x00017C51 File Offset: 0x00015E51
		public unsafe bool apeDuster
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Paw.NativeFieldInfoPtr_apeDuster);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Paw.NativeFieldInfoPtr_apeDuster)) = value;
			}
		}

		// Token: 0x17000C36 RID: 3126
		// (get) Token: 0x060021F8 RID: 8696 RVA: 0x00093094 File Offset: 0x00091294
		// (set) Token: 0x060021F9 RID: 8697 RVA: 0x00017C6C File Offset: 0x00015E6C
		public unsafe ParticleSystem dust
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Paw.NativeFieldInfoPtr_dust);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ParticleSystem>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Paw.NativeFieldInfoPtr_dust), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000C37 RID: 3127
		// (get) Token: 0x060021FA RID: 8698 RVA: 0x000930C4 File Offset: 0x000912C4
		// (set) Token: 0x060021FB RID: 8699 RVA: 0x00017C8B File Offset: 0x00015E8B
		public ParticleSystem.MainModule dustMain
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Paw.NativeFieldInfoPtr_dustMain);
				return new ParticleSystem.MainModule(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ParticleSystem.MainModule>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Paw.NativeFieldInfoPtr_dustMain), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ParticleSystem.MainModule>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x17000C38 RID: 3128
		// (get) Token: 0x060021FC RID: 8700 RVA: 0x000930F4 File Offset: 0x000912F4
		// (set) Token: 0x060021FD RID: 8701 RVA: 0x00017CB9 File Offset: 0x00015EB9
		public unsafe FootprintEmitter prince
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Paw.NativeFieldInfoPtr_prince);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<FootprintEmitter>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Paw.NativeFieldInfoPtr_prince), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000C39 RID: 3129
		// (get) Token: 0x060021FE RID: 8702 RVA: 0x00093124 File Offset: 0x00091324
		// (set) Token: 0x060021FF RID: 8703 RVA: 0x00017CD8 File Offset: 0x00015ED8
		public unsafe bool running
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Paw.NativeFieldInfoPtr_running);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Paw.NativeFieldInfoPtr_running)) = value;
			}
		}

		// Token: 0x17000C3A RID: 3130
		// (get) Token: 0x06002200 RID: 8704 RVA: 0x0009314C File Offset: 0x0009134C
		// (set) Token: 0x06002201 RID: 8705 RVA: 0x00017CF3 File Offset: 0x00015EF3
		public unsafe float bloodiness
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Paw.NativeFieldInfoPtr_bloodiness);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Paw.NativeFieldInfoPtr_bloodiness)) = value;
			}
		}

		// Token: 0x17000C3B RID: 3131
		// (get) Token: 0x06002202 RID: 8706 RVA: 0x00093174 File Offset: 0x00091374
		// (set) Token: 0x06002203 RID: 8707 RVA: 0x00017D0E File Offset: 0x00015F0E
		public unsafe GuardState.GuardBodyType guardType
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Paw.NativeFieldInfoPtr_guardType);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Paw.NativeFieldInfoPtr_guardType)) = value;
			}
		}

		// Token: 0x17000C3C RID: 3132
		// (get) Token: 0x06002204 RID: 8708 RVA: 0x0009319C File Offset: 0x0009139C
		// (set) Token: 0x06002205 RID: 8709 RVA: 0x00017D29 File Offset: 0x00015F29
		public unsafe GuardState.WeaponType WeaponType
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Paw.NativeFieldInfoPtr_WeaponType);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Paw.NativeFieldInfoPtr_WeaponType)) = value;
			}
		}

		// Token: 0x040013F3 RID: 5107
		private static readonly IntPtr NativeFieldInfoPtr_liftTime;

		// Token: 0x040013F4 RID: 5108
		private static readonly IntPtr NativeFieldInfoPtr_placeTime;

		// Token: 0x040013F5 RID: 5109
		private static readonly IntPtr NativeFieldInfoPtr_walkLiftTime;

		// Token: 0x040013F6 RID: 5110
		private static readonly IntPtr NativeFieldInfoPtr_walkPlaceTime;

		// Token: 0x040013F7 RID: 5111
		private static readonly IntPtr NativeFieldInfoPtr_runLiftTime;

		// Token: 0x040013F8 RID: 5112
		private static readonly IntPtr NativeFieldInfoPtr_runPlaceTime;

		// Token: 0x040013F9 RID: 5113
		private static readonly IntPtr NativeFieldInfoPtr_pos;

		// Token: 0x040013FA RID: 5114
		private static readonly IntPtr NativeFieldInfoPtr_paw;

		// Token: 0x040013FB RID: 5115
		private static readonly IntPtr NativeFieldInfoPtr_liftDur;

		// Token: 0x040013FC RID: 5116
		private static readonly IntPtr NativeFieldInfoPtr_rb;

		// Token: 0x040013FD RID: 5117
		private static readonly IntPtr NativeFieldInfoPtr_timeLeft;

		// Token: 0x040013FE RID: 5118
		private static readonly IntPtr NativeFieldInfoPtr_lifted;

		// Token: 0x040013FF RID: 5119
		private static readonly IntPtr NativeFieldInfoPtr_liftDist;

		// Token: 0x04001400 RID: 5120
		private static readonly IntPtr NativeFieldInfoPtr_liftOverride;

		// Token: 0x04001401 RID: 5121
		private static readonly IntPtr NativeFieldInfoPtr_overrideTime;

		// Token: 0x04001402 RID: 5122
		private static readonly IntPtr NativeFieldInfoPtr_tim;

		// Token: 0x04001403 RID: 5123
		private static readonly IntPtr NativeFieldInfoPtr_maxDist;

		// Token: 0x04001404 RID: 5124
		private static readonly IntPtr NativeFieldInfoPtr_lerpPlus;

		// Token: 0x04001405 RID: 5125
		private static readonly IntPtr NativeFieldInfoPtr_curSpd;

		// Token: 0x04001406 RID: 5126
		private static readonly IntPtr NativeFieldInfoPtr_curDest;

		// Token: 0x04001407 RID: 5127
		private static readonly IntPtr NativeFieldInfoPtr_desPlaceTime;

		// Token: 0x04001408 RID: 5128
		private static readonly IntPtr NativeFieldInfoPtr_desLiftTime;

		// Token: 0x04001409 RID: 5129
		private static readonly IntPtr NativeFieldInfoPtr_legs;

		// Token: 0x0400140A RID: 5130
		private static readonly IntPtr NativeFieldInfoPtr_apeDuster;

		// Token: 0x0400140B RID: 5131
		private static readonly IntPtr NativeFieldInfoPtr_dust;

		// Token: 0x0400140C RID: 5132
		private static readonly IntPtr NativeFieldInfoPtr_dustMain;

		// Token: 0x0400140D RID: 5133
		private static readonly IntPtr NativeFieldInfoPtr_prince;

		// Token: 0x0400140E RID: 5134
		private static readonly IntPtr NativeFieldInfoPtr_running;

		// Token: 0x0400140F RID: 5135
		private static readonly IntPtr NativeFieldInfoPtr_bloodiness;

		// Token: 0x04001410 RID: 5136
		private static readonly IntPtr NativeFieldInfoPtr_guardType;

		// Token: 0x04001411 RID: 5137
		private static readonly IntPtr NativeFieldInfoPtr_WeaponType;

		// Token: 0x04001412 RID: 5138
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_GameObject_Single_Single_Single_Single_Legs_Boolean_0;

		// Token: 0x04001413 RID: 5139
		private static readonly IntPtr NativeMethodInfoPtr_Place_Public_Void_Vector2_0;

		// Token: 0x04001414 RID: 5140
		private static readonly IntPtr NativeMethodInfoPtr_Update_Public_Void_Single_Boolean_0;

		// Token: 0x04001415 RID: 5141
		private static readonly IntPtr NativeMethodInfoPtr_Lerp_Public_Single_Single_Single_Single_0;

		// Token: 0x04001416 RID: 5142
		private static readonly IntPtr NativeMethodInfoPtr_Oned_Public_Single_Single_0;

		// Token: 0x04001417 RID: 5143
		private static readonly IntPtr NativeMethodInfoPtr_LiftOverride_Public_Void_0;

		// Token: 0x04001418 RID: 5144
		private static readonly IntPtr NativeMethodInfoPtr_Lifted_Public_Boolean_Single_0;

		// Token: 0x04001419 RID: 5145
		private static readonly IntPtr NativeMethodInfoPtr_ShortestDistPlus_Public_Boolean_Single_Single_Single_Single_0;

		// Token: 0x0400141A RID: 5146
		private static readonly IntPtr NativeMethodInfoPtr_GetDelt_Public_Single_Single_Single_0;

		// Token: 0x0400141B RID: 5147
		private static readonly IntPtr NativeMethodInfoPtr_GetDur_Public_Single_Single_Single_0;

		// Token: 0x0400141C RID: 5148
		private static readonly IntPtr NativeMethodInfoPtr_IsBetween_Public_Boolean_Single_Single_Single_0;

		// Token: 0x0400141D RID: 5149
		private static readonly IntPtr NativeMethodInfoPtr_RemainingStridePercent_Public_Single_0;
	}
}
