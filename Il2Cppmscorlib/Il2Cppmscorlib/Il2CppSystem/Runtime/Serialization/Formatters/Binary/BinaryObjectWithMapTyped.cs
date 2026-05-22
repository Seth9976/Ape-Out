using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Runtime.Serialization.Formatters.Binary
{
	// Token: 0x02000361 RID: 865
	public sealed class BinaryObjectWithMapTyped : Object
	{
		// Token: 0x06003808 RID: 14344 RVA: 0x00110B60 File Offset: 0x0010ED60
		// Note: this type is marked as 'beforefieldinit'.
		static BinaryObjectWithMapTyped()
		{
			Il2CppClassPointerStore<BinaryObjectWithMapTyped>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Runtime.Serialization.Formatters.Binary", "BinaryObjectWithMapTyped");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BinaryObjectWithMapTyped>.NativeClassPtr);
			BinaryObjectWithMapTyped.NativeFieldInfoPtr_binaryHeaderEnum = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BinaryObjectWithMapTyped>.NativeClassPtr, "binaryHeaderEnum");
			BinaryObjectWithMapTyped.NativeFieldInfoPtr_objectId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BinaryObjectWithMapTyped>.NativeClassPtr, "objectId");
			BinaryObjectWithMapTyped.NativeFieldInfoPtr_name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BinaryObjectWithMapTyped>.NativeClassPtr, "name");
			BinaryObjectWithMapTyped.NativeFieldInfoPtr_numMembers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BinaryObjectWithMapTyped>.NativeClassPtr, "numMembers");
			BinaryObjectWithMapTyped.NativeFieldInfoPtr_memberNames = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BinaryObjectWithMapTyped>.NativeClassPtr, "memberNames");
			BinaryObjectWithMapTyped.NativeFieldInfoPtr_binaryTypeEnumA = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BinaryObjectWithMapTyped>.NativeClassPtr, "binaryTypeEnumA");
			BinaryObjectWithMapTyped.NativeFieldInfoPtr_typeInformationA = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BinaryObjectWithMapTyped>.NativeClassPtr, "typeInformationA");
			BinaryObjectWithMapTyped.NativeFieldInfoPtr_memberAssemIds = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BinaryObjectWithMapTyped>.NativeClassPtr, "memberAssemIds");
			BinaryObjectWithMapTyped.NativeFieldInfoPtr_assemId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BinaryObjectWithMapTyped>.NativeClassPtr, "assemId");
			BinaryObjectWithMapTyped.NativeMethodInfoPtr__ctor_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BinaryObjectWithMapTyped>.NativeClassPtr, 100671927);
			BinaryObjectWithMapTyped.NativeMethodInfoPtr__ctor_Internal_Void_BinaryHeaderEnum_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BinaryObjectWithMapTyped>.NativeClassPtr, 100671928);
			BinaryObjectWithMapTyped.NativeMethodInfoPtr_Set_Internal_Void_Int32_String_Int32_Il2CppStringArray_Il2CppStructArray_1_BinaryTypeEnum_Il2CppReferenceArray_1_Object_Il2CppStructArray_1_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BinaryObjectWithMapTyped>.NativeClassPtr, 100671929);
			BinaryObjectWithMapTyped.NativeMethodInfoPtr_Write_Public_Virtual_Final_New_Void___BinaryWriter_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BinaryObjectWithMapTyped>.NativeClassPtr, 100671930);
			BinaryObjectWithMapTyped.NativeMethodInfoPtr_Read_Public_Virtual_Final_New_Void___BinaryParser_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BinaryObjectWithMapTyped>.NativeClassPtr, 100671931);
		}

		// Token: 0x06003809 RID: 14345 RVA: 0x00110CA8 File Offset: 0x0010EEA8
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe BinaryObjectWithMapTyped()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BinaryObjectWithMapTyped>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BinaryObjectWithMapTyped.NativeMethodInfoPtr__ctor_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600380A RID: 14346 RVA: 0x00110CE4 File Offset: 0x0010EEE4
		[CallerCount(0)]
		public unsafe BinaryObjectWithMapTyped(BinaryHeaderEnum binaryHeaderEnum)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BinaryObjectWithMapTyped>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref binaryHeaderEnum;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BinaryObjectWithMapTyped.NativeMethodInfoPtr__ctor_Internal_Void_BinaryHeaderEnum_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600380B RID: 14347 RVA: 0x00110D2C File Offset: 0x0010EF2C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 215846, RefRangeEnd = 215847, XrefRangeStart = 215846, XrefRangeEnd = 215846, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Set(int objectId, string name, int numMembers, Il2CppStringArray memberNames, Il2CppStructArray<BinaryTypeEnum> binaryTypeEnumA, Il2CppReferenceArray<Object> typeInformationA, Il2CppStructArray<int> memberAssemIds, int assemId)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref objectId;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(name);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref numMembers;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(memberNames);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(binaryTypeEnumA);
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(typeInformationA);
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(memberAssemIds);
			ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref assemId;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BinaryObjectWithMapTyped.NativeMethodInfoPtr_Set_Internal_Void_Int32_String_Int32_Il2CppStringArray_Il2CppStructArray_1_BinaryTypeEnum_Il2CppReferenceArray_1_Object_Il2CppStructArray_1_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600380C RID: 14348 RVA: 0x00110DE4 File Offset: 0x0010EFE4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 215848, RefRangeEnd = 215849, XrefRangeStart = 215847, XrefRangeEnd = 215848, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Write(__BinaryWriter sout)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(sout);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BinaryObjectWithMapTyped.NativeMethodInfoPtr_Write_Public_Virtual_Final_New_Void___BinaryWriter_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600380D RID: 14349 RVA: 0x00110E28 File Offset: 0x0010F028
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 215869, RefRangeEnd = 215870, XrefRangeStart = 215849, XrefRangeEnd = 215869, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Read(__BinaryParser input)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(input);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BinaryObjectWithMapTyped.NativeMethodInfoPtr_Read_Public_Virtual_Final_New_Void___BinaryParser_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600380E RID: 14350 RVA: 0x000140BE File Offset: 0x000122BE
		public BinaryObjectWithMapTyped(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000D8E RID: 3470
		// (get) Token: 0x0600380F RID: 14351 RVA: 0x00110E6C File Offset: 0x0010F06C
		// (set) Token: 0x06003810 RID: 14352 RVA: 0x000140C7 File Offset: 0x000122C7
		public unsafe BinaryHeaderEnum binaryHeaderEnum
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BinaryObjectWithMapTyped.NativeFieldInfoPtr_binaryHeaderEnum);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BinaryObjectWithMapTyped.NativeFieldInfoPtr_binaryHeaderEnum)) = value;
			}
		}

		// Token: 0x17000D8F RID: 3471
		// (get) Token: 0x06003811 RID: 14353 RVA: 0x00110E94 File Offset: 0x0010F094
		// (set) Token: 0x06003812 RID: 14354 RVA: 0x000140E2 File Offset: 0x000122E2
		public unsafe int objectId
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BinaryObjectWithMapTyped.NativeFieldInfoPtr_objectId);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BinaryObjectWithMapTyped.NativeFieldInfoPtr_objectId)) = value;
			}
		}

		// Token: 0x17000D90 RID: 3472
		// (get) Token: 0x06003813 RID: 14355 RVA: 0x00110EBC File Offset: 0x0010F0BC
		// (set) Token: 0x06003814 RID: 14356 RVA: 0x000140FD File Offset: 0x000122FD
		public unsafe string name
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BinaryObjectWithMapTyped.NativeFieldInfoPtr_name);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BinaryObjectWithMapTyped.NativeFieldInfoPtr_name), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000D91 RID: 3473
		// (get) Token: 0x06003815 RID: 14357 RVA: 0x00110EE4 File Offset: 0x0010F0E4
		// (set) Token: 0x06003816 RID: 14358 RVA: 0x0001411C File Offset: 0x0001231C
		public unsafe int numMembers
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BinaryObjectWithMapTyped.NativeFieldInfoPtr_numMembers);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BinaryObjectWithMapTyped.NativeFieldInfoPtr_numMembers)) = value;
			}
		}

		// Token: 0x17000D92 RID: 3474
		// (get) Token: 0x06003817 RID: 14359 RVA: 0x00110F0C File Offset: 0x0010F10C
		// (set) Token: 0x06003818 RID: 14360 RVA: 0x00014137 File Offset: 0x00012337
		public unsafe Il2CppStringArray memberNames
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BinaryObjectWithMapTyped.NativeFieldInfoPtr_memberNames);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BinaryObjectWithMapTyped.NativeFieldInfoPtr_memberNames), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000D93 RID: 3475
		// (get) Token: 0x06003819 RID: 14361 RVA: 0x00110F3C File Offset: 0x0010F13C
		// (set) Token: 0x0600381A RID: 14362 RVA: 0x00014156 File Offset: 0x00012356
		public unsafe Il2CppStructArray<BinaryTypeEnum> binaryTypeEnumA
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BinaryObjectWithMapTyped.NativeFieldInfoPtr_binaryTypeEnumA);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<BinaryTypeEnum>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BinaryObjectWithMapTyped.NativeFieldInfoPtr_binaryTypeEnumA), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000D94 RID: 3476
		// (get) Token: 0x0600381B RID: 14363 RVA: 0x00110F6C File Offset: 0x0010F16C
		// (set) Token: 0x0600381C RID: 14364 RVA: 0x00014175 File Offset: 0x00012375
		public unsafe Il2CppReferenceArray<Object> typeInformationA
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BinaryObjectWithMapTyped.NativeFieldInfoPtr_typeInformationA);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Object>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BinaryObjectWithMapTyped.NativeFieldInfoPtr_typeInformationA), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000D95 RID: 3477
		// (get) Token: 0x0600381D RID: 14365 RVA: 0x00110F9C File Offset: 0x0010F19C
		// (set) Token: 0x0600381E RID: 14366 RVA: 0x00014194 File Offset: 0x00012394
		public unsafe Il2CppStructArray<int> memberAssemIds
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BinaryObjectWithMapTyped.NativeFieldInfoPtr_memberAssemIds);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BinaryObjectWithMapTyped.NativeFieldInfoPtr_memberAssemIds), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000D96 RID: 3478
		// (get) Token: 0x0600381F RID: 14367 RVA: 0x00110FCC File Offset: 0x0010F1CC
		// (set) Token: 0x06003820 RID: 14368 RVA: 0x000141B3 File Offset: 0x000123B3
		public unsafe int assemId
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BinaryObjectWithMapTyped.NativeFieldInfoPtr_assemId);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BinaryObjectWithMapTyped.NativeFieldInfoPtr_assemId)) = value;
			}
		}

		// Token: 0x04002F03 RID: 12035
		private static readonly IntPtr NativeFieldInfoPtr_binaryHeaderEnum;

		// Token: 0x04002F04 RID: 12036
		private static readonly IntPtr NativeFieldInfoPtr_objectId;

		// Token: 0x04002F05 RID: 12037
		private static readonly IntPtr NativeFieldInfoPtr_name;

		// Token: 0x04002F06 RID: 12038
		private static readonly IntPtr NativeFieldInfoPtr_numMembers;

		// Token: 0x04002F07 RID: 12039
		private static readonly IntPtr NativeFieldInfoPtr_memberNames;

		// Token: 0x04002F08 RID: 12040
		private static readonly IntPtr NativeFieldInfoPtr_binaryTypeEnumA;

		// Token: 0x04002F09 RID: 12041
		private static readonly IntPtr NativeFieldInfoPtr_typeInformationA;

		// Token: 0x04002F0A RID: 12042
		private static readonly IntPtr NativeFieldInfoPtr_memberAssemIds;

		// Token: 0x04002F0B RID: 12043
		private static readonly IntPtr NativeFieldInfoPtr_assemId;

		// Token: 0x04002F0C RID: 12044
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_0;

		// Token: 0x04002F0D RID: 12045
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_BinaryHeaderEnum_0;

		// Token: 0x04002F0E RID: 12046
		private static readonly IntPtr NativeMethodInfoPtr_Set_Internal_Void_Int32_String_Int32_Il2CppStringArray_Il2CppStructArray_1_BinaryTypeEnum_Il2CppReferenceArray_1_Object_Il2CppStructArray_1_Int32_Int32_0;

		// Token: 0x04002F0F RID: 12047
		private static readonly IntPtr NativeMethodInfoPtr_Write_Public_Virtual_Final_New_Void___BinaryWriter_0;

		// Token: 0x04002F10 RID: 12048
		private static readonly IntPtr NativeMethodInfoPtr_Read_Public_Virtual_Final_New_Void___BinaryParser_0;
	}
}
