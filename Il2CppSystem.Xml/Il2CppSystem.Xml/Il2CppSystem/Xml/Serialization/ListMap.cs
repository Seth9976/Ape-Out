using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Xml.Serialization
{
	// Token: 0x020000F2 RID: 242
	public class ListMap : ObjectMap
	{
		// Token: 0x0600144F RID: 5199 RVA: 0x0006A538 File Offset: 0x00068738
		// Note: this type is marked as 'beforefieldinit'.
		static ListMap()
		{
			Il2CppClassPointerStore<ListMap>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Xml.dll", "System.Xml.Serialization", "ListMap");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ListMap>.NativeClassPtr);
			ListMap.NativeFieldInfoPtr__itemInfo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ListMap>.NativeClassPtr, "_itemInfo");
			ListMap.NativeFieldInfoPtr__choiceMember = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ListMap>.NativeClassPtr, "_choiceMember");
			ListMap.NativeMethodInfoPtr_set_ChoiceMember_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ListMap>.NativeClassPtr, 100666416);
			ListMap.NativeMethodInfoPtr_get_ItemInfo_Public_get_XmlTypeMapElementInfoList_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ListMap>.NativeClassPtr, 100666417);
			ListMap.NativeMethodInfoPtr_set_ItemInfo_Public_set_Void_XmlTypeMapElementInfoList_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ListMap>.NativeClassPtr, 100666418);
			ListMap.NativeMethodInfoPtr_FindElement_Public_XmlTypeMapElementInfo_Object_Int32_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ListMap>.NativeClassPtr, 100666419);
			ListMap.NativeMethodInfoPtr_GetArrayType_Public_Void_Int32_byref_String_byref_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ListMap>.NativeClassPtr, 100666420);
			ListMap.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ListMap>.NativeClassPtr, 100666421);
			ListMap.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ListMap>.NativeClassPtr, 100666422);
			ListMap.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ListMap>.NativeClassPtr, 100666423);
		}

		// Token: 0x170006C9 RID: 1737
		// (set) Token: 0x06001450 RID: 5200 RVA: 0x0006A630 File Offset: 0x00068830
		public unsafe string ChoiceMember
		{
			[CallerCount(58)]
			[CachedScanResults(RefRangeStart = 18562, RefRangeEnd = 18620, XrefRangeStart = 18562, XrefRangeEnd = 18620, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ListMap.NativeMethodInfoPtr_set_ChoiceMember_Public_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170006CA RID: 1738
		// (get) Token: 0x06001451 RID: 5201 RVA: 0x0006A674 File Offset: 0x00068874
		// (set) Token: 0x06001452 RID: 5202 RVA: 0x0006A6B4 File Offset: 0x000688B4
		public unsafe XmlTypeMapElementInfoList ItemInfo
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ListMap.NativeMethodInfoPtr_get_ItemInfo_Public_get_XmlTypeMapElementInfoList_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlTypeMapElementInfoList>(intPtr3) : null;
			}
			[CallerCount(79)]
			[CachedScanResults(RefRangeStart = 14237, RefRangeEnd = 14316, XrefRangeStart = 14237, XrefRangeEnd = 14316, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ListMap.NativeMethodInfoPtr_set_ItemInfo_Public_set_Void_XmlTypeMapElementInfoList_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06001453 RID: 5203 RVA: 0x0006A6F8 File Offset: 0x000688F8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 407815, RefRangeEnd = 407817, XrefRangeStart = 407795, XrefRangeEnd = 407815, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XmlTypeMapElementInfo FindElement(Object ob, int index, Object memberValue)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(ob);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref index;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(memberValue);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ListMap.NativeMethodInfoPtr_FindElement_Public_XmlTypeMapElementInfo_Object_Int32_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlTypeMapElementInfo>(intPtr3) : null;
		}

		// Token: 0x06001454 RID: 5204 RVA: 0x0006A768 File Offset: 0x00068968
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 407835, RefRangeEnd = 407836, XrefRangeStart = 407817, XrefRangeEnd = 407835, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void GetArrayType(int itemCount, out string localName, out string ns)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref itemCount;
			}
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			ref IntPtr ptr3 = ref ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr2 = 0;
			ptr3 = &intPtr2;
			IntPtr intPtr4;
			IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(ListMap.NativeMethodInfoPtr_GetArrayType_Public_Void_Int32_byref_String_byref_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr4);
			Il2CppException.RaiseExceptionIfNecessary(intPtr4);
			localName = IL2CPP.Il2CppStringToManaged(intPtr);
			ns = IL2CPP.Il2CppStringToManaged(intPtr2);
		}

		// Token: 0x06001455 RID: 5205 RVA: 0x0006A7DC File Offset: 0x000689DC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 407836, XrefRangeEnd = 407840, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Equals(Object other)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(other);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ListMap.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001456 RID: 5206 RVA: 0x0006A834 File Offset: 0x00068A34
		[CallerCount(0)]
		public unsafe override int GetHashCode()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ListMap.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001457 RID: 5207 RVA: 0x0006A87C File Offset: 0x00068A7C
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ListMap()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ListMap>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ListMap.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001458 RID: 5208 RVA: 0x00009134 File Offset: 0x00007334
		public ListMap(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170006C7 RID: 1735
		// (get) Token: 0x06001459 RID: 5209 RVA: 0x0006A8B8 File Offset: 0x00068AB8
		// (set) Token: 0x0600145A RID: 5210 RVA: 0x0000913D File Offset: 0x0000733D
		public unsafe XmlTypeMapElementInfoList _itemInfo
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListMap.NativeFieldInfoPtr__itemInfo);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlTypeMapElementInfoList>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListMap.NativeFieldInfoPtr__itemInfo), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170006C8 RID: 1736
		// (get) Token: 0x0600145B RID: 5211 RVA: 0x0006A8E8 File Offset: 0x00068AE8
		// (set) Token: 0x0600145C RID: 5212 RVA: 0x0000915C File Offset: 0x0000735C
		public unsafe string _choiceMember
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListMap.NativeFieldInfoPtr__choiceMember);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListMap.NativeFieldInfoPtr__choiceMember), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x04000FA7 RID: 4007
		private static readonly IntPtr NativeFieldInfoPtr__itemInfo;

		// Token: 0x04000FA8 RID: 4008
		private static readonly IntPtr NativeFieldInfoPtr__choiceMember;

		// Token: 0x04000FA9 RID: 4009
		private static readonly IntPtr NativeMethodInfoPtr_set_ChoiceMember_Public_set_Void_String_0;

		// Token: 0x04000FAA RID: 4010
		private static readonly IntPtr NativeMethodInfoPtr_get_ItemInfo_Public_get_XmlTypeMapElementInfoList_0;

		// Token: 0x04000FAB RID: 4011
		private static readonly IntPtr NativeMethodInfoPtr_set_ItemInfo_Public_set_Void_XmlTypeMapElementInfoList_0;

		// Token: 0x04000FAC RID: 4012
		private static readonly IntPtr NativeMethodInfoPtr_FindElement_Public_XmlTypeMapElementInfo_Object_Int32_Object_0;

		// Token: 0x04000FAD RID: 4013
		private static readonly IntPtr NativeMethodInfoPtr_GetArrayType_Public_Void_Int32_byref_String_byref_String_0;

		// Token: 0x04000FAE RID: 4014
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

		// Token: 0x04000FAF RID: 4015
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

		// Token: 0x04000FB0 RID: 4016
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
