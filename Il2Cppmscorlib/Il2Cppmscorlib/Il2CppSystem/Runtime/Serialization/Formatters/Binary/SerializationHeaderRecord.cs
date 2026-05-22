using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;

namespace Il2CppSystem.Runtime.Serialization.Formatters.Binary
{
	// Token: 0x02000356 RID: 854
	public sealed class SerializationHeaderRecord : Object
	{
		// Token: 0x06003771 RID: 14193 RVA: 0x0010EF98 File Offset: 0x0010D198
		// Note: this type is marked as 'beforefieldinit'.
		static SerializationHeaderRecord()
		{
			Il2CppClassPointerStore<SerializationHeaderRecord>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Runtime.Serialization.Formatters.Binary", "SerializationHeaderRecord");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SerializationHeaderRecord>.NativeClassPtr);
			SerializationHeaderRecord.NativeFieldInfoPtr_binaryFormatterMajorVersion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerializationHeaderRecord>.NativeClassPtr, "binaryFormatterMajorVersion");
			SerializationHeaderRecord.NativeFieldInfoPtr_binaryFormatterMinorVersion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerializationHeaderRecord>.NativeClassPtr, "binaryFormatterMinorVersion");
			SerializationHeaderRecord.NativeFieldInfoPtr_binaryHeaderEnum = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerializationHeaderRecord>.NativeClassPtr, "binaryHeaderEnum");
			SerializationHeaderRecord.NativeFieldInfoPtr_topId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerializationHeaderRecord>.NativeClassPtr, "topId");
			SerializationHeaderRecord.NativeFieldInfoPtr_headerId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerializationHeaderRecord>.NativeClassPtr, "headerId");
			SerializationHeaderRecord.NativeFieldInfoPtr_majorVersion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerializationHeaderRecord>.NativeClassPtr, "majorVersion");
			SerializationHeaderRecord.NativeFieldInfoPtr_minorVersion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerializationHeaderRecord>.NativeClassPtr, "minorVersion");
			SerializationHeaderRecord.NativeMethodInfoPtr__ctor_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializationHeaderRecord>.NativeClassPtr, 100671879);
			SerializationHeaderRecord.NativeMethodInfoPtr__ctor_Internal_Void_BinaryHeaderEnum_Int32_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializationHeaderRecord>.NativeClassPtr, 100671880);
			SerializationHeaderRecord.NativeMethodInfoPtr_Write_Public_Virtual_Final_New_Void___BinaryWriter_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializationHeaderRecord>.NativeClassPtr, 100671881);
			SerializationHeaderRecord.NativeMethodInfoPtr_GetInt32_Private_Static_Int32_Il2CppStructArray_1_Byte_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializationHeaderRecord>.NativeClassPtr, 100671882);
			SerializationHeaderRecord.NativeMethodInfoPtr_Read_Public_Virtual_Final_New_Void___BinaryParser_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializationHeaderRecord>.NativeClassPtr, 100671883);
			SerializationHeaderRecord.NativeMethodInfoPtr_Dump_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializationHeaderRecord>.NativeClassPtr, 100671884);
		}

		// Token: 0x06003772 RID: 14194 RVA: 0x0010F0CC File Offset: 0x0010D2CC
		[CallerCount(0)]
		public unsafe SerializationHeaderRecord()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SerializationHeaderRecord>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SerializationHeaderRecord.NativeMethodInfoPtr__ctor_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003773 RID: 14195 RVA: 0x0010F108 File Offset: 0x0010D308
		[CallerCount(0)]
		public unsafe SerializationHeaderRecord(BinaryHeaderEnum binaryHeaderEnum, int topId, int headerId, int majorVersion, int minorVersion)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SerializationHeaderRecord>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref binaryHeaderEnum;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref topId;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref headerId;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref majorVersion;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref minorVersion;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SerializationHeaderRecord.NativeMethodInfoPtr__ctor_Internal_Void_BinaryHeaderEnum_Int32_Int32_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003774 RID: 14196 RVA: 0x0010F188 File Offset: 0x0010D388
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 215788, XrefRangeEnd = 215789, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Write(__BinaryWriter sout)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(sout);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SerializationHeaderRecord.NativeMethodInfoPtr_Write_Public_Virtual_Final_New_Void___BinaryWriter_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06003775 RID: 14197 RVA: 0x0010F1CC File Offset: 0x0010D3CC
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 215789, RefRangeEnd = 215793, XrefRangeStart = 215789, XrefRangeEnd = 215789, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int GetInt32(Il2CppStructArray<byte> buffer, int index)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(buffer);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref index;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SerializationHeaderRecord.NativeMethodInfoPtr_GetInt32_Private_Static_Int32_Il2CppStructArray_1_Byte_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06003776 RID: 14198 RVA: 0x0010F21C File Offset: 0x0010D41C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 215797, RefRangeEnd = 215799, XrefRangeStart = 215793, XrefRangeEnd = 215797, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Read(__BinaryParser input)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(input);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SerializationHeaderRecord.NativeMethodInfoPtr_Read_Public_Virtual_Final_New_Void___BinaryParser_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06003777 RID: 14199 RVA: 0x0010F260 File Offset: 0x0010D460
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Dump()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SerializationHeaderRecord.NativeMethodInfoPtr_Dump_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003778 RID: 14200 RVA: 0x00013BD5 File Offset: 0x00011DD5
		public SerializationHeaderRecord(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000D65 RID: 3429
		// (get) Token: 0x06003779 RID: 14201 RVA: 0x0010F294 File Offset: 0x0010D494
		// (set) Token: 0x0600377A RID: 14202 RVA: 0x00013BDE File Offset: 0x00011DDE
		public unsafe int binaryFormatterMajorVersion
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializationHeaderRecord.NativeFieldInfoPtr_binaryFormatterMajorVersion);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializationHeaderRecord.NativeFieldInfoPtr_binaryFormatterMajorVersion)) = value;
			}
		}

		// Token: 0x17000D66 RID: 3430
		// (get) Token: 0x0600377B RID: 14203 RVA: 0x0010F2BC File Offset: 0x0010D4BC
		// (set) Token: 0x0600377C RID: 14204 RVA: 0x00013BF9 File Offset: 0x00011DF9
		public unsafe int binaryFormatterMinorVersion
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializationHeaderRecord.NativeFieldInfoPtr_binaryFormatterMinorVersion);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializationHeaderRecord.NativeFieldInfoPtr_binaryFormatterMinorVersion)) = value;
			}
		}

		// Token: 0x17000D67 RID: 3431
		// (get) Token: 0x0600377D RID: 14205 RVA: 0x0010F2E4 File Offset: 0x0010D4E4
		// (set) Token: 0x0600377E RID: 14206 RVA: 0x00013C14 File Offset: 0x00011E14
		public unsafe BinaryHeaderEnum binaryHeaderEnum
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializationHeaderRecord.NativeFieldInfoPtr_binaryHeaderEnum);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializationHeaderRecord.NativeFieldInfoPtr_binaryHeaderEnum)) = value;
			}
		}

		// Token: 0x17000D68 RID: 3432
		// (get) Token: 0x0600377F RID: 14207 RVA: 0x0010F30C File Offset: 0x0010D50C
		// (set) Token: 0x06003780 RID: 14208 RVA: 0x00013C2F File Offset: 0x00011E2F
		public unsafe int topId
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializationHeaderRecord.NativeFieldInfoPtr_topId);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializationHeaderRecord.NativeFieldInfoPtr_topId)) = value;
			}
		}

		// Token: 0x17000D69 RID: 3433
		// (get) Token: 0x06003781 RID: 14209 RVA: 0x0010F334 File Offset: 0x0010D534
		// (set) Token: 0x06003782 RID: 14210 RVA: 0x00013C4A File Offset: 0x00011E4A
		public unsafe int headerId
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializationHeaderRecord.NativeFieldInfoPtr_headerId);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializationHeaderRecord.NativeFieldInfoPtr_headerId)) = value;
			}
		}

		// Token: 0x17000D6A RID: 3434
		// (get) Token: 0x06003783 RID: 14211 RVA: 0x0010F35C File Offset: 0x0010D55C
		// (set) Token: 0x06003784 RID: 14212 RVA: 0x00013C65 File Offset: 0x00011E65
		public unsafe int majorVersion
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializationHeaderRecord.NativeFieldInfoPtr_majorVersion);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializationHeaderRecord.NativeFieldInfoPtr_majorVersion)) = value;
			}
		}

		// Token: 0x17000D6B RID: 3435
		// (get) Token: 0x06003785 RID: 14213 RVA: 0x0010F384 File Offset: 0x0010D584
		// (set) Token: 0x06003786 RID: 14214 RVA: 0x00013C80 File Offset: 0x00011E80
		public unsafe int minorVersion
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializationHeaderRecord.NativeFieldInfoPtr_minorVersion);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializationHeaderRecord.NativeFieldInfoPtr_minorVersion)) = value;
			}
		}

		// Token: 0x04002EAB RID: 11947
		private static readonly IntPtr NativeFieldInfoPtr_binaryFormatterMajorVersion;

		// Token: 0x04002EAC RID: 11948
		private static readonly IntPtr NativeFieldInfoPtr_binaryFormatterMinorVersion;

		// Token: 0x04002EAD RID: 11949
		private static readonly IntPtr NativeFieldInfoPtr_binaryHeaderEnum;

		// Token: 0x04002EAE RID: 11950
		private static readonly IntPtr NativeFieldInfoPtr_topId;

		// Token: 0x04002EAF RID: 11951
		private static readonly IntPtr NativeFieldInfoPtr_headerId;

		// Token: 0x04002EB0 RID: 11952
		private static readonly IntPtr NativeFieldInfoPtr_majorVersion;

		// Token: 0x04002EB1 RID: 11953
		private static readonly IntPtr NativeFieldInfoPtr_minorVersion;

		// Token: 0x04002EB2 RID: 11954
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_0;

		// Token: 0x04002EB3 RID: 11955
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_BinaryHeaderEnum_Int32_Int32_Int32_Int32_0;

		// Token: 0x04002EB4 RID: 11956
		private static readonly IntPtr NativeMethodInfoPtr_Write_Public_Virtual_Final_New_Void___BinaryWriter_0;

		// Token: 0x04002EB5 RID: 11957
		private static readonly IntPtr NativeMethodInfoPtr_GetInt32_Private_Static_Int32_Il2CppStructArray_1_Byte_Int32_0;

		// Token: 0x04002EB6 RID: 11958
		private static readonly IntPtr NativeMethodInfoPtr_Read_Public_Virtual_Final_New_Void___BinaryParser_0;

		// Token: 0x04002EB7 RID: 11959
		private static readonly IntPtr NativeMethodInfoPtr_Dump_Public_Void_0;
	}
}
