using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using UnityEngine;

namespace Il2Cpp
{
	// Token: 0x0200016C RID: 364
	public class Reinforcements : MonoBehaviour
	{
		// Token: 0x06002BE6 RID: 11238 RVA: 0x000AD9C0 File Offset: 0x000ABBC0
		// Note: this type is marked as 'beforefieldinit'.
		static Reinforcements()
		{
			Il2CppClassPointerStore<Reinforcements>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "Reinforcements");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Reinforcements>.NativeClassPtr);
			Reinforcements.NativeFieldInfoPtr_delay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Reinforcements>.NativeClassPtr, "delay");
			Reinforcements.NativeFieldInfoPtr_coolDownTimer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Reinforcements>.NativeClassPtr, "coolDownTimer");
			Reinforcements.NativeFieldInfoPtr_coolDownTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Reinforcements>.NativeClassPtr, "coolDownTime");
			Reinforcements.NativeFieldInfoPtr_startPos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Reinforcements>.NativeClassPtr, "startPos");
			Reinforcements.NativeMethodInfoPtr_Start_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Reinforcements>.NativeClassPtr, 100666739);
			Reinforcements.NativeMethodInfoPtr_FixedUpdate_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Reinforcements>.NativeClassPtr, 100666740);
			Reinforcements.NativeMethodInfoPtr_SpawnGuard_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Reinforcements>.NativeClassPtr, 100666741);
			Reinforcements.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Reinforcements>.NativeClassPtr, 100666742);
		}

		// Token: 0x06002BE7 RID: 11239 RVA: 0x000ADA90 File Offset: 0x000ABC90
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 79805, XrefRangeEnd = 79811, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Reinforcements.NativeMethodInfoPtr_Start_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002BE8 RID: 11240 RVA: 0x000ADAC4 File Offset: 0x000ABCC4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 79811, XrefRangeEnd = 79812, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void FixedUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Reinforcements.NativeMethodInfoPtr_FixedUpdate_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002BE9 RID: 11241 RVA: 0x000ADAF8 File Offset: 0x000ABCF8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 79833, RefRangeEnd = 79834, XrefRangeStart = 79812, XrefRangeEnd = 79833, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SpawnGuard()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Reinforcements.NativeMethodInfoPtr_SpawnGuard_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002BEA RID: 11242 RVA: 0x000ADB2C File Offset: 0x000ABD2C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Reinforcements()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Reinforcements>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Reinforcements.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002BEB RID: 11243 RVA: 0x0001E70D File Offset: 0x0001C90D
		public Reinforcements(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000FC8 RID: 4040
		// (get) Token: 0x06002BEC RID: 11244 RVA: 0x000ADB68 File Offset: 0x000ABD68
		// (set) Token: 0x06002BED RID: 11245 RVA: 0x0001E716 File Offset: 0x0001C916
		public unsafe float delay
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Reinforcements.NativeFieldInfoPtr_delay);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Reinforcements.NativeFieldInfoPtr_delay)) = value;
			}
		}

		// Token: 0x17000FC9 RID: 4041
		// (get) Token: 0x06002BEE RID: 11246 RVA: 0x000ADB90 File Offset: 0x000ABD90
		// (set) Token: 0x06002BEF RID: 11247 RVA: 0x0001E731 File Offset: 0x0001C931
		public unsafe int coolDownTimer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Reinforcements.NativeFieldInfoPtr_coolDownTimer);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Reinforcements.NativeFieldInfoPtr_coolDownTimer)) = value;
			}
		}

		// Token: 0x17000FCA RID: 4042
		// (get) Token: 0x06002BF0 RID: 11248 RVA: 0x000ADBB8 File Offset: 0x000ABDB8
		// (set) Token: 0x06002BF1 RID: 11249 RVA: 0x0001E74C File Offset: 0x0001C94C
		public unsafe int coolDownTime
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Reinforcements.NativeFieldInfoPtr_coolDownTime);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Reinforcements.NativeFieldInfoPtr_coolDownTime)) = value;
			}
		}

		// Token: 0x17000FCB RID: 4043
		// (get) Token: 0x06002BF2 RID: 11250 RVA: 0x000ADBE0 File Offset: 0x000ABDE0
		// (set) Token: 0x06002BF3 RID: 11251 RVA: 0x0001E767 File Offset: 0x0001C967
		public unsafe Vector2 startPos
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Reinforcements.NativeFieldInfoPtr_startPos);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Reinforcements.NativeFieldInfoPtr_startPos)) = value;
			}
		}

		// Token: 0x040019E1 RID: 6625
		private static readonly IntPtr NativeFieldInfoPtr_delay;

		// Token: 0x040019E2 RID: 6626
		private static readonly IntPtr NativeFieldInfoPtr_coolDownTimer;

		// Token: 0x040019E3 RID: 6627
		private static readonly IntPtr NativeFieldInfoPtr_coolDownTime;

		// Token: 0x040019E4 RID: 6628
		private static readonly IntPtr NativeFieldInfoPtr_startPos;

		// Token: 0x040019E5 RID: 6629
		private static readonly IntPtr NativeMethodInfoPtr_Start_Public_Void_0;

		// Token: 0x040019E6 RID: 6630
		private static readonly IntPtr NativeMethodInfoPtr_FixedUpdate_Public_Void_0;

		// Token: 0x040019E7 RID: 6631
		private static readonly IntPtr NativeMethodInfoPtr_SpawnGuard_Public_Void_0;

		// Token: 0x040019E8 RID: 6632
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
