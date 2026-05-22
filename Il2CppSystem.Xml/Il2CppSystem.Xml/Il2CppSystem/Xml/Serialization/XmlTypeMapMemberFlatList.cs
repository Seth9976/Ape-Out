using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Xml.Serialization
{
	// Token: 0x020000EB RID: 235
	public class XmlTypeMapMemberFlatList : XmlTypeMapMemberExpandable
	{
		// Token: 0x060013E2 RID: 5090 RVA: 0x00068F80 File Offset: 0x00067180
		// Note: this type is marked as 'beforefieldinit'.
		static XmlTypeMapMemberFlatList()
		{
			Il2CppClassPointerStore<XmlTypeMapMemberFlatList>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Xml.dll", "System.Xml.Serialization", "XmlTypeMapMemberFlatList");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<XmlTypeMapMemberFlatList>.NativeClassPtr);
			XmlTypeMapMemberFlatList.NativeFieldInfoPtr__listMap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlTypeMapMemberFlatList>.NativeClassPtr, "_listMap");
			XmlTypeMapMemberFlatList.NativeMethodInfoPtr_get_ListMap_Public_get_ListMap_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTypeMapMemberFlatList>.NativeClassPtr, 100666377);
			XmlTypeMapMemberFlatList.NativeMethodInfoPtr_set_ListMap_Public_set_Void_ListMap_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTypeMapMemberFlatList>.NativeClassPtr, 100666378);
			XmlTypeMapMemberFlatList.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTypeMapMemberFlatList>.NativeClassPtr, 100666379);
		}

		// Token: 0x17000698 RID: 1688
		// (get) Token: 0x060013E3 RID: 5091 RVA: 0x00069000 File Offset: 0x00067200
		// (set) Token: 0x060013E4 RID: 5092 RVA: 0x00069040 File Offset: 0x00067240
		public unsafe ListMap ListMap
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTypeMapMemberFlatList.NativeMethodInfoPtr_get_ListMap_Public_get_ListMap_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ListMap>(intPtr3) : null;
			}
			[CallerCount(10)]
			[CachedScanResults(RefRangeStart = 382561, RefRangeEnd = 382571, XrefRangeStart = 382561, XrefRangeEnd = 382571, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTypeMapMemberFlatList.NativeMethodInfoPtr_set_ListMap_Public_set_Void_ListMap_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x060013E5 RID: 5093 RVA: 0x00069084 File Offset: 0x00067284
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XmlTypeMapMemberFlatList()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<XmlTypeMapMemberFlatList>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTypeMapMemberFlatList.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060013E6 RID: 5094 RVA: 0x00008D37 File Offset: 0x00006F37
		public XmlTypeMapMemberFlatList(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000697 RID: 1687
		// (get) Token: 0x060013E7 RID: 5095 RVA: 0x000690C0 File Offset: 0x000672C0
		// (set) Token: 0x060013E8 RID: 5096 RVA: 0x00008D40 File Offset: 0x00006F40
		public unsafe ListMap _listMap
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTypeMapMemberFlatList.NativeFieldInfoPtr__listMap);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ListMap>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTypeMapMemberFlatList.NativeFieldInfoPtr__listMap), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000F64 RID: 3940
		private static readonly IntPtr NativeFieldInfoPtr__listMap;

		// Token: 0x04000F65 RID: 3941
		private static readonly IntPtr NativeMethodInfoPtr_get_ListMap_Public_get_ListMap_0;

		// Token: 0x04000F66 RID: 3942
		private static readonly IntPtr NativeMethodInfoPtr_set_ListMap_Public_set_Void_ListMap_0;

		// Token: 0x04000F67 RID: 3943
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
