using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem
{
	// Token: 0x02000139 RID: 313
	public class TermInfoReader : Object
	{
		// Token: 0x060016BB RID: 5819 RVA: 0x0008AF78 File Offset: 0x00089178
		// Note: this type is marked as 'beforefieldinit'.
		static TermInfoReader()
		{
			Il2CppClassPointerStore<TermInfoReader>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System", "TermInfoReader");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TermInfoReader>.NativeClassPtr);
			TermInfoReader.NativeFieldInfoPtr_boolSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TermInfoReader>.NativeClassPtr, "boolSize");
			TermInfoReader.NativeFieldInfoPtr_numSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TermInfoReader>.NativeClassPtr, "numSize");
			TermInfoReader.NativeFieldInfoPtr_strOffsets = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TermInfoReader>.NativeClassPtr, "strOffsets");
			TermInfoReader.NativeFieldInfoPtr_buffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TermInfoReader>.NativeClassPtr, "buffer");
			TermInfoReader.NativeFieldInfoPtr_booleansOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TermInfoReader>.NativeClassPtr, "booleansOffset");
			TermInfoReader.NativeFieldInfoPtr_intOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TermInfoReader>.NativeClassPtr, "intOffset");
			TermInfoReader.NativeMethodInfoPtr__ctor_Public_Void_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TermInfoReader>.NativeClassPtr, 100667185);
			TermInfoReader.NativeMethodInfoPtr__ctor_Public_Void_String_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TermInfoReader>.NativeClassPtr, 100667186);
			TermInfoReader.NativeMethodInfoPtr_DetermineVersion_Private_Void_Int16_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TermInfoReader>.NativeClassPtr, 100667187);
			TermInfoReader.NativeMethodInfoPtr_ReadHeader_Private_Void_Il2CppStructArray_1_Byte_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TermInfoReader>.NativeClassPtr, 100667188);
			TermInfoReader.NativeMethodInfoPtr_ReadNames_Private_Void_Il2CppStructArray_1_Byte_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TermInfoReader>.NativeClassPtr, 100667189);
			TermInfoReader.NativeMethodInfoPtr_Get_Public_Int32_TermInfoNumbers_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TermInfoReader>.NativeClassPtr, 100667190);
			TermInfoReader.NativeMethodInfoPtr_Get_Public_String_TermInfoStrings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TermInfoReader>.NativeClassPtr, 100667191);
			TermInfoReader.NativeMethodInfoPtr_GetStringBytes_Public_Il2CppStructArray_1_Byte_TermInfoStrings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TermInfoReader>.NativeClassPtr, 100667192);
			TermInfoReader.NativeMethodInfoPtr_GetInt16_Private_Int16_Il2CppStructArray_1_Byte_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TermInfoReader>.NativeClassPtr, 100667193);
			TermInfoReader.NativeMethodInfoPtr_GetInt32_Private_Int32_Il2CppStructArray_1_Byte_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TermInfoReader>.NativeClassPtr, 100667194);
			TermInfoReader.NativeMethodInfoPtr_GetInteger_Private_Int32_Il2CppStructArray_1_Byte_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TermInfoReader>.NativeClassPtr, 100667195);
			TermInfoReader.NativeMethodInfoPtr_GetString_Private_String_Il2CppStructArray_1_Byte_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TermInfoReader>.NativeClassPtr, 100667196);
			TermInfoReader.NativeMethodInfoPtr_GetStringBytes_Private_Il2CppStructArray_1_Byte_Il2CppStructArray_1_Byte_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TermInfoReader>.NativeClassPtr, 100667197);
		}

		// Token: 0x060016BC RID: 5820 RVA: 0x0008B124 File Offset: 0x00089324
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 178451, RefRangeEnd = 178452, XrefRangeStart = 178441, XrefRangeEnd = 178451, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TermInfoReader(string term, string filename)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TermInfoReader>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(term);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(filename);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TermInfoReader.NativeMethodInfoPtr__ctor_Public_Void_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060016BD RID: 5821 RVA: 0x0008B184 File Offset: 0x00089384
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 178460, RefRangeEnd = 178463, XrefRangeStart = 178452, XrefRangeEnd = 178460, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TermInfoReader(string term, Il2CppStructArray<byte> buffer)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TermInfoReader>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(term);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(buffer);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TermInfoReader.NativeMethodInfoPtr__ctor_Public_Void_String_Il2CppStructArray_1_Byte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060016BE RID: 5822 RVA: 0x0008B1E4 File Offset: 0x000893E4
		[CallerCount(0)]
		public unsafe void DetermineVersion(short magic)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref magic;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TermInfoReader.NativeMethodInfoPtr_DetermineVersion_Private_Void_Int16_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060016BF RID: 5823 RVA: 0x0008B224 File Offset: 0x00089424
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 178467, RefRangeEnd = 178469, XrefRangeStart = 178463, XrefRangeEnd = 178467, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ReadHeader(Il2CppStructArray<byte> buffer, ref int position)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(buffer);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &position;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TermInfoReader.NativeMethodInfoPtr_ReadHeader_Private_Void_Il2CppStructArray_1_Byte_byref_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060016C0 RID: 5824 RVA: 0x0008B274 File Offset: 0x00089474
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 178471, RefRangeEnd = 178473, XrefRangeStart = 178469, XrefRangeEnd = 178471, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ReadNames(Il2CppStructArray<byte> buffer, ref int position)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(buffer);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &position;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TermInfoReader.NativeMethodInfoPtr_ReadNames_Private_Void_Il2CppStructArray_1_Byte_byref_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060016C1 RID: 5825 RVA: 0x0008B2C4 File Offset: 0x000894C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 178473, XrefRangeEnd = 178474, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int Get(TermInfoNumbers number)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref number;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TermInfoReader.NativeMethodInfoPtr_Get_Public_Int32_TermInfoNumbers_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060016C2 RID: 5826 RVA: 0x0008B310 File Offset: 0x00089510
		[CallerCount(14)]
		[CachedScanResults(RefRangeStart = 178477, RefRangeEnd = 178491, XrefRangeStart = 178474, XrefRangeEnd = 178477, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string Get(TermInfoStrings tstr)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref tstr;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TermInfoReader.NativeMethodInfoPtr_Get_Public_String_TermInfoStrings_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x060016C3 RID: 5827 RVA: 0x0008B354 File Offset: 0x00089554
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 178501, RefRangeEnd = 178503, XrefRangeStart = 178491, XrefRangeEnd = 178501, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Il2CppStructArray<byte> GetStringBytes(TermInfoStrings tstr)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref tstr;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TermInfoReader.NativeMethodInfoPtr_GetStringBytes_Public_Il2CppStructArray_1_Byte_TermInfoStrings_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr3) : null;
			}
		}

		// Token: 0x060016C4 RID: 5828 RVA: 0x0008B3A0 File Offset: 0x000895A0
		[CallerCount(0)]
		public unsafe short GetInt16(Il2CppStructArray<byte> buffer, int offset)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(buffer);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref offset;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TermInfoReader.NativeMethodInfoPtr_GetInt16_Private_Int16_Il2CppStructArray_1_Byte_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060016C5 RID: 5829 RVA: 0x0008B3FC File Offset: 0x000895FC
		[CallerCount(0)]
		public unsafe int GetInt32(Il2CppStructArray<byte> buffer, int offset)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(buffer);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref offset;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TermInfoReader.NativeMethodInfoPtr_GetInt32_Private_Int32_Il2CppStructArray_1_Byte_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060016C6 RID: 5830 RVA: 0x0008B458 File Offset: 0x00089658
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 178503, RefRangeEnd = 178507, XrefRangeStart = 178503, XrefRangeEnd = 178503, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int GetInteger(Il2CppStructArray<byte> buffer, int offset)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(buffer);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref offset;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TermInfoReader.NativeMethodInfoPtr_GetInteger_Private_Int32_Il2CppStructArray_1_Byte_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060016C7 RID: 5831 RVA: 0x0008B4B4 File Offset: 0x000896B4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 178507, XrefRangeEnd = 178509, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string GetString(Il2CppStructArray<byte> buffer, int offset)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(buffer);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref offset;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TermInfoReader.NativeMethodInfoPtr_GetString_Private_String_Il2CppStructArray_1_Byte_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060016C8 RID: 5832 RVA: 0x0008B50C File Offset: 0x0008970C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 178509, XrefRangeEnd = 178518, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Il2CppStructArray<byte> GetStringBytes(Il2CppStructArray<byte> buffer, int offset)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(buffer);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref offset;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TermInfoReader.NativeMethodInfoPtr_GetStringBytes_Private_Il2CppStructArray_1_Byte_Il2CppStructArray_1_Byte_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr3) : null;
		}

		// Token: 0x060016C9 RID: 5833 RVA: 0x00007D6D File Offset: 0x00005F6D
		public TermInfoReader(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000445 RID: 1093
		// (get) Token: 0x060016CA RID: 5834 RVA: 0x0008B56C File Offset: 0x0008976C
		// (set) Token: 0x060016CB RID: 5835 RVA: 0x00007D76 File Offset: 0x00005F76
		public unsafe int boolSize
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TermInfoReader.NativeFieldInfoPtr_boolSize);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TermInfoReader.NativeFieldInfoPtr_boolSize)) = value;
			}
		}

		// Token: 0x17000446 RID: 1094
		// (get) Token: 0x060016CC RID: 5836 RVA: 0x0008B594 File Offset: 0x00089794
		// (set) Token: 0x060016CD RID: 5837 RVA: 0x00007D91 File Offset: 0x00005F91
		public unsafe int numSize
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TermInfoReader.NativeFieldInfoPtr_numSize);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TermInfoReader.NativeFieldInfoPtr_numSize)) = value;
			}
		}

		// Token: 0x17000447 RID: 1095
		// (get) Token: 0x060016CE RID: 5838 RVA: 0x0008B5BC File Offset: 0x000897BC
		// (set) Token: 0x060016CF RID: 5839 RVA: 0x00007DAC File Offset: 0x00005FAC
		public unsafe int strOffsets
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TermInfoReader.NativeFieldInfoPtr_strOffsets);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TermInfoReader.NativeFieldInfoPtr_strOffsets)) = value;
			}
		}

		// Token: 0x17000448 RID: 1096
		// (get) Token: 0x060016D0 RID: 5840 RVA: 0x0008B5E4 File Offset: 0x000897E4
		// (set) Token: 0x060016D1 RID: 5841 RVA: 0x00007DC7 File Offset: 0x00005FC7
		public unsafe Il2CppStructArray<byte> buffer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TermInfoReader.NativeFieldInfoPtr_buffer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TermInfoReader.NativeFieldInfoPtr_buffer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000449 RID: 1097
		// (get) Token: 0x060016D2 RID: 5842 RVA: 0x0008B614 File Offset: 0x00089814
		// (set) Token: 0x060016D3 RID: 5843 RVA: 0x00007DE6 File Offset: 0x00005FE6
		public unsafe int booleansOffset
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TermInfoReader.NativeFieldInfoPtr_booleansOffset);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TermInfoReader.NativeFieldInfoPtr_booleansOffset)) = value;
			}
		}

		// Token: 0x1700044A RID: 1098
		// (get) Token: 0x060016D4 RID: 5844 RVA: 0x0008B63C File Offset: 0x0008983C
		// (set) Token: 0x060016D5 RID: 5845 RVA: 0x00007E01 File Offset: 0x00006001
		public unsafe int intOffset
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TermInfoReader.NativeFieldInfoPtr_intOffset);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TermInfoReader.NativeFieldInfoPtr_intOffset)) = value;
			}
		}

		// Token: 0x04001367 RID: 4967
		private static readonly IntPtr NativeFieldInfoPtr_boolSize;

		// Token: 0x04001368 RID: 4968
		private static readonly IntPtr NativeFieldInfoPtr_numSize;

		// Token: 0x04001369 RID: 4969
		private static readonly IntPtr NativeFieldInfoPtr_strOffsets;

		// Token: 0x0400136A RID: 4970
		private static readonly IntPtr NativeFieldInfoPtr_buffer;

		// Token: 0x0400136B RID: 4971
		private static readonly IntPtr NativeFieldInfoPtr_booleansOffset;

		// Token: 0x0400136C RID: 4972
		private static readonly IntPtr NativeFieldInfoPtr_intOffset;

		// Token: 0x0400136D RID: 4973
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_String_0;

		// Token: 0x0400136E RID: 4974
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_Il2CppStructArray_1_Byte_0;

		// Token: 0x0400136F RID: 4975
		private static readonly IntPtr NativeMethodInfoPtr_DetermineVersion_Private_Void_Int16_0;

		// Token: 0x04001370 RID: 4976
		private static readonly IntPtr NativeMethodInfoPtr_ReadHeader_Private_Void_Il2CppStructArray_1_Byte_byref_Int32_0;

		// Token: 0x04001371 RID: 4977
		private static readonly IntPtr NativeMethodInfoPtr_ReadNames_Private_Void_Il2CppStructArray_1_Byte_byref_Int32_0;

		// Token: 0x04001372 RID: 4978
		private static readonly IntPtr NativeMethodInfoPtr_Get_Public_Int32_TermInfoNumbers_0;

		// Token: 0x04001373 RID: 4979
		private static readonly IntPtr NativeMethodInfoPtr_Get_Public_String_TermInfoStrings_0;

		// Token: 0x04001374 RID: 4980
		private static readonly IntPtr NativeMethodInfoPtr_GetStringBytes_Public_Il2CppStructArray_1_Byte_TermInfoStrings_0;

		// Token: 0x04001375 RID: 4981
		private static readonly IntPtr NativeMethodInfoPtr_GetInt16_Private_Int16_Il2CppStructArray_1_Byte_Int32_0;

		// Token: 0x04001376 RID: 4982
		private static readonly IntPtr NativeMethodInfoPtr_GetInt32_Private_Int32_Il2CppStructArray_1_Byte_Int32_0;

		// Token: 0x04001377 RID: 4983
		private static readonly IntPtr NativeMethodInfoPtr_GetInteger_Private_Int32_Il2CppStructArray_1_Byte_Int32_0;

		// Token: 0x04001378 RID: 4984
		private static readonly IntPtr NativeMethodInfoPtr_GetString_Private_String_Il2CppStructArray_1_Byte_Int32_0;

		// Token: 0x04001379 RID: 4985
		private static readonly IntPtr NativeMethodInfoPtr_GetStringBytes_Private_Il2CppStructArray_1_Byte_Il2CppStructArray_1_Byte_Int32_0;
	}
}
