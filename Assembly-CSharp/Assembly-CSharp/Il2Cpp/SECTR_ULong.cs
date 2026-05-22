using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Il2Cpp
{
	// Token: 0x02000053 RID: 83
	[Serializable]
	public class SECTR_ULong : Object
	{
		// Token: 0x06000C31 RID: 3121 RVA: 0x00058C7C File Offset: 0x00056E7C
		// Note: this type is marked as 'beforefieldinit'.
		static SECTR_ULong()
		{
			Il2CppClassPointerStore<SECTR_ULong>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "SECTR_ULong");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SECTR_ULong>.NativeClassPtr);
			SECTR_ULong.NativeFieldInfoPtr_first = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SECTR_ULong>.NativeClassPtr, "first");
			SECTR_ULong.NativeFieldInfoPtr_second = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SECTR_ULong>.NativeClassPtr, "second");
			SECTR_ULong.NativeMethodInfoPtr_get_value_Public_get_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SECTR_ULong>.NativeClassPtr, 100664365);
			SECTR_ULong.NativeMethodInfoPtr_set_value_Public_set_Void_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SECTR_ULong>.NativeClassPtr, 100664366);
			SECTR_ULong.NativeMethodInfoPtr__ctor_Public_Void_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SECTR_ULong>.NativeClassPtr, 100664367);
			SECTR_ULong.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SECTR_ULong>.NativeClassPtr, 100664368);
			SECTR_ULong.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SECTR_ULong>.NativeClassPtr, 100664369);
			SECTR_ULong.NativeMethodInfoPtr_op_GreaterThan_Public_Static_Boolean_SECTR_ULong_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SECTR_ULong>.NativeClassPtr, 100664370);
			SECTR_ULong.NativeMethodInfoPtr_op_GreaterThan_Public_Static_Boolean_UInt64_SECTR_ULong_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SECTR_ULong>.NativeClassPtr, 100664371);
			SECTR_ULong.NativeMethodInfoPtr_op_LessThan_Public_Static_Boolean_SECTR_ULong_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SECTR_ULong>.NativeClassPtr, 100664372);
			SECTR_ULong.NativeMethodInfoPtr_op_LessThan_Public_Static_Boolean_UInt64_SECTR_ULong_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SECTR_ULong>.NativeClassPtr, 100664373);
		}

		// Token: 0x17000480 RID: 1152
		// (get) Token: 0x06000C32 RID: 3122 RVA: 0x00058D88 File Offset: 0x00056F88
		// (set) Token: 0x06000C33 RID: 3123 RVA: 0x00058DC4 File Offset: 0x00056FC4
		public unsafe ulong value
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SECTR_ULong.NativeMethodInfoPtr_get_value_Public_get_UInt64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SECTR_ULong.NativeMethodInfoPtr_set_value_Public_set_Void_UInt64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06000C34 RID: 3124 RVA: 0x00058E04 File Offset: 0x00057004
		[CallerCount(0)]
		public unsafe SECTR_ULong(ulong newValue)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SECTR_ULong>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref newValue;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SECTR_ULong.NativeMethodInfoPtr__ctor_Public_Void_UInt64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000C35 RID: 3125 RVA: 0x00058E4C File Offset: 0x0005704C
		[CallerCount(0)]
		public unsafe SECTR_ULong()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SECTR_ULong>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SECTR_ULong.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000C36 RID: 3126 RVA: 0x00058E88 File Offset: 0x00057088
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 42410, XrefRangeEnd = 42421, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SECTR_ULong.NativeMethodInfoPtr_ToString_Public_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000C37 RID: 3127 RVA: 0x00058ECC File Offset: 0x000570CC
		[CallerCount(0)]
		public unsafe static bool operator >(SECTR_ULong a, ulong b)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(a);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref b;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SECTR_ULong.NativeMethodInfoPtr_op_GreaterThan_Public_Static_Boolean_SECTR_ULong_UInt64_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000C38 RID: 3128 RVA: 0x00058F1C File Offset: 0x0005711C
		[CallerCount(0)]
		public unsafe static bool operator >(ulong a, SECTR_ULong b)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref a;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(b);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SECTR_ULong.NativeMethodInfoPtr_op_GreaterThan_Public_Static_Boolean_UInt64_SECTR_ULong_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000C39 RID: 3129 RVA: 0x00058F6C File Offset: 0x0005716C
		[CallerCount(0)]
		public unsafe static bool operator <(SECTR_ULong a, ulong b)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(a);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref b;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SECTR_ULong.NativeMethodInfoPtr_op_LessThan_Public_Static_Boolean_SECTR_ULong_UInt64_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000C3A RID: 3130 RVA: 0x00058FBC File Offset: 0x000571BC
		[CallerCount(0)]
		public unsafe static bool operator <(ulong a, SECTR_ULong b)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref a;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(b);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SECTR_ULong.NativeMethodInfoPtr_op_LessThan_Public_Static_Boolean_UInt64_SECTR_ULong_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000C3B RID: 3131 RVA: 0x000096A8 File Offset: 0x000078A8
		public SECTR_ULong(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700047E RID: 1150
		// (get) Token: 0x06000C3C RID: 3132 RVA: 0x0005900C File Offset: 0x0005720C
		// (set) Token: 0x06000C3D RID: 3133 RVA: 0x000096B1 File Offset: 0x000078B1
		public unsafe int first
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SECTR_ULong.NativeFieldInfoPtr_first);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SECTR_ULong.NativeFieldInfoPtr_first)) = value;
			}
		}

		// Token: 0x1700047F RID: 1151
		// (get) Token: 0x06000C3E RID: 3134 RVA: 0x00059034 File Offset: 0x00057234
		// (set) Token: 0x06000C3F RID: 3135 RVA: 0x000096CC File Offset: 0x000078CC
		public unsafe int second
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SECTR_ULong.NativeFieldInfoPtr_second);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SECTR_ULong.NativeFieldInfoPtr_second)) = value;
			}
		}

		// Token: 0x0400077D RID: 1917
		private static readonly IntPtr NativeFieldInfoPtr_first;

		// Token: 0x0400077E RID: 1918
		private static readonly IntPtr NativeFieldInfoPtr_second;

		// Token: 0x0400077F RID: 1919
		private static readonly IntPtr NativeMethodInfoPtr_get_value_Public_get_UInt64_0;

		// Token: 0x04000780 RID: 1920
		private static readonly IntPtr NativeMethodInfoPtr_set_value_Public_set_Void_UInt64_0;

		// Token: 0x04000781 RID: 1921
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_UInt64_0;

		// Token: 0x04000782 RID: 1922
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04000783 RID: 1923
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

		// Token: 0x04000784 RID: 1924
		private static readonly IntPtr NativeMethodInfoPtr_op_GreaterThan_Public_Static_Boolean_SECTR_ULong_UInt64_0;

		// Token: 0x04000785 RID: 1925
		private static readonly IntPtr NativeMethodInfoPtr_op_GreaterThan_Public_Static_Boolean_UInt64_SECTR_ULong_0;

		// Token: 0x04000786 RID: 1926
		private static readonly IntPtr NativeMethodInfoPtr_op_LessThan_Public_Static_Boolean_SECTR_ULong_UInt64_0;

		// Token: 0x04000787 RID: 1927
		private static readonly IntPtr NativeMethodInfoPtr_op_LessThan_Public_Static_Boolean_UInt64_SECTR_ULong_0;
	}
}
