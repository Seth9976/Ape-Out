using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Globalization
{
	// Token: 0x02000254 RID: 596
	public sealed class IdnMapping : Object
	{
		// Token: 0x0600298C RID: 10636 RVA: 0x000DADA4 File Offset: 0x000D8FA4
		// Note: this type is marked as 'beforefieldinit'.
		static IdnMapping()
		{
			Il2CppClassPointerStore<IdnMapping>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Globalization", "IdnMapping");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<IdnMapping>.NativeClassPtr);
			IdnMapping.NativeFieldInfoPtr_allow_unassigned = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IdnMapping>.NativeClassPtr, "allow_unassigned");
			IdnMapping.NativeFieldInfoPtr_use_std3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IdnMapping>.NativeClassPtr, "use_std3");
			IdnMapping.NativeFieldInfoPtr_puny = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IdnMapping>.NativeClassPtr, "puny");
			IdnMapping.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IdnMapping>.NativeClassPtr, 100670032);
			IdnMapping.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IdnMapping>.NativeClassPtr, 100670033);
			IdnMapping.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IdnMapping>.NativeClassPtr, 100670034);
			IdnMapping.NativeMethodInfoPtr_GetAscii_Public_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IdnMapping>.NativeClassPtr, 100670035);
			IdnMapping.NativeMethodInfoPtr_GetAscii_Public_String_String_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IdnMapping>.NativeClassPtr, 100670036);
			IdnMapping.NativeMethodInfoPtr_Convert_Private_String_String_Int32_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IdnMapping>.NativeClassPtr, 100670037);
			IdnMapping.NativeMethodInfoPtr_ToAscii_Private_String_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IdnMapping>.NativeClassPtr, 100670038);
			IdnMapping.NativeMethodInfoPtr_VerifyLength_Private_Void_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IdnMapping>.NativeClassPtr, 100670039);
			IdnMapping.NativeMethodInfoPtr_NamePrep_Private_String_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IdnMapping>.NativeClassPtr, 100670040);
			IdnMapping.NativeMethodInfoPtr_VerifyProhibitedCharacters_Private_Void_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IdnMapping>.NativeClassPtr, 100670041);
			IdnMapping.NativeMethodInfoPtr_VerifyStd3AsciiRules_Private_Void_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IdnMapping>.NativeClassPtr, 100670042);
			IdnMapping.NativeMethodInfoPtr_GetUnicode_Public_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IdnMapping>.NativeClassPtr, 100670043);
			IdnMapping.NativeMethodInfoPtr_GetUnicode_Public_String_String_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IdnMapping>.NativeClassPtr, 100670044);
			IdnMapping.NativeMethodInfoPtr_ToUnicode_Private_String_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IdnMapping>.NativeClassPtr, 100670045);
		}

		// Token: 0x0600298D RID: 10637 RVA: 0x000DAF28 File Offset: 0x000D9128
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 199897, RefRangeEnd = 199900, XrefRangeStart = 199894, XrefRangeEnd = 199897, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IdnMapping()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<IdnMapping>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IdnMapping.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600298E RID: 10638 RVA: 0x000DAF64 File Offset: 0x000D9164
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 199900, XrefRangeEnd = 199902, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Equals(Object obj)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IdnMapping.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600298F RID: 10639 RVA: 0x000DAFB4 File Offset: 0x000D91B4
		[CallerCount(0)]
		public unsafe override int GetHashCode()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IdnMapping.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002990 RID: 10640 RVA: 0x000DAFF0 File Offset: 0x000D91F0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 199903, RefRangeEnd = 199904, XrefRangeStart = 199902, XrefRangeEnd = 199903, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string GetAscii(string unicode)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(unicode);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IdnMapping.NativeMethodInfoPtr_GetAscii_Public_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06002991 RID: 10641 RVA: 0x000DB038 File Offset: 0x000D9238
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 199904, XrefRangeEnd = 199905, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string GetAscii(string unicode, int index, int count)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(unicode);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref index;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref count;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IdnMapping.NativeMethodInfoPtr_GetAscii_Public_String_String_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06002992 RID: 10642 RVA: 0x000DB09C File Offset: 0x000D929C
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 199948, RefRangeEnd = 199956, XrefRangeStart = 199905, XrefRangeEnd = 199948, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string Convert(string input, int index, int count, bool toAscii)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(input);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref index;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref count;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref toAscii;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IdnMapping.NativeMethodInfoPtr_Convert_Private_String_String_Int32_Int32_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06002993 RID: 10643 RVA: 0x000DB110 File Offset: 0x000D9310
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 199969, RefRangeEnd = 199971, XrefRangeStart = 199956, XrefRangeEnd = 199969, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string ToAscii(string s, int offset)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(s);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref offset;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IdnMapping.NativeMethodInfoPtr_ToAscii_Private_String_String_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06002994 RID: 10644 RVA: 0x000DB168 File Offset: 0x000D9368
		[CallerCount(0)]
		public unsafe void VerifyLength(string s, int offset)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(s);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref offset;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IdnMapping.NativeMethodInfoPtr_VerifyLength_Private_Void_String_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002995 RID: 10645 RVA: 0x000DB1B8 File Offset: 0x000D93B8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 199978, RefRangeEnd = 199980, XrefRangeStart = 199971, XrefRangeEnd = 199978, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string NamePrep(string s, int offset)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(s);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref offset;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IdnMapping.NativeMethodInfoPtr_NamePrep_Private_String_String_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06002996 RID: 10646 RVA: 0x000DB210 File Offset: 0x000D9410
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 199990, RefRangeEnd = 199991, XrefRangeStart = 199980, XrefRangeEnd = 199990, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void VerifyProhibitedCharacters(string s, int offset)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(s);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref offset;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IdnMapping.NativeMethodInfoPtr_VerifyProhibitedCharacters_Private_Void_String_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002997 RID: 10647 RVA: 0x000DB260 File Offset: 0x000D9460
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 199993, RefRangeEnd = 199994, XrefRangeStart = 199991, XrefRangeEnd = 199993, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void VerifyStd3AsciiRules(string s, int offset)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(s);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref offset;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IdnMapping.NativeMethodInfoPtr_VerifyStd3AsciiRules_Private_Void_String_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002998 RID: 10648 RVA: 0x000DB2B0 File Offset: 0x000D94B0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 199994, XrefRangeEnd = 199995, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string GetUnicode(string ascii)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(ascii);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IdnMapping.NativeMethodInfoPtr_GetUnicode_Public_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06002999 RID: 10649 RVA: 0x000DB2F8 File Offset: 0x000D94F8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 199995, XrefRangeEnd = 199996, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string GetUnicode(string ascii, int index, int count)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(ascii);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref index;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref count;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IdnMapping.NativeMethodInfoPtr_GetUnicode_Public_String_String_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x0600299A RID: 10650 RVA: 0x000DB35C File Offset: 0x000D955C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 200015, RefRangeEnd = 200016, XrefRangeStart = 199996, XrefRangeEnd = 200015, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string ToUnicode(string s, int offset)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(s);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref offset;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IdnMapping.NativeMethodInfoPtr_ToUnicode_Private_String_String_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x0600299B RID: 10651 RVA: 0x0000E42E File Offset: 0x0000C62E
		public IdnMapping(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170009AA RID: 2474
		// (get) Token: 0x0600299C RID: 10652 RVA: 0x000DB3B4 File Offset: 0x000D95B4
		// (set) Token: 0x0600299D RID: 10653 RVA: 0x0000E437 File Offset: 0x0000C637
		public unsafe bool allow_unassigned
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IdnMapping.NativeFieldInfoPtr_allow_unassigned);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IdnMapping.NativeFieldInfoPtr_allow_unassigned)) = value;
			}
		}

		// Token: 0x170009AB RID: 2475
		// (get) Token: 0x0600299E RID: 10654 RVA: 0x000DB3DC File Offset: 0x000D95DC
		// (set) Token: 0x0600299F RID: 10655 RVA: 0x0000E452 File Offset: 0x0000C652
		public unsafe bool use_std3
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IdnMapping.NativeFieldInfoPtr_use_std3);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IdnMapping.NativeFieldInfoPtr_use_std3)) = value;
			}
		}

		// Token: 0x170009AC RID: 2476
		// (get) Token: 0x060029A0 RID: 10656 RVA: 0x000DB404 File Offset: 0x000D9604
		// (set) Token: 0x060029A1 RID: 10657 RVA: 0x0000E46D File Offset: 0x0000C66D
		public unsafe Punycode puny
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IdnMapping.NativeFieldInfoPtr_puny);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Punycode>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(IdnMapping.NativeFieldInfoPtr_puny), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040024BF RID: 9407
		private static readonly IntPtr NativeFieldInfoPtr_allow_unassigned;

		// Token: 0x040024C0 RID: 9408
		private static readonly IntPtr NativeFieldInfoPtr_use_std3;

		// Token: 0x040024C1 RID: 9409
		private static readonly IntPtr NativeFieldInfoPtr_puny;

		// Token: 0x040024C2 RID: 9410
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x040024C3 RID: 9411
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

		// Token: 0x040024C4 RID: 9412
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

		// Token: 0x040024C5 RID: 9413
		private static readonly IntPtr NativeMethodInfoPtr_GetAscii_Public_String_String_0;

		// Token: 0x040024C6 RID: 9414
		private static readonly IntPtr NativeMethodInfoPtr_GetAscii_Public_String_String_Int32_Int32_0;

		// Token: 0x040024C7 RID: 9415
		private static readonly IntPtr NativeMethodInfoPtr_Convert_Private_String_String_Int32_Int32_Boolean_0;

		// Token: 0x040024C8 RID: 9416
		private static readonly IntPtr NativeMethodInfoPtr_ToAscii_Private_String_String_Int32_0;

		// Token: 0x040024C9 RID: 9417
		private static readonly IntPtr NativeMethodInfoPtr_VerifyLength_Private_Void_String_Int32_0;

		// Token: 0x040024CA RID: 9418
		private static readonly IntPtr NativeMethodInfoPtr_NamePrep_Private_String_String_Int32_0;

		// Token: 0x040024CB RID: 9419
		private static readonly IntPtr NativeMethodInfoPtr_VerifyProhibitedCharacters_Private_Void_String_Int32_0;

		// Token: 0x040024CC RID: 9420
		private static readonly IntPtr NativeMethodInfoPtr_VerifyStd3AsciiRules_Private_Void_String_Int32_0;

		// Token: 0x040024CD RID: 9421
		private static readonly IntPtr NativeMethodInfoPtr_GetUnicode_Public_String_String_0;

		// Token: 0x040024CE RID: 9422
		private static readonly IntPtr NativeMethodInfoPtr_GetUnicode_Public_String_String_Int32_Int32_0;

		// Token: 0x040024CF RID: 9423
		private static readonly IntPtr NativeMethodInfoPtr_ToUnicode_Private_String_String_Int32_0;
	}
}
