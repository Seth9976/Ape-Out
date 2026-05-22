using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Runtime.Serialization.Formatters.Binary
{
	// Token: 0x02000389 RID: 905
	public sealed class NameInfo : Object
	{
		// Token: 0x06003BDB RID: 15323 RVA: 0x0011D60C File Offset: 0x0011B80C
		// Note: this type is marked as 'beforefieldinit'.
		static NameInfo()
		{
			Il2CppClassPointerStore<NameInfo>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Runtime.Serialization.Formatters.Binary", "NameInfo");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NameInfo>.NativeClassPtr);
			NameInfo.NativeFieldInfoPtr_NIFullName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NameInfo>.NativeClassPtr, "NIFullName");
			NameInfo.NativeFieldInfoPtr_NIobjectId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NameInfo>.NativeClassPtr, "NIobjectId");
			NameInfo.NativeFieldInfoPtr_NIassemId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NameInfo>.NativeClassPtr, "NIassemId");
			NameInfo.NativeFieldInfoPtr_NIprimitiveTypeEnum = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NameInfo>.NativeClassPtr, "NIprimitiveTypeEnum");
			NameInfo.NativeFieldInfoPtr_NItype = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NameInfo>.NativeClassPtr, "NItype");
			NameInfo.NativeFieldInfoPtr_NIisSealed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NameInfo>.NativeClassPtr, "NIisSealed");
			NameInfo.NativeFieldInfoPtr_NIisArray = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NameInfo>.NativeClassPtr, "NIisArray");
			NameInfo.NativeFieldInfoPtr_NIisArrayItem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NameInfo>.NativeClassPtr, "NIisArrayItem");
			NameInfo.NativeFieldInfoPtr_NItransmitTypeOnObject = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NameInfo>.NativeClassPtr, "NItransmitTypeOnObject");
			NameInfo.NativeFieldInfoPtr_NItransmitTypeOnMember = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NameInfo>.NativeClassPtr, "NItransmitTypeOnMember");
			NameInfo.NativeFieldInfoPtr_NIisParentTypeOnObject = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NameInfo>.NativeClassPtr, "NIisParentTypeOnObject");
			NameInfo.NativeFieldInfoPtr_NIarrayEnum = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NameInfo>.NativeClassPtr, "NIarrayEnum");
			NameInfo.NativeFieldInfoPtr_NIsealedStatusChecked = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NameInfo>.NativeClassPtr, "NIsealedStatusChecked");
			NameInfo.NativeMethodInfoPtr__ctor_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NameInfo>.NativeClassPtr, 100672237);
			NameInfo.NativeMethodInfoPtr_Init_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NameInfo>.NativeClassPtr, 100672238);
			NameInfo.NativeMethodInfoPtr_get_IsSealed_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NameInfo>.NativeClassPtr, 100672239);
			NameInfo.NativeMethodInfoPtr_get_NIname_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NameInfo>.NativeClassPtr, 100672240);
			NameInfo.NativeMethodInfoPtr_set_NIname_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NameInfo>.NativeClassPtr, 100672241);
		}

		// Token: 0x06003BDC RID: 15324 RVA: 0x0011D7A4 File Offset: 0x0011B9A4
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe NameInfo()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NameInfo>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NameInfo.NativeMethodInfoPtr__ctor_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003BDD RID: 15325 RVA: 0x0011D7E0 File Offset: 0x0011B9E0
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 219002, RefRangeEnd = 219010, XrefRangeStart = 219002, XrefRangeEnd = 219002, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Init()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NameInfo.NativeMethodInfoPtr_Init_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000EE1 RID: 3809
		// (get) Token: 0x06003BDE RID: 15326 RVA: 0x0011D814 File Offset: 0x0011BA14
		public unsafe bool IsSealed
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NameInfo.NativeMethodInfoPtr_get_IsSealed_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000EE2 RID: 3810
		// (get) Token: 0x06003BDF RID: 15327 RVA: 0x0011D850 File Offset: 0x0011BA50
		// (set) Token: 0x06003BE0 RID: 15328 RVA: 0x0011D888 File Offset: 0x0011BA88
		public unsafe string NIname
		{
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 219010, RefRangeEnd = 219014, XrefRangeStart = 219010, XrefRangeEnd = 219010, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NameInfo.NativeMethodInfoPtr_get_NIname_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			[CallerCount(79)]
			[CachedScanResults(RefRangeStart = 14237, RefRangeEnd = 14316, XrefRangeStart = 14237, XrefRangeEnd = 14316, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NameInfo.NativeMethodInfoPtr_set_NIname_Public_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06003BE1 RID: 15329 RVA: 0x00016385 File Offset: 0x00014585
		public NameInfo(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000ED4 RID: 3796
		// (get) Token: 0x06003BE2 RID: 15330 RVA: 0x0011D8CC File Offset: 0x0011BACC
		// (set) Token: 0x06003BE3 RID: 15331 RVA: 0x0001638E File Offset: 0x0001458E
		public unsafe string NIFullName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NameInfo.NativeFieldInfoPtr_NIFullName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NameInfo.NativeFieldInfoPtr_NIFullName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000ED5 RID: 3797
		// (get) Token: 0x06003BE4 RID: 15332 RVA: 0x0011D8F4 File Offset: 0x0011BAF4
		// (set) Token: 0x06003BE5 RID: 15333 RVA: 0x000163AD File Offset: 0x000145AD
		public unsafe long NIobjectId
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NameInfo.NativeFieldInfoPtr_NIobjectId);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NameInfo.NativeFieldInfoPtr_NIobjectId)) = value;
			}
		}

		// Token: 0x17000ED6 RID: 3798
		// (get) Token: 0x06003BE6 RID: 15334 RVA: 0x0011D91C File Offset: 0x0011BB1C
		// (set) Token: 0x06003BE7 RID: 15335 RVA: 0x000163C8 File Offset: 0x000145C8
		public unsafe long NIassemId
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NameInfo.NativeFieldInfoPtr_NIassemId);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NameInfo.NativeFieldInfoPtr_NIassemId)) = value;
			}
		}

		// Token: 0x17000ED7 RID: 3799
		// (get) Token: 0x06003BE8 RID: 15336 RVA: 0x0011D944 File Offset: 0x0011BB44
		// (set) Token: 0x06003BE9 RID: 15337 RVA: 0x000163E3 File Offset: 0x000145E3
		public unsafe InternalPrimitiveTypeE NIprimitiveTypeEnum
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NameInfo.NativeFieldInfoPtr_NIprimitiveTypeEnum);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NameInfo.NativeFieldInfoPtr_NIprimitiveTypeEnum)) = value;
			}
		}

		// Token: 0x17000ED8 RID: 3800
		// (get) Token: 0x06003BEA RID: 15338 RVA: 0x0011D96C File Offset: 0x0011BB6C
		// (set) Token: 0x06003BEB RID: 15339 RVA: 0x000163FE File Offset: 0x000145FE
		public unsafe Type NItype
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NameInfo.NativeFieldInfoPtr_NItype);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Type>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NameInfo.NativeFieldInfoPtr_NItype), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000ED9 RID: 3801
		// (get) Token: 0x06003BEC RID: 15340 RVA: 0x0011D99C File Offset: 0x0011BB9C
		// (set) Token: 0x06003BED RID: 15341 RVA: 0x0001641D File Offset: 0x0001461D
		public unsafe bool NIisSealed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NameInfo.NativeFieldInfoPtr_NIisSealed);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NameInfo.NativeFieldInfoPtr_NIisSealed)) = value;
			}
		}

		// Token: 0x17000EDA RID: 3802
		// (get) Token: 0x06003BEE RID: 15342 RVA: 0x0011D9C4 File Offset: 0x0011BBC4
		// (set) Token: 0x06003BEF RID: 15343 RVA: 0x00016438 File Offset: 0x00014638
		public unsafe bool NIisArray
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NameInfo.NativeFieldInfoPtr_NIisArray);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NameInfo.NativeFieldInfoPtr_NIisArray)) = value;
			}
		}

		// Token: 0x17000EDB RID: 3803
		// (get) Token: 0x06003BF0 RID: 15344 RVA: 0x0011D9EC File Offset: 0x0011BBEC
		// (set) Token: 0x06003BF1 RID: 15345 RVA: 0x00016453 File Offset: 0x00014653
		public unsafe bool NIisArrayItem
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NameInfo.NativeFieldInfoPtr_NIisArrayItem);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NameInfo.NativeFieldInfoPtr_NIisArrayItem)) = value;
			}
		}

		// Token: 0x17000EDC RID: 3804
		// (get) Token: 0x06003BF2 RID: 15346 RVA: 0x0011DA14 File Offset: 0x0011BC14
		// (set) Token: 0x06003BF3 RID: 15347 RVA: 0x0001646E File Offset: 0x0001466E
		public unsafe bool NItransmitTypeOnObject
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NameInfo.NativeFieldInfoPtr_NItransmitTypeOnObject);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NameInfo.NativeFieldInfoPtr_NItransmitTypeOnObject)) = value;
			}
		}

		// Token: 0x17000EDD RID: 3805
		// (get) Token: 0x06003BF4 RID: 15348 RVA: 0x0011DA3C File Offset: 0x0011BC3C
		// (set) Token: 0x06003BF5 RID: 15349 RVA: 0x00016489 File Offset: 0x00014689
		public unsafe bool NItransmitTypeOnMember
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NameInfo.NativeFieldInfoPtr_NItransmitTypeOnMember);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NameInfo.NativeFieldInfoPtr_NItransmitTypeOnMember)) = value;
			}
		}

		// Token: 0x17000EDE RID: 3806
		// (get) Token: 0x06003BF6 RID: 15350 RVA: 0x0011DA64 File Offset: 0x0011BC64
		// (set) Token: 0x06003BF7 RID: 15351 RVA: 0x000164A4 File Offset: 0x000146A4
		public unsafe bool NIisParentTypeOnObject
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NameInfo.NativeFieldInfoPtr_NIisParentTypeOnObject);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NameInfo.NativeFieldInfoPtr_NIisParentTypeOnObject)) = value;
			}
		}

		// Token: 0x17000EDF RID: 3807
		// (get) Token: 0x06003BF8 RID: 15352 RVA: 0x0011DA8C File Offset: 0x0011BC8C
		// (set) Token: 0x06003BF9 RID: 15353 RVA: 0x000164BF File Offset: 0x000146BF
		public unsafe InternalArrayTypeE NIarrayEnum
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NameInfo.NativeFieldInfoPtr_NIarrayEnum);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NameInfo.NativeFieldInfoPtr_NIarrayEnum)) = value;
			}
		}

		// Token: 0x17000EE0 RID: 3808
		// (get) Token: 0x06003BFA RID: 15354 RVA: 0x0011DAB4 File Offset: 0x0011BCB4
		// (set) Token: 0x06003BFB RID: 15355 RVA: 0x000164DA File Offset: 0x000146DA
		public unsafe bool NIsealedStatusChecked
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NameInfo.NativeFieldInfoPtr_NIsealedStatusChecked);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NameInfo.NativeFieldInfoPtr_NIsealedStatusChecked)) = value;
			}
		}

		// Token: 0x040031E4 RID: 12772
		private static readonly IntPtr NativeFieldInfoPtr_NIFullName;

		// Token: 0x040031E5 RID: 12773
		private static readonly IntPtr NativeFieldInfoPtr_NIobjectId;

		// Token: 0x040031E6 RID: 12774
		private static readonly IntPtr NativeFieldInfoPtr_NIassemId;

		// Token: 0x040031E7 RID: 12775
		private static readonly IntPtr NativeFieldInfoPtr_NIprimitiveTypeEnum;

		// Token: 0x040031E8 RID: 12776
		private static readonly IntPtr NativeFieldInfoPtr_NItype;

		// Token: 0x040031E9 RID: 12777
		private static readonly IntPtr NativeFieldInfoPtr_NIisSealed;

		// Token: 0x040031EA RID: 12778
		private static readonly IntPtr NativeFieldInfoPtr_NIisArray;

		// Token: 0x040031EB RID: 12779
		private static readonly IntPtr NativeFieldInfoPtr_NIisArrayItem;

		// Token: 0x040031EC RID: 12780
		private static readonly IntPtr NativeFieldInfoPtr_NItransmitTypeOnObject;

		// Token: 0x040031ED RID: 12781
		private static readonly IntPtr NativeFieldInfoPtr_NItransmitTypeOnMember;

		// Token: 0x040031EE RID: 12782
		private static readonly IntPtr NativeFieldInfoPtr_NIisParentTypeOnObject;

		// Token: 0x040031EF RID: 12783
		private static readonly IntPtr NativeFieldInfoPtr_NIarrayEnum;

		// Token: 0x040031F0 RID: 12784
		private static readonly IntPtr NativeFieldInfoPtr_NIsealedStatusChecked;

		// Token: 0x040031F1 RID: 12785
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_0;

		// Token: 0x040031F2 RID: 12786
		private static readonly IntPtr NativeMethodInfoPtr_Init_Internal_Void_0;

		// Token: 0x040031F3 RID: 12787
		private static readonly IntPtr NativeMethodInfoPtr_get_IsSealed_Public_get_Boolean_0;

		// Token: 0x040031F4 RID: 12788
		private static readonly IntPtr NativeMethodInfoPtr_get_NIname_Public_get_String_0;

		// Token: 0x040031F5 RID: 12789
		private static readonly IntPtr NativeMethodInfoPtr_set_NIname_Public_set_Void_String_0;
	}
}
