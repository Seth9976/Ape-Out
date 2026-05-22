using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem
{
	// Token: 0x0200013D RID: 317
	public class TimeType : Object
	{
		// Token: 0x060016E1 RID: 5857 RVA: 0x0008B88C File Offset: 0x00089A8C
		// Note: this type is marked as 'beforefieldinit'.
		static TimeType()
		{
			Il2CppClassPointerStore<TimeType>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System", "TimeType");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TimeType>.NativeClassPtr);
			TimeType.NativeFieldInfoPtr_Offset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TimeType>.NativeClassPtr, "Offset");
			TimeType.NativeFieldInfoPtr_IsDst = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TimeType>.NativeClassPtr, "IsDst");
			TimeType.NativeFieldInfoPtr_Name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TimeType>.NativeClassPtr, "Name");
			TimeType.NativeMethodInfoPtr__ctor_Public_Void_Int32_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeType>.NativeClassPtr, 100667202);
			TimeType.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeType>.NativeClassPtr, 100667203);
		}

		// Token: 0x060016E2 RID: 5858 RVA: 0x0008B920 File Offset: 0x00089B20
		[CallerCount(0)]
		public unsafe TimeType(int offset, bool is_dst, string abbrev)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TimeType>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref offset;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref is_dst;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(abbrev);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimeType.NativeMethodInfoPtr__ctor_Public_Void_Int32_Boolean_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060016E3 RID: 5859 RVA: 0x0008B988 File Offset: 0x00089B88
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 178532, XrefRangeEnd = 178582, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TimeType.NativeMethodInfoPtr_ToString_Public_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060016E4 RID: 5860 RVA: 0x00007E5F File Offset: 0x0000605F
		public TimeType(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700044D RID: 1101
		// (get) Token: 0x060016E5 RID: 5861 RVA: 0x0008B9CC File Offset: 0x00089BCC
		// (set) Token: 0x060016E6 RID: 5862 RVA: 0x00007E68 File Offset: 0x00006068
		public unsafe int Offset
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TimeType.NativeFieldInfoPtr_Offset);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TimeType.NativeFieldInfoPtr_Offset)) = value;
			}
		}

		// Token: 0x1700044E RID: 1102
		// (get) Token: 0x060016E7 RID: 5863 RVA: 0x0008B9F4 File Offset: 0x00089BF4
		// (set) Token: 0x060016E8 RID: 5864 RVA: 0x00007E83 File Offset: 0x00006083
		public unsafe bool IsDst
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TimeType.NativeFieldInfoPtr_IsDst);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TimeType.NativeFieldInfoPtr_IsDst)) = value;
			}
		}

		// Token: 0x1700044F RID: 1103
		// (get) Token: 0x060016E9 RID: 5865 RVA: 0x0008BA1C File Offset: 0x00089C1C
		// (set) Token: 0x060016EA RID: 5866 RVA: 0x00007E9E File Offset: 0x0000609E
		public unsafe string Name
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TimeType.NativeFieldInfoPtr_Name);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TimeType.NativeFieldInfoPtr_Name), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x0400150B RID: 5387
		private static readonly IntPtr NativeFieldInfoPtr_Offset;

		// Token: 0x0400150C RID: 5388
		private static readonly IntPtr NativeFieldInfoPtr_IsDst;

		// Token: 0x0400150D RID: 5389
		private static readonly IntPtr NativeFieldInfoPtr_Name;

		// Token: 0x0400150E RID: 5390
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_Boolean_String_0;

		// Token: 0x0400150F RID: 5391
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;
	}
}
