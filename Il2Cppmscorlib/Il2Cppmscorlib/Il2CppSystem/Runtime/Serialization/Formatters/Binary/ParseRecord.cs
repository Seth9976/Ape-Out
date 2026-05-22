using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Runtime.Serialization.Formatters.Binary
{
	// Token: 0x02000382 RID: 898
	public sealed class ParseRecord : Object
	{
		// Token: 0x06003B34 RID: 15156 RVA: 0x0011BB48 File Offset: 0x00119D48
		// Note: this type is marked as 'beforefieldinit'.
		static ParseRecord()
		{
			Il2CppClassPointerStore<ParseRecord>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Runtime.Serialization.Formatters.Binary", "ParseRecord");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ParseRecord>.NativeClassPtr);
			ParseRecord.NativeFieldInfoPtr_parseRecordIdCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParseRecord>.NativeClassPtr, "parseRecordIdCount");
			ParseRecord.NativeFieldInfoPtr_PRparseTypeEnum = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParseRecord>.NativeClassPtr, "PRparseTypeEnum");
			ParseRecord.NativeFieldInfoPtr_PRobjectTypeEnum = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParseRecord>.NativeClassPtr, "PRobjectTypeEnum");
			ParseRecord.NativeFieldInfoPtr_PRarrayTypeEnum = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParseRecord>.NativeClassPtr, "PRarrayTypeEnum");
			ParseRecord.NativeFieldInfoPtr_PRmemberTypeEnum = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParseRecord>.NativeClassPtr, "PRmemberTypeEnum");
			ParseRecord.NativeFieldInfoPtr_PRmemberValueEnum = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParseRecord>.NativeClassPtr, "PRmemberValueEnum");
			ParseRecord.NativeFieldInfoPtr_PRobjectPositionEnum = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParseRecord>.NativeClassPtr, "PRobjectPositionEnum");
			ParseRecord.NativeFieldInfoPtr_PRname = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParseRecord>.NativeClassPtr, "PRname");
			ParseRecord.NativeFieldInfoPtr_PRvalue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParseRecord>.NativeClassPtr, "PRvalue");
			ParseRecord.NativeFieldInfoPtr_PRvarValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParseRecord>.NativeClassPtr, "PRvarValue");
			ParseRecord.NativeFieldInfoPtr_PRkeyDt = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParseRecord>.NativeClassPtr, "PRkeyDt");
			ParseRecord.NativeFieldInfoPtr_PRdtType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParseRecord>.NativeClassPtr, "PRdtType");
			ParseRecord.NativeFieldInfoPtr_PRdtTypeCode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParseRecord>.NativeClassPtr, "PRdtTypeCode");
			ParseRecord.NativeFieldInfoPtr_PRisEnum = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParseRecord>.NativeClassPtr, "PRisEnum");
			ParseRecord.NativeFieldInfoPtr_PRobjectId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParseRecord>.NativeClassPtr, "PRobjectId");
			ParseRecord.NativeFieldInfoPtr_PRidRef = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParseRecord>.NativeClassPtr, "PRidRef");
			ParseRecord.NativeFieldInfoPtr_PRarrayElementTypeString = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParseRecord>.NativeClassPtr, "PRarrayElementTypeString");
			ParseRecord.NativeFieldInfoPtr_PRarrayElementType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParseRecord>.NativeClassPtr, "PRarrayElementType");
			ParseRecord.NativeFieldInfoPtr_PRisArrayVariant = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParseRecord>.NativeClassPtr, "PRisArrayVariant");
			ParseRecord.NativeFieldInfoPtr_PRarrayElementTypeCode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParseRecord>.NativeClassPtr, "PRarrayElementTypeCode");
			ParseRecord.NativeFieldInfoPtr_PRrank = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParseRecord>.NativeClassPtr, "PRrank");
			ParseRecord.NativeFieldInfoPtr_PRlengthA = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParseRecord>.NativeClassPtr, "PRlengthA");
			ParseRecord.NativeFieldInfoPtr_PRpositionA = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParseRecord>.NativeClassPtr, "PRpositionA");
			ParseRecord.NativeFieldInfoPtr_PRlowerBoundA = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParseRecord>.NativeClassPtr, "PRlowerBoundA");
			ParseRecord.NativeFieldInfoPtr_PRupperBoundA = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParseRecord>.NativeClassPtr, "PRupperBoundA");
			ParseRecord.NativeFieldInfoPtr_PRindexMap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParseRecord>.NativeClassPtr, "PRindexMap");
			ParseRecord.NativeFieldInfoPtr_PRmemberIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParseRecord>.NativeClassPtr, "PRmemberIndex");
			ParseRecord.NativeFieldInfoPtr_PRlinearlength = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParseRecord>.NativeClassPtr, "PRlinearlength");
			ParseRecord.NativeFieldInfoPtr_PRrectangularMap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParseRecord>.NativeClassPtr, "PRrectangularMap");
			ParseRecord.NativeFieldInfoPtr_PRisLowerBound = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParseRecord>.NativeClassPtr, "PRisLowerBound");
			ParseRecord.NativeFieldInfoPtr_PRtopId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParseRecord>.NativeClassPtr, "PRtopId");
			ParseRecord.NativeFieldInfoPtr_PRheaderId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParseRecord>.NativeClassPtr, "PRheaderId");
			ParseRecord.NativeFieldInfoPtr_PRobjectInfo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParseRecord>.NativeClassPtr, "PRobjectInfo");
			ParseRecord.NativeFieldInfoPtr_PRisValueTypeFixup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParseRecord>.NativeClassPtr, "PRisValueTypeFixup");
			ParseRecord.NativeFieldInfoPtr_PRnewObj = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParseRecord>.NativeClassPtr, "PRnewObj");
			ParseRecord.NativeFieldInfoPtr_PRobjectA = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParseRecord>.NativeClassPtr, "PRobjectA");
			ParseRecord.NativeFieldInfoPtr_PRprimitiveArray = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParseRecord>.NativeClassPtr, "PRprimitiveArray");
			ParseRecord.NativeFieldInfoPtr_PRisRegistered = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParseRecord>.NativeClassPtr, "PRisRegistered");
			ParseRecord.NativeFieldInfoPtr_PRmemberData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParseRecord>.NativeClassPtr, "PRmemberData");
			ParseRecord.NativeFieldInfoPtr_PRsi = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParseRecord>.NativeClassPtr, "PRsi");
			ParseRecord.NativeFieldInfoPtr_PRnullCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParseRecord>.NativeClassPtr, "PRnullCount");
			ParseRecord.NativeMethodInfoPtr__ctor_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParseRecord>.NativeClassPtr, 100672206);
			ParseRecord.NativeMethodInfoPtr_Init_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParseRecord>.NativeClassPtr, 100672207);
		}

		// Token: 0x06003B35 RID: 15157 RVA: 0x0011BED4 File Offset: 0x0011A0D4
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ParseRecord()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ParseRecord>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParseRecord.NativeMethodInfoPtr__ctor_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003B36 RID: 15158 RVA: 0x0011BF10 File Offset: 0x0011A110
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 218809, RefRangeEnd = 218816, XrefRangeStart = 218809, XrefRangeEnd = 218809, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Init()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParseRecord.NativeMethodInfoPtr_Init_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003B37 RID: 15159 RVA: 0x00015C5B File Offset: 0x00013E5B
		public ParseRecord(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000E94 RID: 3732
		// (get) Token: 0x06003B38 RID: 15160 RVA: 0x0011BF44 File Offset: 0x0011A144
		// (set) Token: 0x06003B39 RID: 15161 RVA: 0x00015C64 File Offset: 0x00013E64
		public unsafe static int parseRecordIdCount
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(ParseRecord.NativeFieldInfoPtr_parseRecordIdCount, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ParseRecord.NativeFieldInfoPtr_parseRecordIdCount, (void*)(&value));
			}
		}

		// Token: 0x17000E95 RID: 3733
		// (get) Token: 0x06003B3A RID: 15162 RVA: 0x0011BF60 File Offset: 0x0011A160
		// (set) Token: 0x06003B3B RID: 15163 RVA: 0x00015C72 File Offset: 0x00013E72
		public unsafe InternalParseTypeE PRparseTypeEnum
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ParseRecord.NativeFieldInfoPtr_PRparseTypeEnum);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ParseRecord.NativeFieldInfoPtr_PRparseTypeEnum)) = value;
			}
		}

		// Token: 0x17000E96 RID: 3734
		// (get) Token: 0x06003B3C RID: 15164 RVA: 0x0011BF88 File Offset: 0x0011A188
		// (set) Token: 0x06003B3D RID: 15165 RVA: 0x00015C8D File Offset: 0x00013E8D
		public unsafe InternalObjectTypeE PRobjectTypeEnum
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ParseRecord.NativeFieldInfoPtr_PRobjectTypeEnum);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ParseRecord.NativeFieldInfoPtr_PRobjectTypeEnum)) = value;
			}
		}

		// Token: 0x17000E97 RID: 3735
		// (get) Token: 0x06003B3E RID: 15166 RVA: 0x0011BFB0 File Offset: 0x0011A1B0
		// (set) Token: 0x06003B3F RID: 15167 RVA: 0x00015CA8 File Offset: 0x00013EA8
		public unsafe InternalArrayTypeE PRarrayTypeEnum
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ParseRecord.NativeFieldInfoPtr_PRarrayTypeEnum);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ParseRecord.NativeFieldInfoPtr_PRarrayTypeEnum)) = value;
			}
		}

		// Token: 0x17000E98 RID: 3736
		// (get) Token: 0x06003B40 RID: 15168 RVA: 0x0011BFD8 File Offset: 0x0011A1D8
		// (set) Token: 0x06003B41 RID: 15169 RVA: 0x00015CC3 File Offset: 0x00013EC3
		public unsafe InternalMemberTypeE PRmemberTypeEnum
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ParseRecord.NativeFieldInfoPtr_PRmemberTypeEnum);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ParseRecord.NativeFieldInfoPtr_PRmemberTypeEnum)) = value;
			}
		}

		// Token: 0x17000E99 RID: 3737
		// (get) Token: 0x06003B42 RID: 15170 RVA: 0x0011C000 File Offset: 0x0011A200
		// (set) Token: 0x06003B43 RID: 15171 RVA: 0x00015CDE File Offset: 0x00013EDE
		public unsafe InternalMemberValueE PRmemberValueEnum
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ParseRecord.NativeFieldInfoPtr_PRmemberValueEnum);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ParseRecord.NativeFieldInfoPtr_PRmemberValueEnum)) = value;
			}
		}

		// Token: 0x17000E9A RID: 3738
		// (get) Token: 0x06003B44 RID: 15172 RVA: 0x0011C028 File Offset: 0x0011A228
		// (set) Token: 0x06003B45 RID: 15173 RVA: 0x00015CF9 File Offset: 0x00013EF9
		public unsafe InternalObjectPositionE PRobjectPositionEnum
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ParseRecord.NativeFieldInfoPtr_PRobjectPositionEnum);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ParseRecord.NativeFieldInfoPtr_PRobjectPositionEnum)) = value;
			}
		}

		// Token: 0x17000E9B RID: 3739
		// (get) Token: 0x06003B46 RID: 15174 RVA: 0x0011C050 File Offset: 0x0011A250
		// (set) Token: 0x06003B47 RID: 15175 RVA: 0x00015D14 File Offset: 0x00013F14
		public unsafe string PRname
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ParseRecord.NativeFieldInfoPtr_PRname);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ParseRecord.NativeFieldInfoPtr_PRname), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000E9C RID: 3740
		// (get) Token: 0x06003B48 RID: 15176 RVA: 0x0011C078 File Offset: 0x0011A278
		// (set) Token: 0x06003B49 RID: 15177 RVA: 0x00015D33 File Offset: 0x00013F33
		public unsafe string PRvalue
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ParseRecord.NativeFieldInfoPtr_PRvalue);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ParseRecord.NativeFieldInfoPtr_PRvalue), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000E9D RID: 3741
		// (get) Token: 0x06003B4A RID: 15178 RVA: 0x0011C0A0 File Offset: 0x0011A2A0
		// (set) Token: 0x06003B4B RID: 15179 RVA: 0x00015D52 File Offset: 0x00013F52
		public unsafe Object PRvarValue
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ParseRecord.NativeFieldInfoPtr_PRvarValue);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ParseRecord.NativeFieldInfoPtr_PRvarValue), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000E9E RID: 3742
		// (get) Token: 0x06003B4C RID: 15180 RVA: 0x0011C0D0 File Offset: 0x0011A2D0
		// (set) Token: 0x06003B4D RID: 15181 RVA: 0x00015D71 File Offset: 0x00013F71
		public unsafe string PRkeyDt
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ParseRecord.NativeFieldInfoPtr_PRkeyDt);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ParseRecord.NativeFieldInfoPtr_PRkeyDt), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000E9F RID: 3743
		// (get) Token: 0x06003B4E RID: 15182 RVA: 0x0011C0F8 File Offset: 0x0011A2F8
		// (set) Token: 0x06003B4F RID: 15183 RVA: 0x00015D90 File Offset: 0x00013F90
		public unsafe Type PRdtType
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ParseRecord.NativeFieldInfoPtr_PRdtType);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Type>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ParseRecord.NativeFieldInfoPtr_PRdtType), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000EA0 RID: 3744
		// (get) Token: 0x06003B50 RID: 15184 RVA: 0x0011C128 File Offset: 0x0011A328
		// (set) Token: 0x06003B51 RID: 15185 RVA: 0x00015DAF File Offset: 0x00013FAF
		public unsafe InternalPrimitiveTypeE PRdtTypeCode
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ParseRecord.NativeFieldInfoPtr_PRdtTypeCode);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ParseRecord.NativeFieldInfoPtr_PRdtTypeCode)) = value;
			}
		}

		// Token: 0x17000EA1 RID: 3745
		// (get) Token: 0x06003B52 RID: 15186 RVA: 0x0011C150 File Offset: 0x0011A350
		// (set) Token: 0x06003B53 RID: 15187 RVA: 0x00015DCA File Offset: 0x00013FCA
		public unsafe bool PRisEnum
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ParseRecord.NativeFieldInfoPtr_PRisEnum);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ParseRecord.NativeFieldInfoPtr_PRisEnum)) = value;
			}
		}

		// Token: 0x17000EA2 RID: 3746
		// (get) Token: 0x06003B54 RID: 15188 RVA: 0x0011C178 File Offset: 0x0011A378
		// (set) Token: 0x06003B55 RID: 15189 RVA: 0x00015DE5 File Offset: 0x00013FE5
		public unsafe long PRobjectId
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ParseRecord.NativeFieldInfoPtr_PRobjectId);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ParseRecord.NativeFieldInfoPtr_PRobjectId)) = value;
			}
		}

		// Token: 0x17000EA3 RID: 3747
		// (get) Token: 0x06003B56 RID: 15190 RVA: 0x0011C1A0 File Offset: 0x0011A3A0
		// (set) Token: 0x06003B57 RID: 15191 RVA: 0x00015E00 File Offset: 0x00014000
		public unsafe long PRidRef
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ParseRecord.NativeFieldInfoPtr_PRidRef);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ParseRecord.NativeFieldInfoPtr_PRidRef)) = value;
			}
		}

		// Token: 0x17000EA4 RID: 3748
		// (get) Token: 0x06003B58 RID: 15192 RVA: 0x0011C1C8 File Offset: 0x0011A3C8
		// (set) Token: 0x06003B59 RID: 15193 RVA: 0x00015E1B File Offset: 0x0001401B
		public unsafe string PRarrayElementTypeString
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ParseRecord.NativeFieldInfoPtr_PRarrayElementTypeString);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ParseRecord.NativeFieldInfoPtr_PRarrayElementTypeString), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000EA5 RID: 3749
		// (get) Token: 0x06003B5A RID: 15194 RVA: 0x0011C1F0 File Offset: 0x0011A3F0
		// (set) Token: 0x06003B5B RID: 15195 RVA: 0x00015E3A File Offset: 0x0001403A
		public unsafe Type PRarrayElementType
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ParseRecord.NativeFieldInfoPtr_PRarrayElementType);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Type>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ParseRecord.NativeFieldInfoPtr_PRarrayElementType), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000EA6 RID: 3750
		// (get) Token: 0x06003B5C RID: 15196 RVA: 0x0011C220 File Offset: 0x0011A420
		// (set) Token: 0x06003B5D RID: 15197 RVA: 0x00015E59 File Offset: 0x00014059
		public unsafe bool PRisArrayVariant
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ParseRecord.NativeFieldInfoPtr_PRisArrayVariant);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ParseRecord.NativeFieldInfoPtr_PRisArrayVariant)) = value;
			}
		}

		// Token: 0x17000EA7 RID: 3751
		// (get) Token: 0x06003B5E RID: 15198 RVA: 0x0011C248 File Offset: 0x0011A448
		// (set) Token: 0x06003B5F RID: 15199 RVA: 0x00015E74 File Offset: 0x00014074
		public unsafe InternalPrimitiveTypeE PRarrayElementTypeCode
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ParseRecord.NativeFieldInfoPtr_PRarrayElementTypeCode);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ParseRecord.NativeFieldInfoPtr_PRarrayElementTypeCode)) = value;
			}
		}

		// Token: 0x17000EA8 RID: 3752
		// (get) Token: 0x06003B60 RID: 15200 RVA: 0x0011C270 File Offset: 0x0011A470
		// (set) Token: 0x06003B61 RID: 15201 RVA: 0x00015E8F File Offset: 0x0001408F
		public unsafe int PRrank
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ParseRecord.NativeFieldInfoPtr_PRrank);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ParseRecord.NativeFieldInfoPtr_PRrank)) = value;
			}
		}

		// Token: 0x17000EA9 RID: 3753
		// (get) Token: 0x06003B62 RID: 15202 RVA: 0x0011C298 File Offset: 0x0011A498
		// (set) Token: 0x06003B63 RID: 15203 RVA: 0x00015EAA File Offset: 0x000140AA
		public unsafe Il2CppStructArray<int> PRlengthA
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ParseRecord.NativeFieldInfoPtr_PRlengthA);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ParseRecord.NativeFieldInfoPtr_PRlengthA), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000EAA RID: 3754
		// (get) Token: 0x06003B64 RID: 15204 RVA: 0x0011C2C8 File Offset: 0x0011A4C8
		// (set) Token: 0x06003B65 RID: 15205 RVA: 0x00015EC9 File Offset: 0x000140C9
		public unsafe Il2CppStructArray<int> PRpositionA
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ParseRecord.NativeFieldInfoPtr_PRpositionA);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ParseRecord.NativeFieldInfoPtr_PRpositionA), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000EAB RID: 3755
		// (get) Token: 0x06003B66 RID: 15206 RVA: 0x0011C2F8 File Offset: 0x0011A4F8
		// (set) Token: 0x06003B67 RID: 15207 RVA: 0x00015EE8 File Offset: 0x000140E8
		public unsafe Il2CppStructArray<int> PRlowerBoundA
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ParseRecord.NativeFieldInfoPtr_PRlowerBoundA);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ParseRecord.NativeFieldInfoPtr_PRlowerBoundA), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000EAC RID: 3756
		// (get) Token: 0x06003B68 RID: 15208 RVA: 0x0011C328 File Offset: 0x0011A528
		// (set) Token: 0x06003B69 RID: 15209 RVA: 0x00015F07 File Offset: 0x00014107
		public unsafe Il2CppStructArray<int> PRupperBoundA
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ParseRecord.NativeFieldInfoPtr_PRupperBoundA);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ParseRecord.NativeFieldInfoPtr_PRupperBoundA), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000EAD RID: 3757
		// (get) Token: 0x06003B6A RID: 15210 RVA: 0x0011C358 File Offset: 0x0011A558
		// (set) Token: 0x06003B6B RID: 15211 RVA: 0x00015F26 File Offset: 0x00014126
		public unsafe Il2CppStructArray<int> PRindexMap
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ParseRecord.NativeFieldInfoPtr_PRindexMap);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ParseRecord.NativeFieldInfoPtr_PRindexMap), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000EAE RID: 3758
		// (get) Token: 0x06003B6C RID: 15212 RVA: 0x0011C388 File Offset: 0x0011A588
		// (set) Token: 0x06003B6D RID: 15213 RVA: 0x00015F45 File Offset: 0x00014145
		public unsafe int PRmemberIndex
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ParseRecord.NativeFieldInfoPtr_PRmemberIndex);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ParseRecord.NativeFieldInfoPtr_PRmemberIndex)) = value;
			}
		}

		// Token: 0x17000EAF RID: 3759
		// (get) Token: 0x06003B6E RID: 15214 RVA: 0x0011C3B0 File Offset: 0x0011A5B0
		// (set) Token: 0x06003B6F RID: 15215 RVA: 0x00015F60 File Offset: 0x00014160
		public unsafe int PRlinearlength
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ParseRecord.NativeFieldInfoPtr_PRlinearlength);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ParseRecord.NativeFieldInfoPtr_PRlinearlength)) = value;
			}
		}

		// Token: 0x17000EB0 RID: 3760
		// (get) Token: 0x06003B70 RID: 15216 RVA: 0x0011C3D8 File Offset: 0x0011A5D8
		// (set) Token: 0x06003B71 RID: 15217 RVA: 0x00015F7B File Offset: 0x0001417B
		public unsafe Il2CppStructArray<int> PRrectangularMap
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ParseRecord.NativeFieldInfoPtr_PRrectangularMap);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ParseRecord.NativeFieldInfoPtr_PRrectangularMap), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000EB1 RID: 3761
		// (get) Token: 0x06003B72 RID: 15218 RVA: 0x0011C408 File Offset: 0x0011A608
		// (set) Token: 0x06003B73 RID: 15219 RVA: 0x00015F9A File Offset: 0x0001419A
		public unsafe bool PRisLowerBound
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ParseRecord.NativeFieldInfoPtr_PRisLowerBound);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ParseRecord.NativeFieldInfoPtr_PRisLowerBound)) = value;
			}
		}

		// Token: 0x17000EB2 RID: 3762
		// (get) Token: 0x06003B74 RID: 15220 RVA: 0x0011C430 File Offset: 0x0011A630
		// (set) Token: 0x06003B75 RID: 15221 RVA: 0x00015FB5 File Offset: 0x000141B5
		public unsafe long PRtopId
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ParseRecord.NativeFieldInfoPtr_PRtopId);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ParseRecord.NativeFieldInfoPtr_PRtopId)) = value;
			}
		}

		// Token: 0x17000EB3 RID: 3763
		// (get) Token: 0x06003B76 RID: 15222 RVA: 0x0011C458 File Offset: 0x0011A658
		// (set) Token: 0x06003B77 RID: 15223 RVA: 0x00015FD0 File Offset: 0x000141D0
		public unsafe long PRheaderId
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ParseRecord.NativeFieldInfoPtr_PRheaderId);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ParseRecord.NativeFieldInfoPtr_PRheaderId)) = value;
			}
		}

		// Token: 0x17000EB4 RID: 3764
		// (get) Token: 0x06003B78 RID: 15224 RVA: 0x0011C480 File Offset: 0x0011A680
		// (set) Token: 0x06003B79 RID: 15225 RVA: 0x00015FEB File Offset: 0x000141EB
		public unsafe ReadObjectInfo PRobjectInfo
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ParseRecord.NativeFieldInfoPtr_PRobjectInfo);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ReadObjectInfo>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ParseRecord.NativeFieldInfoPtr_PRobjectInfo), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000EB5 RID: 3765
		// (get) Token: 0x06003B7A RID: 15226 RVA: 0x0011C4B0 File Offset: 0x0011A6B0
		// (set) Token: 0x06003B7B RID: 15227 RVA: 0x0001600A File Offset: 0x0001420A
		public unsafe bool PRisValueTypeFixup
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ParseRecord.NativeFieldInfoPtr_PRisValueTypeFixup);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ParseRecord.NativeFieldInfoPtr_PRisValueTypeFixup)) = value;
			}
		}

		// Token: 0x17000EB6 RID: 3766
		// (get) Token: 0x06003B7C RID: 15228 RVA: 0x0011C4D8 File Offset: 0x0011A6D8
		// (set) Token: 0x06003B7D RID: 15229 RVA: 0x00016025 File Offset: 0x00014225
		public unsafe Object PRnewObj
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ParseRecord.NativeFieldInfoPtr_PRnewObj);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ParseRecord.NativeFieldInfoPtr_PRnewObj), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000EB7 RID: 3767
		// (get) Token: 0x06003B7E RID: 15230 RVA: 0x0011C508 File Offset: 0x0011A708
		// (set) Token: 0x06003B7F RID: 15231 RVA: 0x00016044 File Offset: 0x00014244
		public unsafe Il2CppReferenceArray<Object> PRobjectA
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ParseRecord.NativeFieldInfoPtr_PRobjectA);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Object>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ParseRecord.NativeFieldInfoPtr_PRobjectA), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000EB8 RID: 3768
		// (get) Token: 0x06003B80 RID: 15232 RVA: 0x0011C538 File Offset: 0x0011A738
		// (set) Token: 0x06003B81 RID: 15233 RVA: 0x00016063 File Offset: 0x00014263
		public unsafe PrimitiveArray PRprimitiveArray
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ParseRecord.NativeFieldInfoPtr_PRprimitiveArray);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<PrimitiveArray>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ParseRecord.NativeFieldInfoPtr_PRprimitiveArray), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000EB9 RID: 3769
		// (get) Token: 0x06003B82 RID: 15234 RVA: 0x0011C568 File Offset: 0x0011A768
		// (set) Token: 0x06003B83 RID: 15235 RVA: 0x00016082 File Offset: 0x00014282
		public unsafe bool PRisRegistered
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ParseRecord.NativeFieldInfoPtr_PRisRegistered);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ParseRecord.NativeFieldInfoPtr_PRisRegistered)) = value;
			}
		}

		// Token: 0x17000EBA RID: 3770
		// (get) Token: 0x06003B84 RID: 15236 RVA: 0x0011C590 File Offset: 0x0011A790
		// (set) Token: 0x06003B85 RID: 15237 RVA: 0x0001609D File Offset: 0x0001429D
		public unsafe Il2CppReferenceArray<Object> PRmemberData
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ParseRecord.NativeFieldInfoPtr_PRmemberData);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Object>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ParseRecord.NativeFieldInfoPtr_PRmemberData), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000EBB RID: 3771
		// (get) Token: 0x06003B86 RID: 15238 RVA: 0x0011C5C0 File Offset: 0x0011A7C0
		// (set) Token: 0x06003B87 RID: 15239 RVA: 0x000160BC File Offset: 0x000142BC
		public unsafe SerializationInfo PRsi
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ParseRecord.NativeFieldInfoPtr_PRsi);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SerializationInfo>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ParseRecord.NativeFieldInfoPtr_PRsi), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000EBC RID: 3772
		// (get) Token: 0x06003B88 RID: 15240 RVA: 0x0011C5F0 File Offset: 0x0011A7F0
		// (set) Token: 0x06003B89 RID: 15241 RVA: 0x000160DB File Offset: 0x000142DB
		public unsafe int PRnullCount
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ParseRecord.NativeFieldInfoPtr_PRnullCount);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ParseRecord.NativeFieldInfoPtr_PRnullCount)) = value;
			}
		}

		// Token: 0x04003189 RID: 12681
		private static readonly IntPtr NativeFieldInfoPtr_parseRecordIdCount;

		// Token: 0x0400318A RID: 12682
		private static readonly IntPtr NativeFieldInfoPtr_PRparseTypeEnum;

		// Token: 0x0400318B RID: 12683
		private static readonly IntPtr NativeFieldInfoPtr_PRobjectTypeEnum;

		// Token: 0x0400318C RID: 12684
		private static readonly IntPtr NativeFieldInfoPtr_PRarrayTypeEnum;

		// Token: 0x0400318D RID: 12685
		private static readonly IntPtr NativeFieldInfoPtr_PRmemberTypeEnum;

		// Token: 0x0400318E RID: 12686
		private static readonly IntPtr NativeFieldInfoPtr_PRmemberValueEnum;

		// Token: 0x0400318F RID: 12687
		private static readonly IntPtr NativeFieldInfoPtr_PRobjectPositionEnum;

		// Token: 0x04003190 RID: 12688
		private static readonly IntPtr NativeFieldInfoPtr_PRname;

		// Token: 0x04003191 RID: 12689
		private static readonly IntPtr NativeFieldInfoPtr_PRvalue;

		// Token: 0x04003192 RID: 12690
		private static readonly IntPtr NativeFieldInfoPtr_PRvarValue;

		// Token: 0x04003193 RID: 12691
		private static readonly IntPtr NativeFieldInfoPtr_PRkeyDt;

		// Token: 0x04003194 RID: 12692
		private static readonly IntPtr NativeFieldInfoPtr_PRdtType;

		// Token: 0x04003195 RID: 12693
		private static readonly IntPtr NativeFieldInfoPtr_PRdtTypeCode;

		// Token: 0x04003196 RID: 12694
		private static readonly IntPtr NativeFieldInfoPtr_PRisEnum;

		// Token: 0x04003197 RID: 12695
		private static readonly IntPtr NativeFieldInfoPtr_PRobjectId;

		// Token: 0x04003198 RID: 12696
		private static readonly IntPtr NativeFieldInfoPtr_PRidRef;

		// Token: 0x04003199 RID: 12697
		private static readonly IntPtr NativeFieldInfoPtr_PRarrayElementTypeString;

		// Token: 0x0400319A RID: 12698
		private static readonly IntPtr NativeFieldInfoPtr_PRarrayElementType;

		// Token: 0x0400319B RID: 12699
		private static readonly IntPtr NativeFieldInfoPtr_PRisArrayVariant;

		// Token: 0x0400319C RID: 12700
		private static readonly IntPtr NativeFieldInfoPtr_PRarrayElementTypeCode;

		// Token: 0x0400319D RID: 12701
		private static readonly IntPtr NativeFieldInfoPtr_PRrank;

		// Token: 0x0400319E RID: 12702
		private static readonly IntPtr NativeFieldInfoPtr_PRlengthA;

		// Token: 0x0400319F RID: 12703
		private static readonly IntPtr NativeFieldInfoPtr_PRpositionA;

		// Token: 0x040031A0 RID: 12704
		private static readonly IntPtr NativeFieldInfoPtr_PRlowerBoundA;

		// Token: 0x040031A1 RID: 12705
		private static readonly IntPtr NativeFieldInfoPtr_PRupperBoundA;

		// Token: 0x040031A2 RID: 12706
		private static readonly IntPtr NativeFieldInfoPtr_PRindexMap;

		// Token: 0x040031A3 RID: 12707
		private static readonly IntPtr NativeFieldInfoPtr_PRmemberIndex;

		// Token: 0x040031A4 RID: 12708
		private static readonly IntPtr NativeFieldInfoPtr_PRlinearlength;

		// Token: 0x040031A5 RID: 12709
		private static readonly IntPtr NativeFieldInfoPtr_PRrectangularMap;

		// Token: 0x040031A6 RID: 12710
		private static readonly IntPtr NativeFieldInfoPtr_PRisLowerBound;

		// Token: 0x040031A7 RID: 12711
		private static readonly IntPtr NativeFieldInfoPtr_PRtopId;

		// Token: 0x040031A8 RID: 12712
		private static readonly IntPtr NativeFieldInfoPtr_PRheaderId;

		// Token: 0x040031A9 RID: 12713
		private static readonly IntPtr NativeFieldInfoPtr_PRobjectInfo;

		// Token: 0x040031AA RID: 12714
		private static readonly IntPtr NativeFieldInfoPtr_PRisValueTypeFixup;

		// Token: 0x040031AB RID: 12715
		private static readonly IntPtr NativeFieldInfoPtr_PRnewObj;

		// Token: 0x040031AC RID: 12716
		private static readonly IntPtr NativeFieldInfoPtr_PRobjectA;

		// Token: 0x040031AD RID: 12717
		private static readonly IntPtr NativeFieldInfoPtr_PRprimitiveArray;

		// Token: 0x040031AE RID: 12718
		private static readonly IntPtr NativeFieldInfoPtr_PRisRegistered;

		// Token: 0x040031AF RID: 12719
		private static readonly IntPtr NativeFieldInfoPtr_PRmemberData;

		// Token: 0x040031B0 RID: 12720
		private static readonly IntPtr NativeFieldInfoPtr_PRsi;

		// Token: 0x040031B1 RID: 12721
		private static readonly IntPtr NativeFieldInfoPtr_PRnullCount;

		// Token: 0x040031B2 RID: 12722
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_0;

		// Token: 0x040031B3 RID: 12723
		private static readonly IntPtr NativeMethodInfoPtr_Init_Internal_Void_0;
	}
}
