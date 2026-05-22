using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Runtime.Serialization.Formatters.Binary
{
	// Token: 0x02000368 RID: 872
	public sealed class ObjectProgress : Object
	{
		// Token: 0x0600387C RID: 14460 RVA: 0x00112404 File Offset: 0x00110604
		// Note: this type is marked as 'beforefieldinit'.
		static ObjectProgress()
		{
			Il2CppClassPointerStore<ObjectProgress>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Runtime.Serialization.Formatters.Binary", "ObjectProgress");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ObjectProgress>.NativeClassPtr);
			ObjectProgress.NativeFieldInfoPtr_opRecordIdCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectProgress>.NativeClassPtr, "opRecordIdCount");
			ObjectProgress.NativeFieldInfoPtr_isInitial = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectProgress>.NativeClassPtr, "isInitial");
			ObjectProgress.NativeFieldInfoPtr_count = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectProgress>.NativeClassPtr, "count");
			ObjectProgress.NativeFieldInfoPtr_expectedType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectProgress>.NativeClassPtr, "expectedType");
			ObjectProgress.NativeFieldInfoPtr_expectedTypeInformation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectProgress>.NativeClassPtr, "expectedTypeInformation");
			ObjectProgress.NativeFieldInfoPtr_name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectProgress>.NativeClassPtr, "name");
			ObjectProgress.NativeFieldInfoPtr_objectTypeEnum = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectProgress>.NativeClassPtr, "objectTypeEnum");
			ObjectProgress.NativeFieldInfoPtr_memberTypeEnum = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectProgress>.NativeClassPtr, "memberTypeEnum");
			ObjectProgress.NativeFieldInfoPtr_memberValueEnum = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectProgress>.NativeClassPtr, "memberValueEnum");
			ObjectProgress.NativeFieldInfoPtr_dtType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectProgress>.NativeClassPtr, "dtType");
			ObjectProgress.NativeFieldInfoPtr_numItems = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectProgress>.NativeClassPtr, "numItems");
			ObjectProgress.NativeFieldInfoPtr_binaryTypeEnum = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectProgress>.NativeClassPtr, "binaryTypeEnum");
			ObjectProgress.NativeFieldInfoPtr_typeInformation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectProgress>.NativeClassPtr, "typeInformation");
			ObjectProgress.NativeFieldInfoPtr_nullCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectProgress>.NativeClassPtr, "nullCount");
			ObjectProgress.NativeFieldInfoPtr_memberLength = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectProgress>.NativeClassPtr, "memberLength");
			ObjectProgress.NativeFieldInfoPtr_binaryTypeEnumA = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectProgress>.NativeClassPtr, "binaryTypeEnumA");
			ObjectProgress.NativeFieldInfoPtr_typeInformationA = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectProgress>.NativeClassPtr, "typeInformationA");
			ObjectProgress.NativeFieldInfoPtr_memberNames = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectProgress>.NativeClassPtr, "memberNames");
			ObjectProgress.NativeFieldInfoPtr_memberTypes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectProgress>.NativeClassPtr, "memberTypes");
			ObjectProgress.NativeFieldInfoPtr_pr = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectProgress>.NativeClassPtr, "pr");
			ObjectProgress.NativeMethodInfoPtr__ctor_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectProgress>.NativeClassPtr, 100671963);
			ObjectProgress.NativeMethodInfoPtr_Init_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectProgress>.NativeClassPtr, 100671964);
			ObjectProgress.NativeMethodInfoPtr_ArrayCountIncrement_Internal_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectProgress>.NativeClassPtr, 100671965);
			ObjectProgress.NativeMethodInfoPtr_GetNext_Internal_Boolean_byref_BinaryTypeEnum_byref_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectProgress>.NativeClassPtr, 100671966);
		}

		// Token: 0x0600387D RID: 14461 RVA: 0x00112614 File Offset: 0x00110814
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 215952, XrefRangeEnd = 215955, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ObjectProgress()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ObjectProgress>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectProgress.NativeMethodInfoPtr__ctor_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600387E RID: 14462 RVA: 0x00112650 File Offset: 0x00110850
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 215957, RefRangeEnd = 215958, XrefRangeStart = 215955, XrefRangeEnd = 215957, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Init()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectProgress.NativeMethodInfoPtr_Init_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600387F RID: 14463 RVA: 0x00112684 File Offset: 0x00110884
		[CallerCount(0)]
		public unsafe void ArrayCountIncrement(int value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectProgress.NativeMethodInfoPtr_ArrayCountIncrement_Internal_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06003880 RID: 14464 RVA: 0x001126C4 File Offset: 0x001108C4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 215960, RefRangeEnd = 215961, XrefRangeStart = 215958, XrefRangeEnd = 215960, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool GetNext(out BinaryTypeEnum outBinaryTypeEnum, out Object outTypeInformation)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &outBinaryTypeEnum;
			}
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(ObjectProgress.NativeMethodInfoPtr_GetNext_Internal_Boolean_byref_BinaryTypeEnum_byref_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			outTypeInformation = ((intPtr4 == 0) ? null : new Object(intPtr4));
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x06003881 RID: 14465 RVA: 0x000144C0 File Offset: 0x000126C0
		public ObjectProgress(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000DAF RID: 3503
		// (get) Token: 0x06003882 RID: 14466 RVA: 0x00112730 File Offset: 0x00110930
		// (set) Token: 0x06003883 RID: 14467 RVA: 0x000144C9 File Offset: 0x000126C9
		public unsafe static int opRecordIdCount
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(ObjectProgress.NativeFieldInfoPtr_opRecordIdCount, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ObjectProgress.NativeFieldInfoPtr_opRecordIdCount, (void*)(&value));
			}
		}

		// Token: 0x17000DB0 RID: 3504
		// (get) Token: 0x06003884 RID: 14468 RVA: 0x0011274C File Offset: 0x0011094C
		// (set) Token: 0x06003885 RID: 14469 RVA: 0x000144D7 File Offset: 0x000126D7
		public unsafe bool isInitial
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectProgress.NativeFieldInfoPtr_isInitial);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectProgress.NativeFieldInfoPtr_isInitial)) = value;
			}
		}

		// Token: 0x17000DB1 RID: 3505
		// (get) Token: 0x06003886 RID: 14470 RVA: 0x00112774 File Offset: 0x00110974
		// (set) Token: 0x06003887 RID: 14471 RVA: 0x000144F2 File Offset: 0x000126F2
		public unsafe int count
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectProgress.NativeFieldInfoPtr_count);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectProgress.NativeFieldInfoPtr_count)) = value;
			}
		}

		// Token: 0x17000DB2 RID: 3506
		// (get) Token: 0x06003888 RID: 14472 RVA: 0x0011279C File Offset: 0x0011099C
		// (set) Token: 0x06003889 RID: 14473 RVA: 0x0001450D File Offset: 0x0001270D
		public unsafe BinaryTypeEnum expectedType
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectProgress.NativeFieldInfoPtr_expectedType);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectProgress.NativeFieldInfoPtr_expectedType)) = value;
			}
		}

		// Token: 0x17000DB3 RID: 3507
		// (get) Token: 0x0600388A RID: 14474 RVA: 0x001127C4 File Offset: 0x001109C4
		// (set) Token: 0x0600388B RID: 14475 RVA: 0x00014528 File Offset: 0x00012728
		public unsafe Object expectedTypeInformation
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectProgress.NativeFieldInfoPtr_expectedTypeInformation);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectProgress.NativeFieldInfoPtr_expectedTypeInformation), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000DB4 RID: 3508
		// (get) Token: 0x0600388C RID: 14476 RVA: 0x001127F4 File Offset: 0x001109F4
		// (set) Token: 0x0600388D RID: 14477 RVA: 0x00014547 File Offset: 0x00012747
		public unsafe string name
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectProgress.NativeFieldInfoPtr_name);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectProgress.NativeFieldInfoPtr_name), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000DB5 RID: 3509
		// (get) Token: 0x0600388E RID: 14478 RVA: 0x0011281C File Offset: 0x00110A1C
		// (set) Token: 0x0600388F RID: 14479 RVA: 0x00014566 File Offset: 0x00012766
		public unsafe InternalObjectTypeE objectTypeEnum
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectProgress.NativeFieldInfoPtr_objectTypeEnum);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectProgress.NativeFieldInfoPtr_objectTypeEnum)) = value;
			}
		}

		// Token: 0x17000DB6 RID: 3510
		// (get) Token: 0x06003890 RID: 14480 RVA: 0x00112844 File Offset: 0x00110A44
		// (set) Token: 0x06003891 RID: 14481 RVA: 0x00014581 File Offset: 0x00012781
		public unsafe InternalMemberTypeE memberTypeEnum
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectProgress.NativeFieldInfoPtr_memberTypeEnum);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectProgress.NativeFieldInfoPtr_memberTypeEnum)) = value;
			}
		}

		// Token: 0x17000DB7 RID: 3511
		// (get) Token: 0x06003892 RID: 14482 RVA: 0x0011286C File Offset: 0x00110A6C
		// (set) Token: 0x06003893 RID: 14483 RVA: 0x0001459C File Offset: 0x0001279C
		public unsafe InternalMemberValueE memberValueEnum
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectProgress.NativeFieldInfoPtr_memberValueEnum);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectProgress.NativeFieldInfoPtr_memberValueEnum)) = value;
			}
		}

		// Token: 0x17000DB8 RID: 3512
		// (get) Token: 0x06003894 RID: 14484 RVA: 0x00112894 File Offset: 0x00110A94
		// (set) Token: 0x06003895 RID: 14485 RVA: 0x000145B7 File Offset: 0x000127B7
		public unsafe Type dtType
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectProgress.NativeFieldInfoPtr_dtType);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Type>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectProgress.NativeFieldInfoPtr_dtType), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000DB9 RID: 3513
		// (get) Token: 0x06003896 RID: 14486 RVA: 0x001128C4 File Offset: 0x00110AC4
		// (set) Token: 0x06003897 RID: 14487 RVA: 0x000145D6 File Offset: 0x000127D6
		public unsafe int numItems
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectProgress.NativeFieldInfoPtr_numItems);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectProgress.NativeFieldInfoPtr_numItems)) = value;
			}
		}

		// Token: 0x17000DBA RID: 3514
		// (get) Token: 0x06003898 RID: 14488 RVA: 0x001128EC File Offset: 0x00110AEC
		// (set) Token: 0x06003899 RID: 14489 RVA: 0x000145F1 File Offset: 0x000127F1
		public unsafe BinaryTypeEnum binaryTypeEnum
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectProgress.NativeFieldInfoPtr_binaryTypeEnum);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectProgress.NativeFieldInfoPtr_binaryTypeEnum)) = value;
			}
		}

		// Token: 0x17000DBB RID: 3515
		// (get) Token: 0x0600389A RID: 14490 RVA: 0x00112914 File Offset: 0x00110B14
		// (set) Token: 0x0600389B RID: 14491 RVA: 0x0001460C File Offset: 0x0001280C
		public unsafe Object typeInformation
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectProgress.NativeFieldInfoPtr_typeInformation);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectProgress.NativeFieldInfoPtr_typeInformation), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000DBC RID: 3516
		// (get) Token: 0x0600389C RID: 14492 RVA: 0x00112944 File Offset: 0x00110B44
		// (set) Token: 0x0600389D RID: 14493 RVA: 0x0001462B File Offset: 0x0001282B
		public unsafe int nullCount
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectProgress.NativeFieldInfoPtr_nullCount);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectProgress.NativeFieldInfoPtr_nullCount)) = value;
			}
		}

		// Token: 0x17000DBD RID: 3517
		// (get) Token: 0x0600389E RID: 14494 RVA: 0x0011296C File Offset: 0x00110B6C
		// (set) Token: 0x0600389F RID: 14495 RVA: 0x00014646 File Offset: 0x00012846
		public unsafe int memberLength
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectProgress.NativeFieldInfoPtr_memberLength);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectProgress.NativeFieldInfoPtr_memberLength)) = value;
			}
		}

		// Token: 0x17000DBE RID: 3518
		// (get) Token: 0x060038A0 RID: 14496 RVA: 0x00112994 File Offset: 0x00110B94
		// (set) Token: 0x060038A1 RID: 14497 RVA: 0x00014661 File Offset: 0x00012861
		public unsafe Il2CppStructArray<BinaryTypeEnum> binaryTypeEnumA
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectProgress.NativeFieldInfoPtr_binaryTypeEnumA);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<BinaryTypeEnum>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectProgress.NativeFieldInfoPtr_binaryTypeEnumA), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000DBF RID: 3519
		// (get) Token: 0x060038A2 RID: 14498 RVA: 0x001129C4 File Offset: 0x00110BC4
		// (set) Token: 0x060038A3 RID: 14499 RVA: 0x00014680 File Offset: 0x00012880
		public unsafe Il2CppReferenceArray<Object> typeInformationA
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectProgress.NativeFieldInfoPtr_typeInformationA);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Object>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectProgress.NativeFieldInfoPtr_typeInformationA), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000DC0 RID: 3520
		// (get) Token: 0x060038A4 RID: 14500 RVA: 0x001129F4 File Offset: 0x00110BF4
		// (set) Token: 0x060038A5 RID: 14501 RVA: 0x0001469F File Offset: 0x0001289F
		public unsafe Il2CppStringArray memberNames
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectProgress.NativeFieldInfoPtr_memberNames);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectProgress.NativeFieldInfoPtr_memberNames), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000DC1 RID: 3521
		// (get) Token: 0x060038A6 RID: 14502 RVA: 0x00112A24 File Offset: 0x00110C24
		// (set) Token: 0x060038A7 RID: 14503 RVA: 0x000146BE File Offset: 0x000128BE
		public unsafe Il2CppReferenceArray<Type> memberTypes
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectProgress.NativeFieldInfoPtr_memberTypes);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Type>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectProgress.NativeFieldInfoPtr_memberTypes), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000DC2 RID: 3522
		// (get) Token: 0x060038A8 RID: 14504 RVA: 0x00112A54 File Offset: 0x00110C54
		// (set) Token: 0x060038A9 RID: 14505 RVA: 0x000146DD File Offset: 0x000128DD
		public unsafe ParseRecord pr
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectProgress.NativeFieldInfoPtr_pr);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ParseRecord>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectProgress.NativeFieldInfoPtr_pr), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04002F48 RID: 12104
		private static readonly IntPtr NativeFieldInfoPtr_opRecordIdCount;

		// Token: 0x04002F49 RID: 12105
		private static readonly IntPtr NativeFieldInfoPtr_isInitial;

		// Token: 0x04002F4A RID: 12106
		private static readonly IntPtr NativeFieldInfoPtr_count;

		// Token: 0x04002F4B RID: 12107
		private static readonly IntPtr NativeFieldInfoPtr_expectedType;

		// Token: 0x04002F4C RID: 12108
		private static readonly IntPtr NativeFieldInfoPtr_expectedTypeInformation;

		// Token: 0x04002F4D RID: 12109
		private static readonly IntPtr NativeFieldInfoPtr_name;

		// Token: 0x04002F4E RID: 12110
		private static readonly IntPtr NativeFieldInfoPtr_objectTypeEnum;

		// Token: 0x04002F4F RID: 12111
		private static readonly IntPtr NativeFieldInfoPtr_memberTypeEnum;

		// Token: 0x04002F50 RID: 12112
		private static readonly IntPtr NativeFieldInfoPtr_memberValueEnum;

		// Token: 0x04002F51 RID: 12113
		private static readonly IntPtr NativeFieldInfoPtr_dtType;

		// Token: 0x04002F52 RID: 12114
		private static readonly IntPtr NativeFieldInfoPtr_numItems;

		// Token: 0x04002F53 RID: 12115
		private static readonly IntPtr NativeFieldInfoPtr_binaryTypeEnum;

		// Token: 0x04002F54 RID: 12116
		private static readonly IntPtr NativeFieldInfoPtr_typeInformation;

		// Token: 0x04002F55 RID: 12117
		private static readonly IntPtr NativeFieldInfoPtr_nullCount;

		// Token: 0x04002F56 RID: 12118
		private static readonly IntPtr NativeFieldInfoPtr_memberLength;

		// Token: 0x04002F57 RID: 12119
		private static readonly IntPtr NativeFieldInfoPtr_binaryTypeEnumA;

		// Token: 0x04002F58 RID: 12120
		private static readonly IntPtr NativeFieldInfoPtr_typeInformationA;

		// Token: 0x04002F59 RID: 12121
		private static readonly IntPtr NativeFieldInfoPtr_memberNames;

		// Token: 0x04002F5A RID: 12122
		private static readonly IntPtr NativeFieldInfoPtr_memberTypes;

		// Token: 0x04002F5B RID: 12123
		private static readonly IntPtr NativeFieldInfoPtr_pr;

		// Token: 0x04002F5C RID: 12124
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_0;

		// Token: 0x04002F5D RID: 12125
		private static readonly IntPtr NativeMethodInfoPtr_Init_Internal_Void_0;

		// Token: 0x04002F5E RID: 12126
		private static readonly IntPtr NativeMethodInfoPtr_ArrayCountIncrement_Internal_Void_Int32_0;

		// Token: 0x04002F5F RID: 12127
		private static readonly IntPtr NativeMethodInfoPtr_GetNext_Internal_Boolean_byref_BinaryTypeEnum_byref_Object_0;
	}
}
