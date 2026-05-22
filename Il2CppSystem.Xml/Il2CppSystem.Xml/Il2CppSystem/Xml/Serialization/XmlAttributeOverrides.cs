using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections;

namespace Il2CppSystem.Xml.Serialization
{
	// Token: 0x020000CA RID: 202
	public class XmlAttributeOverrides : Object
	{
		// Token: 0x060011CA RID: 4554 RVA: 0x00060BC0 File Offset: 0x0005EDC0
		// Note: this type is marked as 'beforefieldinit'.
		static XmlAttributeOverrides()
		{
			Il2CppClassPointerStore<XmlAttributeOverrides>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Xml.dll", "System.Xml.Serialization", "XmlAttributeOverrides");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<XmlAttributeOverrides>.NativeClassPtr);
			XmlAttributeOverrides.NativeFieldInfoPtr_overrides = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlAttributeOverrides>.NativeClassPtr, "overrides");
			XmlAttributeOverrides.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlAttributeOverrides>.NativeClassPtr, 100666109);
			XmlAttributeOverrides.NativeMethodInfoPtr_get_Item_Public_get_XmlAttributes_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlAttributeOverrides>.NativeClassPtr, 100666110);
			XmlAttributeOverrides.NativeMethodInfoPtr_get_Item_Public_get_XmlAttributes_Type_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlAttributeOverrides>.NativeClassPtr, 100666111);
			XmlAttributeOverrides.NativeMethodInfoPtr_GetKey_Private_TypeMember_Type_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlAttributeOverrides>.NativeClassPtr, 100666112);
		}

		// Token: 0x060011CB RID: 4555 RVA: 0x00060C54 File Offset: 0x0005EE54
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 404765, XrefRangeEnd = 404769, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XmlAttributeOverrides()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<XmlAttributeOverrides>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlAttributeOverrides.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x170005DC RID: 1500
		public unsafe XmlAttributes this[Type type]
		{
			[CallerCount(6)]
			[CachedScanResults(RefRangeStart = 404772, RefRangeEnd = 404778, XrefRangeStart = 404769, XrefRangeEnd = 404772, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlAttributeOverrides.NativeMethodInfoPtr_get_Item_Public_get_XmlAttributes_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlAttributes>(intPtr3) : null;
				}
			}
		}

		// Token: 0x170005DD RID: 1501
		public unsafe XmlAttributes this[Type type, string member]
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 404783, RefRangeEnd = 404786, XrefRangeStart = 404778, XrefRangeEnd = 404783, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(member);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlAttributeOverrides.NativeMethodInfoPtr_get_Item_Public_get_XmlAttributes_Type_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlAttributes>(intPtr3) : null;
			}
		}

		// Token: 0x060011CE RID: 4558 RVA: 0x00060D44 File Offset: 0x0005EF44
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 404786, XrefRangeEnd = 404789, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TypeMember GetKey(Type type, string member)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(member);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlAttributeOverrides.NativeMethodInfoPtr_GetKey_Private_TypeMember_Type_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<TypeMember>(intPtr3) : null;
		}

		// Token: 0x060011CF RID: 4559 RVA: 0x00007E84 File Offset: 0x00006084
		public XmlAttributeOverrides(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170005DB RID: 1499
		// (get) Token: 0x060011D0 RID: 4560 RVA: 0x00060DA8 File Offset: 0x0005EFA8
		// (set) Token: 0x060011D1 RID: 4561 RVA: 0x00007E8D File Offset: 0x0000608D
		public unsafe Hashtable overrides
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlAttributeOverrides.NativeFieldInfoPtr_overrides);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Hashtable>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlAttributeOverrides.NativeFieldInfoPtr_overrides), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000DF6 RID: 3574
		private static readonly IntPtr NativeFieldInfoPtr_overrides;

		// Token: 0x04000DF7 RID: 3575
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04000DF8 RID: 3576
		private static readonly IntPtr NativeMethodInfoPtr_get_Item_Public_get_XmlAttributes_Type_0;

		// Token: 0x04000DF9 RID: 3577
		private static readonly IntPtr NativeMethodInfoPtr_get_Item_Public_get_XmlAttributes_Type_String_0;

		// Token: 0x04000DFA RID: 3578
		private static readonly IntPtr NativeMethodInfoPtr_GetKey_Private_TypeMember_Type_String_0;
	}
}
