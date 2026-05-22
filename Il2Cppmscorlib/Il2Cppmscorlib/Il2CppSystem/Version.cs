using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Text;

namespace Il2CppSystem
{
	// Token: 0x02000104 RID: 260
	[Serializable]
	public sealed class Version : Object
	{
		// Token: 0x06001312 RID: 4882 RVA: 0x0007CE28 File Offset: 0x0007B028
		// Note: this type is marked as 'beforefieldinit'.
		static Version()
		{
			Il2CppClassPointerStore<Version>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System", "Version");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Version>.NativeClassPtr);
			Version.NativeFieldInfoPtr__Major = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Version>.NativeClassPtr, "_Major");
			Version.NativeFieldInfoPtr__Minor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Version>.NativeClassPtr, "_Minor");
			Version.NativeFieldInfoPtr__Build = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Version>.NativeClassPtr, "_Build");
			Version.NativeFieldInfoPtr__Revision = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Version>.NativeClassPtr, "_Revision");
			Version.NativeFieldInfoPtr_SeparatorsArray = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Version>.NativeClassPtr, "SeparatorsArray");
			Version.NativeFieldInfoPtr_ZERO_CHAR_VALUE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Version>.NativeClassPtr, "ZERO_CHAR_VALUE");
			Version.NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Version>.NativeClassPtr, 100666670);
			Version.NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Version>.NativeClassPtr, 100666671);
			Version.NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Version>.NativeClassPtr, 100666672);
			Version.NativeMethodInfoPtr__ctor_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Version>.NativeClassPtr, 100666673);
			Version.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Version>.NativeClassPtr, 100666674);
			Version.NativeMethodInfoPtr_get_Major_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Version>.NativeClassPtr, 100666675);
			Version.NativeMethodInfoPtr_get_Minor_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Version>.NativeClassPtr, 100666676);
			Version.NativeMethodInfoPtr_get_Build_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Version>.NativeClassPtr, 100666677);
			Version.NativeMethodInfoPtr_get_Revision_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Version>.NativeClassPtr, 100666678);
			Version.NativeMethodInfoPtr_Clone_Public_Virtual_Final_New_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Version>.NativeClassPtr, 100666679);
			Version.NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Version>.NativeClassPtr, 100666680);
			Version.NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_Version_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Version>.NativeClassPtr, 100666681);
			Version.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Version>.NativeClassPtr, 100666682);
			Version.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_Version_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Version>.NativeClassPtr, 100666683);
			Version.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Version>.NativeClassPtr, 100666684);
			Version.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Version>.NativeClassPtr, 100666685);
			Version.NativeMethodInfoPtr_ToString_Public_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Version>.NativeClassPtr, 100666686);
			Version.NativeMethodInfoPtr_AppendPositiveNumber_Private_Static_Void_Int32_StringBuilder_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Version>.NativeClassPtr, 100666687);
			Version.NativeMethodInfoPtr_Parse_Public_Static_Version_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Version>.NativeClassPtr, 100666688);
			Version.NativeMethodInfoPtr_TryParseVersion_Private_Static_Boolean_String_byref_VersionResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Version>.NativeClassPtr, 100666689);
			Version.NativeMethodInfoPtr_TryParseComponent_Private_Static_Boolean_String_String_byref_VersionResult_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Version>.NativeClassPtr, 100666690);
			Version.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_Version_Version_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Version>.NativeClassPtr, 100666691);
			Version.NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_Version_Version_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Version>.NativeClassPtr, 100666692);
			Version.NativeMethodInfoPtr_op_LessThan_Public_Static_Boolean_Version_Version_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Version>.NativeClassPtr, 100666693);
		}

		// Token: 0x06001313 RID: 4883 RVA: 0x0007D0B0 File Offset: 0x0007B2B0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 173356, RefRangeEnd = 173358, XrefRangeStart = 173356, XrefRangeEnd = 173356, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Version(int major, int minor, int build, int revision)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Version>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref major;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref minor;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref build;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref revision;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Version.NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001314 RID: 4884 RVA: 0x0007D124 File Offset: 0x0007B324
		[CallerCount(0)]
		public unsafe Version(int major, int minor, int build)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Version>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref major;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref minor;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref build;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Version.NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001315 RID: 4885 RVA: 0x0007D188 File Offset: 0x0007B388
		[CallerCount(0)]
		public unsafe Version(int major, int minor)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Version>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref major;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref minor;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Version.NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001316 RID: 4886 RVA: 0x0007D1E0 File Offset: 0x0007B3E0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 173369, RefRangeEnd = 173370, XrefRangeStart = 173358, XrefRangeEnd = 173369, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Version(string version)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Version>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(version);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Version.NativeMethodInfoPtr__ctor_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001317 RID: 4887 RVA: 0x0007D22C File Offset: 0x0007B42C
		[CallerCount(0)]
		public unsafe Version()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Version>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Version.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000367 RID: 871
		// (get) Token: 0x06001318 RID: 4888 RVA: 0x0007D268 File Offset: 0x0007B468
		public unsafe int Major
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 896, RefRangeEnd = 897, XrefRangeStart = 896, XrefRangeEnd = 897, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Version.NativeMethodInfoPtr_get_Major_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000368 RID: 872
		// (get) Token: 0x06001319 RID: 4889 RVA: 0x0007D2A4 File Offset: 0x0007B4A4
		public unsafe int Minor
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Version.NativeMethodInfoPtr_get_Minor_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000369 RID: 873
		// (get) Token: 0x0600131A RID: 4890 RVA: 0x0007D2E0 File Offset: 0x0007B4E0
		public unsafe int Build
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Version.NativeMethodInfoPtr_get_Build_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700036A RID: 874
		// (get) Token: 0x0600131B RID: 4891 RVA: 0x0007D31C File Offset: 0x0007B51C
		public unsafe int Revision
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Version.NativeMethodInfoPtr_get_Revision_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600131C RID: 4892 RVA: 0x0007D358 File Offset: 0x0007B558
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 173370, XrefRangeEnd = 173373, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Object Clone()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Version.NativeMethodInfoPtr_Clone_Public_Virtual_Final_New_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x0600131D RID: 4893 RVA: 0x0007D398 File Offset: 0x0007B598
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 173373, XrefRangeEnd = 173381, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int CompareTo(Object version)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(version);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Version.NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600131E RID: 4894 RVA: 0x0007D3E8 File Offset: 0x0007B5E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 173381, XrefRangeEnd = 173389, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int CompareTo(Version value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Version.NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_Version_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600131F RID: 4895 RVA: 0x0007D438 File Offset: 0x0007B638
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 173389, XrefRangeEnd = 173397, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Equals(Object obj)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Version.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001320 RID: 4896 RVA: 0x0007D488 File Offset: 0x0007B688
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 173401, RefRangeEnd = 173402, XrefRangeStart = 173397, XrefRangeEnd = 173401, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool Equals(Version obj)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Version.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_Version_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001321 RID: 4897 RVA: 0x0007D4D8 File Offset: 0x0007B6D8
		[CallerCount(0)]
		public unsafe override int GetHashCode()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Version.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001322 RID: 4898 RVA: 0x0007D514 File Offset: 0x0007B714
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 173402, XrefRangeEnd = 173413, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Version.NativeMethodInfoPtr_ToString_Public_Virtual_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06001323 RID: 4899 RVA: 0x0007D54C File Offset: 0x0007B74C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 173440, RefRangeEnd = 173442, XrefRangeStart = 173413, XrefRangeEnd = 173440, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string ToString(int fieldCount)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref fieldCount;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Version.NativeMethodInfoPtr_ToString_Public_String_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06001324 RID: 4900 RVA: 0x0007D590 File Offset: 0x0007B790
		[CallerCount(9)]
		[CachedScanResults(RefRangeStart = 173443, RefRangeEnd = 173452, XrefRangeStart = 173442, XrefRangeEnd = 173443, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void AppendPositiveNumber(int num, StringBuilder sb)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref num;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(sb);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Version.NativeMethodInfoPtr_AppendPositiveNumber_Private_Static_Void_Int32_StringBuilder_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001325 RID: 4901 RVA: 0x0007D5D4 File Offset: 0x0007B7D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 173452, XrefRangeEnd = 173458, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Version Parse(string input)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(input);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Version.NativeMethodInfoPtr_Parse_Public_Static_Version_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Version>(intPtr3) : null;
			}
		}

		// Token: 0x06001326 RID: 4902 RVA: 0x0007D618 File Offset: 0x0007B818
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 173491, RefRangeEnd = 173493, XrefRangeStart = 173458, XrefRangeEnd = 173491, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool TryParseVersion(string version, ref Version.VersionResult result)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(version);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(result));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Version.NativeMethodInfoPtr_TryParseVersion_Private_Static_Boolean_String_byref_VersionResult_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001327 RID: 4903 RVA: 0x0007D674 File Offset: 0x0007B874
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 173506, RefRangeEnd = 173510, XrefRangeStart = 173493, XrefRangeEnd = 173506, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool TryParseComponent(string component, string componentName, ref Version.VersionResult result, out int parsedComponent)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(component);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(componentName);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(result));
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &parsedComponent;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Version.NativeMethodInfoPtr_TryParseComponent_Private_Static_Boolean_String_String_byref_VersionResult_byref_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001328 RID: 4904 RVA: 0x0007D6F0 File Offset: 0x0007B8F0
		[CallerCount(19)]
		[CachedScanResults(RefRangeStart = 173514, RefRangeEnd = 173533, XrefRangeStart = 173510, XrefRangeEnd = 173514, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool operator ==(Version v1, Version v2)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(v1);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(v2);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Version.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_Version_Version_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001329 RID: 4905 RVA: 0x0007D744 File Offset: 0x0007B944
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 173541, RefRangeEnd = 173543, XrefRangeStart = 173533, XrefRangeEnd = 173541, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool operator !=(Version v1, Version v2)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(v1);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(v2);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Version.NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_Version_Version_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600132A RID: 4906 RVA: 0x0007D798 File Offset: 0x0007B998
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 173551, RefRangeEnd = 173552, XrefRangeStart = 173543, XrefRangeEnd = 173551, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool operator <(Version v1, Version v2)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(v1);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(v2);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Version.NativeMethodInfoPtr_op_LessThan_Public_Static_Boolean_Version_Version_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600132B RID: 4907 RVA: 0x00006763 File Offset: 0x00004963
		public Version(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000361 RID: 865
		// (get) Token: 0x0600132C RID: 4908 RVA: 0x0007D7EC File Offset: 0x0007B9EC
		// (set) Token: 0x0600132D RID: 4909 RVA: 0x0000676C File Offset: 0x0000496C
		public unsafe int _Major
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Version.NativeFieldInfoPtr__Major);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Version.NativeFieldInfoPtr__Major)) = value;
			}
		}

		// Token: 0x17000362 RID: 866
		// (get) Token: 0x0600132E RID: 4910 RVA: 0x0007D814 File Offset: 0x0007BA14
		// (set) Token: 0x0600132F RID: 4911 RVA: 0x00006787 File Offset: 0x00004987
		public unsafe int _Minor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Version.NativeFieldInfoPtr__Minor);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Version.NativeFieldInfoPtr__Minor)) = value;
			}
		}

		// Token: 0x17000363 RID: 867
		// (get) Token: 0x06001330 RID: 4912 RVA: 0x0007D83C File Offset: 0x0007BA3C
		// (set) Token: 0x06001331 RID: 4913 RVA: 0x000067A2 File Offset: 0x000049A2
		public unsafe int _Build
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Version.NativeFieldInfoPtr__Build);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Version.NativeFieldInfoPtr__Build)) = value;
			}
		}

		// Token: 0x17000364 RID: 868
		// (get) Token: 0x06001332 RID: 4914 RVA: 0x0007D864 File Offset: 0x0007BA64
		// (set) Token: 0x06001333 RID: 4915 RVA: 0x000067BD File Offset: 0x000049BD
		public unsafe int _Revision
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Version.NativeFieldInfoPtr__Revision);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Version.NativeFieldInfoPtr__Revision)) = value;
			}
		}

		// Token: 0x17000365 RID: 869
		// (get) Token: 0x06001334 RID: 4916 RVA: 0x0007D88C File Offset: 0x0007BA8C
		// (set) Token: 0x06001335 RID: 4917 RVA: 0x000067D8 File Offset: 0x000049D8
		public unsafe static Il2CppStructArray<char> SeparatorsArray
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Version.NativeFieldInfoPtr_SeparatorsArray, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<char>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Version.NativeFieldInfoPtr_SeparatorsArray, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000366 RID: 870
		// (get) Token: 0x06001336 RID: 4918 RVA: 0x0007D8B4 File Offset: 0x0007BAB4
		// (set) Token: 0x06001337 RID: 4919 RVA: 0x000067EA File Offset: 0x000049EA
		public unsafe static int ZERO_CHAR_VALUE
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(Version.NativeFieldInfoPtr_ZERO_CHAR_VALUE, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Version.NativeFieldInfoPtr_ZERO_CHAR_VALUE, (void*)(&value));
			}
		}

		// Token: 0x04001093 RID: 4243
		private static readonly IntPtr NativeFieldInfoPtr__Major;

		// Token: 0x04001094 RID: 4244
		private static readonly IntPtr NativeFieldInfoPtr__Minor;

		// Token: 0x04001095 RID: 4245
		private static readonly IntPtr NativeFieldInfoPtr__Build;

		// Token: 0x04001096 RID: 4246
		private static readonly IntPtr NativeFieldInfoPtr__Revision;

		// Token: 0x04001097 RID: 4247
		private static readonly IntPtr NativeFieldInfoPtr_SeparatorsArray;

		// Token: 0x04001098 RID: 4248
		private static readonly IntPtr NativeFieldInfoPtr_ZERO_CHAR_VALUE;

		// Token: 0x04001099 RID: 4249
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_Int32_Int32_0;

		// Token: 0x0400109A RID: 4250
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_Int32_0;

		// Token: 0x0400109B RID: 4251
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_0;

		// Token: 0x0400109C RID: 4252
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_0;

		// Token: 0x0400109D RID: 4253
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x0400109E RID: 4254
		private static readonly IntPtr NativeMethodInfoPtr_get_Major_Public_get_Int32_0;

		// Token: 0x0400109F RID: 4255
		private static readonly IntPtr NativeMethodInfoPtr_get_Minor_Public_get_Int32_0;

		// Token: 0x040010A0 RID: 4256
		private static readonly IntPtr NativeMethodInfoPtr_get_Build_Public_get_Int32_0;

		// Token: 0x040010A1 RID: 4257
		private static readonly IntPtr NativeMethodInfoPtr_get_Revision_Public_get_Int32_0;

		// Token: 0x040010A2 RID: 4258
		private static readonly IntPtr NativeMethodInfoPtr_Clone_Public_Virtual_Final_New_Object_0;

		// Token: 0x040010A3 RID: 4259
		private static readonly IntPtr NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_Object_0;

		// Token: 0x040010A4 RID: 4260
		private static readonly IntPtr NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_Version_0;

		// Token: 0x040010A5 RID: 4261
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

		// Token: 0x040010A6 RID: 4262
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_Version_0;

		// Token: 0x040010A7 RID: 4263
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

		// Token: 0x040010A8 RID: 4264
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

		// Token: 0x040010A9 RID: 4265
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_String_Int32_0;

		// Token: 0x040010AA RID: 4266
		private static readonly IntPtr NativeMethodInfoPtr_AppendPositiveNumber_Private_Static_Void_Int32_StringBuilder_0;

		// Token: 0x040010AB RID: 4267
		private static readonly IntPtr NativeMethodInfoPtr_Parse_Public_Static_Version_String_0;

		// Token: 0x040010AC RID: 4268
		private static readonly IntPtr NativeMethodInfoPtr_TryParseVersion_Private_Static_Boolean_String_byref_VersionResult_0;

		// Token: 0x040010AD RID: 4269
		private static readonly IntPtr NativeMethodInfoPtr_TryParseComponent_Private_Static_Boolean_String_String_byref_VersionResult_byref_Int32_0;

		// Token: 0x040010AE RID: 4270
		private static readonly IntPtr NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_Version_Version_0;

		// Token: 0x040010AF RID: 4271
		private static readonly IntPtr NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_Version_Version_0;

		// Token: 0x040010B0 RID: 4272
		private static readonly IntPtr NativeMethodInfoPtr_op_LessThan_Public_Static_Boolean_Version_Version_0;

		// Token: 0x020005A6 RID: 1446
		[OriginalName("mscorlib.dll", "", "ParseFailureKind")]
		public enum ParseFailureKind
		{
			// Token: 0x040041E4 RID: 16868
			ArgumentNullException,
			// Token: 0x040041E5 RID: 16869
			ArgumentException,
			// Token: 0x040041E6 RID: 16870
			ArgumentOutOfRangeException,
			// Token: 0x040041E7 RID: 16871
			FormatException
		}

		// Token: 0x020005A7 RID: 1447
		public sealed class VersionResult : ValueType
		{
			// Token: 0x06005122 RID: 20770 RVA: 0x0016FFA8 File Offset: 0x0016E1A8
			// Note: this type is marked as 'beforefieldinit'.
			static VersionResult()
			{
				Il2CppClassPointerStore<Version.VersionResult>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Version>.NativeClassPtr, "VersionResult");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Version.VersionResult>.NativeClassPtr);
				Version.VersionResult.NativeFieldInfoPtr_m_parsedVersion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Version.VersionResult>.NativeClassPtr, "m_parsedVersion");
				Version.VersionResult.NativeFieldInfoPtr_m_failure = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Version.VersionResult>.NativeClassPtr, "m_failure");
				Version.VersionResult.NativeFieldInfoPtr_m_exceptionArgument = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Version.VersionResult>.NativeClassPtr, "m_exceptionArgument");
				Version.VersionResult.NativeFieldInfoPtr_m_argumentName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Version.VersionResult>.NativeClassPtr, "m_argumentName");
				Version.VersionResult.NativeFieldInfoPtr_m_canThrow = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Version.VersionResult>.NativeClassPtr, "m_canThrow");
				Version.VersionResult.NativeMethodInfoPtr_Init_Internal_Void_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Version.VersionResult>.NativeClassPtr, 100666695);
				Version.VersionResult.NativeMethodInfoPtr_SetFailure_Internal_Void_ParseFailureKind_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Version.VersionResult>.NativeClassPtr, 100666696);
				Version.VersionResult.NativeMethodInfoPtr_SetFailure_Internal_Void_ParseFailureKind_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Version.VersionResult>.NativeClassPtr, 100666697);
				Version.VersionResult.NativeMethodInfoPtr_GetVersionParseException_Internal_Exception_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Version.VersionResult>.NativeClassPtr, 100666698);
			}

			// Token: 0x06005123 RID: 20771 RVA: 0x00170088 File Offset: 0x0016E288
			[CallerCount(0)]
			public unsafe void Init(string argumentName, bool canThrow)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(argumentName);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref canThrow;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Version.VersionResult.NativeMethodInfoPtr_Init_Internal_Void_String_Boolean_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06005124 RID: 20772 RVA: 0x001700E0 File Offset: 0x0016E2E0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 173334, XrefRangeEnd = 173337, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void SetFailure(Version.ParseFailureKind failure)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref failure;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Version.VersionResult.NativeMethodInfoPtr_SetFailure_Internal_Void_ParseFailureKind_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06005125 RID: 20773 RVA: 0x00170124 File Offset: 0x0016E324
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 173337, RefRangeEnd = 173339, XrefRangeStart = 173337, XrefRangeEnd = 173337, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void SetFailure(Version.ParseFailureKind failure, string argument)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref failure;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(argument);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Version.VersionResult.NativeMethodInfoPtr_SetFailure_Internal_Void_ParseFailureKind_String_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06005126 RID: 20774 RVA: 0x0017017C File Offset: 0x0016E37C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 173339, XrefRangeEnd = 173356, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Exception GetVersionParseException()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Version.VersionResult.NativeMethodInfoPtr_GetVersionParseException_Internal_Exception_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Exception>(intPtr3) : null;
			}

			// Token: 0x06005127 RID: 20775 RVA: 0x0001E663 File Offset: 0x0001C863
			public VersionResult(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x06005128 RID: 20776 RVA: 0x0001E66C File Offset: 0x0001C86C
			public VersionResult()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Version.VersionResult>.NativeClassPtr))
			{
			}

			// Token: 0x170014BC RID: 5308
			// (get) Token: 0x06005129 RID: 20777 RVA: 0x001701C0 File Offset: 0x0016E3C0
			// (set) Token: 0x0600512A RID: 20778 RVA: 0x0001E67E File Offset: 0x0001C87E
			public unsafe Version m_parsedVersion
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Version.VersionResult.NativeFieldInfoPtr_m_parsedVersion);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Version>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Version.VersionResult.NativeFieldInfoPtr_m_parsedVersion), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170014BD RID: 5309
			// (get) Token: 0x0600512B RID: 20779 RVA: 0x001701F0 File Offset: 0x0016E3F0
			// (set) Token: 0x0600512C RID: 20780 RVA: 0x0001E69D File Offset: 0x0001C89D
			public unsafe Version.ParseFailureKind m_failure
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Version.VersionResult.NativeFieldInfoPtr_m_failure);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Version.VersionResult.NativeFieldInfoPtr_m_failure)) = value;
				}
			}

			// Token: 0x170014BE RID: 5310
			// (get) Token: 0x0600512D RID: 20781 RVA: 0x00170218 File Offset: 0x0016E418
			// (set) Token: 0x0600512E RID: 20782 RVA: 0x0001E6B8 File Offset: 0x0001C8B8
			public unsafe string m_exceptionArgument
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Version.VersionResult.NativeFieldInfoPtr_m_exceptionArgument);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Version.VersionResult.NativeFieldInfoPtr_m_exceptionArgument), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x170014BF RID: 5311
			// (get) Token: 0x0600512F RID: 20783 RVA: 0x00170240 File Offset: 0x0016E440
			// (set) Token: 0x06005130 RID: 20784 RVA: 0x0001E6D7 File Offset: 0x0001C8D7
			public unsafe string m_argumentName
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Version.VersionResult.NativeFieldInfoPtr_m_argumentName);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Version.VersionResult.NativeFieldInfoPtr_m_argumentName), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x170014C0 RID: 5312
			// (get) Token: 0x06005131 RID: 20785 RVA: 0x00170268 File Offset: 0x0016E468
			// (set) Token: 0x06005132 RID: 20786 RVA: 0x0001E6F6 File Offset: 0x0001C8F6
			public unsafe bool m_canThrow
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Version.VersionResult.NativeFieldInfoPtr_m_canThrow);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Version.VersionResult.NativeFieldInfoPtr_m_canThrow)) = value;
				}
			}

			// Token: 0x040041E8 RID: 16872
			private static readonly IntPtr NativeFieldInfoPtr_m_parsedVersion;

			// Token: 0x040041E9 RID: 16873
			private static readonly IntPtr NativeFieldInfoPtr_m_failure;

			// Token: 0x040041EA RID: 16874
			private static readonly IntPtr NativeFieldInfoPtr_m_exceptionArgument;

			// Token: 0x040041EB RID: 16875
			private static readonly IntPtr NativeFieldInfoPtr_m_argumentName;

			// Token: 0x040041EC RID: 16876
			private static readonly IntPtr NativeFieldInfoPtr_m_canThrow;

			// Token: 0x040041ED RID: 16877
			private static readonly IntPtr NativeMethodInfoPtr_Init_Internal_Void_String_Boolean_0;

			// Token: 0x040041EE RID: 16878
			private static readonly IntPtr NativeMethodInfoPtr_SetFailure_Internal_Void_ParseFailureKind_0;

			// Token: 0x040041EF RID: 16879
			private static readonly IntPtr NativeMethodInfoPtr_SetFailure_Internal_Void_ParseFailureKind_String_0;

			// Token: 0x040041F0 RID: 16880
			private static readonly IntPtr NativeMethodInfoPtr_GetVersionParseException_Internal_Exception_0;
		}
	}
}
