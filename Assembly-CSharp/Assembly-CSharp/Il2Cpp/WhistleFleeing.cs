using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2Cpp
{
	// Token: 0x020001D4 RID: 468
	public class WhistleFleeing : GuardFleeing
	{
		// Token: 0x060032B6 RID: 12982 RVA: 0x000BF88C File Offset: 0x000BDA8C
		// Note: this type is marked as 'beforefieldinit'.
		static WhistleFleeing()
		{
			Il2CppClassPointerStore<WhistleFleeing>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "WhistleFleeing");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WhistleFleeing>.NativeClassPtr);
			WhistleFleeing.NativeFieldInfoPtr_wTimer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WhistleFleeing>.NativeClassPtr, "wTimer");
			WhistleFleeing.NativeMethodInfoPtr__ctor_Public_Void_GuardState_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WhistleFleeing>.NativeClassPtr, 100667239);
			WhistleFleeing.NativeMethodInfoPtr_Start_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WhistleFleeing>.NativeClassPtr, 100667240);
			WhistleFleeing.NativeMethodInfoPtr_Update_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WhistleFleeing>.NativeClassPtr, 100667241);
			WhistleFleeing.NativeMethodInfoPtr_Whistle_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WhistleFleeing>.NativeClassPtr, 100667242);
		}

		// Token: 0x060032B7 RID: 12983 RVA: 0x000BF920 File Offset: 0x000BDB20
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 85977, XrefRangeEnd = 85978, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WhistleFleeing(GuardState st, float mSpd, float rRate)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WhistleFleeing>.NativeClassPtr))
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WhistleFleeing.NativeMethodInfoPtr__ctor_Public_Void_GuardState_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060032B8 RID: 12984 RVA: 0x000BF988 File Offset: 0x000BDB88
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WhistleFleeing.NativeMethodInfoPtr_Start_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060032B9 RID: 12985 RVA: 0x000BF9C4 File Offset: 0x000BDBC4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 85978, XrefRangeEnd = 85982, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WhistleFleeing.NativeMethodInfoPtr_Update_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060032BA RID: 12986 RVA: 0x000BFA00 File Offset: 0x000BDC00
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 85991, RefRangeEnd = 85992, XrefRangeStart = 85982, XrefRangeEnd = 85991, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Whistle()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WhistleFleeing.NativeMethodInfoPtr_Whistle_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060032BB RID: 12987 RVA: 0x00022BB0 File Offset: 0x00020DB0
		public WhistleFleeing(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17001203 RID: 4611
		// (get) Token: 0x060032BC RID: 12988 RVA: 0x000BFA34 File Offset: 0x000BDC34
		// (set) Token: 0x060032BD RID: 12989 RVA: 0x00022BB9 File Offset: 0x00020DB9
		public unsafe int wTimer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WhistleFleeing.NativeFieldInfoPtr_wTimer);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WhistleFleeing.NativeFieldInfoPtr_wTimer)) = value;
			}
		}

		// Token: 0x04001DAB RID: 7595
		private static readonly IntPtr NativeFieldInfoPtr_wTimer;

		// Token: 0x04001DAC RID: 7596
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_GuardState_Single_Single_0;

		// Token: 0x04001DAD RID: 7597
		private static readonly IntPtr NativeMethodInfoPtr_Start_Public_Virtual_Void_0;

		// Token: 0x04001DAE RID: 7598
		private static readonly IntPtr NativeMethodInfoPtr_Update_Public_Virtual_Void_0;

		// Token: 0x04001DAF RID: 7599
		private static readonly IntPtr NativeMethodInfoPtr_Whistle_Public_Void_0;
	}
}
