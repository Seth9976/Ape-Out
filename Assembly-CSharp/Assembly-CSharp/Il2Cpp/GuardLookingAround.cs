using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2Cpp
{
	// Token: 0x020000FA RID: 250
	public class GuardLookingAround : GuardMode
	{
		// Token: 0x06001D6C RID: 7532 RVA: 0x00086F44 File Offset: 0x00085144
		// Note: this type is marked as 'beforefieldinit'.
		static GuardLookingAround()
		{
			Il2CppClassPointerStore<GuardLookingAround>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "GuardLookingAround");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GuardLookingAround>.NativeClassPtr);
			GuardLookingAround.NativeFieldInfoPtr_timer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GuardLookingAround>.NativeClassPtr, "timer");
			GuardLookingAround.NativeFieldInfoPtr_totTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GuardLookingAround>.NativeClassPtr, "totTime");
			GuardLookingAround.NativeFieldInfoPtr_startRot = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GuardLookingAround>.NativeClassPtr, "startRot");
			GuardLookingAround.NativeMethodInfoPtr__ctor_Public_Void_GuardState_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuardLookingAround>.NativeClassPtr, 100665673);
			GuardLookingAround.NativeMethodInfoPtr_Start_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuardLookingAround>.NativeClassPtr, 100665674);
			GuardLookingAround.NativeMethodInfoPtr_Update_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuardLookingAround>.NativeClassPtr, 100665675);
		}

		// Token: 0x06001D6D RID: 7533 RVA: 0x00086FEC File Offset: 0x000851EC
		[CallerCount(0)]
		public unsafe GuardLookingAround(GuardState st, float mSpd, float rRate)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GuardLookingAround>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(st);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref mSpd;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rRate;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GuardLookingAround.NativeMethodInfoPtr__ctor_Public_Void_GuardState_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001D6E RID: 7534 RVA: 0x00087054 File Offset: 0x00085254
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 64514, XrefRangeEnd = 64519, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GuardLookingAround.NativeMethodInfoPtr_Start_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001D6F RID: 7535 RVA: 0x00087090 File Offset: 0x00085290
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 64519, XrefRangeEnd = 64522, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GuardLookingAround.NativeMethodInfoPtr_Update_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001D70 RID: 7536 RVA: 0x00014ABA File Offset: 0x00012CBA
		public GuardLookingAround(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000A87 RID: 2695
		// (get) Token: 0x06001D71 RID: 7537 RVA: 0x000870CC File Offset: 0x000852CC
		// (set) Token: 0x06001D72 RID: 7538 RVA: 0x00014AC3 File Offset: 0x00012CC3
		public unsafe int timer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuardLookingAround.NativeFieldInfoPtr_timer);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuardLookingAround.NativeFieldInfoPtr_timer)) = value;
			}
		}

		// Token: 0x17000A88 RID: 2696
		// (get) Token: 0x06001D73 RID: 7539 RVA: 0x000870F4 File Offset: 0x000852F4
		// (set) Token: 0x06001D74 RID: 7540 RVA: 0x00014ADE File Offset: 0x00012CDE
		public unsafe int totTime
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuardLookingAround.NativeFieldInfoPtr_totTime);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuardLookingAround.NativeFieldInfoPtr_totTime)) = value;
			}
		}

		// Token: 0x17000A89 RID: 2697
		// (get) Token: 0x06001D75 RID: 7541 RVA: 0x0008711C File Offset: 0x0008531C
		// (set) Token: 0x06001D76 RID: 7542 RVA: 0x00014AF9 File Offset: 0x00012CF9
		public unsafe float startRot
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuardLookingAround.NativeFieldInfoPtr_startRot);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuardLookingAround.NativeFieldInfoPtr_startRot)) = value;
			}
		}

		// Token: 0x0400117C RID: 4476
		private static readonly IntPtr NativeFieldInfoPtr_timer;

		// Token: 0x0400117D RID: 4477
		private static readonly IntPtr NativeFieldInfoPtr_totTime;

		// Token: 0x0400117E RID: 4478
		private static readonly IntPtr NativeFieldInfoPtr_startRot;

		// Token: 0x0400117F RID: 4479
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_GuardState_Single_Single_0;

		// Token: 0x04001180 RID: 4480
		private static readonly IntPtr NativeMethodInfoPtr_Start_Public_Virtual_Void_0;

		// Token: 0x04001181 RID: 4481
		private static readonly IntPtr NativeMethodInfoPtr_Update_Public_Virtual_Void_0;
	}
}
