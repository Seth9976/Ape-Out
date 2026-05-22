using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Il2CppRewired
{
	// Token: 0x0200002E RID: 46
	public sealed class RewiredVersion : ValueType
	{
		// Token: 0x06000364 RID: 868 RVA: 0x0003AC8C File Offset: 0x00038E8C
		// Note: this type is marked as 'beforefieldinit'.
		static RewiredVersion()
		{
			Il2CppClassPointerStore<RewiredVersion>.NativeClassPtr = IL2CPP.GetIl2CppClass("Rewired_Core.dll", "Rewired", "RewiredVersion");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RewiredVersion>.NativeClassPtr);
			RewiredVersion.NativeFieldInfoPtr_version1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RewiredVersion>.NativeClassPtr, "version1");
			RewiredVersion.NativeFieldInfoPtr_version2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RewiredVersion>.NativeClassPtr, "version2");
			RewiredVersion.NativeFieldInfoPtr_version3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RewiredVersion>.NativeClassPtr, "version3");
			RewiredVersion.NativeFieldInfoPtr_version4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RewiredVersion>.NativeClassPtr, "version4");
			RewiredVersion.NativeFieldInfoPtr_unityVersion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RewiredVersion>.NativeClassPtr, "unityVersion");
			RewiredVersion.NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_Int32_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RewiredVersion>.NativeClassPtr, 100663848);
			RewiredVersion.NativeMethodInfoPtr__ctor_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RewiredVersion>.NativeClassPtr, 100663849);
			RewiredVersion.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RewiredVersion>.NativeClassPtr, 100663850);
			RewiredVersion.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RewiredVersion>.NativeClassPtr, 100663851);
			RewiredVersion.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RewiredVersion>.NativeClassPtr, 100663852);
			RewiredVersion.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_RewiredVersion_RewiredVersion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RewiredVersion>.NativeClassPtr, 100663853);
			RewiredVersion.NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_RewiredVersion_RewiredVersion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RewiredVersion>.NativeClassPtr, 100663854);
			RewiredVersion.NativeMethodInfoPtr_op_GreaterThan_Public_Static_Boolean_RewiredVersion_RewiredVersion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RewiredVersion>.NativeClassPtr, 100663855);
			RewiredVersion.NativeMethodInfoPtr_op_LessThan_Public_Static_Boolean_RewiredVersion_RewiredVersion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RewiredVersion>.NativeClassPtr, 100663856);
		}

		// Token: 0x06000365 RID: 869 RVA: 0x0003ADD4 File Offset: 0x00038FD4
		[CallerCount(0)]
		public unsafe RewiredVersion(int version1, int version2, int version3, int version4, string unityVersion)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RewiredVersion>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref version1;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref version2;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref version3;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref version4;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(unityVersion);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RewiredVersion.NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_Int32_Int32_String_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000366 RID: 870 RVA: 0x0003AE60 File Offset: 0x00039060
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 244614, RefRangeEnd = 244615, XrefRangeStart = 244597, XrefRangeEnd = 244614, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RewiredVersion(string versionString)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RewiredVersion>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(versionString);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RewiredVersion.NativeMethodInfoPtr__ctor_Public_Void_String_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000367 RID: 871 RVA: 0x0003AEB0 File Offset: 0x000390B0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 244615, XrefRangeEnd = 244618, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Equals(Object obj)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RewiredVersion.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000368 RID: 872 RVA: 0x0003AF04 File Offset: 0x00039104
		[CallerCount(0)]
		public unsafe override int GetHashCode()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RewiredVersion.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000369 RID: 873 RVA: 0x0003AF48 File Offset: 0x00039148
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 244618, XrefRangeEnd = 244654, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RewiredVersion.NativeMethodInfoPtr_ToString_Public_Virtual_String_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x0600036A RID: 874 RVA: 0x0003AF84 File Offset: 0x00039184
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 244659, RefRangeEnd = 244663, XrefRangeStart = 244654, XrefRangeEnd = 244659, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool operator ==(RewiredVersion a, RewiredVersion b)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(a));
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(b));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RewiredVersion.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_RewiredVersion_RewiredVersion_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600036B RID: 875 RVA: 0x0003AFE4 File Offset: 0x000391E4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 244663, XrefRangeEnd = 244664, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool operator !=(RewiredVersion a, RewiredVersion b)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(a));
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(b));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RewiredVersion.NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_RewiredVersion_RewiredVersion_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600036C RID: 876 RVA: 0x0003B044 File Offset: 0x00039244
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 244664, XrefRangeEnd = 244665, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool operator >(RewiredVersion a, RewiredVersion b)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(a));
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(b));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RewiredVersion.NativeMethodInfoPtr_op_GreaterThan_Public_Static_Boolean_RewiredVersion_RewiredVersion_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600036D RID: 877 RVA: 0x0003B0A4 File Offset: 0x000392A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 244665, XrefRangeEnd = 244666, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool operator <(RewiredVersion a, RewiredVersion b)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(a));
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(b));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RewiredVersion.NativeMethodInfoPtr_op_LessThan_Public_Static_Boolean_RewiredVersion_RewiredVersion_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600036E RID: 878 RVA: 0x000031DB File Offset: 0x000013DB
		public RewiredVersion(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0600036F RID: 879 RVA: 0x000031E4 File Offset: 0x000013E4
		public RewiredVersion()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RewiredVersion>.NativeClassPtr))
		{
		}

		// Token: 0x17000110 RID: 272
		// (get) Token: 0x06000370 RID: 880 RVA: 0x0003B104 File Offset: 0x00039304
		// (set) Token: 0x06000371 RID: 881 RVA: 0x000031F6 File Offset: 0x000013F6
		public unsafe int version1
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RewiredVersion.NativeFieldInfoPtr_version1);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RewiredVersion.NativeFieldInfoPtr_version1)) = value;
			}
		}

		// Token: 0x17000111 RID: 273
		// (get) Token: 0x06000372 RID: 882 RVA: 0x0003B12C File Offset: 0x0003932C
		// (set) Token: 0x06000373 RID: 883 RVA: 0x00003211 File Offset: 0x00001411
		public unsafe int version2
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RewiredVersion.NativeFieldInfoPtr_version2);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RewiredVersion.NativeFieldInfoPtr_version2)) = value;
			}
		}

		// Token: 0x17000112 RID: 274
		// (get) Token: 0x06000374 RID: 884 RVA: 0x0003B154 File Offset: 0x00039354
		// (set) Token: 0x06000375 RID: 885 RVA: 0x0000322C File Offset: 0x0000142C
		public unsafe int version3
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RewiredVersion.NativeFieldInfoPtr_version3);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RewiredVersion.NativeFieldInfoPtr_version3)) = value;
			}
		}

		// Token: 0x17000113 RID: 275
		// (get) Token: 0x06000376 RID: 886 RVA: 0x0003B17C File Offset: 0x0003937C
		// (set) Token: 0x06000377 RID: 887 RVA: 0x00003247 File Offset: 0x00001447
		public unsafe int version4
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RewiredVersion.NativeFieldInfoPtr_version4);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RewiredVersion.NativeFieldInfoPtr_version4)) = value;
			}
		}

		// Token: 0x17000114 RID: 276
		// (get) Token: 0x06000378 RID: 888 RVA: 0x0003B1A4 File Offset: 0x000393A4
		// (set) Token: 0x06000379 RID: 889 RVA: 0x00003262 File Offset: 0x00001462
		public unsafe string unityVersion
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RewiredVersion.NativeFieldInfoPtr_unityVersion);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RewiredVersion.NativeFieldInfoPtr_unityVersion), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x040002E9 RID: 745
		private static readonly IntPtr NativeFieldInfoPtr_version1;

		// Token: 0x040002EA RID: 746
		private static readonly IntPtr NativeFieldInfoPtr_version2;

		// Token: 0x040002EB RID: 747
		private static readonly IntPtr NativeFieldInfoPtr_version3;

		// Token: 0x040002EC RID: 748
		private static readonly IntPtr NativeFieldInfoPtr_version4;

		// Token: 0x040002ED RID: 749
		private static readonly IntPtr NativeFieldInfoPtr_unityVersion;

		// Token: 0x040002EE RID: 750
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_Int32_Int32_String_0;

		// Token: 0x040002EF RID: 751
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_0;

		// Token: 0x040002F0 RID: 752
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

		// Token: 0x040002F1 RID: 753
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

		// Token: 0x040002F2 RID: 754
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

		// Token: 0x040002F3 RID: 755
		private static readonly IntPtr NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_RewiredVersion_RewiredVersion_0;

		// Token: 0x040002F4 RID: 756
		private static readonly IntPtr NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_RewiredVersion_RewiredVersion_0;

		// Token: 0x040002F5 RID: 757
		private static readonly IntPtr NativeMethodInfoPtr_op_GreaterThan_Public_Static_Boolean_RewiredVersion_RewiredVersion_0;

		// Token: 0x040002F6 RID: 758
		private static readonly IntPtr NativeMethodInfoPtr_op_LessThan_Public_Static_Boolean_RewiredVersion_RewiredVersion_0;
	}
}
