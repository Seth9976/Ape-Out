using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Il2CppRewired.Data.Mapping
{
	// Token: 0x020000BA RID: 186
	[Serializable]
	public class HardwareButtonInfo : Object
	{
		// Token: 0x06001568 RID: 5480 RVA: 0x0007D2F8 File Offset: 0x0007B4F8
		// Note: this type is marked as 'beforefieldinit'.
		static HardwareButtonInfo()
		{
			Il2CppClassPointerStore<HardwareButtonInfo>.NativeClassPtr = IL2CPP.GetIl2CppClass("Rewired_Core.dll", "Rewired.Data.Mapping", "HardwareButtonInfo");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HardwareButtonInfo>.NativeClassPtr);
			HardwareButtonInfo.NativeFieldInfoPtr__excludeFromPolling = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HardwareButtonInfo>.NativeClassPtr, "_excludeFromPolling");
			HardwareButtonInfo.NativeFieldInfoPtr__isPressureSensitive = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HardwareButtonInfo>.NativeClassPtr, "_isPressureSensitive");
			HardwareButtonInfo.NativeMethodInfoPtr_get_excludeFromPolling_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HardwareButtonInfo>.NativeClassPtr, 100668370);
			HardwareButtonInfo.NativeMethodInfoPtr_get_isPressureSensitive_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HardwareButtonInfo>.NativeClassPtr, 100668371);
			HardwareButtonInfo.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HardwareButtonInfo>.NativeClassPtr, 100668372);
			HardwareButtonInfo.NativeMethodInfoPtr__ctor_Internal_Void_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HardwareButtonInfo>.NativeClassPtr, 100668373);
			HardwareButtonInfo.NativeMethodInfoPtr_DeepClone_Public_Virtual_Final_New_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HardwareButtonInfo>.NativeClassPtr, 100668374);
		}

		// Token: 0x17000783 RID: 1923
		// (get) Token: 0x06001569 RID: 5481 RVA: 0x0007D3B4 File Offset: 0x0007B5B4
		public unsafe bool excludeFromPolling
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HardwareButtonInfo.NativeMethodInfoPtr_get_excludeFromPolling_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000784 RID: 1924
		// (get) Token: 0x0600156A RID: 5482 RVA: 0x0007D3F0 File Offset: 0x0007B5F0
		public unsafe bool isPressureSensitive
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HardwareButtonInfo.NativeMethodInfoPtr_get_isPressureSensitive_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600156B RID: 5483 RVA: 0x0007D42C File Offset: 0x0007B62C
		[CallerCount(0)]
		public unsafe HardwareButtonInfo()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<HardwareButtonInfo>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HardwareButtonInfo.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600156C RID: 5484 RVA: 0x0007D468 File Offset: 0x0007B668
		[CallerCount(0)]
		public unsafe HardwareButtonInfo(bool excludeFromPolling, bool isPressureSensitive)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<HardwareButtonInfo>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref excludeFromPolling;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isPressureSensitive;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HardwareButtonInfo.NativeMethodInfoPtr__ctor_Internal_Void_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600156D RID: 5485 RVA: 0x0007D4C0 File Offset: 0x0007B6C0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 271472, XrefRangeEnd = 271475, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual Object DeepClone()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HardwareButtonInfo.NativeMethodInfoPtr_DeepClone_Public_Virtual_Final_New_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x0600156E RID: 5486 RVA: 0x00009613 File Offset: 0x00007813
		public HardwareButtonInfo(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000781 RID: 1921
		// (get) Token: 0x0600156F RID: 5487 RVA: 0x0007D500 File Offset: 0x0007B700
		// (set) Token: 0x06001570 RID: 5488 RVA: 0x0000961C File Offset: 0x0000781C
		public unsafe bool _excludeFromPolling
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HardwareButtonInfo.NativeFieldInfoPtr__excludeFromPolling);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HardwareButtonInfo.NativeFieldInfoPtr__excludeFromPolling)) = value;
			}
		}

		// Token: 0x17000782 RID: 1922
		// (get) Token: 0x06001571 RID: 5489 RVA: 0x0007D528 File Offset: 0x0007B728
		// (set) Token: 0x06001572 RID: 5490 RVA: 0x00009637 File Offset: 0x00007837
		public unsafe bool _isPressureSensitive
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HardwareButtonInfo.NativeFieldInfoPtr__isPressureSensitive);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HardwareButtonInfo.NativeFieldInfoPtr__isPressureSensitive)) = value;
			}
		}

		// Token: 0x04001143 RID: 4419
		private static readonly IntPtr NativeFieldInfoPtr__excludeFromPolling;

		// Token: 0x04001144 RID: 4420
		private static readonly IntPtr NativeFieldInfoPtr__isPressureSensitive;

		// Token: 0x04001145 RID: 4421
		private static readonly IntPtr NativeMethodInfoPtr_get_excludeFromPolling_Public_get_Boolean_0;

		// Token: 0x04001146 RID: 4422
		private static readonly IntPtr NativeMethodInfoPtr_get_isPressureSensitive_Public_get_Boolean_0;

		// Token: 0x04001147 RID: 4423
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04001148 RID: 4424
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_Boolean_Boolean_0;

		// Token: 0x04001149 RID: 4425
		private static readonly IntPtr NativeMethodInfoPtr_DeepClone_Public_Virtual_Final_New_Object_0;
	}
}
