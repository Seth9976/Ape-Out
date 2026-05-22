using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Runtime.Serialization.Formatters.Binary
{
	// Token: 0x02000379 RID: 889
	public sealed class ObjectMapInfo : Object
	{
		// Token: 0x06003992 RID: 14738 RVA: 0x001159D4 File Offset: 0x00113BD4
		// Note: this type is marked as 'beforefieldinit'.
		static ObjectMapInfo()
		{
			Il2CppClassPointerStore<ObjectMapInfo>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Runtime.Serialization.Formatters.Binary", "ObjectMapInfo");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ObjectMapInfo>.NativeClassPtr);
			ObjectMapInfo.NativeFieldInfoPtr_objectId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectMapInfo>.NativeClassPtr, "objectId");
			ObjectMapInfo.NativeFieldInfoPtr_numMembers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectMapInfo>.NativeClassPtr, "numMembers");
			ObjectMapInfo.NativeFieldInfoPtr_memberNames = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectMapInfo>.NativeClassPtr, "memberNames");
			ObjectMapInfo.NativeFieldInfoPtr_memberTypes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectMapInfo>.NativeClassPtr, "memberTypes");
			ObjectMapInfo.NativeMethodInfoPtr__ctor_Internal_Void_Int32_Int32_Il2CppStringArray_Il2CppReferenceArray_1_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectMapInfo>.NativeClassPtr, 100672044);
			ObjectMapInfo.NativeMethodInfoPtr_isCompatible_Internal_Boolean_Int32_Il2CppStringArray_Il2CppReferenceArray_1_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectMapInfo>.NativeClassPtr, 100672045);
		}

		// Token: 0x06003993 RID: 14739 RVA: 0x00115A7C File Offset: 0x00113C7C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 91989, RefRangeEnd = 91990, XrefRangeStart = 91989, XrefRangeEnd = 91990, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ObjectMapInfo(int objectId, int numMembers, Il2CppStringArray memberNames, Il2CppReferenceArray<Type> memberTypes)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ObjectMapInfo>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref objectId;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref numMembers;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(memberNames);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(memberTypes);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectMapInfo.NativeMethodInfoPtr__ctor_Internal_Void_Int32_Int32_Il2CppStringArray_Il2CppReferenceArray_1_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003994 RID: 14740 RVA: 0x00115AF8 File Offset: 0x00113CF8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 216813, RefRangeEnd = 216814, XrefRangeStart = 216812, XrefRangeEnd = 216813, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool isCompatible(int numMembers, Il2CppStringArray memberNames, Il2CppReferenceArray<Type> memberTypes)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref numMembers;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(memberNames);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(memberTypes);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectMapInfo.NativeMethodInfoPtr_isCompatible_Internal_Boolean_Int32_Il2CppStringArray_Il2CppReferenceArray_1_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06003995 RID: 14741 RVA: 0x00014DCA File Offset: 0x00012FCA
		public ObjectMapInfo(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000E11 RID: 3601
		// (get) Token: 0x06003996 RID: 14742 RVA: 0x00115B68 File Offset: 0x00113D68
		// (set) Token: 0x06003997 RID: 14743 RVA: 0x00014DD3 File Offset: 0x00012FD3
		public unsafe int objectId
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectMapInfo.NativeFieldInfoPtr_objectId);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectMapInfo.NativeFieldInfoPtr_objectId)) = value;
			}
		}

		// Token: 0x17000E12 RID: 3602
		// (get) Token: 0x06003998 RID: 14744 RVA: 0x00115B90 File Offset: 0x00113D90
		// (set) Token: 0x06003999 RID: 14745 RVA: 0x00014DEE File Offset: 0x00012FEE
		public unsafe int numMembers
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectMapInfo.NativeFieldInfoPtr_numMembers);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectMapInfo.NativeFieldInfoPtr_numMembers)) = value;
			}
		}

		// Token: 0x17000E13 RID: 3603
		// (get) Token: 0x0600399A RID: 14746 RVA: 0x00115BB8 File Offset: 0x00113DB8
		// (set) Token: 0x0600399B RID: 14747 RVA: 0x00014E09 File Offset: 0x00013009
		public unsafe Il2CppStringArray memberNames
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectMapInfo.NativeFieldInfoPtr_memberNames);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectMapInfo.NativeFieldInfoPtr_memberNames), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000E14 RID: 3604
		// (get) Token: 0x0600399C RID: 14748 RVA: 0x00115BE8 File Offset: 0x00113DE8
		// (set) Token: 0x0600399D RID: 14749 RVA: 0x00014E28 File Offset: 0x00013028
		public unsafe Il2CppReferenceArray<Type> memberTypes
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectMapInfo.NativeFieldInfoPtr_memberTypes);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Type>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectMapInfo.NativeFieldInfoPtr_memberTypes), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04003072 RID: 12402
		private static readonly IntPtr NativeFieldInfoPtr_objectId;

		// Token: 0x04003073 RID: 12403
		private static readonly IntPtr NativeFieldInfoPtr_numMembers;

		// Token: 0x04003074 RID: 12404
		private static readonly IntPtr NativeFieldInfoPtr_memberNames;

		// Token: 0x04003075 RID: 12405
		private static readonly IntPtr NativeFieldInfoPtr_memberTypes;

		// Token: 0x04003076 RID: 12406
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_Int32_Int32_Il2CppStringArray_Il2CppReferenceArray_1_Type_0;

		// Token: 0x04003077 RID: 12407
		private static readonly IntPtr NativeMethodInfoPtr_isCompatible_Internal_Boolean_Int32_Il2CppStringArray_Il2CppReferenceArray_1_Type_0;
	}
}
