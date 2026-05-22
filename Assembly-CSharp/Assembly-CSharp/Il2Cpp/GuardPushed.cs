using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using UnityEngine;

namespace Il2Cpp
{
	// Token: 0x020000FE RID: 254
	public class GuardPushed : GuardMode
	{
		// Token: 0x06001DAD RID: 7597 RVA: 0x00087B84 File Offset: 0x00085D84
		// Note: this type is marked as 'beforefieldinit'.
		static GuardPushed()
		{
			Il2CppClassPointerStore<GuardPushed>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "GuardPushed");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GuardPushed>.NativeClassPtr);
			GuardPushed.NativeFieldInfoPtr_pushSpd = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GuardPushed>.NativeClassPtr, "pushSpd");
			GuardPushed.NativeFieldInfoPtr_pushDir = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GuardPushed>.NativeClassPtr, "pushDir");
			GuardPushed.NativeFieldInfoPtr_pushDist = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GuardPushed>.NativeClassPtr, "pushDist");
			GuardPushed.NativeFieldInfoPtr_mass = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GuardPushed>.NativeClassPtr, "mass");
			GuardPushed.NativeFieldInfoPtr_distTraved = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GuardPushed>.NativeClassPtr, "distTraved");
			GuardPushed.NativeFieldInfoPtr_minPushSpd = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GuardPushed>.NativeClassPtr, "minPushSpd");
			GuardPushed.NativeMethodInfoPtr__ctor_Public_Void_GuardState_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuardPushed>.NativeClassPtr, 100665694);
			GuardPushed.NativeMethodInfoPtr_ShouldAnim_Public_Virtual_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuardPushed>.NativeClassPtr, 100665695);
			GuardPushed.NativeMethodInfoPtr_Start_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuardPushed>.NativeClassPtr, 100665696);
			GuardPushed.NativeMethodInfoPtr_Update_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuardPushed>.NativeClassPtr, 100665697);
		}

		// Token: 0x06001DAE RID: 7598 RVA: 0x00087C7C File Offset: 0x00085E7C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 64634, RefRangeEnd = 64635, XrefRangeStart = 64630, XrefRangeEnd = 64634, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe GuardPushed(GuardState st, float pushMass)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GuardPushed>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(st);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref pushMass;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GuardPushed.NativeMethodInfoPtr__ctor_Public_Void_GuardState_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001DAF RID: 7599 RVA: 0x00087CD8 File Offset: 0x00085ED8
		[CallerCount(0)]
		public unsafe override bool ShouldAnim()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GuardPushed.NativeMethodInfoPtr_ShouldAnim_Public_Virtual_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001DB0 RID: 7600 RVA: 0x00087D20 File Offset: 0x00085F20
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 64635, XrefRangeEnd = 64657, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GuardPushed.NativeMethodInfoPtr_Start_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001DB1 RID: 7601 RVA: 0x00087D5C File Offset: 0x00085F5C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 64657, XrefRangeEnd = 64662, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GuardPushed.NativeMethodInfoPtr_Update_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001DB2 RID: 7602 RVA: 0x00014CD0 File Offset: 0x00012ED0
		public GuardPushed(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000A99 RID: 2713
		// (get) Token: 0x06001DB3 RID: 7603 RVA: 0x00087D98 File Offset: 0x00085F98
		// (set) Token: 0x06001DB4 RID: 7604 RVA: 0x00014CD9 File Offset: 0x00012ED9
		public unsafe float pushSpd
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuardPushed.NativeFieldInfoPtr_pushSpd);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuardPushed.NativeFieldInfoPtr_pushSpd)) = value;
			}
		}

		// Token: 0x17000A9A RID: 2714
		// (get) Token: 0x06001DB5 RID: 7605 RVA: 0x00087DC0 File Offset: 0x00085FC0
		// (set) Token: 0x06001DB6 RID: 7606 RVA: 0x00014CF4 File Offset: 0x00012EF4
		public unsafe Vector2 pushDir
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuardPushed.NativeFieldInfoPtr_pushDir);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuardPushed.NativeFieldInfoPtr_pushDir)) = value;
			}
		}

		// Token: 0x17000A9B RID: 2715
		// (get) Token: 0x06001DB7 RID: 7607 RVA: 0x00087DE8 File Offset: 0x00085FE8
		// (set) Token: 0x06001DB8 RID: 7608 RVA: 0x00014D0F File Offset: 0x00012F0F
		public unsafe float pushDist
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuardPushed.NativeFieldInfoPtr_pushDist);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuardPushed.NativeFieldInfoPtr_pushDist)) = value;
			}
		}

		// Token: 0x17000A9C RID: 2716
		// (get) Token: 0x06001DB9 RID: 7609 RVA: 0x00087E10 File Offset: 0x00086010
		// (set) Token: 0x06001DBA RID: 7610 RVA: 0x00014D2A File Offset: 0x00012F2A
		public unsafe float mass
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuardPushed.NativeFieldInfoPtr_mass);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuardPushed.NativeFieldInfoPtr_mass)) = value;
			}
		}

		// Token: 0x17000A9D RID: 2717
		// (get) Token: 0x06001DBB RID: 7611 RVA: 0x00087E38 File Offset: 0x00086038
		// (set) Token: 0x06001DBC RID: 7612 RVA: 0x00014D45 File Offset: 0x00012F45
		public unsafe float distTraved
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuardPushed.NativeFieldInfoPtr_distTraved);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuardPushed.NativeFieldInfoPtr_distTraved)) = value;
			}
		}

		// Token: 0x17000A9E RID: 2718
		// (get) Token: 0x06001DBD RID: 7613 RVA: 0x00087E60 File Offset: 0x00086060
		// (set) Token: 0x06001DBE RID: 7614 RVA: 0x00014D60 File Offset: 0x00012F60
		public unsafe float minPushSpd
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuardPushed.NativeFieldInfoPtr_minPushSpd);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuardPushed.NativeFieldInfoPtr_minPushSpd)) = value;
			}
		}

		// Token: 0x040011A3 RID: 4515
		private static readonly IntPtr NativeFieldInfoPtr_pushSpd;

		// Token: 0x040011A4 RID: 4516
		private static readonly IntPtr NativeFieldInfoPtr_pushDir;

		// Token: 0x040011A5 RID: 4517
		private static readonly IntPtr NativeFieldInfoPtr_pushDist;

		// Token: 0x040011A6 RID: 4518
		private static readonly IntPtr NativeFieldInfoPtr_mass;

		// Token: 0x040011A7 RID: 4519
		private static readonly IntPtr NativeFieldInfoPtr_distTraved;

		// Token: 0x040011A8 RID: 4520
		private static readonly IntPtr NativeFieldInfoPtr_minPushSpd;

		// Token: 0x040011A9 RID: 4521
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_GuardState_Single_0;

		// Token: 0x040011AA RID: 4522
		private static readonly IntPtr NativeMethodInfoPtr_ShouldAnim_Public_Virtual_Boolean_0;

		// Token: 0x040011AB RID: 4523
		private static readonly IntPtr NativeMethodInfoPtr_Start_Public_Virtual_Void_0;

		// Token: 0x040011AC RID: 4524
		private static readonly IntPtr NativeMethodInfoPtr_Update_Public_Virtual_Void_0;
	}
}
