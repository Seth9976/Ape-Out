using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace Il2Cpp
{
	// Token: 0x02000150 RID: 336
	public class ParalaxSimple : MonoBehaviour
	{
		// Token: 0x0600288E RID: 10382 RVA: 0x000A4584 File Offset: 0x000A2784
		// Note: this type is marked as 'beforefieldinit'.
		static ParalaxSimple()
		{
			Il2CppClassPointerStore<ParalaxSimple>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "ParalaxSimple");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ParalaxSimple>.NativeClassPtr);
			ParalaxSimple.NativeFieldInfoPtr_parAmount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParalaxSimple>.NativeClassPtr, "parAmount");
			ParalaxSimple.NativeFieldInfoPtr_defPos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParalaxSimple>.NativeClassPtr, "defPos");
			ParalaxSimple.NativeFieldInfoPtr_defLocalPos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParalaxSimple>.NativeClassPtr, "defLocalPos");
			ParalaxSimple.NativeFieldInfoPtr_layerThisShit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParalaxSimple>.NativeClassPtr, "layerThisShit");
			ParalaxSimple.NativeFieldInfoPtr_pts = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParalaxSimple>.NativeClassPtr, "pts");
			ParalaxSimple.NativeFieldInfoPtr_rend = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParalaxSimple>.NativeClassPtr, "rend");
			ParalaxSimple.NativeFieldInfoPtr_avPt = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParalaxSimple>.NativeClassPtr, "avPt");
			ParalaxSimple.NativeFieldInfoPtr_top = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParalaxSimple>.NativeClassPtr, "top");
			ParalaxSimple.NativeFieldInfoPtr_startflag = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParalaxSimple>.NativeClassPtr, "startflag");
			ParalaxSimple.NativeFieldInfoPtr_zeroed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParalaxSimple>.NativeClassPtr, "zeroed");
			ParalaxSimple.NativeFieldInfoPtr_selfTransform = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParalaxSimple>.NativeClassPtr, "selfTransform");
			ParalaxSimple.NativeFieldInfoPtr_startRan = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParalaxSimple>.NativeClassPtr, "startRan");
			ParalaxSimple.NativeMethodInfoPtr_OnEnable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParalaxSimple>.NativeClassPtr, 100666507);
			ParalaxSimple.NativeMethodInfoPtr_MyStart_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParalaxSimple>.NativeClassPtr, 100666508);
			ParalaxSimple.NativeMethodInfoPtr_LateUpdate_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParalaxSimple>.NativeClassPtr, 100666509);
			ParalaxSimple.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParalaxSimple>.NativeClassPtr, 100666510);
		}

		// Token: 0x0600288F RID: 10383 RVA: 0x000A46F4 File Offset: 0x000A28F4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 76318, XrefRangeEnd = 76327, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnEnable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParalaxSimple.NativeMethodInfoPtr_OnEnable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002890 RID: 10384 RVA: 0x000A4728 File Offset: 0x000A2928
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 76372, RefRangeEnd = 76373, XrefRangeStart = 76327, XrefRangeEnd = 76372, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void MyStart()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParalaxSimple.NativeMethodInfoPtr_MyStart_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002891 RID: 10385 RVA: 0x000A475C File Offset: 0x000A295C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 76373, XrefRangeEnd = 76390, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void LateUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParalaxSimple.NativeMethodInfoPtr_LateUpdate_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002892 RID: 10386 RVA: 0x000A4790 File Offset: 0x000A2990
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ParalaxSimple()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ParalaxSimple>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParalaxSimple.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002893 RID: 10387 RVA: 0x0001C4B3 File Offset: 0x0001A6B3
		public ParalaxSimple(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000EA1 RID: 3745
		// (get) Token: 0x06002894 RID: 10388 RVA: 0x000A47CC File Offset: 0x000A29CC
		// (set) Token: 0x06002895 RID: 10389 RVA: 0x0001C4BC File Offset: 0x0001A6BC
		public unsafe float parAmount
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ParalaxSimple.NativeFieldInfoPtr_parAmount);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ParalaxSimple.NativeFieldInfoPtr_parAmount)) = value;
			}
		}

		// Token: 0x17000EA2 RID: 3746
		// (get) Token: 0x06002896 RID: 10390 RVA: 0x000A47F4 File Offset: 0x000A29F4
		// (set) Token: 0x06002897 RID: 10391 RVA: 0x0001C4D7 File Offset: 0x0001A6D7
		public unsafe Vector3 defPos
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ParalaxSimple.NativeFieldInfoPtr_defPos);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ParalaxSimple.NativeFieldInfoPtr_defPos)) = value;
			}
		}

		// Token: 0x17000EA3 RID: 3747
		// (get) Token: 0x06002898 RID: 10392 RVA: 0x000A481C File Offset: 0x000A2A1C
		// (set) Token: 0x06002899 RID: 10393 RVA: 0x0001C4F2 File Offset: 0x0001A6F2
		public unsafe Vector3 defLocalPos
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ParalaxSimple.NativeFieldInfoPtr_defLocalPos);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ParalaxSimple.NativeFieldInfoPtr_defLocalPos)) = value;
			}
		}

		// Token: 0x17000EA4 RID: 3748
		// (get) Token: 0x0600289A RID: 10394 RVA: 0x000A4844 File Offset: 0x000A2A44
		// (set) Token: 0x0600289B RID: 10395 RVA: 0x0001C50D File Offset: 0x0001A70D
		public unsafe bool layerThisShit
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ParalaxSimple.NativeFieldInfoPtr_layerThisShit);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ParalaxSimple.NativeFieldInfoPtr_layerThisShit)) = value;
			}
		}

		// Token: 0x17000EA5 RID: 3749
		// (get) Token: 0x0600289C RID: 10396 RVA: 0x000A486C File Offset: 0x000A2A6C
		// (set) Token: 0x0600289D RID: 10397 RVA: 0x0001C528 File Offset: 0x0001A728
		public unsafe Il2CppStructArray<Vector2> pts
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ParalaxSimple.NativeFieldInfoPtr_pts);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<Vector2>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ParalaxSimple.NativeFieldInfoPtr_pts), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000EA6 RID: 3750
		// (get) Token: 0x0600289E RID: 10398 RVA: 0x000A489C File Offset: 0x000A2A9C
		// (set) Token: 0x0600289F RID: 10399 RVA: 0x0001C547 File Offset: 0x0001A747
		public unsafe Renderer rend
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ParalaxSimple.NativeFieldInfoPtr_rend);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Renderer>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ParalaxSimple.NativeFieldInfoPtr_rend), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000EA7 RID: 3751
		// (get) Token: 0x060028A0 RID: 10400 RVA: 0x000A48CC File Offset: 0x000A2ACC
		// (set) Token: 0x060028A1 RID: 10401 RVA: 0x0001C566 File Offset: 0x0001A766
		public unsafe Vector2 avPt
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ParalaxSimple.NativeFieldInfoPtr_avPt);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ParalaxSimple.NativeFieldInfoPtr_avPt)) = value;
			}
		}

		// Token: 0x17000EA8 RID: 3752
		// (get) Token: 0x060028A2 RID: 10402 RVA: 0x000A48F4 File Offset: 0x000A2AF4
		// (set) Token: 0x060028A3 RID: 10403 RVA: 0x0001C581 File Offset: 0x0001A781
		public unsafe Transform top
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ParalaxSimple.NativeFieldInfoPtr_top);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ParalaxSimple.NativeFieldInfoPtr_top), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000EA9 RID: 3753
		// (get) Token: 0x060028A4 RID: 10404 RVA: 0x000A4924 File Offset: 0x000A2B24
		// (set) Token: 0x060028A5 RID: 10405 RVA: 0x0001C5A0 File Offset: 0x0001A7A0
		public unsafe bool startflag
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ParalaxSimple.NativeFieldInfoPtr_startflag);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ParalaxSimple.NativeFieldInfoPtr_startflag)) = value;
			}
		}

		// Token: 0x17000EAA RID: 3754
		// (get) Token: 0x060028A6 RID: 10406 RVA: 0x000A494C File Offset: 0x000A2B4C
		// (set) Token: 0x060028A7 RID: 10407 RVA: 0x0001C5BB File Offset: 0x0001A7BB
		public unsafe bool zeroed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ParalaxSimple.NativeFieldInfoPtr_zeroed);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ParalaxSimple.NativeFieldInfoPtr_zeroed)) = value;
			}
		}

		// Token: 0x17000EAB RID: 3755
		// (get) Token: 0x060028A8 RID: 10408 RVA: 0x000A4974 File Offset: 0x000A2B74
		// (set) Token: 0x060028A9 RID: 10409 RVA: 0x0001C5D6 File Offset: 0x0001A7D6
		public unsafe Transform selfTransform
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ParalaxSimple.NativeFieldInfoPtr_selfTransform);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ParalaxSimple.NativeFieldInfoPtr_selfTransform), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000EAC RID: 3756
		// (get) Token: 0x060028AA RID: 10410 RVA: 0x000A49A4 File Offset: 0x000A2BA4
		// (set) Token: 0x060028AB RID: 10411 RVA: 0x0001C5F5 File Offset: 0x0001A7F5
		public unsafe bool startRan
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ParalaxSimple.NativeFieldInfoPtr_startRan);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ParalaxSimple.NativeFieldInfoPtr_startRan)) = value;
			}
		}

		// Token: 0x040017D8 RID: 6104
		private static readonly IntPtr NativeFieldInfoPtr_parAmount;

		// Token: 0x040017D9 RID: 6105
		private static readonly IntPtr NativeFieldInfoPtr_defPos;

		// Token: 0x040017DA RID: 6106
		private static readonly IntPtr NativeFieldInfoPtr_defLocalPos;

		// Token: 0x040017DB RID: 6107
		private static readonly IntPtr NativeFieldInfoPtr_layerThisShit;

		// Token: 0x040017DC RID: 6108
		private static readonly IntPtr NativeFieldInfoPtr_pts;

		// Token: 0x040017DD RID: 6109
		private static readonly IntPtr NativeFieldInfoPtr_rend;

		// Token: 0x040017DE RID: 6110
		private static readonly IntPtr NativeFieldInfoPtr_avPt;

		// Token: 0x040017DF RID: 6111
		private static readonly IntPtr NativeFieldInfoPtr_top;

		// Token: 0x040017E0 RID: 6112
		private static readonly IntPtr NativeFieldInfoPtr_startflag;

		// Token: 0x040017E1 RID: 6113
		private static readonly IntPtr NativeFieldInfoPtr_zeroed;

		// Token: 0x040017E2 RID: 6114
		private static readonly IntPtr NativeFieldInfoPtr_selfTransform;

		// Token: 0x040017E3 RID: 6115
		private static readonly IntPtr NativeFieldInfoPtr_startRan;

		// Token: 0x040017E4 RID: 6116
		private static readonly IntPtr NativeMethodInfoPtr_OnEnable_Private_Void_0;

		// Token: 0x040017E5 RID: 6117
		private static readonly IntPtr NativeMethodInfoPtr_MyStart_Private_Void_0;

		// Token: 0x040017E6 RID: 6118
		private static readonly IntPtr NativeMethodInfoPtr_LateUpdate_Private_Void_0;

		// Token: 0x040017E7 RID: 6119
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
