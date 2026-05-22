using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Runtime.Serialization.Formatters.Binary
{
	// Token: 0x02000362 RID: 866
	public sealed class BinaryArray : Object
	{
		// Token: 0x06003821 RID: 14369 RVA: 0x00110FF4 File Offset: 0x0010F1F4
		// Note: this type is marked as 'beforefieldinit'.
		static BinaryArray()
		{
			Il2CppClassPointerStore<BinaryArray>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Runtime.Serialization.Formatters.Binary", "BinaryArray");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BinaryArray>.NativeClassPtr);
			BinaryArray.NativeFieldInfoPtr_objectId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BinaryArray>.NativeClassPtr, "objectId");
			BinaryArray.NativeFieldInfoPtr_rank = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BinaryArray>.NativeClassPtr, "rank");
			BinaryArray.NativeFieldInfoPtr_lengthA = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BinaryArray>.NativeClassPtr, "lengthA");
			BinaryArray.NativeFieldInfoPtr_lowerBoundA = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BinaryArray>.NativeClassPtr, "lowerBoundA");
			BinaryArray.NativeFieldInfoPtr_binaryTypeEnum = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BinaryArray>.NativeClassPtr, "binaryTypeEnum");
			BinaryArray.NativeFieldInfoPtr_typeInformation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BinaryArray>.NativeClassPtr, "typeInformation");
			BinaryArray.NativeFieldInfoPtr_assemId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BinaryArray>.NativeClassPtr, "assemId");
			BinaryArray.NativeFieldInfoPtr_binaryHeaderEnum = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BinaryArray>.NativeClassPtr, "binaryHeaderEnum");
			BinaryArray.NativeFieldInfoPtr_binaryArrayTypeEnum = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BinaryArray>.NativeClassPtr, "binaryArrayTypeEnum");
			BinaryArray.NativeMethodInfoPtr__ctor_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BinaryArray>.NativeClassPtr, 100671932);
			BinaryArray.NativeMethodInfoPtr__ctor_Internal_Void_BinaryHeaderEnum_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BinaryArray>.NativeClassPtr, 100671933);
			BinaryArray.NativeMethodInfoPtr_Set_Internal_Void_Int32_Int32_Il2CppStructArray_1_Int32_Il2CppStructArray_1_Int32_BinaryTypeEnum_Object_BinaryArrayTypeEnum_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BinaryArray>.NativeClassPtr, 100671934);
			BinaryArray.NativeMethodInfoPtr_Write_Public_Virtual_Final_New_Void___BinaryWriter_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BinaryArray>.NativeClassPtr, 100671935);
			BinaryArray.NativeMethodInfoPtr_Read_Public_Virtual_Final_New_Void___BinaryParser_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BinaryArray>.NativeClassPtr, 100671936);
		}

		// Token: 0x06003822 RID: 14370 RVA: 0x0011113C File Offset: 0x0010F33C
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe BinaryArray()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BinaryArray>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BinaryArray.NativeMethodInfoPtr__ctor_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003823 RID: 14371 RVA: 0x00111178 File Offset: 0x0010F378
		[CallerCount(0)]
		public unsafe BinaryArray(BinaryHeaderEnum binaryHeaderEnum)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BinaryArray>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref binaryHeaderEnum;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BinaryArray.NativeMethodInfoPtr__ctor_Internal_Void_BinaryHeaderEnum_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06003824 RID: 14372 RVA: 0x001111C0 File Offset: 0x0010F3C0
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 215870, RefRangeEnd = 215873, XrefRangeStart = 215870, XrefRangeEnd = 215870, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Set(int objectId, int rank, Il2CppStructArray<int> lengthA, Il2CppStructArray<int> lowerBoundA, BinaryTypeEnum binaryTypeEnum, Object typeInformation, BinaryArrayTypeEnum binaryArrayTypeEnum, int assemId)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref objectId;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rank;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(lengthA);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(lowerBoundA);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref binaryTypeEnum;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(typeInformation);
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref binaryArrayTypeEnum;
			ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref assemId;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BinaryArray.NativeMethodInfoPtr_Set_Internal_Void_Int32_Int32_Il2CppStructArray_1_Int32_Il2CppStructArray_1_Int32_BinaryTypeEnum_Object_BinaryArrayTypeEnum_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003825 RID: 14373 RVA: 0x00111270 File Offset: 0x0010F470
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 215875, RefRangeEnd = 215878, XrefRangeStart = 215873, XrefRangeEnd = 215875, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Write(__BinaryWriter sout)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(sout);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BinaryArray.NativeMethodInfoPtr_Write_Public_Virtual_Final_New_Void___BinaryWriter_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06003826 RID: 14374 RVA: 0x001112B4 File Offset: 0x0010F4B4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 215895, RefRangeEnd = 215896, XrefRangeStart = 215878, XrefRangeEnd = 215895, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Read(__BinaryParser input)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(input);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BinaryArray.NativeMethodInfoPtr_Read_Public_Virtual_Final_New_Void___BinaryParser_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06003827 RID: 14375 RVA: 0x000141CE File Offset: 0x000123CE
		public BinaryArray(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000D97 RID: 3479
		// (get) Token: 0x06003828 RID: 14376 RVA: 0x001112F8 File Offset: 0x0010F4F8
		// (set) Token: 0x06003829 RID: 14377 RVA: 0x000141D7 File Offset: 0x000123D7
		public unsafe int objectId
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BinaryArray.NativeFieldInfoPtr_objectId);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BinaryArray.NativeFieldInfoPtr_objectId)) = value;
			}
		}

		// Token: 0x17000D98 RID: 3480
		// (get) Token: 0x0600382A RID: 14378 RVA: 0x00111320 File Offset: 0x0010F520
		// (set) Token: 0x0600382B RID: 14379 RVA: 0x000141F2 File Offset: 0x000123F2
		public unsafe int rank
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BinaryArray.NativeFieldInfoPtr_rank);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BinaryArray.NativeFieldInfoPtr_rank)) = value;
			}
		}

		// Token: 0x17000D99 RID: 3481
		// (get) Token: 0x0600382C RID: 14380 RVA: 0x00111348 File Offset: 0x0010F548
		// (set) Token: 0x0600382D RID: 14381 RVA: 0x0001420D File Offset: 0x0001240D
		public unsafe Il2CppStructArray<int> lengthA
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BinaryArray.NativeFieldInfoPtr_lengthA);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BinaryArray.NativeFieldInfoPtr_lengthA), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000D9A RID: 3482
		// (get) Token: 0x0600382E RID: 14382 RVA: 0x00111378 File Offset: 0x0010F578
		// (set) Token: 0x0600382F RID: 14383 RVA: 0x0001422C File Offset: 0x0001242C
		public unsafe Il2CppStructArray<int> lowerBoundA
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BinaryArray.NativeFieldInfoPtr_lowerBoundA);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BinaryArray.NativeFieldInfoPtr_lowerBoundA), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000D9B RID: 3483
		// (get) Token: 0x06003830 RID: 14384 RVA: 0x001113A8 File Offset: 0x0010F5A8
		// (set) Token: 0x06003831 RID: 14385 RVA: 0x0001424B File Offset: 0x0001244B
		public unsafe BinaryTypeEnum binaryTypeEnum
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BinaryArray.NativeFieldInfoPtr_binaryTypeEnum);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BinaryArray.NativeFieldInfoPtr_binaryTypeEnum)) = value;
			}
		}

		// Token: 0x17000D9C RID: 3484
		// (get) Token: 0x06003832 RID: 14386 RVA: 0x001113D0 File Offset: 0x0010F5D0
		// (set) Token: 0x06003833 RID: 14387 RVA: 0x00014266 File Offset: 0x00012466
		public unsafe Object typeInformation
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BinaryArray.NativeFieldInfoPtr_typeInformation);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BinaryArray.NativeFieldInfoPtr_typeInformation), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000D9D RID: 3485
		// (get) Token: 0x06003834 RID: 14388 RVA: 0x00111400 File Offset: 0x0010F600
		// (set) Token: 0x06003835 RID: 14389 RVA: 0x00014285 File Offset: 0x00012485
		public unsafe int assemId
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BinaryArray.NativeFieldInfoPtr_assemId);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BinaryArray.NativeFieldInfoPtr_assemId)) = value;
			}
		}

		// Token: 0x17000D9E RID: 3486
		// (get) Token: 0x06003836 RID: 14390 RVA: 0x00111428 File Offset: 0x0010F628
		// (set) Token: 0x06003837 RID: 14391 RVA: 0x000142A0 File Offset: 0x000124A0
		public unsafe BinaryHeaderEnum binaryHeaderEnum
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BinaryArray.NativeFieldInfoPtr_binaryHeaderEnum);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BinaryArray.NativeFieldInfoPtr_binaryHeaderEnum)) = value;
			}
		}

		// Token: 0x17000D9F RID: 3487
		// (get) Token: 0x06003838 RID: 14392 RVA: 0x00111450 File Offset: 0x0010F650
		// (set) Token: 0x06003839 RID: 14393 RVA: 0x000142BB File Offset: 0x000124BB
		public unsafe BinaryArrayTypeEnum binaryArrayTypeEnum
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BinaryArray.NativeFieldInfoPtr_binaryArrayTypeEnum);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BinaryArray.NativeFieldInfoPtr_binaryArrayTypeEnum)) = value;
			}
		}

		// Token: 0x04002F11 RID: 12049
		private static readonly IntPtr NativeFieldInfoPtr_objectId;

		// Token: 0x04002F12 RID: 12050
		private static readonly IntPtr NativeFieldInfoPtr_rank;

		// Token: 0x04002F13 RID: 12051
		private static readonly IntPtr NativeFieldInfoPtr_lengthA;

		// Token: 0x04002F14 RID: 12052
		private static readonly IntPtr NativeFieldInfoPtr_lowerBoundA;

		// Token: 0x04002F15 RID: 12053
		private static readonly IntPtr NativeFieldInfoPtr_binaryTypeEnum;

		// Token: 0x04002F16 RID: 12054
		private static readonly IntPtr NativeFieldInfoPtr_typeInformation;

		// Token: 0x04002F17 RID: 12055
		private static readonly IntPtr NativeFieldInfoPtr_assemId;

		// Token: 0x04002F18 RID: 12056
		private static readonly IntPtr NativeFieldInfoPtr_binaryHeaderEnum;

		// Token: 0x04002F19 RID: 12057
		private static readonly IntPtr NativeFieldInfoPtr_binaryArrayTypeEnum;

		// Token: 0x04002F1A RID: 12058
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_0;

		// Token: 0x04002F1B RID: 12059
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_BinaryHeaderEnum_0;

		// Token: 0x04002F1C RID: 12060
		private static readonly IntPtr NativeMethodInfoPtr_Set_Internal_Void_Int32_Int32_Il2CppStructArray_1_Int32_Il2CppStructArray_1_Int32_BinaryTypeEnum_Object_BinaryArrayTypeEnum_Int32_0;

		// Token: 0x04002F1D RID: 12061
		private static readonly IntPtr NativeMethodInfoPtr_Write_Public_Virtual_Final_New_Void___BinaryWriter_0;

		// Token: 0x04002F1E RID: 12062
		private static readonly IntPtr NativeMethodInfoPtr_Read_Public_Virtual_Final_New_Void___BinaryParser_0;
	}
}
